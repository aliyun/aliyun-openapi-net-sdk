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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeBackupTasksResponse : AcsResponse
	{

		private string instanceId;

		private string requestId;

		private List<DescribeBackupTasks_BackupJob> backupJobs;

		private DescribeBackupTasks_AccessDeniedDetail accessDeniedDetail;

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

		public List<DescribeBackupTasks_BackupJob> BackupJobs
		{
			get
			{
				return backupJobs;
			}
			set	
			{
				backupJobs = value;
			}
		}

		public DescribeBackupTasks_AccessDeniedDetail AccessDeniedDetail
		{
			get
			{
				return accessDeniedDetail;
			}
			set	
			{
				accessDeniedDetail = value;
			}
		}

		public class DescribeBackupTasks_BackupJob
		{

			private string startTime;

			private string process;

			private string jobMode;

			private long? backupJobID;

			private string backupProgressStatus;

			private string nodeId;

			private string taskAction;

			private string progress;

			public string StartTime
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

			public string Process
			{
				get
				{
					return process;
				}
				set	
				{
					process = value;
				}
			}

			public string JobMode
			{
				get
				{
					return jobMode;
				}
				set	
				{
					jobMode = value;
				}
			}

			public long? BackupJobID
			{
				get
				{
					return backupJobID;
				}
				set	
				{
					backupJobID = value;
				}
			}

			public string BackupProgressStatus
			{
				get
				{
					return backupProgressStatus;
				}
				set	
				{
					backupProgressStatus = value;
				}
			}

			public string NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
				}
			}

			public string TaskAction
			{
				get
				{
					return taskAction;
				}
				set	
				{
					taskAction = value;
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
		}

		public class DescribeBackupTasks_AccessDeniedDetail
		{

			private string authAction;

			private string authPrincipalDisplayName;

			private string authPrincipalOwnerId;

			private string authPrincipalType;

			private string encodedDiagnosticMessage;

			private string noPermissionType;

			private string policyType;

			public string AuthAction
			{
				get
				{
					return authAction;
				}
				set	
				{
					authAction = value;
				}
			}

			public string AuthPrincipalDisplayName
			{
				get
				{
					return authPrincipalDisplayName;
				}
				set	
				{
					authPrincipalDisplayName = value;
				}
			}

			public string AuthPrincipalOwnerId
			{
				get
				{
					return authPrincipalOwnerId;
				}
				set	
				{
					authPrincipalOwnerId = value;
				}
			}

			public string AuthPrincipalType
			{
				get
				{
					return authPrincipalType;
				}
				set	
				{
					authPrincipalType = value;
				}
			}

			public string EncodedDiagnosticMessage
			{
				get
				{
					return encodedDiagnosticMessage;
				}
				set	
				{
					encodedDiagnosticMessage = value;
				}
			}

			public string NoPermissionType
			{
				get
				{
					return noPermissionType;
				}
				set	
				{
					noPermissionType = value;
				}
			}

			public string PolicyType
			{
				get
				{
					return policyType;
				}
				set	
				{
					policyType = value;
				}
			}
		}
	}
}
