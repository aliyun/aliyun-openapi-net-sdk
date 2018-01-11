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
using Aliyun.Acs.Core.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Aliyun.Acs.Core.Http
{
    public class HttpResponse : HttpRequest
    {

        private static int _timeout = 100000; // No effect
        private static int bufferLength = 1024;

        public int Status { get; set; }

        public HttpResponse(string strUrl)
            : base(strUrl)
        {

        }

        public HttpResponse()
        {
        }

        public new void SetContent(byte[] content, string encoding, FormatType? format)
        {
            this.Content = content;
            this.Encoding = encoding;
            this.ContentType = format;
        }

        private static async Task PasrseHttpResponse(HttpResponse httpResponse, HttpWebResponse httpWebResponse, CancellationToken ct)
        {
            httpResponse.Content = await ReadContent(httpResponse, httpWebResponse, ct);
            httpResponse.Status = (int)httpWebResponse.StatusCode;
            httpResponse.Headers = new Dictionary<string, string>();
            httpResponse.Method = ParameterHelper.StringToMethodType(httpWebResponse.Method);

            foreach (var key in httpWebResponse.Headers.AllKeys)
            {
                httpResponse.Headers.Add(key, httpWebResponse.Headers[key]);
            }

            string type = httpResponse.Headers["Content-Type"];
            if (null != type)
            {
                httpResponse.Encoding = "UTF-8";
                string[] split = type.Split(';');
                httpResponse.ContentType = ParameterHelper.StingToFormatType(split[0].Trim());
                if (split.Length > 1 && split[1].Contains("="))
                {
                    string[] codings = split[1].Split('=');
                    httpResponse.Encoding = codings[1].Trim().ToUpper();
                }
            }
        }

        public static async Task<byte[]> ReadContent(HttpResponse response, HttpWebResponse rsp, CancellationToken ct)
        {

            MemoryStream ms = new MemoryStream();
            byte[] buffer = new byte[bufferLength];
            Stream stream = rsp.GetResponseStream();

            while (true)
            {
                int length = await stream.ReadAsync(buffer, 0, bufferLength, ct);
                if (length == 0)
                {
                    break;
                }
                await ms.WriteAsync(buffer, 0, length, ct);
            }
            ms.Seek(0, SeekOrigin.Begin);
            byte[] bytes = new byte[ms.Length];
            await ms.ReadAsync(bytes, 0, bytes.Length, ct);

            ms.Close();
            ms.Dispose();
            stream.Close();
            stream.Dispose();
            return bytes;
        }

        public static HttpResponse GetResponse(HttpRequest request, int? timeout = null)
        {
            return GetResponse(request, timeout, CancellationToken.None).Result;
        }

        public static async Task<HttpResponse> GetResponse(HttpRequest request, CancellationToken ct)
        {
            return await GetResponse(request, null, ct);
        }

        public static async Task<HttpResponse> GetResponse(HttpRequest request, int? timeout, CancellationToken ct)
        {
            HttpWebRequest httpWebRequest = GetWebRequest(request);
            if (timeout != null)
            {
                httpWebRequest.Timeout = (int)timeout;
            }

            HttpResponse httpResponse = new HttpResponse(httpWebRequest.RequestUri.AbsoluteUri);
            HttpWebResponse httpWebResponse = null;
            try {
                var now = DateTime.Now;
                ct.ThrowIfCancellationRequested();
                using (ct.Register(httpWebRequest.Abort))
                {
                    var task = Task.Factory.FromAsync(httpWebRequest.BeginGetResponse, httpWebRequest.EndGetResponse, null);
                    httpWebResponse = (HttpWebResponse) await task;
                }
            }
            catch (WebException ex)
            {
                ct.ThrowIfCancellationRequested(); // In case httpWebRequest.Abort was trigger by ct

                if (ex.Response != null)
                {
                    httpWebResponse = (HttpWebResponse)ex.Response;
                }
                else
                {
                    throw ex;
                }
            }

            await PasrseHttpResponse(httpResponse, httpWebResponse, ct);
            return httpResponse;
        }

        public static HttpWebRequest GetWebRequest(HttpRequest request)
        {
            HttpWebRequest httpWebRequest = null;
            httpWebRequest = (HttpWebRequest)WebRequest.Create(request.Url);
            httpWebRequest.ServicePoint.Expect100Continue = false;
            httpWebRequest.Method = request.Method.ToString();
            httpWebRequest.KeepAlive = true;
            httpWebRequest.Timeout = _timeout;

            if (request.Headers.ContainsKey("Accept"))
            {
                httpWebRequest.Accept = DictionaryUtil.Pop(request.Headers, "Accept");
            }
            if (request.Headers.ContainsKey("Date"))
            {
                httpWebRequest.Date = Convert.ToDateTime(DictionaryUtil.Pop(request.Headers, "Date"));
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

                httpWebRequest.Headers.Add(header.Key, header.Value);
            }

            if ((request.Method == MethodType.POST || request.Method == MethodType.PUT) && request.Content != null)
            {
                using (Stream stream = httpWebRequest.GetRequestStream())
                {
                    stream.Write(request.Content, 0, request.Content.Length);
                }
            }
            

            return httpWebRequest;
        }

        public bool isSuccess()
        {
            if (200 <= this.Status &&
                    300 > this.Status)
                return true;
            return false;
        }
    }
}
