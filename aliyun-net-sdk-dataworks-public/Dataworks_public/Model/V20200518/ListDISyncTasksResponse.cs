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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListDISyncTasksResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private ListDISyncTasks_TaskList taskList;

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

		public ListDISyncTasks_TaskList TaskList
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

		public class ListDISyncTasks_TaskList
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListDISyncTasks_RealTimeSolutionListItem> realTimeSolutionList;

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

			public List<ListDISyncTasks_RealTimeSolutionListItem> RealTimeSolutionList
			{
				get
				{
					return realTimeSolutionList;
				}
				set	
				{
					realTimeSolutionList = value;
				}
			}

			public class ListDISyncTasks_RealTimeSolutionListItem
			{

				private long? processId;

				private string processName;

				private string taskStatus;

				private string taskType;

				private long? createTime;

				public long? ProcessId
				{
					get
					{
						return processId;
					}
					set	
					{
						processId = value;
					}
				}

				public string ProcessName
				{
					get
					{
						return processName;
					}
					set	
					{
						processName = value;
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

				public long? CreateTime
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
			}
		}
	}
}
