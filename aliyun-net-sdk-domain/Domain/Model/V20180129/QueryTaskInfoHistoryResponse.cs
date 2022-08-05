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
	public class QueryTaskInfoHistoryResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private List<QueryTaskInfoHistory_TaskInfoHistory> objects;

		private QueryTaskInfoHistory_CurrentPageCursor currentPageCursor;

		private QueryTaskInfoHistory_PrePageCursor prePageCursor;

		private QueryTaskInfoHistory_NextPageCursor nextPageCursor;

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

		public class QueryTaskInfoHistory_TaskInfoHistory
		{

			private string taskType;

			private string taskNo;

			private int? taskStatusCode;

			private string taskStatus;

			private string taskTypeDescription;

			private int? taskNum;

			private string createTime;

			private long? createTimeLong;

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

		public class QueryTaskInfoHistory_CurrentPageCursor
		{

			private string taskType;

			private string taskNo;

			private int? taskStatusCode;

			private string taskStatus;

			private string taskTypeDescription;

			private int? taskNum;

			private string createTime;

			private long? createTimeLong;

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

		public class QueryTaskInfoHistory_PrePageCursor
		{

			private string taskType;

			private string taskNo;

			private int? taskStatusCode;

			private string taskStatus;

			private string taskTypeDescription;

			private int? taskNum;

			private string createTime;

			private long? createTimeLong;

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

		public class QueryTaskInfoHistory_NextPageCursor
		{

			private string taskType;

			private string taskNo;

			private int? taskStatusCode;

			private string taskStatus;

			private string taskTypeDescription;

			private int? taskNum;

			private string createTime;

			private long? createTimeLong;

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
