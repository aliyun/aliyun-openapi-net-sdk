using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal
{
    public abstract partial class WebServiceRequest
    {
        readonly IDictionary<string, string> _parameters = new Dictionary<string, string>(StringComparer.Ordinal);
        readonly IDictionary<string, string> _headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private string _contentType;
        private string _contentMD5;

        /// <summary>
        /// Returns a dictionary of the headers included in this request.
        /// </summary>
        public IDictionary<string, string> Headers
        {
            get
            {
                return this._headers;
            }
        }

        /// <summary>
        /// Adds a new entry to the Headers collection for the request
        /// </summary>
        /// <param name="headerName">The name of the header</param>
        /// <param name="value">Value of the entry</param>
        public void AddHeader(string headerName, string value)
        {
            Headers.Add(headerName, value);
        }

        /// <summary>
        /// Returns a dictionary of the parameters included in this request.
        /// </summary>
        public IDictionary<string, string> Parameters
        {
            get
            {
                return this._parameters;
            }
        }

        /// <summary>
        /// Adds a new entry to the Parameters collection for the request
        /// </summary>
        /// <param name="paramName">The name of the parameter</param>
        /// <param name="value">Value of the entry</param>
        public void AddParameter(string paramName, string value)
        {
            Parameters.Add(paramName, value);
        }

        /// <summary>
        /// Returns the content type of the HTTP request.
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        public bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Returns the content MD5 of the HTTP request.
        /// </summary>
        public string ContentMD5
        {
            get { return this._contentMD5; }
            set { this._contentMD5 = value; }
        }

        public bool IsSetContentMD5()
        {
            return this._contentMD5 != null;
        }

        private TimeSpan? _timeoutInternal;

        /// <summary>
        /// Overrides the default request timeout value.
        /// </summary>
        internal TimeSpan? TimeoutInternal
        {
            get { return this._timeoutInternal; }
            set
            {
                ClientConfig.ValidateTimeout(value);
                this._timeoutInternal = value;
            }
        }

        private TimeSpan? _readWriteTimeoutInternal;

        /// <summary>
        /// Overrides the default read-write timeout value.
        /// </summary>
        internal TimeSpan? ReadWriteTimeoutInternal
        {
            get { return this._readWriteTimeoutInternal; }
            set
            {
                ClientConfig.ValidateTimeout(value);
                this._readWriteTimeoutInternal = value;
            }
        }

        /// <summary>
        /// Gets or Sets a value indicating if "Expect: 100-continue" HTTP header will be 
        /// sent by the client for this request. The default value is true.
        /// </summary>
        internal virtual bool Expect100Continue
        {
            get { return true; }            
        }

        /// <summary>
        /// Gets or Sets a value indicating if "KeepAlive" HTTP header will be 
        /// sent by the client for this request. The default value is true.
        /// </summary>
        internal virtual bool KeepAlive
        {
            get { return true; }
        }
    }
}
