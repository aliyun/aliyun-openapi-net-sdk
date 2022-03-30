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
	public class DescribeCasterLayoutsResponse : AcsResponse
	{

		private int? total;

		private string requestId;

		private List<DescribeCasterLayouts_Layout> layouts;

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

			private List<string> mixList;

			private List<string> blendList;

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

			public class DescribeCasterLayouts_VideoLayer
			{

				private float? widthNormalized;

				private int? fixedDelayDuration;

				private float? heightNormalized;

				private string fillMode;

				private string positionRefer;

				private List<string> positionNormalizeds;

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

				public int? FixedDelayDuration
				{
					get
					{
						return fixedDelayDuration;
					}
					set	
					{
						fixedDelayDuration = value;
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

				private int? fixedDelayDuration;

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

				public int? FixedDelayDuration
				{
					get
					{
						return fixedDelayDuration;
					}
					set	
					{
						fixedDelayDuration = value;
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
