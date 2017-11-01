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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ImportImageRequest : RpcAcsRequest<ImportImageResponse>
    {
        public ImportImageRequest()
            : base("Ecs", "2014-05-26", "ImportImage", "ecs", "openAPI")
        {
        }

		private List<DiskDeviceMapping> diskDeviceMappings;

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string regionId;

		private string imageName;

		private string roleName;

		private string action;

		private string description;

		private string oSType;

		private long? ownerId;

		private string platform;

		private string architecture;

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
					DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (i + 1) + ".Format", diskDeviceMappings[i].Format);
					DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (i + 1) + ".OSSBucket", diskDeviceMappings[i].OSSBucket);
					DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (i + 1) + ".OSSObject", diskDeviceMappings[i].OSSObject);
					DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (i + 1) + ".DiskImSize", diskDeviceMappings[i].DiskImSize);
					DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (i + 1) + ".DiskImageSize", diskDeviceMappings[i].DiskImageSize);
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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
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

		public string RoleName
		{
			get
			{
				return roleName;
			}
			set	
			{
				roleName = value;
				DictionaryUtil.Add(QueryParameters, "RoleName", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

		public string OSType
		{
			get
			{
				return oSType;
			}
			set	
			{
				oSType = value;
				DictionaryUtil.Add(QueryParameters, "OSType", value);
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

		public class DiskDeviceMapping
		{

			private string format;

			private string oSSBucket;

			private string oSSObject;

			private int? diskImSize;

			private int? diskImageSize;

			private string device;

			public string Format
			{
				get
				{
					return format;
				}
				set	
				{
					format = value;
				}
			}

			public string OSSBucket
			{
				get
				{
					return oSSBucket;
				}
				set	
				{
					oSSBucket = value;
				}
			}

			public string OSSObject
			{
				get
				{
					return oSSObject;
				}
				set	
				{
					oSSObject = value;
				}
			}

			public int? DiskImSize
			{
				get
				{
					return diskImSize;
				}
				set	
				{
					diskImSize = value;
				}
			}

			public int? DiskImageSize
			{
				get
				{
					return diskImageSize;
				}
				set	
				{
					diskImageSize = value;
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

        public override ImportImageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ImportImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}