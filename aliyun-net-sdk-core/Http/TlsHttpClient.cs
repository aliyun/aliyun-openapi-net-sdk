/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements. See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership. The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

#if NET472 || NETSTANDARD2_0
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Http
{
    internal sealed class TlsHttpClient : IDisposable
    {
        // Older reference assemblies do not name TLS 1.3, even when the runtime supports it.
        private const SslProtocols Tls13 = (SslProtocols)12288;
        private const int DefaultConnectTimeout = 5000;
        private const int DefaultReadTimeout = 10000;
        private readonly object clientLock = new object();
        private readonly List<ClientEntry> clients = new List<ClientEntry>();
        private bool disposed;

        internal static SslProtocols GetProtocols(string tlsMinVersion)
        {
            switch (tlsMinVersion)
            {
                case "TLSv1":
                    return SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12 | Tls13;
                case "TLSv1.1":
                    return SslProtocols.Tls11 | SslProtocols.Tls12 | Tls13;
                case "TLSv1.2":
                    return SslProtocols.Tls12 | Tls13;
                case "TLSv1.3":
                    return Tls13;
                default:
                    throw new ArgumentException("TlsMinVersion must be TLSv1, TLSv1.1, TLSv1.2 or TLSv1.3.",
                        "tlsMinVersion");
            }
        }

        internal HttpResponse GetResponse(HttpRequest request, string tlsMinVersion, bool ignoreCertificate)
        {
            var protocols = GetProtocols(tlsMinVersion);
            var uri = new Uri(request.Url);
            var client = GetClient(protocols, ignoreCertificate || request.IgnoreCertificate, request.WebProxy);
            var connectTimeout = request.ConnectTimeout > 0 ? request.ConnectTimeout : DefaultConnectTimeout;
            var readTimeout = request.ReadTimeout > 0 ? request.ReadTimeout : DefaultReadTimeout;

            using (var message = CreateRequest(request, uri))
            using (var cancellation = new CancellationTokenSource())
            {
                try
                {
                    cancellation.CancelAfter(connectTimeout);
                    using (var response = client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead,
                        cancellation.Token).ConfigureAwait(false).GetAwaiter().GetResult())
                    {
                        cancellation.CancelAfter(System.Threading.Timeout.Infinite);
                        return ReadResponse(response, uri, readTimeout);
                    }
                }
                catch (HttpRequestException ex)
                {
                    var unsupported = ex.GetBaseException() as PlatformNotSupportedException;
                    if (unsupported != null)
                    {
                        throw unsupported;
                    }

                    throw NetworkException(uri, ex);
                }
                catch (OperationCanceledException ex)
                {
                    throw NetworkException(uri, ex);
                }
                catch (TimeoutException ex)
                {
                    throw NetworkException(uri, ex);
                }
                catch (IOException ex)
                {
                    throw new ClientException("SDK.ServerUnreachable:",
                        string.Format("Server unreachable: connection to url: {0} failed. {1}", uri.Host, ex));
                }
                catch (NotSupportedException)
                {
                    throw;
                }
                catch (ArgumentException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw new ClientException("SDK.Exception",
                        string.Format("The request url is {0} {1}", uri.Host, ex));
                }
            }
        }

        private static ClientException NetworkException(Uri uri, Exception exception)
        {
            return new ClientException("SDK.WebException",
                string.Format("HttpClient request failed, the request url is {0} {1}", uri.Host, exception));
        }

        private HttpClient GetClient(SslProtocols protocols, bool ignoreCertificate, IWebProxy proxy)
        {
            lock (clientLock)
            {
                if (disposed)
                {
                    throw new ObjectDisposedException("TlsHttpClient");
                }

                foreach (var entry in clients)
                {
                    if (entry.Protocols == protocols && entry.IgnoreCertificate == ignoreCertificate &&
                        SameProxy(entry.Proxy, proxy))
                    {
                        return entry.Client;
                    }
                }

                var proxySnapshot = CopyProxy(proxy);
                var handler = new HttpClientHandler();
                try
                {
                    try
                    {
                        handler.SslProtocols = protocols;
                    }
                    catch (NotSupportedException)
                    {
                        var withoutTls13 = protocols & ~Tls13;
                        if (withoutTls13 == SslProtocols.None)
                        {
                            throw;
                        }

                        // Only remove an unsupported higher version; never lower the requested minimum.
                        handler.SslProtocols = withoutTls13;
                    }

                    handler.UseCookies = false;
                    handler.UseProxy = proxySnapshot != null;
                    handler.Proxy = proxySnapshot;
                    if (ignoreCertificate)
                    {
                        handler.ServerCertificateCustomValidationCallback = (message, certificate, chain, errors) => true;
                    }

                    var client = new HttpClient(handler);
                    client.Timeout = System.Threading.Timeout.InfiniteTimeSpan;
                    clients.Add(new ClientEntry(protocols, ignoreCertificate, proxySnapshot, client));
                    return client;
                }
                catch
                {
                    handler.Dispose();
                    throw;
                }
            }
        }

        private static HttpRequestMessage CreateRequest(HttpRequest request, Uri uri)
        {
            var message = new HttpRequestMessage(new HttpMethod(request.Method.ToString()), uri);
            try
            {
                if ((request.Method == MethodType.POST || request.Method == MethodType.PUT) && request.Content != null)
                {
                    message.Content = new ByteArrayContent(request.Content);
                }

                foreach (var header in request.Headers)
                {
                    if (!message.Headers.TryAddWithoutValidation(header.Key, header.Value))
                    {
                        if (message.Content == null)
                        {
                            message.Content = new ByteArrayContent(new byte[0]);
                        }

                        if (!message.Content.Headers.TryAddWithoutValidation(header.Key, header.Value))
                        {
                            throw new ArgumentException("Unsupported HTTP header: " + header.Key, "request");
                        }
                    }
                }

                return message;
            }
            catch
            {
                message.Dispose();
                throw;
            }
        }

        private static HttpResponse ReadResponse(HttpResponseMessage response, Uri requestUri, int readTimeout)
        {
            var result = new HttpResponse(requestUri.AbsoluteUri);
            result.Status = (int)response.StatusCode;
            result.Method = ParameterHelper.StringToMethodType(response.RequestMessage.Method.Method);
            result.HttpVersion = response.Version.ToString();
            result.Headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var header in response.Headers)
            {
                result.Headers[header.Key] = string.Join(",", header.Value);
            }

            if (response.Content != null)
            {
                foreach (var header in response.Content.Headers)
                {
                    result.Headers[header.Key] = string.Join(",", header.Value);
                }

                var contentType = response.Content.Headers.ContentType;
                if (contentType != null)
                {
                    result.ContentType = ParameterHelper.StingToFormatType(contentType.MediaType);
                    result.Encoding = string.IsNullOrWhiteSpace(contentType.CharSet)
                        ? "UTF-8"
                        : contentType.CharSet.Trim('"').ToUpperInvariant();
                }

                using (var stream = response.Content.ReadAsStreamAsync().ConfigureAwait(false).GetAwaiter().GetResult())
                using (var content = new MemoryStream())
                {
                    var buffer = new byte[8192];
                    while (true)
                    {
                        int length;
                        using (var cancellation = new CancellationTokenSource())
                        {
                            var read = stream.ReadAsync(buffer, 0, buffer.Length, cancellation.Token);
                            var delay = Task.Delay(readTimeout, cancellation.Token);
                            var completed = Task.WhenAny(read, delay).ConfigureAwait(false).GetAwaiter().GetResult();
                            cancellation.Cancel();
                            if (completed != read)
                            {
                                read.ContinueWith(task => task.Exception.Handle(exception => true),
                                    TaskContinuationOptions.OnlyOnFaulted | TaskContinuationOptions.ExecuteSynchronously);
                                throw new TimeoutException("The response read timed out.");
                            }

                            length = read.ConfigureAwait(false).GetAwaiter().GetResult();
                        }

                        if (length == 0)
                        {
                            break;
                        }

                        content.Write(buffer, 0, length);
                    }

                    result.Content = content.ToArray();
                }
            }

            return result;
        }

        private static IWebProxy CopyProxy(IWebProxy proxy)
        {
            if (proxy == null || proxy.GetType() != typeof(WebProxy))
            {
                return proxy;
            }

            var source = (WebProxy)proxy;
            var copy = new WebProxy();
            copy.Address = source.Address;
            copy.BypassProxyOnLocal = source.BypassProxyOnLocal;
            copy.BypassList = source.BypassList;
            var credentials = source.Credentials as NetworkCredential;
            copy.Credentials = credentials != null && !ReferenceEquals(credentials, CredentialCache.DefaultNetworkCredentials)
                ? new NetworkCredential(credentials.UserName, credentials.Password, credentials.Domain)
                : source.Credentials;
            return copy;
        }

        private static bool SameProxy(IWebProxy first, IWebProxy second)
        {
            if (ReferenceEquals(first, second))
            {
                return true;
            }

            if (first == null || second == null || first.GetType() != typeof(WebProxy) || second.GetType() != typeof(WebProxy))
            {
                return false;
            }

            var left = (WebProxy)first;
            var right = (WebProxy)second;
            if (!Equals(left.Address, right.Address) || left.BypassProxyOnLocal != right.BypassProxyOnLocal ||
                !SameCredentials(left.Credentials, right.Credentials))
            {
                return false;
            }

            var leftBypass = left.BypassList;
            var rightBypass = right.BypassList;
            if (leftBypass.Length != rightBypass.Length)
            {
                return false;
            }

            for (var index = 0; index < leftBypass.Length; index++)
            {
                if (leftBypass[index] != rightBypass[index])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool SameCredentials(ICredentials first, ICredentials second)
        {
            if (ReferenceEquals(first, second))
            {
                return true;
            }

            var left = first as NetworkCredential;
            var right = second as NetworkCredential;
            return left != null && right != null &&
                !ReferenceEquals(first, CredentialCache.DefaultNetworkCredentials) &&
                !ReferenceEquals(second, CredentialCache.DefaultNetworkCredentials) &&
                left.UserName == right.UserName && left.Password == right.Password && left.Domain == right.Domain;
        }

        public void Dispose()
        {
            lock (clientLock)
            {
                if (disposed)
                {
                    return;
                }

                disposed = true;
                foreach (var entry in clients)
                {
                    entry.Client.Dispose();
                }

                clients.Clear();
            }
        }

        private sealed class ClientEntry
        {
            internal readonly SslProtocols Protocols;
            internal readonly bool IgnoreCertificate;
            internal readonly IWebProxy Proxy;
            internal readonly HttpClient Client;

            internal ClientEntry(SslProtocols protocols, bool ignoreCertificate, IWebProxy proxy, HttpClient client)
            {
                Protocols = protocols;
                IgnoreCertificate = ignoreCertificate;
                Proxy = proxy;
                Client = client;
            }
        }
    }
}
#endif
