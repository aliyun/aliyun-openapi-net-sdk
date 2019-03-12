namespace Aliyun.Acs.Core.Auth
{
    public class BearerTokenSigner : Signer
    {
        public override string GetSignerName()
        {
            return "BearerTokenSigner";
        }

        public override string GetSignerType()
        {
            return "BEARERTOKEN";
        }

        public override string GetSignerVersion()
        {
            return "1.0";
        }

        public override string SignString(string stringToSign, AlibabaCloudCredentials credentials)
        {
            return SignString(stringToSign, credentials.GetAccessKeyId());
        }

        public override string SignString(string stringToSign, string accessKeySecret)
        {
            return "";
        }
    }
}
