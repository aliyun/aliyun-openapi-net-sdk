using System;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline
{
    /// <summary>
    /// An abstract pipeline handler that has implements IPipelineHandler,
    /// and has the default implmentation. This is the base class for most of
    /// the handler implementations.
    /// </summary>
    public abstract partial class PipelineHandler : IPipelineHandler
    {
        /// <summary>
        /// The inner handler which is called after the current 
        /// handler completes it's processing.
        /// </summary>
        public IPipelineHandler InnerHandler { get; set; }

        /// <summary>
        /// The outer handler which encapsulates the current handler.
        /// </summary>
        public IPipelineHandler OuterHandler { get; set; }

        /// <summary>
        /// Contains the processing logic for a synchronous request invocation.
        /// This method calls InnerHandler.InvokeSync to continue processing of the
        /// request by the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public virtual void InvokeSync(IExecutionContext executionContext)
        {
            if (this.InnerHandler != null)
            {
                InnerHandler.InvokeSync(executionContext);
                return;
            }
            throw new InvalidOperationException("Cannot invoke InnerHandler. InnerHandler is not set.");
        }

        /// <summary>
        /// Contains the processing logic for an asynchronous request invocation.
        /// This method should calls InnerHandler.InvokeSync to continue processing of the
        /// request by the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent an async operation.</returns>
        public virtual IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            if (this.InnerHandler != null)
            {
                return InnerHandler.InvokeAsync(executionContext);
            }
            throw new InvalidOperationException("Cannot invoke InnerHandler. InnerHandler is not set.");
        }

        /// <summary>
        /// This callback method is called by the callback method of the inner handler
        /// as part of asynchronous processing after any underlying asynchronous
        /// operations complete. 
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        public void AsyncCallback(IAsyncExecutionContext executionContext)
        {
            try
            {
                this.InvokeAsyncCallback(executionContext);
            }
            catch (Exception exception)
            {
                executionContext.RequestContext.Metrics.AddProperty(Metric.Exception, exception);

                // An unhandled exception occured in the callback implementation.
                // Capture the exception and end the callback processing by signalling the
                // wait handle.
                executionContext.RequestContext.Metrics.StopEvent(Metric.ClientExecuteTime);

                var asyncResult = executionContext.ResponseContext.AsyncResult;
                asyncResult.Exception = exception;
                asyncResult.SignalWaitHandle();
                if (asyncResult.AsyncCallback != null)
                {
                    asyncResult.AsyncCallback(asyncResult);
                }
            }
        }

        /// <summary>
        /// This callback method contains the processing logic that should be executed 
        /// after the underlying asynchronous operation completes.
        /// This method is called as part of a callback chain which starts 
        /// from the InvokeAsyncCallback method of the bottommost handler and then invokes
        /// each callback method of the handler above it.
        /// This method calls OuterHandler.AsyncCallback to continue processing of the
        /// request by the pipeline, unless it's the topmost handler.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected virtual void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            if (this.OuterHandler!=null)
            {
                this.OuterHandler.AsyncCallback(executionContext);    
            }
            else
            {
                // No more outer handlers to process, signal completion
                executionContext.ResponseContext.AsyncResult.Response =
                    executionContext.ResponseContext.Response;                
                
                var asyncResult = executionContext.ResponseContext.AsyncResult;                
                asyncResult.SignalWaitHandle();
                if (asyncResult.AsyncCallback != null)
                {
                    asyncResult.AsyncCallback(asyncResult);
                }
            }
        }
    }
}
