/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

using System;
using System.Net;

namespace Aliyun.Acs.Dybaseapi.MNS.Model
{
    ///<summary>
    /// QueueNotExistException
    /// </summary>
    public class QueueNotExistException : MNSException 
    {
        /// <summary>
        /// Constructs a new QueueNotExistException with the specified error message.
        /// </summary>
        public QueueNotExistException(string message) 
            : base(message) {}
          
        public QueueNotExistException(string message, Exception innerException) 
            : base(message, innerException) {}
            
        public QueueNotExistException(Exception innerException) 
            : base(innerException) {}

        public QueueNotExistException(string message, string errorCode, string requestId, string hostId, HttpStatusCode statusCode)
            : base(message, errorCode, requestId, hostId, statusCode) { }

        public QueueNotExistException(string message, Exception innerException, string errorCode, string requestId, string hostId, HttpStatusCode statusCode)
            : base(message, innerException, errorCode, requestId, hostId, statusCode) { }
    }
}
