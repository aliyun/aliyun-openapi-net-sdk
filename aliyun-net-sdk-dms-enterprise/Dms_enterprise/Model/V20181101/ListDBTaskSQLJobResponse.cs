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
	public class ListDBTaskSQLJobResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<ListDBTaskSQLJob_DBTaskSQLJob> dBTaskSQLJobList;

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

		[JsonProperty(PropertyName = "DBTaskSQLJobList")]
		public List<ListDBTaskSQLJob_DBTaskSQLJob> DBTaskSQLJobList
		{
			get
			{
				return dBTaskSQLJobList;
			}
			set	
			{
				dBTaskSQLJobList = value;
			}
		}

		public class ListDBTaskSQLJob_DBTaskSQLJob
		{

			private string status;

			private string comment;

			private string lastExecTime;

			private string dbSearchName;

			private string jobType;

			private string createTime;

			private long? dbTaskGroupId;

			private long? dbId;

			private bool? logic;

			private long? jobId;

			private bool? transactional;

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

			[JsonProperty(PropertyName = "LastExecTime")]
			public string LastExecTime
			{
				get
				{
					return lastExecTime;
				}
				set	
				{
					lastExecTime = value;
				}
			}

			[JsonProperty(PropertyName = "DbSearchName")]
			public string DbSearchName
			{
				get
				{
					return dbSearchName;
				}
				set	
				{
					dbSearchName = value;
				}
			}

			[JsonProperty(PropertyName = "JobType")]
			public string JobType
			{
				get
				{
					return jobType;
				}
				set	
				{
					jobType = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
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

			[JsonProperty(PropertyName = "DbTaskGroupId")]
			public long? DbTaskGroupId
			{
				get
				{
					return dbTaskGroupId;
				}
				set	
				{
					dbTaskGroupId = value;
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

			[JsonProperty(PropertyName = "Transactional")]
			public bool? Transactional
			{
				get
				{
					return transactional;
				}
				set	
				{
					transactional = value;
				}
			}
		}
	}
}
