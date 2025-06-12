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
using Aliyun.Acs.clickhouse.Transform;
using Aliyun.Acs.clickhouse.Transform.V20191111;

namespace Aliyun.Acs.clickhouse.Model.V20191111
{
    public class CreateDBInstanceRequest : RpcAcsRequest<CreateDBInstanceResponse>
    {
        public CreateDBInstanceRequest()
            : base("clickhouse", "2019-11-11", "CreateDBInstance", "service", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.clickhouse.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.clickhouse.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string dBClusterDescription;

		private string sourceDBClusterId;

		private string resourceGroupId;

		private string zondIdBak2;

		private string dbNodeStorageType;

		private string encryptionType;

		private string zoneIdBak;

		private string period;

		private string backupSetID;

		private string encryptionKey;

		private long? ownerId;

		private string dBNodeGroupCount;

		private string vSwitchId;

		private bool? autoRenew;

		private string zoneId;

		private string clientToken;

		private string dBClusterCategory;

		private string dBClusterNetworkType;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string dBClusterVersion;

		private string dBClusterClass;

		private string vSwitchBak;

		private string usedTime;

		private string vSwitchBak2;

		private string dBNodeStorage;

		private string vPCId;

		private string payType;

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

		public string DBClusterDescription
		{
			get
			{
				return dBClusterDescription;
			}
			set	
			{
				dBClusterDescription = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterDescription", value);
			}
		}

		public string SourceDBClusterId
		{
			get
			{
				return sourceDBClusterId;
			}
			set	
			{
				sourceDBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "SourceDBClusterId", value);
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

		public string ZondIdBak2
		{
			get
			{
				return zondIdBak2;
			}
			set	
			{
				zondIdBak2 = value;
				DictionaryUtil.Add(QueryParameters, "ZondIdBak2", value);
			}
		}

		public string DbNodeStorageType
		{
			get
			{
				return dbNodeStorageType;
			}
			set	
			{
				dbNodeStorageType = value;
				DictionaryUtil.Add(QueryParameters, "DbNodeStorageType", value);
			}
		}

		public string EncryptionType
		{
			get
			{
				return encryptionType;
			}
			set	
			{
				encryptionType = value;
				DictionaryUtil.Add(QueryParameters, "EncryptionType", value);
			}
		}

		public string ZoneIdBak
		{
			get
			{
				return zoneIdBak;
			}
			set	
			{
				zoneIdBak = value;
				DictionaryUtil.Add(QueryParameters, "ZoneIdBak", value);
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

		public string BackupSetID
		{
			get
			{
				return backupSetID;
			}
			set	
			{
				backupSetID = value;
				DictionaryUtil.Add(QueryParameters, "BackupSetID", value);
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

		public string DBNodeGroupCount
		{
			get
			{
				return dBNodeGroupCount;
			}
			set	
			{
				dBNodeGroupCount = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeGroupCount", value);
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

		public bool? AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value.ToString());
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

		public string DBClusterCategory
		{
			get
			{
				return dBClusterCategory;
			}
			set	
			{
				dBClusterCategory = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterCategory", value);
			}
		}

		public string DBClusterNetworkType
		{
			get
			{
				return dBClusterNetworkType;
			}
			set	
			{
				dBClusterNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterNetworkType", value);
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

		public string DBClusterVersion
		{
			get
			{
				return dBClusterVersion;
			}
			set	
			{
				dBClusterVersion = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterVersion", value);
			}
		}

		public string DBClusterClass
		{
			get
			{
				return dBClusterClass;
			}
			set	
			{
				dBClusterClass = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterClass", value);
			}
		}

		public string VSwitchBak
		{
			get
			{
				return vSwitchBak;
			}
			set	
			{
				vSwitchBak = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchBak", value);
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

		public string VSwitchBak2
		{
			get
			{
				return vSwitchBak2;
			}
			set	
			{
				vSwitchBak2 = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchBak2", value);
			}
		}

		public string DBNodeStorage
		{
			get
			{
				return dBNodeStorage;
			}
			set	
			{
				dBNodeStorage = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeStorage", value);
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
