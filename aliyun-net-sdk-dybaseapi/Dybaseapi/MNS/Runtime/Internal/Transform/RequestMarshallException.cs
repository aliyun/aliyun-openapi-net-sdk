using System;
using System.Runtime.Serialization;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform
{
    /// <summary>
    /// RequestMarshallException
    /// </summary>
    internal class RequestMarshallException : InvalidOperationException, ISerializable
    {
        /// <summary>
        /// Constructs a new QueueAlreadyExistException with the specified error message.
        /// </summary>
        public RequestMarshallException(string message) 
            : base(message)
        {
        }

        public RequestMarshallException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        protected RequestMarshallException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
        }
    }
}
