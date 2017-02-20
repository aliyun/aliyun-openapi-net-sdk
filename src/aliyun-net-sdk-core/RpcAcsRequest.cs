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
        private FormatType _acceptFormat;
        private string _actionName;
        private string _version;

        protected RpcAcsRequest(string product)
            : base(product)
        {
            Initialize();
        }

        protected RpcAcsRequest(string product, string version)
            : base(product)
        {
            Version = version;
            Initialize();
        }

        protected RpcAcsRequest(string product, string version, string action)
            : base(product)
        {
            Version = version;
            ActionName = action;
            Initialize();
        }

        public override string ActionName
        {
            get { return _actionName; }
            set
            {
                _actionName = value;
                QueryParameters.Add("Action", value);
            }
        }

        public override string Version
        {
            get { return _version; }
            set
            {
                _version = value;
                QueryParameters.Add("Version", value);
            }
        }

        public override FormatType AcceptFormat
        {
            get { return _acceptFormat; }
            set
            {
                _acceptFormat = value;
                DictionaryUtil.Add(QueryParameters, "Format", value.ToString());
            }
        }

        private void Initialize()
        {
            Method = MethodType.GET;
            AcceptFormat = FormatType.XML;
            Composer = RpcSignatureComposer.GetComposer();
        }

        public override HttpRequest SignRequest(ISigner signer, Credential credential, FormatType? format, ProductDomain domain)
        {
            var imutableMap = new Dictionary<string, string>(QueryParameters);
            if (null != signer && null != credential)
            {
                var accessKeyId = credential.AccessKeyId;
                var accessSecret = credential.AccessSecret;
                imutableMap = Composer.RefreshSignParameters(QueryParameters, signer, accessKeyId, format);
                imutableMap.Add("RegionId", RegionId);
                var strToSign = Composer.ComposeStringToSign(Method, null, signer, imutableMap, null, null);
                var signature = signer.SignString(strToSign, accessSecret + "&");
                imutableMap.Add("Signature", signature);
            }
            var request = new HttpRequest(ComposeUrl(domain.DomianName, imutableMap)) {Method = Method};
            return request;
        }

        public override string ComposeUrl(string endpoint, Dictionary<string, string> queries)
        {
            var mapQueries = queries ?? QueryParameters;
            var urlBuilder = new StringBuilder("");
            urlBuilder.Append(Protocol.ToString().ToLower());
            urlBuilder.Append("://").Append(endpoint);
            if (-1 == urlBuilder.ToString().IndexOf("?", StringComparison.Ordinal))
                urlBuilder.Append("/?");
            var query = ConcatQueryString(mapQueries);
            return urlBuilder.Append(query).ToString();
        }
    }
}