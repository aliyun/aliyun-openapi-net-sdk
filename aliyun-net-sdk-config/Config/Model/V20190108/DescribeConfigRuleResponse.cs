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
	public class DescribeConfigRuleResponse : AcsResponse
	{

		private string requestId;

		private DescribeConfigRule_ConfigRule configRule;

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

		public DescribeConfigRule_ConfigRule ConfigRule
		{
			get
			{
				return configRule;
			}
			set	
			{
				configRule = value;
			}
		}

		public class DescribeConfigRule_ConfigRule
		{

			private string configRuleArn;

			private string configRuleId;

			private string configRuleName;

			private string configRuleState;

			private long? createTimestamp;

			private string description;

			private string inputParameters;

			private long? modifiedTimestamp;

			private int? riskLevel;

			private string maximumExecutionFrequency;

			private DescribeConfigRule_CreateBy createBy;

			private DescribeConfigRule_ConfigRuleEvaluationStatus configRuleEvaluationStatus;

			private DescribeConfigRule_ManagedRule managedRule;

			private DescribeConfigRule_Source source;

			private DescribeConfigRule_Scope scope;

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

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
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

			public string InputParameters
			{
				get
				{
					return inputParameters;
				}
				set	
				{
					inputParameters = value;
				}
			}

			public long? ModifiedTimestamp
			{
				get
				{
					return modifiedTimestamp;
				}
				set	
				{
					modifiedTimestamp = value;
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

			public string MaximumExecutionFrequency
			{
				get
				{
					return maximumExecutionFrequency;
				}
				set	
				{
					maximumExecutionFrequency = value;
				}
			}

			public DescribeConfigRule_CreateBy CreateBy
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

			public DescribeConfigRule_ConfigRuleEvaluationStatus ConfigRuleEvaluationStatus
			{
				get
				{
					return configRuleEvaluationStatus;
				}
				set	
				{
					configRuleEvaluationStatus = value;
				}
			}

			public DescribeConfigRule_ManagedRule ManagedRule
			{
				get
				{
					return managedRule;
				}
				set	
				{
					managedRule = value;
				}
			}

			public DescribeConfigRule_Source Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public DescribeConfigRule_Scope Scope
			{
				get
				{
					return scope;
				}
				set	
				{
					scope = value;
				}
			}

			public class DescribeConfigRule_CreateBy
			{

				private string creatorType;

				private string creatorId;

				private string creatorName;

				private string configRuleSceneId;

				private string configRuleSceneName;

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

			public class DescribeConfigRule_ConfigRuleEvaluationStatus
			{

				private long? firstActivatedTimestamp;

				private bool? firstEvaluationStarted;

				private string lastErrorCode;

				private string lastErrorMessage;

				private long? lastFailedEvaluationTimestamp;

				private long? lastFailedInvocationTimestamp;

				private long? lastSuccessfulEvaluationTimestamp;

				private long? lastSuccessfulInvocationTimestamp;

				public long? FirstActivatedTimestamp
				{
					get
					{
						return firstActivatedTimestamp;
					}
					set	
					{
						firstActivatedTimestamp = value;
					}
				}

				public bool? FirstEvaluationStarted
				{
					get
					{
						return firstEvaluationStarted;
					}
					set	
					{
						firstEvaluationStarted = value;
					}
				}

				public string LastErrorCode
				{
					get
					{
						return lastErrorCode;
					}
					set	
					{
						lastErrorCode = value;
					}
				}

				public string LastErrorMessage
				{
					get
					{
						return lastErrorMessage;
					}
					set	
					{
						lastErrorMessage = value;
					}
				}

				public long? LastFailedEvaluationTimestamp
				{
					get
					{
						return lastFailedEvaluationTimestamp;
					}
					set	
					{
						lastFailedEvaluationTimestamp = value;
					}
				}

				public long? LastFailedInvocationTimestamp
				{
					get
					{
						return lastFailedInvocationTimestamp;
					}
					set	
					{
						lastFailedInvocationTimestamp = value;
					}
				}

				public long? LastSuccessfulEvaluationTimestamp
				{
					get
					{
						return lastSuccessfulEvaluationTimestamp;
					}
					set	
					{
						lastSuccessfulEvaluationTimestamp = value;
					}
				}

				public long? LastSuccessfulInvocationTimestamp
				{
					get
					{
						return lastSuccessfulInvocationTimestamp;
					}
					set	
					{
						lastSuccessfulInvocationTimestamp = value;
					}
				}
			}

			public class DescribeConfigRule_ManagedRule
			{

				private string managedRuleName;

				private string description;

				private string identifier;

				private string compulsoryInputParameterDetails;

				private string optionalInputParameterDetails;

				private string helpUrl;

				private List<DescribeConfigRule_SourceDetailsItem> sourceDetails;

				private List<string> labels;

				public string ManagedRuleName
				{
					get
					{
						return managedRuleName;
					}
					set	
					{
						managedRuleName = value;
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

				public string Identifier
				{
					get
					{
						return identifier;
					}
					set	
					{
						identifier = value;
					}
				}

				public string CompulsoryInputParameterDetails
				{
					get
					{
						return compulsoryInputParameterDetails;
					}
					set	
					{
						compulsoryInputParameterDetails = value;
					}
				}

				public string OptionalInputParameterDetails
				{
					get
					{
						return optionalInputParameterDetails;
					}
					set	
					{
						optionalInputParameterDetails = value;
					}
				}

				public string HelpUrl
				{
					get
					{
						return helpUrl;
					}
					set	
					{
						helpUrl = value;
					}
				}

				public List<DescribeConfigRule_SourceDetailsItem> SourceDetails
				{
					get
					{
						return sourceDetails;
					}
					set	
					{
						sourceDetails = value;
					}
				}

				public List<string> Labels
				{
					get
					{
						return labels;
					}
					set	
					{
						labels = value;
					}
				}

				public class DescribeConfigRule_SourceDetailsItem
				{

					private string eventSource;

					private string maximumExecutionFrequency;

					private string messageType;

					public string EventSource
					{
						get
						{
							return eventSource;
						}
						set	
						{
							eventSource = value;
						}
					}

					public string MaximumExecutionFrequency
					{
						get
						{
							return maximumExecutionFrequency;
						}
						set	
						{
							maximumExecutionFrequency = value;
						}
					}

					public string MessageType
					{
						get
						{
							return messageType;
						}
						set	
						{
							messageType = value;
						}
					}
				}
			}

			public class DescribeConfigRule_Source
			{

				private string identifier;

				private string owner;

				private List<DescribeConfigRule_SourceConditionsItem> sourceConditions;

				private List<DescribeConfigRule_SourceDetailsItem2> sourceDetails1;

				public string Identifier
				{
					get
					{
						return identifier;
					}
					set	
					{
						identifier = value;
					}
				}

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
					}
				}

				public List<DescribeConfigRule_SourceConditionsItem> SourceConditions
				{
					get
					{
						return sourceConditions;
					}
					set	
					{
						sourceConditions = value;
					}
				}

				public List<DescribeConfigRule_SourceDetailsItem2> SourceDetails1
				{
					get
					{
						return sourceDetails1;
					}
					set	
					{
						sourceDetails1 = value;
					}
				}

				public class DescribeConfigRule_SourceConditionsItem
				{

					private string desiredValue;

					private string name;

					private string _operator;

					private bool? required;

					private string selectPath;

					private string tips;

					public string DesiredValue
					{
						get
						{
							return desiredValue;
						}
						set	
						{
							desiredValue = value;
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

					public string _Operator
					{
						get
						{
							return _operator;
						}
						set	
						{
							_operator = value;
						}
					}

					public bool? Required
					{
						get
						{
							return required;
						}
						set	
						{
							required = value;
						}
					}

					public string SelectPath
					{
						get
						{
							return selectPath;
						}
						set	
						{
							selectPath = value;
						}
					}

					public string Tips
					{
						get
						{
							return tips;
						}
						set	
						{
							tips = value;
						}
					}
				}

				public class DescribeConfigRule_SourceDetailsItem2
				{

					private string eventSource;

					private string maximumExecutionFrequency;

					private string messageType;

					public string EventSource
					{
						get
						{
							return eventSource;
						}
						set	
						{
							eventSource = value;
						}
					}

					public string MaximumExecutionFrequency
					{
						get
						{
							return maximumExecutionFrequency;
						}
						set	
						{
							maximumExecutionFrequency = value;
						}
					}

					public string MessageType
					{
						get
						{
							return messageType;
						}
						set	
						{
							messageType = value;
						}
					}
				}
			}

			public class DescribeConfigRule_Scope
			{

				private string complianceResourceId;

				private List<string> complianceResourceTypes;

				public string ComplianceResourceId
				{
					get
					{
						return complianceResourceId;
					}
					set	
					{
						complianceResourceId = value;
					}
				}

				public List<string> ComplianceResourceTypes
				{
					get
					{
						return complianceResourceTypes;
					}
					set	
					{
						complianceResourceTypes = value;
					}
				}
			}
		}
	}
}
