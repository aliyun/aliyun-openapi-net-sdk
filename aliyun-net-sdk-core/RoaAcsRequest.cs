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
using System.Collections.Generic;
using System.Text;

namespace Aliyun.Acs.Core
{
    public abstract class RoaAcsRequest<T> : AcsRequest<T>
    {
        private string uriPattern = null;
        private Dictionary<string, string> pathParameters = new Dictionary<string, string>();

        public RoaAcsRequest(string product)
            : base(product)
        {
            Initialize();
        }

        public RoaAcsRequest(string product, string version)
            : base(product, version)
        {
            this.SetVersion(version);
            Initialize();
        }

        public RoaAcsRequest(string product, string version, string action)
            : base(product)
        {
            this.Version = version;
            this.ActionName = action;
            Initialize();
        }

        public RoaAcsRequest(string product, string version, string action, string locationProduct)
            : base(product)
        {
            Version = version;
            ActionName = action;
            this.LocationProduct = locationProduct;
            Initialize();
        }

        private void Initialize()
        {
            this.AcceptFormat = FormatType.RAW;
            this.Composer = RoaSignatureComposer.GetComposer();
        }


        public void SetVersion(string version)
        {
            base.Version = version;
            DictionaryUtil.Add(Headers, "x-acs-version", version);
        }

        public override string ComposeUrl(string endpoint, Dictionary<string, string> queries)
        {

            Dictionary<string, string> mapQueries = (queries == null) ? QueryParameters : queries;
            StringBuilder urlBuilder = new StringBuilder("");
            urlBuilder.Append(Protocol);
            urlBuilder.Append("://").Append(endpoint);
            if (null != this.uriPattern)
            {
                urlBuilder.Append(RoaSignatureComposer.ReplaceOccupiedParameters(uriPattern, pathParameters));
            }
            if (-1 == urlBuilder.ToString().IndexOf('?'))
            {
                urlBuilder.Append("?");
            }
            else if (!urlBuilder.ToString().EndsWith("?"))
            {
                urlBuilder.Append("&");
            }
            string query = ConcatQueryString(mapQueries);
            string url = urlBuilder.Append(query).ToString();
            if (url.EndsWith("?") || url.EndsWith("&"))
            {
                url = url.Substring(0, url.Length - 1);
            }
            return url;
        }


        public override HttpRequest SignRequest(ISigner signer, Credential credential, FormatType? format, ProductDomain domain)
        {
            Dictionary<string, string> imutableMap = new Dictionary<string, string>(this.Headers);
            if (null != signer && null != credential)
            {
                string accessKeyId = credential.AccessKeyId;
                string accessSecret = credential.AccessSecret;
                imutableMap = this.Composer.RefreshSignParameters(Headers, signer, accessKeyId, format);
                string strToSign = this.Composer.ComposeStringToSign(Method, uriPattern, signer, QueryParameters, imutableMap, pathParameters);
                string signature = signer.SignString(strToSign, accessSecret);
                DictionaryUtil.Add(imutableMap, "Authorization", "acs " + accessKeyId + ":" + signature);
            }
            Url = this.ComposeUrl(domain.DomianName, QueryParameters);
            this.Headers = imutableMap;
            return this;
        }

        protected string UriPattern
        {
            get { return uriPattern; }
            set { uriPattern = value; }
        }

        public Dictionary<string, string> PathParameters
        {
            get { return pathParameters; }
            set { pathParameters = value; }
        }
    }
}
