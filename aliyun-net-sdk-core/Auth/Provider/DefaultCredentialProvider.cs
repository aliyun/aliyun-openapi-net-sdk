/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections;
using System.IO;

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;

using SharpConfig;

namespace Aliyun.Acs.Core.Auth.Provider
{
    public class DefaultCredentialProvider
    {
        private readonly string ENV_ACCESS_KEY_ID = "ALIBABA_CLOUD_ACCESS_KEY_ID";
        private readonly string ENV_ACCESS_KEY_SECRET = "ALIBABA_CLOUD_ACCESS_KEY_SECRET";
        private readonly string ENV_REGION_ID = "ALIBABA_CLOUD_REGION_ID";
        private readonly string ENV_CREDENTIAL_FILE = "ALIBABA_CLOUD_CREDENTIALS_FILE";
        private readonly string ENV_ROLE_NAME = "ALIBABA_CLOUD_ECS_METADATA";

        private IClientProfile defaultProfile;

        private string accessKeyId;
        private string accessKeySecret;
        private string regionId;
        private string credentialFileLocation;
        private string roleName;
        private string roleArn;
        private string roleSessionName;
        private string publicKeyId;
        private string privateKeyFile;

        private readonly AlibabaCloudCredentialsProvider alibabaCloudCredentialProvider;

        public DefaultCredentialProvider() { }

        public DefaultCredentialProvider(IClientProfile profile,
            AlibabaCloudCredentialsProvider alibabaCloudCredentialProvider)
        {
            accessKeyId = GetEnvironmentAccessKeyId();
            accessKeySecret = GetEnvironmentAccessKeySecret();
            regionId = GetEnvironmentRegionId();
            credentialFileLocation = GetEnvironmentCredentialFile();
            roleName = GetEnvironmentRoleName();
            defaultProfile = profile;
            this.alibabaCloudCredentialProvider = alibabaCloudCredentialProvider;
        }

        public DefaultCredentialProvider(IClientProfile profile,
            AlibabaCloudCredentialsProvider alibabaCloudCredentialsProvider,
            string publicKeyId,
            string privateKeyFile)
        {
            defaultProfile = profile;
            this.privateKeyFile = privateKeyFile;
            this.publicKeyId = publicKeyId;
            alibabaCloudCredentialProvider = alibabaCloudCredentialsProvider;
            regionId = GetEnvironmentRegionId();
        }

        public AlibabaCloudCredentials GetAlibabaCloudClientCredential()
        {
            var credential = GetEnvironmentAlibabaCloudCredential() ??
                GetCredentialFileAlibabaCloudCredential() ??
                GetInstanceRamRoleAlibabaCloudCredential() ?? null;

            if (credential == null)
                throw new ClientException("There is no credential chain can use");
            return credential;
        }

        public AlibabaCloudCredentials GetEnvironmentAlibabaCloudCredential()
        {
            if (null == accessKeyId || null == accessKeySecret)
            {
                return null;
            }
            else if (accessKeyId.Equals("") || accessKeySecret.Equals(""))
            {
                throw new ClientException("Environment credential variable 'ALIBABA_CLOUD_ACCESS_KEY_*' cannot be empty");
            }
            else
            {
                if (defaultProfile.DefaultClientName.Equals("default"))
                {
                    return GetAccessKeyCredential();
                }
                return null;
            }
        }

        public AlibabaCloudCredentials GetCredentialFileAlibabaCloudCredential()
        {
            if (null == credentialFileLocation)
            {
                credentialFileLocation = GetHomePath();
                var fileLocation = ComposeFileUrl(credentialFileLocation);
                var fileExist = File.Exists(fileLocation);

                if (fileExist)
                {
                    credentialFileLocation = fileLocation;
                }
                else
                {
                    return null;
                }
            }
            if (credentialFileLocation.Equals(""))
            {
                throw new ClientException("Credentials file environment variable 'ALIBABA_CLOUD_CREDENTIALS_FILE' cannot be empty");
            }
            else
            {
                Configuration config;
                try
                {
                    config = LoadFileFromIni(credentialFileLocation);
                }
                catch (Exception)
                {
                    throw new ClientException("Invalid credentials file: " + credentialFileLocation);
                }

                ArrayList sectionNameList = new ArrayList();
                string userDefineSectionNode = "";
                foreach (var sectionName in config)
                {
                    sectionNameList.Add(sectionName.Name);
                }

                if (null != defaultProfile.DefaultClientName)
                {
                    userDefineSectionNode = defaultProfile.DefaultClientName;

                    if (config[userDefineSectionNode]["type"].RawValue.Equals("access_key"))
                    {
                        accessKeyId = config[userDefineSectionNode]["access_key_id"].RawValue;
                        accessKeySecret = config[userDefineSectionNode]["access_key_secret"].RawValue;
                        regionId = config[userDefineSectionNode]["region_id"].RawValue;

                        return GetAccessKeyCredential();
                    }
                    else if (config[userDefineSectionNode]["type"].RawValue.Equals("ecs_ram_role"))
                    {
                        roleName = config[userDefineSectionNode]["role_name"].RawValue;

                        return GetInstanceRamRoleAlibabaCloudCredential();
                    }
                    else if (config[userDefineSectionNode]["type"].RawValue.Equals("ram_role_arn"))
                    {
                        accessKeyId = config[userDefineSectionNode]["access_key_id"].RawValue;
                        accessKeySecret = config[userDefineSectionNode]["access_key_secret"].RawValue;
                        roleArn = config[userDefineSectionNode]["role_arn"].RawValue;
                        roleSessionName = config[userDefineSectionNode]["role_session_name"].RawValue;

                        return GetRamRoleArnAlibabaCloudCredential();
                    }
                    else if (config[userDefineSectionNode]["type"].RawValue.Equals("rsa_key_pair"))
                    {
                        publicKeyId = config[userDefineSectionNode]["public_key_id"].RawValue;
                        privateKeyFile = config[userDefineSectionNode]["private_key_file"].RawValue;

                        return GetRsaKeyPairAlibabaCloudCredential();
                    }
                }
                else
                {
                    foreach (string sectionItem in sectionNameList)
                    {
                        if (sectionItem.Equals("default"))
                        {
                            userDefineSectionNode = "default";
                            accessKeyId = config[userDefineSectionNode]["access_key_id"].RawValue;
                            accessKeySecret = config[userDefineSectionNode]["access_key_secret"].RawValue;
                            regionId = config[userDefineSectionNode]["region_id"].RawValue;

                            return GetAccessKeyCredential();
                        }
                    }
                }
            }
            return null;
        }

        public virtual AlibabaCloudCredentials GetInstanceRamRoleAlibabaCloudCredential()
        {
            if (null == regionId || regionId.Equals(""))
            {
                throw new ClientException("RegionID cannot be null or empty.");
            }
            else
            {
                if (defaultProfile.DefaultClientName.Equals("default"))
                {
                    var eCSMetadataServiceCredentialsFetcher = (ECSMetadataServiceCredentialsFetcher) alibabaCloudCredentialProvider;
                    eCSMetadataServiceCredentialsFetcher.SetRoleName(roleName);
                    var ecsInstanceCredential = eCSMetadataServiceCredentialsFetcher.Fetch();

                    return ecsInstanceCredential;
                }
            }
            return null;
        }

        private AlibabaCloudCredentials GetAccessKeyCredential()
        {
            if (String.IsNullOrEmpty(accessKeyId) && String.IsNullOrEmpty(accessKeySecret) && String.IsNullOrEmpty(regionId))
            {
                throw new ClientException("Missing required variable option for 'default Client'");
            }
            AccessKeyCredential accessKeyCredential = new AccessKeyCredential(accessKeyId, accessKeySecret);

            return accessKeyCredential;
        }

        public virtual AlibabaCloudCredentials GetRamRoleArnAlibabaCloudCredential()
        {
            if (String.IsNullOrEmpty(accessKeyId) && String.IsNullOrEmpty(accessKeySecret) && String.IsNullOrEmpty(regionId))
            {
                throw new ClientException("Missing required variable option for 'default Client'");
            }
            RamRoleArnCredential credential = new RamRoleArnCredential(
                accessKeyId,
                accessKeySecret,
                roleArn,
                roleSessionName,
                STSAssumeRoleSessionCredentialsProvider.GetNewRoleSessionName(),
                STSAssumeRoleSessionCredentialsProvider.DEFAULT_DURATION_SECONDS);
            defaultProfile = DefaultProfile.GetProfile(regionId, accessKeyId, accessKeySecret);

            var sTSAssumeRoleSessionCredentialsProvider = (STSAssumeRoleSessionCredentialsProvider) alibabaCloudCredentialProvider;
            RamRoleArnCredential ramRoleArnCredential = (RamRoleArnCredential) sTSAssumeRoleSessionCredentialsProvider.GetCredentials();

            return ramRoleArnCredential;
        }

        public virtual AlibabaCloudCredentials GetRsaKeyPairAlibabaCloudCredential()
        {
            if (String.IsNullOrEmpty(publicKeyId) || String.IsNullOrEmpty(privateKeyFile) || String.IsNullOrEmpty(regionId))
            {
                throw new ClientException("Missing required variable option for 'default Client'");
            }
            RsaKeyPairCredential rsaKeyPairCredential = new RsaKeyPairCredential(publicKeyId, privateKeyFile);
            DefaultProfile profile = DefaultProfile.GetProfile(regionId, publicKeyId, privateKeyFile);

            var provider = (RsaKeyPairCredentialProvider) alibabaCloudCredentialProvider;
            BasicSessionCredentials basicCrededential = (BasicSessionCredentials) provider.GetCredentials();

            return basicCrededential;
        }

        public virtual string GetHomePath()
        {
            string homePath = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ?
                Environment.GetEnvironmentVariable("HOME") :
                Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            return homePath;
        }

        private string ComposeFileUrl(string path)
        {
            string slash = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ? "/" : "\\";
            return path + slash + ".alibabacloud" + slash + "credentials.ini";
        }

        private string GetEnvironmentAccessKeyId()
        {
            return Environment.GetEnvironmentVariable(ENV_ACCESS_KEY_ID) ?? null;
        }

        private string GetEnvironmentAccessKeySecret()
        {
            return Environment.GetEnvironmentVariable(ENV_ACCESS_KEY_SECRET) ?? null;
        }

        private string GetEnvironmentRegionId()
        {
            return Environment.GetEnvironmentVariable(ENV_REGION_ID) ?? null;
        }

        private string GetEnvironmentCredentialFile()
        {
            return Environment.GetEnvironmentVariable(ENV_CREDENTIAL_FILE) ?? null;
        }

        private string GetEnvironmentRoleName()
        {
            return Environment.GetEnvironmentVariable(ENV_ROLE_NAME) ?? null;
        }

        public virtual Configuration LoadFileFromIni(string location)
        {
            return Configuration.LoadFromFile(location);
        }
    }
}
