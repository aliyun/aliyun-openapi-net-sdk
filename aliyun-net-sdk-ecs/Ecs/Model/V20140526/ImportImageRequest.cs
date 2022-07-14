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
    public class ImportImageRequest : RpcAcsRequest<ImportImageResponse>
    {
        public ImportImageRequest()
            : base("Ecs", "2014-05-26", "ImportImage", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> diskDeviceMappings = new List<string>(){ };

		private long? resourceOwnerId;

		private string description;

		private string platform;

		private string resourceGroupId;

		private string bootMode;

		private string imageName;

		private List<string> tags = new List<string>(){ };

		private string architecture;

		private string licenseType;

		private string detectionStrategy;

		private string resourceOwnerAccount;

		private string roleName;

		private string oSType;

		private long? ownerId;

		public List<string> DiskDeviceMappings
		{
			get
			{
				return diskDeviceMappings;
			}

			set
			{
				diskDeviceMappings = value;
				if(diskDeviceMappings != null)
				{
					for (int depth1 = 0; depth1 < diskDeviceMappings.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (depth1 + 1), diskDeviceMappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (depth1 + 1), diskDeviceMappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (depth1 + 1), diskDeviceMappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (depth1 + 1), diskDeviceMappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (depth1 + 1), diskDeviceMappings[depth1]);
						DictionaryUtil.Add(QueryParameters,"DiskDeviceMapping." + (depth1 + 1), diskDeviceMappings[depth1]);
					}
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

		public string BootMode
		{
			get
			{
				return bootMode;
			}
			set	
			{
				bootMode = value;
				DictionaryUtil.Add(QueryParameters, "BootMode", value);
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

		public string LicenseType
		{
			get
			{
				return licenseType;
			}
			set	
			{
				licenseType = value;
				DictionaryUtil.Add(QueryParameters, "LicenseType", value);
			}
		}

		public string DetectionStrategy
		{
			get
			{
				return detectionStrategy;
			}
			set	
			{
				detectionStrategy = value;
				DictionaryUtil.Add(QueryParameters, "DetectionStrategy", value);
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

		public class DiskDeviceMapping
		{

			private string oSSBucket;

			private int? diskImSize;

			private string format;

			private string device;

			private string oSSObject;

			private int? diskImageSize;

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

        public override ImportImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
