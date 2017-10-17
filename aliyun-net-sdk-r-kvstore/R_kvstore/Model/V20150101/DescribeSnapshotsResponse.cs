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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeSnapshotsResponse : AcsResponse
	{

		private string requestId;

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

			private string snapshotName;

			private string instanceId;

			private string createTime;

			private long? memory;

			private long? rdbSize;

			private string status;

			private string type;

			private string ossDownloadInPath;

			private string ossDownloadOutPath;

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

			public long? Memory
			{
				get
				{
					return memory;
				}
				set	
				{
					memory = value;
				}
			}

			public long? RdbSize
			{
				get
				{
					return rdbSize;
				}
				set	
				{
					rdbSize = value;
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

			public string OssDownloadInPath
			{
				get
				{
					return ossDownloadInPath;
				}
				set	
				{
					ossDownloadInPath = value;
				}
			}

			public string OssDownloadOutPath
			{
				get
				{
					return ossDownloadOutPath;
				}
				set	
				{
					ossDownloadOutPath = value;
				}
			}
		}
	}
}