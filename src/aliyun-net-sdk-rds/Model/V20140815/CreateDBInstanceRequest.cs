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
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CreateDBInstanceRequest : RpcAcsRequest<CreateDBInstanceResponse>
    {
        public CreateDBInstanceRequest()
            : base("Rds", "2014-08-15", "CreateDBInstance")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _clientToken;

		private string _engine;

		private string _engineVersion;

		private string _dBInstanceClass;

		private int? _dBInstanceStorage;

		private string _systemDBCharset;

		private string _dBInstanceNetType;

		private string _dBInstanceDescription;

		private string _securityIpList;

		private string _payType;

		private string _zoneId;

		private string _instanceNetworkType;

		private string _connectionMode;

		private string _vPcId;

		private string _vSwitchId;

		private string _privateIpAddress;

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

		public string Engine
		{
			get
			{
				return _engine;
			}
			set	
			{
				_engine = value;
				DictionaryUtil.Add(QueryParameters, "Engine", value);
			}
		}

		public string EngineVersion
		{
			get
			{
				return _engineVersion;
			}
			set	
			{
				_engineVersion = value;
				DictionaryUtil.Add(QueryParameters, "EngineVersion", value);
			}
		}

		public string DBInstanceClass
		{
			get
			{
				return _dBInstanceClass;
			}
			set	
			{
				_dBInstanceClass = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceClass", value);
			}
		}

		public int? DBInstanceStorage
		{
			get
			{
				return _dBInstanceStorage;
			}
			set	
			{
				_dBInstanceStorage = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceStorage", value.ToString());
			}
		}

		public string SystemDBCharset
		{
			get
			{
				return _systemDBCharset;
			}
			set	
			{
				_systemDBCharset = value;
				DictionaryUtil.Add(QueryParameters, "SystemDBCharset", value);
			}
		}

		public string DBInstanceNetType
		{
			get
			{
				return _dBInstanceNetType;
			}
			set	
			{
				_dBInstanceNetType = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceNetType", value);
			}
		}

		public string DBInstanceDescription
		{
			get
			{
				return _dBInstanceDescription;
			}
			set	
			{
				_dBInstanceDescription = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceDescription", value);
			}
		}

		public string SecurityIpList
		{
			get
			{
				return _securityIpList;
			}
			set	
			{
				_securityIpList = value;
				DictionaryUtil.Add(QueryParameters, "SecurityIPList", value);
			}
		}

		public string PayType
		{
			get
			{
				return _payType;
			}
			set	
			{
				_payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
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

		public string InstanceNetworkType
		{
			get
			{
				return _instanceNetworkType;
			}
			set	
			{
				_instanceNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceNetworkType", value);
			}
		}

		public string ConnectionMode
		{
			get
			{
				return _connectionMode;
			}
			set	
			{
				_connectionMode = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionMode", value);
			}
		}

		public string VpcId
		{
			get
			{
				return _vPcId;
			}
			set	
			{
				_vPcId = value;
				DictionaryUtil.Add(QueryParameters, "VPCId", value);
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

		public string PrivateIpAddress
		{
			get
			{
				return _privateIpAddress;
			}
			set	
			{
				_privateIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "PrivateIpAddress", value);
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

        public override CreateDBInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}