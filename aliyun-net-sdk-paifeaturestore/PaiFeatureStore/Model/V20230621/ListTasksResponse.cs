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

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
	public class ListTasksResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<ListTasks_TasksItem> tasks;

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

		public List<ListTasks_TasksItem> Tasks
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

		public class ListTasks_TasksItem
		{

			private string gmtCreateTime;

			private string gmtExecutedTime;

			private string gmtFinishedTime;

			private string objectId;

			private string objectType;

			private string projectId;

			private string projectName;

			private string status;

			private string taskId;

			private string type;

			public string GmtCreateTime
			{
				get
				{
					return gmtCreateTime;
				}
				set	
				{
					gmtCreateTime = value;
				}
			}

			public string GmtExecutedTime
			{
				get
				{
					return gmtExecutedTime;
				}
				set	
				{
					gmtExecutedTime = value;
				}
			}

			public string GmtFinishedTime
			{
				get
				{
					return gmtFinishedTime;
				}
				set	
				{
					gmtFinishedTime = value;
				}
			}

			public string ObjectId
			{
				get
				{
					return objectId;
				}
				set	
				{
					objectId = value;
				}
			}

			public string ObjectType
			{
				get
				{
					return objectType;
				}
				set	
				{
					objectType = value;
				}
			}

			public string ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
				}
			}

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}
		}
	}
}
