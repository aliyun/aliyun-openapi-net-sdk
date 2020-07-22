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
using Aliyun.Acs.R_kvstore.Transform;
using Aliyun.Acs.R_kvstore.Transform.V20150101;

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
    public class ModifyDedicatedUserClusterRequest : RpcAcsRequest<ModifyDedicatedUserClusterResponse>
    {
        public ModifyDedicatedUserClusterRequest()
            : base("R-kvstore", "2015-01-01", "ModifyDedicatedUserCluster", "redisa", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clusterName;

		private string securityToken;

		private string engine;

		private int? diskOverAllocationRatio;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string clusterId;

		private int? memoryOverAllocationRatio;

		private long? ownerId;

		private string hostReplacePolicy;

		private string allocationPolicy;

		private string zoneId;

		private int? cpuOverAllocationRatio;

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

		public string ClusterName
		{
			get
			{
				return clusterName;
			}
			set	
			{
				clusterName = value;
				DictionaryUtil.Add(QueryParameters, "ClusterName", value);
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

		public int? DiskOverAllocationRatio
		{
			get
			{
				return diskOverAllocationRatio;
			}
			set	
			{
				diskOverAllocationRatio = value;
				DictionaryUtil.Add(QueryParameters, "DiskOverAllocationRatio", value.ToString());
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

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public int? MemoryOverAllocationRatio
		{
			get
			{
				return memoryOverAllocationRatio;
			}
			set	
			{
				memoryOverAllocationRatio = value;
				DictionaryUtil.Add(QueryParameters, "MemoryOverAllocationRatio", value.ToString());
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

		public string HostReplacePolicy
		{
			get
			{
				return hostReplacePolicy;
			}
			set	
			{
				hostReplacePolicy = value;
				DictionaryUtil.Add(QueryParameters, "HostReplacePolicy", value);
			}
		}

		public string AllocationPolicy
		{
			get
			{
				return allocationPolicy;
			}
			set	
			{
				allocationPolicy = value;
				DictionaryUtil.Add(QueryParameters, "AllocationPolicy", value);
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

		public int? CpuOverAllocationRatio
		{
			get
			{
				return cpuOverAllocationRatio;
			}
			set	
			{
				cpuOverAllocationRatio = value;
				DictionaryUtil.Add(QueryParameters, "CpuOverAllocationRatio", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyDedicatedUserClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDedicatedUserClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
