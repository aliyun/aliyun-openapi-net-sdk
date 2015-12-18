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

namespace Aliyun.Acs.Ecs.Model.V20151101
{
	public class OpsDescribeDisksResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNo;

		private int? pageSize;

		private List<Disk> disks;

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

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
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

		public List<Disk> Disks
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

		public class Disk{

			private long? id;

			private long? aliUid;

			private string bid;

			private string diskId;

			private string houyiDiskId;

			private string diskType;

			private string diskCategory;

			private string status;

			private string regionNo;

			private string izNo;

			private string zoneNo;

			private string diskName;

			private string diskDesc;

			private int? diskSize;

			private bool? active;

			private bool? bootable;

			private bool? portable;

			private string imageId;

			private string snapshotId;

			private string ecsInstanceId;

			private string mountPoint;

			private bool? deleteWithInstance;

			private bool? deleteAutoSnapshot;

			private bool? enableAutoSnapshot;

			private string businessStatus;

			private string createdTime;

			private string modifiedTime;

			private string lastAttachedTime;

			private string lastDetachedTime;

			private int? iopsSize;

			private string productCode;

			public long? Id
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

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string Bid
			{
				get
				{
					return bid;
				}
				set	
				{
					bid = value;
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

			public string HouyiDiskId
			{
				get
				{
					return houyiDiskId;
				}
				set	
				{
					houyiDiskId = value;
				}
			}

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

			public string DiskCategory
			{
				get
				{
					return diskCategory;
				}
				set	
				{
					diskCategory = value;
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

			public string RegionNo
			{
				get
				{
					return regionNo;
				}
				set	
				{
					regionNo = value;
				}
			}

			public string IzNo
			{
				get
				{
					return izNo;
				}
				set	
				{
					izNo = value;
				}
			}

			public string ZoneNo
			{
				get
				{
					return zoneNo;
				}
				set	
				{
					zoneNo = value;
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

			public string DiskDesc
			{
				get
				{
					return diskDesc;
				}
				set	
				{
					diskDesc = value;
				}
			}

			public int? DiskSize
			{
				get
				{
					return diskSize;
				}
				set	
				{
					diskSize = value;
				}
			}

			public bool? Active
			{
				get
				{
					return active;
				}
				set	
				{
					active = value;
				}
			}

			public bool? Bootable
			{
				get
				{
					return bootable;
				}
				set	
				{
					bootable = value;
				}
			}

			public bool? Portable
			{
				get
				{
					return portable;
				}
				set	
				{
					portable = value;
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

			public string EcsInstanceId
			{
				get
				{
					return ecsInstanceId;
				}
				set	
				{
					ecsInstanceId = value;
				}
			}

			public string MountPoint
			{
				get
				{
					return mountPoint;
				}
				set	
				{
					mountPoint = value;
				}
			}

			public bool? DeleteWithInstance
			{
				get
				{
					return deleteWithInstance;
				}
				set	
				{
					deleteWithInstance = value;
				}
			}

			public bool? DeleteAutoSnapshot
			{
				get
				{
					return deleteAutoSnapshot;
				}
				set	
				{
					deleteAutoSnapshot = value;
				}
			}

			public bool? EnableAutoSnapshot
			{
				get
				{
					return enableAutoSnapshot;
				}
				set	
				{
					enableAutoSnapshot = value;
				}
			}

			public string BusinessStatus
			{
				get
				{
					return businessStatus;
				}
				set	
				{
					businessStatus = value;
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

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			public string LastAttachedTime
			{
				get
				{
					return lastAttachedTime;
				}
				set	
				{
					lastAttachedTime = value;
				}
			}

			public string LastDetachedTime
			{
				get
				{
					return lastDetachedTime;
				}
				set	
				{
					lastDetachedTime = value;
				}
			}

			public int? IopsSize
			{
				get
				{
					return iopsSize;
				}
				set	
				{
					iopsSize = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}
		}
	}
}