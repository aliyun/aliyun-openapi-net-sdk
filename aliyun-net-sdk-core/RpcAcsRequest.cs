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
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core
{
    public abstract class RpcAcsRequest<T> : AcsRequest<T>
    {
        private string actionName;
        private string version;
        private FormatType acceptFormat;

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

        public RpcAcsRequest(string product, string version, string action, string locationProduct, string locationEndpointType) : base(product)
        {
            this.Version = version;
            this.ActionName = action;
            this.LocationProduct = locationProduct;
            this.LocationEndpointType = locationEndpointType;
            Initialize();
        }

        private void Initialize()
        {
            Method = MethodType.GET;
            AcceptFormat = FormatType.JSON;
            this.Composer = RpcSignatureComposer.GetComposer();
        }

        public override string ActionName
        {
            get
            {
                return actionName;
            }
            set
            {
                actionName = value;
                QueryParameters.Add("Action", value);
            }
        }

        public override string Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
                QueryParameters.Add("Version", value);
            }
        }

        public override FormatType AcceptFormat
        {
            get
            {
                return acceptFormat;
            }
            set
            {
                acceptFormat = value;
                DictionaryUtil.Add(QueryParameters, "Format", value.ToString());
            }
        }

        public override HttpRequest SignRequest(Signer signer, AlibabaCloudCredentials credentials,
            FormatType? format, ProductDomain domain)
        {
            var imutableMap = new Dictionary<string, string>(QueryParameters);

            if (null != signer && null != credentials)
            {
                var accessKeyId = credentials.GetAccessKeyId();
                var accessSecret = credentials.GetAccessKeySecret();
                if (credentials is BasicSessionCredentials)
                {
                    var sessionToken = ((BasicSessionCredentials)credentials).GetSessionToken();
                    if (null != sessionToken)
                    {
                        QueryParameters.Add("SecurityToken", sessionToken);
                    }
                }

                if (credentials is BearerTokenCredential)
                {
                    var bearerToken = ((BearerTokenCredential)credentials).GetBearerToken();
                    if (null != bearerToken)
                    {
                        QueryParameters.Add("BearerToken", bearerToken);
                    }
                }

                imutableMap = Composer.RefreshSignParameters(QueryParameters, signer, accessKeyId, format);
                imutableMap.Add("RegionId", RegionId);

                var paramsToSign = new Dictionary<string, string>(imutableMap);
                if (this.BodyParameters != null && this.BodyParameters.Count > 0)
                {
                    var formParams = new Dictionary<string, string>(this.BodyParameters);
                    string formStr = ConcatQueryString(formParams);
                    byte[] formData = System.Text.Encoding.UTF8.GetBytes(formStr);
                    this.SetContent(formData, "UTF-8", FormatType.FORM);
                    foreach (var formParam in formParams)
                    {
                        DictionaryUtil.Add(paramsToSign, formParam.Key, formParam.Value);
                    }
                }

                var strToSign = this.Composer.ComposeStringToSign(Method, null, signer, paramsToSign, null, null);
                var signature = signer.SignString(strToSign, accessSecret + "&");
                imutableMap.Add("Signature", signature);

                this.StringToSign = strToSign;
            }

            Url = this.ComposeUrl(domain.DomianName, imutableMap);
            return this;
        }

        public override string ComposeUrl(string endpoint, Dictionary<string, string> queries)
        {
            var mapQueries = (queries == null) ? this.QueryParameters : queries;
            StringBuilder urlBuilder = new StringBuilder("");
            urlBuilder.Append(this.Protocol.ToString().ToLower());
            urlBuilder.Append("://").Append(endpoint);
            if (-1 == urlBuilder.ToString().IndexOf("?"))
            {
                urlBuilder.Append("/?");
            }
            var query = ConcatQueryString(mapQueries);
            return urlBuilder.Append(query).ToString();
        }
    }
}
