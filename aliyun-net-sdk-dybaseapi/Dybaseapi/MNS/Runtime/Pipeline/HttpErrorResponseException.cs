using System;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline
{
    /// <summary>
    /// HttpErrorResponseException
    /// </summary>
    public class HttpErrorResponseException : Exception
    {
        /// <summary>
        /// Gets and sets original response data. 
        /// </summary>
        public IWebResponseData Response { get; private set; }

        public HttpErrorResponseException(IWebResponseData response)
        {
            this.Response = response;
        }

        public HttpErrorResponseException(string message, IWebResponseData response)
            : base(message)
        {
            this.Response = response;
        }

        public HttpErrorResponseException(string message, Exception innerException, IWebResponseData response) 
            : base(message,innerException)
        {
            this.Response = response;
        }
    }
}
