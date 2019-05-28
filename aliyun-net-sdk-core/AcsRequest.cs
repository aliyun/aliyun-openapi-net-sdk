/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System.Collections.Generic;
using System.Text;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core
{
    public abstract class AcsRequest<T> : HttpRequest
    {
        private FormatType acceptFormat;


        public string StringToSign;
        private UserAgent userAgentConfig;

        public AcsRequest(string product) : base(null)
        {
            DictionaryUtil.Add(Headers, "x-sdk-client", "Net/2.0.0");
            DictionaryUtil.Add(Headers, "x-sdk-invoke-type", "normal");
            Product = product;
        }

        public virtual string Product { get; set; }
        public virtual string Version { get; set; }
        public virtual string ActionName { get; set; }
        public virtual string RegionId { get; set; }
        public virtual string SecurityToken { get; set; }
        public ISignatureComposer Composer { get; set; }
        public string LocationProduct { get; set; }
        public string LocationEndpointType { get; set; }
        public ProductDomain ProductDomain { get; set; }

        public virtual FormatType AcceptFormat
        {
            get { return acceptFormat; }
            set
            {
                acceptFormat = value;
                DictionaryUtil.Add(Headers, "Accept", value.ToString());
            }
        }

        private ProtocolType protocol = ProtocolType.HTTP;

        public ProtocolType Protocol
        {
            get { return protocol; }
            set { protocol = value; }
        }

        private Dictionary<string, string> queryParameters = new Dictionary<string, string>();

        public Dictionary<string, string> QueryParameters
        {
            get { return queryParameters; }
            set { queryParameters = value; }
        }

        private Dictionary<string, string> domainParameters = new Dictionary<string, string>();

        public Dictionary<string, string> DomainParameters
        {
            get { return domainParameters; }
            set { domainParameters = value; }
        }

        private Dictionary<string, string> bodyParameters = new Dictionary<string, string>();

        public Dictionary<string, string> BodyParameters
        {
            get { return bodyParameters; }
            set { bodyParameters = value; }
        }

        public static string ConcatQueryString(Dictionary<string, string> parameters)
        {
            if (null == parameters)
            {
                return null;
            }

            var sb = new StringBuilder();

            foreach (var entry in parameters)
            {
                var key = entry.Key;
                var val = entry.Value;

                sb.Append(AcsURLEncoder.Encode(key));
                if (val != null)
                {
                    sb.Append("=").Append(AcsURLEncoder.Encode(val));
                }

                sb.Append("&");
            }

            var strIndex = sb.Length;
            if (parameters.Count > 0)
            {
                sb.Remove(strIndex - 1, 1);
            }

            return sb.ToString();
        }

        public HttpRequest SignRequest(Signer signer, Credential credential,
            FormatType? format, ProductDomain domain)
        {
            return SignRequest(signer, new LegacyCredentials(credential), format, domain);
        }

        public abstract HttpRequest SignRequest(Signer signer, AlibabaCloudCredentials credentials,
            FormatType? format, ProductDomain domain);

        public abstract string ComposeUrl(string endpoint, Dictionary<string, string> queries);

        public abstract T GetResponse(UnmarshallerContext unmarshallerContext);

        public virtual bool CheckShowJsonItemName()
        {
            return true;
        }

        public UserAgent GetSysUserAgentConfig()
        {
            return userAgentConfig;
        }

        public void AppendUserAgent(string key, string value)
        {
            if (userAgentConfig == null)
            {
                userAgentConfig = new UserAgent();
            }

            userAgentConfig.AppendUserAgent(key, value);
        }
    }
}
