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
	public class DescribeJoinRuleListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeJoinRuleList_JoinRuleListItem> joinRuleList;

		private DescribeJoinRuleList_PageInfo pageInfo;

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

		public List<DescribeJoinRuleList_JoinRuleListItem> JoinRuleList
		{
			get
			{
				return joinRuleList;
			}
			set	
			{
				joinRuleList = value;
			}
		}

		public DescribeJoinRuleList_PageInfo PageInfo
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

		public class DescribeJoinRuleList_JoinRuleListItem
		{

			private int? timeWindow;

			private string warnLevel;

			private int? dataSourceId1;

			private string description;

			private string ruleName;

			private string joinRelation;

			private int? dataSourceId2;

			private string expression2;

			private int? ruleId;

			private string expression1;

			private string actions;

			private string statisticsRules;

			private bool? needGroup;

			private string statusCode;

			public int? TimeWindow
			{
				get
				{
					return timeWindow;
				}
				set	
				{
					timeWindow = value;
				}
			}

			public string WarnLevel
			{
				get
				{
					return warnLevel;
				}
				set	
				{
					warnLevel = value;
				}
			}

			public int? DataSourceId1
			{
				get
				{
					return dataSourceId1;
				}
				set	
				{
					dataSourceId1 = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			public string JoinRelation
			{
				get
				{
					return joinRelation;
				}
				set	
				{
					joinRelation = value;
				}
			}

			public int? DataSourceId2
			{
				get
				{
					return dataSourceId2;
				}
				set	
				{
					dataSourceId2 = value;
				}
			}

			public string Expression2
			{
				get
				{
					return expression2;
				}
				set	
				{
					expression2 = value;
				}
			}

			public int? RuleId
			{
				get
				{
					return ruleId;
				}
				set	
				{
					ruleId = value;
				}
			}

			public string Expression1
			{
				get
				{
					return expression1;
				}
				set	
				{
					expression1 = value;
				}
			}

			public string Actions
			{
				get
				{
					return actions;
				}
				set	
				{
					actions = value;
				}
			}

			public string StatisticsRules
			{
				get
				{
					return statisticsRules;
				}
				set	
				{
					statisticsRules = value;
				}
			}

			public bool? NeedGroup
			{
				get
				{
					return needGroup;
				}
				set	
				{
					needGroup = value;
				}
			}

			public string StatusCode
			{
				get
				{
					return statusCode;
				}
				set	
				{
					statusCode = value;
				}
			}
		}

		public class DescribeJoinRuleList_PageInfo
		{

			private int? count;

			private int? pageSize;

			private int? currentPage;

			private int? totalCount;

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
		}
	}
}
