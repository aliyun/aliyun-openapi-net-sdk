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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class DescribeTasksResponse : AcsResponse
	{

		private string requestId;

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

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

			private string dBName;

			private string beginTime;

			private string progressInfo;

			private string finishTime;

			private string taskAction;

			private string taskId;

			private string progress;

			private string finishTime1;

			private string status;

			private string taskErrorCode;

			private string taskErrorMessage;

			private string scaleOutToken;

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

			public string FinishTime1
			{
				get
				{
					return finishTime1;
				}
				set	
				{
					finishTime1 = value;
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

			public string ScaleOutToken
			{
				get
				{
					return scaleOutToken;
				}
				set	
				{
					scaleOutToken = value;
				}
			}
		}
	}
}
