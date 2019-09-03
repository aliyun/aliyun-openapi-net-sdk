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
    public class PreCheckCreateOrderRequest : RpcAcsRequest<PreCheckCreateOrderResponse>
    {
        public PreCheckCreateOrderRequest()
            : base("Rds", "2014-08-15", "PreCheckCreateOrder", "rds", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private int? dBInstanceStorage;

		private string systemDBCharset;

		private string countryCode;

		private string engineVersion;

		private string currencyCode;

		private string resourceGroupId;

		private string dBInstanceDescription;

		private string businessInfo;

		private string agentId;

		private string resource;

		private string backupId;

		private string commodityCode;

		private string encryptionKey;

		private long? ownerId;

		private string dBInstanceClass;

		private string securityIPList;

		private string vSwitchId;

		private string privateIpAddress;

		private string autoRenew;

		private string promotionCode;

		private string roleARN;

		private string zoneId;

		private string timeType;

		private string instanceNetworkType;

		private string connectionMode;

		private string nodeType;

		private string clientToken;

		private string zoneIdSlave1;

		private string zoneIdSlave2;

		private string engine;

		private string dBInstanceId;

		private string dBInstanceStorageType;

		private string dBInstanceNetType;

		private string restoreTime;

		private int? quantity;

		private bool? autoPay;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string usedTime;

		private int? instanceUsedType;

		private string vPCId;

		private string category;

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

		public string CountryCode
		{
			get
			{
				return countryCode;
			}
			set	
			{
				countryCode = value;
				DictionaryUtil.Add(QueryParameters, "CountryCode", value);
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

		public string CurrencyCode
		{
			get
			{
				return currencyCode;
			}
			set	
			{
				currencyCode = value;
				DictionaryUtil.Add(QueryParameters, "CurrencyCode", value);
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

		public string AgentId
		{
			get
			{
				return agentId;
			}
			set	
			{
				agentId = value;
				DictionaryUtil.Add(QueryParameters, "AgentId", value);
			}
		}

		public string Resource
		{
			get
			{
				return resource;
			}
			set	
			{
				resource = value;
				DictionaryUtil.Add(QueryParameters, "Resource", value);
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

		public string CommodityCode
		{
			get
			{
				return commodityCode;
			}
			set	
			{
				commodityCode = value;
				DictionaryUtil.Add(QueryParameters, "CommodityCode", value);
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

		public string PromotionCode
		{
			get
			{
				return promotionCode;
			}
			set	
			{
				promotionCode = value;
				DictionaryUtil.Add(QueryParameters, "PromotionCode", value);
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

		public string TimeType
		{
			get
			{
				return timeType;
			}
			set	
			{
				timeType = value;
				DictionaryUtil.Add(QueryParameters, "TimeType", value);
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

		public int? Quantity
		{
			get
			{
				return quantity;
			}
			set	
			{
				quantity = value;
				DictionaryUtil.Add(QueryParameters, "Quantity", value.ToString());
			}
		}

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

		public int? InstanceUsedType
		{
			get
			{
				return instanceUsedType;
			}
			set	
			{
				instanceUsedType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceUsedType", value.ToString());
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

        public override PreCheckCreateOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PreCheckCreateOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
