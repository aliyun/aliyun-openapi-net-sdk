using System;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.ErrorHandler
{
    /// <summary>
    /// The interface for an exception handler.
    /// </summary>    
    public interface IExceptionHandler
    {
        /// <summary>
        /// Handles an exception for the given execution context.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <param name="exception">The exception to handle.</param>
        /// <returns>
        /// Returns a boolean value which indicates if the original exception
        /// should be rethrown.
        /// This method can also throw a new exception to replace the original exception.
        /// </returns>
        bool Handle(IExecutionContext executionContext, Exception exception);
    }

    /// <summary>
    /// The interface for an exception handler with a generic parameter for the exception type.
    /// </summary>
    /// <typeparam name="T">The exception type.</typeparam>
    public interface IExceptionHandler<T> : IExceptionHandler where T : Exception
    {
        /// <summary>
        /// Handles an exception for the given execution context.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <param name="exception">The exception to handle.</param>
        /// <returns>
        /// Returns a boolean value which indicates if the original exception
        /// should be rethrown.
        /// This method can also throw a new exception to replace the original exception.
        /// </returns>
        bool HandleException(IExecutionContext executionContext, T exception);
    }
}
