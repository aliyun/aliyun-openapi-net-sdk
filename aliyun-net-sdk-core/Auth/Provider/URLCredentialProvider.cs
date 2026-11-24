using System;
using System.Collections.Generic;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Utils;
using Newtonsoft.Json;

namespace Aliyun.Acs.Core.Auth.Provider
{
    /// <summary>
    /// By specifying the url, the credential will be able to automatically request maintenance of STS Token.
    /// </summary>
    public class URLCredentialProvider : AlibabaCloudCredentialsProvider
    {
        private readonly Uri credentialsURI;

        /// <summary>
        /// Unit of millsecond.
        /// </summary>
        private int connectTimeout = 5000;

        private int readTimeout = 10000;
        
        public URLCredentialProvider() {}

        private URLCredentialProvider(Builder builder)
        {
            this.connectTimeout = (builder.connectTimeout == null || builder.connectTimeout <= 0)
                ? 5000
                : builder.connectTimeout.Value;
            this.readTimeout = (builder.readTimeout == null || builder.readTimeout <= 0)
                ? 10000
                : builder.readTimeout.Value;
            
            var uriStr = string.IsNullOrEmpty(builder.credentialsURI)
                ? AuthUtils.EnvironmentCredentialsURI
                : builder.credentialsURI;
            if (string.IsNullOrEmpty(uriStr))
            {
                throw new ArgumentNullException("Credential URI or environment variable ALIBABA_CLOUD_CREDENTIALS_URI cannot be empty.");
            }
            
            try
            {
                this.credentialsURI = new Uri(uriStr);

            }
            catch (UriFormatException)
            {
                throw new ClientException("Credential URI is not valid.");
            }
        }

        public class Builder
        {
            internal string credentialsURI;
            internal int? connectTimeout;
            internal int? readTimeout;

            public Builder CredentialsURI(string credentialsURI)
            {
                this.credentialsURI = credentialsURI;
                return this;
            }

            public Builder CredentialsURI(Uri credentialsURI)
            {
                this.credentialsURI = credentialsURI.ToString();
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

            public URLCredentialProvider Build()
            {
                return new URLCredentialProvider(this);
            }
        }

        public AlibabaCloudCredentials GetCredentials()
        {
            var httpRequest = new HttpRequest(credentialsURI.ToString());
            httpRequest.Method = MethodType.GET;
            httpRequest.SetConnectTimeoutInMilliSeconds(this.connectTimeout);
            httpRequest.SetReadTimeoutInMilliSeconds(this.readTimeout);
            HttpResponse httpResponse;

            try
            {
                httpResponse = GetResponse(httpRequest);
            }
            catch (Exception e)
            {
                throw new ClientException("Failed to connect Server: " + credentialsURI.ToString() + e.ToString());
            }

            if (httpResponse.Status >= 300 || httpResponse.Status < 200)
            {
                throw new ClientException("Failed to get credentials from server: " + credentialsURI.ToString() +
                                              "\nHttpCode=" + httpResponse.Status +
                                              "\nHttpRAWContent=" + httpResponse.GetHttpContentString());
            }

            Dictionary<string, string> map;
            try
            {
                map = JsonConvert.DeserializeObject<Dictionary<string, string>>(httpResponse.GetHttpContentString());
            }
            catch (Exception e)
            {
                throw new ClientException("Failed to parse credentials from server: " + credentialsURI.ToString() +
                                          "\nHttpCode=" + httpResponse.Status +
                                          "\nHttpRAWContent=" + httpResponse.GetHttpContentString());
            }
            
            if (null == map || !map.ContainsKey("Code") || DictionaryUtil.Get(map, "Code") == "Success")
            {
                throw new ClientException(string.Format("Error retrieving credentials from url: {0}, result: {1}.", this.credentialsURI, httpResponse.GetHttpContentString()));
            }

            if (!map.ContainsKey("AccessKeyId") || !map.ContainsKey("AccessKeySecret") ||
                !map.ContainsKey("SecurityToken") || !map.ContainsKey("Expiration"))
            {
                throw new ClientException(string.Format("Error retrieving credentials from url: {0}, result: {1}.", this.credentialsURI, httpResponse.GetHttpContentString()));
            }

            var accessKeyId = DictionaryUtil.Get(map, "AccessKeyId");
            var accessKeySecret = DictionaryUtil.Get(map, "AccessKeySecret");
            var securityToken = DictionaryUtil.Get(map, "SecurityToken");
            var expirationStr = DictionaryUtil.Get(map, "Expiration").Replace('T', ' ').Replace('Z', ' ');
            var dt = Convert.ToDateTime(expirationStr);
            var expiration = dt.currentTimeMillis();
            return new BasicSessionCredentials(accessKeyId, accessKeySecret, securityToken,
                expiration - DateTime.UtcNow.currentTimeMillis());
        }
        
        public virtual HttpResponse GetResponse(HttpRequest request)
        {
            return HttpResponse.GetResponse(request);
        }
    }
}
