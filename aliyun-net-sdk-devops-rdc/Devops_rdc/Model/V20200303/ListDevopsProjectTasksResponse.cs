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
	public class ListDevopsProjectTasksResponse : AcsResponse
	{

		private string errorMsg;

		private string requestId;

		private bool? successful;

		private string errorCode;

		private List<ListDevopsProjectTasks_Task> _object;

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

		public List<ListDevopsProjectTasks_Task> _Object
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

		public class ListDevopsProjectTasks_Task
		{

			private string taskgroupId;

			private string tasklistId;

			private string projectId;

			private string modifierId;

			private string updated;

			private string creatorId;

			private string created;

			private string name;

			private string id;

			public string TaskgroupId
			{
				get
				{
					return taskgroupId;
				}
				set	
				{
					taskgroupId = value;
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

			public string ModifierId
			{
				get
				{
					return modifierId;
				}
				set	
				{
					modifierId = value;
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
