/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements. See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership. The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Http
{
    public class TlsMinVersionTest
    {
        private const SslProtocols Tls13 = (SslProtocols)12288;

        [Theory]
        [InlineData("TLSv1", 16320)]
        [InlineData("TLSv1.1", 16128)]
        [InlineData("TLSv1.2", 15360)]
        [InlineData("TLSv1.3", 12288)]
        public void MinimumIncludesAllKnownHigherVersions(string minimum, int expected)
        {
            Assert.Equal((SslProtocols)expected, TlsHttpClient.GetProtocols(minimum));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("1.2")]
        [InlineData("TLSv1.4")]
        [InlineData("tlsv1.2")]
        public void InvalidMinimumIsRejectedBeforeSending(string minimum)
        {
            using (var client = new DefaultAcsClient())
            {
                Assert.Throws<ArgumentException>(() => client.TlsMinVersion = minimum);
                Assert.Null(client.TlsMinVersion);
            }
        }

        [Fact]
        public void UnsetMinimumPreservesLegacyRequestAndGlobalProtocolSetting()
        {
            var originalProtocols = ServicePointManager.SecurityProtocol;
            using (var server = new LoopbackServer(stream => WriteResponse(stream, 200, "legacy")))
            using (var client = new DefaultAcsClient())
            {
                Assert.Null(client.TlsMinVersion);
                var request = CreateRequest(server.Url);
                request.Headers.Add("Accept", "application/json");

                var response = client.GetResponse(request);

                Assert.Equal("legacy", response.GetHttpContentString());
                Assert.Equal(originalProtocols, ServicePointManager.SecurityProtocol);
                // The existing HttpWebRequest path consumes this restricted header.
                Assert.False(request.Headers.ContainsKey("Accept"));
                server.Complete();
            }
        }

        [Fact]
        public void ClearingMinimumRestoresLegacyRequestPath()
        {
            using (var server = new LoopbackServer(stream => WriteResponse(stream, 200, "legacy")))
            using (var client = new DefaultAcsClient())
            {
                client.TlsMinVersion = "TLSv1.2";
                client.TlsMinVersion = null;
                var request = CreateRequest(server.Url);
                request.Headers.Add("Accept", "application/json");

                Assert.Equal(200, client.GetResponse(request).Status);
                Assert.False(request.Headers.ContainsKey("Accept"));
                server.Complete();
            }
        }

        [Theory]
        [InlineData(200)]
        [InlineData(400)]
        [InlineData(503)]
        public void HttpResponsesPreserveStatusHeadersAndBody(int status)
        {
            var originalProtocols = ServicePointManager.SecurityProtocol;
            using (var server = new LoopbackServer(stream => WriteResponse(stream, status, "{\"message\":\"响应\"}")))
            using (var client = new DefaultAcsClient { TlsMinVersion = "TLSv1.2" })
            {
                var response = client.GetResponse(CreateRequest(server.Url));

                Assert.Equal(status, response.Status);
                Assert.Equal("{\"message\":\"响应\"}", response.GetHttpContentString());
                Assert.Equal("test-request-id", response.Headers["X-Test-Request-Id"]);
                Assert.Equal(FormatType.JSON, response.ContentType);
                Assert.Equal("UTF-8", response.Encoding);
                Assert.Equal(MethodType.GET, response.Method);
                Assert.Equal("1.1", response.HttpVersion);
                Assert.Equal(originalProtocols, ServicePointManager.SecurityProtocol);
                server.Complete();
            }
        }

        [Theory]
        [InlineData(MethodType.POST)]
        [InlineData(MethodType.PUT)]
        public void RequestContentAndHeadersAreTransmitted(MethodType method)
        {
            using (var server = new LoopbackServer(stream => WriteResponse(stream, 200, "ok")))
            using (var client = new DefaultAcsClient { TlsMinVersion = "TLSv1.2" })
            {
                var request = CreateRequest(server.Url);
                request.Method = method;
                request.SetContent(Encoding.UTF8.GetBytes("{\"name\":\"测试\"}"), "UTF-8", FormatType.JSON);
                request.Headers.Add("Accept", "application/json");
                request.Headers.Add("User-Agent", "sdk-tls-test/1.0");
                request.Headers.Add("X-Custom", "custom-value");

                Assert.Equal(200, client.GetResponse(request).Status);
                server.Complete();

                Assert.StartsWith(method + " / HTTP/1.1", server.RequestLine);
                Assert.Equal(request.Content, server.RequestBody);
                Assert.Equal("application/json", server.RequestHeaders["Accept"]);
                Assert.Equal("application/json", server.RequestHeaders["Content-Type"]);
                Assert.Equal("sdk-tls-test/1.0", server.RequestHeaders["User-Agent"]);
                Assert.Equal("custom-value", server.RequestHeaders["X-Custom"]);
            }
        }

        [Fact]
        public void ExplicitProxyReceivesTheRequest()
        {
            using (var proxy = new LoopbackServer(stream => WriteResponse(stream, 200, "proxied")))
            using (var client = new DefaultAcsClient { TlsMinVersion = "TLSv1.2" })
            {
                // .NET Framework always bypasses proxies for loopback destinations.
                var request = CreateRequest("http://sdk-proxy-target.invalid/");
                request.WebProxy = new WebProxy(proxy.Url) { BypassProxyOnLocal = false };
                Assert.False(request.WebProxy.IsBypassed(new Uri(request.Url)));

                Assert.Equal("proxied", client.GetResponse(request).GetHttpContentString());
                proxy.Complete();
                Assert.Equal("GET http://sdk-proxy-target.invalid/ HTTP/1.1", proxy.RequestLine);
            }
        }

        [Fact]
        public void ResponseHeadersTimeoutUsesSdkException()
        {
            using (var release = new ManualResetEventSlim())
            using (var server = new LoopbackServer(stream => release.Wait(TimeSpan.FromSeconds(5))))
            using (var client = new DefaultAcsClient { TlsMinVersion = "TLSv1.2" })
            {
                var request = CreateRequest(server.Url);
                request.SetConnectTimeoutInMilliSeconds(200);
                request.SetReadTimeoutInMilliSeconds(4000);
                try
                {
                    var error = Assert.Throws<ClientException>(() => client.GetResponse(request));
                    Assert.Equal("SDK.WebException", error.ErrorCode);
                }
                finally
                {
                    release.Set();
                }
                server.Complete();
            }
        }

        [Fact]
        public void ResponseBodyTimeoutUsesSdkException()
        {
            using (var release = new ManualResetEventSlim())
            using (var server = new LoopbackServer(stream =>
            {
                WriteText(stream, "HTTP/1.1 200 OK\r\nContent-Length: 10\r\nConnection: close\r\n\r\na");
                release.Wait(TimeSpan.FromSeconds(5));
            }))
            using (var client = new DefaultAcsClient { TlsMinVersion = "TLSv1.2" })
            {
                var request = CreateRequest(server.Url);
                request.SetConnectTimeoutInMilliSeconds(4000);
                request.SetReadTimeoutInMilliSeconds(200);
                try
                {
                    var error = Assert.Throws<ClientException>(() => client.GetResponse(request));
                    Assert.Equal("SDK.WebException", error.ErrorCode);
                }
                finally
                {
                    release.Set();
                }
                server.Complete();
            }
        }

        [Fact]
        public void ReadTimeoutResetsWhileResponseBodyMakesProgress()
        {
            using (var server = new LoopbackServer(stream =>
            {
                WriteText(stream, "HTTP/1.1 200 OK\r\nContent-Type: text/plain; charset=UTF-8\r\n" +
                    "Content-Length: 5\r\nConnection: close\r\n\r\n");
                for (var index = 0; index < 5; index++)
                {
                    WriteText(stream, "a");
                    if (index < 4)
                    {
                        Thread.Sleep(400);
                    }
                }
            }))
            using (var client = new DefaultAcsClient { TlsMinVersion = "TLSv1.2" })
            {
                var request = CreateRequest(server.Url);
                request.SetReadTimeoutInMilliSeconds(1000);

                Assert.Equal("aaaaa", client.GetResponse(request).GetHttpContentString());
                server.Complete();
            }
        }

        [Fact]
        public void Minimum12NegotiatesTls12()
        {
            var originalProtocols = ServicePointManager.SecurityProtocol;
            using (var server = new LoopbackServer(stream => WriteResponse(stream, 200, "tls12"), SslProtocols.Tls12))
            using (var client = new DefaultAcsClient { TlsMinVersion = "TLSv1.2" })
            {
                var request = CreateRequest(server.Url);
                request.SetHttpsInsecure(true);

                Assert.Equal("tls12", GetSuccessfulResponse(client, server, request).GetHttpContentString());
                server.Complete();
                Assert.Equal(SslProtocols.Tls12, server.NegotiatedProtocol);
                Assert.Equal(originalProtocols, ServicePointManager.SecurityProtocol);
            }
        }

        [Fact]
        public void CertificateValidationRemainsEnabledByDefault()
        {
            using (var server = new LoopbackServer(stream => WriteResponse(stream, 200, "unexpected"), SslProtocols.Tls12))
            using (var client = new DefaultAcsClient { TlsMinVersion = "TLSv1.2" })
            {
                var error = Assert.Throws<ClientException>(() => client.GetResponse(CreateRequest(server.Url)));
                Assert.Equal("SDK.WebException", error.ErrorCode);
            }
        }

        [Fact]
        public void ChangingMinimumDoesNotReusePreviousTlsPolicy()
        {
            using (var client = new DefaultAcsClient { TlsMinVersion = "TLSv1.2" })
            {
                using (var server = new LoopbackServer(stream => WriteResponse(stream, 200, "tls12"), SslProtocols.Tls12))
                {
                    var request = CreateRequest(server.Url);
                    request.SetHttpsInsecure(true);
                    Assert.Equal(200, GetSuccessfulResponse(client, server, request).Status);
                    server.Complete();
                }

                client.TlsMinVersion = "TLSv1.3";
                using (var server = new LoopbackServer(stream => WriteResponse(stream, 200, "unexpected"), SslProtocols.Tls12))
                {
                    var request = CreateRequest(server.Url);
                    request.SetHttpsInsecure(true);
                    var error = Record.Exception(() => client.GetResponse(request));
                    Assert.NotNull(error);
                    Assert.True(error is ClientException || error is PlatformNotSupportedException,
                        "An unavailable TLS version must fail instead of falling back: " + error);
                    if (error is ClientException)
                    {
                        Assert.Equal("SDK.WebException", ((ClientException)error).ErrorCode);
                    }
                }
            }
        }

        [Fact]
        public void ChangingMinimumDoesNotReuseAnEstablishedTls12Connection()
        {
            using (var server = new KeepAliveTlsServer())
            using (var client = new DefaultAcsClient { TlsMinVersion = "TLSv1.2" })
            using (var otherClient = new DefaultAcsClient { TlsMinVersion = "TLSv1.2" })
            {
                var request = CreateRequest(server.Url);
                request.SetHttpsInsecure(true);
                Assert.Equal(200, server.GetSuccessfulResponse(client, request).Status);

                client.TlsMinVersion = "TLSv1.3";
                var error = Record.Exception(() => client.GetResponse(request));
                Assert.NotNull(error);
                Assert.True(error is ClientException || error is PlatformNotSupportedException,
                    "An established TLS 1.2 connection must not bypass the new minimum: " + error);
                Assert.Equal(200, server.GetSuccessfulResponse(otherClient, request).Status);
            }
        }

        [LegacyTlsFact]
        public void Minimum12RejectsTls11AfterConfirmingServerSupportsIt()
        {
            using (var client = new DefaultAcsClient { TlsMinVersion = "TLSv1.1" })
            {
                using (var server = new LoopbackServer(stream => WriteResponse(stream, 200, "tls11"), SslProtocols.Tls11))
                {
                    var request = CreateRequest(server.Url);
                    request.SetHttpsInsecure(true);
                    Assert.Equal(200, GetSuccessfulResponse(client, server, request).Status);
                    server.Complete();
                    Assert.Equal(SslProtocols.Tls11, server.NegotiatedProtocol);
                }

                client.TlsMinVersion = "TLSv1.2";
                using (var server = new LoopbackServer(stream => WriteResponse(stream, 200, "unexpected"), SslProtocols.Tls11))
                {
                    var request = CreateRequest(server.Url);
                    request.SetHttpsInsecure(true);
                    var error = Assert.Throws<ClientException>(() => client.GetResponse(request));
                    Assert.Equal("SDK.WebException", error.ErrorCode);
                }
            }
        }

        [Tls13Fact]
        public void Minimum12AllowsTls13()
        {
            using (var server = new LoopbackServer(stream => WriteResponse(stream, 200, "tls13"), Tls13))
            using (var client = new DefaultAcsClient { TlsMinVersion = "TLSv1.2" })
            {
                var request = CreateRequest(server.Url);
                request.SetHttpsInsecure(true);

                Assert.Equal("tls13", GetSuccessfulResponse(client, server, request).GetHttpContentString());
                server.Complete();
                Assert.Equal(Tls13, server.NegotiatedProtocol);
            }
        }

        private static HttpRequest CreateRequest(string url)
        {
            var request = new HttpRequest(url) { Method = MethodType.GET };
            request.SetConnectTimeoutInMilliSeconds(4000);
            request.SetReadTimeoutInMilliSeconds(4000);
            return request;
        }

        private static HttpResponse GetSuccessfulResponse(DefaultAcsClient client, LoopbackServer server, HttpRequest request)
        {
            try
            {
                return client.GetResponse(request);
            }
            catch (Exception clientError)
            {
                try
                {
                    server.Complete();
                }
                catch (Exception serverError)
                {
                    throw new AggregateException("TLS client and loopback server failed.", clientError, serverError);
                }
                throw;
            }
        }

        private static X509Certificate2 CreateCertificate()
        {
            var certificate = new X509Certificate2(Convert.FromBase64String(TestCertificate), "tls-test");
            Assert.True(certificate.HasPrivateKey, "The loopback certificate must contain its private key.");
            return certificate;
        }

        private static void WriteResponse(Stream stream, int status, string body)
        {
            var bytes = Encoding.UTF8.GetBytes(body);
            WriteText(stream, "HTTP/1.1 " + status + " Test\r\n" +
                "Content-Type: application/json; charset=UTF-8\r\n" +
                "Content-Length: " + bytes.Length + "\r\n" +
                "X-Test-Request-Id: test-request-id\r\nConnection: close\r\n\r\n");
            stream.Write(bytes, 0, bytes.Length);
            stream.Flush();
        }

        private static void WriteText(Stream stream, string value)
        {
            var bytes = Encoding.ASCII.GetBytes(value);
            stream.Write(bytes, 0, bytes.Length);
            stream.Flush();
        }

        private sealed class LoopbackServer : IDisposable
        {
            private readonly TcpListener listener;
            private readonly Task completion;
            private readonly X509Certificate2 certificate;
            private TcpClient connection;

            public LoopbackServer(Action<Stream> respond, SslProtocols? protocols = null)
            {
                certificate = protocols.HasValue ? CreateCertificate() : null;
                listener = new TcpListener(IPAddress.Loopback, 0);
                listener.Start();
                Url = (protocols.HasValue ? "https" : "http") + "://127.0.0.1:" +
                    ((IPEndPoint)listener.LocalEndpoint).Port + "/";
                completion = Task.Run(() =>
                {
                    using (var accepted = listener.AcceptTcpClient())
                    {
                        connection = accepted;
                        accepted.ReceiveTimeout = 5000;
                        accepted.SendTimeout = 5000;
                        using (var network = accepted.GetStream())
                        {
                            if (protocols.HasValue)
                            {
                                using (var ssl = new SslStream(network, false))
                                {
                                    ssl.AuthenticateAsServer(certificate, false, protocols.Value, false);
                                    NegotiatedProtocol = ssl.SslProtocol;
                                    ReadRequest(ssl);
                                    respond(ssl);
                                }
                            }
                            else
                            {
                                ReadRequest(network);
                                respond(network);
                            }
                        }
                    }
                });
            }

            public string Url { get; private set; }
            public string RequestLine { get; private set; }
            public Dictionary<string, string> RequestHeaders { get; private set; }
            public byte[] RequestBody { get; private set; }
            public SslProtocols NegotiatedProtocol { get; private set; }

            public void Complete()
            {
                Assert.True(completion.Wait(TimeSpan.FromSeconds(6)), "Loopback server did not finish.");
                completion.GetAwaiter().GetResult();
            }

            private void ReadRequest(Stream stream)
            {
                var header = new StringBuilder();
                while (!header.ToString().EndsWith("\r\n\r\n", StringComparison.Ordinal))
                {
                    var value = stream.ReadByte();
                    if (value < 0 || header.Length > 65536)
                    {
                        throw new IOException("Incomplete loopback HTTP request.");
                    }
                    header.Append((char)value);
                }

                var lines = header.ToString().Split(new[] { "\r\n" }, StringSplitOptions.None);
                RequestLine = lines[0];
                RequestHeaders = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                for (var index = 1; index < lines.Length && lines[index].Length != 0; index++)
                {
                    var separator = lines[index].IndexOf(':');
                    RequestHeaders.Add(lines[index].Substring(0, separator), lines[index].Substring(separator + 1).Trim());
                }

                string contentLength;
                var length = RequestHeaders.TryGetValue("Content-Length", out contentLength) ? int.Parse(contentLength) : 0;
                RequestBody = new byte[length];
                for (var offset = 0; offset < length;)
                {
                    var read = stream.Read(RequestBody, offset, length - offset);
                    if (read == 0)
                    {
                        throw new IOException("Incomplete loopback HTTP body.");
                    }
                    offset += read;
                }
            }

            public void Dispose()
            {
                listener.Stop();
                if (connection != null)
                {
                    connection.Dispose();
                }
                try
                {
                    completion.Wait(TimeSpan.FromSeconds(6));
                }
                catch (AggregateException)
                {
                    // Failed-handshake tests intentionally close the connection before HTTP.
                }
                if (certificate != null)
                {
                    certificate.Dispose();
                }
            }
        }

        private sealed class KeepAliveTlsServer : IDisposable
        {
            private readonly X509Certificate2 certificate = CreateCertificate();
            private readonly TcpListener listener = new TcpListener(IPAddress.Loopback, 0);
            private readonly List<TcpClient> connections = new List<TcpClient>();
            private readonly List<Task> workers = new List<Task>();
            private readonly Task acceptLoop;
            private volatile bool stopped;
            private volatile Exception serverError;

            public KeepAliveTlsServer()
            {
                listener.Start();
                Url = "https://127.0.0.1:" + ((IPEndPoint)listener.LocalEndpoint).Port + "/";
                acceptLoop = Task.Run(() =>
                {
                    try
                    {
                        while (!stopped)
                        {
                            var connection = listener.AcceptTcpClient();
                            connections.Add(connection);
                            workers.Add(Task.Run(() => Respond(connection)));
                        }
                    }
                    catch (SocketException) { if (!stopped) throw; }
                    catch (ObjectDisposedException) { if (!stopped) throw; }
                });
            }

            public string Url { get; private set; }

            private void Respond(TcpClient connection)
            {
                using (connection)
                using (var ssl = new SslStream(connection.GetStream(), false))
                {
                    try
                    {
                        ssl.AuthenticateAsServer(certificate, false, SslProtocols.Tls12, false);
                        while (!stopped)
                        {
                            var header = new StringBuilder();
                            while (!header.ToString().EndsWith("\r\n\r\n", StringComparison.Ordinal))
                            {
                                var value = ssl.ReadByte();
                                if (value < 0) return;
                                header.Append((char)value);
                            }
                            WriteText(ssl, "HTTP/1.1 200 OK\r\nContent-Length: 2\r\nConnection: keep-alive\r\n\r\nok");
                        }
                    }
                    catch (AuthenticationException error) { serverError = error; }
                    catch (IOException error) { serverError = error; }
                    catch (ObjectDisposedException) { if (!stopped) throw; }
                }
            }

            public HttpResponse GetSuccessfulResponse(DefaultAcsClient client, HttpRequest request)
            {
                try { return client.GetResponse(request); }
                catch (Exception error)
                {
                    throw new AggregateException("TLS client or keep-alive server failed.", error,
                        serverError ?? new InvalidOperationException("The server has not reported a failure."));
                }
            }

            public void Dispose()
            {
                stopped = true;
                listener.Stop();
                acceptLoop.GetAwaiter().GetResult();
                foreach (var connection in connections) connection.Dispose();
                Task.WhenAll(workers).GetAwaiter().GetResult();
                certificate.Dispose();
            }
        }

        // Public, self-signed loopback fixture. It grants no access to any service.
        private const string TestCertificate =
            "MIIJaQIBAzCCCS8GCSqGSIb3DQEHAaCCCSAEggkcMIIJGDCCA88GCSqGSIb3DQEHBqCCA8AwggO8AgEAMIIDtQYJKoZIhvcNAQcB" +
            "MBwGCiqGSIb3DQEMAQMwDgQImXIrSOHr3sECAggAgIIDiMmVz3yDB1EHg4R9GpSQuUBExGq0UnAHwl8U+IGGjltEpzym/Ly+jAqN" +
            "wb8a1UW2lqng51l/ailnfhI2HDwa1EpgjGx669b3yuF+jsLousaA64KzZlK4N0ra0LvmAJ1oSX8VrvnltWI03Ld3jRGd8AdUM2T6" +
            "hElzOPBJDTjrJoI2aBAXCf5p6eUfGUx8bs57g4ydzCbmxvjE1veUCLKFTlwlwtxud6Iz9KVoWlotSBPAvtUfSZBg838FdtAcCA8t" +
            "vQdk7UoZudHP/ZpIs9ZBJwLo8Xhmmx/3mBmntr9A3yfd7ZRksf2/zkW5wtFXAiuouOFFq61qW2/VUI9v5V5tf1Wuo+KJlOdThoJ7" +
            "nqzQP0kRBeRsaSAblo7YYLEJwGg+qOJ2CMNovkkU072AY+xUW2vtcYur2ASmHl5RxNSSojeMvGDzDUucfK52LtpesrpFvc3gxd/5" +
            "uR51ZhZWibLLZ2JFWiJMlZvcTUwsIT73l1LBpta0LNAOQy9cRHrLP6Bs6ohRC49iSTgQVDgJIOPHppKpk2SCgVJiwB6cs9EVRmLh" +
            "uTFOmRKDeEpt7zMS6cTlMSn8ahVQUAxrA3Gi1dRqkplcvic/kYTKrttaPbsAPUxA8MhS1+lzVSSXyznkGwYRrqzXpbXiJjqRuRhS" +
            "TfP656BDvrEmNOuiw5fTAVyHTWAQiLjlsiJ7tweGVhJFH9WybCyl309ilmA1K6vISAgS40mTpNxQ3pTJLOcfEBZenVYsmfhi4DnH" +
            "nonpMw4uyRJsyxFWu4mcKppDc81k+BTJyZORj9YvzzFQdmUON4gqWBVYiq6U+1rbJrx06Y4/x6TOKjicirzCbkG3cMH6p45azjqY" +
            "6UnmUScBzBge+SC8X8OQZ7jeuIU1PMSTQkVbhpYn2axHTm/IYpggliUmmZsYNi1T2Zm0xutZLuX0ivQ6AZMHAMk26yKd6G5aiZOI" +
            "NW9NkumhD0rIGYWk5LwowpvraMiQ1GF8txlZ1y44kAAq+ajlwRN172fw7FBPFbBS5S/xYx3KWQX9crggEZu/eOC7fnYkhPNhl2Eq" +
            "PsR+zKVjp9nnt0pA3r2soYBUgA6ILuGbs2CW2lLfEieEdhh8gRKuU191Aqza+RQuBANMDsaJvq7onbIPoo1f6OcWQM19v4YmUzs7" +
            "JKpBcZIUT/UOfYcdJ6UL86o65vHYw0ZRlWJe8TIcbzjgSq4TodgwggVBBgkqhkiG9w0BBwGgggUyBIIFLjCCBSowggUmBgsqhkiG" +
            "9w0BDAoBAqCCBO4wggTqMBwGCiqGSIb3DQEMAQMwDgQI1xmESZ7I+xwCAggABIIEyAxdx0lgW/sAXOX1UHGbt6/dTZk38so4DFEz" +
            "4Fkbh27Tjew8NfPC7ESouzFyf7g0fWFZA3nJedRpCXcy6YsyD3YNudhych3MtfZ2m+4Am4xiKEzRzM+5Og6u3BjQKwdxEmd0CWic" +
            "i3xXm5PNAWCzOHDzgH41tb4YLuki/XTcIa5x3vOLRXYUiRWBvGxMXsEX8OJiS6yZ5IKoK2fN9fWXaIuTJcokvU9VOr9EdVCajhqc" +
            "DUn/Hk4jX+PWQEH8a1kWCb8j4jPd+w+8NRIulO6+zDpR0Kwf+OwHuNIEVUkbKkG4JAHUh81JGjoIWwfzTnRLUmdaEeq1PL5dKyjw" +
            "6yK7VzyiRP8zhdDmEbdfYcbrKieQndX6pzi8FvRaawlCYCPOAsfdnCXvOCSAn2yusd0Q/x9k9hPDinbJA9KdmQe5Y5Bp/1sq0IHP" +
            "3gqQaO5iygw/My0eBppP45nYVp3i991OcU1RNxI5JTIXq625YUjraz52v/cKTcYnlujI1tgSAHeCfCuAav9D/Vxs3rrHG6CppDDn" +
            "V+pjfi9Pnf7m5sUWjfnNlP9AEaR+HzZ4L+/3EbZ3MC93yOW4gs2tSruRCiqRXZN/bHiXJC4hufAt3gkTVXAe768T0xp7hrp5swHa" +
            "9cUyP/pn/OOlMDvZtL3tmMpUWtkRoabfrNkOFZq0BwkJDg11Uzt6UDxUb1QLxqMPG3Z57+b8OzaAh+xCGPAz+gLqdTqmOIz02uKk" +
            "3stcfpjyq57GcKoNKfHEeNrocQtyOESanM7oxqs/i/D+SRiEVIz0llHsnx5W1za696EGZnk0lLP09rylyM4kY2PZHeuSDjoMEwKD" +
            "W72EfvxeeGI3hMPD3KGyqT3BC+zDnrK+2Poimd6Gr/vNHV3R6sfFvidfR2HEF48hrOqjdOWEmW3Pg/C7qBQphb1pyJ++/aYRtQ/Z" +
            "H6o8eUPQDDawaCtBm32KuW/yZOpOupWm/MFokhl3oq6+6dJAOJCNKISHygCCYSwDU7Cc7rYsUo7RD5kwYZaFU37USTu9Lh7AEXmC" +
            "G3SptJgWnAWSYsnx2iwea9gtBX+batZk9ZvXYNRSX13vVDSRDqY1OltXaXddJt70v0FuvIVarvpzD+HR10KHjHJWYwnHRVJnUDfU" +
            "9JTDtdX8Rx1icIDGSrenmZOD2tGC84/bRqzCKGoKgxNZ3GrByNs+ys7NauT9eEsvRkUqvVEEoDJCMqFw8yzPvof9GQmAzkLAPajK" +
            "rjLLziedyfI1CaR7C9ngnUxhc5XfVMaV+yWQHcpjEnpOh0ATAMuBezqVMdcBUmPXlTlix0izGeQJUHqj/O0TH5Lqp+bO6dlUy3Fb" +
            "apIH9x9WdL0x9FAhrRJ2vp3Vaz1JeRI/z9f4ipZ4qXEPJsS4uZqCWT1vyZ7QkeH577srOitMa56Hcw/pfZC23OLbkV56/1YUE3Mj" +
            "Jh+y57swP8XBHMFgFQyckBRDaJ1MZQK/u0NFfUKT83nkuz3JQHxHuJfUhUQR98N/4tDHJZ1qwZrghkK8ETztx4tw3miCk/vykPVP" +
            "Cg3Bs6MVTDayc6pU8e/FJRxqa0ucSBYVfG0KMo0xkr2mL5k3nV1YLDc92EFG9ZDF+47KwWKm/brtQhV1F1b3uMKDOpzEke0pUTEl" +
            "MCMGCSqGSIb3DQEJFTEWBBQChfNcvDaqR3duwU86xy4JF/SXsTAxMCEwCQYFKw4DAhoFAAQUqO22ETGP7Li0YTZkMU/0eJN7rSIE" +
            "CIDHrdAkiOKBAgIIAA==";
    }

    public sealed class Tls13FactAttribute : FactAttribute
    {
        public Tls13FactAttribute()
        {
#if NET8_0
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Skip = "TLS 1.3 negotiation is covered by Linux .NET 8 CI; macOS does not support it here.";
            }
#else
            Skip = "TLS 1.3 negotiation is covered by Linux .NET 8 CI; this target uses older TLS APIs.";
#endif
        }
    }

    public sealed class LegacyTlsFactAttribute : FactAttribute
    {
        public LegacyTlsFactAttribute()
        {
#if NET8_0
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ||
                Environment.GetEnvironmentVariable("RUN_LEGACY_TLS_TESTS") != "1")
            {
                Skip = "TLS 1.1 rejection requires Linux CI's isolated OpenSSL configuration and RUN_LEGACY_TLS_TESTS=1.";
            }
#else
            Skip = "TLS 1.1 rejection is exercised in Linux .NET 8 CI with an isolated OpenSSL configuration.";
#endif
        }
    }
}
