using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Auth;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;
using System;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline
{
    public interface IRequestContext
    {
        WebServiceRequest OriginalRequest { get; }
        string RequestName { get; }
        IMarshaller<IRequest, WebServiceRequest> Marshaller { get; }
        ResponseUnmarshaller Unmarshaller { get; }
        RequestMetrics Metrics { get; }
        IServiceSigner Signer { get; }
        ClientConfig ClientConfig { get; }
        ImmutableCredentials ImmutableCredentials { get; set; }

        IRequest Request { get; set; }
        bool IsSigned { get; set; }
        bool IsAsync { get; }
        int Retries { get; set; }
    }

    public interface IResponseContext
    {
        WebServiceResponse Response { get; set; }
        IWebResponseData HttpResponse { get; set; }
    }

    public interface IAsyncRequestContext : IRequestContext
    {
        AsyncCallback Callback { get; }
        object State { get; }
    }    

    public interface IAsyncResponseContext : IResponseContext
    {
        RuntimeAsyncResult AsyncResult { get; set; }
    }

    public interface IExecutionContext
    {
        IResponseContext ResponseContext { get; }
        IRequestContext RequestContext { get; }
    }

    public interface IAsyncExecutionContext
    {
        IAsyncResponseContext ResponseContext { get; }
        IAsyncRequestContext RequestContext { get; }

        object RuntimeState { get; set; }
    }
}

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal
{
    public class RequestContext : IRequestContext
    {
        public RequestContext()
        {
            this.Metrics = new RequestMetrics();
        }

        public IRequest Request { get; set; }
        public RequestMetrics Metrics { get; private set; }
        public IServiceSigner Signer { get; set; }
        public ClientConfig ClientConfig { get; set; }
        public int Retries { get; set; }
        public bool IsSigned { get; set; }
        public bool IsAsync { get; set; }
        public WebServiceRequest OriginalRequest { get; set; }
        public IMarshaller<IRequest, WebServiceRequest> Marshaller { get; set; }
        public ResponseUnmarshaller Unmarshaller { get; set; }
        public ImmutableCredentials ImmutableCredentials { get; set; }

        public string RequestName
        {
            get { return this.OriginalRequest.GetType().Name; }
        }
    }

    public class AsyncRequestContext : RequestContext, IAsyncRequestContext
    {
        public AsyncRequestContext():
            base()
        {
        }

        public AsyncCallback Callback { get; set; }
        public object State { get; set; }
    }

    public class ResponseContext : IResponseContext
    {
        public WebServiceResponse Response { get; set; }        
        public IWebResponseData HttpResponse { get; set; }
    }

    public class AsyncResponseContext : ResponseContext, IAsyncResponseContext
    {
        public RuntimeAsyncResult AsyncResult { get; set; }
    }

    public class ExecutionContext : IExecutionContext
    {
        public IRequestContext RequestContext { get; private set; }
        public IResponseContext ResponseContext { get; private set; }        

        public ExecutionContext()
        {
            this.RequestContext = new RequestContext();
            this.ResponseContext = new ResponseContext();
        }

        public ExecutionContext(IRequestContext requestContext, IResponseContext responseContext)
        {
            this.RequestContext = requestContext;
            this.ResponseContext = responseContext;
        }

        public static IExecutionContext CreateFromAsyncContext(IAsyncExecutionContext asyncContext)
        {
            return new ExecutionContext(asyncContext.RequestContext,
                asyncContext.ResponseContext);
        }
    }

    public class AsyncExecutionContext : IAsyncExecutionContext
    {
        public IAsyncResponseContext ResponseContext { get; private set; }
        public IAsyncRequestContext RequestContext { get; private set; }

        public object RuntimeState { get; set; }

        public AsyncExecutionContext()
        {
            this.RequestContext = new AsyncRequestContext();
            this.ResponseContext = new AsyncResponseContext();
        }

        public AsyncExecutionContext(IAsyncRequestContext requestContext, IAsyncResponseContext responseContext)
        {
            this.RequestContext = requestContext;
            this.ResponseContext = responseContext;
        }
    }
}
