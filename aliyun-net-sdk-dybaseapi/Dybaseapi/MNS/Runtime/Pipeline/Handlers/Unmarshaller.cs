using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.Handlers
{
    /// <summary>
    /// This handler unmarshalls the HTTP response.
    /// </summary>
    public class Unmarshaller : PipelineHandler
    {
        /// <summary>
        /// Unmarshalls the response returned by the HttpHandler.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            base.InvokeSync(executionContext);

            if (executionContext.ResponseContext.HttpResponse.IsSuccessStatusCode)
            {
                // Unmarshall the http response.
                Unmarshall(executionContext);  
            }                      
        }

        /// <summary>
        /// Unmarshalls the response returned by the HttpHandler.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            // Unmarshall the response if an exception hasn't occured
            if (executionContext.ResponseContext.AsyncResult.Exception == null)
            {
                Unmarshall(ExecutionContext.CreateFromAsyncContext(executionContext));
            }            
            base.InvokeAsyncCallback(executionContext);
        }

        /// <summary>
        /// Unmarshalls the HTTP response.
        /// </summary>
        /// <param name="executionContext">
        /// The execution context, it contains the request and response context.
        /// </param>
        private void Unmarshall(IExecutionContext executionContext)
        {
            var requestContext = executionContext.RequestContext;
            var responseContext = executionContext.ResponseContext;

            try
            {
                var unmarshaller = requestContext.Unmarshaller;
                try
                {
                    requestContext.Metrics.StartEvent(Metric.ResponseProcessingTime);
                    var context = unmarshaller.CreateContext(responseContext.HttpResponse,
                            responseContext.HttpResponse.ResponseBody.OpenResponse(),
                            requestContext.Metrics);

                    var response = UnmarshallResponse(context, requestContext);
                    responseContext.Response = response;                    
                }
                finally
                {
                    if (!unmarshaller.HasStreamingProperty)
                        responseContext.HttpResponse.ResponseBody.Dispose();
                }
            }
            finally
            {
                requestContext.Metrics.StopEvent(Metric.ResponseProcessingTime);
            }
        }

        private WebServiceResponse UnmarshallResponse(UnmarshallerContext context,
            IRequestContext requestContext)
        {
            var unmarshaller = requestContext.Unmarshaller;
            WebServiceResponse response = null;
            try
            {
                requestContext.Metrics.StartEvent(Metric.ResponseUnmarshallTime);
                response = unmarshaller.UnmarshallResponse(context);
            }
            finally
            {
                requestContext.Metrics.StopEvent(Metric.ResponseUnmarshallTime);
            }

            requestContext.Metrics.AddProperty(Metric.StatusCode, response.HttpStatusCode);
            requestContext.Metrics.AddProperty(Metric.BytesProcessed, response.ContentLength);

            return response;
        }
    }
}
