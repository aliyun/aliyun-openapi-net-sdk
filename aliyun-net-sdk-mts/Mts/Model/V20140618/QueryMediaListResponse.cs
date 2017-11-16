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
	public class QueryMediaListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryMediaList_Media> mediaList;

		private List<string> nonExistMediaIds;

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

		public List<QueryMediaList_Media> MediaList
		{
			get
			{
				return mediaList;
			}
			set	
			{
				mediaList = value;
			}
		}

		public List<string> NonExistMediaIds
		{
			get
			{
				return nonExistMediaIds;
			}
			set	
			{
				nonExistMediaIds = value;
			}
		}

		public class QueryMediaList_Media
		{

			private string mediaId;

			private string title;

			private string description;

			private string coverURL;

			private long? cateId;

			private string duration;

			private string format;

			private string size;

			private string bitrate;

			private string width;

			private string height;

			private string fps;

			private string publishState;

			private string creationTime;

			private List<QueryMediaList_Play> playList;

			private List<QueryMediaList_Snapshot> snapshotList;

			private List<string> tags;

			private List<string> runIdList;

			private QueryMediaList_File file;

			private QueryMediaList_MediaInfo mediaInfo;

			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
				}
			}

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

			public string CoverURL
			{
				get
				{
					return coverURL;
				}
				set	
				{
					coverURL = value;
				}
			}

			public long? CateId
			{
				get
				{
					return cateId;
				}
				set	
				{
					cateId = value;
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

			public string PublishState
			{
				get
				{
					return publishState;
				}
				set	
				{
					publishState = value;
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

			public List<QueryMediaList_Play> PlayList
			{
				get
				{
					return playList;
				}
				set	
				{
					playList = value;
				}
			}

			public List<QueryMediaList_Snapshot> SnapshotList
			{
				get
				{
					return snapshotList;
				}
				set	
				{
					snapshotList = value;
				}
			}

			public List<string> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<string> RunIdList
			{
				get
				{
					return runIdList;
				}
				set	
				{
					runIdList = value;
				}
			}

			public QueryMediaList_File File
			{
				get
				{
					return file;
				}
				set	
				{
					file = value;
				}
			}

			public QueryMediaList_MediaInfo MediaInfo
			{
				get
				{
					return mediaInfo;
				}
				set	
				{
					mediaInfo = value;
				}
			}

			public class QueryMediaList_Play
			{

				private string activityName;

				private string mediaWorkflowId;

				private string mediaWorkflowName;

				private string duration;

				private string format;

				private string size;

				private string bitrate;

				private string width;

				private string height;

				private string fps;

				private string encryption;

				private QueryMediaList_File1 file1;

				public string ActivityName
				{
					get
					{
						return activityName;
					}
					set	
					{
						activityName = value;
					}
				}

				public string MediaWorkflowId
				{
					get
					{
						return mediaWorkflowId;
					}
					set	
					{
						mediaWorkflowId = value;
					}
				}

				public string MediaWorkflowName
				{
					get
					{
						return mediaWorkflowName;
					}
					set	
					{
						mediaWorkflowName = value;
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

				public QueryMediaList_File1 File1
				{
					get
					{
						return file1;
					}
					set	
					{
						file1 = value;
					}
				}

				public class QueryMediaList_File1
				{

					private string uRL;

					private string state;

					public string URL
					{
						get
						{
							return uRL;
						}
						set	
						{
							uRL = value;
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
				}
			}

			public class QueryMediaList_Snapshot
			{

				private string type;

				private string mediaWorkflowId;

				private string mediaWorkflowName;

				private string activityName;

				private string count;

				private QueryMediaList_File2 file2;

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

				public string MediaWorkflowId
				{
					get
					{
						return mediaWorkflowId;
					}
					set	
					{
						mediaWorkflowId = value;
					}
				}

				public string MediaWorkflowName
				{
					get
					{
						return mediaWorkflowName;
					}
					set	
					{
						mediaWorkflowName = value;
					}
				}

				public string ActivityName
				{
					get
					{
						return activityName;
					}
					set	
					{
						activityName = value;
					}
				}

				public string Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public QueryMediaList_File2 File2
				{
					get
					{
						return file2;
					}
					set	
					{
						file2 = value;
					}
				}

				public class QueryMediaList_File2
				{

					private string uRL;

					private string state;

					public string URL
					{
						get
						{
							return uRL;
						}
						set	
						{
							uRL = value;
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
				}
			}

			public class QueryMediaList_File
			{

				private string uRL;

				private string state;

				public string URL
				{
					get
					{
						return uRL;
					}
					set	
					{
						uRL = value;
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
			}

			public class QueryMediaList_MediaInfo
			{

				private QueryMediaList_Streams streams;

				private QueryMediaList_Format format;

				public QueryMediaList_Streams Streams
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

				public QueryMediaList_Format Format
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

				public class QueryMediaList_Streams
				{

					private List<QueryMediaList_VideoStream> videoStreamList;

					private List<QueryMediaList_AudioStream> audioStreamList;

					private List<QueryMediaList_SubtitleStream> subtitleStreamList;

					public List<QueryMediaList_VideoStream> VideoStreamList
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

					public List<QueryMediaList_AudioStream> AudioStreamList
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

					public List<QueryMediaList_SubtitleStream> SubtitleStreamList
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

					public class QueryMediaList_VideoStream
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

						private QueryMediaList_NetworkCost networkCost;

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

						public QueryMediaList_NetworkCost NetworkCost
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

						public class QueryMediaList_NetworkCost
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

					public class QueryMediaList_AudioStream
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

					public class QueryMediaList_SubtitleStream
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

				public class QueryMediaList_Format
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
		}
	}
}