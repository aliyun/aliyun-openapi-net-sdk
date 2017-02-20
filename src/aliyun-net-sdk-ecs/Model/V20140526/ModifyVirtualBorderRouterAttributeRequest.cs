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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyVirtualBorderRouterAttributeRequest : RpcAcsRequest<ModifyVirtualBorderRouterAttributeResponse>
    {
        public ModifyVirtualBorderRouterAttributeRequest()
            : base("Ecs", "2014-05-26", "ModifyVirtualBorderRouterAttribute")
        {
        }

		private string _vbrId;

		private int? _vlanId;

		private string _circuitCode;

		private string _localGatewayIp;

		private string _peerGatewayIp;

		private string _peeringSubnetMask;

		private string _description;

		private string _name;

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _clientToken;

		private string _ownerAccount;

		private string _userCidr;

		public string VbrId
		{
			get
			{
				return _vbrId;
			}
			set	
			{
				_vbrId = value;
				DictionaryUtil.Add(QueryParameters, "VbrId", value);
			}
		}

		public int? VlanId
		{
			get
			{
				return _vlanId;
			}
			set	
			{
				_vlanId = value;
				DictionaryUtil.Add(QueryParameters, "VlanId", value.ToString());
			}
		}

		public string CircuitCode
		{
			get
			{
				return _circuitCode;
			}
			set	
			{
				_circuitCode = value;
				DictionaryUtil.Add(QueryParameters, "CircuitCode", value);
			}
		}

		public string LocalGatewayIp
		{
			get
			{
				return _localGatewayIp;
			}
			set	
			{
				_localGatewayIp = value;
				DictionaryUtil.Add(QueryParameters, "LocalGatewayIp", value);
			}
		}

		public string PeerGatewayIp
		{
			get
			{
				return _peerGatewayIp;
			}
			set	
			{
				_peerGatewayIp = value;
				DictionaryUtil.Add(QueryParameters, "PeerGatewayIp", value);
			}
		}

		public string PeeringSubnetMask
		{
			get
			{
				return _peeringSubnetMask;
			}
			set	
			{
				_peeringSubnetMask = value;
				DictionaryUtil.Add(QueryParameters, "PeeringSubnetMask", value);
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set	
			{
				_description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set	
			{
				_name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return _clientToken;
			}
			set	
			{
				_clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string UserCidr
		{
			get
			{
				return _userCidr;
			}
			set	
			{
				_userCidr = value;
				DictionaryUtil.Add(QueryParameters, "UserCidr", value);
			}
		}

        public override ModifyVirtualBorderRouterAttributeResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyVirtualBorderRouterAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}