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
	public class ListSnapshotsResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private List<ListSnapshots_Snapshot> snapshots;

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

		[JsonProperty(PropertyName = "Snapshots")]
		public List<ListSnapshots_Snapshot> Snapshots
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

		public class ListSnapshots_Snapshot
		{

			private string status;

			private string creationTime;

			private string sourceDiskId;

			private string snapshotName;

			private string progress;

			private string remark;

			private string snapshotId;

			private string sourceDiskType;

			private string regionId;

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

			[JsonProperty(PropertyName = "SourceDiskId")]
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

			[JsonProperty(PropertyName = "SnapshotName")]
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

			[JsonProperty(PropertyName = "Progress")]
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

			[JsonProperty(PropertyName = "Remark")]
			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			[JsonProperty(PropertyName = "SnapshotId")]
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

			[JsonProperty(PropertyName = "SourceDiskType")]
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
