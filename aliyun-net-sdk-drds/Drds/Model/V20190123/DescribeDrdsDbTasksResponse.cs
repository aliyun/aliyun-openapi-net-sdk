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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeDrdsDbTasksResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeDrdsDbTasks_Task> tasks;

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

		public List<DescribeDrdsDbTasks_Task> Tasks
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

		public class DescribeDrdsDbTasks_Task
		{

			private string taskName;

			private long? gmtCreate;

			private string taskDetail;

			private int? taskType;

			private int? taskStatus;

			private int? progress;

			private string taskPhase;

			private bool? showProgress;

			private bool? allowCancel;

			private string parentJobId;

			private string expandType;

			private long? targetId;

			private string label;

			private string detailTaskId;

			private int? tbComputeLength;

			private int? dbComputeLength;

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

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string TaskDetail
			{
				get
				{
					return taskDetail;
				}
				set	
				{
					taskDetail = value;
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

			public string TaskPhase
			{
				get
				{
					return taskPhase;
				}
				set	
				{
					taskPhase = value;
				}
			}

			public bool? ShowProgress
			{
				get
				{
					return showProgress;
				}
				set	
				{
					showProgress = value;
				}
			}

			public bool? AllowCancel
			{
				get
				{
					return allowCancel;
				}
				set	
				{
					allowCancel = value;
				}
			}

			public string ParentJobId
			{
				get
				{
					return parentJobId;
				}
				set	
				{
					parentJobId = value;
				}
			}

			public string ExpandType
			{
				get
				{
					return expandType;
				}
				set	
				{
					expandType = value;
				}
			}

			public long? TargetId
			{
				get
				{
					return targetId;
				}
				set	
				{
					targetId = value;
				}
			}

			public string Label
			{
				get
				{
					return label;
				}
				set	
				{
					label = value;
				}
			}

			public string DetailTaskId
			{
				get
				{
					return detailTaskId;
				}
				set	
				{
					detailTaskId = value;
				}
			}

			public int? TbComputeLength
			{
				get
				{
					return tbComputeLength;
				}
				set	
				{
					tbComputeLength = value;
				}
			}

			public int? DbComputeLength
			{
				get
				{
					return dbComputeLength;
				}
				set	
				{
					dbComputeLength = value;
				}
			}
		}
	}
}
