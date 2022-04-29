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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeSnapshotsResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeSnapshots_Snapshot> snapshots;

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

			private string status;

			private string progress;

			private string createTime;

			private string sourceFileSystemId;

			private int? retentionDays;

			private int? remainTime;

			private long? sourceFileSystemSize;

			private string sourceFileSystemVersion;

			private string snapshotName;

			private int? encryptType;

			private string description;

			private string snapshotId;

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

			public string SourceFileSystemVersion
			{
				get
				{
					return sourceFileSystemVersion;
				}
				set	
				{
					sourceFileSystemVersion = value;
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

			public int? EncryptType
			{
				get
				{
					return encryptType;
				}
				set	
				{
					encryptType = value;
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
		}
	}
}
