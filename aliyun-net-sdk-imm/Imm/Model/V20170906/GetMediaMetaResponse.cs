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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class GetMediaMetaResponse : AcsResponse
	{

		private string requestId;

		private string mediaUri;

		private GetMediaMeta_MediaMeta mediaMeta;

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

		public string MediaUri
		{
			get
			{
				return mediaUri;
			}
			set	
			{
				mediaUri = value;
			}
		}

		public GetMediaMeta_MediaMeta MediaMeta
		{
			get
			{
				return mediaMeta;
			}
			set	
			{
				mediaMeta = value;
			}
		}

		public class GetMediaMeta_MediaMeta
		{

			private GetMediaMeta_MediaFormat mediaFormat;

			private GetMediaMeta_MediaStreams mediaStreams;

			public GetMediaMeta_MediaFormat MediaFormat
			{
				get
				{
					return mediaFormat;
				}
				set	
				{
					mediaFormat = value;
				}
			}

			public GetMediaMeta_MediaStreams MediaStreams
			{
				get
				{
					return mediaStreams;
				}
				set	
				{
					mediaStreams = value;
				}
			}

			public class GetMediaMeta_MediaFormat
			{

				private int? numberStreams;

				private int? numberPrograms;

				private string formatName;

				private string formatLongName;

				private string size;

				private string duration;

				private string startTime;

				private string bitrate;

				private string creationTime;

				private string location;

				public int? NumberStreams
				{
					get
					{
						return numberStreams;
					}
					set	
					{
						numberStreams = value;
					}
				}

				public int? NumberPrograms
				{
					get
					{
						return numberPrograms;
					}
					set	
					{
						numberPrograms = value;
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
			}

			public class GetMediaMeta_MediaStreams
			{

				private List<GetMediaMeta_VideoStream> videoStreams;

				private List<GetMediaMeta_AudioStream> audioStreams;

				private List<GetMediaMeta_SubtitleStream> subtitleStreams;

				public List<GetMediaMeta_VideoStream> VideoStreams
				{
					get
					{
						return videoStreams;
					}
					set	
					{
						videoStreams = value;
					}
				}

				public List<GetMediaMeta_AudioStream> AudioStreams
				{
					get
					{
						return audioStreams;
					}
					set	
					{
						audioStreams = value;
					}
				}

				public List<GetMediaMeta_SubtitleStream> SubtitleStreams
				{
					get
					{
						return subtitleStreams;
					}
					set	
					{
						subtitleStreams = value;
					}
				}

				public class GetMediaMeta_VideoStream
				{

					private int? index;

					private string language;

					private string codecName;

					private string codecLongName;

					private string profile;

					private string codecTimeBase;

					private string codecTagString;

					private string codecTag;

					private int? width;

					private int? height;

					private int? hasBFrames;

					private string sampleAspectRatio;

					private string displayAspectRatio;

					private string pixelFormat;

					private int? level;

					private string frameRrate;

					private string averageFrameRate;

					private string timeBase;

					private string startTime;

					private string duration;

					private string bitrate;

					private string frames;

					public int? Index
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

					public string Language
					{
						get
						{
							return language;
						}
						set	
						{
							language = value;
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

					public int? Width
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

					public int? Height
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

					public int? HasBFrames
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

					public string SampleAspectRatio
					{
						get
						{
							return sampleAspectRatio;
						}
						set	
						{
							sampleAspectRatio = value;
						}
					}

					public string DisplayAspectRatio
					{
						get
						{
							return displayAspectRatio;
						}
						set	
						{
							displayAspectRatio = value;
						}
					}

					public string PixelFormat
					{
						get
						{
							return pixelFormat;
						}
						set	
						{
							pixelFormat = value;
						}
					}

					public int? Level
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

					public string FrameRrate
					{
						get
						{
							return frameRrate;
						}
						set	
						{
							frameRrate = value;
						}
					}

					public string AverageFrameRate
					{
						get
						{
							return averageFrameRate;
						}
						set	
						{
							averageFrameRate = value;
						}
					}

					public string TimeBase
					{
						get
						{
							return timeBase;
						}
						set	
						{
							timeBase = value;
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

					public string Frames
					{
						get
						{
							return frames;
						}
						set	
						{
							frames = value;
						}
					}
				}

				public class GetMediaMeta_AudioStream
				{

					private int? index;

					private string codecName;

					private string codecLongName;

					private string codecTimeBase;

					private string codecTagString;

					private string codecTag;

					private string sampleFormat;

					private string sampleRate;

					private int? channels;

					private string channelLayout;

					private string timeBase;

					private string startTime;

					private string duration;

					private string bitrate;

					private string frames;

					private string language;

					public int? Index
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

					public string SampleFormat
					{
						get
						{
							return sampleFormat;
						}
						set	
						{
							sampleFormat = value;
						}
					}

					public string SampleRate
					{
						get
						{
							return sampleRate;
						}
						set	
						{
							sampleRate = value;
						}
					}

					public int? Channels
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

					public string TimeBase
					{
						get
						{
							return timeBase;
						}
						set	
						{
							timeBase = value;
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

					public string Frames
					{
						get
						{
							return frames;
						}
						set	
						{
							frames = value;
						}
					}

					public string Language
					{
						get
						{
							return language;
						}
						set	
						{
							language = value;
						}
					}
				}

				public class GetMediaMeta_SubtitleStream
				{

					private int? index;

					private string language;

					public int? Index
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

					public string Language
					{
						get
						{
							return language;
						}
						set	
						{
							language = value;
						}
					}
				}
			}
		}
	}
}
