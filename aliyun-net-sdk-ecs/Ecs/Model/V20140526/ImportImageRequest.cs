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
            : base("Ecs", "2014-05-26", "ImportImage")
        {
        }

		private long? ownerId;

		private string resourceOwnerAccount;

		private long? resourceOwnerId;

		private string imageName;

		private string description;

		private string architecture;

		private string oSType;

		private string platform;

		private string diskDeviceMapping1Format;

		private string diskDeviceMapping1OSSBucket;

		private string diskDeviceMapping1OSSObject;

		private int? diskDeviceMapping1DiskImSize;

		private string diskDeviceMapping1Device;

		private string roleName;

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

		public string DiskDeviceMapping1Format
		{
			get
			{
				return diskDeviceMapping1Format;
			}
			set	
			{
				diskDeviceMapping1Format = value;
				DictionaryUtil.Add(QueryParameters, "DiskDeviceMapping.1.Format", value);
			}
		}

		public string DiskDeviceMapping1OSSBucket
		{
			get
			{
				return diskDeviceMapping1OSSBucket;
			}
			set	
			{
				diskDeviceMapping1OSSBucket = value;
				DictionaryUtil.Add(QueryParameters, "DiskDeviceMapping.1.OSSBucket", value);
			}
		}

		public string DiskDeviceMapping1OSSObject
		{
			get
			{
				return diskDeviceMapping1OSSObject;
			}
			set	
			{
				diskDeviceMapping1OSSObject = value;
				DictionaryUtil.Add(QueryParameters, "DiskDeviceMapping.1.OSSObject", value);
			}
		}

		public int? DiskDeviceMapping1DiskImSize
		{
			get
			{
				return diskDeviceMapping1DiskImSize;
			}
			set	
			{
				diskDeviceMapping1DiskImSize = value;
				DictionaryUtil.Add(QueryParameters, "DiskDeviceMapping.1.DiskImSize", value.ToString());
			}
		}

		public string DiskDeviceMapping1Device
		{
			get
			{
				return diskDeviceMapping1Device;
			}
			set	
			{
				diskDeviceMapping1Device = value;
				DictionaryUtil.Add(QueryParameters, "DiskDeviceMapping.1.Device", value);
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

        public override ImportImageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ImportImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}