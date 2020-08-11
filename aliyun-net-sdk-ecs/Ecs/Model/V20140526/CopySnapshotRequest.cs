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
    public class CopySnapshotRequest : RpcAcsRequest<CopySnapshotResponse>
    {
        public CopySnapshotRequest()
            : base("Ecs", "2014-05-26", "CopySnapshot", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string snapshotId;

		private string destinationRegionId;

		private string resourceGroupId;

		private List<Tag> tags = new List<Tag>(){ };

		private string resourceOwnerAccount;

		private long? ownerId;

		private string destinationSnapshotName;

		private string destinationSnapshotDescription;

		private int? retentionDays;

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

		public string DestinationRegionId
		{
			get
			{
				return destinationRegionId;
			}
			set	
			{
				destinationRegionId = value;
				DictionaryUtil.Add(QueryParameters, "DestinationRegionId", value);
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
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
				}
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

		public string DestinationSnapshotName
		{
			get
			{
				return destinationSnapshotName;
			}
			set	
			{
				destinationSnapshotName = value;
				DictionaryUtil.Add(QueryParameters, "DestinationSnapshotName", value);
			}
		}

		public string DestinationSnapshotDescription
		{
			get
			{
				return destinationSnapshotDescription;
			}
			set	
			{
				destinationSnapshotDescription = value;
				DictionaryUtil.Add(QueryParameters, "DestinationSnapshotDescription", value);
			}
		}

		public int? RetentionDays
		{
			get
			{
				return retentionDays;
			}
			set	
			{
				retentionDays = value;
				DictionaryUtil.Add(QueryParameters, "RetentionDays", value.ToString());
			}
		}

		public class Tag
		{

			private string key;

			private string value_;

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
		}

        public override CopySnapshotResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CopySnapshotResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
