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
	public class DescribeLiveAISubtitleResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveAISubtitle_SubtitleConfig> subtitleConfigs;

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

		[JsonProperty(PropertyName = "SubtitleConfigs")]
		public List<DescribeLiveAISubtitle_SubtitleConfig> SubtitleConfigs
		{
			get
			{
				return subtitleConfigs;
			}
			set	
			{
				subtitleConfigs = value;
			}
		}

		public class DescribeLiveAISubtitle_SubtitleConfig
		{

			private string dstLanguage;

			private string srcLanguage;

			private string fontColor;

			private string fontName;

			private int? showSourceLan;

			private int? maxLines;

			private int? wordPerline;

			private string bgColor;

			private float? bgWidthNormalized;

			private float? borderWidthNormalized;

			private string width;

			private string height;

			private string subtitleName;

			private string subtitleId;

			private string fontSizeNormalized;

			private string description;

			private List<string> positionNormalized;

			private List<string> rulesRefer;

			[JsonProperty(PropertyName = "DstLanguage")]
			public string DstLanguage
			{
				get
				{
					return dstLanguage;
				}
				set	
				{
					dstLanguage = value;
				}
			}

			[JsonProperty(PropertyName = "SrcLanguage")]
			public string SrcLanguage
			{
				get
				{
					return srcLanguage;
				}
				set	
				{
					srcLanguage = value;
				}
			}

			[JsonProperty(PropertyName = "FontColor")]
			public string FontColor
			{
				get
				{
					return fontColor;
				}
				set	
				{
					fontColor = value;
				}
			}

			[JsonProperty(PropertyName = "FontName")]
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

			[JsonProperty(PropertyName = "ShowSourceLan")]
			public int? ShowSourceLan
			{
				get
				{
					return showSourceLan;
				}
				set	
				{
					showSourceLan = value;
				}
			}

			[JsonProperty(PropertyName = "MaxLines")]
			public int? MaxLines
			{
				get
				{
					return maxLines;
				}
				set	
				{
					maxLines = value;
				}
			}

			[JsonProperty(PropertyName = "WordPerline")]
			public int? WordPerline
			{
				get
				{
					return wordPerline;
				}
				set	
				{
					wordPerline = value;
				}
			}

			[JsonProperty(PropertyName = "BgColor")]
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

			[JsonProperty(PropertyName = "BgWidthNormalized")]
			public float? BgWidthNormalized
			{
				get
				{
					return bgWidthNormalized;
				}
				set	
				{
					bgWidthNormalized = value;
				}
			}

			[JsonProperty(PropertyName = "BorderWidthNormalized")]
			public float? BorderWidthNormalized
			{
				get
				{
					return borderWidthNormalized;
				}
				set	
				{
					borderWidthNormalized = value;
				}
			}

			[JsonProperty(PropertyName = "Width")]
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

			[JsonProperty(PropertyName = "Height")]
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

			[JsonProperty(PropertyName = "SubtitleName")]
			public string SubtitleName
			{
				get
				{
					return subtitleName;
				}
				set	
				{
					subtitleName = value;
				}
			}

			[JsonProperty(PropertyName = "SubtitleId")]
			public string SubtitleId
			{
				get
				{
					return subtitleId;
				}
				set	
				{
					subtitleId = value;
				}
			}

			[JsonProperty(PropertyName = "FontSizeNormalized")]
			public string FontSizeNormalized
			{
				get
				{
					return fontSizeNormalized;
				}
				set	
				{
					fontSizeNormalized = value;
				}
			}

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "RulesRefer")]
			public List<string> RulesRefer
			{
				get
				{
					return rulesRefer;
				}
				set	
				{
					rulesRefer = value;
				}
			}
		}
	}
}
