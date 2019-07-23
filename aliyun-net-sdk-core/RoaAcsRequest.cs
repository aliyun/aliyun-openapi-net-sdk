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
    public abstract class RoaAcsRequest<T> : AcsRequest<T>
    {
        public RoaAcsRequest(string product) : base(product)
        {
            Initialize();
        }

        public RoaAcsRequest(string product, string version) : base(product)
        {
            SetVersion(version);
            Initialize();
        }

        public RoaAcsRequest(string product, string version, string action) : base(product)
        {
            SetVersion(version);
            ActionName = action;
            Initialize();
        }

        public RoaAcsRequest(string product, string version, string action, string locationProduct) : base(product)
        {
            SetVersion(version);
            ActionName = action;
            LocationProduct = locationProduct;
            Initialize();
        }

        public RoaAcsRequest(string product, string version, string action, string locationProduct,
            string locationEndpointType) : base(product)
        {
            SetVersion(version);
            ActionName = action;
            LocationProduct = locationProduct;
            LocationEndpointType = locationEndpointType;
            Initialize();
        }

        public string UriPattern { get; set; }

        private Dictionary<string, string> pathParameters = new Dictionary<string, string>();

        public Dictionary<string, string> PathParameters
        {
            get { return pathParameters; }
            set { pathParameters = value; }
        }

        private void Initialize()
        {
            Method = MethodType.GET;
            AcceptFormat = FormatType.RAW;
            Composer = RoaSignatureComposer.GetComposer();
        }

        public void SetVersion(string version)
        {
            base.Version = version;
            DictionaryUtil.Add(Headers, "x-acs-version", version);
        }

        public override string ComposeUrl(string endpoint, Dictionary<string, string> queries)
        {
            var mapQueries = queries == null ? QueryParameters : queries;
            var urlBuilder = new StringBuilder("");
            urlBuilder.Append(Protocol);
            urlBuilder.Append("://").Append(endpoint);
            if (null != UriPattern)
            {
                urlBuilder.Append(RoaSignatureComposer.ReplaceOccupiedParameters(UriPattern, PathParameters));
            }

            if (-1 == urlBuilder.ToString().IndexOf('?'))
            {
                urlBuilder.Append("?");
            }
            else if (!urlBuilder.ToString().EndsWith("?"))
            {
                urlBuilder.Append("&");
            }

            var query = ConcatQueryString(mapQueries);
            var url = urlBuilder.Append(query).ToString();
            if (url.EndsWith("?") || url.EndsWith("&"))
            {
                url = url.Substring(0, url.Length - 1);
            }

            return url;
        }

        public override HttpRequest SignRequest(Signer signer, AlibabaCloudCredentials credentials,
            FormatType? format, ProductDomain domain)
        {
            if (BodyParameters != null && BodyParameters.Count > 0)
            {
                var formParams = new Dictionary<string, string>(BodyParameters);
                var formStr = ConcatQueryString(formParams);
                var formData = System.Text.Encoding.UTF8.GetBytes(formStr);
                SetContent(formData, "UTF-8", FormatType.FORM);
            }

            var imutableMap = new Dictionary<string, string>(Headers);
            if (null != signer && null != credentials)
            {
                var accessKeyId = credentials.GetAccessKeyId();
                imutableMap = Composer.RefreshSignParameters(Headers, signer, accessKeyId, format);

                var sessionCredentials = credentials as BasicSessionCredentials;
                var sessionToken = sessionCredentials == null ? null : sessionCredentials.GetSessionToken();
                if (sessionToken != null)
                {
                    imutableMap.Add("x-acs-security-token", sessionToken);
                }

                var credential = credentials as BearerTokenCredential;
                var bearerToken = credential == null ? null : credential.GetBearerToken();
                if (bearerToken != null)
                {
                    QueryParameters.Add("x-acs-bearer-token", bearerToken);
                }

                var strToSign = Composer.ComposeStringToSign(Method, UriPattern, signer,
                    QueryParameters, imutableMap, PathParameters);
                var signature = signer.SignString(strToSign, credentials);
                DictionaryUtil.Add(imutableMap, "Authorization", "acs " + accessKeyId + ":" + signature);
            }

            Url = ComposeUrl(domain.DomainName, QueryParameters);
            Headers = imutableMap;
            return this;
        }

        public void AddPathParameters(string name, string value)
        {
            DictionaryUtil.Add(PathParameters, name, value);
        }
    }
}
