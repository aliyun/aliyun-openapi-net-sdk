using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;

namespace Aliyun.Acs.Core.Auth.Provider
{
    public class RsaKeyPairCredentialProvider : AlibabaCloudCredentialsProvider
    {
        public static readonly int DEFAULT_DURATION_SECONDS = 3600;
        private readonly RsaKeyPairCredential rsaKeyPairCredential;
        private IAcsClient stsClient;
        private long sessionDurationSeconds = DEFAULT_DURATION_SECONDS;
        private BasicSessionCredentials basicSessionCredentials = null;

        public RsaKeyPairCredentialProvider(RsaKeyPairCredential rsaKeyPairCredential, IClientProfile profile)
        {
            this.rsaKeyPairCredential = rsaKeyPairCredential;
            this.stsClient = new DefaultAcsClient(profile, rsaKeyPairCredential);
        }

        public RsaKeyPairCredentialProvider WithDurationSeconds(long seconds)
        {
            this.sessionDurationSeconds = seconds;
            return this;
        }

        public RsaKeyPairCredentialProvider WithSTSClient(IAcsClient client)
        {
            this.stsClient = client;
            return this;
        }

        public AlibabaCloudCredentials GetCredentials()
        {
            if (basicSessionCredentials == null || basicSessionCredentials.WillSoonExpire())
            {
                basicSessionCredentials = GetNewSessionCredentials();
            }
            return basicSessionCredentials;
        }

        public BasicSessionCredentials GetNewSessionCredentials()
        {
            GetSessionAccessKeyRequest request = new GetSessionAccessKeyRequest();
            request.PublicKeyId = rsaKeyPairCredential.GetAccessKeyId();
            request.DurationSeconds = (int) sessionDurationSeconds;
            request.Protocol = ProtocolType.HTTPS;

            GetSessionAccessKeyResponse response = this.stsClient.GetAcsResponse(request);

            return new BasicSessionCredentials(
                response.SessionAccesskey.SessionAccessKeyId,
                response.SessionAccesskey.SessionAccessKeySecert,
                null,
                sessionDurationSeconds
            );
        }
    }
}
