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
using System.IO;
using System.Text;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth.Provider
{
    public class DefaultCredentialProvider : AlibabaCloudCredentialsProvider
    {
        private static IClientProfile defaultProfile;

        private readonly AlibabaCloudCredentialsProvider alibabaCloudCredentialProvider;

        private string accessKeyId;
        private string accessKeySecret;
        private string credentialFileLocation;
        private string privateKeyFile;
        private string publicKeyId;
        private string regionId;
        private string roleArn;
        private string roleName;
        private string oidcProviderArn;
        private string oidcTokenFile;

        public DefaultCredentialProvider()
        {
            accessKeyId = EnvironmentUtil.GetEnvironmentAccessKeyId();
            accessKeySecret = EnvironmentUtil.GetEnvironmentAccessKeySecret();
            regionId = EnvironmentUtil.GetEnvironmentRegionId();
            credentialFileLocation = EnvironmentUtil.GetEnvironmentCredentialFile();
            roleName = EnvironmentUtil.GetEnvironmentRoleName();
            roleArn = EnvironmentUtil.GetEnvironmentRoleArn();
            oidcProviderArn = EnvironmentUtil.GetEnvironmentOIDCProviderArn();
            oidcTokenFile = EnvironmentUtil.GetEnvironmentOIDCTokenFile();
        }

        [Obsolete]
        public DefaultCredentialProvider(
            IClientProfile profile,
            AlibabaCloudCredentialsProvider alibabaCloudCredentialProvider
        ) : this()
        {
            defaultProfile = profile;
            this.alibabaCloudCredentialProvider = alibabaCloudCredentialProvider;
        }

        [Obsolete]
        public DefaultCredentialProvider(
            IClientProfile profile,
            string publicKeyId,
            string privateKeyFile,
            AlibabaCloudCredentialsProvider alibabaCloudCredentialsProvider
        ) : this(profile, alibabaCloudCredentialsProvider)
        {
            this.privateKeyFile = privateKeyFile;
            this.publicKeyId = publicKeyId;
        }

        public AlibabaCloudCredentials GetAlibabaCloudClientCredential()
        {
            var credential = GetEnvironmentAlibabaCloudCredential() ??
                             GetOIDCAlibabaCloudCredential() ??
                             GetCredentialFileAlibabaCloudCredential() ??
                             GetInstanceRamRoleAlibabaCloudCredential();

            if (credential == null)
            {
                throw new ClientException("There is no credential chain can use.");
            }

            return credential;
        }

        internal virtual AlibabaCloudCredentials GetOIDCAlibabaCloudCredential()
        {
            if (string.IsNullOrEmpty(oidcProviderArn) || string.IsNullOrEmpty(roleArn) || string.IsNullOrEmpty(oidcTokenFile))
            {
                return null;
            }
            return new OIDCCredentialsProvider(roleArn, oidcProviderArn, oidcTokenFile, null, regionId).GetCredentials();
        }

        public AlibabaCloudCredentials GetEnvironmentAlibabaCloudCredential()
        {
            if (null == accessKeyId || null == accessKeySecret)
            {
                return null;
            }

            if (accessKeyId.Equals("") || accessKeySecret.Equals(""))
            {
                throw new ClientException(
                    "Environment credential variable 'ALIBABA_CLOUD_ACCESS_KEY_*' cannot be empty");
            }

            return GetAccessKeyCredential();
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
                throw new ClientException(
                    "Credentials file environment variable 'ALIBABA_CLOUD_CREDENTIALS_FILE' cannot be empty");
            }

            var iniReader = new IniReader(credentialFileLocation);
            var sectionNameList = iniReader.GetSections();
            string userDefineSectionNode;
            if (defaultProfile != null && defaultProfile.DefaultClientName != null)
            {
                userDefineSectionNode = defaultProfile.DefaultClientName;
            }
            else
            {
                userDefineSectionNode = AuthUtils.GetClientType();
            }

            var iniKeyTypeValue = iniReader.GetValue("type", userDefineSectionNode);

            if (string.IsNullOrEmpty(iniKeyTypeValue))
            {
                throw new ClientException("The configured client type is empty");
            }

            if (iniKeyTypeValue.Equals("access_key"))
            {
                accessKeyId = iniReader.GetValue("access_key_id", userDefineSectionNode);
                accessKeySecret = iniReader.GetValue("access_key_secret", userDefineSectionNode);
                return GetAccessKeyCredential();
            }

            if (iniKeyTypeValue.Equals("ecs_ram_role"))
            {
                roleName = iniReader.GetValue("role_name", userDefineSectionNode);
                if (string.IsNullOrEmpty(roleName))
                {
                    throw new ClientException("The configured role_name is empty");
                }
                return GetInstanceRamRoleAlibabaCloudCredential();
            }

            if (iniKeyTypeValue.Equals("ram_role_arn"))
            {
                accessKeyId = iniReader.GetValue("access_key_id", userDefineSectionNode);
                accessKeySecret = iniReader.GetValue("access_key_secret", userDefineSectionNode);
                if (string.IsNullOrEmpty(accessKeyId) || string.IsNullOrEmpty(accessKeySecret))
                {
                    throw new ClientException("The configured access_key_id or access_key_secret is empty");
                }

                roleArn = iniReader.GetValue("role_arn", userDefineSectionNode);
                var roleSessionName = iniReader.GetValue("role_session_name", userDefineSectionNode);
                if (string.IsNullOrEmpty(roleArn) || string.IsNullOrEmpty(roleSessionName))
                {
                    throw new ClientException("The configured role_session_name or role_arn is empty");
                }

                return GetRamRoleArnAlibabaCloudCredential();
            }

            if (iniKeyTypeValue.Equals("rsa_key_pair"))
            {
                publicKeyId = iniReader.GetValue("public_key_id", userDefineSectionNode);
                privateKeyFile = iniReader.GetValue("private_key_file", userDefineSectionNode);

                return GetRsaKeyPairAlibabaCloudCredential();
            }

            return null;
        }

        public virtual AlibabaCloudCredentials GetInstanceRamRoleAlibabaCloudCredential()
        {
            if (string.IsNullOrEmpty(roleName))
            {
                throw new ClientException("Environment variable roleName('ALIBABA_CLOUD_ECS_METADATA') cannot be empty");
            }

            InstanceProfileCredentialsProvider instanceProfileCredentialProvider;
            if (null != alibabaCloudCredentialProvider)
            {
                instanceProfileCredentialProvider =
                    (InstanceProfileCredentialsProvider)alibabaCloudCredentialProvider;
            }
            else
            {
                instanceProfileCredentialProvider = new InstanceProfileCredentialsProvider(roleName);
            }

            return instanceProfileCredentialProvider.GetCredentials();
        }

        public AlibabaCloudCredentials GetAccessKeyCredential()
        {
            if (string.IsNullOrEmpty(accessKeyId))
            {
                throw new ClientException("Access key ID cannot be null.");
            }
            if (string.IsNullOrEmpty(accessKeySecret))
            {
                throw new ClientException("Access key secret cannot be null.");
            }

            var accessKeyCredentialProvider =
                new AccessKeyCredentialProvider(accessKeyId, accessKeySecret);

            return accessKeyCredentialProvider.GetCredentials();
        }

        public virtual AlibabaCloudCredentials GetRamRoleArnAlibabaCloudCredential()
        {
            if (string.IsNullOrEmpty(accessKeyId) || string.IsNullOrEmpty(accessKeySecret))
            {
                throw new ClientException("Missing required variable option for 'default Client'");
            }

            var credential = new BasicSessionCredentials(accessKeyId, accessKeySecret,
                STSAssumeRoleSessionCredentialsProvider.GetNewRoleSessionName(),
                3600
            );
            var profile = DefaultProfile.GetProfile(regionId, accessKeyId, accessKeySecret);

            STSAssumeRoleSessionCredentialsProvider stsAsssumeRoleSessionCredentialProvider;

            if (null != alibabaCloudCredentialProvider)
            {
                stsAsssumeRoleSessionCredentialProvider =
                    (STSAssumeRoleSessionCredentialsProvider)alibabaCloudCredentialProvider;
            }
            else
            {
                stsAsssumeRoleSessionCredentialProvider =
                    new STSAssumeRoleSessionCredentialsProvider(credential, roleArn, profile);
            }

            return stsAsssumeRoleSessionCredentialProvider.GetCredentials();
        }

        public virtual AlibabaCloudCredentials GetRsaKeyPairAlibabaCloudCredential()
        {
            if (string.IsNullOrEmpty(privateKeyFile))
            {
                throw new ClientException("The configured private_key_file is empty");
            }

            string privateKey;
            try
            {
                privateKey = File.ReadAllText(privateKeyFile, Encoding.UTF8);
            }
            catch (IOException)
            {
                privateKey = null;
            }

            if (string.IsNullOrEmpty(publicKeyId) || string.IsNullOrEmpty(privateKey))
            {
                throw new ClientException("The configured public_key_id or private_key_file is empty");
            }

            var rsaKeyPairCredential = new KeyPairCredentials(publicKeyId, privateKeyFile);
            var profile = DefaultProfile.GetProfile(regionId, publicKeyId, privateKeyFile);

            RsaKeyPairCredentialProvider rsaKeyPairCredentialProvider;

            if (null != alibabaCloudCredentialProvider)
            {
                rsaKeyPairCredentialProvider = (RsaKeyPairCredentialProvider)alibabaCloudCredentialProvider;
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

        public AlibabaCloudCredentials GetCredentials()
        {
            var credential = GetEnvironmentAlibabaCloudCredential() ??
                             GetOIDCAlibabaCloudCredential() ??
                             GetCredentialFileAlibabaCloudCredential() ??
                             GetInstanceRamRoleAlibabaCloudCredential();

            if (credential == null)
            {
                throw new ClientException("There is no credential chain can use.");
            }

            return credential;
        }
    }
}
