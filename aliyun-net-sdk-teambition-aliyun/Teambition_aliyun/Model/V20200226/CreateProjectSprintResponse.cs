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

namespace Aliyun.Acs.teambition_aliyun.Model.V20200226
{
	public class CreateProjectSprintResponse : AcsResponse
	{

		private bool? successful;

		private string errorCode;

		private string errorMsg;

		private string requestId;

		private CreateProjectSprint__Object _object;

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

		public CreateProjectSprint__Object _Object
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

		public class CreateProjectSprint__Object
		{

			private string created;

			private string dueDate;

			private string description;

			private string accomplished;

			private bool? isDeleted;

			private string executor;

			private string name;

			private string creatorId;

			private string id;

			private string updated;

			private string startDate;

			private string status;

			private string projectId;

			private CreateProjectSprint_PlanToDo planToDo;

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

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string Accomplished
			{
				get
				{
					return accomplished;
				}
				set	
				{
					accomplished = value;
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

			public string Executor
			{
				get
				{
					return executor;
				}
				set	
				{
					executor = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
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

			public CreateProjectSprint_PlanToDo PlanToDo
			{
				get
				{
					return planToDo;
				}
				set	
				{
					planToDo = value;
				}
			}

			public class CreateProjectSprint_PlanToDo
			{

				private int? storyPoints;

				private int? workTimes;

				private int? tasks;

				public int? StoryPoints
				{
					get
					{
						return storyPoints;
					}
					set	
					{
						storyPoints = value;
					}
				}

				public int? WorkTimes
				{
					get
					{
						return workTimes;
					}
					set	
					{
						workTimes = value;
					}
				}

				public int? Tasks
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
			}
		}
	}
}
