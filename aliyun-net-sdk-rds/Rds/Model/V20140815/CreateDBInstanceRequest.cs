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
    public class CreateDBInstanceRequest : RpcAcsRequest<CreateDBInstanceResponse>
    {
        public CreateDBInstanceRequest()
            : base("Rds", "2014-08-15", "CreateDBInstance")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dBParamGroupId;

		private string babelfishConfig;

		private long? resourceOwnerId;

		private int? dBInstanceStorage;

		private string systemDBCharset;

		private string connectionString;

		private string engineVersion;

		private bool? deletionProtection;

		private string resourceGroupId;

		private string targetDedicatedHostIdForMaster;

		private string dBInstanceDescription;

		private List<string> tags = new List<string>(){ };

		private string businessInfo;

		private string period;

		private bool? dryRun;

		private string encryptionKey;

		private string dBInstanceClass;

		private string securityIPList;

		private string vSwitchId;

		private string privateIpAddress;

		private string targetDedicatedHostIdForLog;

		private string autoRenew;

		private string port;

		private string roleARN;

		private string zoneId;

		private string storageAutoScale;

		private string instanceNetworkType;

		private string connectionMode;

		private string clientToken;

		private string targetDedicatedHostIdForSlave;

		private string zoneIdSlave1;

		private string zoneIdSlave2;

		private string dBIsIgnoreCase;

		private string engine;

		private string dBTimeZone;

		private string dBInstanceStorageType;

		private string dedicatedHostGroupId;

		private string createStrategy;

		private string dBInstanceNetType;

		private int? amount;

		private bool? autoPay;

		private ServerlessConfig serverlessConfig_;

		private string usedTime;

		private bool? burstingEnabled;

		private string targetMinorVersion;

		private string userBackupId;

		private int? storageUpperBound;

		private int? storageThreshold;

		private string vPCId;

		private string category;

		private string payType;

		private string bpeEnabled;

		[JsonProperty(PropertyName = "DBParamGroupId")]
		public string DBParamGroupId
		{
			get
			{
				return dBParamGroupId;
			}
			set	
			{
				dBParamGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DBParamGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "BabelfishConfig")]
		public string BabelfishConfig
		{
			get
			{
				return babelfishConfig;
			}
			set	
			{
				babelfishConfig = value;
				DictionaryUtil.Add(QueryParameters, "BabelfishConfig", value);
			}
		}

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

		[JsonProperty(PropertyName = "SystemDBCharset")]
		public string SystemDBCharset
		{
			get
			{
				return systemDBCharset;
			}
			set	
			{
				systemDBCharset = value;
				DictionaryUtil.Add(QueryParameters, "SystemDBCharset", value);
			}
		}

		[JsonProperty(PropertyName = "ConnectionString")]
		public string ConnectionString
		{
			get
			{
				return connectionString;
			}
			set	
			{
				connectionString = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionString", value);
			}
		}

		[JsonProperty(PropertyName = "EngineVersion")]
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

		[JsonProperty(PropertyName = "ResourceGroupId")]
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

		[JsonProperty(PropertyName = "TargetDedicatedHostIdForMaster")]
		public string TargetDedicatedHostIdForMaster
		{
			get
			{
				return targetDedicatedHostIdForMaster;
			}
			set	
			{
				targetDedicatedHostIdForMaster = value;
				DictionaryUtil.Add(QueryParameters, "TargetDedicatedHostIdForMaster", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceDescription")]
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

		[JsonProperty(PropertyName = "Tag")]
		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "BusinessInfo")]
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

		[JsonProperty(PropertyName = "DryRun")]
		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EncryptionKey")]
		public string EncryptionKey
		{
			get
			{
				return encryptionKey;
			}
			set	
			{
				encryptionKey = value;
				DictionaryUtil.Add(QueryParameters, "EncryptionKey", value);
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

		[JsonProperty(PropertyName = "SecurityIPList")]
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

		[JsonProperty(PropertyName = "TargetDedicatedHostIdForLog")]
		public string TargetDedicatedHostIdForLog
		{
			get
			{
				return targetDedicatedHostIdForLog;
			}
			set	
			{
				targetDedicatedHostIdForLog = value;
				DictionaryUtil.Add(QueryParameters, "TargetDedicatedHostIdForLog", value);
			}
		}

		[JsonProperty(PropertyName = "AutoRenew")]
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

		[JsonProperty(PropertyName = "Port")]
		public string Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(QueryParameters, "Port", value);
			}
		}

		[JsonProperty(PropertyName = "RoleARN")]
		public string RoleARN
		{
			get
			{
				return roleARN;
			}
			set	
			{
				roleARN = value;
				DictionaryUtil.Add(QueryParameters, "RoleARN", value);
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

		[JsonProperty(PropertyName = "StorageAutoScale")]
		public string StorageAutoScale
		{
			get
			{
				return storageAutoScale;
			}
			set	
			{
				storageAutoScale = value;
				DictionaryUtil.Add(QueryParameters, "StorageAutoScale", value);
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

		[JsonProperty(PropertyName = "ConnectionMode")]
		public string ConnectionMode
		{
			get
			{
				return connectionMode;
			}
			set	
			{
				connectionMode = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionMode", value);
			}
		}

		[JsonProperty(PropertyName = "ClientToken")]
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

		[JsonProperty(PropertyName = "TargetDedicatedHostIdForSlave")]
		public string TargetDedicatedHostIdForSlave
		{
			get
			{
				return targetDedicatedHostIdForSlave;
			}
			set	
			{
				targetDedicatedHostIdForSlave = value;
				DictionaryUtil.Add(QueryParameters, "TargetDedicatedHostIdForSlave", value);
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

		[JsonProperty(PropertyName = "DBIsIgnoreCase")]
		public string DBIsIgnoreCase
		{
			get
			{
				return dBIsIgnoreCase;
			}
			set	
			{
				dBIsIgnoreCase = value;
				DictionaryUtil.Add(QueryParameters, "DBIsIgnoreCase", value);
			}
		}

		[JsonProperty(PropertyName = "Engine")]
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

		[JsonProperty(PropertyName = "DBTimeZone")]
		public string DBTimeZone
		{
			get
			{
				return dBTimeZone;
			}
			set	
			{
				dBTimeZone = value;
				DictionaryUtil.Add(QueryParameters, "DBTimeZone", value);
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

		[JsonProperty(PropertyName = "CreateStrategy")]
		public string CreateStrategy
		{
			get
			{
				return createStrategy;
			}
			set	
			{
				createStrategy = value;
				DictionaryUtil.Add(QueryParameters, "CreateStrategy", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceNetType")]
		public string DBInstanceNetType
		{
			get
			{
				return dBInstanceNetType;
			}
			set	
			{
				dBInstanceNetType = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceNetType", value);
			}
		}

		[JsonProperty(PropertyName = "Amount")]
		public int? Amount
		{
			get
			{
				return amount;
			}
			set	
			{
				amount = value;
				DictionaryUtil.Add(QueryParameters, "Amount", value.ToString());
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

		[JsonProperty(PropertyName = "UsedTime")]
		public string UsedTime
		{
			get
			{
				return usedTime;
			}
			set	
			{
				usedTime = value;
				DictionaryUtil.Add(QueryParameters, "UsedTime", value);
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

		[JsonProperty(PropertyName = "TargetMinorVersion")]
		public string TargetMinorVersion
		{
			get
			{
				return targetMinorVersion;
			}
			set	
			{
				targetMinorVersion = value;
				DictionaryUtil.Add(QueryParameters, "TargetMinorVersion", value);
			}
		}

		[JsonProperty(PropertyName = "UserBackupId")]
		public string UserBackupId
		{
			get
			{
				return userBackupId;
			}
			set	
			{
				userBackupId = value;
				DictionaryUtil.Add(QueryParameters, "UserBackupId", value);
			}
		}

		[JsonProperty(PropertyName = "StorageUpperBound")]
		public int? StorageUpperBound
		{
			get
			{
				return storageUpperBound;
			}
			set	
			{
				storageUpperBound = value;
				DictionaryUtil.Add(QueryParameters, "StorageUpperBound", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "StorageThreshold")]
		public int? StorageThreshold
		{
			get
			{
				return storageThreshold;
			}
			set	
			{
				storageThreshold = value;
				DictionaryUtil.Add(QueryParameters, "StorageThreshold", value.ToString());
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

		public class Tag
		{

			private string value_;

			private string key;

			[JsonProperty(PropertyName = "Value")]
			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			[JsonProperty(PropertyName = "Key")]
			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
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

        public override CreateDBInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
