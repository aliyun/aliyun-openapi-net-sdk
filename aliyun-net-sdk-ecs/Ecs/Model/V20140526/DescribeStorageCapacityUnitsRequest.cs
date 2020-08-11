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
    public class DescribeStorageCapacityUnitsRequest : RpcAcsRequest<DescribeStorageCapacityUnitsResponse>
    {
        public DescribeStorageCapacityUnitsRequest()
            : base("Ecs", "2014-05-26", "DescribeStorageCapacityUnits", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? pageNumber;

		private int? capacity;

		private List<string> storageCapacityUnitIds = new List<string>(){ };

		private int? pageSize;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string name;

		private List<string> statuss = new List<string>(){ };

		private string allocationType;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public int? Capacity
		{
			get
			{
				return capacity;
			}
			set	
			{
				capacity = value;
				DictionaryUtil.Add(QueryParameters, "Capacity", value.ToString());
			}
		}

		public List<string> StorageCapacityUnitIds
		{
			get
			{
				return storageCapacityUnitIds;
			}

			set
			{
				storageCapacityUnitIds = value;
				for (int i = 0; i < storageCapacityUnitIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"StorageCapacityUnitId." + (i + 1) , storageCapacityUnitIds[i]);
				}
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public List<string> Statuss
		{
			get
			{
				return statuss;
			}

			set
			{
				statuss = value;
				for (int i = 0; i < statuss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Status." + (i + 1) , statuss[i]);
				}
			}
		}

		public string AllocationType
		{
			get
			{
				return allocationType;
			}
			set	
			{
				allocationType = value;
				DictionaryUtil.Add(QueryParameters, "AllocationType", value);
			}
		}

        public override DescribeStorageCapacityUnitsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeStorageCapacityUnitsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
