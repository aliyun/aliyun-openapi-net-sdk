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
	public class DescribeScalingInstancesResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private List<DescribeScalingInstances_ScalingInstance> scalingInstances;

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

		public List<DescribeScalingInstances_ScalingInstance> ScalingInstances
		{
			get
			{
				return scalingInstances;
			}
			set	
			{
				scalingInstances = value;
			}
		}

		public class DescribeScalingInstances_ScalingInstance
		{

			private string instanceId;

			private string scalingConfigurationId;

			private string scalingGroupId;

			private string healthStatus;

			private int? loadBalancerWeight;

			private string lifecycleState;

			private string creationTime;

			private string creationType;

			private string launchTemplateId;

			private string launchTemplateVersion;

			private string warmupState;

			private bool? entrusted;

			private string createdTime;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string ScalingConfigurationId
			{
				get
				{
					return scalingConfigurationId;
				}
				set	
				{
					scalingConfigurationId = value;
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

			public string HealthStatus
			{
				get
				{
					return healthStatus;
				}
				set	
				{
					healthStatus = value;
				}
			}

			public int? LoadBalancerWeight
			{
				get
				{
					return loadBalancerWeight;
				}
				set	
				{
					loadBalancerWeight = value;
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

			public string CreationType
			{
				get
				{
					return creationType;
				}
				set	
				{
					creationType = value;
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

			public string WarmupState
			{
				get
				{
					return warmupState;
				}
				set	
				{
					warmupState = value;
				}
			}

			public bool? Entrusted
			{
				get
				{
					return entrusted;
				}
				set	
				{
					entrusted = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}
		}
	}
}
