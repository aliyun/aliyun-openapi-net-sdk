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

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
	public class QueryTaskInfoHistoryResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private List<QueryTaskInfoHistory_TaskInfoHistory> objects;

		private QueryTaskInfoHistory_CurrentPageCursor currentPageCursor;

		private QueryTaskInfoHistory_NextPageCursor nextPageCursor;

		private QueryTaskInfoHistory_PrePageCursor prePageCursor;

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

		public List<QueryTaskInfoHistory_TaskInfoHistory> Objects
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

		public QueryTaskInfoHistory_CurrentPageCursor CurrentPageCursor
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

		public QueryTaskInfoHistory_NextPageCursor NextPageCursor
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

		public QueryTaskInfoHistory_PrePageCursor PrePageCursor
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

		public class QueryTaskInfoHistory_TaskInfoHistory
		{

			private string taskType;

			private int? taskNum;

			private string taskStatus;

			private string createTime;

			private string clientip;

			private string taskNo;

			private long? createTimeLong;

			private int? taskStatusCode;

			private string taskTypeDescription;

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

			public long? CreateTimeLong
			{
				get
				{
					return createTimeLong;
				}
				set	
				{
					createTimeLong = value;
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
		}

		public class QueryTaskInfoHistory_CurrentPageCursor
		{

			private string taskType;

			private int? taskNum;

			private string taskStatus;

			private string createTime;

			private string clientip;

			private string taskNo;

			private long? createTimeLong;

			private int? taskStatusCode;

			private string taskTypeDescription;

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

			public long? CreateTimeLong
			{
				get
				{
					return createTimeLong;
				}
				set	
				{
					createTimeLong = value;
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
		}

		public class QueryTaskInfoHistory_NextPageCursor
		{

			private string taskType;

			private int? taskNum;

			private string taskStatus;

			private string createTime;

			private string clientip;

			private string taskNo;

			private long? createTimeLong;

			private int? taskStatusCode;

			private string taskTypeDescription;

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

			public long? CreateTimeLong
			{
				get
				{
					return createTimeLong;
				}
				set	
				{
					createTimeLong = value;
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
		}

		public class QueryTaskInfoHistory_PrePageCursor
		{

			private string taskType;

			private int? taskNum;

			private string taskStatus;

			private string createTime;

			private string clientip;

			private string taskNo;

			private long? createTimeLong;

			private int? taskStatusCode;

			private string taskTypeDescription;

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

			public long? CreateTimeLong
			{
				get
				{
					return createTimeLong;
				}
				set	
				{
					createTimeLong = value;
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
		}
	}
}
