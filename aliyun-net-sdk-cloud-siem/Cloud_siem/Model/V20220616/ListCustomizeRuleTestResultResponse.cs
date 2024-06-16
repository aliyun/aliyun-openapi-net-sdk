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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class ListCustomizeRuleTestResultResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private ListCustomizeRuleTestResult_Data data;

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

		public ListCustomizeRuleTestResult_Data Data
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

		public class ListCustomizeRuleTestResult_Data
		{

			private List<ListCustomizeRuleTestResult_ResponseDataItem> responseData;

			private ListCustomizeRuleTestResult_PageInfo pageInfo;

			public List<ListCustomizeRuleTestResult_ResponseDataItem> ResponseData
			{
				get
				{
					return responseData;
				}
				set	
				{
					responseData = value;
				}
			}

			public ListCustomizeRuleTestResult_PageInfo PageInfo
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

			public class ListCustomizeRuleTestResult_ResponseDataItem
			{

				private string uuid;

				private string mainUserId;

				private string subUserId;

				private string logType;

				private string logSource;

				private string alertSrcProd;

				private string alertSrcProdModule;

				private string attCk;

				private string alertDesc;

				private string onlineStatus;

				private string eventName;

				private string level;

				private string eventType;

				private string alertDetail;

				private string logTime;

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

				public string MainUserId
				{
					get
					{
						return mainUserId;
					}
					set	
					{
						mainUserId = value;
					}
				}

				public string SubUserId
				{
					get
					{
						return subUserId;
					}
					set	
					{
						subUserId = value;
					}
				}

				public string LogType
				{
					get
					{
						return logType;
					}
					set	
					{
						logType = value;
					}
				}

				public string LogSource
				{
					get
					{
						return logSource;
					}
					set	
					{
						logSource = value;
					}
				}

				public string AlertSrcProd
				{
					get
					{
						return alertSrcProd;
					}
					set	
					{
						alertSrcProd = value;
					}
				}

				public string AlertSrcProdModule
				{
					get
					{
						return alertSrcProdModule;
					}
					set	
					{
						alertSrcProdModule = value;
					}
				}

				public string AttCk
				{
					get
					{
						return attCk;
					}
					set	
					{
						attCk = value;
					}
				}

				public string AlertDesc
				{
					get
					{
						return alertDesc;
					}
					set	
					{
						alertDesc = value;
					}
				}

				public string OnlineStatus
				{
					get
					{
						return onlineStatus;
					}
					set	
					{
						onlineStatus = value;
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

				public string AlertDetail
				{
					get
					{
						return alertDetail;
					}
					set	
					{
						alertDetail = value;
					}
				}

				public string LogTime
				{
					get
					{
						return logTime;
					}
					set	
					{
						logTime = value;
					}
				}
			}

			public class ListCustomizeRuleTestResult_PageInfo
			{

				private int? currentPage;

				private int? pageSize;

				private long? totalCount;

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

				public long? TotalCount
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
			}
		}
	}
}
