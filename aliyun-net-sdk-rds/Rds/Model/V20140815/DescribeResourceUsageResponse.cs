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
	public class DescribeResourceUsageResponse : AcsResponse
	{

		private long? backupOssDataSize;

		private long? diskUsed;

		private long? archiveBackupSize;

		private long? backupOssLogSize;

		private long? backupLogSize;

		private long? backupDataSize;

		private long? coldBackupSize;

		private long? dataSize;

		private long? paidBackupSize;

		private string requestId;

		private long? logSize;

		private long? backupSize;

		private string dBInstanceId;

		private string engine;

		private long? sQLSize;

		[JsonProperty(PropertyName = "BackupOssDataSize")]
		public long? BackupOssDataSize
		{
			get
			{
				return backupOssDataSize;
			}
			set	
			{
				backupOssDataSize = value;
			}
		}

		[JsonProperty(PropertyName = "DiskUsed")]
		public long? DiskUsed
		{
			get
			{
				return diskUsed;
			}
			set	
			{
				diskUsed = value;
			}
		}

		[JsonProperty(PropertyName = "ArchiveBackupSize")]
		public long? ArchiveBackupSize
		{
			get
			{
				return archiveBackupSize;
			}
			set	
			{
				archiveBackupSize = value;
			}
		}

		[JsonProperty(PropertyName = "BackupOssLogSize")]
		public long? BackupOssLogSize
		{
			get
			{
				return backupOssLogSize;
			}
			set	
			{
				backupOssLogSize = value;
			}
		}

		[JsonProperty(PropertyName = "BackupLogSize")]
		public long? BackupLogSize
		{
			get
			{
				return backupLogSize;
			}
			set	
			{
				backupLogSize = value;
			}
		}

		[JsonProperty(PropertyName = "BackupDataSize")]
		public long? BackupDataSize
		{
			get
			{
				return backupDataSize;
			}
			set	
			{
				backupDataSize = value;
			}
		}

		[JsonProperty(PropertyName = "ColdBackupSize")]
		public long? ColdBackupSize
		{
			get
			{
				return coldBackupSize;
			}
			set	
			{
				coldBackupSize = value;
			}
		}

		[JsonProperty(PropertyName = "DataSize")]
		public long? DataSize
		{
			get
			{
				return dataSize;
			}
			set	
			{
				dataSize = value;
			}
		}

		[JsonProperty(PropertyName = "PaidBackupSize")]
		public long? PaidBackupSize
		{
			get
			{
				return paidBackupSize;
			}
			set	
			{
				paidBackupSize = value;
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

		[JsonProperty(PropertyName = "LogSize")]
		public long? LogSize
		{
			get
			{
				return logSize;
			}
			set	
			{
				logSize = value;
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

		[JsonProperty(PropertyName = "SQLSize")]
		public long? SQLSize
		{
			get
			{
				return sQLSize;
			}
			set	
			{
				sQLSize = value;
			}
		}
	}
}
