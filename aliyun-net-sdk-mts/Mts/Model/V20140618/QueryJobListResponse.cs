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
	public class QueryJobListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryJobList_Job> jobList;

		private List<string> nonExistJobIds;

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

		public List<QueryJobList_Job> JobList
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

		public class QueryJobList_Job
		{

			private string creationTime;

			private long? percent;

			private string finishTime;

			private string state;

			private string jobId;

			private string code;

			private string message;

			private string pipelineId;

			private string submitTime;

			private QueryJobList_Output output;

			private QueryJobList_Input input;

			private QueryJobList_MNSMessageResult mNSMessageResult;

			private QueryJobList_Pipeline pipeline;

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

			public string FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
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

			public string SubmitTime
			{
				get
				{
					return submitTime;
				}
				set	
				{
					submitTime = value;
				}
			}

			public QueryJobList_Output Output
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

			public QueryJobList_Input Input
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

			public QueryJobList_MNSMessageResult MNSMessageResult
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

			public QueryJobList_Pipeline Pipeline
			{
				get
				{
					return pipeline;
				}
				set	
				{
					pipeline = value;
				}
			}

			public class QueryJobList_Output
			{

				private string waterMarkConfigUrl;

				private string deWatermark;

				private string priority;

				private string audioStreamMap;

				private string userData;

				private string extendData;

				private string videoStreamMap;

				private string rotate;

				private string mergeConfigUrl;

				private string templateId;

				private List<QueryJobList_WaterMark> waterMarkList;

				private List<QueryJobList_Merge> mergeList;

				private List<QueryJobList_OutSubtitle> outSubtitleList;

				private List<QueryJobList_Opening> openingList;

				private List<QueryJobList_TailSlate> tailSlateList;

				private QueryJobList_Video video;

				private QueryJobList_TransConfig transConfig;

				private QueryJobList_Encryption encryption;

				private QueryJobList_M3U8NonStandardSupport m3U8NonStandardSupport;

				private QueryJobList_Audio audio;

				private QueryJobList_SuperReso superReso;

				private QueryJobList_OutputFile outputFile;

				private QueryJobList_Container container;

				private QueryJobList_Clip clip;

				private QueryJobList_MuxConfig muxConfig;

				private QueryJobList_SubtitleConfig subtitleConfig;

				private QueryJobList_Properties properties;

				private QueryJobList_MultiSpeedInfo multiSpeedInfo;

				private QueryJobList_TraceMark traceMark;

				private QueryJobList_CopyrightMark copyrightMark;

				public string WaterMarkConfigUrl
				{
					get
					{
						return waterMarkConfigUrl;
					}
					set	
					{
						waterMarkConfigUrl = value;
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

				public string ExtendData
				{
					get
					{
						return extendData;
					}
					set	
					{
						extendData = value;
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

				public string MergeConfigUrl
				{
					get
					{
						return mergeConfigUrl;
					}
					set	
					{
						mergeConfigUrl = value;
					}
				}

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

				public List<QueryJobList_WaterMark> WaterMarkList
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

				public List<QueryJobList_Merge> MergeList
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

				public List<QueryJobList_OutSubtitle> OutSubtitleList
				{
					get
					{
						return outSubtitleList;
					}
					set	
					{
						outSubtitleList = value;
					}
				}

				public List<QueryJobList_Opening> OpeningList
				{
					get
					{
						return openingList;
					}
					set	
					{
						openingList = value;
					}
				}

				public List<QueryJobList_TailSlate> TailSlateList
				{
					get
					{
						return tailSlateList;
					}
					set	
					{
						tailSlateList = value;
					}
				}

				public QueryJobList_Video Video
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

				public QueryJobList_TransConfig TransConfig
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

				public QueryJobList_Encryption Encryption
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

				public QueryJobList_M3U8NonStandardSupport M3U8NonStandardSupport
				{
					get
					{
						return m3U8NonStandardSupport;
					}
					set	
					{
						m3U8NonStandardSupport = value;
					}
				}

				public QueryJobList_Audio Audio
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

				public QueryJobList_SuperReso SuperReso
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

				public QueryJobList_OutputFile OutputFile
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

				public QueryJobList_Container Container
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

				public QueryJobList_Clip Clip
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

				public QueryJobList_MuxConfig MuxConfig
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

				public QueryJobList_SubtitleConfig SubtitleConfig
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

				public QueryJobList_Properties Properties
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

				public QueryJobList_MultiSpeedInfo MultiSpeedInfo
				{
					get
					{
						return multiSpeedInfo;
					}
					set	
					{
						multiSpeedInfo = value;
					}
				}

				public QueryJobList_TraceMark TraceMark
				{
					get
					{
						return traceMark;
					}
					set	
					{
						traceMark = value;
					}
				}

				public QueryJobList_CopyrightMark CopyrightMark
				{
					get
					{
						return copyrightMark;
					}
					set	
					{
						copyrightMark = value;
					}
				}

				public class QueryJobList_WaterMark
				{

					private string type;

					private string referPos;

					private string dx;

					private string width;

					private string height;

					private string waterMarkTemplateId;

					private string dy;

					private QueryJobList_InputFile inputFile;

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

					public QueryJobList_InputFile InputFile
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

					public class QueryJobList_InputFile
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
				}

				public class QueryJobList_Merge
				{

					private string start;

					private string roleArn;

					private string mergeURL;

					private string duration;

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

					public string RoleArn
					{
						get
						{
							return roleArn;
						}
						set	
						{
							roleArn = value;
						}
					}

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

				public class QueryJobList_OutSubtitle
				{

					private string map;

					private bool? success;

					private string message;

					private QueryJobList_OutSubtitleFile outSubtitleFile;

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

					public bool? Success
					{
						get
						{
							return success;
						}
						set	
						{
							success = value;
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

					public QueryJobList_OutSubtitleFile OutSubtitleFile
					{
						get
						{
							return outSubtitleFile;
						}
						set	
						{
							outSubtitleFile = value;
						}
					}

					public class QueryJobList_OutSubtitleFile
					{

						private string roleArn;

						private string _object;

						private string location;

						private string bucket;

						public string RoleArn
						{
							get
							{
								return roleArn;
							}
							set	
							{
								roleArn = value;
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
				}

				public class QueryJobList_Opening
				{

					private string openUrl;

					private string start;

					private string width;

					private string height;

					public string OpenUrl
					{
						get
						{
							return openUrl;
						}
						set	
						{
							openUrl = value;
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
				}

				public class QueryJobList_TailSlate
				{

					private string start;

					private string bgColor;

					private bool? isMergeAudio;

					private string width;

					private string height;

					private string blendDuration;

					private string tailUrl;

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

					public string BgColor
					{
						get
						{
							return bgColor;
						}
						set	
						{
							bgColor = value;
						}
					}

					public bool? IsMergeAudio
					{
						get
						{
							return isMergeAudio;
						}
						set	
						{
							isMergeAudio = value;
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

					public string BlendDuration
					{
						get
						{
							return blendDuration;
						}
						set	
						{
							blendDuration = value;
						}
					}

					public string TailUrl
					{
						get
						{
							return tailUrl;
						}
						set	
						{
							tailUrl = value;
						}
					}
				}

				public class QueryJobList_Video
				{

					private string bufsize;

					private string degrain;

					private string pixFmt;

					private string pad;

					private string codec;

					private string height;

					private string qscale;

					private string crop;

					private string bitrate;

					private string maxrate;

					private string maxFps;

					private string profile;

					private string crf;

					private string gop;

					private string width;

					private string fps;

					private string preset;

					private string scanMode;

					private string resoPriority;

					private QueryJobList_BitrateBnd bitrateBnd;

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

					public string ResoPriority
					{
						get
						{
							return resoPriority;
						}
						set	
						{
							resoPriority = value;
						}
					}

					public QueryJobList_BitrateBnd BitrateBnd
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

					public class QueryJobList_BitrateBnd
					{

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

				public class QueryJobList_TransConfig
				{

					private string isCheckAudioBitrate;

					private string transMode;

					private string isCheckReso;

					private string isCheckVideoBitrateFail;

					private string adjDarMethod;

					private string isCheckVideoBitrate;

					private string isCheckResoFail;

					private string isCheckAudioBitrateFail;

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

					public string IsCheckVideoBitrateFail
					{
						get
						{
							return isCheckVideoBitrateFail;
						}
						set	
						{
							isCheckVideoBitrateFail = value;
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

					public string IsCheckAudioBitrateFail
					{
						get
						{
							return isCheckAudioBitrateFail;
						}
						set	
						{
							isCheckAudioBitrateFail = value;
						}
					}
				}

				public class QueryJobList_Encryption
				{

					private string type;

					private string key;

					private string keyType;

					private string id;

					private string keyUri;

					private string skipCnt;

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

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}

					public string KeyType
					{
						get
						{
							return keyType;
						}
						set	
						{
							keyType = value;
						}
					}

					public string Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
						}
					}

					public string KeyUri
					{
						get
						{
							return keyUri;
						}
						set	
						{
							keyUri = value;
						}
					}

					public string SkipCnt
					{
						get
						{
							return skipCnt;
						}
						set	
						{
							skipCnt = value;
						}
					}
				}

				public class QueryJobList_M3U8NonStandardSupport
				{

					private QueryJobList_TS tS;

					public QueryJobList_TS TS
					{
						get
						{
							return tS;
						}
						set	
						{
							tS = value;
						}
					}

					public class QueryJobList_TS
					{

						private bool? sizeSupport;

						private bool? md5Support;

						public bool? SizeSupport
						{
							get
							{
								return sizeSupport;
							}
							set	
							{
								sizeSupport = value;
							}
						}

						public bool? Md5Support
						{
							get
							{
								return md5Support;
							}
							set	
							{
								md5Support = value;
							}
						}
					}
				}

				public class QueryJobList_Audio
				{

					private string profile;

					private string codec;

					private string samplerate;

					private string qscale;

					private string channels;

					private string bitrate;

					private QueryJobList_Volume volume;

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

					public QueryJobList_Volume Volume
					{
						get
						{
							return volume;
						}
						set	
						{
							volume = value;
						}
					}

					public class QueryJobList_Volume
					{

						private string method;

						private string level;

						public string Method
						{
							get
							{
								return method;
							}
							set	
							{
								method = value;
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
					}
				}

				public class QueryJobList_SuperReso
				{

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

				public class QueryJobList_OutputFile
				{

					private string roleArn;

					private string _object;

					private string location;

					private string bucket;

					public string RoleArn
					{
						get
						{
							return roleArn;
						}
						set	
						{
							roleArn = value;
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

				public class QueryJobList_Container
				{

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

				public class QueryJobList_Clip
				{

					private QueryJobList_TimeSpan timeSpan;

					public QueryJobList_TimeSpan TimeSpan
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

					public class QueryJobList_TimeSpan
					{

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

				public class QueryJobList_MuxConfig
				{

					private QueryJobList_Webp webp;

					private QueryJobList_Gif gif;

					private QueryJobList_Segment segment;

					public QueryJobList_Webp Webp
					{
						get
						{
							return webp;
						}
						set	
						{
							webp = value;
						}
					}

					public QueryJobList_Gif Gif
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

					public QueryJobList_Segment Segment
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

					public class QueryJobList_Webp
					{

						private string loop;

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
					}

					public class QueryJobList_Gif
					{

						private string finalDelay;

						private string ditherMode;

						private string loop;

						private string isCustomPalette;

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
					}

					public class QueryJobList_Segment
					{

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
				}

				public class QueryJobList_SubtitleConfig
				{

					private List<QueryJobList_ExtSubtitle> extSubtitleList;

					private List<QueryJobList_Subtitle> subtitleList;

					public List<QueryJobList_ExtSubtitle> ExtSubtitleList
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

					public List<QueryJobList_Subtitle> SubtitleList
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

					public class QueryJobList_ExtSubtitle
					{

						private string charEnc;

						private string fontName;

						private QueryJobList_Input1 input1;

						public string CharEnc
						{
							get
							{
								return charEnc;
							}
							set	
							{
								charEnc = value;
							}
						}

						public string FontName
						{
							get
							{
								return fontName;
							}
							set	
							{
								fontName = value;
							}
						}

						public QueryJobList_Input1 Input1
						{
							get
							{
								return input1;
							}
							set	
							{
								input1 = value;
							}
						}

						public class QueryJobList_Input1
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
					}

					public class QueryJobList_Subtitle
					{

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
				}

				public class QueryJobList_Properties
				{

					private string width;

					private string height;

					private string duration;

					private string fps;

					private string bitrate;

					private string fileFormat;

					private string fileSize;

					private List<QueryJobList_SourceLogo> sourceLogos;

					private QueryJobList_Streams streams;

					private QueryJobList_Format format;

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

					public List<QueryJobList_SourceLogo> SourceLogos
					{
						get
						{
							return sourceLogos;
						}
						set	
						{
							sourceLogos = value;
						}
					}

					public QueryJobList_Streams Streams
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

					public QueryJobList_Format Format
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

					public class QueryJobList_SourceLogo
					{

						private string source;

						public string Source
						{
							get
							{
								return source;
							}
							set	
							{
								source = value;
							}
						}
					}

					public class QueryJobList_Streams
					{

						private List<QueryJobList_VideoStream> videoStreamList;

						private List<QueryJobList_AudioStream> audioStreamList;

						private List<QueryJobList_SubtitleStream> subtitleStreamList;

						public List<QueryJobList_VideoStream> VideoStreamList
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

						public List<QueryJobList_AudioStream> AudioStreamList
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

						public List<QueryJobList_SubtitleStream> SubtitleStreamList
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

						public class QueryJobList_VideoStream
						{

							private string index;

							private string timebase;

							private string avgFPS;

							private string pixFmt;

							private string sar;

							private string lang;

							private string codecLongName;

							private string height;

							private string numFrames;

							private string bitrate;

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

							private string colorTransfer;

							private string colorPrimaries;

							private string bitsPerRawSample;

							private QueryJobList_NetworkCost networkCost;

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

							public string BitsPerRawSample
							{
								get
								{
									return bitsPerRawSample;
								}
								set	
								{
									bitsPerRawSample = value;
								}
							}

							public QueryJobList_NetworkCost NetworkCost
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

							public class QueryJobList_NetworkCost
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

						public class QueryJobList_AudioStream
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

						public class QueryJobList_SubtitleStream
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

					public class QueryJobList_Format
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

				public class QueryJobList_MultiSpeedInfo
				{

					private string enable;

					private string code;

					private string message;

					private int? settingSpeed;

					private string downgradePolicy;

					private double? realSpeed;

					private double? duration;

					private double? timeCost;

					public string Enable
					{
						get
						{
							return enable;
						}
						set	
						{
							enable = value;
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

					public int? SettingSpeed
					{
						get
						{
							return settingSpeed;
						}
						set	
						{
							settingSpeed = value;
						}
					}

					public string DowngradePolicy
					{
						get
						{
							return downgradePolicy;
						}
						set	
						{
							downgradePolicy = value;
						}
					}

					public double? RealSpeed
					{
						get
						{
							return realSpeed;
						}
						set	
						{
							realSpeed = value;
						}
					}

					public double? Duration
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

					public double? TimeCost
					{
						get
						{
							return timeCost;
						}
						set	
						{
							timeCost = value;
						}
					}
				}

				public class QueryJobList_TraceMark
				{

					private string enable;

					public string Enable
					{
						get
						{
							return enable;
						}
						set	
						{
							enable = value;
						}
					}
				}

				public class QueryJobList_CopyrightMark
				{

					private string content;

					public string Content
					{
						get
						{
							return content;
						}
						set	
						{
							content = value;
						}
					}
				}
			}

			public class QueryJobList_Input
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

			public class QueryJobList_MNSMessageResult
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

			public class QueryJobList_Pipeline
			{

				private string id;

				private string name;

				private string speed;

				private string state;

				private QueryJobList_ExtendConfig extendConfig;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Speed
				{
					get
					{
						return speed;
					}
					set	
					{
						speed = value;
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

				public QueryJobList_ExtendConfig ExtendConfig
				{
					get
					{
						return extendConfig;
					}
					set	
					{
						extendConfig = value;
					}
				}

				public class QueryJobList_ExtendConfig
				{

					private bool? isBoostNew;

					private int? maxMultiSpeed;

					private string multiSpeedDowngradePolicy;

					public bool? IsBoostNew
					{
						get
						{
							return isBoostNew;
						}
						set	
						{
							isBoostNew = value;
						}
					}

					public int? MaxMultiSpeed
					{
						get
						{
							return maxMultiSpeed;
						}
						set	
						{
							maxMultiSpeed = value;
						}
					}

					public string MultiSpeedDowngradePolicy
					{
						get
						{
							return multiSpeedDowngradePolicy;
						}
						set	
						{
							multiSpeedDowngradePolicy = value;
						}
					}
				}
			}
		}
	}
}
