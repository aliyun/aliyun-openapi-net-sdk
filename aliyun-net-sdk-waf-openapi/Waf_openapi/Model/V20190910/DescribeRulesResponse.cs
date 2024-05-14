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
	public class DescribeRulesResponse : AcsResponse
	{

		private string ruleGroupTemplateId;

		private string ruleGroupName;

		private string requestId;

		private int? totalCount;

		private string ruleGroupTemplateName;

		private long? isSubscribe;

		private List<DescribeRules_RulesItem> rules;

		public string RuleGroupTemplateId
		{
			get
			{
				return ruleGroupTemplateId;
			}
			set	
			{
				ruleGroupTemplateId = value;
			}
		}

		public string RuleGroupName
		{
			get
			{
				return ruleGroupName;
			}
			set	
			{
				ruleGroupName = value;
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

		public long? IsSubscribe
		{
			get
			{
				return isSubscribe;
			}
			set	
			{
				isSubscribe = value;
			}
		}

		public List<DescribeRules_RulesItem> Rules
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

		public class DescribeRules_RulesItem
		{

			private int? riskLevel;

			private long? updateTime;

			private string description;

			private string cveUrl;

			private int? applicationType;

			private string cveId;

			private int? protectionType;

			private string ruleName;

			private long? ruleId;

			public int? RiskLevel
			{
				get
				{
					return riskLevel;
				}
				set	
				{
					riskLevel = value;
				}
			}

			public long? UpdateTime
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

			public string CveUrl
			{
				get
				{
					return cveUrl;
				}
				set	
				{
					cveUrl = value;
				}
			}

			public int? ApplicationType
			{
				get
				{
					return applicationType;
				}
				set	
				{
					applicationType = value;
				}
			}

			public string CveId
			{
				get
				{
					return cveId;
				}
				set	
				{
					cveId = value;
				}
			}

			public int? ProtectionType
			{
				get
				{
					return protectionType;
				}
				set	
				{
					protectionType = value;
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

			public long? RuleId
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
		}
	}
}
