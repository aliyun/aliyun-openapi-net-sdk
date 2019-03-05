using System;

namespace Aliyun.Acs.Core.Auth
{
    public class AccessKeyCredential : AlibabaCloudCredentials
    {
        private readonly string accessKeyId;
        private readonly string accessKeySecret;

        public AccessKeyCredential(string accessKeyId, string accessKeySecret)
        {
            if (accessKeyId == null)
            {
                throw new ArgumentOutOfRangeException("Access key ID cannot be null.");
            }
            if (accessKeySecret == null)
            {
                throw new ArgumentOutOfRangeException("Access key secret cannot be null.");
            }

            this.accessKeyId = accessKeyId;
            this.accessKeySecret = accessKeySecret;
        }

        public string GetAccessKeyId()
        {
            return accessKeyId;
        }

        public string GetAccessKeySecret()
        {
            return accessKeySecret;
        }
    }
}
