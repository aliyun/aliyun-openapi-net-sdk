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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeOssIncrementCheckSettingResponse : AcsResponse
	{

		private string callbackName;

		private long? imageScanLimit;

		private long? videoScanLimit;

		private bool? audioAutoFreezeOpened;

		private int? videoMaxSize;

		private bool? imageEnableLimit;

		private string bizType;

		private string endTime;

		private bool? imageAutoFreezeOpened;

		private int? videoMaxFrames;

		private string startTime;

		private string callbackId;

		private bool? scanImageNoFileType;

		private string autoFreezeType;

		private string requestId;

		private bool? videoAutoFreezeOpened;

		private int? videoFrameInterval;

		private long? audioScanLimit;

		private int? audioMaxSize;

		private List<DescribeOssIncrementCheckSetting_BucketConfig> bucketConfigList;

		private List<string> audioSceneList;

		private List<string> videoAutoFreezeSceneList;

		private List<string> videoSceneList;

		private List<string> imageSceneList;

		private DescribeOssIncrementCheckSetting_ImageAutoFreeze imageAutoFreeze;

		private DescribeOssIncrementCheckSetting_AudioAntispamFreezeConfig audioAntispamFreezeConfig;

		private DescribeOssIncrementCheckSetting_BizTypeTemplate bizTypeTemplate;

		private DescribeOssIncrementCheckSetting_ImagePornFreezeConfig imagePornFreezeConfig;

		private DescribeOssIncrementCheckSetting_ImageTerrorismFreezeConfig imageTerrorismFreezeConfig;

		private DescribeOssIncrementCheckSetting_ImageAdFreezeConfig imageAdFreezeConfig;

		private DescribeOssIncrementCheckSetting_ImageLiveFreezeConfig imageLiveFreezeConfig;

		private DescribeOssIncrementCheckSetting_VideoPornFreezeConfig videoPornFreezeConfig;

		private DescribeOssIncrementCheckSetting_VideoTerrorismFreezeConfig videoTerrorismFreezeConfig;

		private DescribeOssIncrementCheckSetting_VideoAdFreezeConfig videoAdFreezeConfig;

		private DescribeOssIncrementCheckSetting_VideoLiveFreezeConfig videoLiveFreezeConfig;

		private DescribeOssIncrementCheckSetting_VideoVoiceAntispamFreezeConfig videoVoiceAntispamFreezeConfig;

		public string CallbackName
		{
			get
			{
				return callbackName;
			}
			set	
			{
				callbackName = value;
			}
		}

		public long? ImageScanLimit
		{
			get
			{
				return imageScanLimit;
			}
			set	
			{
				imageScanLimit = value;
			}
		}

		public long? VideoScanLimit
		{
			get
			{
				return videoScanLimit;
			}
			set	
			{
				videoScanLimit = value;
			}
		}

		public bool? AudioAutoFreezeOpened
		{
			get
			{
				return audioAutoFreezeOpened;
			}
			set	
			{
				audioAutoFreezeOpened = value;
			}
		}

		public int? VideoMaxSize
		{
			get
			{
				return videoMaxSize;
			}
			set	
			{
				videoMaxSize = value;
			}
		}

		public bool? ImageEnableLimit
		{
			get
			{
				return imageEnableLimit;
			}
			set	
			{
				imageEnableLimit = value;
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public bool? ImageAutoFreezeOpened
		{
			get
			{
				return imageAutoFreezeOpened;
			}
			set	
			{
				imageAutoFreezeOpened = value;
			}
		}

		public int? VideoMaxFrames
		{
			get
			{
				return videoMaxFrames;
			}
			set	
			{
				videoMaxFrames = value;
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

		public string CallbackId
		{
			get
			{
				return callbackId;
			}
			set	
			{
				callbackId = value;
			}
		}

		public bool? ScanImageNoFileType
		{
			get
			{
				return scanImageNoFileType;
			}
			set	
			{
				scanImageNoFileType = value;
			}
		}

		public string AutoFreezeType
		{
			get
			{
				return autoFreezeType;
			}
			set	
			{
				autoFreezeType = value;
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

		public bool? VideoAutoFreezeOpened
		{
			get
			{
				return videoAutoFreezeOpened;
			}
			set	
			{
				videoAutoFreezeOpened = value;
			}
		}

		public int? VideoFrameInterval
		{
			get
			{
				return videoFrameInterval;
			}
			set	
			{
				videoFrameInterval = value;
			}
		}

		public long? AudioScanLimit
		{
			get
			{
				return audioScanLimit;
			}
			set	
			{
				audioScanLimit = value;
			}
		}

		public int? AudioMaxSize
		{
			get
			{
				return audioMaxSize;
			}
			set	
			{
				audioMaxSize = value;
			}
		}

		public List<DescribeOssIncrementCheckSetting_BucketConfig> BucketConfigList
		{
			get
			{
				return bucketConfigList;
			}
			set	
			{
				bucketConfigList = value;
			}
		}

		public List<string> AudioSceneList
		{
			get
			{
				return audioSceneList;
			}
			set	
			{
				audioSceneList = value;
			}
		}

		public List<string> VideoAutoFreezeSceneList
		{
			get
			{
				return videoAutoFreezeSceneList;
			}
			set	
			{
				videoAutoFreezeSceneList = value;
			}
		}

		public List<string> VideoSceneList
		{
			get
			{
				return videoSceneList;
			}
			set	
			{
				videoSceneList = value;
			}
		}

		public List<string> ImageSceneList
		{
			get
			{
				return imageSceneList;
			}
			set	
			{
				imageSceneList = value;
			}
		}

		public DescribeOssIncrementCheckSetting_ImageAutoFreeze ImageAutoFreeze
		{
			get
			{
				return imageAutoFreeze;
			}
			set	
			{
				imageAutoFreeze = value;
			}
		}

		public DescribeOssIncrementCheckSetting_AudioAntispamFreezeConfig AudioAntispamFreezeConfig
		{
			get
			{
				return audioAntispamFreezeConfig;
			}
			set	
			{
				audioAntispamFreezeConfig = value;
			}
		}

		public DescribeOssIncrementCheckSetting_BizTypeTemplate BizTypeTemplate
		{
			get
			{
				return bizTypeTemplate;
			}
			set	
			{
				bizTypeTemplate = value;
			}
		}

		public DescribeOssIncrementCheckSetting_ImagePornFreezeConfig ImagePornFreezeConfig
		{
			get
			{
				return imagePornFreezeConfig;
			}
			set	
			{
				imagePornFreezeConfig = value;
			}
		}

		public DescribeOssIncrementCheckSetting_ImageTerrorismFreezeConfig ImageTerrorismFreezeConfig
		{
			get
			{
				return imageTerrorismFreezeConfig;
			}
			set	
			{
				imageTerrorismFreezeConfig = value;
			}
		}

		public DescribeOssIncrementCheckSetting_ImageAdFreezeConfig ImageAdFreezeConfig
		{
			get
			{
				return imageAdFreezeConfig;
			}
			set	
			{
				imageAdFreezeConfig = value;
			}
		}

		public DescribeOssIncrementCheckSetting_ImageLiveFreezeConfig ImageLiveFreezeConfig
		{
			get
			{
				return imageLiveFreezeConfig;
			}
			set	
			{
				imageLiveFreezeConfig = value;
			}
		}

		public DescribeOssIncrementCheckSetting_VideoPornFreezeConfig VideoPornFreezeConfig
		{
			get
			{
				return videoPornFreezeConfig;
			}
			set	
			{
				videoPornFreezeConfig = value;
			}
		}

		public DescribeOssIncrementCheckSetting_VideoTerrorismFreezeConfig VideoTerrorismFreezeConfig
		{
			get
			{
				return videoTerrorismFreezeConfig;
			}
			set	
			{
				videoTerrorismFreezeConfig = value;
			}
		}

		public DescribeOssIncrementCheckSetting_VideoAdFreezeConfig VideoAdFreezeConfig
		{
			get
			{
				return videoAdFreezeConfig;
			}
			set	
			{
				videoAdFreezeConfig = value;
			}
		}

		public DescribeOssIncrementCheckSetting_VideoLiveFreezeConfig VideoLiveFreezeConfig
		{
			get
			{
				return videoLiveFreezeConfig;
			}
			set	
			{
				videoLiveFreezeConfig = value;
			}
		}

		public DescribeOssIncrementCheckSetting_VideoVoiceAntispamFreezeConfig VideoVoiceAntispamFreezeConfig
		{
			get
			{
				return videoVoiceAntispamFreezeConfig;
			}
			set	
			{
				videoVoiceAntispamFreezeConfig = value;
			}
		}

		public class DescribeOssIncrementCheckSetting_BucketConfig
		{

			private string type;

			private bool? selected;

			private string bucket;

			private List<string> prefixes;

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

			public bool? Selected
			{
				get
				{
					return selected;
				}
				set	
				{
					selected = value;
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

			public List<string> Prefixes
			{
				get
				{
					return prefixes;
				}
				set	
				{
					prefixes = value;
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_ImageAutoFreeze
		{

			private string live;

			private string porn;

			private string ad;

			private string terrorism;

			private bool? enabled;

			public string Live
			{
				get
				{
					return live;
				}
				set	
				{
					live = value;
				}
			}

			public string Porn
			{
				get
				{
					return porn;
				}
				set	
				{
					porn = value;
				}
			}

			public string Ad
			{
				get
				{
					return ad;
				}
				set	
				{
					ad = value;
				}
			}

			public string Terrorism
			{
				get
				{
					return terrorism;
				}
				set	
				{
					terrorism = value;
				}
			}

			public bool? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_AudioAntispamFreezeConfig
		{

			private string type;

			private string _value;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_BizTypeTemplate
		{

			private string name;

			private string description;

			private string bizType;

			private int? includeChannel;

			private DescribeOssIncrementCheckSetting_ImageConfig imageConfig;

			private DescribeOssIncrementCheckSetting_VideoConfig videoConfig;

			private DescribeOssIncrementCheckSetting_VoiceConfig voiceConfig;

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

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public int? IncludeChannel
			{
				get
				{
					return includeChannel;
				}
				set	
				{
					includeChannel = value;
				}
			}

			public DescribeOssIncrementCheckSetting_ImageConfig ImageConfig
			{
				get
				{
					return imageConfig;
				}
				set	
				{
					imageConfig = value;
				}
			}

			public DescribeOssIncrementCheckSetting_VideoConfig VideoConfig
			{
				get
				{
					return videoConfig;
				}
				set	
				{
					videoConfig = value;
				}
			}

			public DescribeOssIncrementCheckSetting_VoiceConfig VoiceConfig
			{
				get
				{
					return voiceConfig;
				}
				set	
				{
					voiceConfig = value;
				}
			}

			public class DescribeOssIncrementCheckSetting_ImageConfig
			{

				private DescribeOssIncrementCheckSetting_Terrorism terrorism;

				private DescribeOssIncrementCheckSetting_Porn porn;

				private DescribeOssIncrementCheckSetting_Ad ad;

				private DescribeOssIncrementCheckSetting_Live live;

				public DescribeOssIncrementCheckSetting_Terrorism Terrorism
				{
					get
					{
						return terrorism;
					}
					set	
					{
						terrorism = value;
					}
				}

				public DescribeOssIncrementCheckSetting_Porn Porn
				{
					get
					{
						return porn;
					}
					set	
					{
						porn = value;
					}
				}

				public DescribeOssIncrementCheckSetting_Ad Ad
				{
					get
					{
						return ad;
					}
					set	
					{
						ad = value;
					}
				}

				public DescribeOssIncrementCheckSetting_Live Live
				{
					get
					{
						return live;
					}
					set	
					{
						live = value;
					}
				}

				public class DescribeOssIncrementCheckSetting_Terrorism
				{

					private List<string> categories;

					public List<string> Categories
					{
						get
						{
							return categories;
						}
						set	
						{
							categories = value;
						}
					}
				}

				public class DescribeOssIncrementCheckSetting_Porn
				{

					private List<string> categories1;

					public List<string> Categories1
					{
						get
						{
							return categories1;
						}
						set	
						{
							categories1 = value;
						}
					}
				}

				public class DescribeOssIncrementCheckSetting_Ad
				{

					private List<string> categories2;

					public List<string> Categories2
					{
						get
						{
							return categories2;
						}
						set	
						{
							categories2 = value;
						}
					}
				}

				public class DescribeOssIncrementCheckSetting_Live
				{

					private List<string> categories3;

					public List<string> Categories3
					{
						get
						{
							return categories3;
						}
						set	
						{
							categories3 = value;
						}
					}
				}
			}

			public class DescribeOssIncrementCheckSetting_VideoConfig
			{

				private DescribeOssIncrementCheckSetting_Terrorism4 terrorism4;

				private DescribeOssIncrementCheckSetting_Porn5 porn5;

				private DescribeOssIncrementCheckSetting_Ad6 ad6;

				private DescribeOssIncrementCheckSetting_Live7 live7;

				public DescribeOssIncrementCheckSetting_Terrorism4 Terrorism4
				{
					get
					{
						return terrorism4;
					}
					set	
					{
						terrorism4 = value;
					}
				}

				public DescribeOssIncrementCheckSetting_Porn5 Porn5
				{
					get
					{
						return porn5;
					}
					set	
					{
						porn5 = value;
					}
				}

				public DescribeOssIncrementCheckSetting_Ad6 Ad6
				{
					get
					{
						return ad6;
					}
					set	
					{
						ad6 = value;
					}
				}

				public DescribeOssIncrementCheckSetting_Live7 Live7
				{
					get
					{
						return live7;
					}
					set	
					{
						live7 = value;
					}
				}

				public class DescribeOssIncrementCheckSetting_Terrorism4
				{

					private List<string> categories8;

					public List<string> Categories8
					{
						get
						{
							return categories8;
						}
						set	
						{
							categories8 = value;
						}
					}
				}

				public class DescribeOssIncrementCheckSetting_Porn5
				{

					private List<string> categories9;

					public List<string> Categories9
					{
						get
						{
							return categories9;
						}
						set	
						{
							categories9 = value;
						}
					}
				}

				public class DescribeOssIncrementCheckSetting_Ad6
				{

					private List<string> categories10;

					public List<string> Categories10
					{
						get
						{
							return categories10;
						}
						set	
						{
							categories10 = value;
						}
					}
				}

				public class DescribeOssIncrementCheckSetting_Live7
				{

					private List<string> categories11;

					public List<string> Categories11
					{
						get
						{
							return categories11;
						}
						set	
						{
							categories11 = value;
						}
					}
				}
			}

			public class DescribeOssIncrementCheckSetting_VoiceConfig
			{

				private DescribeOssIncrementCheckSetting_Antispam antispam;

				public DescribeOssIncrementCheckSetting_Antispam Antispam
				{
					get
					{
						return antispam;
					}
					set	
					{
						antispam = value;
					}
				}

				public class DescribeOssIncrementCheckSetting_Antispam
				{

					private List<string> categories12;

					public List<string> Categories12
					{
						get
						{
							return categories12;
						}
						set	
						{
							categories12 = value;
						}
					}
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_ImagePornFreezeConfig
		{

			private string type;

			private string _value;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_ImageTerrorismFreezeConfig
		{

			private string type;

			private string _value;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_ImageAdFreezeConfig
		{

			private string type;

			private string _value;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_ImageLiveFreezeConfig
		{

			private string type;

			private string _value;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_VideoPornFreezeConfig
		{

			private string type;

			private string _value;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_VideoTerrorismFreezeConfig
		{

			private string type;

			private string _value;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_VideoAdFreezeConfig
		{

			private string type;

			private string _value;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_VideoLiveFreezeConfig
		{

			private string type;

			private string _value;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeOssIncrementCheckSetting_VideoVoiceAntispamFreezeConfig
		{

			private string type;

			private string _value;

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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}
	}
}
