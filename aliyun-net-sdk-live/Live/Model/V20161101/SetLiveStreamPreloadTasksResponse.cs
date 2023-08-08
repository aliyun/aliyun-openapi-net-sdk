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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class SetLiveStreamPreloadTasksResponse : AcsResponse
	{

		private string status;

		private int? failedURL;

		private int? totalURL;

		private string requestId;

		private int? successURL;

		private List<SetLiveStreamPreloadTasks_PreloadTasksMessage> preloadTasksMessages;

		[JsonProperty(PropertyName = "Status")]
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

		[JsonProperty(PropertyName = "FailedURL")]
		public int? FailedURL
		{
			get
			{
				return failedURL;
			}
			set	
			{
				failedURL = value;
			}
		}

		[JsonProperty(PropertyName = "TotalURL")]
		public int? TotalURL
		{
			get
			{
				return totalURL;
			}
			set	
			{
				totalURL = value;
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

		[JsonProperty(PropertyName = "SuccessURL")]
		public int? SuccessURL
		{
			get
			{
				return successURL;
			}
			set	
			{
				successURL = value;
			}
		}

		[JsonProperty(PropertyName = "PreloadTasksMessages")]
		public List<SetLiveStreamPreloadTasks_PreloadTasksMessage> PreloadTasksMessages
		{
			get
			{
				return preloadTasksMessages;
			}
			set	
			{
				preloadTasksMessages = value;
			}
		}

		public class SetLiveStreamPreloadTasks_PreloadTasksMessage
		{

			private string playUrl;

			private string description;

			private string taskId;

			[JsonProperty(PropertyName = "PlayUrl")]
			public string PlayUrl
			{
				get
				{
					return playUrl;
				}
				set	
				{
					playUrl = value;
				}
			}

			[JsonProperty(PropertyName = "Description")]
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
		}
	}
}
