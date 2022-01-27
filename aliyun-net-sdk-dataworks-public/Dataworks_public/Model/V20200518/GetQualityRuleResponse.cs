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
	public class GetQualityRuleResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private string errorMessage;

		private string errorCode;

		private bool? success;

		private GetQualityRule_Data data;

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

		public GetQualityRule_Data Data
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

		public class GetQualityRule_Data
		{

			private int? blockType;

			private string onDutyAccountName;

			private string warningThreshold;

			private string property;

			private int? ruleType;

			private string comment;

			private string onDuty;

			private int? checker;

			private bool? fixCheck;

			private int? methodId;

			private string criticalThreshold;

			private int? predictType;

			private string templateName;

			private string checkerName;

			private string ruleName;

			private string methodName;

			private long? entityId;

			private string whereCondition;

			private string _operator;

			private string expectValue;

			private string trend;

			private int? templateId;

			private long? id;

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

			public int? Checker
			{
				get
				{
					return checker;
				}
				set	
				{
					checker = value;
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

			public int? PredictType
			{
				get
				{
					return predictType;
				}
				set	
				{
					predictType = value;
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

			public long? EntityId
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
		}
	}
}
