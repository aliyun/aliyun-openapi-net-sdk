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
	public class SearchAlertHistoriesResponse : AcsResponse
	{

		private string requestId;

		private SearchAlertHistories_PageBean pageBean;

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

		public SearchAlertHistories_PageBean PageBean
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

		public class SearchAlertHistories_PageBean
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<SearchAlertHistories_AlarmHistory> alarmHistories;

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

			public List<SearchAlertHistories_AlarmHistory> AlarmHistories
			{
				get
				{
					return alarmHistories;
				}
				set	
				{
					alarmHistories = value;
				}
			}

			public class SearchAlertHistories_AlarmHistory
			{

				private long? id;

				private string strategyId;

				private string userId;

				private string target;

				private string phones;

				private string emails;

				private long? alarmTime;

				private int? alarmType;

				private int? alarmResponseCode;

				private string alarmContent;

				private string alarmSources;

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

				public string StrategyId
				{
					get
					{
						return strategyId;
					}
					set	
					{
						strategyId = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string Target
				{
					get
					{
						return target;
					}
					set	
					{
						target = value;
					}
				}

				public string Phones
				{
					get
					{
						return phones;
					}
					set	
					{
						phones = value;
					}
				}

				public string Emails
				{
					get
					{
						return emails;
					}
					set	
					{
						emails = value;
					}
				}

				public long? AlarmTime
				{
					get
					{
						return alarmTime;
					}
					set	
					{
						alarmTime = value;
					}
				}

				public int? AlarmType
				{
					get
					{
						return alarmType;
					}
					set	
					{
						alarmType = value;
					}
				}

				public int? AlarmResponseCode
				{
					get
					{
						return alarmResponseCode;
					}
					set	
					{
						alarmResponseCode = value;
					}
				}

				public string AlarmContent
				{
					get
					{
						return alarmContent;
					}
					set	
					{
						alarmContent = value;
					}
				}

				public string AlarmSources
				{
					get
					{
						return alarmSources;
					}
					set	
					{
						alarmSources = value;
					}
				}
			}
		}
	}
}
