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
	public class DescribeRuleListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeRuleList_RulesItem> rules;

		private DescribeRuleList_PageInfo pageInfo;

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

		public List<DescribeRuleList_RulesItem> Rules
		{
			get
			{
				return rules;
			}
			set	
			{
				rules = value;
			}
		}

		public DescribeRuleList_PageInfo PageInfo
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

		public class DescribeRuleList_RulesItem
		{

			private string warnLevel;

			private long? modified;

			private long? create;

			private string ruleName;

			private string description;

			private int? id;

			private int? dataSourceId;

			private string expressions;

			private string actions;

			private string statisticsRules;

			private bool? needGroup;

			private string statusCode;

			private List<DescribeRuleList_RuleGroup> ruleGroups;

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

			public long? Modified
			{
				get
				{
					return modified;
				}
				set	
				{
					modified = value;
				}
			}

			public long? Create
			{
				get
				{
					return create;
				}
				set	
				{
					create = value;
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

			public int? Id
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

			public int? DataSourceId
			{
				get
				{
					return dataSourceId;
				}
				set	
				{
					dataSourceId = value;
				}
			}

			public string Expressions
			{
				get
				{
					return expressions;
				}
				set	
				{
					expressions = value;
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

			public List<DescribeRuleList_RuleGroup> RuleGroups
			{
				get
				{
					return ruleGroups;
				}
				set	
				{
					ruleGroups = value;
				}
			}

			public class DescribeRuleList_RuleGroup
			{

				private string groupName;

				private int? ruleNum;

				private long? modified;

				private long? create;

				private string description;

				private int? id;

				private int? aliUid;

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
					}
				}

				public int? RuleNum
				{
					get
					{
						return ruleNum;
					}
					set	
					{
						ruleNum = value;
					}
				}

				public long? Modified
				{
					get
					{
						return modified;
					}
					set	
					{
						modified = value;
					}
				}

				public long? Create
				{
					get
					{
						return create;
					}
					set	
					{
						create = value;
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

				public int? Id
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

				public int? AliUid
				{
					get
					{
						return aliUid;
					}
					set	
					{
						aliUid = value;
					}
				}
			}
		}

		public class DescribeRuleList_PageInfo
		{

			private int? pageSize;

			private int? currentPage;

			private int? totalCount;

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
