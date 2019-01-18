/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

using System;
using System.Net;
using Aliyun.Acs.Dybaseapi.MNS.Runtime;

namespace Aliyun.Acs.Dybaseapi.MNS
{
    /// <summary>
    /// Base class for all MNS exception classes. 
    /// </summary>
    public class MNSException : AliyunServiceException
    {
        public MNSException(string message)
            : base(message)
        {
        }

        public MNSException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public MNSException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        public MNSException(string message, string errorCode, string requestId, string hostId, HttpStatusCode statusCode)
            : base(message, errorCode, requestId, hostId, statusCode)
        {
        }

        public MNSException(string message, Exception innerException, string errorCode, string requestId, string hostId, HttpStatusCode statusCode)
            : base(message, innerException, errorCode, requestId, hostId, statusCode)
        {
        }
    }
}
