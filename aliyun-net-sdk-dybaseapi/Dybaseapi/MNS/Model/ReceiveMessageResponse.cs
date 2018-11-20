/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

using Aliyun.Acs.Dybaseapi.MNS.Runtime;

namespace Aliyun.Acs.Dybaseapi.MNS.Model
{
    /// <summary>
    /// Response for MNS ReceiveMessage service
    /// </summary>
    public partial class ReceiveMessageResponse : WebServiceResponse
    {
        private Message _message = new Message();

        /// <summary>
        /// Gets and sets the property Message. 
        /// </summary>
        public Message Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
    }
}
