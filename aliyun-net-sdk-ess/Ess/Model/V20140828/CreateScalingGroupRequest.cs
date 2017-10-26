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
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;
using System.Collections.Generic;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class CreateScalingGroupRequest : RpcAcsRequest<CreateScalingGroupResponse>
    {
        public CreateScalingGroupRequest()
            : base("Ess", "2014-08-28", "CreateScalingGroup", "ess", "openAPI")
        {
        }

		private string dBInstanceIds;

		private string loadBalancerIds;

		private string resourceOwnerAccount;

		private string scalingGroupName;

		private string ownerAccount;

		private int? minSize;

		private long? ownerId;

		private string accessKeyId;

		private string vSwitchId;

		private string regionId;

		private string action;

		private int? maxSize;

		private int? defaultCooldown;

		private string removalPolicy1;

		private string removalPolicy2;

		public string DBInstanceIds
		{
			get
			{
				return dBInstanceIds;
			}
			set	
			{
				dBInstanceIds = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceIds", value);
			}
		}

		public string LoadBalancerIds
		{
			get
			{
				return loadBalancerIds;
			}
			set	
			{
				loadBalancerIds = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerIds", value);
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

		public string ScalingGroupName
		{
			get
			{
				return scalingGroupName;
			}
			set	
			{
				scalingGroupName = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupName", value);
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

		public int? MinSize
		{
			get
			{
				return minSize;
			}
			set	
			{
				minSize = value;
				DictionaryUtil.Add(QueryParameters, "MinSize", value.ToString());
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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
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
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
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

		public int? MaxSize
		{
			get
			{
				return maxSize;
			}
			set	
			{
				maxSize = value;
				DictionaryUtil.Add(QueryParameters, "MaxSize", value.ToString());
			}
		}

		public int? DefaultCooldown
		{
			get
			{
				return defaultCooldown;
			}
			set	
			{
				defaultCooldown = value;
				DictionaryUtil.Add(QueryParameters, "DefaultCooldown", value.ToString());
			}
		}

		public string RemovalPolicy1
		{
			get
			{
				return removalPolicy1;
			}
			set	
			{
				removalPolicy1 = value;
				DictionaryUtil.Add(QueryParameters, "RemovalPolicy.1", value);
			}
		}

		public string RemovalPolicy2
		{
			get
			{
				return removalPolicy2;
			}
			set	
			{
				removalPolicy2 = value;
				DictionaryUtil.Add(QueryParameters, "RemovalPolicy.2", value);
			}
		}

        public override CreateScalingGroupResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateScalingGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}