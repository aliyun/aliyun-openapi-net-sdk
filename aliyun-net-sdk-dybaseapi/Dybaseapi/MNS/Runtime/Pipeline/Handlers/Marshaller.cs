using System;
using System.Collections.Generic;
using System.Globalization;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Util;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.Handlers
{
    /// <summary>
    /// This handler marshalls the request before calling invoking the next handler.
    /// </summary>
    public class Marshaller : GenericHandler
    {
        /// <summary>
        /// Marshalls the request before calling invoking the next handler.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            try
            {
                executionContext.RequestContext.Metrics.StartEvent(Metric.RequestMarshallTime);

                IRequestContext requestContext = executionContext.RequestContext;
                requestContext.Request = requestContext.Marshaller.Marshall(requestContext.OriginalRequest);
                requestContext.Request.Endpoint = requestContext.ClientConfig.RegionEndpoint;
                AddRequiredHeaders(requestContext);
                AddOptionalHeaders(requestContext);
            }
            finally
            {
                executionContext.RequestContext.Metrics.StopEvent(Metric.RequestMarshallTime);
            }
        }

        private void AddRequiredHeaders(IRequestContext requestContext)
        {
            IDictionary<string, string> headers = requestContext.Request.Headers;
            headers[HttpHeader.UserAgentHeader] = requestContext.ClientConfig.UserAgent;
            if (requestContext.Request.ContentStream != null)
                headers[HttpHeader.ContentLengthHeader] = requestContext.Request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            headers[HttpHeader.DateHeader] = AliyunSDKUtils.FormattedCurrentTimestampRFC822;
            headers[HttpHeader.XMnsVersionHeader] = requestContext.ClientConfig.ServiceVersion;
            if (!headers.ContainsKey(HttpHeader.HostHeader))
            {
                Uri requestEndpoint = requestContext.Request.Endpoint;
                var hostHeader = requestEndpoint.Host;
                if (!requestEndpoint.IsDefaultPort)
                    hostHeader += ":" + requestEndpoint.Port;
                headers.Add(HttpHeader.HostHeader, hostHeader);
            }
        }

        private void AddOptionalHeaders(IRequestContext requestContext)
        {
            WebServiceRequest originalRequest = requestContext.Request.OriginalRequest;
            IDictionary<string, string> headers = requestContext.Request.Headers;
            if (originalRequest.IsSetContentType())
                headers[HttpHeader.ContentTypeHeader] = originalRequest.ContentType;
            else
                headers[HttpHeader.ContentTypeHeader] = MNSConstants.ContentTypeTextXml;
            if (originalRequest.IsSetContentMD5())
                headers[HttpHeader.ContentMD5Header] = originalRequest.ContentMD5;
        }
    }
}
