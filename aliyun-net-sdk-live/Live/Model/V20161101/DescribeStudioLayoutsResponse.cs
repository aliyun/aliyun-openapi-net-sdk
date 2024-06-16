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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeStudioLayoutsResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private List<DescribeStudioLayouts_StudioLayout> studioLayouts;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Total")]
		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		[JsonProperty(PropertyName = "StudioLayouts")]
		public List<DescribeStudioLayouts_StudioLayout> StudioLayouts
		{
			get
			{
				return studioLayouts;
			}
			set	
			{
				studioLayouts = value;
			}
		}

		public class DescribeStudioLayouts_StudioLayout
		{

			private string layoutId;

			private string layoutName;

			private string layoutType;

			private List<DescribeStudioLayouts_LayerOrderConfig> layerOrderConfigList;

			private List<DescribeStudioLayouts_MediaInputConfig> mediaInputConfigList;

			private List<DescribeStudioLayouts_ScreenInputConfig> screenInputConfigList;

			private DescribeStudioLayouts_BgImageConfig bgImageConfig;

			private DescribeStudioLayouts_CommonConfig commonConfig;

			[JsonProperty(PropertyName = "LayoutId")]
			public string LayoutId
			{
				get
				{
					return layoutId;
				}
				set	
				{
					layoutId = value;
				}
			}

			[JsonProperty(PropertyName = "LayoutName")]
			public string LayoutName
			{
				get
				{
					return layoutName;
				}
				set	
				{
					layoutName = value;
				}
			}

			[JsonProperty(PropertyName = "LayoutType")]
			public string LayoutType
			{
				get
				{
					return layoutType;
				}
				set	
				{
					layoutType = value;
				}
			}

			[JsonProperty(PropertyName = "LayerOrderConfigList")]
			public List<DescribeStudioLayouts_LayerOrderConfig> LayerOrderConfigList
			{
				get
				{
					return layerOrderConfigList;
				}
				set	
				{
					layerOrderConfigList = value;
				}
			}

			[JsonProperty(PropertyName = "MediaInputConfigList")]
			public List<DescribeStudioLayouts_MediaInputConfig> MediaInputConfigList
			{
				get
				{
					return mediaInputConfigList;
				}
				set	
				{
					mediaInputConfigList = value;
				}
			}

			[JsonProperty(PropertyName = "ScreenInputConfigList")]
			public List<DescribeStudioLayouts_ScreenInputConfig> ScreenInputConfigList
			{
				get
				{
					return screenInputConfigList;
				}
				set	
				{
					screenInputConfigList = value;
				}
			}

			[JsonProperty(PropertyName = "BgImageConfig")]
			public DescribeStudioLayouts_BgImageConfig BgImageConfig
			{
				get
				{
					return bgImageConfig;
				}
				set	
				{
					bgImageConfig = value;
				}
			}

			[JsonProperty(PropertyName = "CommonConfig")]
			public DescribeStudioLayouts_CommonConfig CommonConfig
			{
				get
				{
					return commonConfig;
				}
				set	
				{
					commonConfig = value;
				}
			}

			public class DescribeStudioLayouts_LayerOrderConfig
			{

				private string id;

				private string type;

				[JsonProperty(PropertyName = "Id")]
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

				[JsonProperty(PropertyName = "Type")]
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

			public class DescribeStudioLayouts_MediaInputConfig
			{

				private string channelId;

				private string fillMode;

				private float? heightNormalized;

				private string id;

				private string imageMaterialId;

				private int? index;

				private string positionRefer;

				private string videoResourceId;

				private float? widthNormalized;

				private List<string> positionNormalized;

				[JsonProperty(PropertyName = "ChannelId")]
				public string ChannelId
				{
					get
					{
						return channelId;
					}
					set	
					{
						channelId = value;
					}
				}

				[JsonProperty(PropertyName = "FillMode")]
				public string FillMode
				{
					get
					{
						return fillMode;
					}
					set	
					{
						fillMode = value;
					}
				}

				[JsonProperty(PropertyName = "HeightNormalized")]
				public float? HeightNormalized
				{
					get
					{
						return heightNormalized;
					}
					set	
					{
						heightNormalized = value;
					}
				}

				[JsonProperty(PropertyName = "Id")]
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

				[JsonProperty(PropertyName = "ImageMaterialId")]
				public string ImageMaterialId
				{
					get
					{
						return imageMaterialId;
					}
					set	
					{
						imageMaterialId = value;
					}
				}

				[JsonProperty(PropertyName = "Index")]
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

				[JsonProperty(PropertyName = "PositionRefer")]
				public string PositionRefer
				{
					get
					{
						return positionRefer;
					}
					set	
					{
						positionRefer = value;
					}
				}

				[JsonProperty(PropertyName = "VideoResourceId")]
				public string VideoResourceId
				{
					get
					{
						return videoResourceId;
					}
					set	
					{
						videoResourceId = value;
					}
				}

				[JsonProperty(PropertyName = "WidthNormalized")]
				public float? WidthNormalized
				{
					get
					{
						return widthNormalized;
					}
					set	
					{
						widthNormalized = value;
					}
				}

				[JsonProperty(PropertyName = "PositionNormalized")]
				public List<string> PositionNormalized
				{
					get
					{
						return positionNormalized;
					}
					set	
					{
						positionNormalized = value;
					}
				}
			}

			public class DescribeStudioLayouts_ScreenInputConfig
			{

				private string channelId;

				private string color;

				private float? heightNormalized;

				private string id;

				private int? index;

				private bool? onlyAudio;

				private int? portraitType;

				private string positionX;

				private string positionY;

				private string videoResourceId;

				private DescribeStudioLayouts_AudioConfig audioConfig;

				[JsonProperty(PropertyName = "ChannelId")]
				public string ChannelId
				{
					get
					{
						return channelId;
					}
					set	
					{
						channelId = value;
					}
				}

				[JsonProperty(PropertyName = "Color")]
				public string Color
				{
					get
					{
						return color;
					}
					set	
					{
						color = value;
					}
				}

				[JsonProperty(PropertyName = "HeightNormalized")]
				public float? HeightNormalized
				{
					get
					{
						return heightNormalized;
					}
					set	
					{
						heightNormalized = value;
					}
				}

				[JsonProperty(PropertyName = "Id")]
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

				[JsonProperty(PropertyName = "Index")]
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

				[JsonProperty(PropertyName = "OnlyAudio")]
				public bool? OnlyAudio
				{
					get
					{
						return onlyAudio;
					}
					set	
					{
						onlyAudio = value;
					}
				}

				[JsonProperty(PropertyName = "PortraitType")]
				public int? PortraitType
				{
					get
					{
						return portraitType;
					}
					set	
					{
						portraitType = value;
					}
				}

				[JsonProperty(PropertyName = "PositionX")]
				public string PositionX
				{
					get
					{
						return positionX;
					}
					set	
					{
						positionX = value;
					}
				}

				[JsonProperty(PropertyName = "PositionY")]
				public string PositionY
				{
					get
					{
						return positionY;
					}
					set	
					{
						positionY = value;
					}
				}

				[JsonProperty(PropertyName = "VideoResourceId")]
				public string VideoResourceId
				{
					get
					{
						return videoResourceId;
					}
					set	
					{
						videoResourceId = value;
					}
				}

				[JsonProperty(PropertyName = "AudioConfig")]
				public DescribeStudioLayouts_AudioConfig AudioConfig
				{
					get
					{
						return audioConfig;
					}
					set	
					{
						audioConfig = value;
					}
				}

				public class DescribeStudioLayouts_AudioConfig
				{

					private string validChannel;

					private float? volumeRate;

					[JsonProperty(PropertyName = "ValidChannel")]
					public string ValidChannel
					{
						get
						{
							return validChannel;
						}
						set	
						{
							validChannel = value;
						}
					}

					[JsonProperty(PropertyName = "VolumeRate")]
					public float? VolumeRate
					{
						get
						{
							return volumeRate;
						}
						set	
						{
							volumeRate = value;
						}
					}
				}
			}

			public class DescribeStudioLayouts_BgImageConfig
			{

				private string id;

				private string imageUrl;

				private string locationId;

				private string materialId;

				[JsonProperty(PropertyName = "Id")]
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

				[JsonProperty(PropertyName = "ImageUrl")]
				public string ImageUrl
				{
					get
					{
						return imageUrl;
					}
					set	
					{
						imageUrl = value;
					}
				}

				[JsonProperty(PropertyName = "LocationId")]
				public string LocationId
				{
					get
					{
						return locationId;
					}
					set	
					{
						locationId = value;
					}
				}

				[JsonProperty(PropertyName = "MaterialId")]
				public string MaterialId
				{
					get
					{
						return materialId;
					}
					set	
					{
						materialId = value;
					}
				}
			}

			public class DescribeStudioLayouts_CommonConfig
			{

				private string channelId;

				private string videoResourceId;

				[JsonProperty(PropertyName = "ChannelId")]
				public string ChannelId
				{
					get
					{
						return channelId;
					}
					set	
					{
						channelId = value;
					}
				}

				[JsonProperty(PropertyName = "VideoResourceId")]
				public string VideoResourceId
				{
					get
					{
						return videoResourceId;
					}
					set	
					{
						videoResourceId = value;
					}
				}
			}
		}
	}
}
