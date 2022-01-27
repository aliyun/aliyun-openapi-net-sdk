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
	public class DescribeAntiBruteForceRulesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAntiBruteForceRules_AntiBruteForceRule> rules;

		private DescribeAntiBruteForceRules_PageInfo pageInfo;

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

		public List<DescribeAntiBruteForceRules_AntiBruteForceRule> Rules
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

		public DescribeAntiBruteForceRules_PageInfo PageInfo
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

		public class DescribeAntiBruteForceRules_AntiBruteForceRule
		{

			private long? id;

			private bool? defaultRule;

			private string name;

			private int? span;

			private int? failCount;

			private int? forbiddenTime;

			private bool? enableSmartRule;

			private int? machineCount;

			private List<string> uuidList;

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

			public bool? DefaultRule
			{
				get
				{
					return defaultRule;
				}
				set	
				{
					defaultRule = value;
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

			public int? Span
			{
				get
				{
					return span;
				}
				set	
				{
					span = value;
				}
			}

			public int? FailCount
			{
				get
				{
					return failCount;
				}
				set	
				{
					failCount = value;
				}
			}

			public int? ForbiddenTime
			{
				get
				{
					return forbiddenTime;
				}
				set	
				{
					forbiddenTime = value;
				}
			}

			public bool? EnableSmartRule
			{
				get
				{
					return enableSmartRule;
				}
				set	
				{
					enableSmartRule = value;
				}
			}

			public int? MachineCount
			{
				get
				{
					return machineCount;
				}
				set	
				{
					machineCount = value;
				}
			}

			public List<string> UuidList
			{
				get
				{
					return uuidList;
				}
				set	
				{
					uuidList = value;
				}
			}
		}

		public class DescribeAntiBruteForceRules_PageInfo
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
