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
    public class CreateImageRequest : RpcAcsRequest<CreateImageResponse>
    {
        public CreateImageRequest()
            : base("Ecs", "2014-05-26", "CreateImage", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<DiskDeviceMapping> diskDeviceMappings = new List<DiskDeviceMapping>(){ };

		private long? resourceOwnerId;

		private string snapshotId;

		private string clientToken;

		private string description;

		private string platform;

		private string resourceGroupId;

		private string imageName;

		private List<Tag> tags = new List<Tag>(){ };

		private string architecture;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string instanceId;

		private string imageFamily;

		private string imageVersion;

		public List<DiskDeviceMapping> DiskDeviceMappings
		{
			get
			{
				return diskDeviceMappings;
			}

			set
			{
				diskDeviceMappings = value;
				for (int i = 0; i < diskDeviceMappings.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (i + 1) + ".SnapshotId", diskDeviceMappings[i].SnapshotId);
					DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (i + 1) + ".Size", diskDeviceMappings[i].Size);
					DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (i + 1) + ".DiskType", diskDeviceMappings[i].DiskType);
					DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (i + 1) + ".Device", diskDeviceMappings[i].Device);
				}
			}
		}

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

		public string Platform
		{
			get
			{
				return platform;
			}
			set	
			{
				platform = value;
				DictionaryUtil.Add(QueryParameters, "Platform", value);
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

		public string ImageName
		{
			get
			{
				return imageName;
			}
			set	
			{
				imageName = value;
				DictionaryUtil.Add(QueryParameters, "ImageName", value);
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

		public string ImageFamily
		{
			get
			{
				return imageFamily;
			}
			set	
			{
				imageFamily = value;
				DictionaryUtil.Add(QueryParameters, "ImageFamily", value);
			}
		}

		public string ImageVersion
		{
			get
			{
				return imageVersion;
			}
			set	
			{
				imageVersion = value;
				DictionaryUtil.Add(QueryParameters, "ImageVersion", value);
			}
		}

		public class DiskDeviceMapping
		{

			private string snapshotId;

			private int? size;

			private string diskType;

			private string device;

			public string SnapshotId
			{
				get
				{
					return snapshotId;
				}
				set	
				{
					snapshotId = value;
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
				}
			}

			public string DiskType
			{
				get
				{
					return diskType;
				}
				set	
				{
					diskType = value;
				}
			}

			public string Device
			{
				get
				{
					return device;
				}
				set	
				{
					device = value;
				}
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

        public override CreateImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
