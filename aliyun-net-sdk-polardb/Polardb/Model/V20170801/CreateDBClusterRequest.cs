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
using Aliyun.Acs.polardb.Transform;
using Aliyun.Acs.polardb.Transform.V20170801;

namespace Aliyun.Acs.polardb.Model.V20170801
{
    public class CreateDBClusterRequest : RpcAcsRequest<CreateDBClusterResponse>
    {
        public CreateDBClusterRequest()
            : base("polardb", "2017-08-01", "CreateDBCluster", "polardb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string dBClusterDescription;

		private string proxyClass;

		private string proxyType;

		private string scaleMax;

		private string storageType;

		private string creationCategory;

		private string resourceGroupId;

		private string dBNodeClass;

		private string creationOption;

		private List<string> tags = new List<string>(){ };

		private string sourceResourceId;

		private string scaleMin;

		private string backupRetentionPolicyOnClusterDeletion;

		private string period;

		private long? ownerId;

		private string vSwitchId;

		private string securityIPList;

		private string dBMinorVersion;

		private long? provisionedIops;

		private bool? autoRenew;

		private string hotStandbyCluster;

		private string storagePayType;

		private string zoneId;

		private string storageAutoScale;

		private bool? tDEStatus;

		private string allowShutDown;

		private string lowerCaseTableNames;

		private string scaleRoNumMax;

		private string standbyAZ;

		private string clientToken;

		private string defaultTimeZone;

		private string clusterNetworkType;

		private string parameterGroupId;

		private string gDNId;

		private string looseXEngine;

		private string loosePolarLogBin;

		private string architecture;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string looseXEngineUseMemoryPct;

		private string usedTime;

		private string burstingEnabled;

		private string targetMinorVersion;

		private int? dBNodeNum;

		private long? storageUpperBound;

		private string vPCId;

		private string scaleRoNumMin;

		private string dBType;

		private string dBVersion;

		private string strictConsistency;

		private string cloneDataPoint;

		private string payType;

		private long? storageSpace;

		private string serverlessType;

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

		public string ProxyClass
		{
			get
			{
				return proxyClass;
			}
			set	
			{
				proxyClass = value;
				DictionaryUtil.Add(QueryParameters, "ProxyClass", value);
			}
		}

		public string ProxyType
		{
			get
			{
				return proxyType;
			}
			set	
			{
				proxyType = value;
				DictionaryUtil.Add(QueryParameters, "ProxyType", value);
			}
		}

		public string ScaleMax
		{
			get
			{
				return scaleMax;
			}
			set	
			{
				scaleMax = value;
				DictionaryUtil.Add(QueryParameters, "ScaleMax", value);
			}
		}

		public string StorageType
		{
			get
			{
				return storageType;
			}
			set	
			{
				storageType = value;
				DictionaryUtil.Add(QueryParameters, "StorageType", value);
			}
		}

		public string CreationCategory
		{
			get
			{
				return creationCategory;
			}
			set	
			{
				creationCategory = value;
				DictionaryUtil.Add(QueryParameters, "CreationCategory", value);
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

		public string DBNodeClass
		{
			get
			{
				return dBNodeClass;
			}
			set	
			{
				dBNodeClass = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeClass", value);
			}
		}

		public string CreationOption
		{
			get
			{
				return creationOption;
			}
			set	
			{
				creationOption = value;
				DictionaryUtil.Add(QueryParameters, "CreationOption", value);
			}
		}

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

		public string SourceResourceId
		{
			get
			{
				return sourceResourceId;
			}
			set	
			{
				sourceResourceId = value;
				DictionaryUtil.Add(QueryParameters, "SourceResourceId", value);
			}
		}

		public string ScaleMin
		{
			get
			{
				return scaleMin;
			}
			set	
			{
				scaleMin = value;
				DictionaryUtil.Add(QueryParameters, "ScaleMin", value);
			}
		}

		public string BackupRetentionPolicyOnClusterDeletion
		{
			get
			{
				return backupRetentionPolicyOnClusterDeletion;
			}
			set	
			{
				backupRetentionPolicyOnClusterDeletion = value;
				DictionaryUtil.Add(QueryParameters, "BackupRetentionPolicyOnClusterDeletion", value);
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

		public string DBMinorVersion
		{
			get
			{
				return dBMinorVersion;
			}
			set	
			{
				dBMinorVersion = value;
				DictionaryUtil.Add(QueryParameters, "DBMinorVersion", value);
			}
		}

		public long? ProvisionedIops
		{
			get
			{
				return provisionedIops;
			}
			set	
			{
				provisionedIops = value;
				DictionaryUtil.Add(QueryParameters, "ProvisionedIops", value.ToString());
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

		public string HotStandbyCluster
		{
			get
			{
				return hotStandbyCluster;
			}
			set	
			{
				hotStandbyCluster = value;
				DictionaryUtil.Add(QueryParameters, "HotStandbyCluster", value);
			}
		}

		public string StoragePayType
		{
			get
			{
				return storagePayType;
			}
			set	
			{
				storagePayType = value;
				DictionaryUtil.Add(QueryParameters, "StoragePayType", value);
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

		public bool? TDEStatus
		{
			get
			{
				return tDEStatus;
			}
			set	
			{
				tDEStatus = value;
				DictionaryUtil.Add(QueryParameters, "TDEStatus", value.ToString());
			}
		}

		public string AllowShutDown
		{
			get
			{
				return allowShutDown;
			}
			set	
			{
				allowShutDown = value;
				DictionaryUtil.Add(QueryParameters, "AllowShutDown", value);
			}
		}

		public string LowerCaseTableNames
		{
			get
			{
				return lowerCaseTableNames;
			}
			set	
			{
				lowerCaseTableNames = value;
				DictionaryUtil.Add(QueryParameters, "LowerCaseTableNames", value);
			}
		}

		public string ScaleRoNumMax
		{
			get
			{
				return scaleRoNumMax;
			}
			set	
			{
				scaleRoNumMax = value;
				DictionaryUtil.Add(QueryParameters, "ScaleRoNumMax", value);
			}
		}

		public string StandbyAZ
		{
			get
			{
				return standbyAZ;
			}
			set	
			{
				standbyAZ = value;
				DictionaryUtil.Add(QueryParameters, "StandbyAZ", value);
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

		public string DefaultTimeZone
		{
			get
			{
				return defaultTimeZone;
			}
			set	
			{
				defaultTimeZone = value;
				DictionaryUtil.Add(QueryParameters, "DefaultTimeZone", value);
			}
		}

		public string ClusterNetworkType
		{
			get
			{
				return clusterNetworkType;
			}
			set	
			{
				clusterNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "ClusterNetworkType", value);
			}
		}

		public string ParameterGroupId
		{
			get
			{
				return parameterGroupId;
			}
			set	
			{
				parameterGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ParameterGroupId", value);
			}
		}

		public string GDNId
		{
			get
			{
				return gDNId;
			}
			set	
			{
				gDNId = value;
				DictionaryUtil.Add(QueryParameters, "GDNId", value);
			}
		}

		public string LooseXEngine
		{
			get
			{
				return looseXEngine;
			}
			set	
			{
				looseXEngine = value;
				DictionaryUtil.Add(QueryParameters, "LooseXEngine", value);
			}
		}

		public string LoosePolarLogBin
		{
			get
			{
				return loosePolarLogBin;
			}
			set	
			{
				loosePolarLogBin = value;
				DictionaryUtil.Add(QueryParameters, "LoosePolarLogBin", value);
			}
		}

		public string Architecture
		{
			get
			{
				return architecture;
			}
			set	
			{
				architecture = value;
				DictionaryUtil.Add(QueryParameters, "Architecture", value);
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

		public string LooseXEngineUseMemoryPct
		{
			get
			{
				return looseXEngineUseMemoryPct;
			}
			set	
			{
				looseXEngineUseMemoryPct = value;
				DictionaryUtil.Add(QueryParameters, "LooseXEngineUseMemoryPct", value);
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

		public string BurstingEnabled
		{
			get
			{
				return burstingEnabled;
			}
			set	
			{
				burstingEnabled = value;
				DictionaryUtil.Add(QueryParameters, "BurstingEnabled", value);
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

		public int? DBNodeNum
		{
			get
			{
				return dBNodeNum;
			}
			set	
			{
				dBNodeNum = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeNum", value.ToString());
			}
		}

		public long? StorageUpperBound
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

		public string ScaleRoNumMin
		{
			get
			{
				return scaleRoNumMin;
			}
			set	
			{
				scaleRoNumMin = value;
				DictionaryUtil.Add(QueryParameters, "ScaleRoNumMin", value);
			}
		}

		public string DBType
		{
			get
			{
				return dBType;
			}
			set	
			{
				dBType = value;
				DictionaryUtil.Add(QueryParameters, "DBType", value);
			}
		}

		public string DBVersion
		{
			get
			{
				return dBVersion;
			}
			set	
			{
				dBVersion = value;
				DictionaryUtil.Add(QueryParameters, "DBVersion", value);
			}
		}

		public string StrictConsistency
		{
			get
			{
				return strictConsistency;
			}
			set	
			{
				strictConsistency = value;
				DictionaryUtil.Add(QueryParameters, "StrictConsistency", value);
			}
		}

		public string CloneDataPoint
		{
			get
			{
				return cloneDataPoint;
			}
			set	
			{
				cloneDataPoint = value;
				DictionaryUtil.Add(QueryParameters, "CloneDataPoint", value);
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

		public long? StorageSpace
		{
			get
			{
				return storageSpace;
			}
			set	
			{
				storageSpace = value;
				DictionaryUtil.Add(QueryParameters, "StorageSpace", value.ToString());
			}
		}

		public string ServerlessType
		{
			get
			{
				return serverlessType;
			}
			set	
			{
				serverlessType = value;
				DictionaryUtil.Add(QueryParameters, "ServerlessType", value);
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

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

        public override CreateDBClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDBClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
