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
	public class DescribeResourceUsageResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceId;

		private string engine;

		private long? diskUsed;

		private long? dataSize;

		private long? logSize;

		private long? backupSize;

		private long? backupOssDataSize;

		private long? backupOssLogSize;

		private long? sQLSize;

		private long? coldBackupSize;

		private long? backupDataSize;

		private long? backupLogSize;

		private long? paidBackupSize;

		private long? archiveBackupSize;

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
	}
}
