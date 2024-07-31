using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.Handlers
{
    /// <summary>
    /// This handler retrieved the Service credentials to be used for the current call.
    /// </summary>
    public class CredentialsRetriever : GenericHandler
    {
        /// <summary>
        /// The constructor for CredentialsRetriever.
        /// </summary>
        /// <param name="credentials">An Service Credentials instance.</param>
        public CredentialsRetriever(ServiceCredentials credentials)
        {
            this.Credentials = credentials;
        }

        protected ServiceCredentials Credentials
        {
            get;
            private set;
        }

        /// <summary>
        /// Retrieves the credentials to be used for the current call before 
        /// invoking the next handler.
        /// </summary>
        /// <param name="executionContext"></param>
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            ImmutableCredentials ic = null;
            if (Credentials != null && (Credentials is BasicServiceCredentials))
            {
                try
                {
                    executionContext.RequestContext.Metrics.StartEvent(Metric.CredentialsRequestTime);
                    ic = Credentials.GetCredentials();
                }
                finally
                {
                    executionContext.RequestContext.Metrics.StopEvent(Metric.CredentialsRequestTime);
                }
            }

            executionContext.RequestContext.ImmutableCredentials = ic;
        }
    }
}
