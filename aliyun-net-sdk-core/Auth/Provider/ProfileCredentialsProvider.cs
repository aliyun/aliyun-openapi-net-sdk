using System;
using System.IO;
using System.Text;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth.Provider
{
    internal class ProfileCredentialsProvider : AlibabaCloudCredentialsProvider
    {
        private readonly IClientProfile defaultProfile;
        private readonly AlibabaCloudCredentialsProvider alibabaCloudCredentialProvider;

        public ProfileCredentialsProvider(IClientProfile defaultProfile,
            AlibabaCloudCredentialsProvider alibabaCloudCredentialProvider)
        {
            this.defaultProfile = defaultProfile;
            this.alibabaCloudCredentialProvider = alibabaCloudCredentialProvider;
        }

        public AlibabaCloudCredentials GetCredentials()
        {
            var filePath = EnvironmentUtil.GetEnvironmentCredentialFile();
            if (null == filePath)
            {
                filePath = EnvironmentUtil.GetHomePath();
                var slash = EnvironmentUtil.GetOSSlash();
                var fileLocation = EnvironmentUtil.GetComposedPath(filePath, slash);

                if (File.Exists(fileLocation))
                {
                    filePath = fileLocation;
                }
                else
                {
                    throw new ClientException(string.Format("Unable to open credentials file: {0}.", filePath));
                }
            }

            if (filePath.Equals(""))
            {
                throw new ClientException(
                    "Credentials file environment variable 'ALIBABA_CLOUD_CREDENTIALS_FILE' cannot be empty");
            }

            IniReader iniReader;
            try
            {
                iniReader = new IniReader(filePath);
            }
            catch (IOException)
            {
                throw new ClientException(string.Format("Unable to open credentials file: {0}.", filePath));
            }

            string userDefineSectionNode;
            if (this.defaultProfile != null && this.defaultProfile.DefaultClientName != null)
            {
                userDefineSectionNode = defaultProfile.DefaultClientName;
            }
            else
            {
                userDefineSectionNode = AuthUtils.GetClientType();
            }

            var iniKeyTypeValue = iniReader.GetValue("type", userDefineSectionNode);

            if (string.IsNullOrWhiteSpace(iniKeyTypeValue))
            {
                throw new ClientException("The configured client type is empty");
            }

            switch (iniKeyTypeValue)
            {
                case "ecs_ram_role":
                    return GetInstanceProfileCredentials(iniReader, userDefineSectionNode);
                case "ram_role_arn":
                    return GetSTSAssumeRoleSessionCredentials(iniReader, userDefineSectionNode);
                case "rsa_key_pair":
                    return GetRsaKeyPairAlibabaCloudCredential(iniReader, userDefineSectionNode);
                case "oidc_role_arn":
                    return GetSTSOIDCRoleSessionCredentials(iniReader, userDefineSectionNode);
                default:
                    return GetAccessKeyCredential(iniReader, userDefineSectionNode);
            }
        }

        private AlibabaCloudCredentials GetInstanceProfileCredentials(IniReader iniReader,
            string userDefineSectionNode)
        {
            var roleName = iniReader.GetValue("role_name", userDefineSectionNode);
            if (string.IsNullOrEmpty(roleName))
            {
                throw new ClientException("The configured role_name is empty");
            }

            var provider = new InstanceProfileCredentialsProvider.Builder().RoleName(roleName).Build();
            return provider.GetCredentials();
        }

        private AlibabaCloudCredentials GetSTSAssumeRoleSessionCredentials(IniReader iniReader,
            string userDefineSectionNode)
        {
            var accessKeyId = iniReader.GetValue("access_key_id", userDefineSectionNode);
            var accessKeySecret = iniReader.GetValue("access_key_secret", userDefineSectionNode);
            if (string.IsNullOrWhiteSpace(accessKeyId) || string.IsNullOrWhiteSpace(accessKeySecret))
            {
                throw new ClientException("The configured access_key_id or access_key_secret is empty");
            }

            var roleArn = iniReader.GetValue("role_arn", userDefineSectionNode);
            var roleSessionName = iniReader.GetValue("role_session_name", userDefineSectionNode);
            if (string.IsNullOrWhiteSpace(roleArn) || string.IsNullOrWhiteSpace(roleSessionName))
            {
                throw new ClientException("The configured role_session_name or role_arn is empty");
            }

            var policy = iniReader.GetValue("policy", userDefineSectionNode);
            var stsRegionId = iniReader.GetValue("sts_region", userDefineSectionNode);
            var enable = iniReader.GetValue("enable", userDefineSectionNode);
            var enableVpc = enable == null ? (bool?)null
                : enable.ToLower() == "true" ? true
                : enable.ToLower() == "false" ? false
                : (bool?)null;
            var externalId = iniReader.GetValue("external_id", userDefineSectionNode);

            var provider = new STSAssumeRoleSessionCredentialsProvider.Builder()
                .AccessKeyId(accessKeyId)
                .AccessKeySecret(accessKeySecret)
                .RoleSessionName(roleSessionName)
                .RoleArn(roleArn)
                .Policy(policy)
                .StsRegionId(stsRegionId)
                .EnableVpc(enableVpc)
                .ExternalId(externalId)
                .Build();
            return provider.GetCredentials();
        }

        private AlibabaCloudCredentials GetSTSOIDCRoleSessionCredentials(IniReader iniReader,
            string userDefineSectionNode)
        {
            var oidcProviderArn = iniReader.GetValue("oidc_provider_arn", userDefineSectionNode);
            var oidcTokenFilePath = iniReader.GetValue("oidc_token_file_path", userDefineSectionNode);
            var roleArn = iniReader.GetValue("role_arn", userDefineSectionNode);

            if (string.IsNullOrWhiteSpace(roleArn))
            {
                throw new ClientException("The configured role_arn is empty");
            }

            if (string.IsNullOrWhiteSpace(oidcProviderArn))
            {
                throw new ClientException("The configured oidc_provider_arn is empty");
            }

            var roleSessionName = iniReader.GetValue("role_session_name", userDefineSectionNode);
            var policy = iniReader.GetValue("policy", userDefineSectionNode);
            var stsRegionId = iniReader.GetValue("sts_region", userDefineSectionNode);
            var enable = iniReader.GetValue("enable", userDefineSectionNode);
            var enableVpc = enable == null ? (bool?)null
                : enable.ToLower() == "true" ? true
                : enable.ToLower() == "false" ? false
                : (bool?)null;

            var provider = new OIDCCredentialsProvider.Builder()
                .RoleArn(roleArn)
                .OIDCProviderArn(oidcProviderArn)
                .OIDCTokenFilePath(oidcTokenFilePath)
                .RoleSessionName(roleSessionName)
                .Policy(policy)
                .StsRegionId(stsRegionId)
                .EnableVpc(enableVpc)
                .Build();
            return provider.GetCredentials();
        }

        private AlibabaCloudCredentials GetAccessKeyCredential(IniReader iniReader, string userDefineSectionNode)
        {
            var accessKeyId = iniReader.GetValue("access_key_id", userDefineSectionNode);
            var accessKeySecret = iniReader.GetValue("access_key_secret", userDefineSectionNode);
            if (string.IsNullOrWhiteSpace(accessKeyId))
            {
                throw new ClientException("Environment variable accessKeyId cannot be empty");
            }

            if (string.IsNullOrWhiteSpace(accessKeySecret))
            {
                throw new ClientException("Environment variable accessKeySecret cannot be empty");
            }

            var accessKeyCredentialProvider =
                new AccessKeyCredentialProvider(accessKeyId, accessKeySecret);
            return accessKeyCredentialProvider.GetCredentials();
        }

        private AlibabaCloudCredentials GetRsaKeyPairAlibabaCloudCredential(IniReader iniReader,
            string userDefineSectionNode)
        {
            var publicKeyId = iniReader.GetValue("public_key_id", userDefineSectionNode);
            var privateKeyFile = iniReader.GetValue("private_key_file", userDefineSectionNode);
            if (string.IsNullOrWhiteSpace(privateKeyFile))
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

            if (string.IsNullOrWhiteSpace(publicKeyId) || string.IsNullOrWhiteSpace(privateKey))
            {
                throw new ClientException("The configured public_key_id or private_key_file is empty");
            }

            var rsaKeyPairCredential = new KeyPairCredentials(publicKeyId, privateKeyFile);
            var regionId = EnvironmentUtil.GetEnvironmentRegionId();
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
    }
}
