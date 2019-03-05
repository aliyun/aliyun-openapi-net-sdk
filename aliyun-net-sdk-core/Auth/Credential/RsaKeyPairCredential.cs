using System;

namespace Aliyun.Acs.Core.Auth
{
    public class RsaKeyPairCredential : AlibabaCloudCredentials
    {
        private string privateKeySecret;
        private string publicKeyId;

        public RsaKeyPairCredential(string publicKeyId, string privateKeySecret)
        {
            if (publicKeyId == null || privateKeySecret == null)
            {
                throw new ArgumentNullException(
                    "You must provide a valid pair of Public Key ID and Private Key Secret."
                );
            }
            this.publicKeyId = publicKeyId;
            this.privateKeySecret = privateKeySecret;
        }

        public string GetAccessKeyId()
        {
            return publicKeyId;
        }

        public string GetAccessKeySecret()
        {
            return privateKeySecret;
        }
    }
}
