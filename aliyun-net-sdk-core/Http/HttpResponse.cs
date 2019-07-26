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
using System.IO;
using System.Net;

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Http
{
    public class HttpResponse : HttpRequest
    {
        // Default read timeout 10s
        private const int DEFAULT_READ_TIMEOUT_IN_MilliSeconds = 10000;

        // Default connect timeout 5s
        private const int DEFAULT_CONNECT_TIMEOUT_In_MilliSeconds = 5000;
        private static readonly int bufferLength = 1024;

        public HttpResponse(string strUrl) : base(strUrl)
        {
        }

        public HttpResponse()
        {
        }

        public int Status { get; set; }

        public string HttpVersion { get; set; }

        public new void SetContent(byte[] content, string encoding, FormatType? format)
        {
            Content = content;
            Encoding = encoding;
            ContentType = format;
        }

        private static void ParseHttpResponse(HttpResponse httpResponse, HttpWebResponse httpWebResponse)
        {
            httpResponse.Content = ReadContent(httpResponse, httpWebResponse);
            httpResponse.Status = (int)httpWebResponse.StatusCode;
            httpResponse.Headers = new Dictionary<string, string>();
            httpResponse.Method = ParameterHelper.StringToMethodType(httpWebResponse.Method);
            httpResponse.HttpVersion = httpWebResponse.ProtocolVersion.ToString();

            foreach (var key in httpWebResponse.Headers.AllKeys)
            {
                httpResponse.Headers.Add(key, httpWebResponse.Headers[key]);
            }

            var contentType = DictionaryUtil.Get(httpResponse.Headers, "Content-Type");

            if (null != contentType)
            {
                httpResponse.Encoding = "UTF-8";
                var split = contentType.Split(';');
                httpResponse.ContentType = ParameterHelper.StingToFormatType(split[0].Trim());
                if (split.Length > 1 && split[1].Contains("="))
                {
                    var codings = split[1].Split('=');
                    httpResponse.Encoding = codings[1].Trim().ToUpper();
                }
            }
        }

        public static byte[] ReadContent(HttpResponse response, HttpWebResponse rsp)
        {
            using (var ms = new MemoryStream())
            using (var stream = rsp.GetResponseStream())
            {
                {
                    var buffer = new byte[bufferLength];
                    while (true)
                    {
                        var length = stream.Read(buffer, 0, bufferLength);
                        if (length == 0)
                        {
                            break;
                        }

                        ms.Write(buffer, 0, length);
                    }

                    ms.Seek(0, SeekOrigin.Begin);
                    var bytes = new byte[ms.Length];
                    ms.Read(bytes, 0, bytes.Length);
                    return bytes;
                }
            }
        }

        public static HttpResponse GetResponse(HttpRequest request, int? timeout = null)
        {
            var httpWebRequest = GetWebRequest(request);

            if (timeout != null)
            {
                httpWebRequest.Timeout = (int)timeout;
            }

            HttpWebResponse httpWebResponse;
            var httpResponse = new HttpResponse(httpWebRequest.RequestUri.AbsoluteUri);

            try
            {
                using (httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    ParseHttpResponse(httpResponse, httpWebResponse);
                    return httpResponse;
                }

            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (httpWebResponse = ex.Response as HttpWebResponse)
                    {
                        ParseHttpResponse(httpResponse, httpWebResponse);
                        return httpResponse;
                    }
                }

                throw new ClientException("SDK.WebException",
                    string.Format("HttpWebRequest WebException occured, the request url is {0} {1}",
                        httpWebRequest.RequestUri == null ? "empty" : httpWebRequest.RequestUri.Host, ex));
            }
            catch (IOException ex)
            {
                throw new ClientException("SDK.ServerUnreachable:",
                    string.Format("Server unreachable: connection to url: {0} failed. {1}",
                        httpWebRequest.RequestUri == null ? "empty" : httpWebRequest.RequestUri.Host,
                        ex));
            }
            catch (Exception ex)
            {
                throw new ClientException("SDK.Exception",
                    string.Format("The request url is {0} {1}",
                        httpWebRequest.RequestUri == null ? "empty" : httpWebRequest.RequestUri.Host, ex));
            }
        }

        public static HttpWebRequest GetWebRequest(HttpRequest request)
        {
            var uri = new Uri(request.Url);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);

            httpWebRequest.Proxy = request.WebProxy;
            httpWebRequest.Method = request.Method.ToString();
            httpWebRequest.KeepAlive = true;

            httpWebRequest.Timeout = request.ConnectTimeout > 0
                ? request.ConnectTimeout
                : DEFAULT_CONNECT_TIMEOUT_In_MilliSeconds;

            httpWebRequest.ReadWriteTimeout =
                request.ReadTimeout > 0 ? request.ReadTimeout : DEFAULT_READ_TIMEOUT_IN_MilliSeconds;

            if (request.IgnoreCertificate)
            {
                httpWebRequest.ServerCertificateValidationCallback = (s, cert, chains, sslPolicyError) => true;
            }

            if (DictionaryUtil.Get(request.Headers, "Accept") != null)
            {
                httpWebRequest.Accept = DictionaryUtil.Pop(request.Headers, "Accept");
            }

            if (DictionaryUtil.Get(request.Headers, "Date") != null)
            {
                var headerDate = DictionaryUtil.Pop(request.Headers, "Date");
                httpWebRequest.Date = Convert.ToDateTime(headerDate);
            }

            foreach (var header in request.Headers)
            {
                if (header.Key.Equals("Content-Length"))
                {
                    httpWebRequest.ContentLength = long.Parse(header.Value);
                    continue;
                }

                if (header.Key.Equals("Content-Type"))
                {
                    httpWebRequest.ContentType = header.Value;
                    continue;
                }

                if (header.Key.Equals("User-Agent"))
                {
                    httpWebRequest.UserAgent = header.Value;
                    continue;
                }

                httpWebRequest.Headers.Add(header.Key, header.Value);
            }

            if ((request.Method == MethodType.POST || request.Method == MethodType.PUT) && request.Content != null)
            {
                using (var stream = httpWebRequest.GetRequestStream())
                {
                    stream.Write(request.Content, 0, request.Content.Length);
                }
            }

            return httpWebRequest;
        }

        public bool isSuccess()
        {
            return 200 <= Status && 300 > Status;
        }
    }
}
