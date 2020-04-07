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

namespace Aliyun.Acs.ARMS.Model.V20190808
{
	public class SearchEventsResponse : AcsResponse
	{

		private string requestId;

		private int? isTrigger;

		private SearchEvents_PageBean pageBean;

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

		public int? IsTrigger
		{
			get
			{
				return isTrigger;
			}
			set	
			{
				isTrigger = value;
			}
		}

		public SearchEvents_PageBean PageBean
		{
			get
			{
				return pageBean;
			}
			set	
			{
				pageBean = value;
			}
		}

		public class SearchEvents_PageBean
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<SearchEvents_EventItem> _event;

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

			public List<SearchEvents_EventItem> _Event
			{
				get
				{
					return _event;
				}
				set	
				{
					_event = value;
				}
			}

			public class SearchEvents_EventItem
			{

				private long? id;

				private long? eventTime;

				private int? alertType;

				private int? eventLevel;

				private string message;

				private long? alertId;

				private string alertName;

				private string alertRule;

				private List<string> links;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public long? EventTime
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

				public int? AlertType
				{
					get
					{
						return alertType;
					}
					set	
					{
						alertType = value;
					}
				}

				public int? EventLevel
				{
					get
					{
						return eventLevel;
					}
					set	
					{
						eventLevel = value;
					}
				}

				public string Message
				{
					get
					{
						return message;
					}
					set	
					{
						message = value;
					}
				}

				public long? AlertId
				{
					get
					{
						return alertId;
					}
					set	
					{
						alertId = value;
					}
				}

				public string AlertName
				{
					get
					{
						return alertName;
					}
					set	
					{
						alertName = value;
					}
				}

				public string AlertRule
				{
					get
					{
						return alertRule;
					}
					set	
					{
						alertRule = value;
					}
				}

				public List<string> Links
				{
					get
					{
						return links;
					}
					set	
					{
						links = value;
					}
				}
			}
		}
	}
}
