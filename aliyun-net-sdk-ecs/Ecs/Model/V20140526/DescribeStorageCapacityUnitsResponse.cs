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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeStorageCapacityUnitsResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeStorageCapacityUnits_StorageCapacityUnit> storageCapacityUnits;

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

		public List<DescribeStorageCapacityUnits_StorageCapacityUnit> StorageCapacityUnits
		{
			get
			{
				return storageCapacityUnits;
			}
			set	
			{
				storageCapacityUnits = value;
			}
		}

		public class DescribeStorageCapacityUnits_StorageCapacityUnit
		{

			private string creationTime;

			private string status;

			private string startTime;

			private int? capacity;

			private string description;

			private string allocationStatus;

			private string expiredTime;

			private string storageCapacityUnitId;

			private string name;

			private string regionId;

			private List<DescribeStorageCapacityUnits_Tag> tags;

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

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public int? Capacity
			{
				get
				{
					return capacity;
				}
				set	
				{
					capacity = value;
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

			public string AllocationStatus
			{
				get
				{
					return allocationStatus;
				}
				set	
				{
					allocationStatus = value;
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

			public string StorageCapacityUnitId
			{
				get
				{
					return storageCapacityUnitId;
				}
				set	
				{
					storageCapacityUnitId = value;
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

			public List<DescribeStorageCapacityUnits_Tag> Tags
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

			public class DescribeStorageCapacityUnits_Tag
			{

				private string tagValue;

				private string tagKey;

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
			}
		}
	}
}
