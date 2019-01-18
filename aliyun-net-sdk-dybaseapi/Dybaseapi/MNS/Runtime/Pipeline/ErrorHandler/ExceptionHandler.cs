/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 * 
 * 
 */

using System;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.ErrorHandler
{
    /// <summary>
    /// The abstract base class for exception handlers.
    /// </summary>
    /// <typeparam name="T">The exception type.</typeparam>
    public abstract class ExceptionHandler<T> : IExceptionHandler<T> where T : Exception
    {
        protected ExceptionHandler()
        {
        }

        public bool Handle(IExecutionContext executionContext, Exception exception)
        {
            return HandleException(executionContext, exception as T);
        }

        public abstract bool HandleException(IExecutionContext executionContext, T exception);
    }
}
