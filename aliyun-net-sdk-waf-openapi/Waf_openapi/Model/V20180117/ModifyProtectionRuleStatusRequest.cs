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
using Aliyun.Acs.waf_openapi.Transform.V20180117;

namespace Aliyun.Acs.waf_openapi.Model.V20180117
{
    public class ModifyProtectionRuleStatusRequest : RpcAcsRequest<ModifyProtectionRuleStatusResponse>
    {
        public ModifyProtectionRuleStatusRequest()
            : base("waf-openapi", "2018-01-17", "ModifyProtectionRuleStatus", "waf", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? lockVersion;

		private string defense;

		private long? id;

		private int? ruleStatus;

		private string instanceId;

		private string domain;

		private string region;

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

		public string Defense
		{
			get
			{
				return defense;
			}
			set	
			{
				defense = value;
				DictionaryUtil.Add(QueryParameters, "Defense", value);
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
