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
    public class RoaSignatureComposer : ISignatureComposer
    {
        protected const string QUERY_SEPARATOR = "&";
        protected const string HEADER_SEPARATOR = "\n";
        private static ISignatureComposer composer;

        public Dictionary<string, string> RefreshSignParameters(Dictionary<string, string> parameters,
            Signer signer, string accessKeyId, FormatType? format)
        {
            var immutableMap = new Dictionary<string, string>(parameters);
            DictionaryUtil.Add(immutableMap, "Date", ParameterHelper.GetRFC2616Date(DateTime.UtcNow));
            if (null == format)
            {
                format = FormatType.RAW;
            }

            DictionaryUtil.Add(immutableMap, "Accept", ParameterHelper.FormatTypeToString(format));
            DictionaryUtil.Add(immutableMap, "x-acs-signature-method", signer.GetSignerName());
            DictionaryUtil.Add(immutableMap, "x-acs-signature-version", signer.GetSignerVersion());
            if (signer.GetSignerType() != null)
            {
                DictionaryUtil.Add(immutableMap, "x-acs-signature-type", signer.GetSignerType());
            }

            return immutableMap;
        }

        public string ComposeStringToSign(MethodType? method, string uriPattern, Signer signer,
            Dictionary<string, string> queries, Dictionary<string, string> headers,
            Dictionary<string, string> paths)
        {
            var sb = new StringBuilder();
            sb.Append(method).Append(HEADER_SEPARATOR);
            if (headers.ContainsKey("Accept"))
            {
                sb.Append(headers["Accept"]);
            }

            sb.Append(HEADER_SEPARATOR);
            if (headers.ContainsKey("Content-MD5"))
            {
                sb.Append(headers["Content-MD5"]);
            }

            sb.Append(HEADER_SEPARATOR);
            if (headers.ContainsKey("Content-Type"))
            {
                sb.Append(headers["Content-Type"]);
            }

            sb.Append(HEADER_SEPARATOR);
            if (headers.ContainsKey("Date"))
            {
                sb.Append(headers["Date"]);
            }

            sb.Append(HEADER_SEPARATOR);
            var uri = ReplaceOccupiedParameters(uriPattern, paths);
            sb.Append(BuildCanonicalHeaders(headers, "x-acs-"));
            sb.Append(BuildQuerystring(uri, queries));
            return sb.ToString();
        }

        private string[] SplitSubResource(string uri)
        {
            var queIndex = uri.IndexOf("?");
            var uriParts = new string[2];
            if (-1 != queIndex)
            {
                uriParts[0] = uri.Substring(0, queIndex);
                uriParts[1] = uri.Substring(queIndex + 1);
            }
            else
            {
                uriParts[0] = uri;
            }

            return uriParts;
        }

        private string BuildQuerystring(string uri, Dictionary<string, string> queries)
        {
            var uriParts = SplitSubResource(uri);
            var sortMap = new Dictionary<string, string>(queries);
            if (null != uriParts[1])
            {
                sortMap.Add(uriParts[1], null);
            }

            var queryBuilder = new StringBuilder(uriParts[0]);
            var sortedDictionary = SortDictionary(sortMap);
            if (0 < sortedDictionary.Count)
            {
                queryBuilder.Append("?");
            }

            foreach (var e in sortedDictionary)
            {
                queryBuilder.Append(e.Key);
                if (null != e.Value)
                {
                    queryBuilder.Append("=").Append(e.Value);
                }

                queryBuilder.Append(QUERY_SEPARATOR);
            }

            var querystring = queryBuilder.ToString();
            if (querystring.EndsWith(QUERY_SEPARATOR))
            {
                querystring = querystring.Substring(0, querystring.Length - 1);
            }

            return querystring;
        }

        protected string BuildCanonicalHeaders(Dictionary<string, string> headers, string headerBegin)
        {
            var sortMap = new Dictionary<string, string>();
            foreach (var e in headers)
            {
                var key = e.Key.ToLower();
                var val = e.Value;
                if (key.StartsWith(headerBegin))
                {
                    sortMap.Add(key, val);
                }
            }

            var sortedDictionary = SortDictionary(sortMap);

            var headerBuilder = new StringBuilder();
            foreach (var e in sortedDictionary)
            {
                headerBuilder.Append(e.Key);
                headerBuilder.Append(':').Append(e.Value);
                headerBuilder.Append(HEADER_SEPARATOR);
            }

            return headerBuilder.ToString();
        }

        public static string ReplaceOccupiedParameters(string url, Dictionary<string, string> paths)
        {
            var result = url;
            foreach (var entry in paths)
            {
                var key = entry.Key;
                var value = entry.Value;
                var target = "[" + key + "]";
                result = result.Replace(target, value);
            }

            return result;
        }

        public static ISignatureComposer GetComposer()
        {
            if (null == composer)
            {
                composer = new RoaSignatureComposer();
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
