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
    public class CreateVSwitchRequest : RpcAcsRequest<CreateVSwitchResponse>
    {
        public CreateVSwitchRequest()
            : base("Ecs", "2014-05-26", "CreateVSwitch")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _zoneId;

		private string _cidrBlock;

		private string _vpcId;

		private string _vSwitchName;

		private string _description;

		private string _clientToken;

		private string _ownerAccount;

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

		public string ZoneId
		{
			get
			{
				return _zoneId;
			}
			set	
			{
				_zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string CidrBlock
		{
			get
			{
				return _cidrBlock;
			}
			set	
			{
				_cidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "CidrBlock", value);
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

		public string VSwitchName
		{
			get
			{
				return _vSwitchName;
			}
			set	
			{
				_vSwitchName = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchName", value);
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

        public override CreateVSwitchResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateVSwitchResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}