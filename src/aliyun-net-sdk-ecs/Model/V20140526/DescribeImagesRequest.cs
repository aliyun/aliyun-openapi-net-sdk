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
    public class DescribeImagesRequest : RpcAcsRequest<DescribeImagesResponse>
    {
        public DescribeImagesRequest()
            : base("Ecs", "2014-05-26", "DescribeImages")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _status;

		private string _imageId;

		private bool? _showExpired;

		private string _snapshotId;

		private string _imageName;

		private string _imageOwnerAlias;

		private string _instanceType;

		private bool? _isSupportIoOptimized;

		private string _oSType;

		private string _architecture;

		private int? _pageNumber;

		private int? _pageSize;

		private string _ownerAccount;

		private string _filter1Key;

		private string _filter2Key;

		private string _filter1Value;

		private string _filter2Value;

		private string _usage;

		private string _tag1Key;

		private string _tag2Key;

		private string _tag3Key;

		private string _tag4Key;

		private string _tag5Key;

		private string _tag1Value;

		private string _tag2Value;

		private string _tag3Value;

		private string _tag4Value;

		private string _tag5Value;

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

		public string Status
		{
			get
			{
				return _status;
			}
			set	
			{
				_status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public string ImageId
		{
			get
			{
				return _imageId;
			}
			set	
			{
				_imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		public bool? ShowExpired
		{
			get
			{
				return _showExpired;
			}
			set	
			{
				_showExpired = value;
				DictionaryUtil.Add(QueryParameters, "ShowExpired", value.ToString());
			}
		}

		public string SnapshotId
		{
			get
			{
				return _snapshotId;
			}
			set	
			{
				_snapshotId = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotId", value);
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

		public string ImageOwnerAlias
		{
			get
			{
				return _imageOwnerAlias;
			}
			set	
			{
				_imageOwnerAlias = value;
				DictionaryUtil.Add(QueryParameters, "ImageOwnerAlias", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return _instanceType;
			}
			set	
			{
				_instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public bool? IsSupportIoOptimized
		{
			get
			{
				return _isSupportIoOptimized;
			}
			set	
			{
				_isSupportIoOptimized = value;
				DictionaryUtil.Add(QueryParameters, "IsSupportIoOptimized", value.ToString());
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

		public int? PageNumber
		{
			get
			{
				return _pageNumber;
			}
			set	
			{
				_pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return _pageSize;
			}
			set	
			{
				_pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string Filter1Key
		{
			get
			{
				return _filter1Key;
			}
			set	
			{
				_filter1Key = value;
				DictionaryUtil.Add(QueryParameters, "Filter.1.Key", value);
			}
		}

		public string Filter2Key
		{
			get
			{
				return _filter2Key;
			}
			set	
			{
				_filter2Key = value;
				DictionaryUtil.Add(QueryParameters, "Filter.2.Key", value);
			}
		}

		public string Filter1Value
		{
			get
			{
				return _filter1Value;
			}
			set	
			{
				_filter1Value = value;
				DictionaryUtil.Add(QueryParameters, "Filter.1.Value", value);
			}
		}

		public string Filter2Value
		{
			get
			{
				return _filter2Value;
			}
			set	
			{
				_filter2Value = value;
				DictionaryUtil.Add(QueryParameters, "Filter.2.Value", value);
			}
		}

		public string Usage
		{
			get
			{
				return _usage;
			}
			set	
			{
				_usage = value;
				DictionaryUtil.Add(QueryParameters, "Usage", value);
			}
		}

		public string Tag1Key
		{
			get
			{
				return _tag1Key;
			}
			set	
			{
				_tag1Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.Key", value);
			}
		}

		public string Tag2Key
		{
			get
			{
				return _tag2Key;
			}
			set	
			{
				_tag2Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.Key", value);
			}
		}

		public string Tag3Key
		{
			get
			{
				return _tag3Key;
			}
			set	
			{
				_tag3Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.Key", value);
			}
		}

		public string Tag4Key
		{
			get
			{
				return _tag4Key;
			}
			set	
			{
				_tag4Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.Key", value);
			}
		}

		public string Tag5Key
		{
			get
			{
				return _tag5Key;
			}
			set	
			{
				_tag5Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.Key", value);
			}
		}

		public string Tag1Value
		{
			get
			{
				return _tag1Value;
			}
			set	
			{
				_tag1Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.Value", value);
			}
		}

		public string Tag2Value
		{
			get
			{
				return _tag2Value;
			}
			set	
			{
				_tag2Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.Value", value);
			}
		}

		public string Tag3Value
		{
			get
			{
				return _tag3Value;
			}
			set	
			{
				_tag3Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.Value", value);
			}
		}

		public string Tag4Value
		{
			get
			{
				return _tag4Value;
			}
			set	
			{
				_tag4Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.Value", value);
			}
		}

		public string Tag5Value
		{
			get
			{
				return _tag5Value;
			}
			set	
			{
				_tag5Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.Value", value);
			}
		}

        public override DescribeImagesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeImagesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}