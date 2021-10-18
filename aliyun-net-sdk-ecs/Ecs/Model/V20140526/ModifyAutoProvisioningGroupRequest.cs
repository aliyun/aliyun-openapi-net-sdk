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
    public class ModifyAutoProvisioningGroupRequest : RpcAcsRequest<ModifyAutoProvisioningGroupResponse>
    {
        public ModifyAutoProvisioningGroupRequest()
            : base("Ecs", "2014-05-26", "ModifyAutoProvisioningGroup", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private bool? terminateInstancesWithExpiration;

		private string defaultTargetCapacityType;

		private string excessCapacityTerminationPolicy;

		private List<string> launchTemplateConfigs = new List<string>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string autoProvisioningGroupId;

		private string payAsYouGoTargetCapacity;

		private string totalTargetCapacity;

		private string spotTargetCapacity;

		private float? maxSpotPrice;

		private string autoProvisioningGroupName;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "TerminateInstancesWithExpiration")]
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

		[JsonProperty(PropertyName = "DefaultTargetCapacityType")]
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

		[JsonProperty(PropertyName = "ExcessCapacityTerminationPolicy")]
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

		[JsonProperty(PropertyName = "LaunchTemplateConfig")]
		public List<string> LaunchTemplateConfigs
		{
			get
			{
				return launchTemplateConfigs;
			}

			set
			{
				launchTemplateConfigs = value;
				if(launchTemplateConfigs != null)
				{
					for (int depth1 = 0; depth1 < launchTemplateConfigs.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (depth1 + 1), launchTemplateConfigs[depth1]);
						DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (depth1 + 1), launchTemplateConfigs[depth1]);
						DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (depth1 + 1), launchTemplateConfigs[depth1]);
						DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (depth1 + 1), launchTemplateConfigs[depth1]);
						DictionaryUtil.Add(QueryParameters,"LaunchTemplateConfig." + (depth1 + 1), launchTemplateConfigs[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "AutoProvisioningGroupId")]
		public string AutoProvisioningGroupId
		{
			get
			{
				return autoProvisioningGroupId;
			}
			set	
			{
				autoProvisioningGroupId = value;
				DictionaryUtil.Add(QueryParameters, "AutoProvisioningGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "PayAsYouGoTargetCapacity")]
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

		[JsonProperty(PropertyName = "TotalTargetCapacity")]
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

		[JsonProperty(PropertyName = "SpotTargetCapacity")]
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

		[JsonProperty(PropertyName = "MaxSpotPrice")]
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

		[JsonProperty(PropertyName = "AutoProvisioningGroupName")]
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

		public class LaunchTemplateConfig
		{

			private string vSwitchId;

			private double? maxPrice;

			private int? priority;

			private string instanceType;

			private double? weightedCapacity;

			[JsonProperty(PropertyName = "VSwitchId")]
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

			[JsonProperty(PropertyName = "MaxPrice")]
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

			[JsonProperty(PropertyName = "Priority")]
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

			[JsonProperty(PropertyName = "InstanceType")]
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

			[JsonProperty(PropertyName = "WeightedCapacity")]
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
		}

        public override ModifyAutoProvisioningGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyAutoProvisioningGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
