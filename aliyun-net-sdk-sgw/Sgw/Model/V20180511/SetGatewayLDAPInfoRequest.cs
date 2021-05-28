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
    public class SetGatewayLDAPInfoRequest : RpcAcsRequest<SetGatewayLDAPInfoResponse>
    {
        public SetGatewayLDAPInfoRequest()
            : base("sgw", "2018-05-11", "SetGatewayLDAPInfo", "hcs_sgw", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? isTls;

		private string password;

		private string rootDN;

		private string securityToken;

		private string serverIp;

		private string baseDN;

		private string gatewayId;

		private bool? isEnabled;

		public bool? IsTls
		{
			get
			{
				return isTls;
			}
			set	
			{
				isTls = value;
				DictionaryUtil.Add(QueryParameters, "IsTls", value.ToString());
			}
		}

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

		public string RootDN
		{
			get
			{
				return rootDN;
			}
			set	
			{
				rootDN = value;
				DictionaryUtil.Add(QueryParameters, "RootDN", value);
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

		public string BaseDN
		{
			get
			{
				return baseDN;
			}
			set	
			{
				baseDN = value;
				DictionaryUtil.Add(QueryParameters, "BaseDN", value);
			}
		}

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

        public override SetGatewayLDAPInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetGatewayLDAPInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
