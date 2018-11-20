using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;
using Aliyun.Acs.Dybaseapi.MNS.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Auth
{
    /// <summary>
    /// A signer for generating MNS request header named 'Authorization'.
    /// </summary>
    internal class MNSSigner : IServiceSigner
    {
        #region Immutable Properties

        static readonly Regex CompressWhitespaceRegex = new Regex("\\s+");
        const SigningAlgorithm SignerAlgorithm = SigningAlgorithm.HmacSHA1;

        #endregion

        #region Public Signing Methods

        public void Sign(IRequest request, 
                                  RequestMetrics metrics, 
                                  string accessKeyId, 
                                  string secretAccessKey,
		                          string stsToken)
        {
            var signingRequest = SignRequest(request, metrics, secretAccessKey);
            var signingResult = new StringBuilder();
            signingResult.AppendFormat("{0} {1}:{2}", 
                                             MNSConstants.MNS_AUTHORIZATION_HEADER_PREFIX,
                                             accessKeyId, 
                                             signingRequest);
            request.Headers[HttpHeader.AuthorizationHeader] = signingResult.ToString();

			if (!string.IsNullOrEmpty(stsToken))
			{
				request.Headers[HttpHeader.SecurityToken] = stsToken;
			}
        }
       
        public string SignRequest(IRequest request,
                                             RequestMetrics metrics,
                                             string secretAccessKey)
        {
            InitializeHeaders(request.Headers);

            var parametersToCanonicalize = GetParametersToCanonicalize(request);
            var canonicalParameters = CanonicalizeQueryParameters(parametersToCanonicalize);
            var canonicalResource = CanonicalizeResource(canonicalParameters, request.ResourcePath);
            var canonicalMNSHeaders = CanonoicalizeMNSHeaders(request.Headers);
            
            var canonicalRequest = CanonicalizeRequest(request.HttpMethod,
                                                       request.Headers,
                                                       canonicalMNSHeaders,
                                                       canonicalResource);
            if (metrics != null)
                metrics.AddProperty(Metric.CanonicalRequest, canonicalRequest);

            return ComputeSignature(secretAccessKey, canonicalRequest);
        }

        #endregion

        #region Public Signing Helpers

        /// <summary>
        /// Initializes request headers.
        /// </summary>
        /// <param name="headers">The request headers</param>
        private static void InitializeHeaders(IDictionary<string, string> headers)
        {
            // clean up any prior signature in the headers if resigning
            headers.Remove(HttpHeader.AuthorizationHeader);
        }

        /// <summary>
        /// Computes and returns an Service signature for the specified canonicalized request
        /// </summary>
        /// <param name="secretAccessKey"></param>
        /// <param name="canonicalRequest"></param>
        /// <returns></returns>
        public static string ComputeSignature(string secretAccessKey, string canonicalRequest)
        {
            return ComputeKeyedHash(SignerAlgorithm, secretAccessKey, canonicalRequest);
        }

        /// <summary>
        /// Compute and return the hash of a data blob using the specified key
        /// </summary>
        /// <param name="algorithm">Algorithm to use for hashing</param>
        /// <param name="key">Hash key</param>
        /// <param name="data">Data blob</param>
        /// <returns>Hash of the data</returns>
        public static string ComputeKeyedHash(SigningAlgorithm algorithm, string key, string data)
        {
            return CryptoUtilFactory.CryptoInstance.HMACSign(data, key, algorithm);
        }

        #endregion

        #region Private Signing Helpers

        protected static string CanonoicalizeMNSHeaders(IDictionary<string, string> headers)
        {
            var headersToCanonicalize = new SortedDictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            if (headers != null && headers.Count > 0)
            {
                foreach (var header in headers.Where(header =>
                    header.Key.ToLowerInvariant().StartsWith(MNSConstants.X_MNS_HEADER_PREFIX)))
                {
                    headersToCanonicalize.Add(header.Key.ToLowerInvariant(), header.Value);
                }
            }
            return CanonicalizeHeaders(headersToCanonicalize);
        }

        protected static string CanonicalizeResource(string canonicalQueryString, string resourcePath)
        {
            var canonicalResource = new StringBuilder();
            canonicalResource.Append(CanonicalizeResourcePath(resourcePath));
            if (canonicalQueryString != string.Empty)
                canonicalResource.AppendFormat("?{0}", canonicalQueryString);
            return canonicalResource.ToString();
        }

        /// <summary>
        /// Returns the canonicalized resource path for the service endpoint
        /// </summary>
        /// <param name="resourcePath">Resource path for the request</param>
        /// <returns>Canonicalized resource path for the endpoint</returns>
        protected static string CanonicalizeResourcePath(string resourcePath)
        {
            if (string.IsNullOrEmpty(resourcePath) || resourcePath == "/")
                return "/";

            var pathSegments = resourcePath.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var canonicalizedPath = new StringBuilder();
            foreach (var segment in pathSegments)
            {
                canonicalizedPath.AppendFormat("/{0}", segment);
            }

            if (resourcePath.EndsWith("/", StringComparison.Ordinal))
                canonicalizedPath.Append("/");

            return canonicalizedPath.ToString();
        }

        /// <summary>
        /// Computes and returns the canonical request.
        /// </summary>
        /// <param name="httpMethod">The http method used for the request</param>
        /// <param name="headers">The entire request headers</param>
        /// <param name="canonicalMNSHeaders">The canonicalMNSHeaders for the request</param>
        /// <param name="canonicalResource">The canonicalResource for the request</param>
        /// <returns>Canonicalised request as a string</returns>
        protected static string CanonicalizeRequest(string httpMethod,
                                                    IDictionary<string, string> headers,
                                                    string canonicalMNSHeaders,
                                                    string canonicalResource)
        {
            var canonicalRequest = new StringBuilder();
            canonicalRequest.AppendFormat("{0}\n", httpMethod);
            
            var contentMD5 = string.Empty;
            if (headers.ContainsKey(HttpHeader.ContentMD5Header))
                contentMD5 = headers[HttpHeader.ContentMD5Header];
            canonicalRequest.AppendFormat("{0}\n", contentMD5);
            
            var contentType = string.Empty;
            if (headers.ContainsKey(HttpHeader.ContentTypeHeader))
                contentType = headers[HttpHeader.ContentTypeHeader];
            canonicalRequest.AppendFormat("{0}\n", contentType);

            canonicalRequest.AppendFormat("{0}\n", headers[HttpHeader.DateHeader]);
            canonicalRequest.Append(canonicalMNSHeaders);
            canonicalRequest.Append(canonicalResource);

            return canonicalRequest.ToString();
        }

        /// <summary>
        /// Computes the canonical headers with values for the request.
        /// </summary>
        /// <param name="sortedHeaders">All sorted request headers</param>
        /// <returns>The canonical headers.</returns>
        protected static string CanonicalizeHeaders(ICollection<KeyValuePair<string, string>> sortedHeaders)
        {
            if (sortedHeaders == null || sortedHeaders.Count == 0)
                return string.Empty;

            var builder = new StringBuilder();
            foreach (var entry in sortedHeaders)
            {
                builder.Append(entry.Key.ToLower(CultureInfo.InvariantCulture));
                builder.Append(":");
                builder.Append(CompressSpaces(entry.Value));
                builder.Append("\n");
            }

            return builder.ToString();
        }

        /// <summary>
        /// Collects all subresources and query string parameters. 
        /// </summary>
        /// <param name="request">The request being signed</param>
        /// <returns>A set of parameters</returns>
        protected static IDictionary<string, string> GetParametersToCanonicalize(IRequest request)
        {
            var parametersToCanonicalize = new Dictionary<string, string>();

            if (request.SubResources != null && request.SubResources.Count > 0)
            {
                foreach (var subResource in request.SubResources)
                {
                    parametersToCanonicalize.Add(subResource.Key, subResource.Value);
                }
            }

            if (request.Parameters != null && request.Parameters.Count > 0)
            {
                foreach (var queryParameter in request.Parameters.Where(queryParameter => queryParameter.Value != null))
                {
                    parametersToCanonicalize.Add(queryParameter.Key, queryParameter.Value);
                }
            }

            return parametersToCanonicalize;
        }

        /// <summary>
        /// Computes and returns the canonicalized query string
        /// </summary>
        /// <param name="parameters">The set of query string parameters</param>
        /// <returns>The canonical query string parameters</returns>
        protected static string CanonicalizeQueryParameters(IDictionary<string, string> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return string.Empty;

            var canonicalQueryString = new StringBuilder();
            var queryParams = new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);
            foreach (var p in queryParams)
            {
                if (canonicalQueryString.Length > 0)
                    canonicalQueryString.Append("&");
                if (string.IsNullOrEmpty(p.Value))
                    canonicalQueryString.AppendFormat("{0}=", p.Key);
                else
                    canonicalQueryString.AppendFormat("{0}={1}", p.Key, p.Value);
            }

            return canonicalQueryString.ToString();
        }

        static string CompressSpaces(string data)
        {
            if (data == null || !data.Contains(" "))
                return data;

            var compressed = CompressWhitespaceRegex.Replace(data, " ");
            return compressed;
        }

        #endregion
    }
}
