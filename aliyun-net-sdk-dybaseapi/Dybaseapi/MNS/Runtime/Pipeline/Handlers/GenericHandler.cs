using System;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.Handlers
{    
    /// <summary>
    /// A generic handler that provides overridable PreInvoke and PostInvoke methods. 
    /// This class is intended be used as a base class for handlers which perform simple processing.
    /// </summary>
    public abstract class GenericHandler : PipelineHandler
    {
        /// <summary>
        /// Calls the PreInvoke and PostInvoke methods before and after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
            PostInvoke(executionContext);            
        }

        /// <summary>
        /// Calls the PreInvoke method before calling the next handler in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent an async operation.</returns>
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            PreInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            return base.InvokeAsync(executionContext);
        }

        /// <summary>
        /// Calls the PostInvoke methods after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            PostInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            base.InvokeAsyncCallback(executionContext);           
        }

        /// <summary>
        /// This method is invoked before calling the next handler in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected virtual void PreInvoke(IExecutionContext executionContext) { }

        /// <summary>
        /// This method is invoked after calling the next handler in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected virtual void PostInvoke(IExecutionContext executionContext) { }        
    }
}
