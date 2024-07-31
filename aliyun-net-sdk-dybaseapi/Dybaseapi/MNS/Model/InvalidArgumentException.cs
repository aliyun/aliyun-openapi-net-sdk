/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

using System;
using System.Net;

namespace Aliyun.Acs.Dybaseapi.MNS.Model
{
    ///<summary>
    /// InvalidArgumentException
    /// </summary>
    public class InvalidArgumentException : MNSException 
    {
        /// <summary>
        /// Constructs a new InvalidArgumentException with the specified error message.
        /// </summary>
        public InvalidArgumentException(string message) 
            : base(message) {}
          
        public InvalidArgumentException(string message, Exception innerException) 
            : base(message, innerException) {}
            
        public InvalidArgumentException(Exception innerException) 
            : base(innerException) {}
            
        public InvalidArgumentException(string message, Exception innerException, string errorCode, string requestId, string hostId, HttpStatusCode statusCode) 
            : base(message, innerException, errorCode, requestId, hostId, statusCode) {}

        public InvalidArgumentException(string message, string errorCode, string requestId, string hostId, HttpStatusCode statusCode) 
            : base(message, errorCode, requestId, hostId, statusCode) {}

    }
}