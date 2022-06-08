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
	public class ListUserBackupFilesResponse : AcsResponse
	{

		private string requestId;

		private List<ListUserBackupFiles_RecordsItem> records;

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

		[JsonProperty(PropertyName = "Records")]
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

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "CreationTime")]
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

			[JsonProperty(PropertyName = "FinishTime")]
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

			[JsonProperty(PropertyName = "Comment")]
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

			[JsonProperty(PropertyName = "OssFilePath")]
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

			[JsonProperty(PropertyName = "OssBucket")]
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

			[JsonProperty(PropertyName = "ModificationTime")]
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

			[JsonProperty(PropertyName = "OssFileSize")]
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

			[JsonProperty(PropertyName = "OssFileName")]
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

			[JsonProperty(PropertyName = "EngineVersion")]
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

			[JsonProperty(PropertyName = "RestoreSize")]
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

			[JsonProperty(PropertyName = "ZoneId")]
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

			[JsonProperty(PropertyName = "Retention")]
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

			[JsonProperty(PropertyName = "Engine")]
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

			[JsonProperty(PropertyName = "OssUrl")]
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

			[JsonProperty(PropertyName = "OssFileMetaData")]
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

			[JsonProperty(PropertyName = "BinlogInfo")]
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

			[JsonProperty(PropertyName = "Reason")]
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
