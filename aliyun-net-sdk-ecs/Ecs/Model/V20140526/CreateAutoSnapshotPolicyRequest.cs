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
    public class CreateAutoSnapshotPolicyRequest : RpcAcsRequest<CreateAutoSnapshotPolicyResponse>
    {
        public CreateAutoSnapshotPolicyRequest()
            : base("Ecs", "2014-05-26", "CreateAutoSnapshotPolicy", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? copiedSnapshotsRetentionDays;

		private string timePoints;

		private string repeatWeekdays;

		private List<Tag> tags = new List<Tag>(){ };

		private bool? enableCrossRegionCopy;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string autoSnapshotPolicyName;

		private int? retentionDays;

		private string targetCopyRegions;

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

		public int? CopiedSnapshotsRetentionDays
		{
			get
			{
				return copiedSnapshotsRetentionDays;
			}
			set	
			{
				copiedSnapshotsRetentionDays = value;
				DictionaryUtil.Add(QueryParameters, "CopiedSnapshotsRetentionDays", value.ToString());
			}
		}

		public string TimePoints
		{
			get
			{
				return timePoints;
			}
			set	
			{
				timePoints = value;
				DictionaryUtil.Add(QueryParameters, "timePoints", value);
			}
		}

		public string RepeatWeekdays
		{
			get
			{
				return repeatWeekdays;
			}
			set	
			{
				repeatWeekdays = value;
				DictionaryUtil.Add(QueryParameters, "repeatWeekdays", value);
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

		public bool? EnableCrossRegionCopy
		{
			get
			{
				return enableCrossRegionCopy;
			}
			set	
			{
				enableCrossRegionCopy = value;
				DictionaryUtil.Add(QueryParameters, "EnableCrossRegionCopy", value.ToString());
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

		public string AutoSnapshotPolicyName
		{
			get
			{
				return autoSnapshotPolicyName;
			}
			set	
			{
				autoSnapshotPolicyName = value;
				DictionaryUtil.Add(QueryParameters, "autoSnapshotPolicyName", value);
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
				DictionaryUtil.Add(QueryParameters, "retentionDays", value.ToString());
			}
		}

		public string TargetCopyRegions
		{
			get
			{
				return targetCopyRegions;
			}
			set	
			{
				targetCopyRegions = value;
				DictionaryUtil.Add(QueryParameters, "TargetCopyRegions", value);
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

        public override CreateAutoSnapshotPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAutoSnapshotPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
