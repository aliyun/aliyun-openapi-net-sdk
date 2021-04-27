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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeSnapshotsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSnapshots_BackupSnapshots> snapshots;

		private DescribeSnapshots_PageInfo pageInfo;

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

		public List<DescribeSnapshots_BackupSnapshots> Snapshots
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

		public DescribeSnapshots_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeSnapshots_BackupSnapshots
		{

			private string snapshotId;

			private string clientId;

			private string vaultId;

			private string snapshotHash;

			private long? duration;

			private long? completeTime;

			private string source;

			private string parentHash;

			private string status;

			private long? size;

			private long? errorCount;

			private long? retention;

			private string snapshotName;

			private long? bytesDone;

			private long? bytesTotal;

			private long? itemsDone;

			private long? itemsTotal;

			private long? actualBytes;

			private string jobId;

			private string exitCode;

			private long? createdTime;

			private long? updatedTime;

			private string sourceType;

			private string snapshotOption;

			private string containerSnapshotId;

			private string planId;

			private string snapshotType;

			private string serverId;

			private string extra;

			private string errorMessage;

			private string errorFile;

			private string errorType;

			private string uuid;

			private string instanceId;

			private string machineInfoJson;

			private string regionId;

			private string backupType;

			private string parentSnapshotHash;

			private string bucket;

			private string prefix;

			private string fileSystemId;

			private long? startTime;

			private long? createTime;

			private long? actualItems;

			private string path;

			private List<string> paths;

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

			public string ClientId
			{
				get
				{
					return clientId;
				}
				set	
				{
					clientId = value;
				}
			}

			public string VaultId
			{
				get
				{
					return vaultId;
				}
				set	
				{
					vaultId = value;
				}
			}

			public string SnapshotHash
			{
				get
				{
					return snapshotHash;
				}
				set	
				{
					snapshotHash = value;
				}
			}

			public long? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public long? CompleteTime
			{
				get
				{
					return completeTime;
				}
				set	
				{
					completeTime = value;
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public string ParentHash
			{
				get
				{
					return parentHash;
				}
				set	
				{
					parentHash = value;
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

			public long? Size
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

			public long? ErrorCount
			{
				get
				{
					return errorCount;
				}
				set	
				{
					errorCount = value;
				}
			}

			public long? Retention
			{
				get
				{
					return retention;
				}
				set	
				{
					retention = value;
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

			public long? BytesDone
			{
				get
				{
					return bytesDone;
				}
				set	
				{
					bytesDone = value;
				}
			}

			public long? BytesTotal
			{
				get
				{
					return bytesTotal;
				}
				set	
				{
					bytesTotal = value;
				}
			}

			public long? ItemsDone
			{
				get
				{
					return itemsDone;
				}
				set	
				{
					itemsDone = value;
				}
			}

			public long? ItemsTotal
			{
				get
				{
					return itemsTotal;
				}
				set	
				{
					itemsTotal = value;
				}
			}

			public long? ActualBytes
			{
				get
				{
					return actualBytes;
				}
				set	
				{
					actualBytes = value;
				}
			}

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string ExitCode
			{
				get
				{
					return exitCode;
				}
				set	
				{
					exitCode = value;
				}
			}

			public long? CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public long? UpdatedTime
			{
				get
				{
					return updatedTime;
				}
				set	
				{
					updatedTime = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			public string SnapshotOption
			{
				get
				{
					return snapshotOption;
				}
				set	
				{
					snapshotOption = value;
				}
			}

			public string ContainerSnapshotId
			{
				get
				{
					return containerSnapshotId;
				}
				set	
				{
					containerSnapshotId = value;
				}
			}

			public string PlanId
			{
				get
				{
					return planId;
				}
				set	
				{
					planId = value;
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

			public string ServerId
			{
				get
				{
					return serverId;
				}
				set	
				{
					serverId = value;
				}
			}

			public string Extra
			{
				get
				{
					return extra;
				}
				set	
				{
					extra = value;
				}
			}

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			public string ErrorFile
			{
				get
				{
					return errorFile;
				}
				set	
				{
					errorFile = value;
				}
			}

			public string ErrorType
			{
				get
				{
					return errorType;
				}
				set	
				{
					errorType = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
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

			public string MachineInfoJson
			{
				get
				{
					return machineInfoJson;
				}
				set	
				{
					machineInfoJson = value;
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

			public string BackupType
			{
				get
				{
					return backupType;
				}
				set	
				{
					backupType = value;
				}
			}

			public string ParentSnapshotHash
			{
				get
				{
					return parentSnapshotHash;
				}
				set	
				{
					parentSnapshotHash = value;
				}
			}

			public string Bucket
			{
				get
				{
					return bucket;
				}
				set	
				{
					bucket = value;
				}
			}

			public string Prefix
			{
				get
				{
					return prefix;
				}
				set	
				{
					prefix = value;
				}
			}

			public string FileSystemId
			{
				get
				{
					return fileSystemId;
				}
				set	
				{
					fileSystemId = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public long? CreateTime
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

			public long? ActualItems
			{
				get
				{
					return actualItems;
				}
				set	
				{
					actualItems = value;
				}
			}

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public List<string> Paths
			{
				get
				{
					return paths;
				}
				set	
				{
					paths = value;
				}
			}
		}

		public class DescribeSnapshots_PageInfo
		{

			private int? count;

			private string nextToken;

			private int? pageSize;

			private int? totalCount;

			private int? currentPage;

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

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

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}
		}
	}
}
