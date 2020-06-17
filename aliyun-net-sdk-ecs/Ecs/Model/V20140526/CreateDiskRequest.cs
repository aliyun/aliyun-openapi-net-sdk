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
    public class CreateDiskRequest : RpcAcsRequest<CreateDiskResponse>
    {
        public CreateDiskRequest()
            : base("Ecs", "2014-05-26", "CreateDisk", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string snapshotId;

		private string clientToken;

		private string encryptAlgorithm;

		private string description;

		private string diskName;

		private string resourceGroupId;

		private string diskCategory;

		private int? storageSetPartitionNumber;

		private List<Tag> tags = new List<Tag>(){ };

		private List<Arn> arns = new List<Arn>(){ };

		private string advancedFeatures;

		private string resourceOwnerAccount;

		private string performanceLevel;

		private string ownerAccount;

		private long? ownerId;

		private string instanceId;

		private string storageSetId;

		private int? size;

		private bool? encrypted;

		private string zoneId;

		private string kMSKeyId;

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

		public string SnapshotId
		{
			get
			{
				return snapshotId;
			}
			set	
			{
				snapshotId = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotId", value);
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

		public string EncryptAlgorithm
		{
			get
			{
				return encryptAlgorithm;
			}
			set	
			{
				encryptAlgorithm = value;
				DictionaryUtil.Add(QueryParameters, "EncryptAlgorithm", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string DiskName
		{
			get
			{
				return diskName;
			}
			set	
			{
				diskName = value;
				DictionaryUtil.Add(QueryParameters, "DiskName", value);
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

		public string DiskCategory
		{
			get
			{
				return diskCategory;
			}
			set	
			{
				diskCategory = value;
				DictionaryUtil.Add(QueryParameters, "DiskCategory", value);
			}
		}

		public int? StorageSetPartitionNumber
		{
			get
			{
				return storageSetPartitionNumber;
			}
			set	
			{
				storageSetPartitionNumber = value;
				DictionaryUtil.Add(QueryParameters, "StorageSetPartitionNumber", value.ToString());
			}
		}

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
				}
			}
		}

		public List<Arn> Arns
		{
			get
			{
				return arns;
			}

			set
			{
				arns = value;
				for (int i = 0; i < arns.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Arn." + (i + 1) + ".Rolearn", arns[i].Rolearn);
					DictionaryUtil.Add(QueryParameters,"Arn." + (i + 1) + ".RoleType", arns[i].RoleType);
					DictionaryUtil.Add(QueryParameters,"Arn." + (i + 1) + ".AssumeRoleFor", arns[i].AssumeRoleFor);
				}
			}
		}

		public string AdvancedFeatures
		{
			get
			{
				return advancedFeatures;
			}
			set	
			{
				advancedFeatures = value;
				DictionaryUtil.Add(QueryParameters, "AdvancedFeatures", value);
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

		public string PerformanceLevel
		{
			get
			{
				return performanceLevel;
			}
			set	
			{
				performanceLevel = value;
				DictionaryUtil.Add(QueryParameters, "PerformanceLevel", value);
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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string StorageSetId
		{
			get
			{
				return storageSetId;
			}
			set	
			{
				storageSetId = value;
				DictionaryUtil.Add(QueryParameters, "StorageSetId", value);
			}
		}

		public int? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "Size", value.ToString());
			}
		}

		public bool? Encrypted
		{
			get
			{
				return encrypted;
			}
			set	
			{
				encrypted = value;
				DictionaryUtil.Add(QueryParameters, "Encrypted", value.ToString());
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

		public string KMSKeyId
		{
			get
			{
				return kMSKeyId;
			}
			set	
			{
				kMSKeyId = value;
				DictionaryUtil.Add(QueryParameters, "KMSKeyId", value);
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value
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

		public class Arn
		{

			private string rolearn;

			private string roleType;

			private long? assumeRoleFor;

			public string Rolearn
			{
				get
				{
					return rolearn;
				}
				set	
				{
					rolearn = value;
				}
			}

			public string RoleType
			{
				get
				{
					return roleType;
				}
				set	
				{
					roleType = value;
				}
			}

			public long? AssumeRoleFor
			{
				get
				{
					return assumeRoleFor;
				}
				set	
				{
					assumeRoleFor = value;
				}
			}
		}

        public override CreateDiskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDiskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
