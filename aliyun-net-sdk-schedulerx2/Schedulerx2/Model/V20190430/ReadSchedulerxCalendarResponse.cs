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

namespace Aliyun.Acs.schedulerx2.Model.V20190430
{
	public class ReadSchedulerxCalendarResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private int? code;

		private bool? success;

		private ReadSchedulerxCalendar_AccessDeniedDetail accessDeniedDetail;

		private ReadSchedulerxCalendar_Data data;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public ReadSchedulerxCalendar_AccessDeniedDetail AccessDeniedDetail
		{
			get
			{
				return accessDeniedDetail;
			}
			set	
			{
				accessDeniedDetail = value;
			}
		}

		public ReadSchedulerxCalendar_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ReadSchedulerxCalendar_AccessDeniedDetail
		{

			private string policyType;

			private string authPrincipalOwnerId;

			private string encodedDiagnosticMessage;

			private string authPrincipalType;

			private string authPrincipalDisplayName;

			private string noPermissionType;

			private string authAction;

			public string PolicyType
			{
				get
				{
					return policyType;
				}
				set	
				{
					policyType = value;
				}
			}

			public string AuthPrincipalOwnerId
			{
				get
				{
					return authPrincipalOwnerId;
				}
				set	
				{
					authPrincipalOwnerId = value;
				}
			}

			public string EncodedDiagnosticMessage
			{
				get
				{
					return encodedDiagnosticMessage;
				}
				set	
				{
					encodedDiagnosticMessage = value;
				}
			}

			public string AuthPrincipalType
			{
				get
				{
					return authPrincipalType;
				}
				set	
				{
					authPrincipalType = value;
				}
			}

			public string AuthPrincipalDisplayName
			{
				get
				{
					return authPrincipalDisplayName;
				}
				set	
				{
					authPrincipalDisplayName = value;
				}
			}

			public string NoPermissionType
			{
				get
				{
					return noPermissionType;
				}
				set	
				{
					noPermissionType = value;
				}
			}

			public string AuthAction
			{
				get
				{
					return authAction;
				}
				set	
				{
					authAction = value;
				}
			}
		}

		public class ReadSchedulerxCalendar_Data
		{

			private string nextToken;

			private long? total;

			private int? maxResults;

			private List<ReadSchedulerxCalendar_Record> records;

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
				}
			}

			public long? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public int? MaxResults
			{
				get
				{
					return maxResults;
				}
				set	
				{
					maxResults = value;
				}
			}

			public List<ReadSchedulerxCalendar_Record> Records
			{
				get
				{
					return records;
				}
				set	
				{
					records = value;
				}
			}

			public class ReadSchedulerxCalendar_Record
			{

				private int? year;

				private bool? systemCalendar;

				private string calendarName;

				private string creator;

				private string monthDaysContent;

				public int? Year
				{
					get
					{
						return year;
					}
					set	
					{
						year = value;
					}
				}

				public bool? SystemCalendar
				{
					get
					{
						return systemCalendar;
					}
					set	
					{
						systemCalendar = value;
					}
				}

				public string CalendarName
				{
					get
					{
						return calendarName;
					}
					set	
					{
						calendarName = value;
					}
				}

				public string Creator
				{
					get
					{
						return creator;
					}
					set	
					{
						creator = value;
					}
				}

				public string MonthDaysContent
				{
					get
					{
						return monthDaysContent;
					}
					set	
					{
						monthDaysContent = value;
					}
				}
			}
		}
	}
}
