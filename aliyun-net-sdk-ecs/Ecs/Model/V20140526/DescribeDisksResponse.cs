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
	public class DescribeDisksResponse : AcsResponse
	{

		private string nextToken;

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private int? totalCount;

		private List<DescribeDisks_Disk> disks;

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

		public List<DescribeDisks_Disk> Disks
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

		public class DescribeDisks_Disk
		{

			private string serialNumber;

			private string creationTime;

			private string status;

			private string type;

			private string performanceLevel;

			private string bdfId;

			private bool? enableAutoSnapshot;

			private string storageSetId;

			private int? storageSetPartitionNumber;

			private string diskId;

			private bool? deleteAutoSnapshot;

			private string dedicatedBlockStorageClusterId;

			private bool? encrypted;

			private int? iOPSRead;

			private int? mountInstanceNum;

			private string description;

			private string device;

			private string diskName;

			private bool? portable;

			private string imageId;

			private string kMSKeyId;

			private bool? deleteWithInstance;

			private string detachedTime;

			private string sourceSnapshotId;

			private string autoSnapshotPolicyId;

			private bool? enableAutomatedSnapshotPolicy;

			private int? iOPSWrite;

			private string instanceId;

			private int? iOPS;

			private string regionId;

			private string expiredTime;

			private int? size;

			private string resourceGroupId;

			private string diskChargeType;

			private string zoneId;

			private string attachedTime;

			private string category;

			private string productCode;

			private string multiAttach;

			private List<DescribeDisks_OperationLock> operationLocks;

			private List<DescribeDisks_MountInstance> mountInstances;

			private List<DescribeDisks_Tag> tags;

			private List<DescribeDisks_Attachment> attachments;

			public string SerialNumber
			{
				get
				{
					return serialNumber;
				}
				set	
				{
					serialNumber = value;
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

			public string Type
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

			public string BdfId
			{
				get
				{
					return bdfId;
				}
				set	
				{
					bdfId = value;
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

			public bool? Encrypted
			{
				get
				{
					return encrypted;
				}
				set	
				{
					encrypted = value;
				}
			}

			public int? IOPSRead
			{
				get
				{
					return iOPSRead;
				}
				set	
				{
					iOPSRead = value;
				}
			}

			public int? MountInstanceNum
			{
				get
				{
					return mountInstanceNum;
				}
				set	
				{
					mountInstanceNum = value;
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

			public string KMSKeyId
			{
				get
				{
					return kMSKeyId;
				}
				set	
				{
					kMSKeyId = value;
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

			public string AutoSnapshotPolicyId
			{
				get
				{
					return autoSnapshotPolicyId;
				}
				set	
				{
					autoSnapshotPolicyId = value;
				}
			}

			public bool? EnableAutomatedSnapshotPolicy
			{
				get
				{
					return enableAutomatedSnapshotPolicy;
				}
				set	
				{
					enableAutomatedSnapshotPolicy = value;
				}
			}

			public int? IOPSWrite
			{
				get
				{
					return iOPSWrite;
				}
				set	
				{
					iOPSWrite = value;
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

			public int? IOPS
			{
				get
				{
					return iOPS;
				}
				set	
				{
					iOPS = value;
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

			public string MultiAttach
			{
				get
				{
					return multiAttach;
				}
				set	
				{
					multiAttach = value;
				}
			}

			public List<DescribeDisks_OperationLock> OperationLocks
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

			public List<DescribeDisks_MountInstance> MountInstances
			{
				get
				{
					return mountInstances;
				}
				set	
				{
					mountInstances = value;
				}
			}

			public List<DescribeDisks_Tag> Tags
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

			public List<DescribeDisks_Attachment> Attachments
			{
				get
				{
					return attachments;
				}
				set	
				{
					attachments = value;
				}
			}

			public class DescribeDisks_OperationLock
			{

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

			public class DescribeDisks_MountInstance
			{

				private string attachedTime;

				private string instanceId;

				private string device;

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
			}

			public class DescribeDisks_Tag
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

			public class DescribeDisks_Attachment
			{

				private string instanceId;

				private string device;

				private string attachedTime;

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
			}
		}
	}
}
