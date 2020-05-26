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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeSimilarSecurityEventsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSimilarSecurityEvents_SimpleSecurityEvent> securityEventsResponse;

		private DescribeSimilarSecurityEvents_PageInfo pageInfo;

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

		public List<DescribeSimilarSecurityEvents_SimpleSecurityEvent> SecurityEventsResponse
		{
			get
			{
				return securityEventsResponse;
			}
			set	
			{
				securityEventsResponse = value;
			}
		}

		public DescribeSimilarSecurityEvents_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeSimilarSecurityEvents_SimpleSecurityEvent
		{

			private long? securityEventId;

			private string uuid;

			private string eventType;

			private string eventName;

			private long? occurrenceTime;

			private long? lastTime;

			public long? SecurityEventId
			{
				get
				{
					return securityEventId;
				}
				set	
				{
					securityEventId = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
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

			public long? OccurrenceTime
			{
				get
				{
					return occurrenceTime;
				}
				set	
				{
					occurrenceTime = value;
				}
			}

			public long? LastTime
			{
				get
				{
					return lastTime;
				}
				set	
				{
					lastTime = value;
				}
			}
		}

		public class DescribeSimilarSecurityEvents_PageInfo
		{

			private int? count;

			private int? pageSize;

			private int? totalCount;

			private int? currentPage;

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
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

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}
		}
	}
}
