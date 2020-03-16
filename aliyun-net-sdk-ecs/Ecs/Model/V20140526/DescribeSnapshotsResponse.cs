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
	public class DescribeSnapshotsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeSnapshots_Snapshot> snapshots;

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

		public List<DescribeSnapshots_Snapshot> Snapshots
		{
			get
			{
				return snapshots;
			}
			set	
			{
				snapshots = value;
			}
		}

		public class DescribeSnapshots_Snapshot
		{

			private string snapshotId;

			private string snapshotSN;

			private string snapshotName;

			private string progress;

			private string productCode;

			private string sourceDiskId;

			private string sourceDiskType;

			private int? retentionDays;

			private bool? encrypted;

			private string sourceDiskSize;

			private string description;

			private string creationTime;

			private string lastModifiedTime;

			private string status;

			private string usage;

			private string sourceStorageType;

			private int? remainTime;

			private string resourceGroupId;

			private string kMSKeyId;

			private string category;

			private string snapshotType;

			private List<DescribeSnapshots_Tag> tags;

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

			public string SnapshotSN
			{
				get
				{
					return snapshotSN;
				}
				set	
				{
					snapshotSN = value;
				}
			}

			public string SnapshotName
			{
				get
				{
					return snapshotName;
				}
				set	
				{
					snapshotName = value;
				}
			}

			public string Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
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

			public string SourceDiskId
			{
				get
				{
					return sourceDiskId;
				}
				set	
				{
					sourceDiskId = value;
				}
			}

			public string SourceDiskType
			{
				get
				{
					return sourceDiskType;
				}
				set	
				{
					sourceDiskType = value;
				}
			}

			public int? RetentionDays
			{
				get
				{
					return retentionDays;
				}
				set	
				{
					retentionDays = value;
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

			public string SourceDiskSize
			{
				get
				{
					return sourceDiskSize;
				}
				set	
				{
					sourceDiskSize = value;
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

			public string LastModifiedTime
			{
				get
				{
					return lastModifiedTime;
				}
				set	
				{
					lastModifiedTime = value;
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

			public string Usage
			{
				get
				{
					return usage;
				}
				set	
				{
					usage = value;
				}
			}

			public string SourceStorageType
			{
				get
				{
					return sourceStorageType;
				}
				set	
				{
					sourceStorageType = value;
				}
			}

			public int? RemainTime
			{
				get
				{
					return remainTime;
				}
				set	
				{
					remainTime = value;
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

			public string SnapshotType
			{
				get
				{
					return snapshotType;
				}
				set	
				{
					snapshotType = value;
				}
			}

			public List<DescribeSnapshots_Tag> Tags
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

			public class DescribeSnapshots_Tag
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
