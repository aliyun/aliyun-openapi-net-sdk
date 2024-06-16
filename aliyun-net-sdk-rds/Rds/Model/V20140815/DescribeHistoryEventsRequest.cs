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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribeHistoryEventsRequest : RpcAcsRequest<DescribeHistoryEventsResponse>
    {
        public DescribeHistoryEventsRequest()
            : base("Rds", "2014-08-15", "DescribeHistoryEvents", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string eventId;

		private string toStartTime;

		private int? pageNumber;

		private string resourceGroupId;

		private string securityToken;

		private int? pageSize;

		private string taskId;

		private string fromStartTime;

		private string resourceType;

		private string archiveStatus;

		private string instanceId;

		private string eventLevel;

		private string eventCategory;

		private string eventType;

		private string eventStatus;

		[JsonProperty(PropertyName = "EventId")]
		public string EventId
		{
			get
			{
				return eventId;
			}
			set	
			{
				eventId = value;
				DictionaryUtil.Add(QueryParameters, "EventId", value);
			}
		}

		[JsonProperty(PropertyName = "ToStartTime")]
		public string ToStartTime
		{
			get
			{
				return toStartTime;
			}
			set	
			{
				toStartTime = value;
				DictionaryUtil.Add(QueryParameters, "ToStartTime", value);
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "ResourceGroupId")]
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

		[JsonProperty(PropertyName = "SecurityToken")]
		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "TaskId")]
		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
			}
		}

		[JsonProperty(PropertyName = "FromStartTime")]
		public string FromStartTime
		{
			get
			{
				return fromStartTime;
			}
			set	
			{
				fromStartTime = value;
				DictionaryUtil.Add(QueryParameters, "FromStartTime", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceType")]
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

		[JsonProperty(PropertyName = "ArchiveStatus")]
		public string ArchiveStatus
		{
			get
			{
				return archiveStatus;
			}
			set	
			{
				archiveStatus = value;
				DictionaryUtil.Add(QueryParameters, "ArchiveStatus", value);
			}
		}

		[JsonProperty(PropertyName = "InstanceId")]
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

		[JsonProperty(PropertyName = "EventLevel")]
		public string EventLevel
		{
			get
			{
				return eventLevel;
			}
			set	
			{
				eventLevel = value;
				DictionaryUtil.Add(QueryParameters, "EventLevel", value);
			}
		}

		[JsonProperty(PropertyName = "EventCategory")]
		public string EventCategory
		{
			get
			{
				return eventCategory;
			}
			set	
			{
				eventCategory = value;
				DictionaryUtil.Add(QueryParameters, "EventCategory", value);
			}
		}

		[JsonProperty(PropertyName = "EventType")]
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

		[JsonProperty(PropertyName = "EventStatus")]
		public string EventStatus
		{
			get
			{
				return eventStatus;
			}
			set	
			{
				eventStatus = value;
				DictionaryUtil.Add(QueryParameters, "EventStatus", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeHistoryEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeHistoryEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
