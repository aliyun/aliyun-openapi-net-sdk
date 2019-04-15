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
using Aliyun.Acs.aegis.Transform;
using Aliyun.Acs.aegis.Transform.V20161111;

namespace Aliyun.Acs.aegis.Model.V20161111
{
    public class CreateOrUpdateRuleRequest : RpcAcsRequest<CreateOrUpdateRuleResponse>
    {
        public CreateOrUpdateRuleRequest()
            : base("aegis", "2016-11-11", "CreateOrUpdateRule", "vipaegis", "openAPI")
        {
        }

		private string warnLevel;

		private string sourceIp;

		private string statisticsRules;

		private long? dataSourceId;

		private string description;

		private string ruleName;

		private long? id;

		private string lang;

		private string expressions;

		private string actions;

		private string ruleGroupIds;

		public string WarnLevel
		{
			get
			{
				return warnLevel;
			}
			set	
			{
				warnLevel = value;
				DictionaryUtil.Add(QueryParameters, "WarnLevel", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string StatisticsRules
		{
			get
			{
				return statisticsRules;
			}
			set	
			{
				statisticsRules = value;
				DictionaryUtil.Add(QueryParameters, "StatisticsRules", value);
			}
		}

		public long? DataSourceId
		{
			get
			{
				return dataSourceId;
			}
			set	
			{
				dataSourceId = value;
				DictionaryUtil.Add(QueryParameters, "DataSourceId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Description", value);
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
				DictionaryUtil.Add(QueryParameters, "RuleName", value);
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
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string Expressions
		{
			get
			{
				return expressions;
			}
			set	
			{
				expressions = value;
				DictionaryUtil.Add(QueryParameters, "Expressions", value);
			}
		}

		public string Actions
		{
			get
			{
				return actions;
			}
			set	
			{
				actions = value;
				DictionaryUtil.Add(QueryParameters, "Actions", value);
			}
		}

		public string RuleGroupIds
		{
			get
			{
				return ruleGroupIds;
			}
			set	
			{
				ruleGroupIds = value;
				DictionaryUtil.Add(QueryParameters, "RuleGroupIds", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateOrUpdateRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOrUpdateRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
