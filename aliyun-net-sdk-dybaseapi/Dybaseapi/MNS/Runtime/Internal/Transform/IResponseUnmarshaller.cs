using System;
using System.Net;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform
{
    /// <summary>
    /// Interface for unmarshallers which unmarshall service responses.
    /// </summary>
    public interface IResponseUnmarshaller<T, R> : IUnmarshaller<T, R>
    {
        /// <summary>
        /// Extracts an exeption with data from an ErrorResponse.
        /// </summary>
        /// <param name="input">The XML parsing context.</param>
        /// <param name="innerException">An inner exception to be included with the returned exception</param>
        /// <param name="statusCode">The HttpStatusCode from the ErrorResponse</param>
        /// <returns>Either an exception based on the ErrorCode from the ErrorResponse, or the 
        /// general service exception for the service in question.</returns>
        AliyunServiceException UnmarshallException(R input, Exception innerException, HttpStatusCode statusCode);
    }
}
