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
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Http
{
    public class HttpRequest
    {
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
                Headers = tmpHeaders;
        }

        public Dictionary<string, string> Headers { get; set; }
        public string Url { get; set; }
        public MethodType? Method { get; set; }
        public FormatType? ContentType { get; set; }
        public byte[] Content { get; set; }
        public string Encoding { get; set; }

        public void SetContent(byte[] content, string encoding, FormatType? format)
        {
            if (null == content)
            {
                Headers.Remove("Content-MD5");
                Headers.Remove("Content-Length");
                Headers.Remove("Content-Type");
                ContentType = null;
                Content = null;
                Encoding = null;
                return;
            }
            var contentLen = content.Length.ToString();
            var strMd5 = ParameterHelper.Md5Sum(content);
            FormatType? type = FormatType.RAW;
            if (null != format)
            {
                ContentType = format;
                type = format;
            }
            Headers.Add("Content-MD5", strMd5);
            Headers.Add("Content-Length", contentLen);
            Headers.Add("Content-Type", ParameterHelper.FormatTypeToString(type));

            Content = content;
            Encoding = encoding;
        }
    }
}