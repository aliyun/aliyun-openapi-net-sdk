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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CloneDBInstanceRequest : RpcAcsRequest<CloneDBInstanceResponse>
    {
        public CloneDBInstanceRequest()
            : base("Rds", "2014-08-15", "CloneDBInstance")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? dBInstanceStorage;

		private bool? deletionProtection;

		private string backupType;

		private string period;

		private string backupId;

		private string dBInstanceClass;

		private string vSwitchId;

		private string privateIpAddress;

		private string zoneId;

		private string instanceNetworkType;

		private string zoneIdSlave1;

		private string zoneIdSlave2;

		private string tableMeta;

		private string dBInstanceId;

		private string dBInstanceStorageType;

		private string dedicatedHostGroupId;

		private string restoreTime;

		private bool? autoPay;

		private ServerlessConfig serverlessConfig_;

		private string restoreTable;

		private int? usedTime;

		private bool? burstingEnabled;

		private string dbNames;

		private string vPCId;

		private string category;

		private string payType;

		private string bpeEnabled;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "DBInstanceStorage")]
		public int? DBInstanceStorage
		{
			get
			{
				return dBInstanceStorage;
			}
			set	
			{
				dBInstanceStorage = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceStorage", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DeletionProtection")]
		public bool? DeletionProtection
		{
			get
			{
				return deletionProtection;
			}
			set	
			{
				deletionProtection = value;
				DictionaryUtil.Add(QueryParameters, "DeletionProtection", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "BackupType")]
		public string BackupType
		{
			get
			{
				return backupType;
			}
			set	
			{
				backupType = value;
				DictionaryUtil.Add(QueryParameters, "BackupType", value);
			}
		}

		[JsonProperty(PropertyName = "Period")]
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

		[JsonProperty(PropertyName = "BackupId")]
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

		[JsonProperty(PropertyName = "DBInstanceClass")]
		public string DBInstanceClass
		{
			get
			{
				return dBInstanceClass;
			}
			set	
			{
				dBInstanceClass = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceClass", value);
			}
		}

		[JsonProperty(PropertyName = "VSwitchId")]
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

		[JsonProperty(PropertyName = "PrivateIpAddress")]
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

		[JsonProperty(PropertyName = "ZoneId")]
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

		[JsonProperty(PropertyName = "InstanceNetworkType")]
		public string InstanceNetworkType
		{
			get
			{
				return instanceNetworkType;
			}
			set	
			{
				instanceNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceNetworkType", value);
			}
		}

		[JsonProperty(PropertyName = "ZoneIdSlave1")]
		public string ZoneIdSlave1
		{
			get
			{
				return zoneIdSlave1;
			}
			set	
			{
				zoneIdSlave1 = value;
				DictionaryUtil.Add(QueryParameters, "ZoneIdSlave1", value);
			}
		}

		[JsonProperty(PropertyName = "ZoneIdSlave2")]
		public string ZoneIdSlave2
		{
			get
			{
				return zoneIdSlave2;
			}
			set	
			{
				zoneIdSlave2 = value;
				DictionaryUtil.Add(QueryParameters, "ZoneIdSlave2", value);
			}
		}

		[JsonProperty(PropertyName = "TableMeta")]
		public string TableMeta
		{
			get
			{
				return tableMeta;
			}
			set	
			{
				tableMeta = value;
				DictionaryUtil.Add(QueryParameters, "TableMeta", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceId")]
		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceStorageType")]
		public string DBInstanceStorageType
		{
			get
			{
				return dBInstanceStorageType;
			}
			set	
			{
				dBInstanceStorageType = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceStorageType", value);
			}
		}

		[JsonProperty(PropertyName = "DedicatedHostGroupId")]
		public string DedicatedHostGroupId
		{
			get
			{
				return dedicatedHostGroupId;
			}
			set	
			{
				dedicatedHostGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "RestoreTime")]
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

		[JsonProperty(PropertyName = "AutoPay")]
		public bool? AutoPay
		{
			get
			{
				return autoPay;
			}
			set	
			{
				autoPay = value;
				DictionaryUtil.Add(QueryParameters, "AutoPay", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ServerlessConfig")]
		public ServerlessConfig ServerlessConfig_
		{
			get
			{
				return serverlessConfig_;
			}

			set
			{
				serverlessConfig_ = value;
				DictionaryUtil.Add(QueryParameters, "ServerlessConfig", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "RestoreTable")]
		public string RestoreTable
		{
			get
			{
				return restoreTable;
			}
			set	
			{
				restoreTable = value;
				DictionaryUtil.Add(QueryParameters, "RestoreTable", value);
			}
		}

		[JsonProperty(PropertyName = "UsedTime")]
		public int? UsedTime
		{
			get
			{
				return usedTime;
			}
			set	
			{
				usedTime = value;
				DictionaryUtil.Add(QueryParameters, "UsedTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "BurstingEnabled")]
		public bool? BurstingEnabled
		{
			get
			{
				return burstingEnabled;
			}
			set	
			{
				burstingEnabled = value;
				DictionaryUtil.Add(QueryParameters, "BurstingEnabled", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DbNames")]
		public string DbNames
		{
			get
			{
				return dbNames;
			}
			set	
			{
				dbNames = value;
				DictionaryUtil.Add(QueryParameters, "DbNames", value);
			}
		}

		[JsonProperty(PropertyName = "VPCId")]
		public string VPCId
		{
			get
			{
				return vPCId;
			}
			set	
			{
				vPCId = value;
				DictionaryUtil.Add(QueryParameters, "VPCId", value);
			}
		}

		[JsonProperty(PropertyName = "Category")]
		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
				DictionaryUtil.Add(QueryParameters, "Category", value);
			}
		}

		[JsonProperty(PropertyName = "PayType")]
		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
			}
		}

		[JsonProperty(PropertyName = "BpeEnabled")]
		public string BpeEnabled
		{
			get
			{
				return bpeEnabled;
			}
			set	
			{
				bpeEnabled = value;
				DictionaryUtil.Add(QueryParameters, "BpeEnabled", value);
			}
		}

		public class ServerlessConfig
		{

			private double? minCapacity;

			private double? maxCapacity;

			private bool? autoPause;

			private bool? switchForce;

			[JsonProperty(PropertyName = "MinCapacity")]
			public double? MinCapacity
			{
				get
				{
					return minCapacity;
				}
				set	
				{
					minCapacity = value;
				}
			}

			[JsonProperty(PropertyName = "MaxCapacity")]
			public double? MaxCapacity
			{
				get
				{
					return maxCapacity;
				}
				set	
				{
					maxCapacity = value;
				}
			}

			[JsonProperty(PropertyName = "AutoPause")]
			public bool? AutoPause
			{
				get
				{
					return autoPause;
				}
				set	
				{
					autoPause = value;
				}
			}

			[JsonProperty(PropertyName = "SwitchForce")]
			public bool? SwitchForce
			{
				get
				{
					return switchForce;
				}
				set	
				{
					switchForce = value;
				}
			}
		}

        public override CloneDBInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CloneDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
