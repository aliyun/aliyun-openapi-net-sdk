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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeDisksRequest : RpcAcsRequest<DescribeDisksResponse>
    {
        public DescribeDisksRequest()
            : base("Ecs", "2014-05-26", "DescribeDisks")
        {
        }

	private long? ownerId;

	private string resourceOwnerAccount;

	private long? resourceOwnerId;

	private string zoneId;

	private string diskIds;

	private string instanceId;

	private string diskType;

	private string category;

	private string status;

	private string snapshotId;

	private bool? portable;

	private bool? deleteWithInstance;

	private bool? deleteAutoSnapshot;

	private int? pageNumber;

	private int? pageSize;

	private string ownerAccount;

	private string diskName;

	private bool? enableAutoSnapshot;

	private string diskChargeType;

	private string lockReason;

	private string filter1Key;

	private string filter2Key;

	private string filter1Value;

	private string filter2Value;

	private string tag1Key;

	private string tag2Key;

	private string tag3Key;

	private string tag4Key;

	private string tag5Key;

	private string tag1Value;

	private string tag2Value;

	private string tag3Value;

	private string tag4Value;

	private string tag5Value;

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

	public string DiskIds
	{
		get
		{
			return diskIds;
		}
		set	
		{
			diskIds = value;
			DictionaryUtil.Add(QueryParameters, "DiskIds", value);
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

	public string DiskType
	{
		get
		{
			return diskType;
		}
		set	
		{
			diskType = value;
			DictionaryUtil.Add(QueryParameters, "DiskType", value);
		}
	}

	public string Category
	{
		get
		{
			return category;
		}
		set	
		{
			category = value;
			DictionaryUtil.Add(QueryParameters, "Category", value);
		}
	}

	public string Status
	{
		get
		{
			return status;
		}
		set	
		{
			status = value;
			DictionaryUtil.Add(QueryParameters, "Status", value);
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

	public bool? Portable
	{
		get
		{
			return portable;
		}
		set	
		{
			portable = value;
			DictionaryUtil.Add(QueryParameters, "Portable", value.ToString());
		}
	}

	public bool? DeleteWithInstance
	{
		get
		{
			return deleteWithInstance;
		}
		set	
		{
			deleteWithInstance = value;
			DictionaryUtil.Add(QueryParameters, "DeleteWithInstance", value.ToString());
		}
	}

	public bool? DeleteAutoSnapshot
	{
		get
		{
			return deleteAutoSnapshot;
		}
		set	
		{
			deleteAutoSnapshot = value;
			DictionaryUtil.Add(QueryParameters, "DeleteAutoSnapshot", value.ToString());
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

	public bool? EnableAutoSnapshot
	{
		get
		{
			return enableAutoSnapshot;
		}
		set	
		{
			enableAutoSnapshot = value;
			DictionaryUtil.Add(QueryParameters, "EnableAutoSnapshot", value.ToString());
		}
	}

	public string DiskChargeType
	{
		get
		{
			return diskChargeType;
		}
		set	
		{
			diskChargeType = value;
			DictionaryUtil.Add(QueryParameters, "DiskChargeType", value);
		}
	}

	public string LockReason
	{
		get
		{
			return lockReason;
		}
		set	
		{
			lockReason = value;
			DictionaryUtil.Add(QueryParameters, "LockReason", value);
		}
	}

	public string Filter1Key
	{
		get
		{
			return filter1Key;
		}
		set	
		{
			filter1Key = value;
			DictionaryUtil.Add(QueryParameters, "Filter.1.Key", value);
		}
	}

	public string Filter2Key
	{
		get
		{
			return filter2Key;
		}
		set	
		{
			filter2Key = value;
			DictionaryUtil.Add(QueryParameters, "Filter.2.Key", value);
		}
	}

	public string Filter1Value
	{
		get
		{
			return filter1Value;
		}
		set	
		{
			filter1Value = value;
			DictionaryUtil.Add(QueryParameters, "Filter.1.Value", value);
		}
	}

	public string Filter2Value
	{
		get
		{
			return filter2Value;
		}
		set	
		{
			filter2Value = value;
			DictionaryUtil.Add(QueryParameters, "Filter.2.Value", value);
		}
	}

	public string Tag1Key
	{
		get
		{
			return tag1Key;
		}
		set	
		{
			tag1Key = value;
			DictionaryUtil.Add(QueryParameters, "Tag.1.Key", value);
		}
	}

	public string Tag2Key
	{
		get
		{
			return tag2Key;
		}
		set	
		{
			tag2Key = value;
			DictionaryUtil.Add(QueryParameters, "Tag.2.Key", value);
		}
	}

	public string Tag3Key
	{
		get
		{
			return tag3Key;
		}
		set	
		{
			tag3Key = value;
			DictionaryUtil.Add(QueryParameters, "Tag.3.Key", value);
		}
	}

	public string Tag4Key
	{
		get
		{
			return tag4Key;
		}
		set	
		{
			tag4Key = value;
			DictionaryUtil.Add(QueryParameters, "Tag.4.Key", value);
		}
	}

	public string Tag5Key
	{
		get
		{
			return tag5Key;
		}
		set	
		{
			tag5Key = value;
			DictionaryUtil.Add(QueryParameters, "Tag.5.Key", value);
		}
	}

	public string Tag1Value
	{
		get
		{
			return tag1Value;
		}
		set	
		{
			tag1Value = value;
			DictionaryUtil.Add(QueryParameters, "Tag.1.Value", value);
		}
	}

	public string Tag2Value
	{
		get
		{
			return tag2Value;
		}
		set	
		{
			tag2Value = value;
			DictionaryUtil.Add(QueryParameters, "Tag.2.Value", value);
		}
	}

	public string Tag3Value
	{
		get
		{
			return tag3Value;
		}
		set	
		{
			tag3Value = value;
			DictionaryUtil.Add(QueryParameters, "Tag.3.Value", value);
		}
	}

	public string Tag4Value
	{
		get
		{
			return tag4Value;
		}
		set	
		{
			tag4Value = value;
			DictionaryUtil.Add(QueryParameters, "Tag.4.Value", value);
		}
	}

	public string Tag5Value
	{
		get
		{
			return tag5Value;
		}
		set	
		{
			tag5Value = value;
			DictionaryUtil.Add(QueryParameters, "Tag.5.Value", value);
		}
	}

        public override DescribeDisksResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeDisksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}