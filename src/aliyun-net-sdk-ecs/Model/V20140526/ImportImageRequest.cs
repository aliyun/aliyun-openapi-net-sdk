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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ImportImageRequest : RpcAcsRequest<ImportImageResponse>
    {
        public ImportImageRequest()
            : base("Ecs", "2014-05-26", "ImportImage")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _imageName;

		private string _description;

		private string _architecture;

		private string _oSType;

		private string _platform;

		private string _diskDeviceMapping1Format;

		private string _diskDeviceMapping1OssBucket;

		private string _diskDeviceMapping1OssObject;

		private int? _diskDeviceMapping1DiskImSize;

		private string _diskDeviceMapping1Device;

		private string _roleName;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ImageName
		{
			get
			{
				return _imageName;
			}
			set	
			{
				_imageName = value;
				DictionaryUtil.Add(QueryParameters, "ImageName", value);
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set	
			{
				_description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string Architecture
		{
			get
			{
				return _architecture;
			}
			set	
			{
				_architecture = value;
				DictionaryUtil.Add(QueryParameters, "Architecture", value);
			}
		}

		public string OsType
		{
			get
			{
				return _oSType;
			}
			set	
			{
				_oSType = value;
				DictionaryUtil.Add(QueryParameters, "OSType", value);
			}
		}

		public string Platform
		{
			get
			{
				return _platform;
			}
			set	
			{
				_platform = value;
				DictionaryUtil.Add(QueryParameters, "Platform", value);
			}
		}

		public string DiskDeviceMapping1Format
		{
			get
			{
				return _diskDeviceMapping1Format;
			}
			set	
			{
				_diskDeviceMapping1Format = value;
				DictionaryUtil.Add(QueryParameters, "DiskDeviceMapping.1.Format", value);
			}
		}

		public string DiskDeviceMapping1OssBucket
		{
			get
			{
				return _diskDeviceMapping1OssBucket;
			}
			set	
			{
				_diskDeviceMapping1OssBucket = value;
				DictionaryUtil.Add(QueryParameters, "DiskDeviceMapping.1.OSSBucket", value);
			}
		}

		public string DiskDeviceMapping1OssObject
		{
			get
			{
				return _diskDeviceMapping1OssObject;
			}
			set	
			{
				_diskDeviceMapping1OssObject = value;
				DictionaryUtil.Add(QueryParameters, "DiskDeviceMapping.1.OSSObject", value);
			}
		}

		public int? DiskDeviceMapping1DiskImSize
		{
			get
			{
				return _diskDeviceMapping1DiskImSize;
			}
			set	
			{
				_diskDeviceMapping1DiskImSize = value;
				DictionaryUtil.Add(QueryParameters, "DiskDeviceMapping.1.DiskImSize", value.ToString());
			}
		}

		public string DiskDeviceMapping1Device
		{
			get
			{
				return _diskDeviceMapping1Device;
			}
			set	
			{
				_diskDeviceMapping1Device = value;
				DictionaryUtil.Add(QueryParameters, "DiskDeviceMapping.1.Device", value);
			}
		}

		public string RoleName
		{
			get
			{
				return _roleName;
			}
			set	
			{
				_roleName = value;
				DictionaryUtil.Add(QueryParameters, "RoleName", value);
			}
		}

        public override ImportImageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ImportImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}