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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDetachedBackupsResponse : AcsResponse
	{

		private long? totalBackupSize;

		private string pageNumber;

		private string requestId;

		private string pageRecordCount;

		private string totalRecordCount;

		private List<DescribeDetachedBackups_Backup> items;

		[JsonProperty(PropertyName = "TotalBackupSize")]
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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "PageRecordCount")]
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

		[JsonProperty(PropertyName = "TotalRecordCount")]
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

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeDetachedBackups_Backup> Items
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

		public class DescribeDetachedBackups_Backup
		{

			private string slaveStatus;

			private long? consistentTime;

			private string storeStatus;

			private string backupStatus;

			private string backupLocation;

			private string backupType;

			private string backupStartTime;

			private long? totalBackupSize;

			private string backupDownloadURL;

			private int? isAvail;

			private string metaStatus;

			private string backupEndTime;

			private string backupDBNames;

			private string backupScale;

			private string backupId;

			private string hostInstanceID;

			private string backupIntranetDownloadURL;

			private long? backupSize;

			private string backupMode;

			private string dBInstanceId;

			private string dBInstanceComment;

			private string backupExtractionStatus;

			private string backupMethod;

			[JsonProperty(PropertyName = "SlaveStatus")]
			public string SlaveStatus
			{
				get
				{
					return slaveStatus;
				}
				set	
				{
					slaveStatus = value;
				}
			}

			[JsonProperty(PropertyName = "ConsistentTime")]
			public long? ConsistentTime
			{
				get
				{
					return consistentTime;
				}
				set	
				{
					consistentTime = value;
				}
			}

			[JsonProperty(PropertyName = "StoreStatus")]
			public string StoreStatus
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

			[JsonProperty(PropertyName = "BackupStatus")]
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

			[JsonProperty(PropertyName = "BackupLocation")]
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

			[JsonProperty(PropertyName = "BackupType")]
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

			[JsonProperty(PropertyName = "BackupStartTime")]
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

			[JsonProperty(PropertyName = "TotalBackupSize")]
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

			[JsonProperty(PropertyName = "BackupDownloadURL")]
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

			[JsonProperty(PropertyName = "IsAvail")]
			public int? IsAvail
			{
				get
				{
					return isAvail;
				}
				set	
				{
					isAvail = value;
				}
			}

			[JsonProperty(PropertyName = "MetaStatus")]
			public string MetaStatus
			{
				get
				{
					return metaStatus;
				}
				set	
				{
					metaStatus = value;
				}
			}

			[JsonProperty(PropertyName = "BackupEndTime")]
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

			[JsonProperty(PropertyName = "BackupDBNames")]
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

			[JsonProperty(PropertyName = "BackupScale")]
			public string BackupScale
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

			[JsonProperty(PropertyName = "BackupId")]
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

			[JsonProperty(PropertyName = "HostInstanceID")]
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

			[JsonProperty(PropertyName = "BackupIntranetDownloadURL")]
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

			[JsonProperty(PropertyName = "BackupSize")]
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

			[JsonProperty(PropertyName = "BackupMode")]
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

			[JsonProperty(PropertyName = "DBInstanceId")]
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

			[JsonProperty(PropertyName = "DBInstanceComment")]
			public string DBInstanceComment
			{
				get
				{
					return dBInstanceComment;
				}
				set	
				{
					dBInstanceComment = value;
				}
			}

			[JsonProperty(PropertyName = "BackupExtractionStatus")]
			public string BackupExtractionStatus
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

			[JsonProperty(PropertyName = "BackupMethod")]
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
		}
	}
}
