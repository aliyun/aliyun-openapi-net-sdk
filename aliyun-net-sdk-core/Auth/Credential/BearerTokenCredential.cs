namespace Aliyun.Acs.Core.Auth
{
    public class BearerTokenCredential : AlibabaCloudCredentials
    {
        private string bearerToken;

        public BearerTokenCredential(string bearerToken)
        {
            this.bearerToken = bearerToken;
        }

        public string GetAccessKeyId()
        {
            return null;
        }

        public string GetAccessKeySecret()
        {
            return null;
        }

        public string GetBearerToken()
        {
            return this.bearerToken;
        }
    }
}
