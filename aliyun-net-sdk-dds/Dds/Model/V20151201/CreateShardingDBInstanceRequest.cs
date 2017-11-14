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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Dds.Transform;
using Aliyun.Acs.Dds.Transform.V20151201;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Model.V20151201
{
    public class CreateShardingDBInstanceRequest : RpcAcsRequest<CreateShardingDBInstanceResponse>
    {
        public CreateShardingDBInstanceRequest()
            : base("Dds", "2015-12-01", "CreateShardingDBInstance", "dds", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string engineVersion;

		private string networkType;

		private List<ReplicaSet> replicaSets;

		private string accessKeyId;

		private string storageEngine;

		private string securityToken;

		private string engine;

		private string action;

		private string dBInstanceDescription;

		private int? period;

		private string restoreTime;

		private string resourceOwnerAccount;

		private string srcDBInstanceId;

		private string ownerAccount;

		private List<ConfigServer> configServers;

		private long? ownerId;

		private List<Mongos> mongoss;

		private string securityIPList;

		private string vSwitchId;

		private string accountPassword;

		private string vpcId;

		private string zoneId;

		private string chargeType;

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

		public List<ReplicaSet> ReplicaSets
		{
			get
			{
				return replicaSets;
			}

			set
			{
				replicaSets = value;
				for (int i = 0; i < replicaSets.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ReplicaSet." + (i + 1) + ".Class", replicaSets[i].Class);
					DictionaryUtil.Add(QueryParameters,"ReplicaSet." + (i + 1) + ".Storage", replicaSets[i].Storage);
				}
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string StorageEngine
		{
			get
			{
				return storageEngine;
			}
			set	
			{
				storageEngine = value;
				DictionaryUtil.Add(QueryParameters, "StorageEngine", value);
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

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
				DictionaryUtil.Add(QueryParameters, "Engine", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string DBInstanceDescription
		{
			get
			{
				return dBInstanceDescription;
			}
			set	
			{
				dBInstanceDescription = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceDescription", value);
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public string RestoreTime
		{
			get
			{
				return restoreTime;
			}
			set	
			{
				restoreTime = value;
				DictionaryUtil.Add(QueryParameters, "RestoreTime", value);
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

		public List<ConfigServer> ConfigServers
		{
			get
			{
				return configServers;
			}

			set
			{
				configServers = value;
				for (int i = 0; i < configServers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ConfigServer." + (i + 1) + ".Class", configServers[i].Class);
					DictionaryUtil.Add(QueryParameters,"ConfigServer." + (i + 1) + ".Storage", configServers[i].Storage);
				}
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

		public List<Mongos> Mongoss
		{
			get
			{
				return mongoss;
			}

			set
			{
				mongoss = value;
				for (int i = 0; i < mongoss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Mongos." + (i + 1) + ".Class", mongoss[i].Class);
				}
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

		public string AccountPassword
		{
			get
			{
				return accountPassword;
			}
			set	
			{
				accountPassword = value;
				DictionaryUtil.Add(QueryParameters, "AccountPassword", value);
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

		public class ReplicaSet
		{

			private string class_;

			private int? storage;

			public string Class
			{
				get
				{
					return class_;
				}
				set	
				{
					class_ = value;
				}
			}

			public int? Storage
			{
				get
				{
					return storage;
				}
				set	
				{
					storage = value;
				}
			}
		}

		public class ConfigServer
		{

			private string class_;

			private int? storage;

			public string Class
			{
				get
				{
					return class_;
				}
				set	
				{
					class_ = value;
				}
			}

			public int? Storage
			{
				get
				{
					return storage;
				}
				set	
				{
					storage = value;
				}
			}
		}

		public class Mongos
		{

			private string class_;

			public string Class
			{
				get
				{
					return class_;
				}
				set	
				{
					class_ = value;
				}
			}
		}

        public override CreateShardingDBInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateShardingDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}