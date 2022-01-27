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

		private string mediaUri;

		private string requestId;

		private GetMediaMeta_MediaMeta mediaMeta;

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

				private string size;

				private int? numberStreams;

				private string formatLongName;

				private string startTime;

				private string creationTime;

				private string formatName;

				private string duration;

				private string bitrate;

				private string location;

				private int? numberPrograms;

				private GetMediaMeta_Address address;

				private GetMediaMeta_Tag tag;

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

				public GetMediaMeta_Address Address
				{
					get
					{
						return address;
					}
					set	
					{
						address = value;
					}
				}

				public GetMediaMeta_Tag Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}

				public class GetMediaMeta_Address
				{

					private string township;

					private string addressLine;

					private string country;

					private string city;

					private string district;

					private string province;

					public string Township
					{
						get
						{
							return township;
						}
						set	
						{
							township = value;
						}
					}

					public string AddressLine
					{
						get
						{
							return addressLine;
						}
						set	
						{
							addressLine = value;
						}
					}

					public string Country
					{
						get
						{
							return country;
						}
						set	
						{
							country = value;
						}
					}

					public string City
					{
						get
						{
							return city;
						}
						set	
						{
							city = value;
						}
					}

					public string District
					{
						get
						{
							return district;
						}
						set	
						{
							district = value;
						}
					}

					public string Province
					{
						get
						{
							return province;
						}
						set	
						{
							province = value;
						}
					}
				}

				public class GetMediaMeta_Tag
				{

					private string artist;

					private string composer;

					private string performer;

					private string language;

					private string creationTime;

					private string title;

					private string album;

					private string albumArtist;

					public string Artist
					{
						get
						{
							return artist;
						}
						set	
						{
							artist = value;
						}
					}

					public string Composer
					{
						get
						{
							return composer;
						}
						set	
						{
							composer = value;
						}
					}

					public string Performer
					{
						get
						{
							return performer;
						}
						set	
						{
							performer = value;
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

					public string Album
					{
						get
						{
							return album;
						}
						set	
						{
							album = value;
						}
					}

					public string AlbumArtist
					{
						get
						{
							return albumArtist;
						}
						set	
						{
							albumArtist = value;
						}
					}
				}
			}

			public class GetMediaMeta_MediaStreams
			{

				private List<GetMediaMeta_VideoStream> videoStreams;

				private List<GetMediaMeta_SubtitleStream> subtitleStreams;

				private List<GetMediaMeta_AudioStream> audioStreams;

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

				public class GetMediaMeta_VideoStream
				{

					private string codecTag;

					private string frames;

					private string codecTimeBase;

					private string rotate;

					private string sampleAspectRatio;

					private string startTime;

					private string duration;

					private int? index;

					private string codecName;

					private string bitrate;

					private string profile;

					private string displayAspectRatio;

					private int? hasBFrames;

					private string codecTagString;

					private string averageFrameRate;

					private string language;

					private string codecLongName;

					private string pixelFormat;

					private int? level;

					private int? height;

					private string frameRrate;

					private int? width;

					private string timeBase;

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
				}

				public class GetMediaMeta_SubtitleStream
				{

					private string language;

					private int? index;

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
				}

				public class GetMediaMeta_AudioStream
				{

					private string codecTag;

					private string frames;

					private string codecTimeBase;

					private string channelLayout;

					private string startTime;

					private string duration;

					private int? index;

					private string codecName;

					private string bitrate;

					private string sampleFormat;

					private int? channels;

					private string codecTagString;

					private string sampleRate;

					private string language;

					private string codecLongName;

					private string timeBase;

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
				}
			}
		}
	}
}
