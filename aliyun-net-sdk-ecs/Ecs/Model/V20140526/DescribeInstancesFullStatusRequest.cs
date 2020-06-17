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
    public class DescribeInstancesFullStatusRequest : RpcAcsRequest<DescribeInstancesFullStatusResponse>
    {
        public DescribeInstancesFullStatusRequest()
            : base("Ecs", "2014-05-26", "DescribeInstancesFullStatus", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> eventIds = new List<string>(){ };

		private long? resourceOwnerId;

		private int? pageNumber;

		private int? pageSize;

		private string eventPublishTimeEnd;

		private List<string> instanceEventTypes = new List<string>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string notBeforeStart;

		private long? ownerId;

		private string eventPublishTimeStart;

		private List<string> instanceIds = new List<string>(){ };

		private string notBeforeEnd;

		private string healthStatus;

		private string eventType;

		private string status;

		public List<string> EventIds
		{
			get
			{
				return eventIds;
			}

			set
			{
				eventIds = value;
				for (int i = 0; i < eventIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"EventId." + (i + 1) , eventIds[i]);
				}
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

		public List<string> InstanceEventTypes
		{
			get
			{
				return instanceEventTypes;
			}

			set
			{
				instanceEventTypes = value;
				for (int i = 0; i < instanceEventTypes.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceEventType." + (i + 1) , instanceEventTypes[i]);
				}
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

		public List<string> InstanceIds
		{
			get
			{
				return instanceIds;
			}

			set
			{
				instanceIds = value;
				for (int i = 0; i < instanceIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceId." + (i + 1) , instanceIds[i]);
				}
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

		public string HealthStatus
		{
			get
			{
				return healthStatus;
			}
			set	
			{
				healthStatus = value;
				DictionaryUtil.Add(QueryParameters, "HealthStatus", value);
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

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

        public override DescribeInstancesFullStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeInstancesFullStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
