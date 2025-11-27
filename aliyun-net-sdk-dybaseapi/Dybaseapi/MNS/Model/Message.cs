/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

using Aliyun.Acs.Dybaseapi.MNS.Model.Internal.MarshallTransformations;
using Aliyun.Acs.Dybaseapi.MNS.Util;
using System;

namespace Aliyun.Acs.Dybaseapi.MNS.Model
{
    /// <summary>
    /// An Aliyun MNS message.
    /// </summary>
    public partial class Message
    {
        private string _id;
        private string _receiptHandle;
        private string _bodyMD5;
        private string _body;

        private DateTime _enqueueTime;
        private DateTime _nextVisibleTime;
        private DateTime _firstDequeueTime;
        
        private uint _dequeueCount;

        private uint _priority;

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Message() { }

        /// <summary>
        /// Gets and sets the property Id. 
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
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

        /// <summary>
        /// Gets and sets the property Body. 
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property BodyMD5. 
        /// </summary>
        public string BodyMD5
        {
            get { return this._bodyMD5; }
            set { this._bodyMD5 = value; }
        }

        // Check to see if BodyMD5 property is set
        internal bool IsSetBodyMD5()
        {
            return this._bodyMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property EnqueueTime. 
        /// </summary>
        public DateTime EnqueueTime
        {
            get { return this._enqueueTime; }
            set { this._enqueueTime = value; }
        }

        /// <summary>
        /// Gets and sets the property NextVisibleTime. 
        /// </summary>
        public DateTime NextVisibleTime
        {
            get { return this._nextVisibleTime; }
            set { this._nextVisibleTime = value; }
        }

        /// <summary>
        /// Gets and sets the property FirstDequeueTime. 
        /// </summary>
        public DateTime FirstDequeueTime
        {
            get { return this._firstDequeueTime; }
            set { this._firstDequeueTime = value; }
        }

        /// <summary>
        /// Gets and sets the property DequeueCount. 
        /// </summary>
        public uint DequeueCount
        {
            get { return this._dequeueCount; }
            set { this._dequeueCount = value; }
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// </summary>
        public uint Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

    }
}
