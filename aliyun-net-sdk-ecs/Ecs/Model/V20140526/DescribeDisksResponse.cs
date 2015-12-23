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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeDisksResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

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

			private string diskId;

			private string regionId;

			private string zoneId;

			private string diskName;

			private string description;

			private Type_ type;

			private Category_ category;

			private int? size;

			private string imageId;

			private string sourceSnapshotId;

			private string productCode;

			private bool? portable;

			private string status;

			private string instanceId;

			private string device;

			private bool? deleteWithInstance;

			private bool? deleteAutoSnapshot;

			private bool? enableAutoSnapshot;

			private string creationTime;

			private string attachedTime;

			private string detachedTime;

			private string diskChargeType;

			private string expiredTime;

			private List<OperationLock> operationLocks;

			private List<Tag> tags;

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

			public Type_ Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public Category_ Category
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

			public string SourceSnapshotId
			{
				get
				{
					return sourceSnapshotId;
				}
				set	
				{
					sourceSnapshotId = value;
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

			public string AttachedTime
			{
				get
				{
					return attachedTime;
				}
				set	
				{
					attachedTime = value;
				}
			}

			public string DetachedTime
			{
				get
				{
					return detachedTime;
				}
				set	
				{
					detachedTime = value;
				}
			}

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

			public List<OperationLock> OperationLocks
			{
				get
				{
					return operationLocks;
				}
				set	
				{
					operationLocks = value;
				}
			}

			public List<Tag> Tags
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

			public enum Type_ {
			
					system,
					data,
			}

			public enum Category_ {
			
					ephemeral_ssd,
					ephemeral,
					cloud,
			}

			public class OperationLock{

				private string lockReason;

				public string LockReason
				{
					get
					{
						return lockReason;
					}
					set	
					{
						lockReason = value;
					}
				}
			}

			public class Tag{

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
		}
	}
}