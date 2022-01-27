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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListQualityResultsByRuleResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string errorMessage;

		private string requestId;

		private string errorCode;

		private bool? success;

		private ListQualityResultsByRule_Data data;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public ListQualityResultsByRule_Data Data
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

		public class ListQualityResultsByRule_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private long? totalCount;

			private List<ListQualityResultsByRule_RuleChecksItem> ruleChecks;

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

			public List<ListQualityResultsByRule_RuleChecksItem> RuleChecks
			{
				get
				{
					return ruleChecks;
				}
				set	
				{
					ruleChecks = value;
				}
			}

			public class ListQualityResultsByRule_RuleChecksItem
			{

				private int? blockType;

				private float? warningThreshold;

				private string property;

				private string tableName;

				private string comment;

				private int? checkResultStatus;

				private string templateName;

				private string checkerName;

				private int? ruleId;

				private bool? fixedCheck;

				private string op;

				private float? upperValue;

				private string actualExpression;

				private string externalId;

				private string timeCost;

				private string trend;

				private string externalType;

				private long? bizDate;

				private int? checkResult;

				private string resultString;

				private string matchExpression;

				private int? checkerType;

				private string projectName;

				private long? beginTime;

				private string dateType;

				private float? criticalThreshold;

				private bool? isPrediction;

				private string ruleName;

				private int? checkerId;

				private bool? discreteCheck;

				private long? endTime;

				private string methodName;

				private float? lowerValue;

				private int? entityId;

				private string whereCondition;

				private float? expectValue;

				private int? templateId;

				private string taskId;

				private int? id;

				private List<ListQualityResultsByRule_ReferenceValueItem> referenceValue;

				private List<ListQualityResultsByRule_SampleValueItem> sampleValue;

				public int? BlockType
				{
					get
					{
						return blockType;
					}
					set	
					{
						blockType = value;
					}
				}

				public float? WarningThreshold
				{
					get
					{
						return warningThreshold;
					}
					set	
					{
						warningThreshold = value;
					}
				}

				public string Property
				{
					get
					{
						return property;
					}
					set	
					{
						property = value;
					}
				}

				public string TableName
				{
					get
					{
						return tableName;
					}
					set	
					{
						tableName = value;
					}
				}

				public string Comment
				{
					get
					{
						return comment;
					}
					set	
					{
						comment = value;
					}
				}

				public int? CheckResultStatus
				{
					get
					{
						return checkResultStatus;
					}
					set	
					{
						checkResultStatus = value;
					}
				}

				public string TemplateName
				{
					get
					{
						return templateName;
					}
					set	
					{
						templateName = value;
					}
				}

				public string CheckerName
				{
					get
					{
						return checkerName;
					}
					set	
					{
						checkerName = value;
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

				public bool? FixedCheck
				{
					get
					{
						return fixedCheck;
					}
					set	
					{
						fixedCheck = value;
					}
				}

				public string Op
				{
					get
					{
						return op;
					}
					set	
					{
						op = value;
					}
				}

				public float? UpperValue
				{
					get
					{
						return upperValue;
					}
					set	
					{
						upperValue = value;
					}
				}

				public string ActualExpression
				{
					get
					{
						return actualExpression;
					}
					set	
					{
						actualExpression = value;
					}
				}

				public string ExternalId
				{
					get
					{
						return externalId;
					}
					set	
					{
						externalId = value;
					}
				}

				public string TimeCost
				{
					get
					{
						return timeCost;
					}
					set	
					{
						timeCost = value;
					}
				}

				public string Trend
				{
					get
					{
						return trend;
					}
					set	
					{
						trend = value;
					}
				}

				public string ExternalType
				{
					get
					{
						return externalType;
					}
					set	
					{
						externalType = value;
					}
				}

				public long? BizDate
				{
					get
					{
						return bizDate;
					}
					set	
					{
						bizDate = value;
					}
				}

				public int? CheckResult
				{
					get
					{
						return checkResult;
					}
					set	
					{
						checkResult = value;
					}
				}

				public string ResultString
				{
					get
					{
						return resultString;
					}
					set	
					{
						resultString = value;
					}
				}

				public string MatchExpression
				{
					get
					{
						return matchExpression;
					}
					set	
					{
						matchExpression = value;
					}
				}

				public int? CheckerType
				{
					get
					{
						return checkerType;
					}
					set	
					{
						checkerType = value;
					}
				}

				public string ProjectName
				{
					get
					{
						return projectName;
					}
					set	
					{
						projectName = value;
					}
				}

				public long? BeginTime
				{
					get
					{
						return beginTime;
					}
					set	
					{
						beginTime = value;
					}
				}

				public string DateType
				{
					get
					{
						return dateType;
					}
					set	
					{
						dateType = value;
					}
				}

				public float? CriticalThreshold
				{
					get
					{
						return criticalThreshold;
					}
					set	
					{
						criticalThreshold = value;
					}
				}

				public bool? IsPrediction
				{
					get
					{
						return isPrediction;
					}
					set	
					{
						isPrediction = value;
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

				public int? CheckerId
				{
					get
					{
						return checkerId;
					}
					set	
					{
						checkerId = value;
					}
				}

				public bool? DiscreteCheck
				{
					get
					{
						return discreteCheck;
					}
					set	
					{
						discreteCheck = value;
					}
				}

				public long? EndTime
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

				public string MethodName
				{
					get
					{
						return methodName;
					}
					set	
					{
						methodName = value;
					}
				}

				public float? LowerValue
				{
					get
					{
						return lowerValue;
					}
					set	
					{
						lowerValue = value;
					}
				}

				public int? EntityId
				{
					get
					{
						return entityId;
					}
					set	
					{
						entityId = value;
					}
				}

				public string WhereCondition
				{
					get
					{
						return whereCondition;
					}
					set	
					{
						whereCondition = value;
					}
				}

				public float? ExpectValue
				{
					get
					{
						return expectValue;
					}
					set	
					{
						expectValue = value;
					}
				}

				public int? TemplateId
				{
					get
					{
						return templateId;
					}
					set	
					{
						templateId = value;
					}
				}

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
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

				public List<ListQualityResultsByRule_ReferenceValueItem> ReferenceValue
				{
					get
					{
						return referenceValue;
					}
					set	
					{
						referenceValue = value;
					}
				}

				public List<ListQualityResultsByRule_SampleValueItem> SampleValue
				{
					get
					{
						return sampleValue;
					}
					set	
					{
						sampleValue = value;
					}
				}

				public class ListQualityResultsByRule_ReferenceValueItem
				{

					private string discreteProperty;

					private float? _value;

					private string bizDate;

					private int? singleCheckResult;

					private float? threshold;

					public string DiscreteProperty
					{
						get
						{
							return discreteProperty;
						}
						set	
						{
							discreteProperty = value;
						}
					}

					public float? _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}

					public string BizDate
					{
						get
						{
							return bizDate;
						}
						set	
						{
							bizDate = value;
						}
					}

					public int? SingleCheckResult
					{
						get
						{
							return singleCheckResult;
						}
						set	
						{
							singleCheckResult = value;
						}
					}

					public float? Threshold
					{
						get
						{
							return threshold;
						}
						set	
						{
							threshold = value;
						}
					}
				}

				public class ListQualityResultsByRule_SampleValueItem
				{

					private string discreteProperty;

					private string bizDate;

					private float? _value;

					public string DiscreteProperty
					{
						get
						{
							return discreteProperty;
						}
						set	
						{
							discreteProperty = value;
						}
					}

					public string BizDate
					{
						get
						{
							return bizDate;
						}
						set	
						{
							bizDate = value;
						}
					}

					public float? _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}
			}
		}
	}
}
