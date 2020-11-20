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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeTasksResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalRecordCount;

		private List<DescribeTasks_TaskProgressInfo> items;

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

			private string taskId;

			private string taskAction;

			private string status;

			private float? progress;

			private string beginTime;

			private string finishTime;

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

			public float? Progress
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
