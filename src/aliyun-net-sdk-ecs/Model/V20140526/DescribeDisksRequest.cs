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
    public class DescribeDisksRequest : RpcAcsRequest<DescribeDisksResponse>
    {
        public DescribeDisksRequest()
            : base("Ecs", "2014-05-26", "DescribeDisks")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _zoneId;

		private string _diskIds;

		private string _instanceId;

		private string _diskType;

		private string _category;

		private string _status;

		private string _snapshotId;

		private bool? _portable;

		private bool? _deleteWithInstance;

		private bool? _deleteAutoSnapshot;

		private int? _pageNumber;

		private int? _pageSize;

		private string _ownerAccount;

		private string _diskName;

		private bool? _enableAutoSnapshot;

		private bool? _enableAutomatedSnapshotPolicy;

		private string _diskChargeType;

		private string _lockReason;

		private string _filter1Key;

		private string _filter2Key;

		private string _filter1Value;

		private string _filter2Value;

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

		public string ZoneId
		{
			get
			{
				return _zoneId;
			}
			set	
			{
				_zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string DiskIds
		{
			get
			{
				return _diskIds;
			}
			set	
			{
				_diskIds = value;
				DictionaryUtil.Add(QueryParameters, "DiskIds", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return _instanceId;
			}
			set	
			{
				_instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string DiskType
		{
			get
			{
				return _diskType;
			}
			set	
			{
				_diskType = value;
				DictionaryUtil.Add(QueryParameters, "DiskType", value);
			}
		}

		public string Category
		{
			get
			{
				return _category;
			}
			set	
			{
				_category = value;
				DictionaryUtil.Add(QueryParameters, "Category", value);
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

		public bool? Portable
		{
			get
			{
				return _portable;
			}
			set	
			{
				_portable = value;
				DictionaryUtil.Add(QueryParameters, "Portable", value.ToString());
			}
		}

		public bool? DeleteWithInstance
		{
			get
			{
				return _deleteWithInstance;
			}
			set	
			{
				_deleteWithInstance = value;
				DictionaryUtil.Add(QueryParameters, "DeleteWithInstance", value.ToString());
			}
		}

		public bool? DeleteAutoSnapshot
		{
			get
			{
				return _deleteAutoSnapshot;
			}
			set	
			{
				_deleteAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "DeleteAutoSnapshot", value.ToString());
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

		public string DiskName
		{
			get
			{
				return _diskName;
			}
			set	
			{
				_diskName = value;
				DictionaryUtil.Add(QueryParameters, "DiskName", value);
			}
		}

		public bool? EnableAutoSnapshot
		{
			get
			{
				return _enableAutoSnapshot;
			}
			set	
			{
				_enableAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "EnableAutoSnapshot", value.ToString());
			}
		}

		public bool? EnableAutomatedSnapshotPolicy
		{
			get
			{
				return _enableAutomatedSnapshotPolicy;
			}
			set	
			{
				_enableAutomatedSnapshotPolicy = value;
				DictionaryUtil.Add(QueryParameters, "EnableAutomatedSnapshotPolicy", value.ToString());
			}
		}

		public string DiskChargeType
		{
			get
			{
				return _diskChargeType;
			}
			set	
			{
				_diskChargeType = value;
				DictionaryUtil.Add(QueryParameters, "DiskChargeType", value);
			}
		}

		public string LockReason
		{
			get
			{
				return _lockReason;
			}
			set	
			{
				_lockReason = value;
				DictionaryUtil.Add(QueryParameters, "LockReason", value);
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

        public override DescribeDisksResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeDisksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}