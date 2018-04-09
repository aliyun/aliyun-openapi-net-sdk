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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20180308
{
	public class TaskConfigListResponse : AcsResponse
	{

		private int? errorCode;

		private string errorMessage;

		private bool? success;

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? pageTotal;

		private int? total;

		private List<TaskConfigList_NodeTaskConfig> taskList;

		public int? ErrorCode
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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public int? PageTotal
		{
			get
			{
				return pageTotal;
			}
			set	
			{
				pageTotal = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<TaskConfigList_NodeTaskConfig> TaskList
		{
			get
			{
				return taskList;
			}
			set	
			{
				taskList = value;
			}
		}

		public class TaskConfigList_NodeTaskConfig
		{

			private long? id;

			private string taskName;

			private string taskType;

			private string taskScope;

			private bool? disabled;

			private long? groupId;

			private string groupName;

			private string jsonData;

			private string alertConfig;

			private List<string> instanceList;

			public long? Id
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

			public string TaskScope
			{
				get
				{
					return taskScope;
				}
				set	
				{
					taskScope = value;
				}
			}

			public bool? Disabled
			{
				get
				{
					return disabled;
				}
				set	
				{
					disabled = value;
				}
			}

			public long? GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public string JsonData
			{
				get
				{
					return jsonData;
				}
				set	
				{
					jsonData = value;
				}
			}

			public string AlertConfig
			{
				get
				{
					return alertConfig;
				}
				set	
				{
					alertConfig = value;
				}
			}

			public List<string> InstanceList
			{
				get
				{
					return instanceList;
				}
				set	
				{
					instanceList = value;
				}
			}
		}
	}
}