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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyAutoSnapshotPolicyExRequest : RpcAcsRequest<ModifyAutoSnapshotPolicyExResponse>
    {
        public ModifyAutoSnapshotPolicyExRequest()
            : base("Ecs", "2014-05-26", "ModifyAutoSnapshotPolicyEx", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string autoSnapshotPolicyId;

		private int? copiedSnapshotsRetentionDays;

		private string timePoints;

		private string repeatWeekdays;

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

		public string AutoSnapshotPolicyId
		{
			get
			{
				return autoSnapshotPolicyId;
			}
			set	
			{
				autoSnapshotPolicyId = value;
				DictionaryUtil.Add(QueryParameters, "autoSnapshotPolicyId", value);
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

        public override ModifyAutoSnapshotPolicyExResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyAutoSnapshotPolicyExResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
