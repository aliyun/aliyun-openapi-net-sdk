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
	public class SubmitComplexJobResponse : AcsResponse
	{

		private string requestId;

		private SubmitComplexJob_ComplexJob complexJob;

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

		public SubmitComplexJob_ComplexJob ComplexJob
		{
			get
			{
				return complexJob;
			}
			set	
			{
				complexJob = value;
			}
		}

		public class SubmitComplexJob_ComplexJob
		{

			private string jobId;

			private string state;

			private string code;

			private string message;

			private long? percent;

			private string pipelineId;

			private string creationTime;

			private string finishTime;

			private List<SubmitComplexJob_InputsItem> inputs;

			private List<SubmitComplexJob_ComplexEditingConfigsItem> complexEditingConfigs;

			private SubmitComplexJob_TranscodeOutput transcodeOutput;

			private SubmitComplexJob_MNSMessageResult mNSMessageResult;

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

			public List<SubmitComplexJob_InputsItem> Inputs
			{
				get
				{
					return inputs;
				}
				set	
				{
					inputs = value;
				}
			}

			public List<SubmitComplexJob_ComplexEditingConfigsItem> ComplexEditingConfigs
			{
				get
				{
					return complexEditingConfigs;
				}
				set	
				{
					complexEditingConfigs = value;
				}
			}

			public SubmitComplexJob_TranscodeOutput TranscodeOutput
			{
				get
				{
					return transcodeOutput;
				}
				set	
				{
					transcodeOutput = value;
				}
			}

			public SubmitComplexJob_MNSMessageResult MNSMessageResult
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

			public class SubmitComplexJob_InputsItem
			{

				private List<SubmitComplexJob_EditingInput> editingInputs;

				public List<SubmitComplexJob_EditingInput> EditingInputs
				{
					get
					{
						return editingInputs;
					}
					set	
					{
						editingInputs = value;
					}
				}

				public class SubmitComplexJob_EditingInput
				{

					private string id;

					private SubmitComplexJob_InputFile inputFile;

					private SubmitComplexJob_InputConfig inputConfig;

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

					public SubmitComplexJob_InputFile InputFile
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

					public SubmitComplexJob_InputConfig InputConfig
					{
						get
						{
							return inputConfig;
						}
						set	
						{
							inputConfig = value;
						}
					}

					public class SubmitComplexJob_InputFile
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

					public class SubmitComplexJob_InputConfig
					{

						private string deinterlaceMethod;

						private string isNormalSar;

						public string DeinterlaceMethod
						{
							get
							{
								return deinterlaceMethod;
							}
							set	
							{
								deinterlaceMethod = value;
							}
						}

						public string IsNormalSar
						{
							get
							{
								return isNormalSar;
							}
							set	
							{
								isNormalSar = value;
							}
						}
					}
				}
			}

			public class SubmitComplexJob_ComplexEditingConfigsItem
			{

				private SubmitComplexJob_Editing editing;

				public SubmitComplexJob_Editing Editing
				{
					get
					{
						return editing;
					}
					set	
					{
						editing = value;
					}
				}

				public class SubmitComplexJob_Editing
				{

					private List<SubmitComplexJob_Clip> clipList;

					private SubmitComplexJob_Timeline timeline;

					public List<SubmitComplexJob_Clip> ClipList
					{
						get
						{
							return clipList;
						}
						set	
						{
							clipList = value;
						}
					}

					public SubmitComplexJob_Timeline Timeline
					{
						get
						{
							return timeline;
						}
						set	
						{
							timeline = value;
						}
					}

					public class SubmitComplexJob_Clip
					{

						private string id;

						private string type;

						private string sourceType;

						private string sourceID;

						private string sourceStrmMap;

						private string _in;

						private string _out;

						private List<SubmitComplexJob_Effect> effects;

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

						public string SourceType
						{
							get
							{
								return sourceType;
							}
							set	
							{
								sourceType = value;
							}
						}

						public string SourceID
						{
							get
							{
								return sourceID;
							}
							set	
							{
								sourceID = value;
							}
						}

						public string SourceStrmMap
						{
							get
							{
								return sourceStrmMap;
							}
							set	
							{
								sourceStrmMap = value;
							}
						}

						public string _In
						{
							get
							{
								return _in;
							}
							set	
							{
								_in = value;
							}
						}

						public string _Out
						{
							get
							{
								return _out;
							}
							set	
							{
								_out = value;
							}
						}

						public List<SubmitComplexJob_Effect> Effects
						{
							get
							{
								return effects;
							}
							set	
							{
								effects = value;
							}
						}

						public class SubmitComplexJob_Effect
						{

							private string effect;

							private string effectConfig;

							public string Effect
							{
								get
								{
									return effect;
								}
								set	
								{
									effect = value;
								}
							}

							public string EffectConfig
							{
								get
								{
									return effectConfig;
								}
								set	
								{
									effectConfig = value;
								}
							}
						}
					}

					public class SubmitComplexJob_Timeline
					{

						private List<SubmitComplexJob_Track> trackList;

						private SubmitComplexJob_TimelineConfig timelineConfig;

						public List<SubmitComplexJob_Track> TrackList
						{
							get
							{
								return trackList;
							}
							set	
							{
								trackList = value;
							}
						}

						public SubmitComplexJob_TimelineConfig TimelineConfig
						{
							get
							{
								return timelineConfig;
							}
							set	
							{
								timelineConfig = value;
							}
						}

						public class SubmitComplexJob_Track
						{

							private string id;

							private string type;

							private string order;

							private List<SubmitComplexJob_Clip1> clips;

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

							public string Order
							{
								get
								{
									return order;
								}
								set	
								{
									order = value;
								}
							}

							public List<SubmitComplexJob_Clip1> Clips
							{
								get
								{
									return clips;
								}
								set	
								{
									clips = value;
								}
							}

							public class SubmitComplexJob_Clip1
							{

								private string clipID;

								private string _in;

								private string _out;

								private SubmitComplexJob_ClipsConfig clipsConfig;

								public string ClipID
								{
									get
									{
										return clipID;
									}
									set	
									{
										clipID = value;
									}
								}

								public string _In
								{
									get
									{
										return _in;
									}
									set	
									{
										_in = value;
									}
								}

								public string _Out
								{
									get
									{
										return _out;
									}
									set	
									{
										_out = value;
									}
								}

								public SubmitComplexJob_ClipsConfig ClipsConfig
								{
									get
									{
										return clipsConfig;
									}
									set	
									{
										clipsConfig = value;
									}
								}

								public class SubmitComplexJob_ClipsConfig
								{

									private SubmitComplexJob_ClipsConfigVideo clipsConfigVideo;

									public SubmitComplexJob_ClipsConfigVideo ClipsConfigVideo
									{
										get
										{
											return clipsConfigVideo;
										}
										set	
										{
											clipsConfigVideo = value;
										}
									}

									public class SubmitComplexJob_ClipsConfigVideo
									{

										private string l;

										private string t;

										public string L
										{
											get
											{
												return l;
											}
											set	
											{
												l = value;
											}
										}

										public string T
										{
											get
											{
												return t;
											}
											set	
											{
												t = value;
											}
										}
									}
								}
							}
						}

						public class SubmitComplexJob_TimelineConfig
						{

							private SubmitComplexJob_TimelineConfigVideo timelineConfigVideo;

							private SubmitComplexJob_TimelineConfigAudio timelineConfigAudio;

							public SubmitComplexJob_TimelineConfigVideo TimelineConfigVideo
							{
								get
								{
									return timelineConfigVideo;
								}
								set	
								{
									timelineConfigVideo = value;
								}
							}

							public SubmitComplexJob_TimelineConfigAudio TimelineConfigAudio
							{
								get
								{
									return timelineConfigAudio;
								}
								set	
								{
									timelineConfigAudio = value;
								}
							}

							public class SubmitComplexJob_TimelineConfigVideo
							{

								private string width;

								private string height;

								private string bgColor;

								private string fps;

								private string renderRatio;

								private string reclosePrec;

								private string isGpuData;

								private string isOneTrackData;

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

								public string RenderRatio
								{
									get
									{
										return renderRatio;
									}
									set	
									{
										renderRatio = value;
									}
								}

								public string ReclosePrec
								{
									get
									{
										return reclosePrec;
									}
									set	
									{
										reclosePrec = value;
									}
								}

								public string IsGpuData
								{
									get
									{
										return isGpuData;
									}
									set	
									{
										isGpuData = value;
									}
								}

								public string IsOneTrackData
								{
									get
									{
										return isOneTrackData;
									}
									set	
									{
										isOneTrackData = value;
									}
								}
							}

							public class SubmitComplexJob_TimelineConfigAudio
							{

								private string samplerate;

								private string channelLayout;

								private string channels;

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
							}
						}
					}
				}
			}

			public class SubmitComplexJob_TranscodeOutput
			{

				private string templateId;

				private string userData;

				private string rotate;

				private string videoStreamMap;

				private string audioStreamMap;

				private string deWatermark;

				private string priority;

				private string waterMarkConfigUrl;

				private string mergeConfigUrl;

				private List<SubmitComplexJob_WaterMark> waterMarkList;

				private List<SubmitComplexJob_Merge> mergeList;

				private SubmitComplexJob_DigiWaterMark digiWaterMark;

				private SubmitComplexJob_OutputFile outputFile;

				private SubmitComplexJob_M3U8NonStandardSupport m3U8NonStandardSupport;

				private SubmitComplexJob_Properties properties;

				private SubmitComplexJob_Clip4 clip4;

				private SubmitComplexJob_SuperReso superReso;

				private SubmitComplexJob_SubtitleConfig subtitleConfig;

				private SubmitComplexJob_TransConfig transConfig;

				private SubmitComplexJob_MuxConfig muxConfig;

				private SubmitComplexJob_Audio audio;

				private SubmitComplexJob_Video video;

				private SubmitComplexJob_Container container;

				private SubmitComplexJob_Encryption encryption;

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

				public List<SubmitComplexJob_WaterMark> WaterMarkList
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

				public List<SubmitComplexJob_Merge> MergeList
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

				public SubmitComplexJob_DigiWaterMark DigiWaterMark
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

				public SubmitComplexJob_OutputFile OutputFile
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

				public SubmitComplexJob_M3U8NonStandardSupport M3U8NonStandardSupport
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

				public SubmitComplexJob_Properties Properties
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

				public SubmitComplexJob_Clip4 Clip4
				{
					get
					{
						return clip4;
					}
					set	
					{
						clip4 = value;
					}
				}

				public SubmitComplexJob_SuperReso SuperReso
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

				public SubmitComplexJob_SubtitleConfig SubtitleConfig
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

				public SubmitComplexJob_TransConfig TransConfig
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

				public SubmitComplexJob_MuxConfig MuxConfig
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

				public SubmitComplexJob_Audio Audio
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

				public SubmitComplexJob_Video Video
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

				public SubmitComplexJob_Container Container
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

				public SubmitComplexJob_Encryption Encryption
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

				public class SubmitComplexJob_WaterMark
				{

					private string waterMarkTemplateId;

					private string width;

					private string height;

					private string dx;

					private string dy;

					private string referPos;

					private string type;

					private SubmitComplexJob_InputFile2 inputFile2;

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

					public SubmitComplexJob_InputFile2 InputFile2
					{
						get
						{
							return inputFile2;
						}
						set	
						{
							inputFile2 = value;
						}
					}

					public class SubmitComplexJob_InputFile2
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

				public class SubmitComplexJob_Merge
				{

					private string mergeURL;

					private string start;

					private string duration;

					private string roleArn;

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

				public class SubmitComplexJob_DigiWaterMark
				{

					private string type;

					private string alpha;

					private SubmitComplexJob_InputFile3 inputFile3;

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

					public SubmitComplexJob_InputFile3 InputFile3
					{
						get
						{
							return inputFile3;
						}
						set	
						{
							inputFile3 = value;
						}
					}

					public class SubmitComplexJob_InputFile3
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

				public class SubmitComplexJob_OutputFile
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

				public class SubmitComplexJob_M3U8NonStandardSupport
				{

					private SubmitComplexJob_TS tS;

					public SubmitComplexJob_TS TS
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

					public class SubmitComplexJob_TS
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

				public class SubmitComplexJob_Properties
				{

					private string width;

					private string height;

					private string bitrate;

					private string duration;

					private string fps;

					private string fileSize;

					private string fileFormat;

					private SubmitComplexJob_Streams streams;

					private SubmitComplexJob_Format format;

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

					public SubmitComplexJob_Streams Streams
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

					public SubmitComplexJob_Format Format
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

					public class SubmitComplexJob_Streams
					{

						private List<SubmitComplexJob_VideoStream> videoStreamList;

						private List<SubmitComplexJob_AudioStream> audioStreamList;

						private List<SubmitComplexJob_SubtitleStream> subtitleStreamList;

						public List<SubmitComplexJob_VideoStream> VideoStreamList
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

						public List<SubmitComplexJob_AudioStream> AudioStreamList
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

						public List<SubmitComplexJob_SubtitleStream> SubtitleStreamList
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

						public class SubmitComplexJob_VideoStream
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

							private SubmitComplexJob_NetworkCost networkCost;

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

							public SubmitComplexJob_NetworkCost NetworkCost
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

							public class SubmitComplexJob_NetworkCost
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

						public class SubmitComplexJob_AudioStream
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

						public class SubmitComplexJob_SubtitleStream
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

					public class SubmitComplexJob_Format
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

				public class SubmitComplexJob_Clip4
				{

					private SubmitComplexJob_TimeSpan timeSpan;

					public SubmitComplexJob_TimeSpan TimeSpan
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

					public class SubmitComplexJob_TimeSpan
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

				public class SubmitComplexJob_SuperReso
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

				public class SubmitComplexJob_SubtitleConfig
				{

					private List<SubmitComplexJob_Subtitle> subtitleList;

					private List<SubmitComplexJob_ExtSubtitle> extSubtitleList;

					public List<SubmitComplexJob_Subtitle> SubtitleList
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

					public List<SubmitComplexJob_ExtSubtitle> ExtSubtitleList
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

					public class SubmitComplexJob_Subtitle
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

					public class SubmitComplexJob_ExtSubtitle
					{

						private string fontName;

						private string charEnc;

						private SubmitComplexJob_Input input;

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

						public SubmitComplexJob_Input Input
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

						public class SubmitComplexJob_Input
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
				}

				public class SubmitComplexJob_TransConfig
				{

					private string transMode;

					private string isCheckReso;

					private string isCheckResoFail;

					private string isCheckVideoBitrate;

					private string isCheckAudioBitrate;

					private string adjDarMethod;

					private string isCheckVideoBitrateFail;

					private string isCheckAudioBitrateFail;

					private string duration;

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

				public class SubmitComplexJob_MuxConfig
				{

					private SubmitComplexJob_Segment segment;

					private SubmitComplexJob_Gif gif;

					public SubmitComplexJob_Segment Segment
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

					public SubmitComplexJob_Gif Gif
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

					public class SubmitComplexJob_Segment
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

					public class SubmitComplexJob_Gif
					{

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

				public class SubmitComplexJob_Audio
				{

					private string codec;

					private string profile;

					private string samplerate;

					private string bitrate;

					private string channels;

					private string qscale;

					private SubmitComplexJob_Volume volume;

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

					public SubmitComplexJob_Volume Volume
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

					public class SubmitComplexJob_Volume
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

				public class SubmitComplexJob_Video
				{

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

					private SubmitComplexJob_BitrateBnd bitrateBnd;

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

					public SubmitComplexJob_BitrateBnd BitrateBnd
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

					public class SubmitComplexJob_BitrateBnd
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

				public class SubmitComplexJob_Container
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

				public class SubmitComplexJob_Encryption
				{

					private string type;

					private string id;

					private string key;

					private string keyUri;

					private string keyType;

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
			}

			public class SubmitComplexJob_MNSMessageResult
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