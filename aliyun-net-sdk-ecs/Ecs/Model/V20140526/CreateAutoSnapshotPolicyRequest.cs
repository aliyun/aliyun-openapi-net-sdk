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
    public class CreateAutoSnapshotPolicyRequest : RpcAcsRequest<CreateAutoSnapshotPolicyResponse>
    {
        public CreateAutoSnapshotPolicyRequest()
            : base("Ecs", "2014-05-26", "CreateAutoSnapshotPolicy", "ecs", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string regionId;

		private string action;

		private string timePoints;

		private int? retentionDays;

		private long? ownerId;

		private string repeatWeekdays;

		private string autoSnapshotPolicyName;

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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "regionId", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

        public override CreateAutoSnapshotPolicyResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateAutoSnapshotPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}