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
using Aliyun.Acs.Dds.Transform;
using Aliyun.Acs.Dds.Transform.V20151201;

namespace Aliyun.Acs.Dds.Model.V20151201
{
    public class CreateShardingDBInstanceRequest : RpcAcsRequest<CreateShardingDBInstanceResponse>
    {
        public CreateShardingDBInstanceRequest()
            : base("Dds", "2015-12-01", "CreateShardingDBInstance", "dds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string engineVersion;

		private string networkType;

		private List<int?> replicaSets = new List<int?>(){ };

		private string storageEngine;

		private string resourceGroupId;

		private string securityToken;

		private string engine;

		private string dBInstanceDescription;

		private int? period;

		private string restoreTime;

		private string resourceOwnerAccount;

		private string srcDBInstanceId;

		private string ownerAccount;

		private List<int?> configServers = new List<int?>(){ };

		private long? ownerId;

		private string securityIPList;

		private string vSwitchId;

		private List<string> mongoss = new List<string>(){ };

		private string accountPassword;

		private string autoRenew;

		private string vpcId;

		private string zoneId;

		private string protocolType;

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

		public List<int?> ReplicaSets
		{
			get
			{
				return replicaSets;
			}

			set
			{
				replicaSets = value;
				if(replicaSets != null)
				{
					for (int depth1 = 0; depth1 < replicaSets.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"ReplicaSet." + (depth1 + 1), replicaSets[depth1]);
						DictionaryUtil.Add(QueryParameters,"ReplicaSet." + (depth1 + 1), replicaSets[depth1]);
						DictionaryUtil.Add(QueryParameters,"ReplicaSet." + (depth1 + 1), replicaSets[depth1]);
					}
				}
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

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
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

		public List<int?> ConfigServers
		{
			get
			{
				return configServers;
			}

			set
			{
				configServers = value;
				if(configServers != null)
				{
					for (int depth1 = 0; depth1 < configServers.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"ConfigServer." + (depth1 + 1), configServers[depth1]);
						DictionaryUtil.Add(QueryParameters,"ConfigServer." + (depth1 + 1), configServers[depth1]);
					}
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

		public List<string> Mongoss
		{
			get
			{
				return mongoss;
			}

			set
			{
				mongoss = value;
				if(mongoss != null)
				{
					for (int depth1 = 0; depth1 < mongoss.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Mongos." + (depth1 + 1), mongoss[depth1]);
					}
				}
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

		public string AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value);
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

		public string ProtocolType
		{
			get
			{
				return protocolType;
			}
			set	
			{
				protocolType = value;
				DictionaryUtil.Add(QueryParameters, "ProtocolType", value);
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

			private int? readonlyReplicas;

			private int? storage;

			private string class_;

			public int? ReadonlyReplicas
			{
				get
				{
					return readonlyReplicas;
				}
				set	
				{
					readonlyReplicas = value;
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

			public string Class_
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

		public class ConfigServer
		{

			private int? storage;

			private string class_;

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

			public string Class_
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

		public class Mongos
		{

			private string class_;

			public string Class_
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

        public override CreateShardingDBInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateShardingDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
