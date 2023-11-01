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
	public class QueryVideoTaskInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private QueryVideoTaskInfo_Data data;

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

		[JsonProperty(PropertyName = "Data")]
		public QueryVideoTaskInfo_Data Data
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

		public class QueryVideoTaskInfo_Data
		{

			private int? pageNo;

			private int? pageSize;

			private long? totalCount;

			private List<QueryVideoTaskInfo_ListItem> list;

			[JsonProperty(PropertyName = "PageNo")]
			public int? PageNo
			{
				get
				{
					return pageNo;
				}
				set	
				{
					pageNo = value;
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

			[JsonProperty(PropertyName = "TotalCount")]
			public long? TotalCount
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

			[JsonProperty(PropertyName = "List")]
			public List<QueryVideoTaskInfo_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class QueryVideoTaskInfo_ListItem
			{

				private string taskUuid;

				private string title;

				private int? type;

				private int? status;

				private QueryVideoTaskInfo_TaskResult taskResult;

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

				[JsonProperty(PropertyName = "Title")]
				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}

				[JsonProperty(PropertyName = "Type")]
				public int? Type
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
				public int? Status
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

				[JsonProperty(PropertyName = "TaskResult")]
				public QueryVideoTaskInfo_TaskResult TaskResult
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

				public class QueryVideoTaskInfo_TaskResult
				{

					private string videoUrl;

					private string subtitlesUrl;

					private string wordSubtitlesUrl;

					private int? videoDuration;

					private string failReason;

					private string failCode;

					private string alphaUrl;

					private string previewPic;

					private string attachmentUrl;

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

					[JsonProperty(PropertyName = "AlphaUrl")]
					public string AlphaUrl
					{
						get
						{
							return alphaUrl;
						}
						set	
						{
							alphaUrl = value;
						}
					}

					[JsonProperty(PropertyName = "PreviewPic")]
					public string PreviewPic
					{
						get
						{
							return previewPic;
						}
						set	
						{
							previewPic = value;
						}
					}

					[JsonProperty(PropertyName = "AttachmentUrl")]
					public string AttachmentUrl
					{
						get
						{
							return attachmentUrl;
						}
						set	
						{
							attachmentUrl = value;
						}
					}
				}
			}
		}
	}
}
