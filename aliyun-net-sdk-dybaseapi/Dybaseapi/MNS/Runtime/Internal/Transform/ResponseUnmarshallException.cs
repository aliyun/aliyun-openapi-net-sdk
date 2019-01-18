using System;
using System.Runtime.Serialization;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform
{
    /// <summary>
    /// Exception thrown during deserializing response.
    /// </summary>
    [Serializable]
    internal class ResponseUnmarshallException : InvalidOperationException, ISerializable
    {
        public ResponseUnmarshallException()
        {
        }

         public ResponseUnmarshallException(string message) 
             : base(message)
        {
        }

        public ResponseUnmarshallException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        protected ResponseUnmarshallException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
        }
    }
}