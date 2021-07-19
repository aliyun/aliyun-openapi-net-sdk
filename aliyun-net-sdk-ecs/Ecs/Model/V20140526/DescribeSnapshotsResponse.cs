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

		private string nextToken;

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private int? totalCount;

		private List<DescribeSnapshots_Snapshot> snapshots;

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

			private string status;

			private string creationTime;

			private string progress;

			private bool? instantAccess;

			private int? remainTime;

			private string sourceDiskSize;

			private int? retentionDays;

			private string sourceDiskType;

			private string sourceStorageType;

			private string usage;

			private string lastModifiedTime;

			private bool? encrypted;

			private string snapshotType;

			private string sourceDiskId;

			private string snapshotName;

			private int? instantAccessRetentionDays;

			private string description;

			private string snapshotId;

			private string resourceGroupId;

			private string category;

			private string kMSKeyId;

			private string snapshotSN;

			private string productCode;

			private string sourceSnapshotId;

			private string sourceRegionId;

			private List<DescribeSnapshots_Tag> tags;

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

			public bool? InstantAccess
			{
				get
				{
					return instantAccess;
				}
				set	
				{
					instantAccess = value;
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

			public int? InstantAccessRetentionDays
			{
				get
				{
					return instantAccessRetentionDays;
				}
				set	
				{
					instantAccessRetentionDays = value;
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

			public string SourceRegionId
			{
				get
				{
					return sourceRegionId;
				}
				set	
				{
					sourceRegionId = value;
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
