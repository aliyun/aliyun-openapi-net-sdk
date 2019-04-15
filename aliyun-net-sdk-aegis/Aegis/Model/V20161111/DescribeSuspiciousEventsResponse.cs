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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeSuspiciousEventsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private int? currentPage;

		private List<DescribeSuspiciousEvents_LogListItem> logList;

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

		public List<DescribeSuspiciousEvents_LogListItem> LogList
		{
			get
			{
				return logList;
			}
			set	
			{
				logList = value;
			}
		}

		public class DescribeSuspiciousEvents_LogListItem
		{

			private string aliasEventType;

			private long? lastTime;

			private string level;

			private string instanceName;

			private long? groupId;

			private string ip;

			private string eventType;

			private string uuid;

			private long? firstTime;

			private string instanceId;

			private string tag;

			private string aliasEventName;

			private string osVersion;

			private string clientIp;

			private string eventName;

			private List<DescribeSuspiciousEvents_DetailListItem> detailList;

			public string AliasEventType
			{
				get
				{
					return aliasEventType;
				}
				set	
				{
					aliasEventType = value;
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

			public long? GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
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

			public long? FirstTime
			{
				get
				{
					return firstTime;
				}
				set	
				{
					firstTime = value;
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
				}
			}

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public string AliasEventName
			{
				get
				{
					return aliasEventName;
				}
				set	
				{
					aliasEventName = value;
				}
			}

			public string OsVersion
			{
				get
				{
					return osVersion;
				}
				set	
				{
					osVersion = value;
				}
			}

			public string ClientIp
			{
				get
				{
					return clientIp;
				}
				set	
				{
					clientIp = value;
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

			public List<DescribeSuspiciousEvents_DetailListItem> DetailList
			{
				get
				{
					return detailList;
				}
				set	
				{
					detailList = value;
				}
			}

			public class DescribeSuspiciousEvents_DetailListItem
			{

				private string name;

				private string type;

				private string _value;

				private string infoType;

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

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public string InfoType
				{
					get
					{
						return infoType;
					}
					set	
					{
						infoType = value;
					}
				}
			}
		}
	}
}
