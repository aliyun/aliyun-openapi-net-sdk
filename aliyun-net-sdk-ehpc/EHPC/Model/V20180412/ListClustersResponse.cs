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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListClustersResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListClusters_ClusterInfoSimple> clusters;

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

		public List<ListClusters_ClusterInfoSimple> Clusters
		{
			get
			{
				return clusters;
			}
			set	
			{
				clusters = value;
			}
		}

		public class ListClusters_ClusterInfoSimple
		{

			private string id;

			private string regionId;

			private string zoneId;

			private string vSwitchId;

			private string vpcId;

			private string name;

			private string description;

			private string status;

			private string osTag;

			private string accountType;

			private string schedulerType;

			private string deployMode;

			private int? count;

			private string instanceType;

			private string loginNodes;

			private string createTime;

			private string imageOwnerAlias;

			private string imageId;

			private string location;

			private string ehpcVersion;

			private string nodePrefix;

			private string nodeSuffix;

			private string baseOsTag;

			private string instanceChargeType;

			private string computeSpotStrategy;

			private float? computeSpotPriceLimit;

			private string clientVersion;

			private bool? isComputeEss;

			private ListClusters_Managers managers;

			private ListClusters_Computes computes;

			private ListClusters_TotalResources totalResources;

			private ListClusters_UsedResources usedResources;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
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

			public string OsTag
			{
				get
				{
					return osTag;
				}
				set	
				{
					osTag = value;
				}
			}

			public string AccountType
			{
				get
				{
					return accountType;
				}
				set	
				{
					accountType = value;
				}
			}

			public string SchedulerType
			{
				get
				{
					return schedulerType;
				}
				set	
				{
					schedulerType = value;
				}
			}

			public string DeployMode
			{
				get
				{
					return deployMode;
				}
				set	
				{
					deployMode = value;
				}
			}

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
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

			public string LoginNodes
			{
				get
				{
					return loginNodes;
				}
				set	
				{
					loginNodes = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string ImageOwnerAlias
			{
				get
				{
					return imageOwnerAlias;
				}
				set	
				{
					imageOwnerAlias = value;
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

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string EhpcVersion
			{
				get
				{
					return ehpcVersion;
				}
				set	
				{
					ehpcVersion = value;
				}
			}

			public string NodePrefix
			{
				get
				{
					return nodePrefix;
				}
				set	
				{
					nodePrefix = value;
				}
			}

			public string NodeSuffix
			{
				get
				{
					return nodeSuffix;
				}
				set	
				{
					nodeSuffix = value;
				}
			}

			public string BaseOsTag
			{
				get
				{
					return baseOsTag;
				}
				set	
				{
					baseOsTag = value;
				}
			}

			public string InstanceChargeType
			{
				get
				{
					return instanceChargeType;
				}
				set	
				{
					instanceChargeType = value;
				}
			}

			public string ComputeSpotStrategy
			{
				get
				{
					return computeSpotStrategy;
				}
				set	
				{
					computeSpotStrategy = value;
				}
			}

			public float? ComputeSpotPriceLimit
			{
				get
				{
					return computeSpotPriceLimit;
				}
				set	
				{
					computeSpotPriceLimit = value;
				}
			}

			public string ClientVersion
			{
				get
				{
					return clientVersion;
				}
				set	
				{
					clientVersion = value;
				}
			}

			public bool? IsComputeEss
			{
				get
				{
					return isComputeEss;
				}
				set	
				{
					isComputeEss = value;
				}
			}

			public ListClusters_Managers Managers
			{
				get
				{
					return managers;
				}
				set	
				{
					managers = value;
				}
			}

			public ListClusters_Computes Computes
			{
				get
				{
					return computes;
				}
				set	
				{
					computes = value;
				}
			}

			public ListClusters_TotalResources TotalResources
			{
				get
				{
					return totalResources;
				}
				set	
				{
					totalResources = value;
				}
			}

			public ListClusters_UsedResources UsedResources
			{
				get
				{
					return usedResources;
				}
				set	
				{
					usedResources = value;
				}
			}

			public class ListClusters_Managers
			{

				private int? total;

				private int? normalCount;

				private int? operatingCount;

				private int? stoppedCount;

				private int? exceptionCount;

				public int? Total
				{
					get
					{
						return total;
					}
					set	
					{
						total = value;
					}
				}

				public int? NormalCount
				{
					get
					{
						return normalCount;
					}
					set	
					{
						normalCount = value;
					}
				}

				public int? OperatingCount
				{
					get
					{
						return operatingCount;
					}
					set	
					{
						operatingCount = value;
					}
				}

				public int? StoppedCount
				{
					get
					{
						return stoppedCount;
					}
					set	
					{
						stoppedCount = value;
					}
				}

				public int? ExceptionCount
				{
					get
					{
						return exceptionCount;
					}
					set	
					{
						exceptionCount = value;
					}
				}
			}

			public class ListClusters_Computes
			{

				private int? total;

				private int? normalCount;

				private int? operatingCount;

				private int? stoppedCount;

				private int? exceptionCount;

				public int? Total
				{
					get
					{
						return total;
					}
					set	
					{
						total = value;
					}
				}

				public int? NormalCount
				{
					get
					{
						return normalCount;
					}
					set	
					{
						normalCount = value;
					}
				}

				public int? OperatingCount
				{
					get
					{
						return operatingCount;
					}
					set	
					{
						operatingCount = value;
					}
				}

				public int? StoppedCount
				{
					get
					{
						return stoppedCount;
					}
					set	
					{
						stoppedCount = value;
					}
				}

				public int? ExceptionCount
				{
					get
					{
						return exceptionCount;
					}
					set	
					{
						exceptionCount = value;
					}
				}
			}

			public class ListClusters_TotalResources
			{

				private int? cpu;

				private int? memory;

				private int? gpu;

				public int? Cpu
				{
					get
					{
						return cpu;
					}
					set	
					{
						cpu = value;
					}
				}

				public int? Memory
				{
					get
					{
						return memory;
					}
					set	
					{
						memory = value;
					}
				}

				public int? Gpu
				{
					get
					{
						return gpu;
					}
					set	
					{
						gpu = value;
					}
				}
			}

			public class ListClusters_UsedResources
			{

				private int? cpu;

				private int? memory;

				private int? gpu;

				public int? Cpu
				{
					get
					{
						return cpu;
					}
					set	
					{
						cpu = value;
					}
				}

				public int? Memory
				{
					get
					{
						return memory;
					}
					set	
					{
						memory = value;
					}
				}

				public int? Gpu
				{
					get
					{
						return gpu;
					}
					set	
					{
						gpu = value;
					}
				}
			}
		}
	}
}
