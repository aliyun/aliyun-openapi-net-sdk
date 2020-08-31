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
	public class DescribeEvaluationResultsResponse : AcsResponse
	{

		private string requestId;

		private DescribeEvaluationResults_EvaluationResults evaluationResults;

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

		public DescribeEvaluationResults_EvaluationResults EvaluationResults
		{
			get
			{
				return evaluationResults;
			}
			set	
			{
				evaluationResults = value;
			}
		}

		public class DescribeEvaluationResults_EvaluationResults
		{

			private int? pageNumber;

			private int? pageSize;

			private long? totalCount;

			private List<DescribeEvaluationResults_EvaluationResult> evaluationResultList;

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

			public List<DescribeEvaluationResults_EvaluationResult> EvaluationResultList
			{
				get
				{
					return evaluationResultList;
				}
				set	
				{
					evaluationResultList = value;
				}
			}

			public class DescribeEvaluationResults_EvaluationResult
			{

				private string annotation;

				private string complianceType;

				private long? configRuleInvokedTimestamp;

				private string invokingEventMessageType;

				private long? resultRecordedTimestamp;

				private int? riskLevel;

				private DescribeEvaluationResults_EvaluationResultIdentifier evaluationResultIdentifier;

				public string Annotation
				{
					get
					{
						return annotation;
					}
					set	
					{
						annotation = value;
					}
				}

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

				public long? ConfigRuleInvokedTimestamp
				{
					get
					{
						return configRuleInvokedTimestamp;
					}
					set	
					{
						configRuleInvokedTimestamp = value;
					}
				}

				public string InvokingEventMessageType
				{
					get
					{
						return invokingEventMessageType;
					}
					set	
					{
						invokingEventMessageType = value;
					}
				}

				public long? ResultRecordedTimestamp
				{
					get
					{
						return resultRecordedTimestamp;
					}
					set	
					{
						resultRecordedTimestamp = value;
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

				public DescribeEvaluationResults_EvaluationResultIdentifier EvaluationResultIdentifier
				{
					get
					{
						return evaluationResultIdentifier;
					}
					set	
					{
						evaluationResultIdentifier = value;
					}
				}

				public class DescribeEvaluationResults_EvaluationResultIdentifier
				{

					private long? orderingTimestamp;

					private DescribeEvaluationResults_EvaluationResultQualifier evaluationResultQualifier;

					public long? OrderingTimestamp
					{
						get
						{
							return orderingTimestamp;
						}
						set	
						{
							orderingTimestamp = value;
						}
					}

					public DescribeEvaluationResults_EvaluationResultQualifier EvaluationResultQualifier
					{
						get
						{
							return evaluationResultQualifier;
						}
						set	
						{
							evaluationResultQualifier = value;
						}
					}

					public class DescribeEvaluationResults_EvaluationResultQualifier
					{

						private string configRuleArn;

						private string configRuleId;

						private string configRuleName;

						private string resourceId;

						private string resourceType;

						private string regionId;

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

						public string ResourceId
						{
							get
							{
								return resourceId;
							}
							set	
							{
								resourceId = value;
							}
						}

						public string ResourceType
						{
							get
							{
								return resourceType;
							}
							set	
							{
								resourceType = value;
							}
						}

						public string RegionId
						{
							get
							{
								return regionId;
							}
							set	
							{
								regionId = value;
							}
						}
					}
				}
			}
		}
	}
}
