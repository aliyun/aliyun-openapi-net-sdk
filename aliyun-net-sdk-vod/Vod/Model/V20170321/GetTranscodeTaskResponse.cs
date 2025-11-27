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
	public class GetTranscodeTaskResponse : AcsResponse
	{

		private string requestId;

		private List<GetTranscodeTask_TranscodeJobInfo> transcodeJobInfoList;

		private List<string> nonExistJobIds;

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

		public List<string> NonExistJobIds
		{
			get
			{
				return nonExistJobIds;
			}
			set	
			{
				nonExistJobIds = value;
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

		public class GetTranscodeTask_TranscodeJobInfo
		{

			private string definition;

			private string creationTime;

			private string inputFileUrl;

			private string errorMessage;

			private string errorCode;

			private string completeTime;

			private long? transcodeProgress;

			private string priority;

			private string transcodeJobStatus;

			private string transcodeTemplateId;

			private string transcodeJobId;

			private GetTranscodeTask_OutputFile outputFile;

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

				private string videoStreamList;

				private string outputFileUrl;

				private string encryption;

				private string height;

				private string subtitleStreamList;

				private string bitrate;

				private string audioStreamList;

				private string width;

				private string fps;

				private string duration;

				private string format;

				private long? filesize;

				private List<string> watermarkIdList;

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

		public class GetTranscodeTask_TranscodeTask
		{

			private string creationTime;

			private string trigger;

			private string taskStatus;

			private string videoId;

			private string completeTime;

			private string transcodeTemplateGroupId;

			private string transcodeTaskId;

			private List<GetTranscodeTask_TranscodeJobInfo2> transcodeJobInfoList1;

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

			public List<GetTranscodeTask_TranscodeJobInfo2> TranscodeJobInfoList1
			{
				get
				{
					return transcodeJobInfoList1;
				}
				set	
				{
					transcodeJobInfoList1 = value;
				}
			}

			public class GetTranscodeTask_TranscodeJobInfo2
			{

				private string definition;

				private string creationTime;

				private string inputFileUrl;

				private string errorMessage;

				private string errorCode;

				private string completeTime;

				private long? transcodeProgress;

				private string priority;

				private string transcodeJobStatus;

				private string transcodeTemplateId;

				private string transcodeJobId;

				private GetTranscodeTask_OutputFile3 outputFile3;

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

				public GetTranscodeTask_OutputFile3 OutputFile3
				{
					get
					{
						return outputFile3;
					}
					set	
					{
						outputFile3 = value;
					}
				}

				public class GetTranscodeTask_OutputFile3
				{

					private string videoStreamList;

					private string outputFileUrl;

					private string encryption;

					private string height;

					private string subtitleStreamList;

					private string bitrate;

					private string audioStreamList;

					private string width;

					private string fps;

					private string duration;

					private string format;

					private long? filesize;

					private List<string> watermarkIdList4;

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

					public List<string> WatermarkIdList4
					{
						get
						{
							return watermarkIdList4;
						}
						set	
						{
							watermarkIdList4 = value;
						}
					}
				}
			}
		}
	}
}
