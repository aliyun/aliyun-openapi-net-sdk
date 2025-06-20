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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class SubmitMediaInfoJobResponse : AcsResponse
	{

		private string requestId;

		private SubmitMediaInfoJob_MediaInfoJob mediaInfoJob;

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

		public SubmitMediaInfoJob_MediaInfoJob MediaInfoJob
		{
			get
			{
				return mediaInfoJob;
			}
			set	
			{
				mediaInfoJob = value;
			}
		}

		public class SubmitMediaInfoJob_MediaInfoJob
		{

			private string creationTime;

			private string state;

			private string jobId;

			private string userData;

			private string code;

			private string message;

			private string pipelineId;

			private bool? async;

			private SubmitMediaInfoJob_Input input;

			private SubmitMediaInfoJob_MNSMessageResult mNSMessageResult;

			private SubmitMediaInfoJob_Properties properties;

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

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string UserData
			{
				get
				{
					return userData;
				}
				set	
				{
					userData = value;
				}
			}

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

			public string PipelineId
			{
				get
				{
					return pipelineId;
				}
				set	
				{
					pipelineId = value;
				}
			}

			public bool? Async
			{
				get
				{
					return async;
				}
				set	
				{
					async = value;
				}
			}

			public SubmitMediaInfoJob_Input Input
			{
				get
				{
					return input;
				}
				set	
				{
					input = value;
				}
			}

			public SubmitMediaInfoJob_MNSMessageResult MNSMessageResult
			{
				get
				{
					return mNSMessageResult;
				}
				set	
				{
					mNSMessageResult = value;
				}
			}

			public SubmitMediaInfoJob_Properties Properties
			{
				get
				{
					return properties;
				}
				set	
				{
					properties = value;
				}
			}

			public class SubmitMediaInfoJob_Input
			{

				private string _object;

				private string location;

				private string bucket;

				public string _Object
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

				public string Location
				{
					get
					{
						return location;
					}
					set	
					{
						location = value;
					}
				}

				public string Bucket
				{
					get
					{
						return bucket;
					}
					set	
					{
						bucket = value;
					}
				}
			}

			public class SubmitMediaInfoJob_MNSMessageResult
			{

				private string messageId;

				private string errorMessage;

				private string errorCode;

				public string MessageId
				{
					get
					{
						return messageId;
					}
					set	
					{
						messageId = value;
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
			}

			public class SubmitMediaInfoJob_Properties
			{

				private string width;

				private string height;

				private string duration;

				private string fps;

				private string bitrate;

				private string fileFormat;

				private string fileSize;

				private SubmitMediaInfoJob_Streams streams;

				private SubmitMediaInfoJob_Format format;

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

				public string FileFormat
				{
					get
					{
						return fileFormat;
					}
					set	
					{
						fileFormat = value;
					}
				}

				public string FileSize
				{
					get
					{
						return fileSize;
					}
					set	
					{
						fileSize = value;
					}
				}

				public SubmitMediaInfoJob_Streams Streams
				{
					get
					{
						return streams;
					}
					set	
					{
						streams = value;
					}
				}

				public SubmitMediaInfoJob_Format Format
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

				public class SubmitMediaInfoJob_Streams
				{

					private List<SubmitMediaInfoJob_VideoStream> videoStreamList;

					private List<SubmitMediaInfoJob_AudioStream> audioStreamList;

					private List<SubmitMediaInfoJob_SubtitleStream> subtitleStreamList;

					public List<SubmitMediaInfoJob_VideoStream> VideoStreamList
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

					public List<SubmitMediaInfoJob_AudioStream> AudioStreamList
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

					public List<SubmitMediaInfoJob_SubtitleStream> SubtitleStreamList
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

					public class SubmitMediaInfoJob_VideoStream
					{

						private string sar;

						private string height;

						private string codecTagString;

						private string width;

						private string index;

						private string timebase;

						private string avgFPS;

						private string pixFmt;

						private string lang;

						private string codecLongName;

						private string numFrames;

						private string rotate;

						private string bitrate;

						private string hasBFrames;

						private string profile;

						private string startTime;

						private string dar;

						private string codecName;

						private string duration;

						private string fps;

						private string codecTag;

						private string codecTimeBase;

						private string level;

						private string colorRange;

						private string colorTransfer;

						private string colorPrimaries;

						private string durationInaccurate;

						private SubmitMediaInfoJob_NetworkCost networkCost;

						public string Sar
						{
							get
							{
								return sar;
							}
							set	
							{
								sar = value;
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

						public string CodecTagString
						{
							get
							{
								return codecTagString;
							}
							set	
							{
								codecTagString = value;
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

						public string Index
						{
							get
							{
								return index;
							}
							set	
							{
								index = value;
							}
						}

						public string Timebase
						{
							get
							{
								return timebase;
							}
							set	
							{
								timebase = value;
							}
						}

						public string AvgFPS
						{
							get
							{
								return avgFPS;
							}
							set	
							{
								avgFPS = value;
							}
						}

						public string PixFmt
						{
							get
							{
								return pixFmt;
							}
							set	
							{
								pixFmt = value;
							}
						}

						public string Lang
						{
							get
							{
								return lang;
							}
							set	
							{
								lang = value;
							}
						}

						public string CodecLongName
						{
							get
							{
								return codecLongName;
							}
							set	
							{
								codecLongName = value;
							}
						}

						public string NumFrames
						{
							get
							{
								return numFrames;
							}
							set	
							{
								numFrames = value;
							}
						}

						public string Rotate
						{
							get
							{
								return rotate;
							}
							set	
							{
								rotate = value;
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

						public string HasBFrames
						{
							get
							{
								return hasBFrames;
							}
							set	
							{
								hasBFrames = value;
							}
						}

						public string Profile
						{
							get
							{
								return profile;
							}
							set	
							{
								profile = value;
							}
						}

						public string StartTime
						{
							get
							{
								return startTime;
							}
							set	
							{
								startTime = value;
							}
						}

						public string Dar
						{
							get
							{
								return dar;
							}
							set	
							{
								dar = value;
							}
						}

						public string CodecName
						{
							get
							{
								return codecName;
							}
							set	
							{
								codecName = value;
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

						public string CodecTag
						{
							get
							{
								return codecTag;
							}
							set	
							{
								codecTag = value;
							}
						}

						public string CodecTimeBase
						{
							get
							{
								return codecTimeBase;
							}
							set	
							{
								codecTimeBase = value;
							}
						}

						public string Level
						{
							get
							{
								return level;
							}
							set	
							{
								level = value;
							}
						}

						public string ColorRange
						{
							get
							{
								return colorRange;
							}
							set	
							{
								colorRange = value;
							}
						}

						public string ColorTransfer
						{
							get
							{
								return colorTransfer;
							}
							set	
							{
								colorTransfer = value;
							}
						}

						public string ColorPrimaries
						{
							get
							{
								return colorPrimaries;
							}
							set	
							{
								colorPrimaries = value;
							}
						}

						public string DurationInaccurate
						{
							get
							{
								return durationInaccurate;
							}
							set	
							{
								durationInaccurate = value;
							}
						}

						public SubmitMediaInfoJob_NetworkCost NetworkCost
						{
							get
							{
								return networkCost;
							}
							set	
							{
								networkCost = value;
							}
						}

						public class SubmitMediaInfoJob_NetworkCost
						{

							private string preloadTime;

							private string avgBitrate;

							private string costBandwidth;

							public string PreloadTime
							{
								get
								{
									return preloadTime;
								}
								set	
								{
									preloadTime = value;
								}
							}

							public string AvgBitrate
							{
								get
								{
									return avgBitrate;
								}
								set	
								{
									avgBitrate = value;
								}
							}

							public string CostBandwidth
							{
								get
								{
									return costBandwidth;
								}
								set	
								{
									costBandwidth = value;
								}
							}
						}
					}

					public class SubmitMediaInfoJob_AudioStream
					{

						private string timebase;

						private string index;

						private string sampleFmt;

						private string channelLayout;

						private string lang;

						private string samplerate;

						private string codecLongName;

						private string channels;

						private string numFrames;

						private string bitrate;

						private string codecTagString;

						private string startTime;

						private string codecName;

						private string duration;

						private string codecTag;

						private string codecTimeBase;

						private string durationInaccurate;

						public string Timebase
						{
							get
							{
								return timebase;
							}
							set	
							{
								timebase = value;
							}
						}

						public string Index
						{
							get
							{
								return index;
							}
							set	
							{
								index = value;
							}
						}

						public string SampleFmt
						{
							get
							{
								return sampleFmt;
							}
							set	
							{
								sampleFmt = value;
							}
						}

						public string ChannelLayout
						{
							get
							{
								return channelLayout;
							}
							set	
							{
								channelLayout = value;
							}
						}

						public string Lang
						{
							get
							{
								return lang;
							}
							set	
							{
								lang = value;
							}
						}

						public string Samplerate
						{
							get
							{
								return samplerate;
							}
							set	
							{
								samplerate = value;
							}
						}

						public string CodecLongName
						{
							get
							{
								return codecLongName;
							}
							set	
							{
								codecLongName = value;
							}
						}

						public string Channels
						{
							get
							{
								return channels;
							}
							set	
							{
								channels = value;
							}
						}

						public string NumFrames
						{
							get
							{
								return numFrames;
							}
							set	
							{
								numFrames = value;
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

						public string CodecTagString
						{
							get
							{
								return codecTagString;
							}
							set	
							{
								codecTagString = value;
							}
						}

						public string StartTime
						{
							get
							{
								return startTime;
							}
							set	
							{
								startTime = value;
							}
						}

						public string CodecName
						{
							get
							{
								return codecName;
							}
							set	
							{
								codecName = value;
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

						public string CodecTag
						{
							get
							{
								return codecTag;
							}
							set	
							{
								codecTag = value;
							}
						}

						public string CodecTimeBase
						{
							get
							{
								return codecTimeBase;
							}
							set	
							{
								codecTimeBase = value;
							}
						}

						public string DurationInaccurate
						{
							get
							{
								return durationInaccurate;
							}
							set	
							{
								durationInaccurate = value;
							}
						}
					}

					public class SubmitMediaInfoJob_SubtitleStream
					{

						private string timebase;

						private string index;

						private string startTime;

						private string codecName;

						private string lang;

						private string codecLongName;

						private string duration;

						private string codecTag;

						private string codecTimeBase;

						private string codecTagString;

						public string Timebase
						{
							get
							{
								return timebase;
							}
							set	
							{
								timebase = value;
							}
						}

						public string Index
						{
							get
							{
								return index;
							}
							set	
							{
								index = value;
							}
						}

						public string StartTime
						{
							get
							{
								return startTime;
							}
							set	
							{
								startTime = value;
							}
						}

						public string CodecName
						{
							get
							{
								return codecName;
							}
							set	
							{
								codecName = value;
							}
						}

						public string Lang
						{
							get
							{
								return lang;
							}
							set	
							{
								lang = value;
							}
						}

						public string CodecLongName
						{
							get
							{
								return codecLongName;
							}
							set	
							{
								codecLongName = value;
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

						public string CodecTag
						{
							get
							{
								return codecTag;
							}
							set	
							{
								codecTag = value;
							}
						}

						public string CodecTimeBase
						{
							get
							{
								return codecTimeBase;
							}
							set	
							{
								codecTimeBase = value;
							}
						}

						public string CodecTagString
						{
							get
							{
								return codecTagString;
							}
							set	
							{
								codecTagString = value;
							}
						}
					}
				}

				public class SubmitMediaInfoJob_Format
				{

					private string startTime;

					private string numPrograms;

					private string size;

					private string numStreams;

					private string formatLongName;

					private string duration;

					private string bitrate;

					private string formatName;

					public string StartTime
					{
						get
						{
							return startTime;
						}
						set	
						{
							startTime = value;
						}
					}

					public string NumPrograms
					{
						get
						{
							return numPrograms;
						}
						set	
						{
							numPrograms = value;
						}
					}

					public string Size
					{
						get
						{
							return size;
						}
						set	
						{
							size = value;
						}
					}

					public string NumStreams
					{
						get
						{
							return numStreams;
						}
						set	
						{
							numStreams = value;
						}
					}

					public string FormatLongName
					{
						get
						{
							return formatLongName;
						}
						set	
						{
							formatLongName = value;
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

					public string FormatName
					{
						get
						{
							return formatName;
						}
						set	
						{
							formatName = value;
						}
					}
				}
			}
		}
	}
}
