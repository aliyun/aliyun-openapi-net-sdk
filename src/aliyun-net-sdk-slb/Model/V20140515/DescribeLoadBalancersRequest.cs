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
using Aliyun.Acs.Slb.Transform.V20140515;

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class DescribeLoadBalancersRequest : RpcAcsRequest<DescribeLoadBalancersResponse>
    {
        public DescribeLoadBalancersRequest()
            : base("Slb", "2014-05-15", "DescribeLoadBalancers")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _serverId;

		private string _loadBalancerId;

		private string _addressType;

		private string _internetChargeType;

		private string _vpcId;

		private string _vSwitchId;

		private string _networkType;

		private string _address;

		private string _masterZoneId;

		private string _slaveZoneId;

		private string _ownerAccount;

		private string _accessKeyID;

		private string _tags;

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

		public string ServerId
		{
			get
			{
				return _serverId;
			}
			set	
			{
				_serverId = value;
				DictionaryUtil.Add(QueryParameters, "ServerId", value);
			}
		}

		public string LoadBalancerId
		{
			get
			{
				return _loadBalancerId;
			}
			set	
			{
				_loadBalancerId = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerId", value);
			}
		}

		public string AddressType
		{
			get
			{
				return _addressType;
			}
			set	
			{
				_addressType = value;
				DictionaryUtil.Add(QueryParameters, "AddressType", value);
			}
		}

		public string InternetChargeType
		{
			get
			{
				return _internetChargeType;
			}
			set	
			{
				_internetChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
			}
		}

		public string VpcId
		{
			get
			{
				return _vpcId;
			}
			set	
			{
				_vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public string VSwitchId
		{
			get
			{
				return _vSwitchId;
			}
			set	
			{
				_vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string NetworkType
		{
			get
			{
				return _networkType;
			}
			set	
			{
				_networkType = value;
				DictionaryUtil.Add(QueryParameters, "NetworkType", value);
			}
		}

		public string Address
		{
			get
			{
				return _address;
			}
			set	
			{
				_address = value;
				DictionaryUtil.Add(QueryParameters, "Address", value);
			}
		}

		public string MasterZoneId
		{
			get
			{
				return _masterZoneId;
			}
			set	
			{
				_masterZoneId = value;
				DictionaryUtil.Add(QueryParameters, "MasterZoneId", value);
			}
		}

		public string SlaveZoneId
		{
			get
			{
				return _slaveZoneId;
			}
			set	
			{
				_slaveZoneId = value;
				DictionaryUtil.Add(QueryParameters, "SlaveZoneId", value);
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

		public string AccessKeyID
		{
			get
			{
				return _accessKeyID;
			}
			set	
			{
				_accessKeyID = value;
				DictionaryUtil.Add(QueryParameters, "access_key_id", value);
			}
		}

		public string Tags
		{
			get
			{
				return _tags;
			}
			set	
			{
				_tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

        public override DescribeLoadBalancersResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeLoadBalancersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}