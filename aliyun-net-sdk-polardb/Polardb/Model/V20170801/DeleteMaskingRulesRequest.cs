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
using Aliyun.Acs.polardb.Transform;
using Aliyun.Acs.polardb.Transform.V20170801;

namespace Aliyun.Acs.polardb.Model.V20170801
{
    public class DeleteMaskingRulesRequest : RpcAcsRequest<DeleteMaskingRulesResponse>
    {
        public DeleteMaskingRulesRequest()
            : base("polardb", "2017-08-01", "DeleteMaskingRules", "polardb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string interfaceVersion;

		private string dBClusterId;

		private string ruleNameList;

		public string InterfaceVersion
		{
			get
			{
				return interfaceVersion;
			}
			set	
			{
				interfaceVersion = value;
				DictionaryUtil.Add(QueryParameters, "InterfaceVersion", value);
			}
		}

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterId", value);
			}
		}

		public string RuleNameList
		{
			get
			{
				return ruleNameList;
			}
			set	
			{
				ruleNameList = value;
				DictionaryUtil.Add(QueryParameters, "RuleNameList", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteMaskingRulesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteMaskingRulesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
