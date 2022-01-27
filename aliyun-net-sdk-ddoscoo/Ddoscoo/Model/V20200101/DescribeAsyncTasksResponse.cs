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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeAsyncTasksResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeAsyncTasks_AsyncTask> asyncTasks;

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

		public List<DescribeAsyncTasks_AsyncTask> AsyncTasks
		{
			get
			{
				return asyncTasks;
			}
			set	
			{
				asyncTasks = value;
			}
		}

		public class DescribeAsyncTasks_AsyncTask
		{

			private long? taskId;

			private long? endTime;

			private long? startTime;

			private int? taskStatus;

			private string taskResult;

			private string taskParams;

			private int? taskType;

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

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public int? TaskStatus
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

			public string TaskParams
			{
				get
				{
					return taskParams;
				}
				set	
				{
					taskParams = value;
				}
			}

			public int? TaskType
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
		}
	}
}
