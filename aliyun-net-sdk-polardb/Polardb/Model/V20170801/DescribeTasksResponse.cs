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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeTasksResponse : AcsResponse
	{

		private string requestId;

		private string startTime;

		private string endTime;

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private string dBClusterId;

		private List<DescribeTasks_Task> tasks;

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

		public string StartTime
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

		public string EndTime
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

		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
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

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
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

		public List<DescribeTasks_Task> Tasks
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

		public class DescribeTasks_Task
		{

			private string taskId;

			private string beginTime;

			private string finishTime;

			private string expectedFinishTime;

			private string taskAction;

			private int? progress;

			private string dBName;

			private string progressInfo;

			private string taskErrorCode;

			private string taskErrorMessage;

			private string stepsInfo;

			private int? remain;

			private string stepProgressInfo;

			private string currentStepName;

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

			public string BeginTime
			{
				get
				{
					return beginTime;
				}
				set	
				{
					beginTime = value;
				}
			}

			public string FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
				}
			}

			public string ExpectedFinishTime
			{
				get
				{
					return expectedFinishTime;
				}
				set	
				{
					expectedFinishTime = value;
				}
			}

			public string TaskAction
			{
				get
				{
					return taskAction;
				}
				set	
				{
					taskAction = value;
				}
			}

			public int? Progress
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

			public string DBName
			{
				get
				{
					return dBName;
				}
				set	
				{
					dBName = value;
				}
			}

			public string ProgressInfo
			{
				get
				{
					return progressInfo;
				}
				set	
				{
					progressInfo = value;
				}
			}

			public string TaskErrorCode
			{
				get
				{
					return taskErrorCode;
				}
				set	
				{
					taskErrorCode = value;
				}
			}

			public string TaskErrorMessage
			{
				get
				{
					return taskErrorMessage;
				}
				set	
				{
					taskErrorMessage = value;
				}
			}

			public string StepsInfo
			{
				get
				{
					return stepsInfo;
				}
				set	
				{
					stepsInfo = value;
				}
			}

			public int? Remain
			{
				get
				{
					return remain;
				}
				set	
				{
					remain = value;
				}
			}

			public string StepProgressInfo
			{
				get
				{
					return stepProgressInfo;
				}
				set	
				{
					stepProgressInfo = value;
				}
			}

			public string CurrentStepName
			{
				get
				{
					return currentStepName;
				}
				set	
				{
					currentStepName = value;
				}
			}
		}
	}
}
