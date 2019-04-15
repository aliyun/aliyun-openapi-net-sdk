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
    public class CreateOrUpdateJoinRuleRequest : RpcAcsRequest<CreateOrUpdateJoinRuleResponse>
    {
        public CreateOrUpdateJoinRuleRequest()
            : base("aegis", "2016-11-11", "CreateOrUpdateJoinRule", "vipaegis", "openAPI")
        {
        }

		private string warnLevel;

		private long? dataSourceId2;

		private long? dataSourceId1;

		private long? timeWindow;

		private string description;

		private string ruleName;

		private string expression2;

		private string expression1;

		private string sourceIp;

		private string statisticsRules;

		private string joinRelation;

		private long? ruleId;

		private string actions;

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

		public long? DataSourceId2
		{
			get
			{
				return dataSourceId2;
			}
			set	
			{
				dataSourceId2 = value;
				DictionaryUtil.Add(QueryParameters, "DataSourceId2", value.ToString());
			}
		}

		public long? DataSourceId1
		{
			get
			{
				return dataSourceId1;
			}
			set	
			{
				dataSourceId1 = value;
				DictionaryUtil.Add(QueryParameters, "DataSourceId1", value.ToString());
			}
		}

		public long? TimeWindow
		{
			get
			{
				return timeWindow;
			}
			set	
			{
				timeWindow = value;
				DictionaryUtil.Add(QueryParameters, "TimeWindow", value.ToString());
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

		public string Expression2
		{
			get
			{
				return expression2;
			}
			set	
			{
				expression2 = value;
				DictionaryUtil.Add(QueryParameters, "Expression2", value);
			}
		}

		public string Expression1
		{
			get
			{
				return expression1;
			}
			set	
			{
				expression1 = value;
				DictionaryUtil.Add(QueryParameters, "Expression1", value);
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

		public string JoinRelation
		{
			get
			{
				return joinRelation;
			}
			set	
			{
				joinRelation = value;
				DictionaryUtil.Add(QueryParameters, "JoinRelation", value);
			}
		}

		public long? RuleId
		{
			get
			{
				return ruleId;
			}
			set	
			{
				ruleId = value;
				DictionaryUtil.Add(QueryParameters, "RuleId", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateOrUpdateJoinRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOrUpdateJoinRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
