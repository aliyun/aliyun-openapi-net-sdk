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
    public class CreateProtectionModuleRuleRequest : RpcAcsRequest<CreateProtectionModuleRuleResponse>
    {
        public CreateProtectionModuleRuleRequest()
            : base("waf-openapi", "2018-01-17", "CreateProtectionModuleRule", "waf", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string rule;

		private string defense;

		private string instanceId;

		private string domain;

		private string region;

		public string Rule
		{
			get
			{
				return rule;
			}
			set	
			{
				rule = value;
				DictionaryUtil.Add(QueryParameters, "Rule", value);
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

        public override CreateProtectionModuleRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateProtectionModuleRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
