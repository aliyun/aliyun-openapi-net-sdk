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
	public class DescribeScalingConfigurationsResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private List<DescribeScalingConfigurations_ScalingConfiguration> scalingConfigurations;

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

		public List<DescribeScalingConfigurations_ScalingConfiguration> ScalingConfigurations
		{
			get
			{
				return scalingConfigurations;
			}
			set	
			{
				scalingConfigurations = value;
			}
		}

		public class DescribeScalingConfigurations_ScalingConfiguration
		{

			private string scalingConfigurationId;

			private string scalingConfigurationName;

			private string scalingGroupId;

			private string imageId;

			private string instanceType;

			private string instanceGeneration;

			private string securityGroupId;

			private string ioOptimized;

			private string internetChargeType;

			private int? internetMaxBandwidthIn;

			private int? internetMaxBandwidthOut;

			private string systemDiskCategory;

			private int? systemDiskSize;

			private string lifecycleState;

			private string creationTime;

			private int? loadBalancerWeight;

			private string userData;

			private string keyPairName;

			private string ramRoleName;

			private string deploymentSetId;

			private string securityEnhancementStrategy;

			private List<DescribeScalingConfigurations_DataDisk> dataDisks;

			private List<DescribeScalingConfigurations_Tag> tags;

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

			public string ScalingConfigurationName
			{
				get
				{
					return scalingConfigurationName;
				}
				set	
				{
					scalingConfigurationName = value;
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

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
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

			public string InstanceGeneration
			{
				get
				{
					return instanceGeneration;
				}
				set	
				{
					instanceGeneration = value;
				}
			}

			public string SecurityGroupId
			{
				get
				{
					return securityGroupId;
				}
				set	
				{
					securityGroupId = value;
				}
			}

			public string IoOptimized
			{
				get
				{
					return ioOptimized;
				}
				set	
				{
					ioOptimized = value;
				}
			}

			public string InternetChargeType
			{
				get
				{
					return internetChargeType;
				}
				set	
				{
					internetChargeType = value;
				}
			}

			public int? InternetMaxBandwidthIn
			{
				get
				{
					return internetMaxBandwidthIn;
				}
				set	
				{
					internetMaxBandwidthIn = value;
				}
			}

			public int? InternetMaxBandwidthOut
			{
				get
				{
					return internetMaxBandwidthOut;
				}
				set	
				{
					internetMaxBandwidthOut = value;
				}
			}

			public string SystemDiskCategory
			{
				get
				{
					return systemDiskCategory;
				}
				set	
				{
					systemDiskCategory = value;
				}
			}

			public int? SystemDiskSize
			{
				get
				{
					return systemDiskSize;
				}
				set	
				{
					systemDiskSize = value;
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

			public string UserData
			{
				get
				{
					return userData;
				}
				set	
				{
					userData = value;
				}
			}

			public string KeyPairName
			{
				get
				{
					return keyPairName;
				}
				set	
				{
					keyPairName = value;
				}
			}

			public string RamRoleName
			{
				get
				{
					return ramRoleName;
				}
				set	
				{
					ramRoleName = value;
				}
			}

			public string DeploymentSetId
			{
				get
				{
					return deploymentSetId;
				}
				set	
				{
					deploymentSetId = value;
				}
			}

			public string SecurityEnhancementStrategy
			{
				get
				{
					return securityEnhancementStrategy;
				}
				set	
				{
					securityEnhancementStrategy = value;
				}
			}

			public List<DescribeScalingConfigurations_DataDisk> DataDisks
			{
				get
				{
					return dataDisks;
				}
				set	
				{
					dataDisks = value;
				}
			}

			public List<DescribeScalingConfigurations_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class DescribeScalingConfigurations_DataDisk
			{

				private int? size;

				private string category;

				private string snapshotId;

				private string device;

				public int? Size
				{
					get
					{
						return size;
					}
					set	
					{
						size = value;
					}
				}

				public string Category
				{
					get
					{
						return category;
					}
					set	
					{
						category = value;
					}
				}

				public string SnapshotId
				{
					get
					{
						return snapshotId;
					}
					set	
					{
						snapshotId = value;
					}
				}

				public string Device
				{
					get
					{
						return device;
					}
					set	
					{
						device = value;
					}
				}
			}

			public class DescribeScalingConfigurations_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}