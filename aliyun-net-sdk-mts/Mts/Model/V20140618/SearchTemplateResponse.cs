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
	public class SearchTemplateResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<SearchTemplate_Template> templateList;

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

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<SearchTemplate_Template> TemplateList
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

		public class SearchTemplate_Template
		{

			private string id;

			private string name;

			private string state;

			private SearchTemplate_Container container;

			private SearchTemplate_Video video;

			private SearchTemplate_Audio audio;

			private SearchTemplate_TransConfig transConfig;

			private SearchTemplate_MuxConfig muxConfig;

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

			public SearchTemplate_Container Container
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

			public SearchTemplate_Video Video
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

			public SearchTemplate_Audio Audio
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

			public SearchTemplate_TransConfig TransConfig
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

			public SearchTemplate_MuxConfig MuxConfig
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

			public class SearchTemplate_Container
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

			public class SearchTemplate_Video
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

				private string _remove;

				private string crop;

				private string pad;

				private string maxFps;

				private SearchTemplate_BitrateBnd bitrateBnd;

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

				public SearchTemplate_BitrateBnd BitrateBnd
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

				public class SearchTemplate_BitrateBnd
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

			public class SearchTemplate_Audio
			{

				private string codec;

				private string profile;

				private string samplerate;

				private string bitrate;

				private string channels;

				private string qscale;

				private string _remove;

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
			}

			public class SearchTemplate_TransConfig
			{

				private string transMode;

				private string isCheckReso;

				private string isCheckResoFail;

				private string isCheckVideoBitrate;

				private string isCheckAudioBitrate;

				private string adjDarMethod;

				private string isCheckVideoBitrateFail;

				private string isCheckAudioBitrateFail;

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
			}

			public class SearchTemplate_MuxConfig
			{

				private SearchTemplate_Segment segment;

				private SearchTemplate_Gif gif;

				public SearchTemplate_Segment Segment
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

				public SearchTemplate_Gif Gif
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

				public class SearchTemplate_Segment
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

				public class SearchTemplate_Gif
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
		}
	}
}