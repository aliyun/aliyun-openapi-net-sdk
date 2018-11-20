using System;
using System.Diagnostics;
using System.Net;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;
using Aliyun.Acs.Dybaseapi.MNS.Util;
using System.IO;
using System.Text;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.ErrorHandler
{
    /// <summary>
    /// The exception handler for HttpErrorResponseException exception.
    /// </summary>
    public class HttpErrorResponseExceptionHandler : ExceptionHandler<HttpErrorResponseException>
    {
        /// <summary>
        /// The constructor for HttpErrorResponseExceptionHandler.
        /// </summary>
        public HttpErrorResponseExceptionHandler() :
            base()
        {
        }

        /// <summary>
        /// Handles an exception for the given execution context.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <param name="exception">The exception to handle.</param>
        /// <returns>
        /// Returns a boolean value which indicates if the original exception
        /// should be rethrown.
        /// This method can also throw a new exception to replace the original exception.
        /// </returns>
        public override bool HandleException(IExecutionContext executionContext, HttpErrorResponseException exception)
        {
            var requestContext = executionContext.RequestContext;
            var httpErrorResponse = exception.Response;

            // If 404 was suppressed and successfully unmarshalled,
            // don't rethrow the original exception.
            if (HandleSuppressed404(executionContext, httpErrorResponse))
                return false;

            requestContext.Metrics.AddProperty(Metric.StatusCode, httpErrorResponse.StatusCode);

            AliyunServiceException errorResponseException = null;
            // Unmarshall the service error response and throw the corresponding service exception
            string responseContent = null;
            try
            {
                using (httpErrorResponse.ResponseBody)
                {
                    var unmarshaller = requestContext.Unmarshaller;

                    var errorContext = unmarshaller.CreateContext(httpErrorResponse,
                        httpErrorResponse.ResponseBody.OpenResponse(),
                        requestContext.Metrics);

                    using (MemoryStream stream = new MemoryStream())
                    {
                        AliyunSDKUtils.CopyTo(errorContext.ResponseStream, stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, (int)stream.Length);
                        responseContent = Encoding.UTF8.GetString(bytes);
                        stream.Seek(0, SeekOrigin.Begin);

                        errorContext.ResponseStream = stream;

                        errorResponseException = unmarshaller.UnmarshallException(errorContext,
                            exception, httpErrorResponse.StatusCode);
                        Debug.Assert(errorResponseException != null);

                        requestContext.Metrics.AddProperty(Metric.RequestId, errorResponseException.RequestId);
                        requestContext.Metrics.AddProperty(Metric.ErrorCode, errorResponseException.ErrorCode);
                    }
                }
            }
            catch (ResponseUnmarshallException unmarshallException)
            {
                if (responseContent != null)
                {
                    throw new AliyunServiceException(responseContent, unmarshallException, 
                        MNSErrorCode.InternalError, 
                        null, null, httpErrorResponse.StatusCode);
                }
                throw;
            }

            throw errorResponseException;
        }

        /// <summary>
        /// Checks if a HTTP 404 status code is returned which needs to be suppressed and 
        /// processes it.
        /// If a suppressed 404 is present, it unmarshalls the response and returns true to 
        /// indicate that a suppressed 404 was processed, else returns false.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <param name="httpErrorResponse"></param>
        /// <returns>
        /// If a suppressed 404 is present, returns true, else returns false.
        /// </returns>
        private bool HandleSuppressed404(IExecutionContext executionContext, IWebResponseData httpErrorResponse)
        {
            var requestContext = executionContext.RequestContext;
            var responseContext = executionContext.ResponseContext;

            // If the error is a 404 and the request is configured to supress it,
            // then unmarshall as much as we can.
            if (httpErrorResponse != null &&
                httpErrorResponse.StatusCode == HttpStatusCode.NotFound &&
                requestContext.Request.Suppress404Exceptions)
            {
                using (httpErrorResponse.ResponseBody)
                {
                    var unmarshaller = requestContext.Unmarshaller;

                    UnmarshallerContext errorContext = unmarshaller.CreateContext(
                        httpErrorResponse,
                        httpErrorResponse.ResponseBody.OpenResponse(),
                        requestContext.Metrics);
                    try
                    {
                        responseContext.Response = unmarshaller.Unmarshall(errorContext);
                        responseContext.Response.ContentLength = httpErrorResponse.ContentLength;
                        responseContext.Response.HttpStatusCode = httpErrorResponse.StatusCode;
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
