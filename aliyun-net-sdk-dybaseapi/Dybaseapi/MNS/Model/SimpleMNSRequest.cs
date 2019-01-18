/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

namespace Aliyun.Acs.Dybaseapi.MNS.Model
{
    /// <summary>
    /// A simple wrapper of MNSRequest to message releated requests.
    /// </summary>
    public partial class SimpleMNSRequest : MNSRequest
    {
        private string _queueName;
        private string _topicName;

        /// <summary>
        /// Empty constructor
        /// </summary>
        public SimpleMNSRequest() { }

        /// <summary>
        /// Gets and sets the property queueName. 
        /// </summary>
        internal string QueueName
        {
            get { return this._queueName; }
            set { this._queueName = value; }
        }

        // Check to see if queueName property is set
        internal bool IsSetQueueName()
        {
            return this._queueName != null;
        }

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// </summary>
        internal string TopicName
        {
            get { return this._topicName; }
            set { this._topicName = value; }
        }

        // Check to see if TopicName property is set
        internal bool IsSetTopicName()
        {
            return this._topicName != null;
        }
    }
}
