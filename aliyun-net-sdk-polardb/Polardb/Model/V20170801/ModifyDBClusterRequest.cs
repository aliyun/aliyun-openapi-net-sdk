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
    public class ModifyDBClusterRequest : RpcAcsRequest<ModifyDBClusterResponse>
    {
        public ModifyDBClusterRequest()
            : base("polardb", "2017-08-01", "ModifyDBCluster", "polardb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string standbyHAMode;

		private string resourceOwnerAccount;

		private string dBClusterId;

		private string ownerAccount;

		private string dBNodeCrashList;

		private string faultSimulateMode;

		private long? ownerId;

		private string compressStorage;

		private long? storageUpperBound;

		private string imciAutoIndex;

		private string storageAutoScale;

		private string faultInjectionType;

		private string dataSyncMode;

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

		public string StandbyHAMode
		{
			get
			{
				return standbyHAMode;
			}
			set	
			{
				standbyHAMode = value;
				DictionaryUtil.Add(QueryParameters, "StandbyHAMode", value);
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

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterId", value);
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

		public string DBNodeCrashList
		{
			get
			{
				return dBNodeCrashList;
			}
			set	
			{
				dBNodeCrashList = value;
				DictionaryUtil.Add(QueryParameters, "DBNodeCrashList", value);
			}
		}

		public string FaultSimulateMode
		{
			get
			{
				return faultSimulateMode;
			}
			set	
			{
				faultSimulateMode = value;
				DictionaryUtil.Add(QueryParameters, "FaultSimulateMode", value);
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

		public string CompressStorage
		{
			get
			{
				return compressStorage;
			}
			set	
			{
				compressStorage = value;
				DictionaryUtil.Add(QueryParameters, "CompressStorage", value);
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

		public string ImciAutoIndex
		{
			get
			{
				return imciAutoIndex;
			}
			set	
			{
				imciAutoIndex = value;
				DictionaryUtil.Add(QueryParameters, "ImciAutoIndex", value);
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

		public string FaultInjectionType
		{
			get
			{
				return faultInjectionType;
			}
			set	
			{
				faultInjectionType = value;
				DictionaryUtil.Add(QueryParameters, "FaultInjectionType", value);
			}
		}

		public string DataSyncMode
		{
			get
			{
				return dataSyncMode;
			}
			set	
			{
				dataSyncMode = value;
				DictionaryUtil.Add(QueryParameters, "DataSyncMode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyDBClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
