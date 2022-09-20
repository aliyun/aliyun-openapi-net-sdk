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
    public class SubscribeRequest : RpcAcsRequest<SubscribeResponse>
    {
        public SubscribeRequest()
            : base("Mns-open", "2022-01-19", "Subscribe", "mns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Mns_open.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Mns_open.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string topicName;

		private string messageTag;

		private string endpoint;

		private string subscriptionName;

		private string notifyStrategy;

		private string notifyContentFormat;

		private string pushType;

		public string TopicName
		{
			get
			{
				return topicName;
			}
			set	
			{
				topicName = value;
				DictionaryUtil.Add(QueryParameters, "TopicName", value);
			}
		}

		public string MessageTag
		{
			get
			{
				return messageTag;
			}
			set	
			{
				messageTag = value;
				DictionaryUtil.Add(QueryParameters, "MessageTag", value);
			}
		}

		public string Endpoint
		{
			get
			{
				return endpoint;
			}
			set	
			{
				endpoint = value;
				DictionaryUtil.Add(QueryParameters, "Endpoint", value);
			}
		}

		public string SubscriptionName
		{
			get
			{
				return subscriptionName;
			}
			set	
			{
				subscriptionName = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionName", value);
			}
		}

		public string NotifyStrategy
		{
			get
			{
				return notifyStrategy;
			}
			set	
			{
				notifyStrategy = value;
				DictionaryUtil.Add(QueryParameters, "NotifyStrategy", value);
			}
		}

		public string NotifyContentFormat
		{
			get
			{
				return notifyContentFormat;
			}
			set	
			{
				notifyContentFormat = value;
				DictionaryUtil.Add(QueryParameters, "NotifyContentFormat", value);
			}
		}

		public string PushType
		{
			get
			{
				return pushType;
			}
			set	
			{
				pushType = value;
				DictionaryUtil.Add(QueryParameters, "PushType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubscribeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubscribeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
