using System;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline
{
    /// <summary>
    /// Interface for a pipeline handler in a pipeline.
    /// </summary>
    public partial interface IPipelineHandler
    {
        /// <summary>
        /// The inner handler which is called after the current 
        /// handler completes it's processing.
        /// </summary>
        IPipelineHandler InnerHandler { get; set; }

        /// <summary>
        /// The outer handler which encapsulates the current handler.
        /// </summary>
        IPipelineHandler OuterHandler { get; set; }

        /// <summary>
        /// Contains the processing logic for a synchronous request invocation.
        /// This method should call InnerHandler.InvokeSync to continue processing of the
        /// request by the pipeline, unless it's a terminating handler.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        void InvokeSync(IExecutionContext executionContext);

        /// <summary>
        /// Contains the processing logic for an asynchronous request invocation.
        /// This method should call InnerHandler.InvokeSync to continue processing of the
        /// request by the pipeline, unless it's a terminating handler.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent a async operation.</returns>
        IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext);

        /// <summary>
        /// This callback method contains the processing logic that should be executed 
        /// after the underlying asynchronous operation completes.
        /// This method is called as part of a callback chain which starts 
        /// from the InvokeAsyncCallback method of the bottommost handler and then invokes
        /// each callback method of the handler above it.
        /// This method should call OuterHandler.AsyncCallback to continue processing of the
        /// request by the pipeline, unless it's the topmost handler.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        void AsyncCallback(IAsyncExecutionContext executionContext);
    }
}
