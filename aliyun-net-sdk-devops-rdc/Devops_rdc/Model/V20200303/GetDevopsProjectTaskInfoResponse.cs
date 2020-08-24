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

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
	public class GetDevopsProjectTaskInfoResponse : AcsResponse
	{

		private bool? successful;

		private string errorCode;

		private string errorMsg;

		private string requestId;

		private GetDevopsProjectTaskInfo__Object _object;

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

		public GetDevopsProjectTaskInfo__Object _Object
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

		public class GetDevopsProjectTaskInfo__Object
		{

			private string tasklistId;

			private string taskflowstatusId;

			private string taskType;

			private bool? isDeleted;

			private string creatorId;

			private bool? isTopInProject;

			private string executorId;

			private string storyPoint;

			private string created;

			private string organizationId;

			private bool? isDone;

			private string id;

			private string updated;

			private string sprintId;

			private string projectId;

			private string content;

			private string note;

			private string dueDate;

			private string startDate;

			private string visible;

			private string priority;

			private List<string> involveMembers;

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

			public bool? IsDeleted
			{
				get
				{
					return isDeleted;
				}
				set	
				{
					isDeleted = value;
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

			public bool? IsTopInProject
			{
				get
				{
					return isTopInProject;
				}
				set	
				{
					isTopInProject = value;
				}
			}

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

			public string Priority
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

			public List<string> InvolveMembers
			{
				get
				{
					return involveMembers;
				}
				set	
				{
					involveMembers = value;
				}
			}
		}
	}
}
