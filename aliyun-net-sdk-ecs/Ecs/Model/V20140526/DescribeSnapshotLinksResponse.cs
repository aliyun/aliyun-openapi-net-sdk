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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeSnapshotLinksResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeSnapshotLinks_SnapshotLink> snapshotLinks;

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

		public List<DescribeSnapshotLinks_SnapshotLink> SnapshotLinks
		{
			get
			{
				return snapshotLinks;
			}
			set	
			{
				snapshotLinks = value;
			}
		}

		public class DescribeSnapshotLinks_SnapshotLink
		{

			private bool? instantAccess;

			private long? totalSize;

			private string sourceDiskName;

			private int? sourceDiskSize;

			private string sourceDiskType;

			private string instanceId;

			private string snapshotLinkId;

			private int? totalCount;

			private string regionId;

			private string sourceDiskId;

			private string instanceName;

			private string category;

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

			public long? TotalSize
			{
				get
				{
					return totalSize;
				}
				set	
				{
					totalSize = value;
				}
			}

			public string SourceDiskName
			{
				get
				{
					return sourceDiskName;
				}
				set	
				{
					sourceDiskName = value;
				}
			}

			public int? SourceDiskSize
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

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
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
		}
	}
}
