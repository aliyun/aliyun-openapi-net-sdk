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
    public class CreateAutoProvisioningGroupRequest : RpcAcsRequest<CreateAutoProvisioningGroupResponse>
    {
        public CreateAutoProvisioningGroupRequest()
            : base("Ecs", "2014-05-26", "CreateAutoProvisioningGroup", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string autoProvisioningGroupType;

		private string description;

		private bool? terminateInstancesWithExpiration;

		private string resourceGroupId;

		private string spotAllocationStrategy;

		private bool? terminateInstances;

		private string payAsYouGoAllocationStrategy;

		private string defaultTargetCapacityType;

		private string excessCapacityTerminationPolicy;

		private List<LaunchTemplateConfig> launchTemplateConfigs = new List<LaunchTemplateConfig>(){ };

		private string validUntil;

		private string spotInstanceInterruptionBehavior;

		private string launchTemplateId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? spotInstancePoolsToUseCount;

		private long? ownerId;

		private string launchTemplateVersion;

		private string payAsYouGoTargetCapacity;

		private string totalTargetCapacity;

		private string spotTargetCapacity;

		private string validFrom;

		private string autoProvisioningGroupName;

		private float? maxSpotPrice;

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

		public string AutoProvisioningGroupType
		{
			get
			{
				return autoProvisioningGroupType;
			}
			set	
			{
				autoProvisioningGroupType = value;
				DictionaryUtil.Add(QueryParameters, "AutoProvisioningGroupType", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public bool? TerminateInstancesWithExpiration
		{
			get
			{
				return terminateInstancesWithExpiration;
			}
			set	
			{
				terminateInstancesWithExpiration = value;
				DictionaryUtil.Add(QueryParameters, "TerminateInstancesWithExpiration", value.ToString());
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

		public string SpotAllocationStrategy
		{
			get
			{
				return spotAllocationStrategy;
			}
			set	
			{
				spotAllocationStrategy = value;
				DictionaryUtil.Add(QueryParameters, "SpotAllocationStrategy", value);
			}
		}

		public bool? TerminateInstances
		{
			get
			{
				return terminateInstances;
			}
			set	
			{
				terminateInstances = value;
				DictionaryUtil.Add(QueryParameters, "TerminateInstances", value.ToString());
			}
		}

		public string PayAsYouGoAllocationStrategy
		{
			get
			{
				return payAsYouGoAllocationStrategy;
			}
			set	
			{
				payAsYouGoAllocationStrategy = value;
				DictionaryUtil.Add(QueryParameters, "PayAsYouGoAllocationStrategy", value);
			}
		}

		public string DefaultTargetCapacityType
		{
			get
			{
				return defaultTargetCapacityType;
			}
			set	
			{
				defaultTargetCapacityType = value;
				DictionaryUtil.Add(QueryParameters, "DefaultTargetCapacityType", value);
			}
		}

		public string ExcessCapacityTerminationPolicy
		{
			get
			{
				return excessCapacityTerminationPolicy;
			}
			set	
			{
				excessCapacityTerminationPolicy = value;
				DictionaryUtil.Add(QueryParameters, "ExcessCapacityTerminationPolicy", value);
			}
		}

		public List<LaunchTemplateConfig> LaunchTemplateConfigs
		{
			get
			{
				return launchTemplateConfigs;
			}

			set
			{
				launchTemplateConfigs = value;
				for (int i = 0; i < launchTemplateConfigs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (i + 1) + ".InstanceType", launchTemplateConfigs[i].InstanceType);
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (i + 1) + ".MaxPrice", launchTemplateConfigs[i].MaxPrice);
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (i + 1) + ".VSwitchId", launchTemplateConfigs[i].VSwitchId);
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (i + 1) + ".WeightedCapacity", launchTemplateConfigs[i].WeightedCapacity);
					DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (i + 1) + ".Priority", launchTemplateConfigs[i].Priority);
				}
			}
		}

		public string ValidUntil
		{
			get
			{
				return validUntil;
			}
			set	
			{
				validUntil = value;
				DictionaryUtil.Add(QueryParameters, "ValidUntil", value);
			}
		}

		public string SpotInstanceInterruptionBehavior
		{
			get
			{
				return spotInstanceInterruptionBehavior;
			}
			set	
			{
				spotInstanceInterruptionBehavior = value;
				DictionaryUtil.Add(QueryParameters, "SpotInstanceInterruptionBehavior", value);
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

		public int? SpotInstancePoolsToUseCount
		{
			get
			{
				return spotInstancePoolsToUseCount;
			}
			set	
			{
				spotInstancePoolsToUseCount = value;
				DictionaryUtil.Add(QueryParameters, "SpotInstancePoolsToUseCount", value.ToString());
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

		public string PayAsYouGoTargetCapacity
		{
			get
			{
				return payAsYouGoTargetCapacity;
			}
			set	
			{
				payAsYouGoTargetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "PayAsYouGoTargetCapacity", value);
			}
		}

		public string TotalTargetCapacity
		{
			get
			{
				return totalTargetCapacity;
			}
			set	
			{
				totalTargetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "TotalTargetCapacity", value);
			}
		}

		public string SpotTargetCapacity
		{
			get
			{
				return spotTargetCapacity;
			}
			set	
			{
				spotTargetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "SpotTargetCapacity", value);
			}
		}

		public string ValidFrom
		{
			get
			{
				return validFrom;
			}
			set	
			{
				validFrom = value;
				DictionaryUtil.Add(QueryParameters, "ValidFrom", value);
			}
		}

		public string AutoProvisioningGroupName
		{
			get
			{
				return autoProvisioningGroupName;
			}
			set	
			{
				autoProvisioningGroupName = value;
				DictionaryUtil.Add(QueryParameters, "AutoProvisioningGroupName", value);
			}
		}

		public float? MaxSpotPrice
		{
			get
			{
				return maxSpotPrice;
			}
			set	
			{
				maxSpotPrice = value;
				DictionaryUtil.Add(QueryParameters, "MaxSpotPrice", value.ToString());
			}
		}

		public class LaunchTemplateConfig
		{

			private string instanceType;

			private double? maxPrice;

			private string vSwitchId;

			private double? weightedCapacity;

			private int? priority;

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public double? MaxPrice
			{
				get
				{
					return maxPrice;
				}
				set	
				{
					maxPrice = value;
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
				}
			}

			public double? WeightedCapacity
			{
				get
				{
					return weightedCapacity;
				}
				set	
				{
					weightedCapacity = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}
		}

        public override CreateAutoProvisioningGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAutoProvisioningGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
