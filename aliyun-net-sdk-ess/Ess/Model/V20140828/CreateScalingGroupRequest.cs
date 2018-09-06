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

		private string multiAZPolicy;

		private string dBInstanceIds;

		private string launchTemplateId;

		private string loadBalancerIds;

		private string healthCheckType;

		private string resourceOwnerAccount;

		private string scalingGroupName;

		private List<string> vSwitchIds;

		private string ownerAccount;

		private int? minSize;

		private long? ownerId;

		private string launchTemplateVersion;

		private string accessKeyId;

		private string vSwitchId;

		private string regionId;

		private string action;

		private int? maxSize;

		private List<LifecycleHook> lifecycleHooks;

		private int? defaultCooldown;

		private string removalPolicy1;

		private string removalPolicy2;

		public string MultiAZPolicy
		{
			get
			{
				return multiAZPolicy;
			}
			set	
			{
				multiAZPolicy = value;
				DictionaryUtil.Add(QueryParameters, "MultiAZPolicy", value);
			}
		}

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

		public string LaunchTemplateId
		{
			get
			{
				return launchTemplateId;
			}
			set	
			{
				launchTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateId", value);
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

		public string HealthCheckType
		{
			get
			{
				return healthCheckType;
			}
			set	
			{
				healthCheckType = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckType", value);
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

		public List<string> VSwitchIds
		{
			get
			{
				return vSwitchIds;
			}

			set
			{
				vSwitchIds = value;
				for (int i = 0; i < vSwitchIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"VSwitchIds." + (i + 1) , vSwitchIds[i]);
				}
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

		public string LaunchTemplateVersion
		{
			get
			{
				return launchTemplateVersion;
			}
			set	
			{
				launchTemplateVersion = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateVersion", value);
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

		public List<LifecycleHook> LifecycleHooks
		{
			get
			{
				return lifecycleHooks;
			}

			set
			{
				lifecycleHooks = value;
				for (int i = 0; i < lifecycleHooks.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LifecycleHook." + (i + 1) + ".DefaultResult", lifecycleHooks[i].DefaultResult);
					DictionaryUtil.Add(QueryParameters,"LifecycleHook." + (i + 1) + ".LifecycleHookName", lifecycleHooks[i].LifecycleHookName);
					DictionaryUtil.Add(QueryParameters,"LifecycleHook." + (i + 1) + ".HeartbeatTimeout", lifecycleHooks[i].HeartbeatTimeout);
					DictionaryUtil.Add(QueryParameters,"LifecycleHook." + (i + 1) + ".NotificationArn", lifecycleHooks[i].NotificationArn);
					DictionaryUtil.Add(QueryParameters,"LifecycleHook." + (i + 1) + ".NotificationMetadata", lifecycleHooks[i].NotificationMetadata);
					DictionaryUtil.Add(QueryParameters,"LifecycleHook." + (i + 1) + ".LifecycleTransition", lifecycleHooks[i].LifecycleTransition);
				}
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

		public class LifecycleHook
		{

			private string defaultResult;

			private string lifecycleHookName;

			private int? heartbeatTimeout;

			private string notificationArn;

			private string notificationMetadata;

			private string lifecycleTransition;

			public string DefaultResult
			{
				get
				{
					return defaultResult;
				}
				set	
				{
					defaultResult = value;
				}
			}

			public string LifecycleHookName
			{
				get
				{
					return lifecycleHookName;
				}
				set	
				{
					lifecycleHookName = value;
				}
			}

			public int? HeartbeatTimeout
			{
				get
				{
					return heartbeatTimeout;
				}
				set	
				{
					heartbeatTimeout = value;
				}
			}

			public string NotificationArn
			{
				get
				{
					return notificationArn;
				}
				set	
				{
					notificationArn = value;
				}
			}

			public string NotificationMetadata
			{
				get
				{
					return notificationMetadata;
				}
				set	
				{
					notificationMetadata = value;
				}
			}

			public string LifecycleTransition
			{
				get
				{
					return lifecycleTransition;
				}
				set	
				{
					lifecycleTransition = value;
				}
			}
		}

        public override CreateScalingGroupResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateScalingGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}