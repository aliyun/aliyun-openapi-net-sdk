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
	public class DescribeStorageSetDetailsResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeStorageSetDetails_Disk> disks;

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

		public List<DescribeStorageSetDetails_Disk> Disks
		{
			get
			{
				return disks;
			}
			set	
			{
				disks = value;
			}
		}

		public class DescribeStorageSetDetails_Disk
		{

			private string creationTime;

			private string diskName;

			private string zoneId;

			private string storageSetId;

			private string diskId;

			private string category;

			private int? storageSetPartitionNumber;

			private string regionId;

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

			public string DiskName
			{
				get
				{
					return diskName;
				}
				set	
				{
					diskName = value;
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

			public string StorageSetId
			{
				get
				{
					return storageSetId;
				}
				set	
				{
					storageSetId = value;
				}
			}

			public string DiskId
			{
				get
				{
					return diskId;
				}
				set	
				{
					diskId = value;
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

			public int? StorageSetPartitionNumber
			{
				get
				{
					return storageSetPartitionNumber;
				}
				set	
				{
					storageSetPartitionNumber = value;
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
		}
	}
}
