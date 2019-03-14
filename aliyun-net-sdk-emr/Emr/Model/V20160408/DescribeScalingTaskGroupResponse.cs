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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeScalingTaskGroupResponse : AcsResponse
	{

		private string requestId;

		private string scalingGroupId;

		private string hostGroupId;

		private int? minSize;

		private int? maxSize;

		private int? defaultCooldown;

		private string status;

		private string activeRuleCategory;

		private DescribeScalingTaskGroup_ScalingConfig scalingConfig;

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

		public string HostGroupId
		{
			get
			{
				return hostGroupId;
			}
			set	
			{
				hostGroupId = value;
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

		public string ActiveRuleCategory
		{
			get
			{
				return activeRuleCategory;
			}
			set	
			{
				activeRuleCategory = value;
			}
		}

		public DescribeScalingTaskGroup_ScalingConfig ScalingConfig
		{
			get
			{
				return scalingConfig;
			}
			set	
			{
				scalingConfig = value;
			}
		}

		public class DescribeScalingTaskGroup_ScalingConfig
		{

			private string payType;

			private string dataDiskCategory;

			private int? dataDiskSize;

			private int? dataDiskCount;

			private string sysDiskCategory;

			private int? sysDiskSize;

			private int? cpuCount;

			private int? memSize;

			private string spotStrategy;

			private List<DescribeScalingTaskGroup_SpotPriceLimit> spotPriceLimits;

			private List<string> instanceTypeList;

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public string DataDiskCategory
			{
				get
				{
					return dataDiskCategory;
				}
				set	
				{
					dataDiskCategory = value;
				}
			}

			public int? DataDiskSize
			{
				get
				{
					return dataDiskSize;
				}
				set	
				{
					dataDiskSize = value;
				}
			}

			public int? DataDiskCount
			{
				get
				{
					return dataDiskCount;
				}
				set	
				{
					dataDiskCount = value;
				}
			}

			public string SysDiskCategory
			{
				get
				{
					return sysDiskCategory;
				}
				set	
				{
					sysDiskCategory = value;
				}
			}

			public int? SysDiskSize
			{
				get
				{
					return sysDiskSize;
				}
				set	
				{
					sysDiskSize = value;
				}
			}

			public int? CpuCount
			{
				get
				{
					return cpuCount;
				}
				set	
				{
					cpuCount = value;
				}
			}

			public int? MemSize
			{
				get
				{
					return memSize;
				}
				set	
				{
					memSize = value;
				}
			}

			public string SpotStrategy
			{
				get
				{
					return spotStrategy;
				}
				set	
				{
					spotStrategy = value;
				}
			}

			public List<DescribeScalingTaskGroup_SpotPriceLimit> SpotPriceLimits
			{
				get
				{
					return spotPriceLimits;
				}
				set	
				{
					spotPriceLimits = value;
				}
			}

			public List<string> InstanceTypeList
			{
				get
				{
					return instanceTypeList;
				}
				set	
				{
					instanceTypeList = value;
				}
			}

			public class DescribeScalingTaskGroup_SpotPriceLimit
			{

				private string instanceType;

				private float? priceLimit;

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

				public float? PriceLimit
				{
					get
					{
						return priceLimit;
					}
					set	
					{
						priceLimit = value;
					}
				}
			}
		}
	}
}
