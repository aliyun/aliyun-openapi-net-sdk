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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeStudioLayoutsResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private List<DescribeStudioLayouts_StudioLayout> studioLayouts;

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

			private List<DescribeStudioLayouts_ScreenInputConfig> screenInputConfigList;

			private List<DescribeStudioLayouts_MediaInputConfig> mediaInputConfigList;

			private List<DescribeStudioLayouts_LayerOrderConfig> layerOrderConfigList;

			private DescribeStudioLayouts_CommonConfig commonConfig;

			private DescribeStudioLayouts_BgImageConfig bgImageConfig;

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

				private string id;

				private int? index;

				private string channelId;

				private string videoResourceId;

				private string color;

				private string positionX;

				private string positionY;

				private float? heightNormalized;

				private int? portraitType;

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
			}

			public class DescribeStudioLayouts_MediaInputConfig
			{

				private string id;

				private int? index;

				private string channelId;

				private string videoResourceId;

				private string imageMaterialId;

				private string fillMode;

				private string positionRefer;

				private float? widthNormalized;

				private float? heightNormalized;

				private List<string> positionNormalized;

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

				private string id;

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

			public class DescribeStudioLayouts_CommonConfig
			{

				private string videoResourceId;

				private string channelId;

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
			}

			public class DescribeStudioLayouts_BgImageConfig
			{

				private string id;

				private string materialId;

				private string imageUrl;

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
			}
		}
	}
}
