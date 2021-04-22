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
	public class DescribeDedicatedBlockStorageClustersResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageCluster> dedicatedBlockStorageClusters;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageCluster> DedicatedBlockStorageClusters
		{
			get
			{
				return dedicatedBlockStorageClusters;
			}
			set	
			{
				dedicatedBlockStorageClusters = value;
			}
		}

		public class DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageCluster
		{

			private string dedicatedBlockStorageClusterId;

			private string dedicatedBlockStorageClusterName;

			private string description;

			private string zoneId;

			private string status;

			private string category;

			private string performanceLevel;

			private string expiredTime;

			private string createTime;

			private DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageClusterCapacity dedicatedBlockStorageClusterCapacity;

			public string DedicatedBlockStorageClusterId
			{
				get
				{
					return dedicatedBlockStorageClusterId;
				}
				set	
				{
					dedicatedBlockStorageClusterId = value;
				}
			}

			public string DedicatedBlockStorageClusterName
			{
				get
				{
					return dedicatedBlockStorageClusterName;
				}
				set	
				{
					dedicatedBlockStorageClusterName = value;
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

			public string PerformanceLevel
			{
				get
				{
					return performanceLevel;
				}
				set	
				{
					performanceLevel = value;
				}
			}

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
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

			public DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageClusterCapacity DedicatedBlockStorageClusterCapacity
			{
				get
				{
					return dedicatedBlockStorageClusterCapacity;
				}
				set	
				{
					dedicatedBlockStorageClusterCapacity = value;
				}
			}

			public class DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageClusterCapacity
			{

				private long? availableCapacity;

				private long? totalCapacity;

				public long? AvailableCapacity
				{
					get
					{
						return availableCapacity;
					}
					set	
					{
						availableCapacity = value;
					}
				}

				public long? TotalCapacity
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
			}
		}
	}
}
