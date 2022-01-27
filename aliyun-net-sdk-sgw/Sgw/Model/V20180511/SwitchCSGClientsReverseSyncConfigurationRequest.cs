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
    public class SwitchCSGClientsReverseSyncConfigurationRequest : RpcAcsRequest<SwitchCSGClientsReverseSyncConfigurationResponse>
    {
        public SwitchCSGClientsReverseSyncConfigurationRequest()
            : base("sgw", "2018-05-11", "SwitchCSGClientsReverseSyncConfiguration", "hcs_sgw", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? reverseSyncInternalSecond;

		private List<string> clientIds = new List<string>(){ };

		private string clientRegionId;

		private bool? isReverseSync;

		private string securityToken;

		[JsonProperty(PropertyName = "ReverseSyncInternalSecond")]
		public int? ReverseSyncInternalSecond
		{
			get
			{
				return reverseSyncInternalSecond;
			}
			set	
			{
				reverseSyncInternalSecond = value;
				DictionaryUtil.Add(QueryParameters, "ReverseSyncInternalSecond", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ClientIds")]
		public List<string> ClientIds
		{
			get
			{
				return clientIds;
			}

			set
			{
				clientIds = value;
				if(clientIds != null)
				{
					for (int depth1 = 0; depth1 < clientIds.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"ClientIds." + (depth1 + 1), clientIds[depth1]);
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

		[JsonProperty(PropertyName = "IsReverseSync")]
		public bool? IsReverseSync
		{
			get
			{
				return isReverseSync;
			}
			set	
			{
				isReverseSync = value;
				DictionaryUtil.Add(QueryParameters, "IsReverseSync", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SwitchCSGClientsReverseSyncConfigurationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SwitchCSGClientsReverseSyncConfigurationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
