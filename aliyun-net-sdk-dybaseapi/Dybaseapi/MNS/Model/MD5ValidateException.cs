using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Aliyun.Acs.Dybaseapi.MNS.Model
{
    public class MD5ValidateException : MNSException
    {
        private string _receiptHandle = null;

        public string ReceiptHandle
        {
            get { return this._receiptHandle; }
            set { this._receiptHandle = value; }
        }

        /// <summary>
        /// Constructs a new InvalidArgumentException with the specified error message.
        /// </summary>
        public MD5ValidateException(string message)
            : base(message)
        { }

        public MD5ValidateException(string message, string receiptHandle)
            : base(message)
        {
            this._receiptHandle = receiptHandle;
        }

        public MD5ValidateException(string message, Exception innerException)
            : base(message, innerException)
        { }

        public MD5ValidateException(Exception innerException)
            : base(innerException)
        { }

        public MD5ValidateException(string message, Exception innerException, string errorCode, string requestId, string hostId, HttpStatusCode statusCode)
            : base(message, innerException, errorCode, requestId, hostId, statusCode)
        { }

        public MD5ValidateException(string message, string errorCode, string requestId, string hostId, HttpStatusCode statusCode)
            : base(message, errorCode, requestId, hostId, statusCode)
        { }

    }
}
