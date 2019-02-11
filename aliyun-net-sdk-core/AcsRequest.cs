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

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core
{
    public abstract class AcsRequest<T> : HttpRequest
    {
        private ProtocolType protocol = ProtocolType.HTTP;
        private FormatType acceptFormat;
        private Dictionary<String, String> queryParameters = new Dictionary<String, String>();
        private Dictionary<String, String> domainParameters = new Dictionary<String, String>();
        private Dictionary<String, String> bodyParameters = new Dictionary<String, String>();

        public virtual String Product { get; set; }
        public virtual String Version { get; set; }
        public virtual String ActionName { get; set; }
        public virtual String RegionId { get; set; }
        public virtual String SecurityToken { get; set; }
        public ISignatureComposer Composer { get; set; }
        public String LocationProduct { get; set; }
        public String LocationEndpointType { get; set; }
        public ProductDomain ProductDomain { get; set; }

        public virtual FormatType AcceptFormat
        {
            get
            {
                return acceptFormat;
            }
            set
            {
                acceptFormat = value;
                DictionaryUtil.Add(Headers, "Accept", value.ToString());
            }
        }

        public ProtocolType Protocol
        {
            get
            {
                return protocol;
            }
            set
            {
                protocol = value;
            }
        }

        public Dictionary<String, String> QueryParameters
        {
            get
            {
                return queryParameters;
            }
            set
            {
                queryParameters = value;
            }
        }

        public Dictionary<String, String> DomainParameters
        {
            get
            {
                return domainParameters;
            }
            set
            {
                domainParameters = value;
            }
        }

        public Dictionary<String, String> BodyParameters
        {
            get
            {
                return bodyParameters;
            }
            set
            {
                bodyParameters = value;
            }
        }

        public AcsRequest(String product) : base(null)
        {
            DictionaryUtil.Add(Headers, "x-sdk-client", "Net/2.0.0");
            DictionaryUtil.Add(Headers, "x-sdk-invoke-type", "normal");
            Product = product;
        }

        public static String ConcatQueryString(Dictionary<String, String> parameters)
        {
            if (null == parameters)
            {
                return null;
            }
            StringBuilder sb = new StringBuilder();

            foreach (var entry in parameters)
            {
                String key = entry.Key;
                String val = entry.Value;

                sb.Append(AcsURLEncoder.Encode(key));
                if (val != null)
                {
                    sb.Append("=").Append(AcsURLEncoder.Encode(val));
                }
                sb.Append("&");
            }

            int strIndex = sb.Length;
            if (parameters.Count > 0)
                sb.Remove(strIndex - 1, 1);

            return sb.ToString();
        }

        public HttpRequest SignRequest(Signer signer, Credential credential,
            FormatType? format, ProductDomain domain)
        {
            return SignRequest(signer, new LegacyCredentials(credential), format, domain);
        }

        public abstract HttpRequest SignRequest(Signer signer, AlibabaCloudCredentials credentials,
            FormatType? format, ProductDomain domain);

        public abstract String ComposeUrl(String endpoint, Dictionary<String, String> queries);

        public abstract T GetResponse(UnmarshallerContext unmarshallerContext);

        public virtual bool CheckShowJsonItemName()
        {
            return true;
        }

    }
}
