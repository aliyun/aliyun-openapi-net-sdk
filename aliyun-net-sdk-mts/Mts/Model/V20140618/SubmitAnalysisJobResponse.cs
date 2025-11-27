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
	public class SubmitAnalysisJobResponse : AcsResponse
	{

		private string requestId;

		private SubmitAnalysisJob_AnalysisJob analysisJob;

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

		public SubmitAnalysisJob_AnalysisJob AnalysisJob
		{
			get
			{
				return analysisJob;
			}
			set	
			{
				analysisJob = value;
			}
		}

		public class SubmitAnalysisJob_AnalysisJob
		{

			private string creationTime;

			private long? percent;

			private string state;

			private string message;

			private string priority;

			private string userData;

			private string code;

			private string pipelineId;

			private string id;

			private List<SubmitAnalysisJob_Template> templateList;

			private SubmitAnalysisJob_AnalysisConfig analysisConfig;

			private SubmitAnalysisJob_MNSMessageResult mNSMessageResult;

			private SubmitAnalysisJob_InputFile inputFile;

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

			public List<SubmitAnalysisJob_Template> TemplateList
			{
				get
				{
					return templateList;
				}
				set	
				{
					templateList = value;
				}
			}

			public SubmitAnalysisJob_AnalysisConfig AnalysisConfig
			{
				get
				{
					return analysisConfig;
				}
				set	
				{
					analysisConfig = value;
				}
			}

			public SubmitAnalysisJob_MNSMessageResult MNSMessageResult
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

			public SubmitAnalysisJob_InputFile InputFile
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

			public class SubmitAnalysisJob_Template
			{

				private string state;

				private string name;

				private string id;

				private SubmitAnalysisJob_Video video;

				private SubmitAnalysisJob_TransConfig transConfig;

				private SubmitAnalysisJob_MuxConfig muxConfig;

				private SubmitAnalysisJob_Audio audio;

				private SubmitAnalysisJob_Container container;

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

				public SubmitAnalysisJob_Video Video
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

				public SubmitAnalysisJob_TransConfig TransConfig
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

				public SubmitAnalysisJob_MuxConfig MuxConfig
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

				public SubmitAnalysisJob_Audio Audio
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

				public SubmitAnalysisJob_Container Container
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

				public class SubmitAnalysisJob_Video
				{

					private string bufsize;

					private string degrain;

					private string pixFmt;

					private string codec;

					private string height;

					private string qscale;

					private string bitrate;

					private string maxrate;

					private string profile;

					private string crf;

					private string gop;

					private string width;

					private string fps;

					private string preset;

					private string scanMode;

					private SubmitAnalysisJob_BitrateBnd bitrateBnd;

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

					public SubmitAnalysisJob_BitrateBnd BitrateBnd
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

					public class SubmitAnalysisJob_BitrateBnd
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

				public class SubmitAnalysisJob_TransConfig
				{

					private string transMode;

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

				public class SubmitAnalysisJob_MuxConfig
				{

					private SubmitAnalysisJob_Gif gif;

					private SubmitAnalysisJob_Segment segment;

					public SubmitAnalysisJob_Gif Gif
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

					public SubmitAnalysisJob_Segment Segment
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

					public class SubmitAnalysisJob_Gif
					{

						private string finalDelay;

						private string loop;

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

					public class SubmitAnalysisJob_Segment
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

				public class SubmitAnalysisJob_Audio
				{

					private string profile;

					private string codec;

					private string samplerate;

					private string qscale;

					private string channels;

					private string bitrate;

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
				}

				public class SubmitAnalysisJob_Container
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
			}

			public class SubmitAnalysisJob_AnalysisConfig
			{

				private SubmitAnalysisJob_QualityControl qualityControl;

				private SubmitAnalysisJob_PropertiesControl propertiesControl;

				public SubmitAnalysisJob_QualityControl QualityControl
				{
					get
					{
						return qualityControl;
					}
					set	
					{
						qualityControl = value;
					}
				}

				public SubmitAnalysisJob_PropertiesControl PropertiesControl
				{
					get
					{
						return propertiesControl;
					}
					set	
					{
						propertiesControl = value;
					}
				}

				public class SubmitAnalysisJob_QualityControl
				{

					private string methodStreaming;

					private string rateQuality;

					public string MethodStreaming
					{
						get
						{
							return methodStreaming;
						}
						set	
						{
							methodStreaming = value;
						}
					}

					public string RateQuality
					{
						get
						{
							return rateQuality;
						}
						set	
						{
							rateQuality = value;
						}
					}
				}

				public class SubmitAnalysisJob_PropertiesControl
				{

					private string deinterlace;

					private SubmitAnalysisJob_Crop crop;

					public string Deinterlace
					{
						get
						{
							return deinterlace;
						}
						set	
						{
							deinterlace = value;
						}
					}

					public SubmitAnalysisJob_Crop Crop
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

					public class SubmitAnalysisJob_Crop
					{

						private string top;

						private string width;

						private string height;

						private string left;

						private string mode;

						public string Top
						{
							get
							{
								return top;
							}
							set	
							{
								top = value;
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

						public string Left
						{
							get
							{
								return left;
							}
							set	
							{
								left = value;
							}
						}

						public string Mode
						{
							get
							{
								return mode;
							}
							set	
							{
								mode = value;
							}
						}
					}
				}
			}

			public class SubmitAnalysisJob_MNSMessageResult
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

			public class SubmitAnalysisJob_InputFile
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
	}
}
