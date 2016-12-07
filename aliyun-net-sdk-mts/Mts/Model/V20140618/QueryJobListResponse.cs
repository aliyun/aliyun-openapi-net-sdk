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
	public class QueryJobListResponse : AcsResponse
	{

		private List<Job> jobList;

		private List<string> nonExistJobIds;

		public List<Job> JobList
		{
			get
			{
				return jobList;
			}
			set	
			{
				jobList = value;
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

		public class Job{

			private string jobId;

			private string state;

			private string code;

			private string message;

			private long? percent;

			private string pipelineId;

			private string creationTime;

			private Input_ input;

			private Output_ output;

			private MNSMessageResult_ mNSMessageResult;

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

			public long? Percent
			{
				get
				{
					return percent;
				}
				set	
				{
					percent = value;
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

			public Input_ Input
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

			public Output_ Output
			{
				get
				{
					return output;
				}
				set	
				{
					output = value;
				}
			}

			public MNSMessageResult_ MNSMessageResult
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

			public class Input_{

				private string bucket;

				private string location;

				private string object_;

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

				public string Object
				{
					get
					{
						return object_;
					}
					set	
					{
						object_ = value;
					}
				}
			}

			public class Output_{

				private string templateId;

				private string userData;

				private string rotate;

				private string videoStreamMap;

				private string audioStreamMap;

				private string deWatermark;

				private string priority;

				private List<WaterMark> waterMarkList;

				private List<Merge> mergeList;

				private OutputFile_ outputFile;

				private Properties_ properties;

				private Clip_ clip;

				private SuperReso_ superReso;

				private SubtitleConfig_ subtitleConfig;

				private TransConfig_ transConfig;

				private MuxConfig_ muxConfig;

				private Audio_ audio;

				private Video_ video;

				private Container_ container;

				public string TemplateId
				{
					get
					{
						return templateId;
					}
					set	
					{
						templateId = value;
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

				public string VideoStreamMap
				{
					get
					{
						return videoStreamMap;
					}
					set	
					{
						videoStreamMap = value;
					}
				}

				public string AudioStreamMap
				{
					get
					{
						return audioStreamMap;
					}
					set	
					{
						audioStreamMap = value;
					}
				}

				public string DeWatermark
				{
					get
					{
						return deWatermark;
					}
					set	
					{
						deWatermark = value;
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

				public List<WaterMark> WaterMarkList
				{
					get
					{
						return waterMarkList;
					}
					set	
					{
						waterMarkList = value;
					}
				}

				public List<Merge> MergeList
				{
					get
					{
						return mergeList;
					}
					set	
					{
						mergeList = value;
					}
				}

				public OutputFile_ OutputFile
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

				public Properties_ Properties
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

				public Clip_ Clip
				{
					get
					{
						return clip;
					}
					set	
					{
						clip = value;
					}
				}

				public SuperReso_ SuperReso
				{
					get
					{
						return superReso;
					}
					set	
					{
						superReso = value;
					}
				}

				public SubtitleConfig_ SubtitleConfig
				{
					get
					{
						return subtitleConfig;
					}
					set	
					{
						subtitleConfig = value;
					}
				}

				public TransConfig_ TransConfig
				{
					get
					{
						return transConfig;
					}
					set	
					{
						transConfig = value;
					}
				}

				public MuxConfig_ MuxConfig
				{
					get
					{
						return muxConfig;
					}
					set	
					{
						muxConfig = value;
					}
				}

				public Audio_ Audio
				{
					get
					{
						return audio;
					}
					set	
					{
						audio = value;
					}
				}

				public Video_ Video
				{
					get
					{
						return video;
					}
					set	
					{
						video = value;
					}
				}

				public Container_ Container
				{
					get
					{
						return container;
					}
					set	
					{
						container = value;
					}
				}

				public class WaterMark{

					private string waterMarkTemplateId;

					private string width;

					private string height;

					private string dx;

					private string dy;

					private string referPos;

					private string type;

					private InputFile_ inputFile;

					public string WaterMarkTemplateId
					{
						get
						{
							return waterMarkTemplateId;
						}
						set	
						{
							waterMarkTemplateId = value;
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

					public string Dx
					{
						get
						{
							return dx;
						}
						set	
						{
							dx = value;
						}
					}

					public string Dy
					{
						get
						{
							return dy;
						}
						set	
						{
							dy = value;
						}
					}

					public string ReferPos
					{
						get
						{
							return referPos;
						}
						set	
						{
							referPos = value;
						}
					}

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

					public InputFile_ InputFile
					{
						get
						{
							return inputFile;
						}
						set	
						{
							inputFile = value;
						}
					}

					public class InputFile_{

						private string bucket;

						private string location;

						private string object_;

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

						public string Object
						{
							get
							{
								return object_;
							}
							set	
							{
								object_ = value;
							}
						}
					}
				}

				public class Merge{

					private string mergeURL;

					private string start;

					private string duration;

					public string MergeURL
					{
						get
						{
							return mergeURL;
						}
						set	
						{
							mergeURL = value;
						}
					}

					public string Start
					{
						get
						{
							return start;
						}
						set	
						{
							start = value;
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
				}

				public class OutputFile_{

					private string bucket;

					private string location;

					private string object_;

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

					public string Object
					{
						get
						{
							return object_;
						}
						set	
						{
							object_ = value;
						}
					}
				}

				public class Properties_{

					private string width;

					private string height;

					private string bitrate;

					private string duration;

					private string fps;

					private string fileSize;

					private string fileFormat;

					private Streams_ streams;

					private Format_ format;

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

					public Streams_ Streams
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

					public Format_ Format
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

					public class Streams_{

						private List<VideoStream> videoStreamList;

						private List<AudioStream> audioStreamList;

						private List<SubtitleStream> subtitleStreamList;

						public List<VideoStream> VideoStreamList
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

						public List<AudioStream> AudioStreamList
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

						public List<SubtitleStream> SubtitleStreamList
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

						public class VideoStream{

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

							private NetworkCost_ networkCost;

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

							public NetworkCost_ NetworkCost
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

							public class NetworkCost_{

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

						public class AudioStream{

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

						public class SubtitleStream{

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

					public class Format_{

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

				public class Clip_{

					private TimeSpan_ timeSpan;

					public TimeSpan_ TimeSpan
					{
						get
						{
							return timeSpan;
						}
						set	
						{
							timeSpan = value;
						}
					}

					public class TimeSpan_{

						private string seek;

						private string duration;

						public string Seek
						{
							get
							{
								return seek;
							}
							set	
							{
								seek = value;
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
					}
				}

				public class SuperReso_{

					private string isHalfSample;

					public string IsHalfSample
					{
						get
						{
							return isHalfSample;
						}
						set	
						{
							isHalfSample = value;
						}
					}
				}

				public class SubtitleConfig_{

					private List<Subtitle> subtitleList;

					private List<ExtSubtitle> extSubtitleList;

					public List<Subtitle> SubtitleList
					{
						get
						{
							return subtitleList;
						}
						set	
						{
							subtitleList = value;
						}
					}

					public List<ExtSubtitle> ExtSubtitleList
					{
						get
						{
							return extSubtitleList;
						}
						set	
						{
							extSubtitleList = value;
						}
					}

					public class Subtitle{

						private string map;

						public string Map
						{
							get
							{
								return map;
							}
							set	
							{
								map = value;
							}
						}
					}

					public class ExtSubtitle{

						private Input_ input;

						public Input_ Input
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

						public class Input_{

							private string bucket;

							private string location;

							private string object_;

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

							public string Object
							{
								get
								{
									return object_;
								}
								set	
								{
									object_ = value;
								}
							}
						}
					}
				}

				public class TransConfig_{

					private string transMode;

					private string isCheckReso;

					private string isCheckResoFail;

					private string isCheckVideoBitrate;

					private string isCheckAudioBitrate;

					private string adjDarMethod;

					public string TransMode
					{
						get
						{
							return transMode;
						}
						set	
						{
							transMode = value;
						}
					}

					public string IsCheckReso
					{
						get
						{
							return isCheckReso;
						}
						set	
						{
							isCheckReso = value;
						}
					}

					public string IsCheckResoFail
					{
						get
						{
							return isCheckResoFail;
						}
						set	
						{
							isCheckResoFail = value;
						}
					}

					public string IsCheckVideoBitrate
					{
						get
						{
							return isCheckVideoBitrate;
						}
						set	
						{
							isCheckVideoBitrate = value;
						}
					}

					public string IsCheckAudioBitrate
					{
						get
						{
							return isCheckAudioBitrate;
						}
						set	
						{
							isCheckAudioBitrate = value;
						}
					}

					public string AdjDarMethod
					{
						get
						{
							return adjDarMethod;
						}
						set	
						{
							adjDarMethod = value;
						}
					}
				}

				public class MuxConfig_{

					private Segment_ segment;

					private Gif_ gif;

					public Segment_ Segment
					{
						get
						{
							return segment;
						}
						set	
						{
							segment = value;
						}
					}

					public Gif_ Gif
					{
						get
						{
							return gif;
						}
						set	
						{
							gif = value;
						}
					}

					public class Segment_{

						private string duration;

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
					}

					public class Gif_{

						private string loop;

						private string finalDelay;

						private string isCustomPalette;

						private string ditherMode;

						public string Loop
						{
							get
							{
								return loop;
							}
							set	
							{
								loop = value;
							}
						}

						public string FinalDelay
						{
							get
							{
								return finalDelay;
							}
							set	
							{
								finalDelay = value;
							}
						}

						public string IsCustomPalette
						{
							get
							{
								return isCustomPalette;
							}
							set	
							{
								isCustomPalette = value;
							}
						}

						public string DitherMode
						{
							get
							{
								return ditherMode;
							}
							set	
							{
								ditherMode = value;
							}
						}
					}
				}

				public class Audio_{

					private string codec;

					private string profile;

					private string samplerate;

					private string bitrate;

					private string channels;

					private string qscale;

					public string Codec
					{
						get
						{
							return codec;
						}
						set	
						{
							codec = value;
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

					public string Qscale
					{
						get
						{
							return qscale;
						}
						set	
						{
							qscale = value;
						}
					}
				}

				public class Video_{

					private string codec;

					private string profile;

					private string bitrate;

					private string crf;

					private string width;

					private string height;

					private string fps;

					private string gop;

					private string preset;

					private string scanMode;

					private string bufsize;

					private string maxrate;

					private string pixFmt;

					private string degrain;

					private string qscale;

					private string crop;

					private string pad;

					private string maxFps;

					private BitrateBnd_ bitrateBnd;

					public string Codec
					{
						get
						{
							return codec;
						}
						set	
						{
							codec = value;
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

					public string Crf
					{
						get
						{
							return crf;
						}
						set	
						{
							crf = value;
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

					public string Gop
					{
						get
						{
							return gop;
						}
						set	
						{
							gop = value;
						}
					}

					public string Preset
					{
						get
						{
							return preset;
						}
						set	
						{
							preset = value;
						}
					}

					public string ScanMode
					{
						get
						{
							return scanMode;
						}
						set	
						{
							scanMode = value;
						}
					}

					public string Bufsize
					{
						get
						{
							return bufsize;
						}
						set	
						{
							bufsize = value;
						}
					}

					public string Maxrate
					{
						get
						{
							return maxrate;
						}
						set	
						{
							maxrate = value;
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

					public string Degrain
					{
						get
						{
							return degrain;
						}
						set	
						{
							degrain = value;
						}
					}

					public string Qscale
					{
						get
						{
							return qscale;
						}
						set	
						{
							qscale = value;
						}
					}

					public string Crop
					{
						get
						{
							return crop;
						}
						set	
						{
							crop = value;
						}
					}

					public string Pad
					{
						get
						{
							return pad;
						}
						set	
						{
							pad = value;
						}
					}

					public string MaxFps
					{
						get
						{
							return maxFps;
						}
						set	
						{
							maxFps = value;
						}
					}

					public BitrateBnd_ BitrateBnd
					{
						get
						{
							return bitrateBnd;
						}
						set	
						{
							bitrateBnd = value;
						}
					}

					public class BitrateBnd_{

						private string max;

						private string min;

						public string Max
						{
							get
							{
								return max;
							}
							set	
							{
								max = value;
							}
						}

						public string Min
						{
							get
							{
								return min;
							}
							set	
							{
								min = value;
							}
						}
					}
				}

				public class Container_{

					private string format;

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
				}
			}

			public class MNSMessageResult_{

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