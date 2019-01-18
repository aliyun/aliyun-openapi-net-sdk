using System;
using System.Collections.Generic;
using System.Net;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime
{
    /// <summary>
    /// Abstract class for Response objects, contains response headers, 
    /// and no result information.
    /// </summary>
    public class WebServiceResponse
    {
        private IDictionary<string, string> _headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private long _contentLength;
        private HttpStatusCode _httpStatusCode;

        /// <summary>
        /// Returns the headers of the HTTP response.
        /// </summary>
        public IDictionary<string, string> Headers
        {
            get { return _headers; }
            set { _headers = value; }
        }

        /// <summary>
        /// Returns the content length of the HTTP response.
        /// </summary>
        public long ContentLength
        {
            get { return this._contentLength; }
            set { this._contentLength = value; }
        }

        /// <summary>
        /// Returns the status code of the HTTP response.
        /// </summary>
        public HttpStatusCode HttpStatusCode
        {
            get { return this._httpStatusCode; }
            set { this._httpStatusCode = value; }
        }
    }
}
