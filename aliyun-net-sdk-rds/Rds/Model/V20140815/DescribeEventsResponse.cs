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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeEventsResponse : AcsResponse
	{

		private string requestId;

		private int? totalRecordCount;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeEvents_EventItemsItem> eventItems;

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

			private int? eventId;

			private string eventType;

			private string eventName;

			private string eventTime;

			private string resourceType;

			private string resourceName;

			private string regionId;

			private string eventUserType;

			private string eventReason;

			private string eventPayload;

			private string eventRecordTime;

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
		}
	}
}
