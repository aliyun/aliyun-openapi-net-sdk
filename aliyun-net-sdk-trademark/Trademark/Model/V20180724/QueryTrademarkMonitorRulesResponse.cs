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

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class QueryTrademarkMonitorRulesResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? pageSize;

		private int? totalPageNum;

		private bool? prePage;

		private bool? nextPage;

		private List<QueryTrademarkMonitorRules_TmMonitorRule> data;

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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
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

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		public bool? PrePage
		{
			get
			{
				return prePage;
			}
			set	
			{
				prePage = value;
			}
		}

		public bool? NextPage
		{
			get
			{
				return nextPage;
			}
			set	
			{
				nextPage = value;
			}
		}

		public List<QueryTrademarkMonitorRules_TmMonitorRule> Data
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

		public class QueryTrademarkMonitorRules_TmMonitorRule
		{

			private string id;

			private string userId;

			private string ruleStatus;

			private string ruleSource;

			private string ruleName;

			private int? ruleType;

			private string ruleKeyword;

			private string ruleDetail;

			private int? notifyUpdate;

			private int? version;

			private string startTime;

			private string endTime;

			private string lastRunTime;

			private string lastFinishTime;

			private string lastUpdateTime;

			private string env;

			private string ruleExtend;

			private string createTime;

			private string updateTime;

			public string Id
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

			public string RuleStatus
			{
				get
				{
					return ruleStatus;
				}
				set	
				{
					ruleStatus = value;
				}
			}

			public string RuleSource
			{
				get
				{
					return ruleSource;
				}
				set	
				{
					ruleSource = value;
				}
			}

			public string RuleName
			{
				get
				{
					return ruleName;
				}
				set	
				{
					ruleName = value;
				}
			}

			public int? RuleType
			{
				get
				{
					return ruleType;
				}
				set	
				{
					ruleType = value;
				}
			}

			public string RuleKeyword
			{
				get
				{
					return ruleKeyword;
				}
				set	
				{
					ruleKeyword = value;
				}
			}

			public string RuleDetail
			{
				get
				{
					return ruleDetail;
				}
				set	
				{
					ruleDetail = value;
				}
			}

			public int? NotifyUpdate
			{
				get
				{
					return notifyUpdate;
				}
				set	
				{
					notifyUpdate = value;
				}
			}

			public int? Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string LastRunTime
			{
				get
				{
					return lastRunTime;
				}
				set	
				{
					lastRunTime = value;
				}
			}

			public string LastFinishTime
			{
				get
				{
					return lastFinishTime;
				}
				set	
				{
					lastFinishTime = value;
				}
			}

			public string LastUpdateTime
			{
				get
				{
					return lastUpdateTime;
				}
				set	
				{
					lastUpdateTime = value;
				}
			}

			public string Env
			{
				get
				{
					return env;
				}
				set	
				{
					env = value;
				}
			}

			public string RuleExtend
			{
				get
				{
					return ruleExtend;
				}
				set	
				{
					ruleExtend = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}
		}
	}
}
