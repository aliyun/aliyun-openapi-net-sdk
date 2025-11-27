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
	public class QueryTemplateListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryTemplateList_Template> templateList;

		private List<string> nonExistTids;

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

		public List<QueryTemplateList_Template> TemplateList
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

		public List<string> NonExistTids
		{
			get
			{
				return nonExistTids;
			}
			set	
			{
				nonExistTids = value;
			}
		}

		public class QueryTemplateList_Template
		{

			private string state;

			private string name;

			private string id;

			private string creationTime;

			private QueryTemplateList_Video video;

			private QueryTemplateList_TransConfig transConfig;

			private QueryTemplateList_MuxConfig muxConfig;

			private QueryTemplateList_Audio audio;

			private QueryTemplateList_Container container;

			private QueryTemplateList_FrontendHint frontendHint;

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

			public QueryTemplateList_Video Video
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

			public QueryTemplateList_TransConfig TransConfig
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

			public QueryTemplateList_MuxConfig MuxConfig
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

			public QueryTemplateList_Audio Audio
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

			public QueryTemplateList_Container Container
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

			public QueryTemplateList_FrontendHint FrontendHint
			{
				get
				{
					return frontendHint;
				}
				set	
				{
					frontendHint = value;
				}
			}

			public class QueryTemplateList_Video
			{

				private string bufsize;

				private string longShortMode;

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

				private string _remove;

				private string gop;

				private string width;

				private string fps;

				private string preset;

				private string scanMode;

				private string resoPriority;

				private string hdr2sdr;

				private QueryTemplateList_BitrateBnd bitrateBnd;

				private QueryTemplateList_NarrowBand narrowBand;

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

				public string LongShortMode
				{
					get
					{
						return longShortMode;
					}
					set	
					{
						longShortMode = value;
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

				public string _Remove
				{
					get
					{
						return _remove;
					}
					set	
					{
						_remove = value;
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

				public string Hdr2sdr
				{
					get
					{
						return hdr2sdr;
					}
					set	
					{
						hdr2sdr = value;
					}
				}

				public QueryTemplateList_BitrateBnd BitrateBnd
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

				public QueryTemplateList_NarrowBand NarrowBand
				{
					get
					{
						return narrowBand;
					}
					set	
					{
						narrowBand = value;
					}
				}

				public class QueryTemplateList_BitrateBnd
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

				public class QueryTemplateList_NarrowBand
				{

					private string version;

					private float? abrmax;

					private float? maxAbrRatio;

					public string Version
					{
						get
						{
							return version;
						}
						set	
						{
							version = value;
						}
					}

					public float? Abrmax
					{
						get
						{
							return abrmax;
						}
						set	
						{
							abrmax = value;
						}
					}

					public float? MaxAbrRatio
					{
						get
						{
							return maxAbrRatio;
						}
						set	
						{
							maxAbrRatio = value;
						}
					}
				}
			}

			public class QueryTemplateList_TransConfig
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

			public class QueryTemplateList_MuxConfig
			{

				private QueryTemplateList_Webp webp;

				private QueryTemplateList_Gif gif;

				private QueryTemplateList_Segment segment;

				public QueryTemplateList_Webp Webp
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

				public QueryTemplateList_Gif Gif
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

				public QueryTemplateList_Segment Segment
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

				public class QueryTemplateList_Webp
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

				public class QueryTemplateList_Gif
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

				public class QueryTemplateList_Segment
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

			public class QueryTemplateList_Audio
			{

				private string profile;

				private string _remove;

				private string codec;

				private string samplerate;

				private string qscale;

				private string channels;

				private string bitrate;

				private QueryTemplateList_Volume volume;

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

				public string _Remove
				{
					get
					{
						return _remove;
					}
					set	
					{
						_remove = value;
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

				public QueryTemplateList_Volume Volume
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

				public class QueryTemplateList_Volume
				{

					private string method;

					private string truePeak;

					private string integratedLoudnessTarget;

					private string loudnessRangeTarget;

					private string level;

					private string peakLevel;

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

					public string TruePeak
					{
						get
						{
							return truePeak;
						}
						set	
						{
							truePeak = value;
						}
					}

					public string IntegratedLoudnessTarget
					{
						get
						{
							return integratedLoudnessTarget;
						}
						set	
						{
							integratedLoudnessTarget = value;
						}
					}

					public string LoudnessRangeTarget
					{
						get
						{
							return loudnessRangeTarget;
						}
						set	
						{
							loudnessRangeTarget = value;
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

					public string PeakLevel
					{
						get
						{
							return peakLevel;
						}
						set	
						{
							peakLevel = value;
						}
					}
				}
			}

			public class QueryTemplateList_Container
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

			public class QueryTemplateList_FrontendHint
			{

				private string transcodeType;

				private string bitrateControlType;

				private string source;

				private bool? isDynamic;

				private bool? hasOldHdr2Sdr;

				public string TranscodeType
				{
					get
					{
						return transcodeType;
					}
					set	
					{
						transcodeType = value;
					}
				}

				public string BitrateControlType
				{
					get
					{
						return bitrateControlType;
					}
					set	
					{
						bitrateControlType = value;
					}
				}

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

				public bool? IsDynamic
				{
					get
					{
						return isDynamic;
					}
					set	
					{
						isDynamic = value;
					}
				}

				public bool? HasOldHdr2Sdr
				{
					get
					{
						return hasOldHdr2Sdr;
					}
					set	
					{
						hasOldHdr2Sdr = value;
					}
				}
			}
		}
	}
}
