using System;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.RetryHandler
{
    /// <summary>
    /// A retry policy specifies all aspects of retry behavior. This includes conditions when the request should be retried,
    /// checks of retry limit, preparing the request before retry and introducing delay (backoff) before retries.
    /// </summary>
    public abstract class RetryPolicy
    {
        /// <summary>
        /// Maximum number of retries to be performed.
        /// This does not count the initial request.
        /// </summary>
        public int MaxRetries { get; protected set; }

        /// <summary>
        /// Checks if a retry should be performed with the given execution context and exception.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <param name="exception">The exception throw after issuing the request.</param>
        /// <returns>Returns true if the request should be retried, else false.</returns>
        public bool Retry(IExecutionContext executionContext, Exception exception)
        {
            return !RetryLimitReached(executionContext) &&
                CanRetry(executionContext) &&
                RetryForException(executionContext, exception);
        }

        /// <summary>
        /// Returns true if the request is in a state where it can be retried, else false.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>Returns true if the request is in a state where it can be retried, else false.</returns>
        public abstract bool CanRetry(IExecutionContext executionContext);

        /// <summary>
        /// Return true if the request should be retried for the given exception.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <param name="exception">The exception thrown by the previous request.</param>
        /// <returns>Return true if the request should be retried.</returns>
        public abstract bool RetryForException(IExecutionContext executionContext, Exception exception);

        /// <summary>
        /// Checks if the retry limit is reached.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>Return false if the request can be retried, based on number of retries.</returns>
        public abstract bool RetryLimitReached(IExecutionContext executionContext);

        /// <summary>
        /// Waits before retrying a request.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public abstract void WaitBeforeRetry(IExecutionContext executionContext);
    }
}
