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

		private string creationCategory;

		private string resourceGroupId;

		private string dBNodeClass;

		private string creationOption;

		private string sourceResourceId;

		private string backupRetentionPolicyOnClusterDeletion;

		private string period;

		private long? ownerId;

		private string vSwitchId;

		private string securityIPList;

		private string dBMinorVersion;

		private bool? autoRenew;

		private string zoneId;

		private bool? tDEStatus;

		private string lowerCaseTableNames;

		private string clientToken;

		private string defaultTimeZone;

		private string clusterNetworkType;

		private string parameterGroupId;

		private string gDNId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string usedTime;

		private string vPCId;

		private string dBType;

		private string dBVersion;

		private string cloneDataPoint;

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

        public override CreateDBClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDBClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
