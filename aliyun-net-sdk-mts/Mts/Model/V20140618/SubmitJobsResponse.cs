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
	public class SubmitJobsResponse : AcsResponse
	{

		private string requestId;

		private List<SubmitJobs_JobResult> jobResultList;

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

		public List<SubmitJobs_JobResult> JobResultList
		{
			get
			{
				return jobResultList;
			}
			set	
			{
				jobResultList = value;
			}
		}

		public class SubmitJobs_JobResult
		{

			private string code;

			private string message;

			private bool? success;

			private SubmitJobs_Job job;

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

			public SubmitJobs_Job Job
			{
				get
				{
					return job;
				}
				set	
				{
					job = value;
				}
			}

			public class SubmitJobs_Job
			{

				private string code;

				private string creationTime;

				private string finishTime;

				private string jobId;

				private string message;

				private long? percent;

				private string pipelineId;

				private string state;

				private SubmitJobs_Input input;

				private SubmitJobs_MNSMessageResult mNSMessageResult;

				private SubmitJobs_Output output;

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

				public SubmitJobs_Input Input
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

				public SubmitJobs_MNSMessageResult MNSMessageResult
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

				public SubmitJobs_Output Output
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

				public class SubmitJobs_Input
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

				public class SubmitJobs_MNSMessageResult
				{

					private string errorCode;

					private string errorMessage;

					private string messageId;

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
				}

				public class SubmitJobs_Output
				{

					private string audioStreamMap;

					private string deWatermark;

					private string mergeConfigUrl;

					private string priority;

					private string rotate;

					private string templateId;

					private string userData;

					private string videoStreamMap;

					private string waterMarkConfigUrl;

					private List<SubmitJobs_Amix> amixList;

					private List<SubmitJobs_Merge> mergeList;

					private List<SubmitJobs_Opening> openingList;

					private List<SubmitJobs_OutSubtitle> outSubtitleList;

					private List<SubmitJobs_TailSlate> tailSlateList;

					private List<SubmitJobs_WaterMark> waterMarkList;

					private SubmitJobs_Audio audio;

					private SubmitJobs_Clip clip;

					private SubmitJobs_Container container;

					private SubmitJobs_DigiWaterMark digiWaterMark;

					private SubmitJobs_Encryption encryption;

					private SubmitJobs_M3U8NonStandardSupport m3U8NonStandardSupport;

					private SubmitJobs_MuxConfig muxConfig;

					private SubmitJobs_OutputFile outputFile;

					private SubmitJobs_Properties properties;

					private SubmitJobs_SubtitleConfig subtitleConfig;

					private SubmitJobs_SuperReso superReso;

					private SubmitJobs_TransConfig transConfig;

					private SubmitJobs_Video video;

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

					public List<SubmitJobs_Amix> AmixList
					{
						get
						{
							return amixList;
						}
						set	
						{
							amixList = value;
						}
					}

					public List<SubmitJobs_Merge> MergeList
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

					public List<SubmitJobs_Opening> OpeningList
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

					public List<SubmitJobs_OutSubtitle> OutSubtitleList
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

					public List<SubmitJobs_TailSlate> TailSlateList
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

					public List<SubmitJobs_WaterMark> WaterMarkList
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

					public SubmitJobs_Audio Audio
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

					public SubmitJobs_Clip Clip
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

					public SubmitJobs_Container Container
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

					public SubmitJobs_DigiWaterMark DigiWaterMark
					{
						get
						{
							return digiWaterMark;
						}
						set	
						{
							digiWaterMark = value;
						}
					}

					public SubmitJobs_Encryption Encryption
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

					public SubmitJobs_M3U8NonStandardSupport M3U8NonStandardSupport
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

					public SubmitJobs_MuxConfig MuxConfig
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

					public SubmitJobs_OutputFile OutputFile
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

					public SubmitJobs_Properties Properties
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

					public SubmitJobs_SubtitleConfig SubtitleConfig
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

					public SubmitJobs_SuperReso SuperReso
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

					public SubmitJobs_TransConfig TransConfig
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

					public SubmitJobs_Video Video
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

					public class SubmitJobs_Amix
					{

						private string amixURL;

						private string duration;

						private string map;

						private string mixDurMode;

						private string start;

						public string AmixURL
						{
							get
							{
								return amixURL;
							}
							set	
							{
								amixURL = value;
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

						public string MixDurMode
						{
							get
							{
								return mixDurMode;
							}
							set	
							{
								mixDurMode = value;
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
					}

					public class SubmitJobs_Merge
					{

						private string duration;

						private string mergeURL;

						private string roleArn;

						private string start;

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
					}

					public class SubmitJobs_Opening
					{

						private string height;

						private string start;

						private string width;

						private string openUrl;

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
					}

					public class SubmitJobs_OutSubtitle
					{

						private string map;

						private string message;

						private bool? success;

						private SubmitJobs_OutSubtitleFile outSubtitleFile;

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

						public SubmitJobs_OutSubtitleFile OutSubtitleFile
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

						public class SubmitJobs_OutSubtitleFile
						{

							private string bucket;

							private string location;

							private string _object;

							private string roleArn;

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
						}
					}

					public class SubmitJobs_TailSlate
					{

						private string bgColor;

						private string blendDuration;

						private string height;

						private bool? isMergeAudio;

						private string start;

						private string tailUrl;

						private string width;

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
					}

					public class SubmitJobs_WaterMark
					{

						private string dx;

						private string dy;

						private string height;

						private string referPos;

						private string type;

						private string waterMarkTemplateId;

						private string width;

						private SubmitJobs_InputFile inputFile;

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

						public SubmitJobs_InputFile InputFile
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

						public class SubmitJobs_InputFile
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
					}

					public class SubmitJobs_Audio
					{

						private string bitrate;

						private string channels;

						private string codec;

						private string profile;

						private string qscale;

						private string samplerate;

						private SubmitJobs_Volume volume;

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

						public SubmitJobs_Volume Volume
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

						public class SubmitJobs_Volume
						{

							private string level;

							private string method;

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
						}
					}

					public class SubmitJobs_Clip
					{

						private SubmitJobs_TimeSpan timeSpan;

						public SubmitJobs_TimeSpan TimeSpan
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

						public class SubmitJobs_TimeSpan
						{

							private string duration;

							private string seek;

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
						}
					}

					public class SubmitJobs_Container
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

					public class SubmitJobs_DigiWaterMark
					{

						private string alpha;

						private string type;

						private SubmitJobs_InputFile1 inputFile1;

						public string Alpha
						{
							get
							{
								return alpha;
							}
							set	
							{
								alpha = value;
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

						public SubmitJobs_InputFile1 InputFile1
						{
							get
							{
								return inputFile1;
							}
							set	
							{
								inputFile1 = value;
							}
						}

						public class SubmitJobs_InputFile1
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
					}

					public class SubmitJobs_Encryption
					{

						private string id;

						private string key;

						private string keyType;

						private string keyUri;

						private string skipCnt;

						private string type;

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
					}

					public class SubmitJobs_M3U8NonStandardSupport
					{

						private SubmitJobs_TS tS;

						public SubmitJobs_TS TS
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

						public class SubmitJobs_TS
						{

							private bool? md5Support;

							private bool? sizeSupport;

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
						}
					}

					public class SubmitJobs_MuxConfig
					{

						private SubmitJobs_Gif gif;

						private SubmitJobs_Segment segment;

						private SubmitJobs_Webp webp;

						public SubmitJobs_Gif Gif
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

						public SubmitJobs_Segment Segment
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

						public SubmitJobs_Webp Webp
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

						public class SubmitJobs_Gif
						{

							private string ditherMode;

							private string finalDelay;

							private string isCustomPalette;

							private string loop;

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

						public class SubmitJobs_Segment
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

						public class SubmitJobs_Webp
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
					}

					public class SubmitJobs_OutputFile
					{

						private string bucket;

						private string location;

						private string _object;

						private string roleArn;

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
					}

					public class SubmitJobs_Properties
					{

						private string bitrate;

						private string duration;

						private string fileFormat;

						private string fileSize;

						private string fps;

						private string height;

						private string width;

						private SubmitJobs_Format format;

						private SubmitJobs_Streams streams;

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

						public SubmitJobs_Format Format
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

						public SubmitJobs_Streams Streams
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

						public class SubmitJobs_Format
						{

							private string bitrate;

							private string duration;

							private string formatLongName;

							private string formatName;

							private string numPrograms;

							private string numStreams;

							private string size;

							private string startTime;

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
						}

						public class SubmitJobs_Streams
						{

							private List<SubmitJobs_AudioStream> audioStreamList;

							private List<SubmitJobs_SubtitleStream> subtitleStreamList;

							private List<SubmitJobs_VideoStream> videoStreamList;

							public List<SubmitJobs_AudioStream> AudioStreamList
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

							public List<SubmitJobs_SubtitleStream> SubtitleStreamList
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

							public List<SubmitJobs_VideoStream> VideoStreamList
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

							public class SubmitJobs_AudioStream
							{

								private string bitrate;

								private string channelLayout;

								private string channels;

								private string codecLongName;

								private string codecName;

								private string codecTag;

								private string codecTagString;

								private string codecTimeBase;

								private string duration;

								private string index;

								private string lang;

								private string numFrames;

								private string sampleFmt;

								private string samplerate;

								private string startTime;

								private string timebase;

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
							}

							public class SubmitJobs_SubtitleStream
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

							public class SubmitJobs_VideoStream
							{

								private string avgFPS;

								private string bitrate;

								private string codecLongName;

								private string codecName;

								private string codecTag;

								private string codecTagString;

								private string codecTimeBase;

								private string dar;

								private string duration;

								private string fps;

								private string hasBFrames;

								private string height;

								private string index;

								private string lang;

								private string level;

								private string numFrames;

								private string pixFmt;

								private string profile;

								private string sar;

								private string startTime;

								private string timebase;

								private string width;

								private SubmitJobs_NetworkCost networkCost;

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

								public SubmitJobs_NetworkCost NetworkCost
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

								public class SubmitJobs_NetworkCost
								{

									private string avgBitrate;

									private string costBandwidth;

									private string preloadTime;

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
								}
							}
						}
					}

					public class SubmitJobs_SubtitleConfig
					{

						private List<SubmitJobs_ExtSubtitle> extSubtitleList;

						private List<SubmitJobs_Subtitle> subtitleList;

						public List<SubmitJobs_ExtSubtitle> ExtSubtitleList
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

						public List<SubmitJobs_Subtitle> SubtitleList
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

						public class SubmitJobs_ExtSubtitle
						{

							private string charEnc;

							private string fontName;

							private SubmitJobs_Input2 input2;

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

							public SubmitJobs_Input2 Input2
							{
								get
								{
									return input2;
								}
								set	
								{
									input2 = value;
								}
							}

							public class SubmitJobs_Input2
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
						}

						public class SubmitJobs_Subtitle
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

					public class SubmitJobs_SuperReso
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

					public class SubmitJobs_TransConfig
					{

						private string adjDarMethod;

						private string isCheckAudioBitrate;

						private string isCheckAudioBitrateFail;

						private string isCheckReso;

						private string isCheckResoFail;

						private string isCheckVideoBitrate;

						private string isCheckVideoBitrateFail;

						private string transMode;

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
					}

					public class SubmitJobs_Video
					{

						private string bitrate;

						private string bufsize;

						private string codec;

						private string crf;

						private string crop;

						private string degrain;

						private string fps;

						private string gop;

						private string height;

						private string maxFps;

						private string maxrate;

						private string pad;

						private string pixFmt;

						private string preset;

						private string profile;

						private string qscale;

						private string resoPriority;

						private string scanMode;

						private string width;

						private SubmitJobs_BitrateBnd bitrateBnd;

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

						public SubmitJobs_BitrateBnd BitrateBnd
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

						public class SubmitJobs_BitrateBnd
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
				}
			}
		}
	}
}
