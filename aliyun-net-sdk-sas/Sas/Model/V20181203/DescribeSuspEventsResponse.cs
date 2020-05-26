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
	public class DescribeSuspEventsResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private int? pageSize;

		private int? totalCount;

		private int? currentPage;

		private List<DescribeSuspEvents_WarningSummary> suspEvents;

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

		public List<DescribeSuspEvents_WarningSummary> SuspEvents
		{
			get
			{
				return suspEvents;
			}
			set	
			{
				suspEvents = value;
			}
		}

		public class DescribeSuspEvents_WarningSummary
		{

			private string lastTime;

			private string occurrenceTime;

			private long? id;

			private string uniqueInfo;

			private string instanceName;

			private string internetIp;

			private string intranetIp;

			private string uuid;

			private string name;

			private string eventSubType;

			private string level;

			private int? eventStatus;

			private string desc;

			private string operateMsg;

			private string dataSource;

			private bool? canBeDealOnLine;

			private string saleVersion;

			private string alarmEventType;

			private string alarmEventName;

			private string alarmUniqueInfo;

			private bool? advanced;

			public string LastTime
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

			public string OccurrenceTime
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

			public string UniqueInfo
			{
				get
				{
					return uniqueInfo;
				}
				set	
				{
					uniqueInfo = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string EventSubType
			{
				get
				{
					return eventSubType;
				}
				set	
				{
					eventSubType = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public int? EventStatus
			{
				get
				{
					return eventStatus;
				}
				set	
				{
					eventStatus = value;
				}
			}

			public string Desc
			{
				get
				{
					return desc;
				}
				set	
				{
					desc = value;
				}
			}

			public string OperateMsg
			{
				get
				{
					return operateMsg;
				}
				set	
				{
					operateMsg = value;
				}
			}

			public string DataSource
			{
				get
				{
					return dataSource;
				}
				set	
				{
					dataSource = value;
				}
			}

			public bool? CanBeDealOnLine
			{
				get
				{
					return canBeDealOnLine;
				}
				set	
				{
					canBeDealOnLine = value;
				}
			}

			public string SaleVersion
			{
				get
				{
					return saleVersion;
				}
				set	
				{
					saleVersion = value;
				}
			}

			public string AlarmEventType
			{
				get
				{
					return alarmEventType;
				}
				set	
				{
					alarmEventType = value;
				}
			}

			public string AlarmEventName
			{
				get
				{
					return alarmEventName;
				}
				set	
				{
					alarmEventName = value;
				}
			}

			public string AlarmUniqueInfo
			{
				get
				{
					return alarmUniqueInfo;
				}
				set	
				{
					alarmUniqueInfo = value;
				}
			}

			public bool? Advanced
			{
				get
				{
					return advanced;
				}
				set	
				{
					advanced = value;
				}
			}
		}
	}
}
