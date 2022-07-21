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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryTaskListResponse : AcsResponse
	{

		private bool? prePage;

		private int? currentPageNum;

		private string requestId;

		private int? pageSize;

		private int? totalPageNum;

		private int? totalItemNum;

		private bool? nextPage;

		private List<QueryTaskList_TaskInfo> data;

		public bool? PrePage
		{
			get
			{
				return prePage;
			}
			set	
			{
				prePage = value;
			}
		}

		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
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

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public bool? NextPage
		{
			get
			{
				return nextPage;
			}
			set	
			{
				nextPage = value;
			}
		}

		public List<QueryTaskList_TaskInfo> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryTaskList_TaskInfo
		{

			private string taskType;

			private string taskCancelStatus;

			private string taskNo;

			private int? taskCancelStatusCode;

			private int? taskStatusCode;

			private string taskStatus;

			private string taskTypeDescription;

			private int? taskNum;

			private string createTime;

			private string clientip;

			public string TaskType
			{
				get
				{
					return taskType;
				}
				set	
				{
					taskType = value;
				}
			}

			public string TaskCancelStatus
			{
				get
				{
					return taskCancelStatus;
				}
				set	
				{
					taskCancelStatus = value;
				}
			}

			public string TaskNo
			{
				get
				{
					return taskNo;
				}
				set	
				{
					taskNo = value;
				}
			}

			public int? TaskCancelStatusCode
			{
				get
				{
					return taskCancelStatusCode;
				}
				set	
				{
					taskCancelStatusCode = value;
				}
			}

			public int? TaskStatusCode
			{
				get
				{
					return taskStatusCode;
				}
				set	
				{
					taskStatusCode = value;
				}
			}

			public string TaskStatus
			{
				get
				{
					return taskStatus;
				}
				set	
				{
					taskStatus = value;
				}
			}

			public string TaskTypeDescription
			{
				get
				{
					return taskTypeDescription;
				}
				set	
				{
					taskTypeDescription = value;
				}
			}

			public int? TaskNum
			{
				get
				{
					return taskNum;
				}
				set	
				{
					taskNum = value;
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

			public string Clientip
			{
				get
				{
					return clientip;
				}
				set	
				{
					clientip = value;
				}
			}
		}
	}
}
