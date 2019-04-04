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
using Aliyun.Acs.Core.Utils;

using SharpConfig;

namespace Aliyun.Acs.Core.Auth.Provider
{
    public class DefaultCredentialProvider
    {
        private static IClientProfile defaultProfile;

        private string accessKeyId;
        private string accessKeySecret;
        private string regionId;
        private string credentialFileLocation;
        private string roleName;
        private string roleArn;
        private string publicKeyId;
        private string privateKeyFile;

        private readonly AlibabaCloudCredentialsProvider alibabaCloudCredentialProvider;

        public DefaultCredentialProvider() { }

        public DefaultCredentialProvider(
            IClientProfile profile,
            AlibabaCloudCredentialsProvider alibabaCloudCredentialProvider
        )
        {
            accessKeyId = EnvironmentUtil.GetEnvironmentAccessKeyId();
            accessKeySecret = EnvironmentUtil.GetEnvironmentAccessKeySecret();
            regionId = EnvironmentUtil.GetEnvironmentRegionId();
            credentialFileLocation = EnvironmentUtil.GetEnvironmentCredentialFile();
            roleName = EnvironmentUtil.GetEnvironmentRoleName();
            defaultProfile = profile;
            this.alibabaCloudCredentialProvider = alibabaCloudCredentialProvider;
        }

        public DefaultCredentialProvider(
            IClientProfile profile,
            string publicKeyId,
            string privateKeyFile,
            AlibabaCloudCredentialsProvider alibabaCloudCredentialsProvider
        )
        {
            defaultProfile = profile;
            this.privateKeyFile = privateKeyFile;
            this.publicKeyId = publicKeyId;
            regionId = EnvironmentUtil.GetEnvironmentRegionId();
            alibabaCloudCredentialProvider = alibabaCloudCredentialsProvider;
        }

        public AlibabaCloudCredentials GetAlibabaCloudClientCredential()
        {
            var credential = GetEnvironmentAlibabaCloudCredential() ??
                GetCredentialFileAlibabaCloudCredential() ??
                GetInstanceRamRoleAlibabaCloudCredential();

            if (credential == null)
            {
                throw new ClientException("There is no credential chain can use.");
            }
            return credential;
        }

        public AlibabaCloudCredentials GetEnvironmentAlibabaCloudCredential()
        {
            if (null == accessKeyId || null == accessKeySecret)
            {
                return null;
            }

            if (accessKeyId.Equals("") || accessKeySecret.Equals(""))
            {
                throw new ClientException("Environment credential variable 'ALIBABA_CLOUD_ACCESS_KEY_*' cannot be empty");
            }

            return defaultProfile.DefaultClientName.Equals("default") ? GetAccessKeyCredential() : null;
        }

        public AlibabaCloudCredentials GetCredentialFileAlibabaCloudCredential()
        {
            if (null == credentialFileLocation)
            {
                credentialFileLocation = GetHomePath();
                var slash = EnvironmentUtil.GetOSSlash();
                var fileLocation = EnvironmentUtil.GetComposedPath(credentialFileLocation, slash);

                if (File.Exists(fileLocation))
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
            foreach (var sectionName in config)
            {
                sectionNameList.Add(sectionName.Name);
            }

            if (null != defaultProfile.DefaultClientName)
            {
                string userDefineSectionNode = defaultProfile.DefaultClientName;

                if (config[userDefineSectionNode]["type"].RawValue.Equals("access_key"))
                {
                    accessKeyId = config[userDefineSectionNode]["access_key_id"].RawValue;
                    accessKeySecret = config[userDefineSectionNode]["access_key_secret"].RawValue;
                    regionId = config[userDefineSectionNode]["region_id"].RawValue;

                    return GetAccessKeyCredential();
                }

                if (config[userDefineSectionNode]["type"].RawValue.Equals("ecs_ram_role"))
                {
                    roleName = config[userDefineSectionNode]["role_name"].RawValue;
                    regionId = config[userDefineSectionNode]["region_id"].RawValue;

                    return GetInstanceRamRoleAlibabaCloudCredential();
                }

                if (config[userDefineSectionNode]["type"].RawValue.Equals("ram_role_arn"))
                {
                    accessKeyId = config[userDefineSectionNode]["access_key_id"].RawValue;
                    accessKeySecret = config[userDefineSectionNode]["access_key_secret"].RawValue;
                    roleArn = config[userDefineSectionNode]["role_arn"].RawValue;

                    return GetRamRoleArnAlibabaCloudCredential();
                }

                if (config[userDefineSectionNode]["type"].RawValue.Equals("rsa_key_pair"))
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
                    if (!sectionItem.Equals("default"))
                    {
                        continue;
                    }
                    string userDefineSectionNode = "default";
                    accessKeyId = config[userDefineSectionNode]["access_key_id"].RawValue;
                    accessKeySecret = config[userDefineSectionNode]["access_key_secret"].RawValue;
                    regionId = config[userDefineSectionNode]["region_id"].RawValue;

                    return GetAccessKeyCredential();
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

            if (!defaultProfile.DefaultClientName.Equals("default"))
            {
                return null;
            }

            InstanceProfileCredentialsProvider instanceProfileCredentialProvider;
            if (null != alibabaCloudCredentialProvider)
            {
                instanceProfileCredentialProvider = (InstanceProfileCredentialsProvider) alibabaCloudCredentialProvider;
            }
            else
            {
                instanceProfileCredentialProvider = new InstanceProfileCredentialsProvider(roleName);
            }

            return instanceProfileCredentialProvider.GetCredentials();
        }

        public AlibabaCloudCredentials GetAccessKeyCredential()
        {
            if (String.IsNullOrEmpty(accessKeyId) || String.IsNullOrEmpty(accessKeySecret) || String.IsNullOrEmpty(regionId))
            {
                throw new ClientException("Missing required variable option for 'default Client'");
            }
            var accessKeyCredentialProvider = new AccessKeyCredentialProvider(accessKeyId, accessKeySecret);

            return accessKeyCredentialProvider.GetCredentials();
        }

        public virtual AlibabaCloudCredentials GetRamRoleArnAlibabaCloudCredential()
        {
            if (String.IsNullOrEmpty(accessKeyId) || String.IsNullOrEmpty(accessKeySecret) || String.IsNullOrEmpty(regionId))
            {
                throw new ClientException("Missing required variable option for 'default Client'");
            }
            BasicSessionCredentials credential = new BasicSessionCredentials(
                accessKeyId,
                accessKeySecret,
                STSAssumeRoleSessionCredentialsProvider.GetNewRoleSessionName(),
                3600
            );
            var profile = DefaultProfile.GetProfile(regionId, accessKeyId, accessKeySecret);

            STSAssumeRoleSessionCredentialsProvider stsAsssumeRoleSessionCredentialProvider;

            if (null != alibabaCloudCredentialProvider)
            {
                stsAsssumeRoleSessionCredentialProvider = (STSAssumeRoleSessionCredentialsProvider) alibabaCloudCredentialProvider;
            }
            else
            {
                stsAsssumeRoleSessionCredentialProvider = new STSAssumeRoleSessionCredentialsProvider(credential, roleArn, profile);
            }
            return stsAsssumeRoleSessionCredentialProvider.GetCredentials();
        }

        public virtual AlibabaCloudCredentials GetRsaKeyPairAlibabaCloudCredential()
        {
            if (String.IsNullOrEmpty(publicKeyId) || String.IsNullOrEmpty(privateKeyFile) || String.IsNullOrEmpty(regionId))
            {
                throw new ClientException("Missing required variable option for 'default Client'");
            }
            var rsaKeyPairCredential = new KeyPairCredentials(publicKeyId, privateKeyFile);
            var profile = DefaultProfile.GetProfile(regionId, publicKeyId, privateKeyFile);

            RsaKeyPairCredentialProvider rsaKeyPairCredentialProvider;

            if (null != alibabaCloudCredentialProvider)
            {
                rsaKeyPairCredentialProvider = (RsaKeyPairCredentialProvider) alibabaCloudCredentialProvider;
            }
            else
            {
                rsaKeyPairCredentialProvider = new RsaKeyPairCredentialProvider(rsaKeyPairCredential, profile);
            }

            return rsaKeyPairCredentialProvider.GetCredentials();
        }

        public virtual string GetHomePath()
        {
            return EnvironmentUtil.GetHomePath();
        }

        public virtual Configuration LoadFileFromIni(string location)
        {
            return Configuration.LoadFromFile(location);
        }
    }
}
