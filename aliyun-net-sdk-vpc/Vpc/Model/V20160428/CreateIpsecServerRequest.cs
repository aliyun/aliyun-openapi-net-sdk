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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class CreateIpsecServerRequest : RpcAcsRequest<CreateIpsecServerResponse>
    {
        public CreateIpsecServerRequest()
            : base("Vpc", "2016-04-28", "CreateIpsecServer", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string ikeConfig;

		private string clientToken;

		private string ipsecConfig;

		private string psk;

		private string localSubnet;

		private bool? effectImmediately;

		private string clientIpPool;

		private string dryRun;

		private string vpnGatewayId;

		private bool? pskEnabled;

		private string ipSecServerName;

		public string IkeConfig
		{
			get
			{
				return ikeConfig;
			}
			set	
			{
				ikeConfig = value;
				DictionaryUtil.Add(QueryParameters, "IkeConfig", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string IpsecConfig
		{
			get
			{
				return ipsecConfig;
			}
			set	
			{
				ipsecConfig = value;
				DictionaryUtil.Add(QueryParameters, "IpsecConfig", value);
			}
		}

		public string Psk
		{
			get
			{
				return psk;
			}
			set	
			{
				psk = value;
				DictionaryUtil.Add(QueryParameters, "Psk", value);
			}
		}

		public string LocalSubnet
		{
			get
			{
				return localSubnet;
			}
			set	
			{
				localSubnet = value;
				DictionaryUtil.Add(QueryParameters, "LocalSubnet", value);
			}
		}

		public bool? EffectImmediately
		{
			get
			{
				return effectImmediately;
			}
			set	
			{
				effectImmediately = value;
				DictionaryUtil.Add(QueryParameters, "EffectImmediately", value.ToString());
			}
		}

		public string ClientIpPool
		{
			get
			{
				return clientIpPool;
			}
			set	
			{
				clientIpPool = value;
				DictionaryUtil.Add(QueryParameters, "ClientIpPool", value);
			}
		}

		public string DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value);
			}
		}

		public string VpnGatewayId
		{
			get
			{
				return vpnGatewayId;
			}
			set	
			{
				vpnGatewayId = value;
				DictionaryUtil.Add(QueryParameters, "VpnGatewayId", value);
			}
		}

		public bool? PskEnabled
		{
			get
			{
				return pskEnabled;
			}
			set	
			{
				pskEnabled = value;
				DictionaryUtil.Add(QueryParameters, "PskEnabled", value.ToString());
			}
		}

		public string IpSecServerName
		{
			get
			{
				return ipSecServerName;
			}
			set	
			{
				ipSecServerName = value;
				DictionaryUtil.Add(QueryParameters, "IpSecServerName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateIpsecServerResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateIpsecServerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
