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
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core
{
    public abstract class RpcAcsRequest<T> : AcsRequest<T>
    {
        private FormatType acceptFormat;
        private string actionName;
        private string version;

        public RpcAcsRequest(string product) : base(product)
        {
            Initialize();
        }

        public RpcAcsRequest(string product, string version) : base(product)
        {
            Version = version;
            Initialize();
        }

        public RpcAcsRequest(string product, string version, string action) : base(product)
        {
            Version = version;
            ActionName = action;
            Initialize();
        }

        public RpcAcsRequest(string product, string version, string action, string locationProduct) : base(product)
        {
            Version = version;
            ActionName = action;
            LocationProduct = locationProduct;
            Initialize();
        }

        public RpcAcsRequest(string product, string version, string action, string locationProduct,
            string locationEndpointType) : base(product)
        {
            Version = version;
            ActionName = action;
            LocationProduct = locationProduct;
            LocationEndpointType = locationEndpointType;
            Initialize();
        }

        public override string ActionName
        {
            get { return actionName; }
            set
            {
                actionName = value;
                DictionaryUtil.Add(QueryParameters, "Action", value);
            }
        }

        public override string Version
        {
            get { return version; }
            set
            {
                version = value;
                DictionaryUtil.Add(QueryParameters, "Version", value);
            }
        }

        public override FormatType AcceptFormat
        {
            get { return acceptFormat; }
            set
            {
                acceptFormat = value;
                DictionaryUtil.Add(QueryParameters, "Format", value.ToString());
            }
        }

        private void Initialize()
        {
            Method = MethodType.GET;
            AcceptFormat = FormatType.JSON;
            Composer = RpcSignatureComposer.GetComposer();
        }

        public override HttpRequest SignRequest(Signer signer, AlibabaCloudCredentials credentials,
            FormatType? format, ProductDomain domain)
        {
            var imutableMap = new Dictionary<string, string>(QueryParameters);

            if (null != signer && null != credentials)
            {
                var accessKeyId = credentials.GetAccessKeyId();
                var accessSecret = credentials.GetAccessKeySecret();

                var sessionCredentials = credentials as BasicSessionCredentials;
                var sessionToken = sessionCredentials == null ? null : sessionCredentials.GetSessionToken();
                if (sessionToken != null)
                {
                    DictionaryUtil.Add(QueryParameters, "SecurityToken", sessionToken);
                }

                var credential = credentials as BearerTokenCredential;
                var bearerToken = credential == null ? null : credential.GetBearerToken();
                if (bearerToken != null)
                {
                    DictionaryUtil.Add(QueryParameters, "BearerToken", bearerToken);
                }

                imutableMap = Composer.RefreshSignParameters(QueryParameters, signer, accessKeyId, format);
                DictionaryUtil.Add(imutableMap, "RegionId", RegionId);

                var paramsToSign = new Dictionary<string, string>(imutableMap);
                if (BodyParameters != null && BodyParameters.Count > 0)
                {
                    var formParams = new Dictionary<string, string>(BodyParameters);
                    var formStr = ConcatQueryString(formParams);
                    var formData = System.Text.Encoding.UTF8.GetBytes(formStr);
                    SetContent(formData, "UTF-8", FormatType.FORM);
                    foreach (var formParam in formParams)
                    {
                        DictionaryUtil.Add(paramsToSign, formParam.Key, formParam.Value);
                    }
                }

                var strToSign = Composer.ComposeStringToSign(Method, null, signer, paramsToSign, null, null);
                var signature = signer.SignString(strToSign, accessSecret + "&");
                DictionaryUtil.Add(imutableMap, "Signature", signature);

                StringToSign = strToSign;
            }

            Url = ComposeUrl(domain.DomainName, imutableMap);
            return this;
        }

        public override string ComposeUrl(string endpoint, Dictionary<string, string> queries)
        {
            var mapQueries = queries == null ? QueryParameters : queries;
            var urlBuilder = new StringBuilder("");
            urlBuilder.Append(Protocol.ToString().ToLower());
            urlBuilder.Append("://").Append(endpoint);
            if (!urlBuilder.ToString().Contains("?"))
            {
                urlBuilder.Append("/?");
            }

            var query = ConcatQueryString(mapQueries);
            return urlBuilder.Append(query).ToString();
        }
    }
}
