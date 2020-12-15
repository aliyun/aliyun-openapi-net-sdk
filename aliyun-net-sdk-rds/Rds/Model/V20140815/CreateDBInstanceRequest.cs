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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CreateDBInstanceRequest : RpcAcsRequest<CreateDBInstanceResponse>
    {
        public CreateDBInstanceRequest()
            : base("Rds", "2014-08-15", "CreateDBInstance", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dBParamGroupId;

		private long? resourceOwnerId;

		private int? dBInstanceStorage;

		private string systemDBCharset;

		private string engineVersion;

		private string resourceGroupId;

		private string targetDedicatedHostIdForMaster;

		private string dBInstanceDescription;

		private string businessInfo;

		private string period;

		private string encryptionKey;

		private string dBInstanceClass;

		private string securityIPList;

		private string vSwitchId;

		private string privateIpAddress;

		private string targetDedicatedHostIdForLog;

		private string autoRenew;

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

		private string dBInstanceNetType;

		private string usedTime;

		private string targetMinorVersion;

		private int? storageUpperBound;

		private int? storageThreshold;

		private string vPCId;

		private string category;

		private string payType;

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

        public override CreateDBInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
