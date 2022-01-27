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
	public class DescribeLogBackupsResponse : AcsResponse
	{

		private long? totalLogSize;

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private int? totalCount;

		private List<DescribeLogBackups_Backup> items;

		public long? TotalLogSize
		{
			get
			{
				return totalLogSize;
			}
			set	
			{
				totalLogSize = value;
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

		public List<DescribeLogBackups_Backup> Items
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

		public class DescribeLogBackups_Backup
		{

			private long? logFileSize;

			private string logTime;

			private string segmentName;

			private string logFileName;

			private string dBInstanceId;

			private string backupId;

			public long? LogFileSize
			{
				get
				{
					return logFileSize;
				}
				set	
				{
					logFileSize = value;
				}
			}

			public string LogTime
			{
				get
				{
					return logTime;
				}
				set	
				{
					logTime = value;
				}
			}

			public string SegmentName
			{
				get
				{
					return segmentName;
				}
				set	
				{
					segmentName = value;
				}
			}

			public string LogFileName
			{
				get
				{
					return logFileName;
				}
				set	
				{
					logFileName = value;
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
		}
	}
}
