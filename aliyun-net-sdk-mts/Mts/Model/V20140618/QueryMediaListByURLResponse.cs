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
	public class QueryMediaListByURLResponse : AcsResponse
	{

		private string requestId;

		private List<QueryMediaListByURL_Media> mediaList;

		private List<string> nonExistFileURLs;

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

		public List<QueryMediaListByURL_Media> MediaList
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

		public List<string> NonExistFileURLs
		{
			get
			{
				return nonExistFileURLs;
			}
			set	
			{
				nonExistFileURLs = value;
			}
		}

		public class QueryMediaListByURL_Media
		{

			private string creationTime;

			private long? cateId;

			private string height;

			private string censorState;

			private string bitrate;

			private string mediaId;

			private string publishState;

			private string description;

			private string size;

			private string width;

			private string coverURL;

			private string duration;

			private string fps;

			private string title;

			private string format;

			private List<QueryMediaListByURL_Play> playList;

			private List<QueryMediaListByURL_Summary> summaryList;

			private List<QueryMediaListByURL_Snapshot> snapshotList;

			private List<string> tags;

			private List<string> runIdList;

			private QueryMediaListByURL_File file;

			private QueryMediaListByURL_MediaInfo mediaInfo;

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

			public string CensorState
			{
				get
				{
					return censorState;
				}
				set	
				{
					censorState = value;
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

			public List<QueryMediaListByURL_Play> PlayList
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

			public List<QueryMediaListByURL_Summary> SummaryList
			{
				get
				{
					return summaryList;
				}
				set	
				{
					summaryList = value;
				}
			}

			public List<QueryMediaListByURL_Snapshot> SnapshotList
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

			public QueryMediaListByURL_File File
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

			public QueryMediaListByURL_MediaInfo MediaInfo
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

			public class QueryMediaListByURL_Play
			{

				private string encryption;

				private string height;

				private string bitrate;

				private string mediaWorkflowId;

				private string width;

				private string size;

				private string fps;

				private string duration;

				private string activityName;

				private string format;

				private string mediaWorkflowName;

				private QueryMediaListByURL_File1 file1;

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

				public QueryMediaListByURL_File1 File1
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

				public class QueryMediaListByURL_File1
				{

					private string state;

					private string uRL;

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
				}
			}

			public class QueryMediaListByURL_Summary
			{

				private string type;

				private string mediaWorkflowId;

				private string activityName;

				private string mediaWorkflowName;

				private QueryMediaListByURL_File2 file2;

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

				public QueryMediaListByURL_File2 File2
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

				public class QueryMediaListByURL_File2
				{

					private string state;

					private string uRL;

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
				}
			}

			public class QueryMediaListByURL_Snapshot
			{

				private string type;

				private string mediaWorkflowId;

				private string activityName;

				private string count;

				private string mediaWorkflowName;

				private QueryMediaListByURL_File3 file3;

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

				public QueryMediaListByURL_File3 File3
				{
					get
					{
						return file3;
					}
					set	
					{
						file3 = value;
					}
				}

				public class QueryMediaListByURL_File3
				{

					private string state;

					private string uRL;

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
				}
			}

			public class QueryMediaListByURL_File
			{

				private string state;

				private string uRL;

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
			}

			public class QueryMediaListByURL_MediaInfo
			{

				private QueryMediaListByURL_Streams streams;

				private QueryMediaListByURL_Format format;

				public QueryMediaListByURL_Streams Streams
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

				public QueryMediaListByURL_Format Format
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

				public class QueryMediaListByURL_Streams
				{

					private List<QueryMediaListByURL_VideoStream> videoStreamList;

					private List<QueryMediaListByURL_AudioStream> audioStreamList;

					private List<QueryMediaListByURL_SubtitleStream> subtitleStreamList;

					public List<QueryMediaListByURL_VideoStream> VideoStreamList
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

					public List<QueryMediaListByURL_AudioStream> AudioStreamList
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

					public List<QueryMediaListByURL_SubtitleStream> SubtitleStreamList
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

					public class QueryMediaListByURL_VideoStream
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

						private QueryMediaListByURL_NetworkCost networkCost;

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

						public QueryMediaListByURL_NetworkCost NetworkCost
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

						public class QueryMediaListByURL_NetworkCost
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

					public class QueryMediaListByURL_AudioStream
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
					}

					public class QueryMediaListByURL_SubtitleStream
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

				public class QueryMediaListByURL_Format
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
