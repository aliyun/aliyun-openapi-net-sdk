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
    public class CreateVpnAttachmentRequest : RpcAcsRequest<CreateVpnAttachmentResponse>
    {
        public CreateVpnAttachmentRequest()
            : base("Vpc", "2016-04-28", "CreateVpnAttachment", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string ikeConfig;

		private bool? autoConfigRoute;

		private long? resourceOwnerId;

		private string clientToken;

		private string ipsecConfig;

		private string bgpConfig;

		private string networkType;

		private string healthCheckConfig;

		private string customerGatewayId;

		private string localSubnet;

		private string remoteCaCert;

		private string remoteSubnet;

		private bool? effectImmediately;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private bool? enableDpd;

		private List<string> tagss = new List<string>(){ };

		private string name;

		private bool? enableNatTraversal;

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

		public bool? AutoConfigRoute
		{
			get
			{
				return autoConfigRoute;
			}
			set	
			{
				autoConfigRoute = value;
				DictionaryUtil.Add(QueryParameters, "AutoConfigRoute", value.ToString());
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
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

		public string BgpConfig
		{
			get
			{
				return bgpConfig;
			}
			set	
			{
				bgpConfig = value;
				DictionaryUtil.Add(QueryParameters, "BgpConfig", value);
			}
		}

		public string NetworkType
		{
			get
			{
				return networkType;
			}
			set	
			{
				networkType = value;
				DictionaryUtil.Add(QueryParameters, "NetworkType", value);
			}
		}

		public string HealthCheckConfig
		{
			get
			{
				return healthCheckConfig;
			}
			set	
			{
				healthCheckConfig = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckConfig", value);
			}
		}

		public string CustomerGatewayId
		{
			get
			{
				return customerGatewayId;
			}
			set	
			{
				customerGatewayId = value;
				DictionaryUtil.Add(QueryParameters, "CustomerGatewayId", value);
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

		public string RemoteCaCert
		{
			get
			{
				return remoteCaCert;
			}
			set	
			{
				remoteCaCert = value;
				DictionaryUtil.Add(QueryParameters, "RemoteCaCert", value);
			}
		}

		public string RemoteSubnet
		{
			get
			{
				return remoteSubnet;
			}
			set	
			{
				remoteSubnet = value;
				DictionaryUtil.Add(QueryParameters, "RemoteSubnet", value);
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

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public bool? EnableDpd
		{
			get
			{
				return enableDpd;
			}
			set	
			{
				enableDpd = value;
				DictionaryUtil.Add(QueryParameters, "EnableDpd", value.ToString());
			}
		}

		public List<string> Tagss
		{
			get
			{
				return tagss;
			}

			set
			{
				tagss = value;
				if(tagss != null)
				{
					for (int depth1 = 0; depth1 < tagss.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tags." + (depth1 + 1), tagss[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tags." + (depth1 + 1), tagss[depth1]);
					}
				}
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public bool? EnableNatTraversal
		{
			get
			{
				return enableNatTraversal;
			}
			set	
			{
				enableNatTraversal = value;
				DictionaryUtil.Add(QueryParameters, "EnableNatTraversal", value.ToString());
			}
		}

		public class Tags
		{

			private string value_;

			private string key;

			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateVpnAttachmentResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVpnAttachmentResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
