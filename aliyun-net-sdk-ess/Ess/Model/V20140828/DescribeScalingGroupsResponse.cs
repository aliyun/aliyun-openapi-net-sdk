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
using System.Collections.Generic;

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

			private int? pendingCapacity;

			private int? removingCapacity;

			private string scalingGroupName;

			private int? activeCapacity;

			private string activeScalingConfigurationId;

			private string scalingGroupId;

			private string regionId;

			private int? totalCapacity;

			private int? minSize;

			private string lifecycleState;

			private string creationTime;

			private string vpcId;

			private string vSwitchId;

			private List<string> removalPolicies;

			private List<string> dBInstanceIds;

			private List<string> loadBalancerIds;

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
		}
	}
}