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

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
	public class CreateDevopsProjectTaskResponse : AcsResponse
	{

		private string errorMsg;

		private string requestId;

		private bool? successful;

		private string errorCode;

		private CreateDevopsProjectTask__Object _object;

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
			}
		}

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

		public bool? Successful
		{
			get
			{
				return successful;
			}
			set	
			{
				successful = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public CreateDevopsProjectTask__Object _Object
		{
			get
			{
				return _object;
			}
			set	
			{
				_object = value;
			}
		}

		public class CreateDevopsProjectTask__Object
		{

			private string executorId;

			private string projectId;

			private int? priority;

			private string scenarioFieldConfigId;

			private string ancestorIds;

			private string taskType;

			private string tasklistId;

			private string taskflowstatusId;

			private string note;

			private string updated;

			private int? uniqueId;

			private string content;

			private int? rating;

			private int? pos;

			private string storyPoint;

			private string startDate;

			private string creatorId;

			private string source;

			private string organizationId;

			private string visible;

			private bool? isDone;

			private string sprintId;

			private string dueDate;

			private string created;

			private string id;

			public string ExecutorId
			{
				get
				{
					return executorId;
				}
				set	
				{
					executorId = value;
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

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string ScenarioFieldConfigId
			{
				get
				{
					return scenarioFieldConfigId;
				}
				set	
				{
					scenarioFieldConfigId = value;
				}
			}

			public string AncestorIds
			{
				get
				{
					return ancestorIds;
				}
				set	
				{
					ancestorIds = value;
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

			public string TasklistId
			{
				get
				{
					return tasklistId;
				}
				set	
				{
					tasklistId = value;
				}
			}

			public string TaskflowstatusId
			{
				get
				{
					return taskflowstatusId;
				}
				set	
				{
					taskflowstatusId = value;
				}
			}

			public string Note
			{
				get
				{
					return note;
				}
				set	
				{
					note = value;
				}
			}

			public string Updated
			{
				get
				{
					return updated;
				}
				set	
				{
					updated = value;
				}
			}

			public int? UniqueId
			{
				get
				{
					return uniqueId;
				}
				set	
				{
					uniqueId = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public int? Rating
			{
				get
				{
					return rating;
				}
				set	
				{
					rating = value;
				}
			}

			public int? Pos
			{
				get
				{
					return pos;
				}
				set	
				{
					pos = value;
				}
			}

			public string StoryPoint
			{
				get
				{
					return storyPoint;
				}
				set	
				{
					storyPoint = value;
				}
			}

			public string StartDate
			{
				get
				{
					return startDate;
				}
				set	
				{
					startDate = value;
				}
			}

			public string CreatorId
			{
				get
				{
					return creatorId;
				}
				set	
				{
					creatorId = value;
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public string OrganizationId
			{
				get
				{
					return organizationId;
				}
				set	
				{
					organizationId = value;
				}
			}

			public string Visible
			{
				get
				{
					return visible;
				}
				set	
				{
					visible = value;
				}
			}

			public bool? IsDone
			{
				get
				{
					return isDone;
				}
				set	
				{
					isDone = value;
				}
			}

			public string SprintId
			{
				get
				{
					return sprintId;
				}
				set	
				{
					sprintId = value;
				}
			}

			public string DueDate
			{
				get
				{
					return dueDate;
				}
				set	
				{
					dueDate = value;
				}
			}

			public string Created
			{
				get
				{
					return created;
				}
				set	
				{
					created = value;
				}
			}

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}
		}
	}
}
