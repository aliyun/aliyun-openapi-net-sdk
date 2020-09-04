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
    public class DescribeDisksRequest : RpcAcsRequest<DescribeDisksResponse>
    {
        public DescribeDisksRequest()
            : base("Ecs", "2014-05-26", "DescribeDisks", "ecs", "openAPI")
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

		private string autoSnapshotPolicyId;

		private string diskName;

		private bool? deleteAutoSnapshot;

		private string resourceGroupId;

		private string diskChargeType;

		private string lockReason;

		private string filter1Key;

		private List<Tag> tags = new List<Tag>(){ };

		private bool? enableAutoSnapshot;

		private bool? dryRun;

		private string filter1Value;

		private bool? portable;

		private long? ownerId;

		private List<string> additionalAttributess = new List<string>(){ };

		private string instanceId;

		private string zoneId;

		private int? maxResults;

		private string status;

		private string snapshotId;

		private int? pageNumber;

		private string nextToken;

		private int? pageSize;

		private string diskIds;

		private bool? deleteWithInstance;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private bool? enableAutomatedSnapshotPolicy;

		private string filter2Key;

		private string diskType;

		private bool? enableShared;

		private bool? encrypted;

		private string category;

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

		public string AutoSnapshotPolicyId
		{
			get
			{
				return autoSnapshotPolicyId;
			}
			set	
			{
				autoSnapshotPolicyId = value;
				DictionaryUtil.Add(QueryParameters, "AutoSnapshotPolicyId", value);
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

		public List<string> AdditionalAttributess
		{
			get
			{
				return additionalAttributess;
			}

			set
			{
				additionalAttributess = value;
				for (int i = 0; i < additionalAttributess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AdditionalAttributes." + (i + 1) , additionalAttributess[i]);
				}
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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
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

		public bool? EnableAutomatedSnapshotPolicy
		{
			get
			{
				return enableAutomatedSnapshotPolicy;
			}
			set	
			{
				enableAutomatedSnapshotPolicy = value;
				DictionaryUtil.Add(QueryParameters, "EnableAutomatedSnapshotPolicy", value.ToString());
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

		public bool? EnableShared
		{
			get
			{
				return enableShared;
			}
			set	
			{
				enableShared = value;
				DictionaryUtil.Add(QueryParameters, "EnableShared", value.ToString());
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

        public override DescribeDisksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDisksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
