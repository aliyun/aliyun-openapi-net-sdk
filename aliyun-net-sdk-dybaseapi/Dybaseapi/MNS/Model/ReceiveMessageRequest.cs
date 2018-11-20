/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

namespace Aliyun.Acs.Dybaseapi.MNS.Model
{
    /// <summary>
    /// Container for request parameters that needed by MNS ReceiveMessage service.
    /// </summary>
    public partial class ReceiveMessageRequest : SimpleMNSRequest
    {
        private uint? _waitSeconds;

        /// <summary>
        /// Empty constructor
        /// </summary>
        public ReceiveMessageRequest() { }

        /// <summary>
        /// Instantiates ReceiveMessageRequest with the parameterized properties,
        /// </summary>
        public ReceiveMessageRequest(uint waitSeconds)
        {
            _waitSeconds = waitSeconds;
        }

        /// <summary>
        /// Gets and sets the property WaitSeconds. 
        /// </summary>
        public uint WaitSeconds
        {
            get { return this._waitSeconds.GetValueOrDefault(); }
            set { this._waitSeconds = value; }
        }

        // Check to see if WaitSeconds property is set
        internal bool IsSetWaitSeconds()
        {
            return this._waitSeconds.HasValue; 
        }

    }
}
