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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeTasksResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private string message;

		private int? pageSize;

		private int? pageNumber;

		private string code;

		private bool? success;

		private List<DescribeTasks_SimpleTask> tasks;

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "Message")]
		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "Code")]
		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "Tasks")]
		public List<DescribeTasks_SimpleTask> Tasks
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

		public class DescribeTasks_SimpleTask
		{

			private string stateCode;

			private int? progress;

			private string messageParams;

			private long? updatedTime;

			private string messageKey;

			private string name;

			private string stageCode;

			private long? createdTime;

			private string taskId;

			private string relatedResourceId;

			[JsonProperty(PropertyName = "StateCode")]
			public string StateCode
			{
				get
				{
					return stateCode;
				}
				set	
				{
					stateCode = value;
				}
			}

			[JsonProperty(PropertyName = "Progress")]
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

			[JsonProperty(PropertyName = "MessageParams")]
			public string MessageParams
			{
				get
				{
					return messageParams;
				}
				set	
				{
					messageParams = value;
				}
			}

			[JsonProperty(PropertyName = "UpdatedTime")]
			public long? UpdatedTime
			{
				get
				{
					return updatedTime;
				}
				set	
				{
					updatedTime = value;
				}
			}

			[JsonProperty(PropertyName = "MessageKey")]
			public string MessageKey
			{
				get
				{
					return messageKey;
				}
				set	
				{
					messageKey = value;
				}
			}

			[JsonProperty(PropertyName = "Name")]
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

			[JsonProperty(PropertyName = "StageCode")]
			public string StageCode
			{
				get
				{
					return stageCode;
				}
				set	
				{
					stageCode = value;
				}
			}

			[JsonProperty(PropertyName = "CreatedTime")]
			public long? CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
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

			[JsonProperty(PropertyName = "RelatedResourceId")]
			public string RelatedResourceId
			{
				get
				{
					return relatedResourceId;
				}
				set	
				{
					relatedResourceId = value;
				}
			}
		}
	}
}
