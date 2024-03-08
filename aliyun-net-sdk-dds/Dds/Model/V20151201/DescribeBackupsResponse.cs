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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeBackupsResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeBackups_Backup> backups;

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

		public class DescribeBackups_Backup
		{

			private string backupStatus;

			private string backupType;

			private string backupStartTime;

			private string backupIntranetDownloadURL;

			private long? backupSize;

			private string backupDownloadURL;

			private string backupMode;

			private string backupEndTime;

			private int? backupId;

			private string backupDBNames;

			private string backupMethod;

			private long? backupJobId;

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

			public int? BackupId
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

			public long? BackupJobId
			{
				get
				{
					return backupJobId;
				}
				set	
				{
					backupJobId = value;
				}
			}
		}
	}
}
