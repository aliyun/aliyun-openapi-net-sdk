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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeTasksResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private List<DescribeTasks_TaskProgressInfo> items;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "PageRecordCount")]
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

		[JsonProperty(PropertyName = "TotalRecordCount")]
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

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeTasks_TaskProgressInfo> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeTasks_TaskProgressInfo
		{

			private string status;

			private string finishTime;

			private string progress;

			private string stepsInfo;

			private string beginTime;

			private string expectedFinishTime;

			private string taskErrorCode;

			private string currentStepName;

			private string progressInfo;

			private string stepProgressInfo;

			private string taskErrorMessage;

			private string taskAction;

			private int? remain;

			private string dBName;

			private string taskId;

			[JsonProperty(PropertyName = "Status")]
			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			[JsonProperty(PropertyName = "FinishTime")]
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

			[JsonProperty(PropertyName = "Progress")]
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

			[JsonProperty(PropertyName = "StepsInfo")]
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

			[JsonProperty(PropertyName = "BeginTime")]
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

			[JsonProperty(PropertyName = "ExpectedFinishTime")]
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

			[JsonProperty(PropertyName = "TaskErrorCode")]
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

			[JsonProperty(PropertyName = "CurrentStepName")]
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

			[JsonProperty(PropertyName = "ProgressInfo")]
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

			[JsonProperty(PropertyName = "StepProgressInfo")]
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

			[JsonProperty(PropertyName = "TaskErrorMessage")]
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

			[JsonProperty(PropertyName = "TaskAction")]
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

			[JsonProperty(PropertyName = "Remain")]
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

			[JsonProperty(PropertyName = "DBName")]
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

			[JsonProperty(PropertyName = "TaskId")]
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
	}
}
