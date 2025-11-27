using System;
using System.Globalization;
using System.Text;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;
using Aliyun.Acs.Dybaseapi.MNS.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.HttpHandler
{
    /// <summary>
    /// The HTTP handler contains common logic for issuing an HTTP request that is 
    /// independent of the underlying HTTP infrastructure.
    /// </summary>
    /// <typeparam name="TRequestContent"></typeparam>
    public class HttpHandler<TRequestContent> : PipelineHandler, IDisposable
    {
        private bool _disposed;
        private IHttpRequestFactory<TRequestContent> _requestFactory;

        /// <summary>
        /// The sender parameter used in any events raised by this handler.
        /// </summary>
        public object CallbackSender { get; private set; }

        /// <summary>
        /// The constructor for HttpHandler.
        /// </summary>
        /// <param name="requestFactory">The request factory used to create HTTP Requests.</param>
        /// <param name="callbackSender">The sender parameter used in any events raised by this handler.</param>
        public HttpHandler(IHttpRequestFactory<TRequestContent> requestFactory, object callbackSender)
        {
            _requestFactory = requestFactory;
            this.CallbackSender = callbackSender;
        }

        /// <summary>
        /// Issues an HTTP request for the current request context.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            IHttpRequest<TRequestContent> httpRequest = null;
            try
            {
                SetMetrics(executionContext.RequestContext);
                IRequest wrappedRequest = executionContext.RequestContext.Request;
                httpRequest = CreateWebRequest(executionContext.RequestContext);
                httpRequest.SetRequestHeaders(wrappedRequest.Headers);

                try
                {
                    executionContext.RequestContext.Metrics.StartEvent(Metric.HttpRequestTime);
                    // Send request body if present.
                    if (wrappedRequest.HasRequestBody())
                    {
                        var requestContent = httpRequest.GetRequestContent();
                        WriteContentToRequestBody(requestContent, httpRequest, executionContext.RequestContext);
                    }

                    executionContext.ResponseContext.HttpResponse = httpRequest.GetResponse();
                }
                finally
                {
                    executionContext.RequestContext.Metrics.StopEvent(Metric.HttpRequestTime);
                }
            }
            finally
            {
                if (httpRequest != null)
                    httpRequest.Dispose();
            }
        }

        /// <summary>
        /// Issues an HTTP request for the current request context.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent an async operation.</returns>
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            IHttpRequest<TRequestContent> httpRequest = null;
            try
            {
                SetMetrics(executionContext.RequestContext);
                httpRequest = CreateWebRequest(executionContext.RequestContext);
                executionContext.RuntimeState = httpRequest;

                IRequest wrappedRequest = executionContext.RequestContext.Request;
                if (executionContext.RequestContext.Retries == 0)
                {
                    // First call, initialize an async result.
                    executionContext.ResponseContext.AsyncResult =
                        new RuntimeAsyncResult(executionContext.RequestContext.Callback, 
                            executionContext.RequestContext.State);                    
                }

                // Set request headers
                httpRequest.SetRequestHeaders(executionContext.RequestContext.Request.Headers);

                executionContext.RequestContext.Metrics.StartEvent(Metric.HttpRequestTime);
                if (wrappedRequest.HasRequestBody())
                {
                    // Send request body if present.
                    httpRequest.BeginGetRequestContent(new AsyncCallback(GetRequestStreamCallback), executionContext);
                }
                else
                {
                    // Get response if there is no response body to send.
                    httpRequest.BeginGetResponse(new AsyncCallback(GetResponseCallback), executionContext);
                }
                return executionContext.ResponseContext.AsyncResult;
            }
            catch (Exception)
            {
                if (executionContext.ResponseContext.AsyncResult != null)
                {
                    // An exception will be thrown back to the calling code.
                    // Dispose AsyncResult as it will not be used further.
                    executionContext.ResponseContext.AsyncResult.Dispose();
                    executionContext.ResponseContext.AsyncResult = null;
                }

                if (httpRequest != null)
                {                    
                    httpRequest.Dispose();
                }

                throw;
            }
        }

        private void GetRequestStreamCallback(IAsyncResult result)
        {
            IAsyncExecutionContext executionContext = null;
            IHttpRequest<TRequestContent> httpRequest = null;
            try
            {
                executionContext = result.AsyncState as IAsyncExecutionContext;
                httpRequest = executionContext.RuntimeState as IHttpRequest<TRequestContent>;

                var requestContent = httpRequest.EndGetRequestContent(result);
                WriteContentToRequestBody(requestContent, httpRequest, executionContext.RequestContext);
                //var requestStream = httpRequest.EndSetRequestBody(result);                
                httpRequest.BeginGetResponse(new AsyncCallback(GetResponseCallback), executionContext);
            }
            catch(Exception exception)
            {   
                httpRequest.Dispose();

                // Capture the exception and invoke outer handlers to 
                // process the exception.
                executionContext.ResponseContext.AsyncResult.Exception = exception;
                base.InvokeAsyncCallback(executionContext);
            }
        }

        private void GetResponseCallback(IAsyncResult result)
        {
            IAsyncExecutionContext executionContext = null;
            IHttpRequest<TRequestContent> httpRequest = null;
            try
            {
                executionContext = result.AsyncState as IAsyncExecutionContext;
                httpRequest = executionContext.RuntimeState as IHttpRequest<TRequestContent>;

                var httpResponse = httpRequest.EndGetResponse(result);
                executionContext.ResponseContext.HttpResponse = httpResponse;
            }
            catch (Exception exception)
            {   
                // Capture the exception and invoke outer handlers to 
                // process the exception.
                executionContext.ResponseContext.AsyncResult.Exception = exception;
            }
            finally
            {
                executionContext.RequestContext.Metrics.StopEvent(Metric.HttpRequestTime);
                httpRequest.Dispose();
                base.InvokeAsyncCallback(executionContext);
            }
        }

        private static void SetMetrics(IRequestContext requestContext)
        {
            requestContext.Metrics.AddProperty(Metric.ServiceName, requestContext.Request.ServiceName);
            requestContext.Metrics.AddProperty(Metric.ServiceEndpoint, requestContext.Request.Endpoint);
            requestContext.Metrics.AddProperty(Metric.MethodName, requestContext.Request.RequestName);
        }

        /// <summary>
        /// Determines the content for request body and uses the HTTP request
        /// to write the content to the HTTP request body.
        /// </summary>
        /// <param name="requestContent">Content to be written.</param>
        /// <param name="httpRequest">The HTTP request.</param>
        /// <param name="requestContext">The request context.</param>
        private void WriteContentToRequestBody(TRequestContent requestContent,
            IHttpRequest<TRequestContent> httpRequest,
            IRequestContext requestContext)
        {
            IRequest wrappedRequest = requestContext.Request;

            if (wrappedRequest.ContentStream == null)
            {
                byte[] requestData = wrappedRequest.Content;
                requestContext.Metrics.AddProperty(Metric.RequestSize, requestData.Length);
                httpRequest.WriteToRequestBody(requestContent, requestData, requestContext.Request.Headers);
            }
            else
            {
                var originalStream = wrappedRequest.ContentStream;
                httpRequest.WriteToRequestBody(requestContent, originalStream, 
                    requestContext.Request.Headers, requestContext);

            }
        }

        /// <summary>
        /// Creates the HttpWebRequest and configures the end point, content, user agent and proxy settings.
        /// </summary>
        /// <param name="requestContext">The async request.</param>
        /// <returns>The web request that actually makes the call.</returns>
        protected virtual IHttpRequest<TRequestContent> CreateWebRequest(IRequestContext requestContext)
        {
            IRequest request = requestContext.Request;
            Uri url = AliyunServiceClient.ComposeUrl(request);
            var httpRequest = _requestFactory.CreateHttpRequest(url);
            httpRequest.ConfigureRequest(requestContext);
            
            httpRequest.Method = request.HttpMethod;
            if (request.MayContainRequestBody())
            {
                if (request.Content == null && (request.ContentStream == null))
                {
                    string queryString = AliyunSDKUtils.GetParametersAsString(request.Parameters);
                    request.Content = Encoding.UTF8.GetBytes(queryString);
                }
                
                if (request.Content!=null)
                {
                    request.Headers[HttpHeader.ContentLengthHeader] = 
                        request.Content.Length.ToString(CultureInfo.InvariantCulture);
                }
                else if (request.ContentStream != null && !request.Headers.ContainsKey(HttpHeader.ContentLengthHeader))
                {
                    request.Headers[HttpHeader.ContentLengthHeader] =
                        request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
                }
            }
            else if (request.UseQueryString &&
                (request.HttpMethod == "POST" ||
                 request.HttpMethod == "PUT" ||
                 request.HttpMethod == "DELETE"))
            {
                request.Content = new Byte[0];
            }
            
            return httpRequest;
        }

        /// <summary>
        /// Disposes the HTTP handler.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                if (_requestFactory != null)
                    _requestFactory.Dispose();

                _disposed = true;
            }
        }
    }
}
