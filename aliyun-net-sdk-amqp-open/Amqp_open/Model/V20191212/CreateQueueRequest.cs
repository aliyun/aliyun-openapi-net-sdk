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
using Aliyun.Acs.amqp_open.Transform;
using Aliyun.Acs.amqp_open.Transform.V20191212;

namespace Aliyun.Acs.amqp_open.Model.V20191212
{
    public class CreateQueueRequest : RpcAcsRequest<CreateQueueResponse>
    {
        public CreateQueueRequest()
            : base("amqp-open", "2019-12-12", "CreateQueue", "onsproxy", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string queueName;

		private string deadLetterRoutingKey;

		private long? maxLength;

		private long? autoExpireState;

		private string deadLetterExchange;

		private string instanceId;

		private bool? exclusiveState;

		private bool? autoDeleteState;

		private long? messageTTL;

		private string virtualHost;

		private int? maximumPriority;

		public string QueueName
		{
			get
			{
				return queueName;
			}
			set	
			{
				queueName = value;
				DictionaryUtil.Add(BodyParameters, "QueueName", value);
			}
		}

		public string DeadLetterRoutingKey
		{
			get
			{
				return deadLetterRoutingKey;
			}
			set	
			{
				deadLetterRoutingKey = value;
				DictionaryUtil.Add(BodyParameters, "DeadLetterRoutingKey", value);
			}
		}

		public long? MaxLength
		{
			get
			{
				return maxLength;
			}
			set	
			{
				maxLength = value;
				DictionaryUtil.Add(BodyParameters, "MaxLength", value.ToString());
			}
		}

		public long? AutoExpireState
		{
			get
			{
				return autoExpireState;
			}
			set	
			{
				autoExpireState = value;
				DictionaryUtil.Add(BodyParameters, "AutoExpireState", value.ToString());
			}
		}

		public string DeadLetterExchange
		{
			get
			{
				return deadLetterExchange;
			}
			set	
			{
				deadLetterExchange = value;
				DictionaryUtil.Add(BodyParameters, "DeadLetterExchange", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
			}
		}

		public bool? ExclusiveState
		{
			get
			{
				return exclusiveState;
			}
			set	
			{
				exclusiveState = value;
				DictionaryUtil.Add(BodyParameters, "ExclusiveState", value.ToString());
			}
		}

		public bool? AutoDeleteState
		{
			get
			{
				return autoDeleteState;
			}
			set	
			{
				autoDeleteState = value;
				DictionaryUtil.Add(BodyParameters, "AutoDeleteState", value.ToString());
			}
		}

		public long? MessageTTL
		{
			get
			{
				return messageTTL;
			}
			set	
			{
				messageTTL = value;
				DictionaryUtil.Add(BodyParameters, "MessageTTL", value.ToString());
			}
		}

		public string VirtualHost
		{
			get
			{
				return virtualHost;
			}
			set	
			{
				virtualHost = value;
				DictionaryUtil.Add(BodyParameters, "VirtualHost", value);
			}
		}

		public int? MaximumPriority
		{
			get
			{
				return maximumPriority;
			}
			set	
			{
				maximumPriority = value;
				DictionaryUtil.Add(BodyParameters, "MaximumPriority", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateQueueResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateQueueResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
