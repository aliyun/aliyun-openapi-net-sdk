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
using System.Collections.Generic;
using System.IO;

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Utils;

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

            var sectionNameList = IniFileHelper.ReadSections(credentialFileLocation);

            if (null != defaultProfile.DefaultClientName)
            {
                string userDefineSectionNode = defaultProfile.DefaultClientName;

                var iniKeyTypeValue = IniFileHelper.ReadValue(userDefineSectionNode, "type", credentialFileLocation);
                SaveIniKeyValueToDic(userDefineSectionNode, credentialFileLocation, out Dictionary<string, string> keyValuePairDic);
                if (iniKeyTypeValue.Equals("access_key"))
                {
                    keyValuePairDic.TryGetValue("access_key_id", out accessKeyId);
                    keyValuePairDic.TryGetValue("access_key_secret", out accessKeySecret);
                    keyValuePairDic.TryGetValue("region_id", out regionId);

                    return GetAccessKeyCredential();
                }

                if (iniKeyTypeValue.Equals("ecs_ram_role"))
                {
                    keyValuePairDic.TryGetValue("role_name", out roleName);
                    keyValuePairDic.TryGetValue("region_id", out regionId);

                    return GetInstanceRamRoleAlibabaCloudCredential();
                }

                if (iniKeyTypeValue.Equals("ram_role_arn"))
                {
                    keyValuePairDic.TryGetValue("access_key_id", out accessKeyId);
                    keyValuePairDic.TryGetValue("access_key_secret", out accessKeySecret);
                    keyValuePairDic.TryGetValue("role_arn", out roleArn);

                    return GetRamRoleArnAlibabaCloudCredential();
                }

                if (iniKeyTypeValue.Equals("rsa_key_pair"))
                {
                    keyValuePairDic.TryGetValue("public_key_id", out publicKeyId);
                    keyValuePairDic.TryGetValue("private_key_file", out privateKeyFile);

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
                    SaveIniKeyValueToDic("default", credentialFileLocation, out Dictionary<string, string> keyValuePairDic);

                    keyValuePairDic.TryGetValue("access_key_id", out accessKeyId);
                    keyValuePairDic.TryGetValue("access_key_secret", out accessKeySecret);
                    keyValuePairDic.TryGetValue("region_id", out regionId);

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

        private void SaveIniKeyValueToDic(string sectionName, string fileLocation, out Dictionary<string, string> keyValueDic)
        {
            var keyValuePair = IniFileHelper.ReadKeyValuePairs(sectionName, fileLocation);
            keyValueDic = new Dictionary<string, string>();

            foreach (var keyValueItem in keyValuePair)
            {
                var keyValueArray = keyValueItem.Split('=');
                keyValueDic.Add(keyValueArray[0], keyValueArray[1]);
            }
        }
    }
}
