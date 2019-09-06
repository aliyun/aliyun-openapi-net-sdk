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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeAutoProvisioningGroupsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeAutoProvisioningGroups_AutoProvisioningGroup> autoProvisioningGroups;

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

			private string autoProvisioningGroupId;

			private string autoProvisioningGroupName;

			private string autoProvisioningGroupType;

			private string status;

			private string state;

			private string regionId;

			private string validFrom;

			private string validUntil;

			private string excessCapacityTerminationPolicy;

			private float? maxSpotPrice;

			private string launchTemplateId;

			private string launchTemplateVersion;

			private bool? terminateInstances;

			private bool? terminateInstancesWithExpiration;

			private string creationTime;

			private List<DescribeAutoProvisioningGroups_LaunchTemplateConfig> launchTemplateConfigs;

			private DescribeAutoProvisioningGroups_SpotOptions spotOptions;

			private DescribeAutoProvisioningGroups_PayAsYouGoOptions payAsYouGoOptions;

			private DescribeAutoProvisioningGroups_TargetCapacitySpecification targetCapacitySpecification;

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

				private string instanceType;

				private float? maxPrice;

				private string vSwitchId;

				private float? weightedCapacity;

				private float? priority;

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
			}

			public class DescribeAutoProvisioningGroups_SpotOptions
			{

				private string allocationStrategy;

				private string instanceInterruptionBehavior;

				private int? instancePoolsToUseCount;

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

				private float? totalTargetCapacity;

				private float? payAsYouGoTargetCapacity;

				private float? spotTargetCapacity;

				private string defaultTargetCapacityType;

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
			}
		}
	}
}
