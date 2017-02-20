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
        protected RoaAcsRequest(string product)
            : base(product)
        {
            Initialize();
        }

        protected RoaAcsRequest(string product, string version)
            : base(product, version)
        {
            SetVersion(version);
            Initialize();
        }

        protected RoaAcsRequest(string product, string version, string action)
            : base(product)
        {
            Version = version;
            ActionName = action;
            Initialize();
        }

        protected string UriPattern { get; set; } = null;

        public Dictionary<string, string> PathParameters { get; set; } = new Dictionary<string, string>();

        private void Initialize()
        {
            AcceptFormat = FormatType.RAW;
            Composer = RoaSignatureComposer.GetComposer();
        }


        public void SetVersion(string version)
        {
            Version = version;
            DictionaryUtil.Add(Headers, "x-acs-version", version);
        }

        public override string ComposeUrl(string endpoint, Dictionary<string, string> queries)
        {
            var mapQueries = queries ?? QueryParameters;
            var urlBuilder = new StringBuilder("");
            urlBuilder.Append(Protocol);
            urlBuilder.Append("://").Append(endpoint);
            if (null != UriPattern)
                urlBuilder.Append(RoaSignatureComposer.ReplaceOccupiedParameters(UriPattern, PathParameters));
            if (-1 == urlBuilder.ToString().IndexOf('?'))
                urlBuilder.Append("?");
            else if (!urlBuilder.ToString().EndsWith("?"))
                urlBuilder.Append("&");
            var query = ConcatQueryString(mapQueries);
            var url = urlBuilder.Append(query).ToString();
            if (url.EndsWith("?") || url.EndsWith("&"))
                url = url.Substring(0, url.Length - 1);
            return url;
        }


        public override HttpRequest SignRequest(ISigner signer, Credential credential, FormatType? format, ProductDomain domain)
        {
            var imutableMap = new Dictionary<string, string>(Headers);
            if (null != signer && null != credential)
            {
                var accessKeyId = credential.AccessKeyId;
                var accessSecret = credential.AccessSecret;
                imutableMap = Composer.RefreshSignParameters(Headers, signer, accessKeyId, format);
                var strToSign = Composer.ComposeStringToSign(Method, UriPattern, signer, QueryParameters, imutableMap, PathParameters);
                var signature = signer.SignString(strToSign, accessSecret);
                DictionaryUtil.Add(imutableMap, "Authorization", $"acs {accessKeyId}:{signature}");
            }
            Url = ComposeUrl(domain.DomianName, QueryParameters);
            Headers = imutableMap;
            return this;
        }
    }
}