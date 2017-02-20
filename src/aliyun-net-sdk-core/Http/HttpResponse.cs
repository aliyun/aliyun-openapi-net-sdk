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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Http
{
    public class HttpResponse : HttpRequest
    {
        //private static int _timeout = 100000;
        private static readonly int BufferLength = 1024;

        public HttpResponse(string strUrl)
            : base(strUrl)
        {
        }

        public HttpResponse()
        {
        }

        public int Status { get; set; }

        public new void SetContent(byte[] content, string encoding, FormatType? format)
        {
            Content = content;
            Encoding = encoding;
            ContentType = format;
        }

        private static byte[] ReadContent(HttpResponseMessage rsp)
        {
            return rsp.Content.ReadAsByteArrayAsync().Result;
        }

        private static byte[] ReadContent(WebResponse rsp)
        {
            using (var ms = new MemoryStream())
            {
                var buffer = new byte[BufferLength];
                using (var stream = rsp.GetResponseStream())
                {
                    while (true)
                    {
                        var length = stream.Read(buffer, 0, BufferLength);
                        if (length == 0)
                            break;
                        ms.Write(buffer, 0, length);
                    }
                    ms.Seek(0, SeekOrigin.Begin);
                    var bytes = new byte[ms.Length];
                    ms.Read(bytes, 0, bytes.Length);

                    //ms.Close();
                    //ms.Dispose();
                    //stream.Close();
                    //stream.Dispose();

                    return bytes;
                }
            }
        }

        public static HttpResponse GetResponse(HttpRequest request)
        {
            var httpRequestMessage = GetHttpRequestMessage(request);

            var httpResponse = new HttpResponse(httpRequestMessage.RequestUri.AbsoluteUri);
            try
            {
                using (var httpClient = GetHttpClient(request))
                {
                    var task = httpClient.GetAsync(httpRequestMessage.RequestUri);
                    //task.Wait();
                    var httpResponseMessage = task.ConfigureAwait(false).GetAwaiter().GetResult();
                    PasrseHttpResponse(httpResponse, httpResponseMessage);
                }
            }
            catch (WebException ex)
            {
                var httpWebResponse = (HttpWebResponse) ex.Response;
                PasrseHttpResponse(httpResponse, httpWebResponse);
            }

            return httpResponse;
        }

        private static HttpClient GetHttpClient(HttpRequest request)
        {
            var httpClientHandler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate | DecompressionMethods.None
            };

            if (request.Url.Contains("https"))
                httpClientHandler.ServerCertificateCustomValidationCallback = CheckValidationResult;

            var httpClient = new HttpClient(httpClientHandler);
            httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("aliyun-ddns-client-csharp")));

            return httpClient;
        }

        private static HttpRequestMessage GetHttpRequestMessage(HttpRequest request)
        {
            var httpRequestMessage = new HttpRequestMessage(new HttpMethod(request.Method.ToString()), new Uri(request.Url));

            if (request.Headers.ContainsKey("Accept"))
                httpRequestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(DictionaryUtil.Pop(request.Headers, "Accept")));
            if (request.Headers.ContainsKey("Date"))
                httpRequestMessage.Headers.Date = Convert.ToDateTime(DictionaryUtil.Pop(request.Headers, "Date"));

            foreach (var header in request.Headers)
                httpRequestMessage.Headers.Add(header.Key, header.Value);

            return httpRequestMessage;
        }

        private static void PasrseHttpResponse(HttpResponse httpResponse, HttpResponseMessage httpWebResponse)
        {
            httpResponse.Content = ReadContent(httpWebResponse);
            httpResponse.Status = (int) httpWebResponse.StatusCode;
            httpResponse.Headers = new Dictionary<string, string>();
            httpResponse.Method = ParameterHelper.StringToMethodType(httpWebResponse.RequestMessage.Method.Method);

            //using (var enumerator = httpWebResponse.Headers.GetEnumerator())
            //{
            //    while (enumerator.MoveNext())
            //    {
            //        httpResponse.Headers.Add(enumerator.Current.Key, string.Join(";", enumerator.Current.Value));
            //    }
            //}
            using (var enumerator = httpWebResponse.Content.Headers.GetEnumerator())
            {
                while (enumerator.MoveNext())
                    httpResponse.Headers.Add(enumerator.Current.Key, string.Join(";", enumerator.Current.Value));
            }

            string type;
            if (httpResponse.Headers.TryGetValue("Content-Type", out type))
            {
                httpResponse.Encoding = "UTF-8";
                var split = type.Split(';');
                httpResponse.ContentType = ParameterHelper.StingToFormatType(split[0].Trim());
                if (split.Length > 1 && split[1].Contains("="))
                {
                    var codings = split[1].Split('=');
                    httpResponse.Encoding = codings[1].Trim().ToUpper();
                }
            }
        }

        private static void PasrseHttpResponse(HttpResponse httpResponse, HttpWebResponse httpWebResponse)
        {
            httpResponse.Content = ReadContent(httpWebResponse);
            httpResponse.Status = (int) httpWebResponse.StatusCode;
            httpResponse.Headers = new Dictionary<string, string>();
            httpResponse.Method = ParameterHelper.StringToMethodType(httpWebResponse.Method);

            foreach (var key in httpWebResponse.Headers.AllKeys)
                httpResponse.Headers.Add(key, httpWebResponse.Headers[key]);

            var type = httpResponse.Headers["Content-Type"];
            if (null != type)
            {
                httpResponse.Encoding = "UTF-8";
                var split = type.Split(';');
                httpResponse.ContentType = ParameterHelper.StingToFormatType(split[0].Trim());
                if (split.Length > 1 && split[1].Contains("="))
                {
                    var codings = split[1].Split('=');
                    httpResponse.Encoding = codings[1].Trim().ToUpper();
                }
            }
        }

        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

        public bool IsSuccess()
        {
            if (200 <= Status &&
                300 > Status)
                return true;
            return false;
        }
    }
}