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
    public class SetGatewayADInfoRequest : RpcAcsRequest<SetGatewayADInfoResponse>
    {
        public SetGatewayADInfoRequest()
            : base("sgw", "2018-05-11", "SetGatewayADInfo", "hcs_sgw", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string password;

		private string securityToken;

		private string serverIp;

		private string gatewayId;

		private string username;

		private bool? isEnabled;

		[JsonProperty(PropertyName = "Password")]
		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
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

		[JsonProperty(PropertyName = "ServerIp")]
		public string ServerIp
		{
			get
			{
				return serverIp;
			}
			set	
			{
				serverIp = value;
				DictionaryUtil.Add(QueryParameters, "ServerIp", value);
			}
		}

		[JsonProperty(PropertyName = "GatewayId")]
		public string GatewayId
		{
			get
			{
				return gatewayId;
			}
			set	
			{
				gatewayId = value;
				DictionaryUtil.Add(QueryParameters, "GatewayId", value);
			}
		}

		[JsonProperty(PropertyName = "Username")]
		public string Username
		{
			get
			{
				return username;
			}
			set	
			{
				username = value;
				DictionaryUtil.Add(QueryParameters, "Username", value);
			}
		}

		[JsonProperty(PropertyName = "IsEnabled")]
		public bool? IsEnabled
		{
			get
			{
				return isEnabled;
			}
			set	
			{
				isEnabled = value;
				DictionaryUtil.Add(QueryParameters, "IsEnabled", value.ToString());
			}
		}

        public override SetGatewayADInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetGatewayADInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
