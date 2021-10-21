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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class ListUserBackupFilesResponse : AcsResponse
	{

		private string requestId;

		private List<ListUserBackupFiles_RecordsItem> records;

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

		public List<ListUserBackupFiles_RecordsItem> Records
		{
			get
			{
				return records;
			}
			set	
			{
				records = value;
			}
		}

		public class ListUserBackupFiles_RecordsItem
		{

			private string status;

			private string creationTime;

			private string finishTime;

			private string comment;

			private string ossFilePath;

			private string ossBucket;

			private string modificationTime;

			private long? ossFileSize;

			private string ossFileName;

			private string engineVersion;

			private string backupId;

			private string restoreSize;

			private string zoneId;

			private int? retention;

			private string dBInstanceId;

			private string engine;

			private string ossUrl;

			private string ossFileMetaData;

			private string binlogInfo;

			private string reason;

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

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public string OssFilePath
			{
				get
				{
					return ossFilePath;
				}
				set	
				{
					ossFilePath = value;
				}
			}

			public string OssBucket
			{
				get
				{
					return ossBucket;
				}
				set	
				{
					ossBucket = value;
				}
			}

			public string ModificationTime
			{
				get
				{
					return modificationTime;
				}
				set	
				{
					modificationTime = value;
				}
			}

			public long? OssFileSize
			{
				get
				{
					return ossFileSize;
				}
				set	
				{
					ossFileSize = value;
				}
			}

			public string OssFileName
			{
				get
				{
					return ossFileName;
				}
				set	
				{
					ossFileName = value;
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

			public string RestoreSize
			{
				get
				{
					return restoreSize;
				}
				set	
				{
					restoreSize = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public int? Retention
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

			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			public string OssUrl
			{
				get
				{
					return ossUrl;
				}
				set	
				{
					ossUrl = value;
				}
			}

			public string OssFileMetaData
			{
				get
				{
					return ossFileMetaData;
				}
				set	
				{
					ossFileMetaData = value;
				}
			}

			public string BinlogInfo
			{
				get
				{
					return binlogInfo;
				}
				set	
				{
					binlogInfo = value;
				}
			}

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}
		}
	}
}
