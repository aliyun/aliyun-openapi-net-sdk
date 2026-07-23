using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth.Provider
{
    internal class EnvironmentVariableCredentialsProvider : AlibabaCloudCredentialsProvider
    {
        public AlibabaCloudCredentials GetCredentials()
        {
            var accessKeyId = EnvironmentUtil.GetEnvironmentAccessKeyId();
            var accessKeySecret = EnvironmentUtil.GetEnvironmentAccessKeySecret();
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
    }
}
