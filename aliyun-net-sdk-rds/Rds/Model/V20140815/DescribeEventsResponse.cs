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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeEventsResponse : AcsResponse
	{

		private int? pageNumber;

		private string requestId;

		private int? pageSize;

		private int? totalRecordCount;

		private List<DescribeEvents_EventItemsItem> eventItems;

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
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
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
			}
		}

		[JsonProperty(PropertyName = "TotalRecordCount")]
		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		[JsonProperty(PropertyName = "EventItems")]
		public List<DescribeEvents_EventItemsItem> EventItems
		{
			get
			{
				return eventItems;
			}
			set	
			{
				eventItems = value;
			}
		}

		public class DescribeEvents_EventItemsItem
		{

			private string eventName;

			private string eventTime;

			private string eventUserType;

			private string eventRecordTime;

			private long? callerUid;

			private string regionId;

			private int? eventId;

			private string eventType;

			private string resourceType;

			private string eventPayload;

			private string eventReason;

			private string resourceName;

			[JsonProperty(PropertyName = "EventName")]
			public string EventName
			{
				get
				{
					return eventName;
				}
				set	
				{
					eventName = value;
				}
			}

			[JsonProperty(PropertyName = "EventTime")]
			public string EventTime
			{
				get
				{
					return eventTime;
				}
				set	
				{
					eventTime = value;
				}
			}

			[JsonProperty(PropertyName = "EventUserType")]
			public string EventUserType
			{
				get
				{
					return eventUserType;
				}
				set	
				{
					eventUserType = value;
				}
			}

			[JsonProperty(PropertyName = "EventRecordTime")]
			public string EventRecordTime
			{
				get
				{
					return eventRecordTime;
				}
				set	
				{
					eventRecordTime = value;
				}
			}

			[JsonProperty(PropertyName = "CallerUid")]
			public long? CallerUid
			{
				get
				{
					return callerUid;
				}
				set	
				{
					callerUid = value;
				}
			}

			[JsonProperty(PropertyName = "RegionId")]
			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			[JsonProperty(PropertyName = "EventId")]
			public int? EventId
			{
				get
				{
					return eventId;
				}
				set	
				{
					eventId = value;
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
				}
			}

			[JsonProperty(PropertyName = "EventPayload")]
			public string EventPayload
			{
				get
				{
					return eventPayload;
				}
				set	
				{
					eventPayload = value;
				}
			}

			[JsonProperty(PropertyName = "EventReason")]
			public string EventReason
			{
				get
				{
					return eventReason;
				}
				set	
				{
					eventReason = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceName")]
			public string ResourceName
			{
				get
				{
					return resourceName;
				}
				set	
				{
					resourceName = value;
				}
			}
		}
	}
}
