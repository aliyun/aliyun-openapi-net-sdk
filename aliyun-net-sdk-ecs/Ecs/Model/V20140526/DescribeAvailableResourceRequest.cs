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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeAvailableResourceRequest : RpcAcsRequest<DescribeAvailableResourceResponse>
    {
        public DescribeAvailableResourceRequest()
            : base("Ecs", "2014-05-26", "DescribeAvailableResource", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private float? memory;

		private string ioOptimized;

		private string dataDiskCategory;

		private int? cores;

		private string systemDiskCategory;

		private string scope;

		private string instanceType;

		private string networkCategory;

		private string instanceChargeType;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string dedicatedHostId;

		private long? ownerId;

		private int? spotDuration;

		private string resourceType;

		private string spotStrategy;

		private string destinationResource;

		private string zoneId;

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

		public float? Memory
		{
			get
			{
				return memory;
			}
			set	
			{
				memory = value;
				DictionaryUtil.Add(QueryParameters, "Memory", value.ToString());
			}
		}

		public string IoOptimized
		{
			get
			{
				return ioOptimized;
			}
			set	
			{
				ioOptimized = value;
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value);
			}
		}

		public string DataDiskCategory
		{
			get
			{
				return dataDiskCategory;
			}
			set	
			{
				dataDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "DataDiskCategory", value);
			}
		}

		public int? Cores
		{
			get
			{
				return cores;
			}
			set	
			{
				cores = value;
				DictionaryUtil.Add(QueryParameters, "Cores", value.ToString());
			}
		}

		public string SystemDiskCategory
		{
			get
			{
				return systemDiskCategory;
			}
			set	
			{
				systemDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskCategory", value);
			}
		}

		public string Scope
		{
			get
			{
				return scope;
			}
			set	
			{
				scope = value;
				DictionaryUtil.Add(QueryParameters, "Scope", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string NetworkCategory
		{
			get
			{
				return networkCategory;
			}
			set	
			{
				networkCategory = value;
				DictionaryUtil.Add(QueryParameters, "NetworkCategory", value);
			}
		}

		public string InstanceChargeType
		{
			get
			{
				return instanceChargeType;
			}
			set	
			{
				instanceChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceChargeType", value);
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

		public string DedicatedHostId
		{
			get
			{
				return dedicatedHostId;
			}
			set	
			{
				dedicatedHostId = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostId", value);
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

		public int? SpotDuration
		{
			get
			{
				return spotDuration;
			}
			set	
			{
				spotDuration = value;
				DictionaryUtil.Add(QueryParameters, "SpotDuration", value.ToString());
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public string SpotStrategy
		{
			get
			{
				return spotStrategy;
			}
			set	
			{
				spotStrategy = value;
				DictionaryUtil.Add(QueryParameters, "SpotStrategy", value);
			}
		}

		public string DestinationResource
		{
			get
			{
				return destinationResource;
			}
			set	
			{
				destinationResource = value;
				DictionaryUtil.Add(QueryParameters, "DestinationResource", value);
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

        public override DescribeAvailableResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeAvailableResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
