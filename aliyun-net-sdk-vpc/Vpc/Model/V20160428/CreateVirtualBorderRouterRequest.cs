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
    public class CreateVirtualBorderRouterRequest : RpcAcsRequest<CreateVirtualBorderRouterResponse>
    {
        public CreateVirtualBorderRouterRequest()
            : base("Vpc", "2016-04-28", "CreateVirtualBorderRouter", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string circuitCode;

		private int? vlanId;

		private string clientToken;

		private bool? enableIpv6;

		private string description;

		private string peerGatewayIp;

		private string peerIpv6GatewayIp;

		private string peeringSubnetMask;

		private string localGatewayIp;

		private string peeringIpv6SubnetMask;

		private string resourceOwnerAccount;

		private long? bandwidth;

		private string ownerAccount;

		private long? ownerId;

		private string physicalConnectionId;

		private string localIpv6GatewayIp;

		private string name;

		private long? vbrOwnerId;

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

		public string CircuitCode
		{
			get
			{
				return circuitCode;
			}
			set	
			{
				circuitCode = value;
				DictionaryUtil.Add(QueryParameters, "CircuitCode", value);
			}
		}

		public int? VlanId
		{
			get
			{
				return vlanId;
			}
			set	
			{
				vlanId = value;
				DictionaryUtil.Add(QueryParameters, "VlanId", value.ToString());
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

		public bool? EnableIpv6
		{
			get
			{
				return enableIpv6;
			}
			set	
			{
				enableIpv6 = value;
				DictionaryUtil.Add(QueryParameters, "EnableIpv6", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string PeerGatewayIp
		{
			get
			{
				return peerGatewayIp;
			}
			set	
			{
				peerGatewayIp = value;
				DictionaryUtil.Add(QueryParameters, "PeerGatewayIp", value);
			}
		}

		public string PeerIpv6GatewayIp
		{
			get
			{
				return peerIpv6GatewayIp;
			}
			set	
			{
				peerIpv6GatewayIp = value;
				DictionaryUtil.Add(QueryParameters, "PeerIpv6GatewayIp", value);
			}
		}

		public string PeeringSubnetMask
		{
			get
			{
				return peeringSubnetMask;
			}
			set	
			{
				peeringSubnetMask = value;
				DictionaryUtil.Add(QueryParameters, "PeeringSubnetMask", value);
			}
		}

		public string LocalGatewayIp
		{
			get
			{
				return localGatewayIp;
			}
			set	
			{
				localGatewayIp = value;
				DictionaryUtil.Add(QueryParameters, "LocalGatewayIp", value);
			}
		}

		public string PeeringIpv6SubnetMask
		{
			get
			{
				return peeringIpv6SubnetMask;
			}
			set	
			{
				peeringIpv6SubnetMask = value;
				DictionaryUtil.Add(QueryParameters, "PeeringIpv6SubnetMask", value);
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

		public long? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value.ToString());
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

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string PhysicalConnectionId
		{
			get
			{
				return physicalConnectionId;
			}
			set	
			{
				physicalConnectionId = value;
				DictionaryUtil.Add(QueryParameters, "PhysicalConnectionId", value);
			}
		}

		public string LocalIpv6GatewayIp
		{
			get
			{
				return localIpv6GatewayIp;
			}
			set	
			{
				localIpv6GatewayIp = value;
				DictionaryUtil.Add(QueryParameters, "LocalIpv6GatewayIp", value);
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

		public long? VbrOwnerId
		{
			get
			{
				return vbrOwnerId;
			}
			set	
			{
				vbrOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "VbrOwnerId", value.ToString());
			}
		}

        public override CreateVirtualBorderRouterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVirtualBorderRouterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
