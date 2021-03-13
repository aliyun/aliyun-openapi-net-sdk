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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeLoadTasksRecordsResponse : AcsResponse
	{

		private string totalCount;

		private string requestId;

		private string pageSize;

		private string pageNumber;

		private string dBClusterId;

		private List<DescribeLoadTasksRecords_LoadTaskRecord> loadTasksRecords;

		public string TotalCount
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

		public string PageSize
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

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
			}
		}

		public List<DescribeLoadTasksRecords_LoadTaskRecord> LoadTasksRecords
		{
			get
			{
				return loadTasksRecords;
			}
			set	
			{
				loadTasksRecords = value;
			}
		}

		public class DescribeLoadTasksRecords_LoadTaskRecord
		{

			private long? processRows;

			private string state;

			private string createTime;

			private string jobName;

			private string updateTime;

			private string dBName;

			private string processID;

			private string sql;

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

			public string ProcessID
			{
				get
				{
					return processID;
				}
				set	
				{
					processID = value;
				}
			}

			public string Sql
			{
				get
				{
					return sql;
				}
				set	
				{
					sql = value;
				}
			}
		}
	}
}
