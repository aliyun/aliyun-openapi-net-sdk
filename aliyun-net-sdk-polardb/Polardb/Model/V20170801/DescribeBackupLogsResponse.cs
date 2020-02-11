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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeBackupLogsResponse : AcsResponse
	{

		private string requestId;

		private string totalRecordCount;

		private string pageNumber;

		private string pageRecordCount;

		private List<DescribeBackupLogs_BackupLog> items;

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

		public List<DescribeBackupLogs_BackupLog> Items
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

		public class DescribeBackupLogs_BackupLog
		{

			private string backupLogId;

			private string backupLogName;

			private string backupLogStartTime;

			private string backupLogEndTime;

			private string backupLogSize;

			private string downloadLink;

			private string intranetDownloadLink;

			private string linkExpiredTime;

			public string BackupLogId
			{
				get
				{
					return backupLogId;
				}
				set	
				{
					backupLogId = value;
				}
			}

			public string BackupLogName
			{
				get
				{
					return backupLogName;
				}
				set	
				{
					backupLogName = value;
				}
			}

			public string BackupLogStartTime
			{
				get
				{
					return backupLogStartTime;
				}
				set	
				{
					backupLogStartTime = value;
				}
			}

			public string BackupLogEndTime
			{
				get
				{
					return backupLogEndTime;
				}
				set	
				{
					backupLogEndTime = value;
				}
			}

			public string BackupLogSize
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

			public string DownloadLink
			{
				get
				{
					return downloadLink;
				}
				set	
				{
					downloadLink = value;
				}
			}

			public string IntranetDownloadLink
			{
				get
				{
					return intranetDownloadLink;
				}
				set	
				{
					intranetDownloadLink = value;
				}
			}

			public string LinkExpiredTime
			{
				get
				{
					return linkExpiredTime;
				}
				set	
				{
					linkExpiredTime = value;
				}
			}
		}
	}
}
