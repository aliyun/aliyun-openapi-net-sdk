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

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
	public class DescribeRuleGroupsResponse : AcsResponse
	{

		private string requestId;

		private int? taskStatus;

		private int? total;

		private string wafTaskId;

		private List<DescribeRuleGroups_RuleGroupsItem> ruleGroups;

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

		public int? TaskStatus
		{
			get
			{
				return taskStatus;
			}
			set	
			{
				taskStatus = value;
			}
		}

		public int? Total
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

		public string WafTaskId
		{
			get
			{
				return wafTaskId;
			}
			set	
			{
				wafTaskId = value;
			}
		}

		public List<DescribeRuleGroups_RuleGroupsItem> RuleGroups
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

		public class DescribeRuleGroups_RuleGroupsItem
		{

			private int? type;

			private int? ruleCnt;

			private long? ruleGroupUpdateTime;

			private long? policyId;

			private string name;

			private long? templatePolicyId;

			private string ruleGroupTemplateName;

			private string desc;

			private long? wafVersion;

			private List<string> domainList;

			public int? Type
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

			public int? RuleCnt
			{
				get
				{
					return ruleCnt;
				}
				set	
				{
					ruleCnt = value;
				}
			}

			public long? RuleGroupUpdateTime
			{
				get
				{
					return ruleGroupUpdateTime;
				}
				set	
				{
					ruleGroupUpdateTime = value;
				}
			}

			public long? PolicyId
			{
				get
				{
					return policyId;
				}
				set	
				{
					policyId = value;
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

			public long? TemplatePolicyId
			{
				get
				{
					return templatePolicyId;
				}
				set	
				{
					templatePolicyId = value;
				}
			}

			public string RuleGroupTemplateName
			{
				get
				{
					return ruleGroupTemplateName;
				}
				set	
				{
					ruleGroupTemplateName = value;
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

			public long? WafVersion
			{
				get
				{
					return wafVersion;
				}
				set	
				{
					wafVersion = value;
				}
			}

			public List<string> DomainList
			{
				get
				{
					return domainList;
				}
				set	
				{
					domainList = value;
				}
			}
		}
	}
}
