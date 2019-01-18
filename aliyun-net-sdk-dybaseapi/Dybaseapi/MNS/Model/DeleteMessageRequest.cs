/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

namespace Aliyun.Acs.Dybaseapi.MNS.Model
{
    /// <summary>
    /// Container for request parameters that needed by MNS DeleteMessage service.
    /// </summary>
    public partial class DeleteMessageRequest : SimpleMNSRequest
    {
        private string _receiptHandle;

        /// <summary>
        /// Empty constructor
        /// </summary>
        public DeleteMessageRequest() { }

        /// <summary>
        /// Instantiates DeleteMessageRequest with the parameterized properties
        /// </summary>
        /// <param name="receiptHandle">The receipt handle associated with the message to delete.</param>
        public DeleteMessageRequest(string receiptHandle)
        {
            _receiptHandle = receiptHandle;
        }

        /// <summary>
        /// Gets and sets the property ReceiptHandle. 
        /// </summary>
        public string ReceiptHandle
        {
            get { return this._receiptHandle; }
            set { this._receiptHandle = value; }
        }

        // Check to see if ReceiptHandle property is set
        internal bool IsSetReceiptHandle()
        {
            return this._receiptHandle != null;
        }

    }
}