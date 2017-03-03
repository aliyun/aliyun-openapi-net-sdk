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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeBackupsResponse : AcsResponse
	{

		private string totalRecordCount;

		private string pageNumber;

		private string pageRecordCount;

		private int? totalBackupSize;

		private List<Backup> items;

		public string TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public string PageNumber
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

		public string PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public int? TotalBackupSize
		{
			get
			{
				return totalBackupSize;
			}
			set	
			{
				totalBackupSize = value;
			}
		}

		public List<Backup> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class Backup{

			private string backupId;

			private string dBInstanceId;

			private BackupStatusEnum? backupStatus;

			private string backupStartTime;

			private string backupEndTime;

			private BackupTypeEnum? backupType;

			private BackupModeEnum? backupMode;

			private BackupMethodEnum? backupMethod;

			private string backupDownloadURL;

			private string backupIntranetDownloadURL;

			private string backupLocation;

			private BackupExtractionStatusEnum? backupExtractionStatus;

			private BackupScaleEnum? backupScale;

			private string backupDBNames;

			private long? totalBackupSize;

			private long? backupSize;

			private string hostInstanceID;

			private StoreStatusEnum? storeStatus;

			public string BackupId
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

			public string DBInstanceId
			{
				get
				{
					return dBInstanceId;
				}
				set	
				{
					dBInstanceId = value;
				}
			}

			public BackupStatusEnum? BackupStatus
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

			public BackupTypeEnum? BackupType
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

			public BackupModeEnum? BackupMode
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

			public BackupMethodEnum? BackupMethod
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

			public string BackupLocation
			{
				get
				{
					return backupLocation;
				}
				set	
				{
					backupLocation = value;
				}
			}

			public BackupExtractionStatusEnum? BackupExtractionStatus
			{
				get
				{
					return backupExtractionStatus;
				}
				set	
				{
					backupExtractionStatus = value;
				}
			}

			public BackupScaleEnum? BackupScale
			{
				get
				{
					return backupScale;
				}
				set	
				{
					backupScale = value;
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

			public long? TotalBackupSize
			{
				get
				{
					return totalBackupSize;
				}
				set	
				{
					totalBackupSize = value;
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

			public string HostInstanceID
			{
				get
				{
					return hostInstanceID;
				}
				set	
				{
					hostInstanceID = value;
				}
			}

			public StoreStatusEnum? StoreStatus
			{
				get
				{
					return storeStatus;
				}
				set	
				{
					storeStatus = value;
				}
			}

public enum BackupStatusEnum {

					Failed,
					Success,
}

public enum BackupTypeEnum {

					IncrementalBackup,
					FullBackup,
}

public enum BackupModeEnum {

					Manual,
					Automated,
}

public enum BackupMethodEnum {

					Physical,
					Logical,
					Snapshot,
}

public enum BackupExtractionStatusEnum {

					Nostart,
					Extracing,
					Failed,
					Success,
}

public enum BackupScaleEnum {

					DBInstance,
					Database,
}

public enum StoreStatusEnum {

					Enabled,
					Disabled,
}
		}
	}
}