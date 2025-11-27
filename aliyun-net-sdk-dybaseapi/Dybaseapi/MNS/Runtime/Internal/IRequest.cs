using System;
using System.Collections.Generic;
using System.IO;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal
{
    /// <summary>
    /// Represents a request being sent to an Aliyun Web Service, including the
    /// parameters being sent as part of the request, the endpoint to which the
    /// request should be sent, etc.
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// The name of the request
        /// </summary>
        string RequestName
        {
            get;
        }

        /// <summary>
        /// Returns a dictionary of the headers included in this request.
        /// </summary>
        IDictionary<string, string> Headers
        {
            get;
        }

        /// <summary>
        /// Gets and sets a flag that indicates whether the request is sent as a query string instead of the request body.
        /// </summary>
        bool UseQueryString
        {
            get;
            set;
        }

        /// <summary>
        /// Returns a dictionary of the parameters included in this request.
        /// </summary>
        IDictionary<String, String> Parameters
        {
            get;
        }

        /// <summary>
        /// Returns the subresources that should be appended to the resource path.
        /// This is used primarily for mns, where object keys can contain '?'
        /// characters, making string-splitting of a resource path potentially 
        /// hazardous.
        /// </summary>
        IDictionary<string, string> SubResources
        {
            get;
        }

        /// <summary>
        /// Adds a new null entry to the SubResources collection for the request
        /// </summary>
        /// <param name="subResource">The name of the subresource</param>
        void AddSubResource(string subResource);

        /// <summary>
        /// Adds a new entry to the SubResources collection for the request
        /// </summary>
        /// <param name="subResource">The name of the subresource</param>
        /// <param name="value">Value of the entry</param>
        void AddSubResource(string subResource, string value);

        /// <summary>
        /// Gets and sets the type of http request to make, whether it should be PUT, POST,GET or DELETE
        /// </summary>
        string HttpMethod
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and Sets the endpoint for this request.
        /// </summary>
        Uri Endpoint
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and Sets the resource path added on to the endpoint.
        /// </summary>
        string ResourcePath
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and Sets the content for this request.
        /// </summary>
        byte[] Content
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and sets the content stream.
        /// </summary>
        Stream ContentStream
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and sets the original stream position.
        /// If ContentStream is null or does not support seek, this propery
        /// should be equal to -1.
        /// </summary>
        long OriginalStreamPosition
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the service to which this request is being sent.
        /// </summary>
        string ServiceName
        {
            get;
        }

        /// <summary>
        /// Returns the original, user facing request object which this internal
        /// request object is representing.
        /// </summary>
        WebServiceRequest OriginalRequest
        {
            get;
        }

        /// <summary>
        /// Gets and sets the Suppress404Exceptions property. If true then 404s return back from MNS will not cause an exception and 
        /// an empty response object will be returned.
        /// </summary>
        bool Suppress404Exceptions
        {
            get;
            set;
        }

        /// <summary>
        /// Checks if the request stream can be rewinded.
        /// </summary>
        /// <returns>Returns true if the request stream can be rewinded ,
        /// else false.</returns>
        bool IsRequestStreamRewindable();

        /// <summary>
        /// Returns true if the request can contain a request body, else false.
        /// </summary>
        /// <returns>Returns true if the currect request can contain a request body, else false.</returns>
        bool MayContainRequestBody();

        /// <summary>
        /// Returns true if the request has a body, else false.
        /// </summary>
        /// <returns>Returns true if the request has a body, else false.</returns>
        bool HasRequestBody();
    }
}
