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
	public class DescribeDedicatedHostClustersResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeDedicatedHostClusters_DedicatedHostCluster> dedicatedHostClusters;

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

		public List<DescribeDedicatedHostClusters_DedicatedHostCluster> DedicatedHostClusters
		{
			get
			{
				return dedicatedHostClusters;
			}
			set	
			{
				dedicatedHostClusters = value;
			}
		}

		public class DescribeDedicatedHostClusters_DedicatedHostCluster
		{

			private string dedicatedHostClusterId;

			private string regionId;

			private string zoneId;

			private string dedicatedHostClusterName;

			private string description;

			private string resourceGroupId;

			private List<DescribeDedicatedHostClusters_Tag> tags;

			private List<string> dedicatedHostIds;

			private DescribeDedicatedHostClusters_DedicatedHostClusterCapacity dedicatedHostClusterCapacity;

			public string DedicatedHostClusterId
			{
				get
				{
					return dedicatedHostClusterId;
				}
				set	
				{
					dedicatedHostClusterId = value;
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

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string DedicatedHostClusterName
			{
				get
				{
					return dedicatedHostClusterName;
				}
				set	
				{
					dedicatedHostClusterName = value;
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
				}
			}

			public List<DescribeDedicatedHostClusters_Tag> Tags
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

			public List<string> DedicatedHostIds
			{
				get
				{
					return dedicatedHostIds;
				}
				set	
				{
					dedicatedHostIds = value;
				}
			}

			public DescribeDedicatedHostClusters_DedicatedHostClusterCapacity DedicatedHostClusterCapacity
			{
				get
				{
					return dedicatedHostClusterCapacity;
				}
				set	
				{
					dedicatedHostClusterCapacity = value;
				}
			}

			public class DescribeDedicatedHostClusters_Tag
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}

			public class DescribeDedicatedHostClusters_DedicatedHostClusterCapacity
			{

				private int? totalVcpus;

				private int? availableVcpus;

				private int? totalMemory;

				private int? availableMemory;

				private List<DescribeDedicatedHostClusters_LocalStorageCapacity> localStorageCapacities;

				private List<DescribeDedicatedHostClusters_AvailableInstanceType> availableInstanceTypes;

				public int? TotalVcpus
				{
					get
					{
						return totalVcpus;
					}
					set	
					{
						totalVcpus = value;
					}
				}

				public int? AvailableVcpus
				{
					get
					{
						return availableVcpus;
					}
					set	
					{
						availableVcpus = value;
					}
				}

				public int? TotalMemory
				{
					get
					{
						return totalMemory;
					}
					set	
					{
						totalMemory = value;
					}
				}

				public int? AvailableMemory
				{
					get
					{
						return availableMemory;
					}
					set	
					{
						availableMemory = value;
					}
				}

				public List<DescribeDedicatedHostClusters_LocalStorageCapacity> LocalStorageCapacities
				{
					get
					{
						return localStorageCapacities;
					}
					set	
					{
						localStorageCapacities = value;
					}
				}

				public List<DescribeDedicatedHostClusters_AvailableInstanceType> AvailableInstanceTypes
				{
					get
					{
						return availableInstanceTypes;
					}
					set	
					{
						availableInstanceTypes = value;
					}
				}

				public class DescribeDedicatedHostClusters_LocalStorageCapacity
				{

					private int? totalDisk;

					private int? availableDisk;

					private string dataDiskCategory;

					public int? TotalDisk
					{
						get
						{
							return totalDisk;
						}
						set	
						{
							totalDisk = value;
						}
					}

					public int? AvailableDisk
					{
						get
						{
							return availableDisk;
						}
						set	
						{
							availableDisk = value;
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
				}

				public class DescribeDedicatedHostClusters_AvailableInstanceType
				{

					private string instanceType;

					private int? availableInstanceCapacity;

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

					public int? AvailableInstanceCapacity
					{
						get
						{
							return availableInstanceCapacity;
						}
						set	
						{
							availableInstanceCapacity = value;
						}
					}
				}
			}
		}
	}
}
