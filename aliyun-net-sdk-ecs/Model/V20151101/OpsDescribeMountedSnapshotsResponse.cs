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

namespace Aliyun.Acs.Ecs.Model.V20151101
{
	public class OpsDescribeMountedSnapshotsResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNo;

		private int? pageSize;

		private List<Snapshot> mountedSnapshots;

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

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
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

		public List<Snapshot> MountedSnapshots
		{
			get
			{
				return mountedSnapshots;
			}
			set	
			{
				mountedSnapshots = value;
			}
		}

		public class Snapshot{

			private string snapshotId;

			private string lastAttachedTime;

			private string ecsInstanceId;

			private string status;

			private string mountPoint;

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

			public string LastAttachedTime
			{
				get
				{
					return lastAttachedTime;
				}
				set	
				{
					lastAttachedTime = value;
				}
			}

			public string EcsInstanceId
			{
				get
				{
					return ecsInstanceId;
				}
				set	
				{
					ecsInstanceId = value;
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

			public string MountPoint
			{
				get
				{
					return mountPoint;
				}
				set	
				{
					mountPoint = value;
				}
			}
		}
	}
}