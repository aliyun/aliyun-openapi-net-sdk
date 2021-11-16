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
	public class GetMezzanineInfoResponse : AcsResponse
	{

		private string requestId;

		private GetMezzanineInfo_Mezzanine mezzanine;

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

		public GetMezzanineInfo_Mezzanine Mezzanine
		{
			get
			{
				return mezzanine;
			}
			set	
			{
				mezzanine = value;
			}
		}

		public class GetMezzanineInfo_Mezzanine
		{

			private string creationTime;

			private string status;

			private string fileURL;

			private string videoId;

			private long? height;

			private string bitrate;

			private string fileName;

			private string outputType;

			private string preprocessStatus;

			private long? width;

			private long? size;

			private string cRC64;

			private string duration;

			private string fps;

			private List<GetMezzanineInfo_AudioStream> audioStreamList;

			private List<GetMezzanineInfo_VideoStream> videoStreamList;

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

			public string Status
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

			public string FileURL
			{
				get
				{
					return fileURL;
				}
				set	
				{
					fileURL = value;
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

			public long? Height
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

			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}

			public string OutputType
			{
				get
				{
					return outputType;
				}
				set	
				{
					outputType = value;
				}
			}

			public string PreprocessStatus
			{
				get
				{
					return preprocessStatus;
				}
				set	
				{
					preprocessStatus = value;
				}
			}

			public long? Width
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

			public long? Size
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

			public string CRC64
			{
				get
				{
					return cRC64;
				}
				set	
				{
					cRC64 = value;
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

			public List<GetMezzanineInfo_AudioStream> AudioStreamList
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

			public List<GetMezzanineInfo_VideoStream> VideoStreamList
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

			public class GetMezzanineInfo_AudioStream
			{

				private string index;

				private string timebase;

				private string sampleFmt;

				private string sampleRate;

				private string channelLayout;

				private string lang;

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

			public class GetMezzanineInfo_VideoStream
			{

				private string timebase;

				private string index;

				private string avgFPS;

				private string pixFmt;

				private string lang;

				private string sar;

				private string height;

				private string codecLongName;

				private string numFrames;

				private string bitrate;

				private string rotate;

				private string codecTagString;

				private string hasBFrames;

				private string profile;

				private string startTime;

				private string dar;

				private string codecName;

				private string width;

				private string duration;

				private string fps;

				private string codecTag;

				private string codecTimeBase;

				private string level;

				private string hDRType;

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

				public string HDRType
				{
					get
					{
						return hDRType;
					}
					set	
					{
						hDRType = value;
					}
				}
			}
		}
	}
}
