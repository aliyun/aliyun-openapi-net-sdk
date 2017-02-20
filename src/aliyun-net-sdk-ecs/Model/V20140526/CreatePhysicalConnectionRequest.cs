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
    public class CreatePhysicalConnectionRequest : RpcAcsRequest<CreatePhysicalConnectionResponse>
    {
        public CreatePhysicalConnectionRequest()
            : base("Ecs", "2014-05-26", "CreatePhysicalConnection")
        {
        }

		private string _accessPointId;

		private string _type;

		private string _lineOperator;

		private int? _bandwidth;

		private string _peerLocation;

		private string _portType;

		private string _redundantPhysicalConnectionId;

		private string _description;

		private string _name;

		private string _circuitCode;

		private string _clientToken;

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _ownerAccount;

		private string _userCidr;

		public string AccessPointId
		{
			get
			{
				return _accessPointId;
			}
			set	
			{
				_accessPointId = value;
				DictionaryUtil.Add(QueryParameters, "AccessPointId", value);
			}
		}

		public string Type
		{
			get
			{
				return _type;
			}
			set	
			{
				_type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string LineOperator
		{
			get
			{
				return _lineOperator;
			}
			set	
			{
				_lineOperator = value;
				DictionaryUtil.Add(QueryParameters, "LineOperator", value);
			}
		}

		public int? Bandwidth
		{
			get
			{
				return _bandwidth;
			}
			set	
			{
				_bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value.ToString());
			}
		}

		public string PeerLocation
		{
			get
			{
				return _peerLocation;
			}
			set	
			{
				_peerLocation = value;
				DictionaryUtil.Add(QueryParameters, "PeerLocation", value);
			}
		}

		public string PortType
		{
			get
			{
				return _portType;
			}
			set	
			{
				_portType = value;
				DictionaryUtil.Add(QueryParameters, "PortType", value);
			}
		}

		public string RedundantPhysicalConnectionId
		{
			get
			{
				return _redundantPhysicalConnectionId;
			}
			set	
			{
				_redundantPhysicalConnectionId = value;
				DictionaryUtil.Add(QueryParameters, "RedundantPhysicalConnectionId", value);
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

        public override CreatePhysicalConnectionResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreatePhysicalConnectionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}