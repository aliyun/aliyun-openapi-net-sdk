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
	public class DescribeBackupsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private long? fullStorageSize;

		private long? logStorageSize;

		private long? freeSize;

		private List<DescribeBackups_Backup> backups;

		private DescribeBackups_AccessDeniedDetail accessDeniedDetail;

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

		public long? FullStorageSize
		{
			get
			{
				return fullStorageSize;
			}
			set	
			{
				fullStorageSize = value;
			}
		}

		public long? LogStorageSize
		{
			get
			{
				return logStorageSize;
			}
			set	
			{
				logStorageSize = value;
			}
		}

		public long? FreeSize
		{
			get
			{
				return freeSize;
			}
			set	
			{
				freeSize = value;
			}
		}

		public List<DescribeBackups_Backup> Backups
		{
			get
			{
				return backups;
			}
			set	
			{
				backups = value;
			}
		}

		public DescribeBackups_AccessDeniedDetail AccessDeniedDetail
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

		public class DescribeBackups_Backup
		{

			private string backupStatus;

			private string backupStartTime;

			private string backupType;

			private string backupDownloadURL;

			private string nodeInstanceId;

			private string backupEndTime;

			private long? backupId;

			private string backupDBNames;

			private string engineVersion;

			private string backupIntranetDownloadURL;

			private long? backupSize;

			private string backupMode;

			private string backupMethod;

			private long? backupJobID;

			private string recoverConfigMode;

			private string expectExpireTime;

			public string BackupStatus
			{
				get
				{
					return backupStatus;
				}
				set	
				{
					backupStatus = value;
				}
			}

			public string BackupStartTime
			{
				get
				{
					return backupStartTime;
				}
				set	
				{
					backupStartTime = value;
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

			public string BackupDownloadURL
			{
				get
				{
					return backupDownloadURL;
				}
				set	
				{
					backupDownloadURL = value;
				}
			}

			public string NodeInstanceId
			{
				get
				{
					return nodeInstanceId;
				}
				set	
				{
					nodeInstanceId = value;
				}
			}

			public string BackupEndTime
			{
				get
				{
					return backupEndTime;
				}
				set	
				{
					backupEndTime = value;
				}
			}

			public long? BackupId
			{
				get
				{
					return backupId;
				}
				set	
				{
					backupId = value;
				}
			}

			public string BackupDBNames
			{
				get
				{
					return backupDBNames;
				}
				set	
				{
					backupDBNames = value;
				}
			}

			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			public string BackupIntranetDownloadURL
			{
				get
				{
					return backupIntranetDownloadURL;
				}
				set	
				{
					backupIntranetDownloadURL = value;
				}
			}

			public long? BackupSize
			{
				get
				{
					return backupSize;
				}
				set	
				{
					backupSize = value;
				}
			}

			public string BackupMode
			{
				get
				{
					return backupMode;
				}
				set	
				{
					backupMode = value;
				}
			}

			public string BackupMethod
			{
				get
				{
					return backupMethod;
				}
				set	
				{
					backupMethod = value;
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

			public string RecoverConfigMode
			{
				get
				{
					return recoverConfigMode;
				}
				set	
				{
					recoverConfigMode = value;
				}
			}

			public string ExpectExpireTime
			{
				get
				{
					return expectExpireTime;
				}
				set	
				{
					expectExpireTime = value;
				}
			}
		}

		public class DescribeBackups_AccessDeniedDetail
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
