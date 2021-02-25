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

		private string errorCode;

		private bool? success;

		private string errorMessage;

		private int? httpStatusCode;

		private string requestId;

		private ListQualityRules_Data data;

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

			private long? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListQualityRules_RulesItem> rules;

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

				private string projectName;

				private string tableName;

				private int? id;

				private int? entityId;

				private string property;

				private int? methodId;

				private string methodName;

				private string onDuty;

				private int? ruleType;

				private int? blockType;

				private int? templateId;

				private string templateName;

				private int? ruleCheckerRelationId;

				private int? checkerId;

				private bool? fixCheck;

				private string trend;

				private string warningThreshold;

				private string criticalThreshold;

				private string historyWarningThreshold;

				private string historyCriticalThreshold;

				private string propertyKey;

				private string matchExpression;

				private string comment;

				private string expectValue;

				private string onDutyAccountName;

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
			}
		}
	}
}
