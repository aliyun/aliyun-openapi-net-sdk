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
	public class DescribeVolumesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeVolumes_Volume> volumes;

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

		public List<DescribeVolumes_Volume> Volumes
		{
			get
			{
				return volumes;
			}
			set	
			{
				volumes = value;
			}
		}

		public class DescribeVolumes_Volume
		{

			private string volumeId;

			private string regionId;

			private string zoneId;

			private string volumeName;

			private string description;

			private string category;

			private int? size;

			private string sourceSnapshotId;

			private string autoSnapshotPolicyId;

			private string snapshotLinkId;

			private string status;

			private bool? enableAutomatedSnapshotPolicy;

			private string creationTime;

			private string volumeChargeType;

			private int? mountInstanceNum;

			private bool? encrypted;

			private List<DescribeVolumes_OperationLock> operationLocks;

			private List<DescribeVolumes_MountInstance> mountInstances;

			private List<DescribeVolumes_Tag> tags;

			public string VolumeId
			{
				get
				{
					return volumeId;
				}
				set	
				{
					volumeId = value;
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

			public string VolumeName
			{
				get
				{
					return volumeName;
				}
				set	
				{
					volumeName = value;
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

			public string SnapshotLinkId
			{
				get
				{
					return snapshotLinkId;
				}
				set	
				{
					snapshotLinkId = value;
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

			public string VolumeChargeType
			{
				get
				{
					return volumeChargeType;
				}
				set	
				{
					volumeChargeType = value;
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

			public List<DescribeVolumes_OperationLock> OperationLocks
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

			public List<DescribeVolumes_MountInstance> MountInstances
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

			public List<DescribeVolumes_Tag> Tags
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

			public class DescribeVolumes_OperationLock
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

			public class DescribeVolumes_MountInstance
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

			public class DescribeVolumes_Tag
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
		}
	}
}