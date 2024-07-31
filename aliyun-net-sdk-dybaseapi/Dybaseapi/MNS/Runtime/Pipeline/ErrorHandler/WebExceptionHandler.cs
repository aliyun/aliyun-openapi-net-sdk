using System.Globalization;
using System.Net;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.ErrorHandler
{
    /// <summary>
    /// The exception handler for HttpErrorResponseException exception.
    /// </summary>
    public class WebExceptionHandler : ExceptionHandler<WebException>
    {
        public WebExceptionHandler() :
            base()
        {
        }

        public override bool HandleException(IExecutionContext executionContext, WebException exception)
        {
            var requestContext = executionContext.RequestContext;
            var httpErrorResponse = exception.Response as HttpWebResponse;

            if (httpErrorResponse != null)
                requestContext.Metrics.AddProperty(Metric.StatusCode, httpErrorResponse.StatusCode);

            var message = string.Format(CultureInfo.InvariantCulture,
                    "A WebException with status {0} was thrown, caused by {1}", exception.Status, exception.Message);
            throw new AliyunServiceException(message, exception);
        }
    }
}
