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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryTaskDetailHistoryResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private List<QueryTaskDetailHistory_TaskDetailHistory> objects;

		private QueryTaskDetailHistory_CurrentPageCursor currentPageCursor;

		private QueryTaskDetailHistory_NextPageCursor nextPageCursor;

		private QueryTaskDetailHistory_PrePageCursor prePageCursor;

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

		public List<QueryTaskDetailHistory_TaskDetailHistory> Objects
		{
			get
			{
				return objects;
			}
			set	
			{
				objects = value;
			}
		}

		public QueryTaskDetailHistory_CurrentPageCursor CurrentPageCursor
		{
			get
			{
				return currentPageCursor;
			}
			set	
			{
				currentPageCursor = value;
			}
		}

		public QueryTaskDetailHistory_NextPageCursor NextPageCursor
		{
			get
			{
				return nextPageCursor;
			}
			set	
			{
				nextPageCursor = value;
			}
		}

		public QueryTaskDetailHistory_PrePageCursor PrePageCursor
		{
			get
			{
				return prePageCursor;
			}
			set	
			{
				prePageCursor = value;
			}
		}

		public class QueryTaskDetailHistory_TaskDetailHistory
		{

			private string taskNo;

			private string taskDetailNo;

			private string taskType;

			private string instanceId;

			private string domainName;

			private string taskStatus;

			private string updateTime;

			private string createTime;

			private int? tryCount;

			private string errorMsg;

			private int? taskStatusCode;

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
		}

		public class QueryTaskDetailHistory_CurrentPageCursor
		{

			private string taskNo;

			private string taskDetailNo;

			private string taskType;

			private string instanceId;

			private string domainName;

			private string taskStatus;

			private string updateTime;

			private string createTime;

			private int? tryCount;

			private string errorMsg;

			private int? taskStatusCode;

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
		}

		public class QueryTaskDetailHistory_NextPageCursor
		{

			private string taskNo;

			private string taskDetailNo;

			private string taskType;

			private string instanceId;

			private string domainName;

			private string taskStatus;

			private string updateTime;

			private string createTime;

			private int? tryCount;

			private string errorMsg;

			private int? taskStatusCode;

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
		}

		public class QueryTaskDetailHistory_PrePageCursor
		{

			private string taskNo;

			private string taskDetailNo;

			private string taskType;

			private string instanceId;

			private string domainName;

			private string taskStatus;

			private string updateTime;

			private string createTime;

			private int? tryCount;

			private string errorMsg;

			private int? taskStatusCode;

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
		}
	}
}