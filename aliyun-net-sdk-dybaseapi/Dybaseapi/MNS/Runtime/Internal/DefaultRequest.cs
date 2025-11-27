using System;
using System.Collections.Generic;
using System.IO;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal
{
    /// <summary>
    /// Default implementation of the IRequest interface.
    /// </summary>
    internal class DefaultRequest : IRequest
    {
        readonly IDictionary<string, string> parameters = new Dictionary<string, string>(StringComparer.Ordinal);
        readonly IDictionary<string, string> headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        readonly IDictionary<string, string> subResources = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        Uri endpoint;
        string resourcePath;
        string serviceName;
        readonly WebServiceRequest originalRequest;
        byte[] content;
        Stream contentStream;
        string httpMethod = "GET";
        bool useQueryString = false;
        string requestName;
        long originalStreamLength;

        /// <summary>
        /// Constructs a new DefaultRequest with the specified service name and the
        /// original, user facing request object.
        /// </summary>
        /// <param name="request">The orignal request that is being wrapped</param>
        /// <param name="serviceName">The service name</param>
        public DefaultRequest(WebServiceRequest request, String serviceName)
        {
            if (request == null) throw new ArgumentNullException("request");
            if (string.IsNullOrEmpty(serviceName)) throw new ArgumentNullException("serviceName");

            this.serviceName = serviceName;
            this.originalRequest = request;
            this.requestName = this.originalRequest.GetType().Name;

            foreach (var header in request.Headers)
                this.Headers.Add(header.Key, header.Value);
            foreach (var param in request.Parameters)
                this.Parameters.Add(param.Key, param.Value);
        }


        /// <summary>
        /// The name of the request
        /// </summary>
        public string RequestName
        {
            get { return this.requestName; }
        }


        /// <summary>
        /// Gets and sets the type of http request to make, whether it should be POST,GET or DELETE
        /// </summary>
        public string HttpMethod
        {
            get
            {
                return this.httpMethod;
            }
            set
            {
                this.httpMethod = value;
            }
        }

        /// <summary>
        /// Gets and sets a flag that indicates whether the request is sent as a query string instead of the request body.
        /// </summary>
        public bool UseQueryString
        {
            get
            {
                return this.useQueryString;
            }
            set
            {
                this.useQueryString = value;
            }
        }

        /// <summary>
        /// Returns the original, user facing request object which this internal
        /// request object is representing.
        /// </summary>
        public WebServiceRequest OriginalRequest
        {
            get
            {
                return originalRequest;
            }
        }

        /// <summary>
        /// Returns a dictionary of the headers included in this request.
        /// </summary>
        public IDictionary<string, string> Headers
        {
            get
            {
                return this.headers;
            }
        }


        /// <summary>
        /// Returns a dictionary of the parameters included in this request.
        /// </summary>
        public IDictionary<string, string> Parameters
        {
            get
            {
                return this.parameters;
            }
        }

        /// <summary>
        /// Returns the subresources that should be appended to the resource path.
        /// This is used primarily for mns, where object keys can contain '?'
        /// characters, making string-splitting of a resource path potentially 
        /// hazardous.
        /// </summary>
        public IDictionary<string, string> SubResources
        {
            get
            {
                return this.subResources;
            }
        }

        /// <summary>
        /// Adds a new null entry to the SubResources collection for the request
        /// </summary>
        /// <param name="subResource">The name of the subresource</param>
        public void AddSubResource(string subResource)
        {
            AddSubResource(subResource, null);
        }

        /// <summary>
        /// Adds a new entry to the SubResources collection for the request
        /// </summary>
        /// <param name="subResource">The name of the subresource</param>
        /// <param name="value">Value of the entry</param>
        public void AddSubResource(string subResource, string value)
        {
            SubResources.Add(subResource, value);
        }

        /// <summary>
        /// Gets and Sets the endpoint for this request.
        /// </summary>
        public Uri Endpoint
        {
            get
            {
                return this.endpoint;
            }
            set
            {
                this.endpoint = value;
            }
        }

        /// <summary>
        /// Gets and Sets the resource path added on to the endpoint.
        /// </summary>
        public string ResourcePath
        {
            get
            {
                return this.resourcePath;
            }
            set
            {
                this.resourcePath = value;
            }
        }

        /// <summary>
        /// Gets and Sets the content for this request.
        /// </summary>
        public byte[] Content
        {
            get
            {
                return this.content;
            }
            set
            {
                this.content = value;
            }
        }

        /// <summary>
        /// Gets and sets the content stream.
        /// </summary>
        public Stream ContentStream
        {
            get { return this.contentStream; }
            set
            {
                this.contentStream = value;
                OriginalStreamPosition = -1;
                if (this.contentStream != null && this.contentStream.CanSeek)
                    OriginalStreamPosition = this.contentStream.Position;
            }
        }

        /// <summary>
        /// Gets and sets the original stream position.
        /// If ContentStream is null or does not support seek, this propery
        /// should be equal to -1.
        /// </summary>
        public long OriginalStreamPosition
        {
            get { return this.originalStreamLength; }
            set { this.originalStreamLength = value; }
        }

        /// <summary>
        /// The name of the service to which this request is being sent.
        /// </summary>
        public string ServiceName
        {
            get
            {
                return this.serviceName;
            }
        }

        /// <summary>
        /// Gets and sets the Suppress404Exceptions property. If true then 404s return back from MNS will not cause an exception and 
        /// an empty response object will be returned.
        /// </summary>
        public bool Suppress404Exceptions
        {
            get;
            set;
        }

		/// <summary>
        /// Checks if the request stream can be rewinded.
        /// </summary>
        /// <returns>Returns true if the request stream can be rewinded ,
        /// else false.</returns>
        public bool IsRequestStreamRewindable()
        {
            // Retries may not be possible with a stream
            if (this.ContentStream != null)
            {
                // Retry is possible if stream is seekable
                return this.ContentStream.CanSeek;
            }
            return true;
        }

        /// <summary>
        /// Returns true if the request can contain a request body, else false.
        /// </summary>
        /// <returns>Returns true if the currect request can contain a request body, else false.</returns>
        public bool MayContainRequestBody()
        {
            return !this.UseQueryString &&
                (this.HttpMethod == "POST" ||
                 this.HttpMethod == "PUT" ||
                 this.HttpMethod == "DELETE");
        }

        /// <summary>
        /// Returns true if the request has a body, else false.
        /// </summary>
        /// <returns>Returns true if the request has a body, else false.</returns>
        public bool HasRequestBody()
        {
            return (this.HttpMethod == "POST" ||
                    this.HttpMethod == "PUT" ||
                    this.HttpMethod == "DELETE") &&
                ((this.Content != null) ||
                        this.ContentStream != null);
        }
    }
}
