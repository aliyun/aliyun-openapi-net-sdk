using System;
using System.Net;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.RetryHandler
{
    /// <summary>
    /// The retry handler has the generic logic for retrying requests.
    /// It uses a retry policy which specifies when 
    /// a retry should be performed.
    /// </summary>
    public class RetryHandler : PipelineHandler
    {
        /// <summary>
        /// The retry policy which specifies when 
        /// a retry should be performed.
        /// </summary>
        public RetryPolicy RetryPolicy { get; private set; }
        
        /// <summary>
        /// Constructor which takes in a retry policy.
        /// </summary>
        /// <param name="retryPolicy">Retry Policy</param>
        public RetryHandler(RetryPolicy retryPolicy)
        {
            this.RetryPolicy = retryPolicy;
        }

        /// <summary>
        /// Invokes the inner handler and performs a retry, if required as per the
        /// retry policy.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            var requestContext = executionContext.RequestContext;
            bool shouldRetry = false;
            do
            {                
                try
                {
                    base.InvokeSync(executionContext);
                    try
                    {
                        if (requestContext.Request.ContentStream != null)
                        {
                            requestContext.Request.ContentStream.Close();
                        }
                    }
                    catch (Exception)
                    {
                    }
                    return;
                }
                catch (Exception exception)
                {
                    shouldRetry = this.RetryPolicy.Retry(executionContext, exception);
                    if (!shouldRetry)
                    {
                        throw;
                    }
                    else
                    {
                        requestContext.Retries++;
                        requestContext.Metrics.SetCounter(Metric.AttemptCount, requestContext.Retries);                    
                    }
                }

                PrepareForRetry(requestContext);

                try
                {
                    requestContext.Metrics.StartEvent(Metric.RetryPauseTime);
                    this.RetryPolicy.WaitBeforeRetry(executionContext);
                }
                finally
                {
                    requestContext.Metrics.StopEvent(Metric.RetryPauseTime);
                }

            } while (shouldRetry);
        }

        /// <summary>
        /// Invokes the inner handler and performs a retry, if required as per the
        /// retry policy.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            var requestContext = executionContext.RequestContext;
            var responseContext = executionContext.ResponseContext;
            var exception = responseContext.AsyncResult.Exception;
            
            if (exception != null)
            {
                var syncExecutionContext = ExecutionContext.CreateFromAsyncContext(executionContext);
                var shouldRetry = this.RetryPolicy.Retry(syncExecutionContext, exception);
                if (shouldRetry)
                {
                    requestContext.Retries++;
                    requestContext.Metrics.SetCounter(Metric.AttemptCount, requestContext.Retries);   

                    PrepareForRetry(requestContext);

                    try
                    {
                        requestContext.Metrics.StartEvent(Metric.RetryPauseTime);
                        this.RetryPolicy.WaitBeforeRetry(syncExecutionContext);
                    }
                    finally
                    {
                        requestContext.Metrics.StopEvent(Metric.RetryPauseTime);
                    }

                    // Retry by calling InvokeAsync
                    this.InvokeAsync(executionContext);
                    return;
                }
            }

            // Call outer handler
            base.InvokeAsyncCallback(executionContext);
        }

        /// <summary>
        /// Prepares the request for retry.
        /// </summary>
        /// <param name="requestContext">Request context containing the state of the request.</param>
        internal static void PrepareForRetry(IRequestContext requestContext)
        {
            if (requestContext.Request.ContentStream != null &&
                requestContext.Request.OriginalStreamPosition >= 0)
            {
                var stream = requestContext.Request.ContentStream;
                stream.Position = requestContext.Request.OriginalStreamPosition;
            }
        }      
    }
}
