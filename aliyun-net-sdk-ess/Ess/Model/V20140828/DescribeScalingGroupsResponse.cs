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

namespace Aliyun.Acs.Ess.Model.V20140828
{
	public class DescribeScalingGroupsResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private List<DescribeScalingGroups_ScalingGroup> scalingGroups;

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

		public List<DescribeScalingGroups_ScalingGroup> ScalingGroups
		{
			get
			{
				return scalingGroups;
			}
			set	
			{
				scalingGroups = value;
			}
		}

		public class DescribeScalingGroups_ScalingGroup
		{

			private int? defaultCooldown;

			private int? maxSize;

			private int? pendingWaitCapacity;

			private int? removingWaitCapacity;

			private int? pendingCapacity;

			private int? removingCapacity;

			private string scalingGroupName;

			private int? activeCapacity;

			private int? standbyCapacity;

			private int? protectedCapacity;

			private string activeScalingConfigurationId;

			private string launchTemplateId;

			private string launchTemplateVersion;

			private string scalingGroupId;

			private string regionId;

			private int? totalCapacity;

			private int? minSize;

			private string lifecycleState;

			private string creationTime;

			private string modificationTime;

			private string vpcId;

			private string vSwitchId;

			private string multiAZPolicy;

			private string healthCheckType;

			private string scalingPolicy;

			private int? stoppedCapacity;

			private int? onDemandBaseCapacity;

			private int? onDemandPercentageAboveBaseCapacity;

			private bool? spotInstanceRemedy;

			private bool? compensateWithOnDemand;

			private int? spotInstancePools;

			private int? desiredCapacity;

			private bool? groupDeletionProtection;

			private bool? scaleOutAmountCheck;

			private List<DescribeScalingGroups_VServerGroup> vServerGroups;

			private List<string> vSwitchIds;

			private List<string> removalPolicies;

			private List<string> dBInstanceIds;

			private List<string> loadBalancerIds;

			private List<string> suspendedProcesses;

			public int? DefaultCooldown
			{
				get
				{
					return defaultCooldown;
				}
				set	
				{
					defaultCooldown = value;
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
				}
			}

			public int? PendingWaitCapacity
			{
				get
				{
					return pendingWaitCapacity;
				}
				set	
				{
					pendingWaitCapacity = value;
				}
			}

			public int? RemovingWaitCapacity
			{
				get
				{
					return removingWaitCapacity;
				}
				set	
				{
					removingWaitCapacity = value;
				}
			}

			public int? PendingCapacity
			{
				get
				{
					return pendingCapacity;
				}
				set	
				{
					pendingCapacity = value;
				}
			}

			public int? RemovingCapacity
			{
				get
				{
					return removingCapacity;
				}
				set	
				{
					removingCapacity = value;
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
				}
			}

			public int? ActiveCapacity
			{
				get
				{
					return activeCapacity;
				}
				set	
				{
					activeCapacity = value;
				}
			}

			public int? StandbyCapacity
			{
				get
				{
					return standbyCapacity;
				}
				set	
				{
					standbyCapacity = value;
				}
			}

			public int? ProtectedCapacity
			{
				get
				{
					return protectedCapacity;
				}
				set	
				{
					protectedCapacity = value;
				}
			}

			public string ActiveScalingConfigurationId
			{
				get
				{
					return activeScalingConfigurationId;
				}
				set	
				{
					activeScalingConfigurationId = value;
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

			public string ScalingGroupId
			{
				get
				{
					return scalingGroupId;
				}
				set	
				{
					scalingGroupId = value;
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

			public int? TotalCapacity
			{
				get
				{
					return totalCapacity;
				}
				set	
				{
					totalCapacity = value;
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
				}
			}

			public string LifecycleState
			{
				get
				{
					return lifecycleState;
				}
				set	
				{
					lifecycleState = value;
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

			public string ModificationTime
			{
				get
				{
					return modificationTime;
				}
				set	
				{
					modificationTime = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
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

			public string MultiAZPolicy
			{
				get
				{
					return multiAZPolicy;
				}
				set	
				{
					multiAZPolicy = value;
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
				}
			}

			public string ScalingPolicy
			{
				get
				{
					return scalingPolicy;
				}
				set	
				{
					scalingPolicy = value;
				}
			}

			public int? StoppedCapacity
			{
				get
				{
					return stoppedCapacity;
				}
				set	
				{
					stoppedCapacity = value;
				}
			}

			public int? OnDemandBaseCapacity
			{
				get
				{
					return onDemandBaseCapacity;
				}
				set	
				{
					onDemandBaseCapacity = value;
				}
			}

			public int? OnDemandPercentageAboveBaseCapacity
			{
				get
				{
					return onDemandPercentageAboveBaseCapacity;
				}
				set	
				{
					onDemandPercentageAboveBaseCapacity = value;
				}
			}

			public bool? SpotInstanceRemedy
			{
				get
				{
					return spotInstanceRemedy;
				}
				set	
				{
					spotInstanceRemedy = value;
				}
			}

			public bool? CompensateWithOnDemand
			{
				get
				{
					return compensateWithOnDemand;
				}
				set	
				{
					compensateWithOnDemand = value;
				}
			}

			public int? SpotInstancePools
			{
				get
				{
					return spotInstancePools;
				}
				set	
				{
					spotInstancePools = value;
				}
			}

			public int? DesiredCapacity
			{
				get
				{
					return desiredCapacity;
				}
				set	
				{
					desiredCapacity = value;
				}
			}

			public bool? GroupDeletionProtection
			{
				get
				{
					return groupDeletionProtection;
				}
				set	
				{
					groupDeletionProtection = value;
				}
			}

			public bool? ScaleOutAmountCheck
			{
				get
				{
					return scaleOutAmountCheck;
				}
				set	
				{
					scaleOutAmountCheck = value;
				}
			}

			public List<DescribeScalingGroups_VServerGroup> VServerGroups
			{
				get
				{
					return vServerGroups;
				}
				set	
				{
					vServerGroups = value;
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
				}
			}

			public List<string> RemovalPolicies
			{
				get
				{
					return removalPolicies;
				}
				set	
				{
					removalPolicies = value;
				}
			}

			public List<string> DBInstanceIds
			{
				get
				{
					return dBInstanceIds;
				}
				set	
				{
					dBInstanceIds = value;
				}
			}

			public List<string> LoadBalancerIds
			{
				get
				{
					return loadBalancerIds;
				}
				set	
				{
					loadBalancerIds = value;
				}
			}

			public List<string> SuspendedProcesses
			{
				get
				{
					return suspendedProcesses;
				}
				set	
				{
					suspendedProcesses = value;
				}
			}

			public class DescribeScalingGroups_VServerGroup
			{

				private string loadBalancerId;

				private List<DescribeScalingGroups_VServerGroupAttribute> vServerGroupAttributes;

				public string LoadBalancerId
				{
					get
					{
						return loadBalancerId;
					}
					set	
					{
						loadBalancerId = value;
					}
				}

				public List<DescribeScalingGroups_VServerGroupAttribute> VServerGroupAttributes
				{
					get
					{
						return vServerGroupAttributes;
					}
					set	
					{
						vServerGroupAttributes = value;
					}
				}

				public class DescribeScalingGroups_VServerGroupAttribute
				{

					private string vServerGroupId;

					private int? port;

					private int? weight;

					public string VServerGroupId
					{
						get
						{
							return vServerGroupId;
						}
						set	
						{
							vServerGroupId = value;
						}
					}

					public int? Port
					{
						get
						{
							return port;
						}
						set	
						{
							port = value;
						}
					}

					public int? Weight
					{
						get
						{
							return weight;
						}
						set	
						{
							weight = value;
						}
					}
				}
			}
		}
	}
}
