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

namespace Aliyun.Acs.avatar.Model.V20220130
{
	public class GetVideoTaskInfoResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private GetVideoTaskInfo_Data data;

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

		[JsonProperty(PropertyName = "Data")]
		public GetVideoTaskInfo_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetVideoTaskInfo_Data
		{

			private string taskUuid;

			private string type;

			private string status;

			private string process;

			private GetVideoTaskInfo_TaskResult taskResult;

			[JsonProperty(PropertyName = "TaskUuid")]
			public string TaskUuid
			{
				get
				{
					return taskUuid;
				}
				set	
				{
					taskUuid = value;
				}
			}

			[JsonProperty(PropertyName = "Type")]
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

			[JsonProperty(PropertyName = "Process")]
			public string Process
			{
				get
				{
					return process;
				}
				set	
				{
					process = value;
				}
			}

			[JsonProperty(PropertyName = "TaskResult")]
			public GetVideoTaskInfo_TaskResult TaskResult
			{
				get
				{
					return taskResult;
				}
				set	
				{
					taskResult = value;
				}
			}

			public class GetVideoTaskInfo_TaskResult
			{

				private string videoUrl;

				private string subtitlesUrl;

				private string wordSubtitlesUrl;

				private string failReason;

				private string failCode;

				private int? videoDuration;

				[JsonProperty(PropertyName = "VideoUrl")]
				public string VideoUrl
				{
					get
					{
						return videoUrl;
					}
					set	
					{
						videoUrl = value;
					}
				}

				[JsonProperty(PropertyName = "SubtitlesUrl")]
				public string SubtitlesUrl
				{
					get
					{
						return subtitlesUrl;
					}
					set	
					{
						subtitlesUrl = value;
					}
				}

				[JsonProperty(PropertyName = "WordSubtitlesUrl")]
				public string WordSubtitlesUrl
				{
					get
					{
						return wordSubtitlesUrl;
					}
					set	
					{
						wordSubtitlesUrl = value;
					}
				}

				[JsonProperty(PropertyName = "FailReason")]
				public string FailReason
				{
					get
					{
						return failReason;
					}
					set	
					{
						failReason = value;
					}
				}

				[JsonProperty(PropertyName = "FailCode")]
				public string FailCode
				{
					get
					{
						return failCode;
					}
					set	
					{
						failCode = value;
					}
				}

				[JsonProperty(PropertyName = "VideoDuration")]
				public int? VideoDuration
				{
					get
					{
						return videoDuration;
					}
					set	
					{
						videoDuration = value;
					}
				}
			}
		}
	}
}
