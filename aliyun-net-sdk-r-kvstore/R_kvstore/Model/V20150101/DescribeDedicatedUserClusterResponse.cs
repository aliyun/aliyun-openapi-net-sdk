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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeDedicatedUserClusterResponse : AcsResponse
	{

		private string requestId;

		private int? maxRecordsPerPage;

		private int? pageNumber;

		private int? totalRecords;

		private int? itemsNumbers;

		private List<DescribeDedicatedUserCluster_ClusterInfo> clusterItems;

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

		public int? MaxRecordsPerPage
		{
			get
			{
				return maxRecordsPerPage;
			}
			set	
			{
				maxRecordsPerPage = value;
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

		public int? TotalRecords
		{
			get
			{
				return totalRecords;
			}
			set	
			{
				totalRecords = value;
			}
		}

		public int? ItemsNumbers
		{
			get
			{
				return itemsNumbers;
			}
			set	
			{
				itemsNumbers = value;
			}
		}

		public List<DescribeDedicatedUserCluster_ClusterInfo> ClusterItems
		{
			get
			{
				return clusterItems;
			}
			set	
			{
				clusterItems = value;
			}
		}

		public class DescribeDedicatedUserCluster_ClusterInfo
		{

			private string clusterId;

			private string clusterName;

			private int? hostNumbers;

			private int? instanceNumbers;

			private int? cpuOverAllocationRatio;

			private int? memoryOverAllocationRatio;

			private int? diskOverAllocationRatio;

			private string allocationPolicy;

			private string hostReplacePolicy;

			private string createTime;

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string ClusterName
			{
				get
				{
					return clusterName;
				}
				set	
				{
					clusterName = value;
				}
			}

			public int? HostNumbers
			{
				get
				{
					return hostNumbers;
				}
				set	
				{
					hostNumbers = value;
				}
			}

			public int? InstanceNumbers
			{
				get
				{
					return instanceNumbers;
				}
				set	
				{
					instanceNumbers = value;
				}
			}

			public int? CpuOverAllocationRatio
			{
				get
				{
					return cpuOverAllocationRatio;
				}
				set	
				{
					cpuOverAllocationRatio = value;
				}
			}

			public int? MemoryOverAllocationRatio
			{
				get
				{
					return memoryOverAllocationRatio;
				}
				set	
				{
					memoryOverAllocationRatio = value;
				}
			}

			public int? DiskOverAllocationRatio
			{
				get
				{
					return diskOverAllocationRatio;
				}
				set	
				{
					diskOverAllocationRatio = value;
				}
			}

			public string AllocationPolicy
			{
				get
				{
					return allocationPolicy;
				}
				set	
				{
					allocationPolicy = value;
				}
			}

			public string HostReplacePolicy
			{
				get
				{
					return hostReplacePolicy;
				}
				set	
				{
					hostReplacePolicy = value;
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
		}
	}
}
