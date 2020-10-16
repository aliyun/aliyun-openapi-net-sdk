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

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

        private Dictionary<string, string> bodyParameters = new Dictionary<string, string>();

        private Dictionary<string, string> domainParameters = new Dictionary<string, string>();

        private string productNetwork = "public";

        private string productSuffix;

        private ProtocolType protocol = ProtocolType.HTTP;

        private Dictionary<string, string> queryParameters = new Dictionary<string, string>();

        private string regionId;

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
        public virtual string RegionId
        {
            get
            {
                return regionId;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    var match = Regex.Match(value, "^[a-zA-Z0-9_-]+$");
                    if (!match.Success)
                    {
                        throw new ArgumentException("regionId is invalid", "regionId");
                    }
                }
                
                regionId = value;
            }
        }
        public virtual string SecurityToken { get; set; }
        public ISignatureComposer Composer { get; set; }
        public string LocationProduct { get; set; }
        public string LocationEndpointType { get; set; }
        public ProductDomain ProductDomain { get; set; }

        public string ProductNetwork
        {
            get
            {
                return productNetwork;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    var match = Regex.Match(value, "^[a-zA-Z0-9_-]+$");
                    if (!match.Success)
                    {
                        throw new ArgumentException("productNetwork is invalid", "productNetwork");
                    }
                }
                
                productNetwork = value;
            }
        }

        public string ProductSuffix
        {
            get
            {
                return productSuffix;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    var match = Regex.Match(value, "^[a-zA-Z0-9_-]+$");
                    if (!match.Success)
                    {
                        throw new ArgumentException("productSuffix is invalid", "productSuffix");
                    }
                }
                
                productSuffix = value;
            }
        }

        public virtual FormatType AcceptFormat
        {
            get { return acceptFormat; }
            set
            {
                acceptFormat = value;
                DictionaryUtil.Add(Headers, "Accept", value.ToString());
            }
        }

        public ProtocolType Protocol
        {
            get { return protocol; }
            set { protocol = value; }
        }

        public Dictionary<string, string> QueryParameters
        {
            get { return queryParameters; }
            set { queryParameters = value; }
        }

        public Dictionary<string, string> DomainParameters
        {
            get { return domainParameters; }
            set { domainParameters = value; }
        }

        public Dictionary<string, string> BodyParameters
        {
            get { return bodyParameters; }
            set { bodyParameters = value; }
        }

        public Dictionary<string, string> ProductEndpointMap { get; set; }

        public string ProductEndpointType { get; set; }

        public void SetProductDomain(string endpoint = "")
        {
            if (endpoint == "")
            {
                endpoint = GetProductEndpoint();
            }

            if (endpoint != "" && ProductDomain == null)
            {
                ProductDomain = new ProductDomain { ProductName = Product, DomainName = endpoint };
            }
        }

        public void SetEndpoint(string endpoint)
        {
            ProductDomain = new ProductDomain { ProductName = Product, DomainName = endpoint };
        }

        public string GetProductEndpoint()
        {
            if (ProductEndpointMap == null && ProductEndpointType == null)
            {
                return "";
            }

            foreach (var endpointItem in ProductEndpointMap)
            {
                if (endpointItem.Key == RegionId)
                {
                    return endpointItem.Value;
                }
            }

            var endpoint = "";
            if (ProductEndpointType == "central")
            {
                endpoint = "<product_id><suffix><network>.aliyuncs.com";
            }
            else if (ProductEndpointType == "regional")
            {
                endpoint = "<product_id><suffix><network>.<region_id>.aliyuncs.com";
                endpoint = endpoint.Replace("<region_id>", RegionId);
            }

            if (string.IsNullOrWhiteSpace(ProductSuffix))
            {
                endpoint = endpoint.Replace("<suffix>", string.Empty);
            }
            else
            {
                endpoint = endpoint.Replace("<suffix>", ProductSuffix);
            }

            if (endpoint == "")
            {
                return "";
            }

            endpoint = endpoint.Replace("<product_id>", Product.ToLower());

            endpoint = ProductNetwork == "public" ?
                endpoint.Replace("<network>", "") :
                endpoint.Replace("<network>", "-" + ProductNetwork);

            return endpoint;
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
