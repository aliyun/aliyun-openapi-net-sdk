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
	public class QueryTaskDetailListResponse : AcsResponse
	{

		private bool? prePage;

		private int? currentPageNum;

		private string requestId;

		private int? pageSize;

		private int? totalPageNum;

		private int? totalItemNum;

		private bool? nextPage;

		private List<QueryTaskDetailList_TaskDetail> data;

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

		public List<QueryTaskDetailList_TaskDetail> Data
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

		public class QueryTaskDetailList_TaskDetail
		{

			private string updateTime;

			private string taskDetailNo;

			private string createTime;

			private string instanceId;

			private string domainName;

			private string taskType;

			private string taskNo;

			private string taskResult;

			private int? taskStatusCode;

			private string taskStatus;

			private string taskTypeDescription;

			private int? tryCount;

			private string errorMsg;

			private string failReason;

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

			public string TaskDetailNo
			{
				get
				{
					return taskDetailNo;
				}
				set	
				{
					taskDetailNo = value;
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

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

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

			public string TaskResult
			{
				get
				{
					return taskResult;
				}
				set	
				{
					taskResult = value;
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

			public int? TryCount
			{
				get
				{
					return tryCount;
				}
				set	
				{
					tryCount = value;
				}
			}

			public string ErrorMsg
			{
				get
				{
					return errorMsg;
				}
				set	
				{
					errorMsg = value;
				}
			}

			public string FailReason
			{
				get
				{
					return failReason;
				}
				set	
				{
					failReason = value;
				}
			}
		}
	}
}
