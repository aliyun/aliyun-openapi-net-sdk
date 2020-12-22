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
	public class ListQualityResultsByEntityResponse : AcsResponse
	{

		private string requestId;

		private int? httpStatusCode;

		private string errorMessage;

		private string errorCode;

		private bool? success;

		private ListQualityResultsByEntity_Data data;

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

		public ListQualityResultsByEntity_Data Data
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

		public class ListQualityResultsByEntity_Data
		{

			private long? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListQualityResultsByEntity_RuleChecksItem> ruleChecks;

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

			public List<ListQualityResultsByEntity_RuleChecksItem> RuleChecks
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

			public class ListQualityResultsByEntity_RuleChecksItem
			{

				private int? id;

				private string taskId;

				private int? entityId;

				private int? ruleId;

				private string property;

				private long? bizDate;

				private string dateType;

				private string actualExpression;

				private string matchExpression;

				private int? blockType;

				private int? checkResult;

				private int? checkResultStatus;

				private string methodName;

				private string comment;

				private string whereCondition;

				private long? beginTime;

				private long? endTime;

				private string timeCost;

				private string externalType;

				private string externalId;

				private bool? discreteCheck;

				private bool? fixedCheck;

				private string trend;

				private float? warningThreshold;

				private float? criticalThreshold;

				private float? expectValue;

				private string op;

				private string projectName;

				private string tableName;

				private int? templateId;

				private string templateName;

				private string resultString;

				private int? checkerId;

				private int? checkerType;

				private string ruleName;

				private bool? isPrediction;

				private float? upperValue;

				private float? lowerValue;

				private string checkerName;

				private List<ListQualityResultsByEntity_ReferenceValueItem> referenceValue;

				private List<ListQualityResultsByEntity_SampleValueItem> sampleValue;

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

				public List<ListQualityResultsByEntity_ReferenceValueItem> ReferenceValue
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

				public List<ListQualityResultsByEntity_SampleValueItem> SampleValue
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

				public class ListQualityResultsByEntity_ReferenceValueItem
				{

					private string bizDate;

					private string discreteProperty;

					private float? _value;

					private float? threshold;

					private int? singleCheckResult;

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
				}

				public class ListQualityResultsByEntity_SampleValueItem
				{

					private string bizDate;

					private string discreteProperty;

					private float? _value;

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
				}
			}
		}
	}
}
