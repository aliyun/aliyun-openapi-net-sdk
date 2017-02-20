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
        private FormatType _acceptFormat;


        protected AcsRequest(string product)
            : base(null)
        {
            DictionaryUtil.Add(Headers, "x-sdk-client", "NetCore/4.6.2");
            Product = product;
        }

        protected AcsRequest(string product, string version)
            : base(null)
        {
            Product = product;
            Version = version;
        }

        public virtual string Product { get; set; }

        public virtual string Version { get; set; }

        public virtual string ActionName { get; set; }

        public virtual string RegionId { get; set; }

        public ISignatureComposer Composer { get; set; }

        public virtual FormatType AcceptFormat
        {
            get { return _acceptFormat; }
            set
            {
                _acceptFormat = value;
                DictionaryUtil.Add(Headers, "Accept", value.ToString());
            }
        }


        public ProtocolType Protocol { get; set; } = ProtocolType.HTTP;

        public Dictionary<string, string> QueryParameters { get; set; } = new Dictionary<string, string>();

        public static string ConcatQueryString(Dictionary<string, string> parameters)
        {
            if (null == parameters)
                return null;
            var sb = new StringBuilder();

            foreach (var entry in parameters)
            {
                var key = entry.Key;
                var val = entry.Value;

                sb.Append(AcsURLEncoder.Encode(key));
                if (val != null)
                    sb.Append("=").Append(AcsURLEncoder.Encode(val));
                sb.Append("&");
            }

            var strIndex = sb.Length;
            if (parameters.Count > 0)
                sb.Remove(strIndex - 1, 1);

            return sb.ToString();
        }

        public abstract HttpRequest SignRequest(ISigner signer, Credential credential,
            FormatType? format, ProductDomain domain);

        public abstract string ComposeUrl(string endpoint, Dictionary<string, string> queries);

        public abstract T GetResponse(UnmarshallerContext unmarshallerContext);
    }
}