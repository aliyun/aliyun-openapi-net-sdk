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
using System.Net;

using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Http
{
    public class HttpRequest
    {
        private int timeout = 100000;

        public HttpRequest()
        {
        }

        public HttpRequest(string strUrl)
        {
            Url = strUrl;
            Headers = new Dictionary<string, string>();
        }

        public HttpRequest(string strUrl, Dictionary<string, string> tmpHeaders)
        {
            Url = strUrl;
            if (null != tmpHeaders)
            {
                Headers = tmpHeaders;
            }
        }

        public Dictionary<string, string> Headers { get; set; }
        public string Url { get; set; }
        public MethodType? Method { get; set; }
        public FormatType? ContentType { get; set; }
        public byte[] Content { get; set; }
        public string Encoding { get; set; }

        [Obsolete(
            "timeoutInMilliSeconds is deprecated as does not match Properties rule, please use TimeoutInMilliseconds instead.")]
        public int timeoutInMilliSeconds
        {
            get { return TimeoutInMilliseconds; }
            set { TimeoutInMilliseconds = value; }
        }

        public int TimeoutInMilliseconds
        {
            get { return timeout; }
            set { timeout = value; }
        }

        [Obsolete("readTimeout is deprecated as does not match Properties rule, please use ReadTimeout instead.")]
        public int readTimeout
        {
            get { return ReadTimeout; }
        }

        public int ReadTimeout { get; private set; }

        [Obsolete("connectTimeout is deprecated as does not match Properties rule, please use ConnectTimeout instead.")]
        public int connectTimeout
        {
            get { return ConnectTimeout; }
        }

        public int ConnectTimeout { get; private set; }

        public bool IgnoreCertificate { get; private set; }

        public IWebProxy WebProxy { get; set; }

        public void SetContent(byte[] content, string encoding, FormatType? format)
        {
            if (null == content)
            {
                DictionaryUtil.Pop(Headers, "Content-MD5");
                DictionaryUtil.Pop(Headers, "Content-Length");
                DictionaryUtil.Pop(Headers, "Content-Type");

                ContentType = null;
                Content = null;
                Encoding = null;
                return;
            }

            var contentLen = content.Length.ToString();
            var strMd5 = ParameterHelper.Md5SumAndBase64(content);
            FormatType? type = FormatType.RAW;
            if (null != format)
            {
                ContentType = format;
                type = format;
            }

            DictionaryUtil.Pop(Headers, "Content-MD5");
            DictionaryUtil.Pop(Headers, "Content-Length");
            DictionaryUtil.Pop(Headers, "Content-Type");

            DictionaryUtil.Add(Headers, "Content-MD5", strMd5);
            if(this.Method.ToString() == "POST" || this.Method.ToString() == "PUT")
            {
                DictionaryUtil.Add(Headers, "Content-Length", contentLen);
            }
            DictionaryUtil.Add(Headers, "Content-Type", ParameterHelper.FormatTypeToString(type));

            Content = content;
            Encoding = encoding;
        }

        public void SetConnectTimeoutInMilliSeconds(int connectTimeout)
        {
            ConnectTimeout = connectTimeout;
        }

        public void SetReadTimeoutInMilliSeconds(int readTimeout)
        {
            ReadTimeout = readTimeout;
        }

        public void SetHttpsInsecure(bool ignoreCertificate = false)
        {
            IgnoreCertificate = ignoreCertificate;
        }
    }
}
