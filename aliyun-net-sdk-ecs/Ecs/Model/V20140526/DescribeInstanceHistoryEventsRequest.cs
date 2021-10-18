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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeInstanceHistoryEventsRequest : RpcAcsRequest<DescribeInstanceHistoryEventsResponse>
    {
        public DescribeInstanceHistoryEventsRequest()
            : base("Ecs", "2014-05-26", "DescribeInstanceHistoryEvents", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> eventIds = new List<string>(){ };

		private long? resourceOwnerId;

		private string eventCycleStatus;

		private int? pageNumber;

		private string impactLevel;

		private string resourceGroupId;

		private int? pageSize;

		private List<string> instanceEventCycleStatuss = new List<string>(){ };

		private List<string> tags = new List<string>(){ };

		private string eventPublishTimeEnd;

		private List<string> resourceIds = new List<string>(){ };

		private List<string> instanceEventTypes = new List<string>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string notBeforeStart;

		private long? ownerId;

		private string resourceType;

		private string eventPublishTimeStart;

		private string instanceId;

		private string notBeforeEnd;

		private string eventType;

		public List<string> EventIds
		{
			get
			{
				return eventIds;
			}

			set
			{
				eventIds = value;
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string EventCycleStatus
		{
			get
			{
				return eventCycleStatus;
			}
			set	
			{
				eventCycleStatus = value;
				DictionaryUtil.Add(QueryParameters, "EventCycleStatus", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string ImpactLevel
		{
			get
			{
				return impactLevel;
			}
			set	
			{
				impactLevel = value;
				DictionaryUtil.Add(QueryParameters, "ImpactLevel", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public List<string> InstanceEventCycleStatuss
		{
			get
			{
				return instanceEventCycleStatuss;
			}

			set
			{
				instanceEventCycleStatuss = value;
			}
		}

		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
			}
		}

		public string EventPublishTimeEnd
		{
			get
			{
				return eventPublishTimeEnd;
			}
			set	
			{
				eventPublishTimeEnd = value;
				DictionaryUtil.Add(QueryParameters, "EventPublishTime.End", value);
			}
		}

		public List<string> ResourceIds
		{
			get
			{
				return resourceIds;
			}

			set
			{
				resourceIds = value;
			}
		}

		public List<string> InstanceEventTypes
		{
			get
			{
				return instanceEventTypes;
			}

			set
			{
				instanceEventTypes = value;
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string NotBeforeStart
		{
			get
			{
				return notBeforeStart;
			}
			set	
			{
				notBeforeStart = value;
				DictionaryUtil.Add(QueryParameters, "NotBefore.Start", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public string EventPublishTimeStart
		{
			get
			{
				return eventPublishTimeStart;
			}
			set	
			{
				eventPublishTimeStart = value;
				DictionaryUtil.Add(QueryParameters, "EventPublishTime.Start", value);
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
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string NotBeforeEnd
		{
			get
			{
				return notBeforeEnd;
			}
			set	
			{
				notBeforeEnd = value;
				DictionaryUtil.Add(QueryParameters, "NotBefore.End", value);
			}
		}

		public string EventType
		{
			get
			{
				return eventType;
			}
			set	
			{
				eventType = value;
				DictionaryUtil.Add(QueryParameters, "EventType", value);
			}
		}

		public class Tag
		{

			private string key;

			private string value_;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}

        public override DescribeInstanceHistoryEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeInstanceHistoryEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
