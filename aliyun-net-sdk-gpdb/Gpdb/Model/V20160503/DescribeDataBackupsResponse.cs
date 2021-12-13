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

namespace Aliyun.Acs.gpdb.Model.V20160503
{
	public class DescribeDataBackupsResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeDataBackups_Backup> items;

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

		public List<DescribeDataBackups_Backup> Items
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

		public class DescribeDataBackups_Backup
		{

			private string dataType;

			private long? consistentTime;

			private string backupStatus;

			private string backupStartTime;

			private string backupEndTime;

			private string backupEndTimeLocal;

			private string backupSetId;

			private string baksetName;

			private long? backupSize;

			private string backupMode;

			private string backupStartTimeLocal;

			private string dBInstanceId;

			public string DataType
			{
				get
				{
					return dataType;
				}
				set	
				{
					dataType = value;
				}
			}

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

			public string BackupEndTimeLocal
			{
				get
				{
					return backupEndTimeLocal;
				}
				set	
				{
					backupEndTimeLocal = value;
				}
			}

			public string BackupSetId
			{
				get
				{
					return backupSetId;
				}
				set	
				{
					backupSetId = value;
				}
			}

			public string BaksetName
			{
				get
				{
					return baksetName;
				}
				set	
				{
					baksetName = value;
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

			public string BackupStartTimeLocal
			{
				get
				{
					return backupStartTimeLocal;
				}
				set	
				{
					backupStartTimeLocal = value;
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
		}
	}
}
