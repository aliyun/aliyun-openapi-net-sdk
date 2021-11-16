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
	public class ListQualityRulesResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private string errorMessage;

		private bool? success;

		private string errorCode;

		private ListQualityRules_Data data;

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

		public ListQualityRules_Data Data
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

		public class ListQualityRules_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private long? totalCount;

			private List<ListQualityRules_RulesItem> rules;

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

			public List<ListQualityRules_RulesItem> Rules
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

			public class ListQualityRules_RulesItem
			{

				private int? blockType;

				private string onDutyAccountName;

				private string property;

				private string warningThreshold;

				private string tableName;

				private string onDuty;

				private string comment;

				private int? ruleCheckerRelationId;

				private bool? fixCheck;

				private int? methodId;

				private string templateName;

				private string trend;

				private string historyWarningThreshold;

				private int? ruleType;

				private string matchExpression;

				private string projectName;

				private string propertyKey;

				private string criticalThreshold;

				private string historyCriticalThreshold;

				private string methodName;

				private int? checkerId;

				private int? entityId;

				private string expectValue;

				private int? templateId;

				private int? id;

				private string ruleName;

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

				public string OnDutyAccountName
				{
					get
					{
						return onDutyAccountName;
					}
					set	
					{
						onDutyAccountName = value;
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

				public string WarningThreshold
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

				public string OnDuty
				{
					get
					{
						return onDuty;
					}
					set	
					{
						onDuty = value;
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

				public int? RuleCheckerRelationId
				{
					get
					{
						return ruleCheckerRelationId;
					}
					set	
					{
						ruleCheckerRelationId = value;
					}
				}

				public bool? FixCheck
				{
					get
					{
						return fixCheck;
					}
					set	
					{
						fixCheck = value;
					}
				}

				public int? MethodId
				{
					get
					{
						return methodId;
					}
					set	
					{
						methodId = value;
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

				public string HistoryWarningThreshold
				{
					get
					{
						return historyWarningThreshold;
					}
					set	
					{
						historyWarningThreshold = value;
					}
				}

				public int? RuleType
				{
					get
					{
						return ruleType;
					}
					set	
					{
						ruleType = value;
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

				public string PropertyKey
				{
					get
					{
						return propertyKey;
					}
					set	
					{
						propertyKey = value;
					}
				}

				public string CriticalThreshold
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

				public string HistoryCriticalThreshold
				{
					get
					{
						return historyCriticalThreshold;
					}
					set	
					{
						historyCriticalThreshold = value;
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

				public string ExpectValue
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
			}
		}
	}
}
