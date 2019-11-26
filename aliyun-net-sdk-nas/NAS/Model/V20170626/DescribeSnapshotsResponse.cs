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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeSnapshotsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

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

			private string createTime;

			private string description;

			private string progress;

			private int? remainTime;

			private int? retentionDays;

			private string snapshotId;

			private string snapshotName;

			private string sourceFileSystemId;

			private long? sourceFileSystemSize;

			private string status;

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

			public string SourceFileSystemId
			{
				get
				{
					return sourceFileSystemId;
				}
				set	
				{
					sourceFileSystemId = value;
				}
			}

			public long? SourceFileSystemSize
			{
				get
				{
					return sourceFileSystemSize;
				}
				set	
				{
					sourceFileSystemSize = value;
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
		}
	}
}
