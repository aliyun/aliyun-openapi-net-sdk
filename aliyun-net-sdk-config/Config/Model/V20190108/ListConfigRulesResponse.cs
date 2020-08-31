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

namespace Aliyun.Acs.Config.Model.V20190108
{
	public class ListConfigRulesResponse : AcsResponse
	{

		private string requestId;

		private ListConfigRules_ConfigRules configRules;

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

		public ListConfigRules_ConfigRules ConfigRules
		{
			get
			{
				return configRules;
			}
			set	
			{
				configRules = value;
			}
		}

		public class ListConfigRules_ConfigRules
		{

			private int? pageNumber;

			private int? pageSize;

			private long? totalCount;

			private List<ListConfigRules_ConfigRule> configRuleList;

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

			public List<ListConfigRules_ConfigRule> ConfigRuleList
			{
				get
				{
					return configRuleList;
				}
				set	
				{
					configRuleList = value;
				}
			}

			public class ListConfigRules_ConfigRule
			{

				private long? accountId;

				private string configRuleArn;

				private string configRuleId;

				private string configRuleName;

				private string configRuleState;

				private string description;

				private int? riskLevel;

				private string sourceIdentifier;

				private string sourceOwner;

				private string automationType;

				private ListConfigRules_Compliance compliance;

				private ListConfigRules_CreateBy createBy;

				public long? AccountId
				{
					get
					{
						return accountId;
					}
					set	
					{
						accountId = value;
					}
				}

				public string ConfigRuleArn
				{
					get
					{
						return configRuleArn;
					}
					set	
					{
						configRuleArn = value;
					}
				}

				public string ConfigRuleId
				{
					get
					{
						return configRuleId;
					}
					set	
					{
						configRuleId = value;
					}
				}

				public string ConfigRuleName
				{
					get
					{
						return configRuleName;
					}
					set	
					{
						configRuleName = value;
					}
				}

				public string ConfigRuleState
				{
					get
					{
						return configRuleState;
					}
					set	
					{
						configRuleState = value;
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

				public string SourceIdentifier
				{
					get
					{
						return sourceIdentifier;
					}
					set	
					{
						sourceIdentifier = value;
					}
				}

				public string SourceOwner
				{
					get
					{
						return sourceOwner;
					}
					set	
					{
						sourceOwner = value;
					}
				}

				public string AutomationType
				{
					get
					{
						return automationType;
					}
					set	
					{
						automationType = value;
					}
				}

				public ListConfigRules_Compliance Compliance
				{
					get
					{
						return compliance;
					}
					set	
					{
						compliance = value;
					}
				}

				public ListConfigRules_CreateBy CreateBy
				{
					get
					{
						return createBy;
					}
					set	
					{
						createBy = value;
					}
				}

				public class ListConfigRules_Compliance
				{

					private string complianceType;

					private int? count;

					public string ComplianceType
					{
						get
						{
							return complianceType;
						}
						set	
						{
							complianceType = value;
						}
					}

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
				}

				public class ListConfigRules_CreateBy
				{

					private string creatorId;

					private string creatorName;

					private string creatorType;

					private string configRuleSceneId;

					private string configRuleSceneName;

					public string CreatorId
					{
						get
						{
							return creatorId;
						}
						set	
						{
							creatorId = value;
						}
					}

					public string CreatorName
					{
						get
						{
							return creatorName;
						}
						set	
						{
							creatorName = value;
						}
					}

					public string CreatorType
					{
						get
						{
							return creatorType;
						}
						set	
						{
							creatorType = value;
						}
					}

					public string ConfigRuleSceneId
					{
						get
						{
							return configRuleSceneId;
						}
						set	
						{
							configRuleSceneId = value;
						}
					}

					public string ConfigRuleSceneName
					{
						get
						{
							return configRuleSceneName;
						}
						set	
						{
							configRuleSceneName = value;
						}
					}
				}
			}
		}
	}
}
