using System;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.Handlers
{
    /// <summary>
    /// This handler manages the metrics used to time the complete call and
    /// logs the final metrics.
    /// </summary>
    public class MetricsHandler : PipelineHandler
    {
        /// <summary>
        /// Captures the overall execution time and logs final metrics.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            executionContext.RequestContext.Metrics.AddProperty(Metric.AsyncCall, false);
            try
            {
                executionContext.RequestContext.Metrics.StartEvent(Metric.ClientExecuteTime);
                base.InvokeSync(executionContext);
            }
            finally
            {
                executionContext.RequestContext.Metrics.StopEvent(Metric.ClientExecuteTime);
            }
        }

        /// <summary>
        /// Captures the overall execution time.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent an async operation.</returns>
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            executionContext.RequestContext.Metrics.AddProperty(Metric.AsyncCall, true);
            executionContext.RequestContext.Metrics.StartEvent(Metric.ClientExecuteTime);
            return base.InvokeAsync(executionContext);
        }

        /// <summary>
        /// Captures the overall execution time and logs final metrics.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            executionContext.RequestContext.Metrics.StopEvent(Metric.ClientExecuteTime);
            base.InvokeAsyncCallback(executionContext);
        }

    }
}
