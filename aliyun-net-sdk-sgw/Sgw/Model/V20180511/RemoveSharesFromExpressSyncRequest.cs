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
using Aliyun.Acs.sgw.Transform;
using Aliyun.Acs.sgw.Transform.V20180511;

namespace Aliyun.Acs.sgw.Model.V20180511
{
    public class RemoveSharesFromExpressSyncRequest : RpcAcsRequest<RemoveSharesFromExpressSyncResponse>
    {
        public RemoveSharesFromExpressSyncRequest()
            : base("sgw", "2018-05-11", "RemoveSharesFromExpressSync", "hcs_sgw", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string expressSyncId;

		private string gatewayShares;

		private string securityToken;

		public string ExpressSyncId
		{
			get
			{
				return expressSyncId;
			}
			set	
			{
				expressSyncId = value;
				DictionaryUtil.Add(QueryParameters, "ExpressSyncId", value);
			}
		}

		public string GatewayShares
		{
			get
			{
				return gatewayShares;
			}
			set	
			{
				gatewayShares = value;
				DictionaryUtil.Add(QueryParameters, "GatewayShares", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

        public override RemoveSharesFromExpressSyncResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RemoveSharesFromExpressSyncResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
