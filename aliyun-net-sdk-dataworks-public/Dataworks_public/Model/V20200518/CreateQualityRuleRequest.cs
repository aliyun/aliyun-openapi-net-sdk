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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class CreateQualityRuleRequest : RpcAcsRequest<CreateQualityRuleResponse>
    {
        public CreateQualityRuleRequest()
            : base("dataworks-public", "2020-05-18", "CreateQualityRule", "dide", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string projectName;

		private string trend;

		private int? ruleType;

		private int? blockType;

		private string propertyType;

		private long? entityId;

		private string ruleName;

		private int? checker;

		private int? templateId;

		private string expectValue;

		private string _operator;

		private string whereCondition;

		private string criticalThreshold;

		private string property;

		private string comment;

		private int? predictType;

		private string warningThreshold;

		private string methodName;

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(BodyParameters, "ProjectName", value);
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
				DictionaryUtil.Add(BodyParameters, "Trend", value);
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
				DictionaryUtil.Add(BodyParameters, "RuleType", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "BlockType", value.ToString());
			}
		}

		public string PropertyType
		{
			get
			{
				return propertyType;
			}
			set	
			{
				propertyType = value;
				DictionaryUtil.Add(BodyParameters, "PropertyType", value);
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
				DictionaryUtil.Add(BodyParameters, "EntityId", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "RuleName", value);
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
				DictionaryUtil.Add(BodyParameters, "Checker", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "TemplateId", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "ExpectValue", value);
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
				DictionaryUtil.Add(BodyParameters, "Operator", value);
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
				DictionaryUtil.Add(BodyParameters, "WhereCondition", value);
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
				DictionaryUtil.Add(BodyParameters, "CriticalThreshold", value);
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
				DictionaryUtil.Add(BodyParameters, "Property", value);
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
				DictionaryUtil.Add(BodyParameters, "Comment", value);
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
				DictionaryUtil.Add(BodyParameters, "PredictType", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "WarningThreshold", value);
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
				DictionaryUtil.Add(BodyParameters, "MethodName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateQualityRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateQualityRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
