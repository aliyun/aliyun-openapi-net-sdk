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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class QueryMediaInfoJobListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryMediaInfoJobList_MediaInfoJob> mediaInfoJobList;

		private List<string> nonExistMediaInfoJobIds;

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

		public List<QueryMediaInfoJobList_MediaInfoJob> MediaInfoJobList
		{
			get
			{
				return mediaInfoJobList;
			}
			set	
			{
				mediaInfoJobList = value;
			}
		}

		public List<string> NonExistMediaInfoJobIds
		{
			get
			{
				return nonExistMediaInfoJobIds;
			}
			set	
			{
				nonExistMediaInfoJobIds = value;
			}
		}

		public class QueryMediaInfoJobList_MediaInfoJob
		{

			private string jobId;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string message;

			private string creationTime;

			private QueryMediaInfoJobList_Input input;

			private QueryMediaInfoJobList_Properties properties;

			private QueryMediaInfoJobList_MNSMessageResult mNSMessageResult;

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

			public QueryMediaInfoJobList_Input Input
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

			public QueryMediaInfoJobList_Properties Properties
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

			public QueryMediaInfoJobList_MNSMessageResult MNSMessageResult
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

			public class QueryMediaInfoJobList_Input
			{

				private string bucket;

				private string location;

				private string _object;

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
			}

			public class QueryMediaInfoJobList_Properties
			{

				private string width;

				private string height;

				private string bitrate;

				private string duration;

				private string fps;

				private string fileSize;

				private string fileFormat;

				private QueryMediaInfoJobList_Streams streams;

				private QueryMediaInfoJobList_Format format;

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

				public QueryMediaInfoJobList_Streams Streams
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

				public QueryMediaInfoJobList_Format Format
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

				public class QueryMediaInfoJobList_Streams
				{

					private List<QueryMediaInfoJobList_VideoStream> videoStreamList;

					private List<QueryMediaInfoJobList_AudioStream> audioStreamList;

					private List<QueryMediaInfoJobList_SubtitleStream> subtitleStreamList;

					public List<QueryMediaInfoJobList_VideoStream> VideoStreamList
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

					public List<QueryMediaInfoJobList_AudioStream> AudioStreamList
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

					public List<QueryMediaInfoJobList_SubtitleStream> SubtitleStreamList
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

					public class QueryMediaInfoJobList_VideoStream
					{

						private string index;

						private string codecName;

						private string codecLongName;

						private string profile;

						private string codecTimeBase;

						private string codecTagString;

						private string codecTag;

						private string width;

						private string height;

						private string hasBFrames;

						private string sar;

						private string dar;

						private string pixFmt;

						private string level;

						private string fps;

						private string avgFPS;

						private string timebase;

						private string startTime;

						private string duration;

						private string bitrate;

						private string numFrames;

						private string lang;

						private string rotate;

						private QueryMediaInfoJobList_NetworkCost networkCost;

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

						public QueryMediaInfoJobList_NetworkCost NetworkCost
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

						public class QueryMediaInfoJobList_NetworkCost
						{

							private string preloadTime;

							private string costBandwidth;

							private string avgBitrate;

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
						}
					}

					public class QueryMediaInfoJobList_AudioStream
					{

						private string index;

						private string codecName;

						private string codecTimeBase;

						private string codecLongName;

						private string codecTagString;

						private string codecTag;

						private string sampleFmt;

						private string samplerate;

						private string channels;

						private string channelLayout;

						private string timebase;

						private string startTime;

						private string duration;

						private string bitrate;

						private string numFrames;

						private string lang;

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
					}

					public class QueryMediaInfoJobList_SubtitleStream
					{

						private string index;

						private string lang;

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
					}
				}

				public class QueryMediaInfoJobList_Format
				{

					private string numStreams;

					private string numPrograms;

					private string formatName;

					private string formatLongName;

					private string startTime;

					private string duration;

					private string size;

					private string bitrate;

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
				}
			}

			public class QueryMediaInfoJobList_MNSMessageResult
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
		}
	}
}