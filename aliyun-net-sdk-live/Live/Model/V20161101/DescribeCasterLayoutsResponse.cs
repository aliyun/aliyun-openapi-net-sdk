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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeCasterLayoutsResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private List<DescribeCasterLayouts_Layout> layouts;

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

		public List<DescribeCasterLayouts_Layout> Layouts
		{
			get
			{
				return layouts;
			}
			set	
			{
				layouts = value;
			}
		}

		public class DescribeCasterLayouts_Layout
		{

			private string layoutId;

			private List<DescribeCasterLayouts_VideoLayer> videoLayers;

			private List<DescribeCasterLayouts_AudioLayer> audioLayers;

			private List<string> blendList;

			private List<string> mixList;

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

			public List<DescribeCasterLayouts_VideoLayer> VideoLayers
			{
				get
				{
					return videoLayers;
				}
				set	
				{
					videoLayers = value;
				}
			}

			public List<DescribeCasterLayouts_AudioLayer> AudioLayers
			{
				get
				{
					return audioLayers;
				}
				set	
				{
					audioLayers = value;
				}
			}

			public List<string> BlendList
			{
				get
				{
					return blendList;
				}
				set	
				{
					blendList = value;
				}
			}

			public List<string> MixList
			{
				get
				{
					return mixList;
				}
				set	
				{
					mixList = value;
				}
			}

			public class DescribeCasterLayouts_VideoLayer
			{

				private float? heightNormalized;

				private float? widthNormalized;

				private string positionRefer;

				private List<string> positionNormalizeds;

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

				public List<string> PositionNormalizeds
				{
					get
					{
						return positionNormalizeds;
					}
					set	
					{
						positionNormalizeds = value;
					}
				}
			}

			public class DescribeCasterLayouts_AudioLayer
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
	}
}