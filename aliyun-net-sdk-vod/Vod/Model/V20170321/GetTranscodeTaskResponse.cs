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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetTranscodeTaskResponse : AcsResponse
	{

		private string requestId;

		private GetTranscodeTask_TranscodeTask transcodeTask;

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

		public GetTranscodeTask_TranscodeTask TranscodeTask
		{
			get
			{
				return transcodeTask;
			}
			set	
			{
				transcodeTask = value;
			}
		}

		public class GetTranscodeTask_TranscodeTask
		{

			private string transcodeTaskId;

			private string videoId;

			private string taskStatus;

			private string creationTime;

			private string completeTime;

			private string trigger;

			private string transcodeTemplateGroupId;

			private List<GetTranscodeTask_TranscodeJobInfo> transcodeJobInfoList;

			public string TranscodeTaskId
			{
				get
				{
					return transcodeTaskId;
				}
				set	
				{
					transcodeTaskId = value;
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

			public string TaskStatus
			{
				get
				{
					return taskStatus;
				}
				set	
				{
					taskStatus = value;
				}
			}

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

			public List<GetTranscodeTask_TranscodeJobInfo> TranscodeJobInfoList
			{
				get
				{
					return transcodeJobInfoList;
				}
				set	
				{
					transcodeJobInfoList = value;
				}
			}

			public class GetTranscodeTask_TranscodeJobInfo
			{

				private string transcodeJobId;

				private string transcodeTemplateId;

				private string transcodeJobStatus;

				private string creationTime;

				private string completeTime;

				private long? transcodeProgress;

				private string inputFileUrl;

				private string priority;

				private string errorCode;

				private string errorMessage;

				private string definition;

				private GetTranscodeTask_OutputFile outputFile;

				public string TranscodeJobId
				{
					get
					{
						return transcodeJobId;
					}
					set	
					{
						transcodeJobId = value;
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

				public string InputFileUrl
				{
					get
					{
						return inputFileUrl;
					}
					set	
					{
						inputFileUrl = value;
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

				public GetTranscodeTask_OutputFile OutputFile
				{
					get
					{
						return outputFile;
					}
					set	
					{
						outputFile = value;
					}
				}

				public class GetTranscodeTask_OutputFile
				{

					private string width;

					private string height;

					private string bitrate;

					private string fps;

					private string format;

					private string duration;

					private long? filesize;

					private string encryption;

					private string audioStreamList;

					private string videoStreamList;

					private string subtitleStreamList;

					private string outputFileUrl;

					private List<string> watermarkIdList;

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

					public string AudioStreamList
					{
						get
						{
							return audioStreamList;
						}
						set	
						{
							audioStreamList = value;
						}
					}

					public string VideoStreamList
					{
						get
						{
							return videoStreamList;
						}
						set	
						{
							videoStreamList = value;
						}
					}

					public string SubtitleStreamList
					{
						get
						{
							return subtitleStreamList;
						}
						set	
						{
							subtitleStreamList = value;
						}
					}

					public string OutputFileUrl
					{
						get
						{
							return outputFileUrl;
						}
						set	
						{
							outputFileUrl = value;
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
}
