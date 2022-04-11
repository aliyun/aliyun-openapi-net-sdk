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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetTranscodeSummaryResponse : AcsResponse
	{

		private string requestId;

		private List<GetTranscodeSummary_TranscodeSummary> transcodeSummaryList;

		private List<string> nonExistVideoIds;

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

		public List<GetTranscodeSummary_TranscodeSummary> TranscodeSummaryList
		{
			get
			{
				return transcodeSummaryList;
			}
			set	
			{
				transcodeSummaryList = value;
			}
		}

		public List<string> NonExistVideoIds
		{
			get
			{
				return nonExistVideoIds;
			}
			set	
			{
				nonExistVideoIds = value;
			}
		}

		public class GetTranscodeSummary_TranscodeSummary
		{

			private string creationTime;

			private string trigger;

			private string videoId;

			private string completeTime;

			private string transcodeStatus;

			private string transcodeTemplateGroupId;

			private List<GetTranscodeSummary_TranscodeJobInfoSummary> transcodeJobInfoSummaryList;

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string Trigger
			{
				get
				{
					return trigger;
				}
				set	
				{
					trigger = value;
				}
			}

			public string VideoId
			{
				get
				{
					return videoId;
				}
				set	
				{
					videoId = value;
				}
			}

			public string CompleteTime
			{
				get
				{
					return completeTime;
				}
				set	
				{
					completeTime = value;
				}
			}

			public string TranscodeStatus
			{
				get
				{
					return transcodeStatus;
				}
				set	
				{
					transcodeStatus = value;
				}
			}

			public string TranscodeTemplateGroupId
			{
				get
				{
					return transcodeTemplateGroupId;
				}
				set	
				{
					transcodeTemplateGroupId = value;
				}
			}

			public List<GetTranscodeSummary_TranscodeJobInfoSummary> TranscodeJobInfoSummaryList
			{
				get
				{
					return transcodeJobInfoSummaryList;
				}
				set	
				{
					transcodeJobInfoSummaryList = value;
				}
			}

			public class GetTranscodeSummary_TranscodeJobInfoSummary
			{

				private string creationTime;

				private string errorMessage;

				private string encryption;

				private string height;

				private long? transcodeProgress;

				private string transcodeTemplateId;

				private string bitrate;

				private string definition;

				private string errorCode;

				private string completeTime;

				private string width;

				private string duration;

				private string fps;

				private string transcodeJobStatus;

				private long? filesize;

				private string format;

				private List<string> watermarkIdList;

				public string CreationTime
				{
					get
					{
						return creationTime;
					}
					set	
					{
						creationTime = value;
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

				public string Encryption
				{
					get
					{
						return encryption;
					}
					set	
					{
						encryption = value;
					}
				}

				public string Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}

				public long? TranscodeProgress
				{
					get
					{
						return transcodeProgress;
					}
					set	
					{
						transcodeProgress = value;
					}
				}

				public string TranscodeTemplateId
				{
					get
					{
						return transcodeTemplateId;
					}
					set	
					{
						transcodeTemplateId = value;
					}
				}

				public string Bitrate
				{
					get
					{
						return bitrate;
					}
					set	
					{
						bitrate = value;
					}
				}

				public string Definition
				{
					get
					{
						return definition;
					}
					set	
					{
						definition = value;
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

				public string CompleteTime
				{
					get
					{
						return completeTime;
					}
					set	
					{
						completeTime = value;
					}
				}

				public string Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}

				public string Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				public string Fps
				{
					get
					{
						return fps;
					}
					set	
					{
						fps = value;
					}
				}

				public string TranscodeJobStatus
				{
					get
					{
						return transcodeJobStatus;
					}
					set	
					{
						transcodeJobStatus = value;
					}
				}

				public long? Filesize
				{
					get
					{
						return filesize;
					}
					set	
					{
						filesize = value;
					}
				}

				public string Format
				{
					get
					{
						return format;
					}
					set	
					{
						format = value;
					}
				}

				public List<string> WatermarkIdList
				{
					get
					{
						return watermarkIdList;
					}
					set	
					{
						watermarkIdList = value;
					}
				}
			}
		}
	}
}
