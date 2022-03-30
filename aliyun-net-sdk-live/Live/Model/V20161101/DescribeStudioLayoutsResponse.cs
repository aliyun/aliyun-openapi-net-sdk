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

		private int? total;

		private string requestId;

		private List<DescribeStudioLayouts_StudioLayout> studioLayouts;

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

			private string layoutType;

			private string layoutId;

			private string layoutName;

			private List<DescribeStudioLayouts_ScreenInputConfig> screenInputConfigList;

			private List<DescribeStudioLayouts_MediaInputConfig> mediaInputConfigList;

			private List<DescribeStudioLayouts_LayerOrderConfig> layerOrderConfigList;

			private DescribeStudioLayouts_CommonConfig commonConfig;

			private DescribeStudioLayouts_BgImageConfig bgImageConfig;

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

			public class DescribeStudioLayouts_ScreenInputConfig
			{

				private int? portraitType;

				private int? index;

				private string positionX;

				private string color;

				private bool? onlyAudio;

				private float? heightNormalized;

				private string positionY;

				private string channelId;

				private string videoResourceId;

				private string id;

				private DescribeStudioLayouts_AudioConfig audioConfig;

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

					private float? volumeRate;

					private string validChannel;

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
				}
			}

			public class DescribeStudioLayouts_MediaInputConfig
			{

				private int? index;

				private float? heightNormalized;

				private string fillMode;

				private string positionRefer;

				private string channelId;

				private string videoResourceId;

				private float? widthNormalized;

				private string imageMaterialId;

				private string id;

				private List<string> positionNormalized;

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

			public class DescribeStudioLayouts_LayerOrderConfig
			{

				private string type;

				private string id;

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
			}

			public class DescribeStudioLayouts_CommonConfig
			{

				private string channelId;

				private string videoResourceId;

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

			public class DescribeStudioLayouts_BgImageConfig
			{

				private string materialId;

				private string imageUrl;

				private string id;

				private string locationId;

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
			}
		}
	}
}
