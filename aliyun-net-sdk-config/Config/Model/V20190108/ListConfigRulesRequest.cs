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
using Aliyun.Acs.Config;
using Aliyun.Acs.Config.Transform;
using Aliyun.Acs.Config.Transform.V20190108;

namespace Aliyun.Acs.Config.Model.V20190108
{
    public class ListConfigRulesRequest : RpcAcsRequest<ListConfigRulesResponse>
    {
        public ListConfigRulesRequest()
            : base("Config", "2019-01-08", "ListConfigRules")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Config.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Config.Endpoint.endpointRegionalType, null);
            }
        }

		private bool? multiAccount;

		private string configRuleState;

		private int? pageNumber;

		private int? pageSize;

		private string compliancePackId;

		private string complianceType;

		private int? riskLevel;

		private string configRuleName;

		private long? memberId;

		public bool? MultiAccount
		{
			get
			{
				return multiAccount;
			}
			set	
			{
				multiAccount = value;
				DictionaryUtil.Add(QueryParameters, "MultiAccount", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ConfigRuleState", value);
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
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string CompliancePackId
		{
			get
			{
				return compliancePackId;
			}
			set	
			{
				compliancePackId = value;
				DictionaryUtil.Add(QueryParameters, "CompliancePackId", value);
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
				DictionaryUtil.Add(QueryParameters, "ComplianceType", value);
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
				DictionaryUtil.Add(QueryParameters, "RiskLevel", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ConfigRuleName", value);
			}
		}

		public long? MemberId
		{
			get
			{
				return memberId;
			}
			set	
			{
				memberId = value;
				DictionaryUtil.Add(QueryParameters, "MemberId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListConfigRulesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListConfigRulesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
