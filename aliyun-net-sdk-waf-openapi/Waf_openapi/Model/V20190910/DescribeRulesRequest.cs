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
using Aliyun.Acs.waf_openapi.Transform;
using Aliyun.Acs.waf_openapi.Transform.V20190910;

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
    public class DescribeRulesRequest : RpcAcsRequest<DescribeRulesResponse>
    {
        public DescribeRulesRequest()
            : base("waf-openapi", "2019-09-10", "DescribeRules", "waf", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? ruleGroupId;

		private int? protectionType;

		private int? pageNumber;

		private string cveIdKey;

		private string resourceGroupId;

		private string sourceIp;

		private int? pageSize;

		private string lang;

		private int? riskLevel;

		private string instanceId;

		private string ruleIdKey;

		private string region;

		private int? applicationType;

		public long? RuleGroupId
		{
			get
			{
				return ruleGroupId;
			}
			set	
			{
				ruleGroupId = value;
				DictionaryUtil.Add(QueryParameters, "RuleGroupId", value.ToString());
			}
		}

		public int? ProtectionType
		{
			get
			{
				return protectionType;
			}
			set	
			{
				protectionType = value;
				DictionaryUtil.Add(QueryParameters, "ProtectionType", value.ToString());
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

		public string CveIdKey
		{
			get
			{
				return cveIdKey;
			}
			set	
			{
				cveIdKey = value;
				DictionaryUtil.Add(QueryParameters, "CveIdKey", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string RuleIdKey
		{
			get
			{
				return ruleIdKey;
			}
			set	
			{
				ruleIdKey = value;
				DictionaryUtil.Add(QueryParameters, "RuleIdKey", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public int? ApplicationType
		{
			get
			{
				return applicationType;
			}
			set	
			{
				applicationType = value;
				DictionaryUtil.Add(QueryParameters, "ApplicationType", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeRulesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeRulesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
