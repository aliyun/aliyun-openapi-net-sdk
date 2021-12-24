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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.sgw.Transform;
using Aliyun.Acs.sgw.Transform.V20180511;

namespace Aliyun.Acs.sgw.Model.V20180511
{
    public class DeployCSGClientsRequest : RpcAcsRequest<DeployCSGClientsResponse>
    {
        public DeployCSGClientsRequest()
            : base("sgw", "2018-05-11", "DeployCSGClients", "hcs_sgw", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> ecsInstanceIds = new List<string>(){ };

		private string clientRegionId;

		private string securityToken;

		private string vpcId;

		[JsonProperty(PropertyName = "EcsInstanceIds")]
		public List<string> EcsInstanceIds
		{
			get
			{
				return ecsInstanceIds;
			}

			set
			{
				ecsInstanceIds = value;
				if(ecsInstanceIds != null)
				{
					for (int depth1 = 0; depth1 < ecsInstanceIds.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"EcsInstanceIds." + (depth1 + 1), ecsInstanceIds[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "ClientRegionId")]
		public string ClientRegionId
		{
			get
			{
				return clientRegionId;
			}
			set	
			{
				clientRegionId = value;
				DictionaryUtil.Add(QueryParameters, "ClientRegionId", value);
			}
		}

		[JsonProperty(PropertyName = "SecurityToken")]
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

		[JsonProperty(PropertyName = "VpcId")]
		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeployCSGClientsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeployCSGClientsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
