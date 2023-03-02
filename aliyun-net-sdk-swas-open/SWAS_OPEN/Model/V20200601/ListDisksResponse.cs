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

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
	public class ListDisksResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private List<ListDisks_Disk> disks;

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "Disks")]
		public List<ListDisks_Disk> Disks
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

		public class ListDisks_Disk
		{

			private string creationTime;

			private string status;

			private string device;

			private int? size;

			private string diskName;

			private string diskChargeType;

			private string diskType;

			private string category;

			private string diskId;

			private string instanceId;

			private string regionId;

			[JsonProperty(PropertyName = "CreationTime")]
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

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "Device")]
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

			[JsonProperty(PropertyName = "Size")]
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

			[JsonProperty(PropertyName = "DiskName")]
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

			[JsonProperty(PropertyName = "DiskChargeType")]
			public string DiskChargeType
			{
				get
				{
					return diskChargeType;
				}
				set	
				{
					diskChargeType = value;
				}
			}

			[JsonProperty(PropertyName = "DiskType")]
			public string DiskType
			{
				get
				{
					return diskType;
				}
				set	
				{
					diskType = value;
				}
			}

			[JsonProperty(PropertyName = "Category")]
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

			[JsonProperty(PropertyName = "DiskId")]
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

			[JsonProperty(PropertyName = "InstanceId")]
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

			[JsonProperty(PropertyName = "RegionId")]
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
