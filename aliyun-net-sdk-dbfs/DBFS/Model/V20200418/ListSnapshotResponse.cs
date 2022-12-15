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

namespace Aliyun.Acs.DBFS.Model.V20200418
{
	public class ListSnapshotResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private List<ListSnapshot_SnapshotsItem> snapshots;

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
		public List<ListSnapshot_SnapshotsItem> Snapshots
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

		public class ListSnapshot_SnapshotsItem
		{

			private string status;

			private string creationTime;

			private string progress;

			private int? sourceFsSize;

			private int? retentionDays;

			private int? remainTime;

			private string lastModifiedTime;

			private string snapshotType;

			private string snapshotName;

			private string description;

			private string sourceFsId;

			private string snapshotId;

			private string category;

			private int? sourceFsStripeWidth;

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

			[JsonProperty(PropertyName = "SourceFsSize")]
			public int? SourceFsSize
			{
				get
				{
					return sourceFsSize;
				}
				set	
				{
					sourceFsSize = value;
				}
			}

			[JsonProperty(PropertyName = "RetentionDays")]
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

			[JsonProperty(PropertyName = "RemainTime")]
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

			[JsonProperty(PropertyName = "LastModifiedTime")]
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

			[JsonProperty(PropertyName = "SnapshotType")]
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

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "SourceFsId")]
			public string SourceFsId
			{
				get
				{
					return sourceFsId;
				}
				set	
				{
					sourceFsId = value;
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

			[JsonProperty(PropertyName = "SourceFsStripeWidth")]
			public int? SourceFsStripeWidth
			{
				get
				{
					return sourceFsStripeWidth;
				}
				set	
				{
					sourceFsStripeWidth = value;
				}
			}
		}
	}
}
