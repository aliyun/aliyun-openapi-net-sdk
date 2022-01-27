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

namespace Aliyun.Acs.DBFS.Model.V20200418
{
	public class ListTaskResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListTask_TasksItem> tasks;

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

		public int? TotalCount
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

		public int? PageNumber
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

		public List<ListTask_TasksItem> Tasks
		{
			get
			{
				return tasks;
			}
			set	
			{
				tasks = value;
			}
		}

		public class ListTask_TasksItem
		{

			private int? id;

			private string taskName;

			private string taskType;

			private string taskOwner;

			private string taskAdder;

			private string taskRunner;

			private int? taskProgress;

			private string taskProgressDescription;

			private string taskStatus;

			private string clientToken;

			private string createdTime;

			private string completionTime;

			private string priority;

			private int? maxRetry;

			private string nextExecutionTime;

			private int? taskExecutionCounts;

			private string taskErrorReason;

			private int? taskStatusCode;

			public int? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string TaskName
			{
				get
				{
					return taskName;
				}
				set	
				{
					taskName = value;
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

			public string TaskOwner
			{
				get
				{
					return taskOwner;
				}
				set	
				{
					taskOwner = value;
				}
			}

			public string TaskAdder
			{
				get
				{
					return taskAdder;
				}
				set	
				{
					taskAdder = value;
				}
			}

			public string TaskRunner
			{
				get
				{
					return taskRunner;
				}
				set	
				{
					taskRunner = value;
				}
			}

			public int? TaskProgress
			{
				get
				{
					return taskProgress;
				}
				set	
				{
					taskProgress = value;
				}
			}

			public string TaskProgressDescription
			{
				get
				{
					return taskProgressDescription;
				}
				set	
				{
					taskProgressDescription = value;
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

			public string ClientToken
			{
				get
				{
					return clientToken;
				}
				set	
				{
					clientToken = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string CompletionTime
			{
				get
				{
					return completionTime;
				}
				set	
				{
					completionTime = value;
				}
			}

			public string Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public int? MaxRetry
			{
				get
				{
					return maxRetry;
				}
				set	
				{
					maxRetry = value;
				}
			}

			public string NextExecutionTime
			{
				get
				{
					return nextExecutionTime;
				}
				set	
				{
					nextExecutionTime = value;
				}
			}

			public int? TaskExecutionCounts
			{
				get
				{
					return taskExecutionCounts;
				}
				set	
				{
					taskExecutionCounts = value;
				}
			}

			public string TaskErrorReason
			{
				get
				{
					return taskErrorReason;
				}
				set	
				{
					taskErrorReason = value;
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
