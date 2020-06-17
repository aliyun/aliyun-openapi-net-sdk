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
    public class DescribeSnapshotsRequest : RpcAcsRequest<DescribeSnapshotsResponse>
    {
        public DescribeSnapshotsRequest()
            : base("Ecs", "2014-05-26", "DescribeSnapshots", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string filter2Value;

		private string snapshotIds;

		private string usage;

		private string snapshotLinkId;

		private string snapshotName;

		private int? pageNumber;

		private string resourceGroupId;

		private string filter1Key;

		private int? pageSize;

		private string diskId;

		private List<Tag> tags = new List<Tag>(){ };

		private bool? dryRun;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string sourceDiskType;

		private string filter1Value;

		private string filter2Key;

		private long? ownerId;

		private string instanceId;

		private bool? encrypted;

		private string snapshotType;

		private string kMSKeyId;

		private string category;

		private string status;

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

		public string SnapshotIds
		{
			get
			{
				return snapshotIds;
			}
			set	
			{
				snapshotIds = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotIds", value);
			}
		}

		public string Usage
		{
			get
			{
				return usage;
			}
			set	
			{
				usage = value;
				DictionaryUtil.Add(QueryParameters, "Usage", value);
			}
		}

		public string SnapshotLinkId
		{
			get
			{
				return snapshotLinkId;
			}
			set	
			{
				snapshotLinkId = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotLinkId", value);
			}
		}

		public string SnapshotName
		{
			get
			{
				return snapshotName;
			}
			set	
			{
				snapshotName = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotName", value);
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

		public string DiskId
		{
			get
			{
				return diskId;
			}
			set	
			{
				diskId = value;
				DictionaryUtil.Add(QueryParameters, "DiskId", value);
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

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
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

		public string SourceDiskType
		{
			get
			{
				return sourceDiskType;
			}
			set	
			{
				sourceDiskType = value;
				DictionaryUtil.Add(QueryParameters, "SourceDiskType", value);
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

		public string SnapshotType
		{
			get
			{
				return snapshotType;
			}
			set	
			{
				snapshotType = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotType", value);
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

        public override DescribeSnapshotsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSnapshotsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
