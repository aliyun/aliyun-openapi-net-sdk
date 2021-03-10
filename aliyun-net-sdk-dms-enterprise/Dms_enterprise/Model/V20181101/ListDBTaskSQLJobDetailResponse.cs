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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ListDBTaskSQLJobDetailResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<ListDBTaskSQLJobDetail_DBTaskSQLJobDetail> dBTaskSQLJobDetailList;

		[JsonProperty(PropertyName = "TotalCount")]
		public long? TotalCount
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

		[JsonProperty(PropertyName = "ErrorCode")]
		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		[JsonProperty(PropertyName = "ErrorMessage")]
		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "DBTaskSQLJobDetailList")]
		public List<ListDBTaskSQLJobDetail_DBTaskSQLJobDetail> DBTaskSQLJobDetailList
		{
			get
			{
				return dBTaskSQLJobDetailList;
			}
			set	
			{
				dBTaskSQLJobDetailList = value;
			}
		}

		public class ListDBTaskSQLJobDetail_DBTaskSQLJobDetail
		{

			private string status;

			private bool? skip;

			private long? dbId;

			private string sqlType;

			private long? executeCount;

			private bool? logic;

			private string currentSql;

			private long? jobDetailId;

			private long? jobId;

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

			[JsonProperty(PropertyName = "Skip")]
			public bool? Skip
			{
				get
				{
					return skip;
				}
				set	
				{
					skip = value;
				}
			}

			[JsonProperty(PropertyName = "DbId")]
			public long? DbId
			{
				get
				{
					return dbId;
				}
				set	
				{
					dbId = value;
				}
			}

			[JsonProperty(PropertyName = "SqlType")]
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

			[JsonProperty(PropertyName = "ExecuteCount")]
			public long? ExecuteCount
			{
				get
				{
					return executeCount;
				}
				set	
				{
					executeCount = value;
				}
			}

			[JsonProperty(PropertyName = "Logic")]
			public bool? Logic
			{
				get
				{
					return logic;
				}
				set	
				{
					logic = value;
				}
			}

			[JsonProperty(PropertyName = "CurrentSql")]
			public string CurrentSql
			{
				get
				{
					return currentSql;
				}
				set	
				{
					currentSql = value;
				}
			}

			[JsonProperty(PropertyName = "JobDetailId")]
			public long? JobDetailId
			{
				get
				{
					return jobDetailId;
				}
				set	
				{
					jobDetailId = value;
				}
			}

			[JsonProperty(PropertyName = "JobId")]
			public long? JobId
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
		}
	}
}
