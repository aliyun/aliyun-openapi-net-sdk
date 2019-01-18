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
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aliyun.Acs.Core
{
    public abstract class RpcAcsRequest<T> : AcsRequest<T>
    {
        private string actionName;
        private string version;
        private FormatType acceptFormat;

        public RpcAcsRequest(String product)
            : base(product)
        {
            Initialize();
        }

        public RpcAcsRequest(String product, String version)
            : base(product)
        {
            Version = version;
            Initialize();
        }

        public RpcAcsRequest(String product, String version, String action)
            : base(product)
        {
            Version = version;
            ActionName = action;
            Initialize();
        }

        public RpcAcsRequest(String product, String version, String action, String locationProduct)
            : base(product)
        {
            Version = version;
            ActionName = action;
            LocationProduct = locationProduct;
            Initialize();
        }

        public RpcAcsRequest(String product, String version, String action, String locationProduct, String locationEndpointType)
            : base(product)
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
            Dictionary<String, String> imutableMap = new Dictionary<String, String>(QueryParameters);

            if (null != signer && null != credentials)
            {
                String accessKeyId = credentials.GetAccessKeyId();
                String accessSecret = credentials.GetAccessKeySecret();
                if (credentials is BasicSessionCredentials)
                {
                    String sessionToken = ((BasicSessionCredentials)credentials).GetSessionToken();
                    if (null != sessionToken)
                    {
                        QueryParameters.Add("SecurityToken", sessionToken);
                    }
                }
                imutableMap = Composer.RefreshSignParameters(QueryParameters, signer, accessKeyId, format);
                imutableMap.Add("RegionId", RegionId);

                Dictionary<String, String> paramsToSign = new Dictionary<String, String>(imutableMap);
                if (this.BodyParameters != null && this.BodyParameters.Count > 0)
                {
                    Dictionary<String, String> formParams = new Dictionary<String, String>(this.BodyParameters);
                    string formStr = ConcatQueryString(formParams);
                    byte[] formData = System.Text.Encoding.UTF8.GetBytes(formStr);
                    this.SetContent(formData, "UTF-8", FormatType.FORM);
                    foreach (var formParam in formParams)
                    {
                        DictionaryUtil.Add(paramsToSign, formParam.Key, formParam.Value);
                    }
                }

                String strToSign = this.Composer.ComposeStringToSign(Method, null, signer, paramsToSign, null, null);
                String signature = signer.SignString(strToSign, accessSecret + "&");
                imutableMap.Add("Signature", signature);
            }

            Url = this.ComposeUrl(domain.DomianName, imutableMap);
            return this;
        }

        public override String ComposeUrl(String endpoint, Dictionary<String, String> queries)
        {
            Dictionary<String, String> mapQueries = (queries == null) ? this.QueryParameters : queries;
            StringBuilder urlBuilder = new StringBuilder("");
            urlBuilder.Append(this.Protocol.ToString().ToLower());
            urlBuilder.Append("://").Append(endpoint);
            if (-1 == urlBuilder.ToString().IndexOf("?"))
            {
                urlBuilder.Append("/?");
            }
            String query = ConcatQueryString(mapQueries);
            return urlBuilder.Append(query).ToString();
        }
    }
}
