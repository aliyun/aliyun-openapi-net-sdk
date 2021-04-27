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
	public class DescribeRestoreJobsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRestoreJobs_RestoreJob> restoreJobs;

		private DescribeRestoreJobs_PageInfo pageInfo;

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

		public List<DescribeRestoreJobs_RestoreJob> RestoreJobs
		{
			get
			{
				return restoreJobs;
			}
			set	
			{
				restoreJobs = value;
			}
		}

		public DescribeRestoreJobs_PageInfo PageInfo
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

		public class DescribeRestoreJobs_RestoreJob
		{

			private long? id;

			private long? createdTime;

			private long? updatedTime;

			private string uuid;

			private string message;

			private string restoreId;

			private string clientId;

			private string vaultId;

			private string snapshotId;

			private string snapshotHash;

			private string source;

			private string target;

			private string status;

			private string restoreType;

			private long? speed;

			private long? completeTime;

			private long? eta;

			private long? errorCount;

			private long? bytesDone;

			private long? bytesTotal;

			private long? itemsDone;

			private long? itemsTotal;

			private long? actualBytes;

			private int? percentage;

			private string errorType;

			private string sourceClientId;

			private string snapshotVersion;

			private string instanceName;

			private string internetIp;

			private string intranetIp;

			private string errorFile;

			private string errorFileUrl;

			private string requestId;

			private string restoreName;

			private string instanceId;

			private string extra;

			private long? duration;

			private string exitCode;

			private string errorFile1;

			private string gmtCreate;

			private long? gmtModified;

			private string excludes;

			private string includes;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public string RestoreId
			{
				get
				{
					return restoreId;
				}
				set	
				{
					restoreId = value;
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

			public string Target
			{
				get
				{
					return target;
				}
				set	
				{
					target = value;
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

			public string RestoreType
			{
				get
				{
					return restoreType;
				}
				set	
				{
					restoreType = value;
				}
			}

			public long? Speed
			{
				get
				{
					return speed;
				}
				set	
				{
					speed = value;
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

			public long? Eta
			{
				get
				{
					return eta;
				}
				set	
				{
					eta = value;
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

			public int? Percentage
			{
				get
				{
					return percentage;
				}
				set	
				{
					percentage = value;
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

			public string SourceClientId
			{
				get
				{
					return sourceClientId;
				}
				set	
				{
					sourceClientId = value;
				}
			}

			public string SnapshotVersion
			{
				get
				{
					return snapshotVersion;
				}
				set	
				{
					snapshotVersion = value;
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

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
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

			public string ErrorFileUrl
			{
				get
				{
					return errorFileUrl;
				}
				set	
				{
					errorFileUrl = value;
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

			public string RestoreName
			{
				get
				{
					return restoreName;
				}
				set	
				{
					restoreName = value;
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

			public string ErrorFile1
			{
				get
				{
					return errorFile1;
				}
				set	
				{
					errorFile1 = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string Excludes
			{
				get
				{
					return excludes;
				}
				set	
				{
					excludes = value;
				}
			}

			public string Includes
			{
				get
				{
					return includes;
				}
				set	
				{
					includes = value;
				}
			}
		}

		public class DescribeRestoreJobs_PageInfo
		{

			private int? count;

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
