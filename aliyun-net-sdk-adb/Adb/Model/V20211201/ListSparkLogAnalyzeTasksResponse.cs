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

namespace Aliyun.Acs.adb.Model.V20211201
{
	public class ListSparkLogAnalyzeTasksResponse : AcsResponse
	{

		private string requestId;

		private ListSparkLogAnalyzeTasks_Data data;

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

		public ListSparkLogAnalyzeTasks_Data Data
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

		public class ListSparkLogAnalyzeTasks_Data
		{

			private long? pageNumber;

			private long? pageSize;

			private long? totalCount;

			private List<ListSparkLogAnalyzeTasks_Task> taskList;

			public long? PageNumber
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

			public long? PageSize
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

			public List<ListSparkLogAnalyzeTasks_Task> TaskList
			{
				get
				{
					return taskList;
				}
				set	
				{
					taskList = value;
				}
			}

			public class ListSparkLogAnalyzeTasks_Task
			{

				private long? taskId;

				private long? userId;

				private long? submittedTimeInMillis;

				private long? terminatedTimeInMillis;

				private string taskState;

				private long? startedTimeInMillis;

				private bool? ruleMatched;

				private string taskErrMsg;

				private string dBClusterId;

				private ListSparkLogAnalyzeTasks_Result result;

				public long? TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}

				public long? UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public long? SubmittedTimeInMillis
				{
					get
					{
						return submittedTimeInMillis;
					}
					set	
					{
						submittedTimeInMillis = value;
					}
				}

				public long? TerminatedTimeInMillis
				{
					get
					{
						return terminatedTimeInMillis;
					}
					set	
					{
						terminatedTimeInMillis = value;
					}
				}

				public string TaskState
				{
					get
					{
						return taskState;
					}
					set	
					{
						taskState = value;
					}
				}

				public long? StartedTimeInMillis
				{
					get
					{
						return startedTimeInMillis;
					}
					set	
					{
						startedTimeInMillis = value;
					}
				}

				public bool? RuleMatched
				{
					get
					{
						return ruleMatched;
					}
					set	
					{
						ruleMatched = value;
					}
				}

				public string TaskErrMsg
				{
					get
					{
						return taskErrMsg;
					}
					set	
					{
						taskErrMsg = value;
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

				public ListSparkLogAnalyzeTasks_Result Result
				{
					get
					{
						return result;
					}
					set	
					{
						result = value;
					}
				}

				public class ListSparkLogAnalyzeTasks_Result
				{

					private string appErrorCode;

					private string appErrorLog;

					private string appErrorAdvice;

					public string AppErrorCode
					{
						get
						{
							return appErrorCode;
						}
						set	
						{
							appErrorCode = value;
						}
					}

					public string AppErrorLog
					{
						get
						{
							return appErrorLog;
						}
						set	
						{
							appErrorLog = value;
						}
					}

					public string AppErrorAdvice
					{
						get
						{
							return appErrorAdvice;
						}
						set	
						{
							appErrorAdvice = value;
						}
					}
				}
			}
		}
	}
}
