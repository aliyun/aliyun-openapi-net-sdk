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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeOnceTaskResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeOnceTask_TaskManageResponse> taskManageResponseList;

		private DescribeOnceTask_PageInfo pageInfo;

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

		public List<DescribeOnceTask_TaskManageResponse> TaskManageResponseList
		{
			get
			{
				return taskManageResponseList;
			}
			set	
			{
				taskManageResponseList = value;
			}
		}

		public DescribeOnceTask_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeOnceTask_TaskManageResponse
		{

			private string taskType;

			private string progress;

			private int? taskStatus;

			private string detailData;

			private string taskStatusText;

			private string taskName;

			private long? taskStartTime;

			private long? taskEndTime;

			private string taskId;

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

			public string Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
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

			public string DetailData
			{
				get
				{
					return detailData;
				}
				set	
				{
					detailData = value;
				}
			}

			public string TaskStatusText
			{
				get
				{
					return taskStatusText;
				}
				set	
				{
					taskStatusText = value;
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

			public long? TaskStartTime
			{
				get
				{
					return taskStartTime;
				}
				set	
				{
					taskStartTime = value;
				}
			}

			public long? TaskEndTime
			{
				get
				{
					return taskEndTime;
				}
				set	
				{
					taskEndTime = value;
				}
			}

			public string TaskId
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
		}

		public class DescribeOnceTask_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalCount;

			private int? count;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
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

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
