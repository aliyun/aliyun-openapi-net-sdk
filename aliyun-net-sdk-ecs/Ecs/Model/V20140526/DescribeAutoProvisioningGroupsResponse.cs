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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeAutoProvisioningGroupsResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeAutoProvisioningGroups_AutoProvisioningGroup> autoProvisioningGroups;

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
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
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeAutoProvisioningGroups_AutoProvisioningGroup> AutoProvisioningGroups
		{
			get
			{
				return autoProvisioningGroups;
			}
			set	
			{
				autoProvisioningGroups = value;
			}
		}

		public class DescribeAutoProvisioningGroups_AutoProvisioningGroup
		{

			private string creationTime;

			private string autoProvisioningGroupName;

			private string status;

			private bool? terminateInstances;

			private float? maxSpotPrice;

			private string state;

			private string launchTemplateId;

			private string validFrom;

			private string launchTemplateVersion;

			private bool? terminateInstancesWithExpiration;

			private string regionId;

			private string validUntil;

			private string autoProvisioningGroupType;

			private string autoProvisioningGroupId;

			private string excessCapacityTerminationPolicy;

			private List<DescribeAutoProvisioningGroups_LaunchTemplateConfig> launchTemplateConfigs;

			private DescribeAutoProvisioningGroups_SpotOptions spotOptions;

			private DescribeAutoProvisioningGroups_PayAsYouGoOptions payAsYouGoOptions;

			private DescribeAutoProvisioningGroups_TargetCapacitySpecification targetCapacitySpecification;

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
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
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
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
				}
			}

			public string AutoProvisioningGroupId
			{
				get
				{
					return autoProvisioningGroupId;
				}
				set	
				{
					autoProvisioningGroupId = value;
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
				}
			}

			public List<DescribeAutoProvisioningGroups_LaunchTemplateConfig> LaunchTemplateConfigs
			{
				get
				{
					return launchTemplateConfigs;
				}
				set	
				{
					launchTemplateConfigs = value;
				}
			}

			public DescribeAutoProvisioningGroups_SpotOptions SpotOptions
			{
				get
				{
					return spotOptions;
				}
				set	
				{
					spotOptions = value;
				}
			}

			public DescribeAutoProvisioningGroups_PayAsYouGoOptions PayAsYouGoOptions
			{
				get
				{
					return payAsYouGoOptions;
				}
				set	
				{
					payAsYouGoOptions = value;
				}
			}

			public DescribeAutoProvisioningGroups_TargetCapacitySpecification TargetCapacitySpecification
			{
				get
				{
					return targetCapacitySpecification;
				}
				set	
				{
					targetCapacitySpecification = value;
				}
			}

			public class DescribeAutoProvisioningGroups_LaunchTemplateConfig
			{

				private float? maxPrice;

				private float? priority;

				private string vSwitchId;

				private float? weightedCapacity;

				private string instanceType;

				public float? MaxPrice
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

				public float? Priority
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

				public float? WeightedCapacity
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
			}

			public class DescribeAutoProvisioningGroups_SpotOptions
			{

				private int? instancePoolsToUseCount;

				private string allocationStrategy;

				private string instanceInterruptionBehavior;

				public int? InstancePoolsToUseCount
				{
					get
					{
						return instancePoolsToUseCount;
					}
					set	
					{
						instancePoolsToUseCount = value;
					}
				}

				public string AllocationStrategy
				{
					get
					{
						return allocationStrategy;
					}
					set	
					{
						allocationStrategy = value;
					}
				}

				public string InstanceInterruptionBehavior
				{
					get
					{
						return instanceInterruptionBehavior;
					}
					set	
					{
						instanceInterruptionBehavior = value;
					}
				}
			}

			public class DescribeAutoProvisioningGroups_PayAsYouGoOptions
			{

				private string allocationStrategy;

				public string AllocationStrategy
				{
					get
					{
						return allocationStrategy;
					}
					set	
					{
						allocationStrategy = value;
					}
				}
			}

			public class DescribeAutoProvisioningGroups_TargetCapacitySpecification
			{

				private float? spotTargetCapacity;

				private float? payAsYouGoTargetCapacity;

				private string defaultTargetCapacityType;

				private float? totalTargetCapacity;

				public float? SpotTargetCapacity
				{
					get
					{
						return spotTargetCapacity;
					}
					set	
					{
						spotTargetCapacity = value;
					}
				}

				public float? PayAsYouGoTargetCapacity
				{
					get
					{
						return payAsYouGoTargetCapacity;
					}
					set	
					{
						payAsYouGoTargetCapacity = value;
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
					}
				}

				public float? TotalTargetCapacity
				{
					get
					{
						return totalTargetCapacity;
					}
					set	
					{
						totalTargetCapacity = value;
					}
				}
			}
		}
	}
}
