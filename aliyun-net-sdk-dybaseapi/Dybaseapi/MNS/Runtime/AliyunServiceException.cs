using System;
using System.Net;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime
{
    public class AliyunServiceException : Exception
    {
        private HttpStatusCode statusCode;
        private string errorCode;
        private string requestId;
        private string hostId;

        public AliyunServiceException()
            : base()
        {
        }

        public AliyunServiceException(string message)
            : base(message)
        {
        }

        public AliyunServiceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public AliyunServiceException(string message, Exception innerException, HttpStatusCode statusCode)
            : base(message, innerException)
        {
            this.statusCode = statusCode;
        }

        public AliyunServiceException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        public AliyunServiceException(string message, string errorCode, string requestId, string hostId, HttpStatusCode statusCode)
            : base(message)
        {
            this.statusCode = statusCode;
            this.errorCode = errorCode;
            this.requestId = requestId;
            this.hostId = hostId;
        }

        public AliyunServiceException(string message, Exception innerException, string errorCode, string requestId, string hostId, HttpStatusCode statusCode)
            : base(message, innerException)
        {
            this.statusCode = statusCode;
            this.errorCode = errorCode;
            this.requestId = requestId;
            this.hostId = hostId;
        }

        /// <summary>
        /// The HTTP status code from the service response
        /// </summary>
        public HttpStatusCode StatusCode
        {
            get { return this.statusCode; }
            set { this.statusCode = value; }
        }

        /// <summary>
        /// The error code returned by the service
        /// </summary>
        public string ErrorCode
        {
            get { return this.errorCode; }
            set { this.errorCode = value; }
        }

        /// <summary>
        /// The id of the request which generated the exception.
        /// </summary>
        public string RequestId
        {
            get { return this.requestId; }
            set { this.requestId = value; }
        }

        /// <summary>
        /// The host id of the request which generated the exception.
        /// </summary>
        public string HostId
        {
            get { return this.hostId; }
            set { this.hostId = value; }
        }
    }
}
