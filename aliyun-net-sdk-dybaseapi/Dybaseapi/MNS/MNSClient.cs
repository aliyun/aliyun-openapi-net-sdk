/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

using System;
using Aliyun.Acs.Dybaseapi.MNS.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Model;
using Aliyun.Acs.Dybaseapi.MNS.Model.Internal.MarshallTransformations;
using Aliyun.Acs.Dybaseapi.MNS.Runtime;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Auth;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline.Handlers;

namespace Aliyun.Acs.Dybaseapi.MNS
{
    /// <summary>
    /// Implementation for accessing MNS
    /// </summary>
    public partial class MNSClient : AliyunServiceClient, IMNS
    {
        #region Constructors

        /// <summary>
        /// Constructs MNSClient with Aliyun Service Credentials.
        /// </summary>
        /// <param name="credentials">Aliyun Service Credentials</param>
        /// <param name="regionEndpoint">The region endpoint to connect.</param>
        public MNSClient(ServiceCredentials credentials, String regionEndpoint)
            : this(credentials, new MNSConfig { RegionEndpoint = new Uri(regionEndpoint) })
        {
        }

        /// <summary>
        /// Constructs MNSClient with Aliyun Service Credentials and an
        /// MNSClient Configuration object.
        /// </summary>
        /// <param name="credentials">Aliyun Service Credentials</param>
        /// <param name="clientConfig">The MNSClient Configuration Object</param>
        public MNSClient(ServiceCredentials credentials, MNSConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs MNSClient with Aliyun Access Key ID and Aliyun Secret Key
        /// </summary>
        /// <param name="accessKeyId">Aliyun Access Key ID</param>
        /// <param name="secretAccessKey">Aliyun Secret Access Key</param>
        /// <param name="regionEndpoint">The region endpoint to connect. 
        /// http://$AccountID.mns.<region>.aliyuncs.com</param>
        public MNSClient(string accessKeyId, string secretAccessKey, string regionEndpoint)
			: this(accessKeyId, secretAccessKey, new MNSConfig { RegionEndpoint = new Uri(regionEndpoint) }, null)
        {
        }

		public MNSClient(string accessKeyId, string secretAccessKey, string regionEndpoint, string stsToken)
			: this(accessKeyId, secretAccessKey, new MNSConfig { RegionEndpoint = new Uri(regionEndpoint) }, stsToken)
		{
		}

        /// <summary>
        /// Constructs MNSClient with Aliyun Access Key ID, Secret Access Key and an
        /// MNSClient Configuration object. 
        /// </summary>
        /// <param name="accessKeyId">Aliyun Access Key ID</param>
        /// <param name="secretAccessKey">Aliyun Secret Access Key</param>
        /// <param name="clientConfig">The MNSClient Configuration Object</param>
        public MNSClient(string accessKeyId, string secretAccessKey, MNSConfig clientConfig, string stsToken)
			: base(accessKeyId, secretAccessKey, clientConfig, stsToken)
        {
        }

        #endregion

        #region Overrides

        protected override IServiceSigner CreateSigner()
        {
            return new MNSSigner();
        }

        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Marshaller>(new ResponseValidationHandler());
        }

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region GetNativeQueue

        /// <inheritdoc/>
        public Queue GetNativeQueue(string queueName)
        {
            return new Queue(queueName, this);
        }

        #endregion

    }
}
