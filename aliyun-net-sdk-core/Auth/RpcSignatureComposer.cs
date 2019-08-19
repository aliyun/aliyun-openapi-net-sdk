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

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth
{
    public class RpcSignatureComposer : ISignatureComposer
    {
        private const string SEPARATOR = "&";
        private static ISignatureComposer composer;

        public Dictionary<string, string> RefreshSignParameters(Dictionary<string, string> parameters,
            Signer signer, string accessKeyId, FormatType? format)
        {
            var immutableMap = new Dictionary<string, string>(parameters);
            DictionaryUtil.Add(immutableMap, "Timestamp", ParameterHelper.FormatIso8601Date(DateTime.UtcNow));
            DictionaryUtil.Add(immutableMap, "SignatureMethod", signer.GetSignerName());
            DictionaryUtil.Add(immutableMap, "SignatureVersion", signer.GetSignerVersion());
            DictionaryUtil.Add(immutableMap, "SignatureNonce", Guid.NewGuid().ToString());
            DictionaryUtil.Add(immutableMap, "AccessKeyId", accessKeyId);

            if (null != format)
            {
                DictionaryUtil.Add(immutableMap, "Format", format.ToString());
            }

            if (signer.GetSignerType() != null)
            {
                DictionaryUtil.Add(immutableMap, "SignatureType", signer.GetSignerType());
            }

            return immutableMap;
        }

        public string ComposeStringToSign(MethodType? method, string uriPattern, Signer signer,
            Dictionary<string, string> queries, Dictionary<string, string> headers, Dictionary<string, string> paths)
        {
            var sortedDictionary = SortDictionary(queries);

            var canonicalizedQueryString = new StringBuilder();
            foreach (var p in sortedDictionary)
            {
                canonicalizedQueryString.Append("&")
                    .Append(AcsURLEncoder.PercentEncode(p.Key)).Append("=")
                    .Append(AcsURLEncoder.PercentEncode(p.Value));
            }

            var stringToSign = new StringBuilder();
            stringToSign.Append(method.ToString());
            stringToSign.Append(SEPARATOR);
            stringToSign.Append(AcsURLEncoder.PercentEncode("/"));
            stringToSign.Append(SEPARATOR);
            stringToSign.Append(AcsURLEncoder.PercentEncode(
                canonicalizedQueryString.ToString().Substring(1)));

            return stringToSign.ToString();
        }

        public static ISignatureComposer GetComposer()
        {
            if (null == composer)
            {
                composer = new RpcSignatureComposer();
            }

            return composer;
        }

        private static IDictionary<string, string> SortDictionary(Dictionary<string, string> dic)
        {
            IDictionary<string, string> sortedDictionary =
                new SortedDictionary<string, string>(dic, StringComparer.Ordinal);
            return sortedDictionary;
        }

        public static void ClearComposer()
        {
            composer = null;
        }
    }
}
