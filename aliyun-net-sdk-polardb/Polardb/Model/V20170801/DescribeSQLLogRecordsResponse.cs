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
	public class DescribeSQLLogRecordsResponse : AcsResponse
	{

		private int? maxRecordsPerPage;

		private int? itemsNumbers;

		private string requestId;

		private string endTime;

		private string dBInstanceID;

		private string startTime;

		private int? totalRecords;

		private string finish;

		private int? pageNumbers;

		private string jobId;

		private string pagingID;

		private string dBInstanceName;

		private List<DescribeSQLLogRecords_SQLLogRecord> items;

		public int? MaxRecordsPerPage
		{
			get
			{
				return maxRecordsPerPage;
			}
			set	
			{
				maxRecordsPerPage = value;
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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public string DBInstanceID
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

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		public int? TotalRecords
		{
			get
			{
				return totalRecords;
			}
			set	
			{
				totalRecords = value;
			}
		}

		public string Finish
		{
			get
			{
				return finish;
			}
			set	
			{
				finish = value;
			}
		}

		public int? PageNumbers
		{
			get
			{
				return pageNumbers;
			}
			set	
			{
				pageNumbers = value;
			}
		}

		public string JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
			}
		}

		public string PagingID
		{
			get
			{
				return pagingID;
			}
			set	
			{
				pagingID = value;
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

		public List<DescribeSQLLogRecords_SQLLogRecord> Items
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

		public class DescribeSQLLogRecords_SQLLogRecord
		{

			private string executeTime;

			private string insName;

			private string hostAddress;

			private long? updateRows;

			private string sQLText;

			private string originTime;

			private long? consume;

			private long? scanRows;

			private int? threadID;

			private string state;

			private string dBName;

			private string sqlType;

			private string vip;

			private string accountName;

			public string ExecuteTime
			{
				get
				{
					return executeTime;
				}
				set	
				{
					executeTime = value;
				}
			}

			public string InsName
			{
				get
				{
					return insName;
				}
				set	
				{
					insName = value;
				}
			}

			public string HostAddress
			{
				get
				{
					return hostAddress;
				}
				set	
				{
					hostAddress = value;
				}
			}

			public long? UpdateRows
			{
				get
				{
					return updateRows;
				}
				set	
				{
					updateRows = value;
				}
			}

			public string SQLText
			{
				get
				{
					return sQLText;
				}
				set	
				{
					sQLText = value;
				}
			}

			public string OriginTime
			{
				get
				{
					return originTime;
				}
				set	
				{
					originTime = value;
				}
			}

			public long? Consume
			{
				get
				{
					return consume;
				}
				set	
				{
					consume = value;
				}
			}

			public long? ScanRows
			{
				get
				{
					return scanRows;
				}
				set	
				{
					scanRows = value;
				}
			}

			public int? ThreadID
			{
				get
				{
					return threadID;
				}
				set	
				{
					threadID = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string DBName
			{
				get
				{
					return dBName;
				}
				set	
				{
					dBName = value;
				}
			}

			public string SqlType
			{
				get
				{
					return sqlType;
				}
				set	
				{
					sqlType = value;
				}
			}

			public string Vip
			{
				get
				{
					return vip;
				}
				set	
				{
					vip = value;
				}
			}

			public string AccountName
			{
				get
				{
					return accountName;
				}
				set	
				{
					accountName = value;
				}
			}
		}
	}
}
