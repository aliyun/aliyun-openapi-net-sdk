using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;
using Aliyun.Acs.Dybaseapi.MNS.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.HttpHandler
{
    /// <summary>
    /// The request factory for System.Net.HttpWebRequest.
    /// </summary>    
    public class HttpWebRequestFactory : IHttpRequestFactory<Stream>
    {
        /// <summary>
        /// Creates an HTTP request for the given URI.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>An HTTP request.</returns>
        public IHttpRequest<Stream> CreateHttpRequest(Uri requestUri)
        {
            return new HttpRequest(requestUri);
        }

        /// <summary>
        /// Disposes the HttpWebRequestFactory.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
        }
    }

    /// <summary>
    /// HTTP request wrapper for System.Net.HttpWebRequest.
    /// </summary>    
    public class HttpRequest : IHttpRequest<Stream>
    {
        private bool _isAborted = false;
        private HttpWebRequest _request;

        /// <summary>
        /// Constructor for HttpRequest.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        public HttpRequest(Uri requestUri)
        {
            _request = WebRequest.Create(requestUri) as HttpWebRequest;
        }

        /// <summary>
        /// The underlying HTTP web request.
        /// </summary>
        public HttpWebRequest Request
        {
            get { return _request; }
        }

        /// <summary>
        /// The HTTP method or verb.
        /// </summary>
        public string Method
        {
            get { return _request.Method; }
            set { _request.Method = value; }
        }

        /// <summary>
        /// The request URI.
        /// </summary>
        public Uri RequestUri
        {
            get { return _request.RequestUri; }
        }

        /// <summary>
        /// Returns the HTTP response.
        /// </summary>
        /// <returns>The HTTP response.</returns>
        public virtual IWebResponseData GetResponse()
        {
            try
            {
                var response = _request.GetResponse() as HttpWebResponse;
                return new HttpWebRequestResponseData(response);
            }
            catch(WebException webException)
            {
                var errorResponse = webException.Response as HttpWebResponse;
                if (errorResponse != null)
                {
                    throw new HttpErrorResponseException(webException.Message,
                        webException,
                        new HttpWebRequestResponseData(errorResponse));                    
                }
                throw;
            }
        }

        /// <summary>
        /// Gets a handle to the request content.
        /// </summary>
        /// <returns>The request content.</returns>
        public Stream GetRequestContent()
        {
            return _request.GetRequestStream();
        }

        /// <summary>
        /// Writes a stream to the request body.
        /// </summary>
        /// <param name="requestContent">The destination where the content stream is written.</param>
        /// <param name="contentStream">The content stream to be written.</param>
        /// <param name="contentHeaders">HTTP content headers.</param>
        /// <param name="requestContext">The request context.</param>
        public void WriteToRequestBody(Stream requestContent, Stream contentStream,
            IDictionary<string, string> contentHeaders, IRequestContext requestContext)
        {
            bool gotException = false;
            try            
            {
                var buffer = new byte[requestContext.ClientConfig.BufferSize];
                int bytesRead = 0;
                int bytesToRead = buffer.Length;

                while ((bytesRead = contentStream.Read(buffer, 0, bytesToRead)) > 0)
                {
                    requestContent.Write(buffer, 0, bytesRead);
                }
            }
            catch(Exception)
            {
                gotException = true;

                // If an exception occured while reading the input stream,
                // Abort the request to signal failure to the server and prevent
                // potentially writing an incomplete stream to the server.
                this.Abort();
                throw;
            }
            finally
            {
                // Only bubble up exception from the close method if we haven't already got an exception
                // reading and writing from the streams.
                try
                {
                    requestContent.Close();
                }
                catch(Exception)
                {
                    if (!gotException)
                        throw;
                }
            }
        }

        /// <summary>
        /// Writes a byte array to the request body.
        /// </summary>
        /// <param name="requestContent">The destination where the content stream is written.</param>
        /// <param name="content">The content stream to be written.</param>
        /// <param name="contentHeaders">HTTP content headers.</param>
        public void WriteToRequestBody(Stream requestContent, byte[] content, IDictionary<string, string> contentHeaders)
        {
            using (requestContent)
            {
                requestContent.Write(content, 0, content.Length);
            }
        }

        /// <summary>
        /// Aborts the HTTP request.
        /// </summary>
        public void Abort()
        {
            if (!_isAborted)
            {
                _request.Abort();
                _isAborted = true;
            }
        }

        /// <summary>
        /// Initiates the operation to gets a handle to the request content.
        /// </summary>
        /// <param name="callback">The async callback invoked when the operation completes.</param>
        /// <param name="state">The state object to be passed to the async callback.</param>
        /// <returns>IAsyncResult that represents an async operation.</returns>
        public IAsyncResult BeginGetRequestContent(AsyncCallback callback, object state)
        {
            return _request.BeginGetRequestStream(callback, state);
        }

        /// <summary>
        /// Ends the operation to gets a handle to the request content.
        /// </summary>
        /// <param name="asyncResult">IAsyncResult that represents an async operation.</param>
        /// <returns>The request content.</returns>
        public Stream EndGetRequestContent(IAsyncResult asyncResult)
        {
            return _request.EndGetRequestStream(asyncResult);
        }

        /// <summary>
        /// Initiates the operation to Returns the HTTP response.
        /// </summary>
        /// <param name="callback">The async callback invoked when the operation completes.</param>
        /// <param name="state">The state object to be passed to the async callback.</param>
        /// <returns>IAsyncResult that represents an async operation.</returns>
        public IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
        {
            return _request.BeginGetResponse(callback, state);
        }

        /// <summary>
        /// Ends the operation to Returns the HTTP response.
        /// </summary>
        /// <param name="asyncResult">IAsyncResult that represents an async operation.</param>
        /// <returns>The HTTP response.</returns>
        public virtual IWebResponseData EndGetResponse(IAsyncResult asyncResult)
        {
            try
            {
                var response = _request.EndGetResponse(asyncResult) as HttpWebResponse;
                return new HttpWebRequestResponseData(response);
            }
            catch (WebException webException)
            {
                var errorResponse = webException.Response as HttpWebResponse;
                if (errorResponse != null)
                {
                    throw new HttpErrorResponseException(webException.Message,
                        webException,
                        new HttpWebRequestResponseData(errorResponse));
                }
                throw;
            }
        }

        /// <summary>
        /// Configures a request as per the request context.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        public virtual void ConfigureRequest(IRequestContext requestContext)
        {
            var clientConfig = requestContext.ClientConfig;
            var originalRequest = requestContext.OriginalRequest;

            // If System.Net.WebRequest.AllowAutoRedirect is set to true (default value),
            // redirects for GET requests are automatically followed and redirects for POST
            // requests are thrown back as exceptions.

            // If System.Net.WebRequest.AllowAutoRedirect is set to false,
            // redirects are returned as responses.
            _request.AllowAutoRedirect = clientConfig.AllowAutoRedirect;

            // Configure timeouts.
            if (requestContext.Request.ContentStream != null)
            {
                _request.Timeout = int.MaxValue;
                _request.ReadWriteTimeout = int.MaxValue;
                _request.AllowWriteStreamBuffering = false;
            }

            // Override the Timeout and ReadWriteTimeout values if set at the request or config level.
            // Public Timeout and ReadWriteTimeout properties are present on client config objects.
            var timeout = ClientConfig.GetTimeoutValue(clientConfig.Timeout,
                originalRequest.TimeoutInternal);
            var readWriteTimeout = ClientConfig.GetTimeoutValue(clientConfig.ReadWriteTimeout,
                originalRequest.ReadWriteTimeoutInternal);
            if (timeout != null)
            {
                _request.Timeout = (int)timeout.Value.TotalMilliseconds;
            }
            if (readWriteTimeout != null)
            {
                _request.ReadWriteTimeout = (int)readWriteTimeout.Value.TotalMilliseconds;
            }
            _request.KeepAlive = originalRequest.KeepAlive;

            // Set proxy related properties
            if (!string.IsNullOrEmpty(requestContext.ClientConfig.ProxyHost) && requestContext.ClientConfig.ProxyPort > 0)
            {
                WebProxy proxy = new WebProxy(requestContext.ClientConfig.ProxyHost, requestContext.ClientConfig.ProxyPort);
                requestContext.Metrics.AddProperty(Metric.ProxyHost, requestContext.ClientConfig.ProxyHost);
                requestContext.Metrics.AddProperty(Metric.ProxyHost, requestContext.ClientConfig.ProxyPort);
                _request.Proxy = proxy;

                if (requestContext.ClientConfig.ProxyCredentials != null)
                {
                    _request.Proxy.Credentials = requestContext.ClientConfig.ProxyCredentials;
                }
            }
            else
            {
                _request.Proxy = null;
            }

            // Set service point properties.
            //_request.ServicePoint.Expect100Continue = originalRequest.Expect100Continue;
        }

        /// <summary>
        /// Sets the headers on the request.
        /// </summary>
        /// <param name="headers">A dictionary of header names and values.</param>
        public void SetRequestHeaders(IDictionary<string, string> headers)
        {
            AddHeaders(_request, headers);
        }

        private static System.Reflection.MethodInfo _addWithoutValidateHeadersMethod =
            typeof(WebHeaderCollection).GetMethod("AddWithoutValidate", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

        internal static void AddHeaders(HttpWebRequest request, IDictionary<string, string> headersToAdd)
        {
            var headers = request.Headers;
            foreach (var kvp in headersToAdd)
            {
                if (WebHeaderCollection.IsRestricted(kvp.Key))
                {
                    if (string.Equals(kvp.Key, HttpHeader.AcceptHeader, StringComparison.OrdinalIgnoreCase))
                        request.Accept = kvp.Value;
                    else if (string.Equals(kvp.Key, HttpHeader.ContentTypeHeader, StringComparison.OrdinalIgnoreCase))
                        request.ContentType = kvp.Value;
                    else if (string.Equals(kvp.Key, HttpHeader.ContentLengthHeader, StringComparison.OrdinalIgnoreCase))
                        request.ContentLength = long.Parse(kvp.Value, CultureInfo.InvariantCulture);
                    else if (string.Equals(kvp.Key, HttpHeader.UserAgentHeader, StringComparison.OrdinalIgnoreCase))
                        request.UserAgent = kvp.Value;
                    else if (string.Equals(kvp.Key, HttpHeader.DateHeader, StringComparison.OrdinalIgnoreCase))
                        _addWithoutValidateHeadersMethod.Invoke(request.Headers, new[] { HttpHeader.DateHeader, kvp.Value });
                    else if (string.Equals(kvp.Key, HttpHeader.HostHeader, StringComparison.OrdinalIgnoreCase))
                        _addWithoutValidateHeadersMethod.Invoke(request.Headers, new[] { HttpHeader.HostHeader, kvp.Value });
                    else
                        throw new NotSupportedException("Header with name " + kvp.Key + " is not suppored");
                }
                else
                {
                    headers[kvp.Key] = kvp.Value;
                }
            }
        }

        /// <summary>
        /// Disposes the HttpRequest.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
        }
    }
}
