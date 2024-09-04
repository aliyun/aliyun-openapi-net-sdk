using System;
using System.Text;
using System.Collections.Generic;

using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Core.Exceptions;

using Aliyun.Acs.Core.Http;

using Newtonsoft.Json;

namespace Aliyun.Acs.Core.Auth
{
    public class OIDCCredentialsProvider : AlibabaCloudCredentialsProvider
    {
        public string RoleArn { get; set; }
        public string OIDCProviderArn { get; set; }
        public string OIDCTokenFilePath { get; set; }
        public string RoleSessionName { get; set; }
        public string Policy { get; set; }

        private readonly string stsEndpoint;

        private readonly long durationSeconds;

        private BasicSessionCredentials credentials;

        public OIDCCredentialsProvider(string roleArn, string oidcProviderArn, string oidcTokenFilePath, string roleSessionName, string regionId)
        {
            RoleArn = ParameterHelper.ValidateEnvNotNull(roleArn, "ALIBABA_CLOUD_ROLE_ARN", "roleArn", "roleArn does not exist and env ALIBABA_CLOUD_ROLE_ARN is null.");
            OIDCProviderArn = ParameterHelper.ValidateEnvNotNull(oidcProviderArn, "ALIBABA_CLOUD_OIDC_PROVIDER_ARN", "oidcProviderArn", "OIDCProviderArn does not exist and env ALIBABA_CLOUD_OIDC_PROVIDER_ARN is null.");
            OIDCTokenFilePath = ParameterHelper.ValidateEnvNotNull(oidcTokenFilePath, "ALIBABA_CLOUD_OIDC_TOKEN_FILE", "oidcTokenFilePath", "OIDCTokenFilePath does not exist and env ALIBABA_CLOUD_OIDC_TOKEN_FILE is null.");

            if (!string.IsNullOrEmpty(roleSessionName))
            {
                RoleSessionName = roleSessionName;
            }
            else
            {
                RoleSessionName = Environment.GetEnvironmentVariable("ALIBABA_CLOUD_ROLE_SESSION_NAME");
            }

            if (string.IsNullOrEmpty(RoleSessionName))
            {
                RoleSessionName = "aliyun-net-sdk-" + DateTime.UtcNow.currentTimeMillis();
            }

            if (string.IsNullOrEmpty(regionId))
            {
                stsEndpoint = "https://sts.aliyuncs.com/";
            }
            else
            {
                stsEndpoint = string.Format("https://sts.{0}.aliyuncs.com/", regionId);
            }

            durationSeconds = 3600;
        }

        public string InvokeAssumeRoleWithOIDC()
        {
            var queries = new Dictionary<string, string>
            {
                { "Action", "AssumeRoleWithOIDC" },
                { "Format", "JSON" },
                { "Version", "2015-04-01" },
                { "Timestamp", ParameterHelper.FormatIso8601Date(DateTime.UtcNow) }
            };

            string url;
            try
            {
                url = stsEndpoint + "?" + "Action=AssumeRoleWithOIDC&Format=JSON&Version=2015-04-01&Timestamp=" + ParameterHelper.FormatIso8601Date(DateTime.UtcNow);
            }
            catch (Exception ex)
            {
                throw new ClientException("AssumeRoleWithOIDC failed: " + ex.Message);
            }

            var httpRequest = new HttpRequest(url)
            {
                Method = MethodType.POST,
                ContentType = FormatType.FORM,
            };

            httpRequest.SetConnectTimeoutInMilliSeconds(1000);
            httpRequest.SetReadTimeoutInMilliSeconds(3000);

            var oidcToken = AuthUtils.GetOIDCToken(OIDCTokenFilePath);
            if (oidcToken == null)
            {
                throw new ClientException("Read OIDC token failed");
            }

            var body = new Dictionary<string, string>
            {
                { "DurationSeconds", durationSeconds.ToString() },
                { "RoleArn", RoleArn },
                { "OIDCProviderArn", OIDCProviderArn },
                { "OIDCToken", oidcToken },
                { "RoleSessionName", RoleSessionName },
                { "Policy", Policy }
            };

            var content = ParameterHelper.GetFormData(body);
            httpRequest.SetContent(content, "UTF-8", FormatType.FORM);
            httpRequest.Headers.Add("User-Agent", UserAgent.Resolve(null, null));

            HttpResponse httpResponse;
            try
            {
                httpResponse = HttpResponse.GetResponse(httpRequest);
            }
            catch (Exception ex)
            {
                throw new ClientException("AssumeRoleWithOIDC failed " + ex.Message);
            }

            if (!httpResponse.isSuccess())
            {
                var responseBody = httpResponse.GetHttpContentString();
                var map = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseBody);
                var requestID = map["RequestId"];
                var message = string.Format("{0}(RequestID: {1}, Code: {2})", map["Message"], requestID, map["Code"]);
                throw new ClientException("AssumeRoleWithOIDC failed: " + message);
            }

            return httpResponse.GetHttpContentString();
        }

        internal static BasicSessionCredentials ParseCredentials(string body, long durationSeconds)
        {
            var map = JsonConvert.DeserializeObject<Dictionary<string, object>>(body);
            if (map == null)
            {
                throw new ClientException("Invalid JSON");
            }
            else if (map.ContainsKey("Credentials"))
            {
                var credentialsJson = JsonConvert.SerializeObject(DictionaryUtil.Get(map, "Credentials"));
                var credentials = JsonConvert.DeserializeObject<Dictionary<string, string>>(credentialsJson);
                var accessKeyId = DictionaryUtil.Get(credentials, "AccessKeyId");
                var accessKeySecret = DictionaryUtil.Get(credentials, "AccessKeySecret");
                var securityToken = DictionaryUtil.Get(credentials, "SecurityToken");
                return new BasicSessionCredentials(accessKeyId, accessKeySecret, securityToken, durationSeconds);
            }
            else
            {
                throw new ClientException("AssumeRoleWithOIDC failed: " + body);
            }
        }

        public AlibabaCloudCredentials GetCredentials()
        {
            if (credentials == null || credentials.WillSoonExpire())
            {
                var body = InvokeAssumeRoleWithOIDC();
                credentials = ParseCredentials(body, durationSeconds);
            }
            return credentials;
        }
    }
}