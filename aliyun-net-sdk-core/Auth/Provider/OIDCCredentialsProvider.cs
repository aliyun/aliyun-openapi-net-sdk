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
        /// <summary>
        /// Unit of millisecond
        /// </summary>
        private int connectTimeout = 5000;

        private int readTimeout = 10000;

        public OIDCCredentialsProvider(string roleArn, string oidcProviderArn, string oidcTokenFilePath,
            string roleSessionName, string regionId)
        {
            RoleArn = ParameterHelper.ValidateEnvNotNull(roleArn, "ALIBABA_CLOUD_ROLE_ARN", "roleArn",
                "roleArn does not exist and env ALIBABA_CLOUD_ROLE_ARN is null.");
            OIDCProviderArn = ParameterHelper.ValidateEnvNotNull(oidcProviderArn, "ALIBABA_CLOUD_OIDC_PROVIDER_ARN",
                "oidcProviderArn", "OIDCProviderArn does not exist and env ALIBABA_CLOUD_OIDC_PROVIDER_ARN is null.");
            OIDCTokenFilePath = ParameterHelper.ValidateEnvNotNull(oidcTokenFilePath, "ALIBABA_CLOUD_OIDC_TOKEN_FILE",
                "oidcTokenFilePath", "OIDCTokenFilePath does not exist and env ALIBABA_CLOUD_OIDC_TOKEN_FILE is null.");

            RoleSessionName = !string.IsNullOrEmpty(roleSessionName) ? roleSessionName : AuthUtils.EnvironmentRoleSessionName;
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
            connectTimeout = 5000;
            readTimeout = 10000;
        }

        public string InvokeAssumeRoleWithOIDC()
        {
            string url;
            try
            {
                url = stsEndpoint + "?" + "Action=AssumeRoleWithOIDC&Format=JSON&Version=2015-04-01&Timestamp=" +
                      ParameterHelper.FormatIso8601Date(DateTime.UtcNow);
            }
            catch (Exception ex)
            {
                throw new ClientException("AssumeRoleWithOIDC failed: " + ex.Message);
            }

            var httpRequest = new HttpRequest(url) { Method = MethodType.POST, ContentType = FormatType.FORM, };

            httpRequest.SetConnectTimeoutInMilliSeconds(this.connectTimeout);
            httpRequest.SetReadTimeoutInMilliSeconds(this.readTimeout);

            var oidcToken = AuthUtils.GetOIDCToken(this.OIDCTokenFilePath);
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

        private OIDCCredentialsProvider(Builder builder)
        {
            this.durationSeconds = (builder.durationSeconds == null || builder.durationSeconds == 0)
                ? 3600
                : builder.durationSeconds.Value;
            if (this.durationSeconds < 900)
            {
                throw new ClientException("Session duration should be in the range of 900s - max session duration");
            }

            this.RoleSessionName = string.IsNullOrEmpty(builder.roleSessionName)
                ? AuthUtils.EnvironmentRoleSessionName
                  ?? "aliyun-net-sdk-" + DateTime.UtcNow.currentTimeMillis()
                : builder.roleSessionName;
            this.RoleArn = string.IsNullOrEmpty(builder.roleArn)
                ? AuthUtils.EnvironmentRoleArn
                : builder.roleArn;
            if (string.IsNullOrEmpty(this.RoleArn))
            {
                throw new ArgumentException("RoleArn or environment variable ALIBABA_CLOUD_ROLE_ARN cannot be empty.");
            }
            
            this.OIDCProviderArn = string.IsNullOrEmpty(builder.oidcProviderArn)
                ? AuthUtils.EnvironmentOIDCProviderArn
                : builder.oidcProviderArn;
            if (string.IsNullOrEmpty(this.OIDCProviderArn))
            {
                throw new ArgumentException("OIDCProviderArn or environment variable ALIBABA_CLOUD_OIDC_PROVIDER_ARN cannot be empty.");
            }
            
            this.OIDCTokenFilePath = string.IsNullOrEmpty(builder.oidcProviderArn)
                ? AuthUtils.EnvironmentOIDCTokenFilePath
                : builder.oidcTokenFilePath;
            if (string.IsNullOrEmpty(this.OIDCTokenFilePath))
            {
                throw new ArgumentException("OIDCTokenFilePath or environment variable ALIBABA_CLOUD_OIDC_TOKEN_FILE cannot be empty.");
            }
            
            this.Policy = builder.policy;
            this.connectTimeout = (builder.connectTimeout == null || builder.connectTimeout <= 0)
                ? 5000
                : builder.connectTimeout.Value;
            this.readTimeout = (builder.readTimeout == null || builder.readTimeout <= 0)
                ? 10000
                : builder.readTimeout.Value;

            var prefix = builder.enableVpc == null
                ? (AuthUtils.EnableVpcEndpoint ? "sts-vpc" : "sts")
                : (builder.enableVpc == true ? "sts-vpc" : "sts");
            if (!string.IsNullOrEmpty(builder.stsRegionId))
            {
                this.stsEndpoint =  string.Format("https://{0}.{1}.aliyuncs.com", prefix, builder.stsRegionId);
            }
            if (!string.IsNullOrEmpty(AuthUtils.EnvironmentSTSRegion))
            {
                this.stsEndpoint =  string.Format("https://{0}.{1}.aliyuncs.com", prefix, AuthUtils.EnvironmentSTSRegion);
            }
            this.stsEndpoint =  "https://sts.aliyuncs.com";
        }

        public class Builder
        {
            internal int? durationSeconds;
            internal string roleSessionName;
            internal string roleArn;
            internal string oidcProviderArn;
            internal string oidcTokenFilePath;
            internal string policy;
            internal int? connectTimeout;
            internal int? readTimeout;
            internal string stsRegionId;
            internal bool? enableVpc;

            public Builder DurationSeconds(int? durationSeconds)
            {
                this.durationSeconds = durationSeconds;
                return this;
            }

            public Builder RoleSessionName(string roleSessionName)
            {
                this.roleSessionName = roleSessionName;
                return this;
            }

            public Builder RoleArn(string roleArn)
            {
                this.roleArn = roleArn;
                return this;
            }

            public Builder OIDCProviderArn(string oidcProviderArn)
            {
                this.oidcProviderArn = oidcProviderArn;
                return this;
            }

            public Builder OIDCTokenFilePath(string oidcTokenFilePath)
            {
                this.oidcTokenFilePath = oidcTokenFilePath;
                return this;
            }

            public Builder Policy(string policy)
            {
                this.policy = policy;
                return this;
            }

            public Builder ConnectTimeout(int? connectTimeout)
            {
                this.connectTimeout = connectTimeout;
                return this;
            }

            public Builder ReadTimeout(int? readTimeout)
            {
                this.readTimeout = readTimeout;
                return this;
            }

            public Builder StsRegionId(string stsRegionId)
            {
                this.stsRegionId = stsRegionId;
                return this;
            }

            public Builder EnableVpc(bool? enableVpc)
            {
                this.enableVpc = enableVpc;
                return this;
            }

            public OIDCCredentialsProvider Build()
            {
                return new OIDCCredentialsProvider(this);
            }
        }
    }
}
