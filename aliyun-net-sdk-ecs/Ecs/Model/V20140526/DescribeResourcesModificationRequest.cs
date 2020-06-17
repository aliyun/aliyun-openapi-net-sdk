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
    public class DescribeResourcesModificationRequest : RpcAcsRequest<DescribeResourcesModificationResponse>
    {
        public DescribeResourcesModificationRequest()
            : base("Ecs", "2014-05-26", "DescribeResourcesModification", "ecs", "openAPI")
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

		private int? cores;

		private bool? migrateAcrossZone;

		private string instanceType;

		private string resourceId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string operationType;

		private long? ownerId;

		private string destinationResource;

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

		public bool? MigrateAcrossZone
		{
			get
			{
				return migrateAcrossZone;
			}
			set	
			{
				migrateAcrossZone = value;
				DictionaryUtil.Add(QueryParameters, "MigrateAcrossZone", value.ToString());
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

		public string ResourceId
		{
			get
			{
				return resourceId;
			}
			set	
			{
				resourceId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId", value);
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

		public string OperationType
		{
			get
			{
				return operationType;
			}
			set	
			{
				operationType = value;
				DictionaryUtil.Add(QueryParameters, "OperationType", value);
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

        public override DescribeResourcesModificationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeResourcesModificationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
