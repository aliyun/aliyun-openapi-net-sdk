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
    public class ModifyProtectionRuleStatusRequest : RpcAcsRequest<ModifyProtectionRuleStatusResponse>
    {
        public ModifyProtectionRuleStatusRequest()
            : base("waf-openapi", "2019-09-10", "ModifyProtectionRuleStatus", "waf", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? lockVersion;

		private string defenseType;

		private int? ruleStatus;

		private string instanceId;

		private string domain;

		private long? ruleId;

		public long? LockVersion
		{
			get
			{
				return lockVersion;
			}
			set	
			{
				lockVersion = value;
				DictionaryUtil.Add(QueryParameters, "LockVersion", value.ToString());
			}
		}

		public string DefenseType
		{
			get
			{
				return defenseType;
			}
			set	
			{
				defenseType = value;
				DictionaryUtil.Add(QueryParameters, "DefenseType", value);
			}
		}

		public int? RuleStatus
		{
			get
			{
				return ruleStatus;
			}
			set	
			{
				ruleStatus = value;
				DictionaryUtil.Add(QueryParameters, "RuleStatus", value.ToString());
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

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyProtectionRuleStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyProtectionRuleStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
