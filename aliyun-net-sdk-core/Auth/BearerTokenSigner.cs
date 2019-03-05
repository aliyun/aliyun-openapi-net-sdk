namespace Aliyun.Acs.Core.Auth
{
    public class BearerTokenSigner : ISigner
    {
        public override string SignerName => "1.0";

        public override string SignerVersion => "BEARERTOKEN";

        public override string SignString(string source, string accessSecret)
        {
            return null;
        }
    }
}
