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
using Aliyun.Acs.R_kvstore.Transform;
using Aliyun.Acs.R_kvstore.Transform.V20150101;

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
    public class CreateShardingInstanceRequest : RpcAcsRequest<CreateShardingInstanceResponse>
    {
        public CreateShardingInstanceRequest()
            : base("R-kvstore", "2015-01-01", "CreateShardingInstance", "redisa", "openAPI")
        {
        }

		private int? shardStorageQuantity;

		private long? resourceOwnerId;

		private string nodeType;

		private string couponNo;

		private string networkType;

		private string engineVersion;

		private string instanceClass;

		private long? capacity;

		private string password;

		private string shardReplicaClass;

		private string securityToken;

		private string incrementalBackupMode;

		private string instanceType;

		private string businessInfo;

		private string period;

		private string resourceOwnerAccount;

		private string srcDBInstanceId;

		private string ownerAccount;

		private string backupId;

		private long? ownerId;

		private string token;

		private int? shardQuantity;

		private string vSwitchId;

		private string privateIpAddress;

		private string securityIPList;

		private string instanceName;

		private int? shardReplicaQuantity;

		private string architectureType;

		private string vpcId;

		private string redisManagerClass;

		private string zoneId;

		private string chargeType;

		private int? proxyQuantity;

		private string config;

		private string proxyMode;

		public int? ShardStorageQuantity
		{
			get
			{
				return shardStorageQuantity;
			}
			set	
			{
				shardStorageQuantity = value;
				DictionaryUtil.Add(QueryParameters, "ShardStorageQuantity", value.ToString());
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

		public string NodeType
		{
			get
			{
				return nodeType;
			}
			set	
			{
				nodeType = value;
				DictionaryUtil.Add(QueryParameters, "NodeType", value);
			}
		}

		public string CouponNo
		{
			get
			{
				return couponNo;
			}
			set	
			{
				couponNo = value;
				DictionaryUtil.Add(QueryParameters, "CouponNo", value);
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

		public string EngineVersion
		{
			get
			{
				return engineVersion;
			}
			set	
			{
				engineVersion = value;
				DictionaryUtil.Add(QueryParameters, "EngineVersion", value);
			}
		}

		public string InstanceClass
		{
			get
			{
				return instanceClass;
			}
			set	
			{
				instanceClass = value;
				DictionaryUtil.Add(QueryParameters, "InstanceClass", value);
			}
		}

		public long? Capacity
		{
			get
			{
				return capacity;
			}
			set	
			{
				capacity = value;
				DictionaryUtil.Add(QueryParameters, "Capacity", value.ToString());
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

		public string ShardReplicaClass
		{
			get
			{
				return shardReplicaClass;
			}
			set	
			{
				shardReplicaClass = value;
				DictionaryUtil.Add(QueryParameters, "ShardReplicaClass", value);
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

		public string IncrementalBackupMode
		{
			get
			{
				return incrementalBackupMode;
			}
			set	
			{
				incrementalBackupMode = value;
				DictionaryUtil.Add(QueryParameters, "IncrementalBackupMode", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string BusinessInfo
		{
			get
			{
				return businessInfo;
			}
			set	
			{
				businessInfo = value;
				DictionaryUtil.Add(QueryParameters, "BusinessInfo", value);
			}
		}

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
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

		public string SrcDBInstanceId
		{
			get
			{
				return srcDBInstanceId;
			}
			set	
			{
				srcDBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "SrcDBInstanceId", value);
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

		public string BackupId
		{
			get
			{
				return backupId;
			}
			set	
			{
				backupId = value;
				DictionaryUtil.Add(QueryParameters, "BackupId", value);
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

		public string Token
		{
			get
			{
				return token;
			}
			set	
			{
				token = value;
				DictionaryUtil.Add(QueryParameters, "Token", value);
			}
		}

		public int? ShardQuantity
		{
			get
			{
				return shardQuantity;
			}
			set	
			{
				shardQuantity = value;
				DictionaryUtil.Add(QueryParameters, "ShardQuantity", value.ToString());
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string PrivateIpAddress
		{
			get
			{
				return privateIpAddress;
			}
			set	
			{
				privateIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "PrivateIpAddress", value);
			}
		}

		public string SecurityIPList
		{
			get
			{
				return securityIPList;
			}
			set	
			{
				securityIPList = value;
				DictionaryUtil.Add(QueryParameters, "SecurityIPList", value);
			}
		}

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
			}
		}

		public int? ShardReplicaQuantity
		{
			get
			{
				return shardReplicaQuantity;
			}
			set	
			{
				shardReplicaQuantity = value;
				DictionaryUtil.Add(QueryParameters, "ShardReplicaQuantity", value.ToString());
			}
		}

		public string ArchitectureType
		{
			get
			{
				return architectureType;
			}
			set	
			{
				architectureType = value;
				DictionaryUtil.Add(QueryParameters, "ArchitectureType", value);
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public string RedisManagerClass
		{
			get
			{
				return redisManagerClass;
			}
			set	
			{
				redisManagerClass = value;
				DictionaryUtil.Add(QueryParameters, "RedisManagerClass", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
				DictionaryUtil.Add(QueryParameters, "ChargeType", value);
			}
		}

		public int? ProxyQuantity
		{
			get
			{
				return proxyQuantity;
			}
			set	
			{
				proxyQuantity = value;
				DictionaryUtil.Add(QueryParameters, "ProxyQuantity", value.ToString());
			}
		}

		public string Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
				DictionaryUtil.Add(QueryParameters, "Config", value);
			}
		}

		public string ProxyMode
		{
			get
			{
				return proxyMode;
			}
			set	
			{
				proxyMode = value;
				DictionaryUtil.Add(QueryParameters, "ProxyMode", value);
			}
		}

        public override CreateShardingInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateShardingInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
