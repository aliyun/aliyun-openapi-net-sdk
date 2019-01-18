using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Auth;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.ErrorHandler;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.Handlers;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.HttpHandler;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.RetryHandler;
using Aliyun.Acs.Dybaseapi.MNS.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime
{
    public abstract class AliyunServiceClient : IDisposable
    {
        private bool _disposed;

        protected RuntimePipeline RuntimePipeline { get; set; }
        protected ServiceCredentials Credentials { get; private set; }
        internal ClientConfig Config { get; private set; }

        #region Constructors

        internal AliyunServiceClient(ServiceCredentials credentials, ClientConfig config)
        {
            RequestMetrics.IsEnabled = config.LogMetrics;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.DefaultConnectionLimit = config.ConnectionLimit;
            ServicePointManager.MaxServicePointIdleTime = config.MaxIdleTime;

            this.Config = config;
            this.Credentials = credentials;
            Signer = CreateSigner();

            Initialize();

            BuildRuntimePipeline();
        }

        protected IServiceSigner Signer
        {
            get;
            private set;
        }

        internal AliyunServiceClient(string accessKeyId, string secretAccessKey, ClientConfig config, string stsToken)
			: this(new BasicServiceCredentials(accessKeyId, secretAccessKey, stsToken), config)
        {
        }

        protected virtual void Initialize()
        {
        }

        #endregion

        #region Invoke methods

        internal TResponse Invoke<TRequest, TResponse>(TRequest request,
            IMarshaller<IRequest, WebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller)            
            where TRequest: WebServiceRequest
            where TResponse : WebServiceResponse
        {
            ThrowIfDisposed();

            var executionContext = new ExecutionContext(
                new RequestContext()
                {
                    ClientConfig = this.Config,
                    Marshaller = marshaller,
                    OriginalRequest = request,
                    Signer = Signer,
                    Unmarshaller = unmarshaller,
                    IsAsync = false
                },
                new ResponseContext()
            );

            var response = (TResponse)this.RuntimePipeline.InvokeSync(executionContext).Response;
            return response;
        }

        internal IAsyncResult BeginInvoke<TRequest>(TRequest request,
            IMarshaller<IRequest, WebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller,
            AsyncCallback callback, object state)
            where TRequest : WebServiceRequest            
        {
            ThrowIfDisposed();

            var executionContext = new AsyncExecutionContext(
                new AsyncRequestContext()
                {
                    ClientConfig = this.Config,
                    Marshaller = marshaller,
                    OriginalRequest = request,
                    Signer = Signer,
                    Unmarshaller = unmarshaller,
                    Callback = callback,
                    State = state,
                    IsAsync = true
                },
                new AsyncResponseContext()
            );

            var asyncResult = this.RuntimePipeline.InvokeAsync(executionContext);
            return asyncResult;
        }

        internal static TResponse EndInvoke<TResponse>(IAsyncResult result)
            where TResponse : WebServiceResponse
        {
            if (result == null)
                throw new ArgumentNullException("result", "Parameter result cannot be null.");

            var asyncResult = result as RuntimeAsyncResult;

            if (asyncResult == null)
                throw new ArgumentOutOfRangeException("result", "Parameter result is not of type RuntimeAsyncResult.");

            using (asyncResult)
            {
                if (!asyncResult.IsCompleted)
                {
                    asyncResult.AsyncWaitHandle.WaitOne();
                }

                if (asyncResult.Exception != null)
                {
                    AliyunSDKUtils.PreserveStackTrace(asyncResult.Exception);
                    throw asyncResult.Exception;
                }

                return (TResponse) asyncResult.Response;
            }
        }

        #endregion

        #region Dispose methods

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
                if (RuntimePipeline != null)
                    RuntimePipeline.Dispose();

                _disposed = true;
            }
        }

        private void ThrowIfDisposed()
        {
            if (this._disposed)
                throw new ObjectDisposedException(GetType().FullName);
        }

        #endregion

        protected abstract IServiceSigner CreateSigner();
        protected virtual void CustomizeRuntimePipeline(RuntimePipeline pipeline) { }

        private void BuildRuntimePipeline()
        {
            var httpRequestFactory = new HttpWebRequestFactory();
            var httpHandler = new HttpHandler<Stream>(httpRequestFactory, this);

            // Build default runtime pipeline.
            if (RequestMetrics.IsEnabled)
            {
                this.RuntimePipeline = new RuntimePipeline(new List<IPipelineHandler>
                {
                    httpHandler,
                    new Unmarshaller(),
                    new ErrorHandler(),
                    new Signer(),
                    new CredentialsRetriever(this.Credentials),
                    new RetryHandler(new DefaultRetryPolicy(this.Config.MaxErrorRetry)),
                    new Marshaller(),
                    new MetricsHandler()
                }
                );
            }
            else
            {
                this.RuntimePipeline = new RuntimePipeline(new List<IPipelineHandler>
                {
                    httpHandler,
                    new Unmarshaller(),
                    new ErrorHandler(),
                    new Signer(),
                    new CredentialsRetriever(this.Credentials),
                    new RetryHandler(new DefaultRetryPolicy(this.Config.MaxErrorRetry)),
                    new Marshaller()
                }
                );
            }

            CustomizeRuntimePipeline(this.RuntimePipeline);
        }
        
        internal static Uri ComposeUrl(IRequest iRequest)
        {
            Uri url = iRequest.Endpoint;
            var resourcePath = iRequest.ResourcePath;
            if (resourcePath == null)
                resourcePath = string.Empty;
            else
            {
                if (resourcePath.StartsWith("//", StringComparison.Ordinal))
                    resourcePath = resourcePath.Substring(2);
                else if (resourcePath.StartsWith("/", StringComparison.Ordinal))
                    resourcePath = resourcePath.Substring(1);
            }

            var delim = "?";
            var sb = new StringBuilder();

            if (iRequest.SubResources.Count > 0)
            {
                foreach (var subResource in iRequest.SubResources)
                {
                    sb.AppendFormat("{0}{1}", delim, subResource.Key);
                    if (subResource.Value != null)
                        sb.AppendFormat("={0}", subResource.Value);
                    delim = "&";
                }
            }

            if (iRequest.Parameters.Count > 0)
            {
                var queryString = AliyunSDKUtils.GetParametersAsString(iRequest.Parameters);
                sb.AppendFormat("{0}{1}", delim, queryString);
            }

            var parameterizedPath = string.Concat(resourcePath, sb);
            var uri = new Uri(url.AbsoluteUri + parameterizedPath);
            return uri;
        }
    }
}
