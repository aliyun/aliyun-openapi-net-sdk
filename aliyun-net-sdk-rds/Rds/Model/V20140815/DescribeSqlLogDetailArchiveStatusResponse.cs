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
	public class DescribeSqlLogDetailArchiveStatusResponse : AcsResponse
	{

		private string requestId;

		private int? dBInstanceID;

		private string dBInstanceName;

		private int? itemsNumbers;

		private List<DescribeSqlLogDetailArchiveStatus_ArchiveSQLLog> items;

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

		public int? DBInstanceID
		{
			get
			{
				return dBInstanceID;
			}
			set	
			{
				dBInstanceID = value;
			}
		}

		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
			}
		}

		public int? ItemsNumbers
		{
			get
			{
				return itemsNumbers;
			}
			set	
			{
				itemsNumbers = value;
			}
		}

		public List<DescribeSqlLogDetailArchiveStatus_ArchiveSQLLog> Items
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

		public class DescribeSqlLogDetailArchiveStatus_ArchiveSQLLog
		{

			private string jobName;

			private string createTime;

			private string updateTime;

			private long? processRows;

			private long? totalRows;

			private string failMsg;

			private string jobStatus;

			private string downloadLink;

			private string linkExpiredTime;

			public string JobName
			{
				get
				{
					return jobName;
				}
				set	
				{
					jobName = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public long? ProcessRows
			{
				get
				{
					return processRows;
				}
				set	
				{
					processRows = value;
				}
			}

			public long? TotalRows
			{
				get
				{
					return totalRows;
				}
				set	
				{
					totalRows = value;
				}
			}

			public string FailMsg
			{
				get
				{
					return failMsg;
				}
				set	
				{
					failMsg = value;
				}
			}

			public string JobStatus
			{
				get
				{
					return jobStatus;
				}
				set	
				{
					jobStatus = value;
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