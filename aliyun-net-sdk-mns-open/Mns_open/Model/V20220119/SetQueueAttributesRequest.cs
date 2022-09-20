/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Mns_open.Transform;
using Aliyun.Acs.Mns_open.Transform.V20220119;

namespace Aliyun.Acs.Mns_open.Model.V20220119
{
    public class SetQueueAttributesRequest : RpcAcsRequest<SetQueueAttributesResponse>
    {
        public SetQueueAttributesRequest()
            : base("Mns-open", "2022-01-19", "SetQueueAttributes", "mns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Mns_open.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Mns_open.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string queueName;

		private long? messageRetentionPeriod;

		private bool? enableLogging;

		private long? visibilityTimeout;

		private long? delaySeconds;

		private long? maximumMessageSize;

		private long? pollingWaitSeconds;

		public string QueueName
		{
			get
			{
				return queueName;
			}
			set	
			{
				queueName = value;
				DictionaryUtil.Add(QueryParameters, "QueueName", value);
			}
		}

		public long? MessageRetentionPeriod
		{
			get
			{
				return messageRetentionPeriod;
			}
			set	
			{
				messageRetentionPeriod = value;
				DictionaryUtil.Add(QueryParameters, "MessageRetentionPeriod", value.ToString());
			}
		}

		public bool? EnableLogging
		{
			get
			{
				return enableLogging;
			}
			set	
			{
				enableLogging = value;
				DictionaryUtil.Add(QueryParameters, "EnableLogging", value.ToString());
			}
		}

		public long? VisibilityTimeout
		{
			get
			{
				return visibilityTimeout;
			}
			set	
			{
				visibilityTimeout = value;
				DictionaryUtil.Add(QueryParameters, "VisibilityTimeout", value.ToString());
			}
		}

		public long? DelaySeconds
		{
			get
			{
				return delaySeconds;
			}
			set	
			{
				delaySeconds = value;
				DictionaryUtil.Add(QueryParameters, "DelaySeconds", value.ToString());
			}
		}

		public long? MaximumMessageSize
		{
			get
			{
				return maximumMessageSize;
			}
			set	
			{
				maximumMessageSize = value;
				DictionaryUtil.Add(QueryParameters, "MaximumMessageSize", value.ToString());
			}
		}

		public long? PollingWaitSeconds
		{
			get
			{
				return pollingWaitSeconds;
			}
			set	
			{
				pollingWaitSeconds = value;
				DictionaryUtil.Add(QueryParameters, "PollingWaitSeconds", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetQueueAttributesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetQueueAttributesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
