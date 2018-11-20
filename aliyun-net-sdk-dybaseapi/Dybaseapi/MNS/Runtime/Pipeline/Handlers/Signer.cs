using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.Handlers
{
    /// <summary>
    /// This handler for signing MNS request.
    /// </summary>
    public class Signer : GenericHandler
    {
        /// <summary>
        /// Signs the request before invoking the next handler.
        /// </summary>
        /// <param name="executionContext">
        /// The execution context, it contains the request and response context.
        /// </param>
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            if (ShouldSign(executionContext.RequestContext))
            {
                SignRequest(executionContext.RequestContext);
                executionContext.RequestContext.IsSigned = true;
            } 
        }

        /// <summary>
        /// Determines if the request should be signed.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        /// <returns>A boolean value that indicated if the request should be signed.</returns>
        private static bool ShouldSign(IRequestContext requestContext)
        {
            return !requestContext.IsSigned ||
                requestContext.ClientConfig.ResignRetries;
        }

        /// <summary>
        /// Signs the request.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        internal static void SignRequest(IRequestContext requestContext)
        {
            ImmutableCredentials immutableCredentials = requestContext.ImmutableCredentials;

            if (immutableCredentials == null)
                return;

            try
            {
                requestContext.Metrics.StartEvent(Metric.RequestSigningTime);
                requestContext.Signer.Sign(requestContext.Request, requestContext.Metrics,
				                           immutableCredentials.AccessKey, immutableCredentials.SecretKey, immutableCredentials.SecurityToken);
            }
            finally
            {
                requestContext.Metrics.StopEvent(Metric.RequestSigningTime);
            }
        }
    }
}
