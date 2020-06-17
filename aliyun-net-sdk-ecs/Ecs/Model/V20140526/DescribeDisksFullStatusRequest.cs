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
    public class DescribeDisksFullStatusRequest : RpcAcsRequest<DescribeDisksFullStatusResponse>
    {
        public DescribeDisksFullStatusRequest()
            : base("Ecs", "2014-05-26", "DescribeDisksFullStatus", "ecs", "openAPI")
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

		private string eventTimeStart;

		private int? pageSize;

		private List<string> diskIds = new List<string>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string eventTimeEnd;

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

		public string EventTimeStart
		{
			get
			{
				return eventTimeStart;
			}
			set	
			{
				eventTimeStart = value;
				DictionaryUtil.Add(QueryParameters, "EventTime.Start", value);
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

		public List<string> DiskIds
		{
			get
			{
				return diskIds;
			}

			set
			{
				diskIds = value;
				for (int i = 0; i < diskIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DiskId." + (i + 1) , diskIds[i]);
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

		public string EventTimeEnd
		{
			get
			{
				return eventTimeEnd;
			}
			set	
			{
				eventTimeEnd = value;
				DictionaryUtil.Add(QueryParameters, "EventTime.End", value);
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

        public override DescribeDisksFullStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDisksFullStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
