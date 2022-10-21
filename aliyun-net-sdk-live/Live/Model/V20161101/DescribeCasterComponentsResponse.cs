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
	public class DescribeCasterComponentsResponse : AcsResponse
	{

		private int? total;

		private string requestId;

		private List<DescribeCasterComponents_Component> components;

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

		[JsonProperty(PropertyName = "Components")]
		public List<DescribeCasterComponents_Component> Components
		{
			get
			{
				return components;
			}
			set	
			{
				components = value;
			}
		}

		public class DescribeCasterComponents_Component
		{

			private string effect;

			private string componentName;

			private string componentId;

			private string componentType;

			private string locationId;

			private DescribeCasterComponents_ComponentLayer componentLayer;

			private DescribeCasterComponents_TextLayerContent textLayerContent;

			private DescribeCasterComponents_ImageLayerContent imageLayerContent;

			private DescribeCasterComponents_CaptionLayerContent captionLayerContent;

			[JsonProperty(PropertyName = "Effect")]
			public string Effect
			{
				get
				{
					return effect;
				}
				set	
				{
					effect = value;
				}
			}

			[JsonProperty(PropertyName = "ComponentName")]
			public string ComponentName
			{
				get
				{
					return componentName;
				}
				set	
				{
					componentName = value;
				}
			}

			[JsonProperty(PropertyName = "ComponentId")]
			public string ComponentId
			{
				get
				{
					return componentId;
				}
				set	
				{
					componentId = value;
				}
			}

			[JsonProperty(PropertyName = "ComponentType")]
			public string ComponentType
			{
				get
				{
					return componentType;
				}
				set	
				{
					componentType = value;
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

			[JsonProperty(PropertyName = "ComponentLayer")]
			public DescribeCasterComponents_ComponentLayer ComponentLayer
			{
				get
				{
					return componentLayer;
				}
				set	
				{
					componentLayer = value;
				}
			}

			[JsonProperty(PropertyName = "TextLayerContent")]
			public DescribeCasterComponents_TextLayerContent TextLayerContent
			{
				get
				{
					return textLayerContent;
				}
				set	
				{
					textLayerContent = value;
				}
			}

			[JsonProperty(PropertyName = "ImageLayerContent")]
			public DescribeCasterComponents_ImageLayerContent ImageLayerContent
			{
				get
				{
					return imageLayerContent;
				}
				set	
				{
					imageLayerContent = value;
				}
			}

			[JsonProperty(PropertyName = "CaptionLayerContent")]
			public DescribeCasterComponents_CaptionLayerContent CaptionLayerContent
			{
				get
				{
					return captionLayerContent;
				}
				set	
				{
					captionLayerContent = value;
				}
			}

			public class DescribeCasterComponents_ComponentLayer
			{

				private int? transparency;

				private float? widthNormalized;

				private float? heightNormalized;

				private string positionRefer;

				private List<string> positionNormalizeds;

				[JsonProperty(PropertyName = "Transparency")]
				public int? Transparency
				{
					get
					{
						return transparency;
					}
					set	
					{
						transparency = value;
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

				[JsonProperty(PropertyName = "PositionNormalizeds")]
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

			public class DescribeCasterComponents_TextLayerContent
			{

				private string color;

				private string borderColor;

				private float? borderWidthNormalized;

				private string text;

				private float? sizeNormalized;

				private string fontName;

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

				[JsonProperty(PropertyName = "BorderColor")]
				public string BorderColor
				{
					get
					{
						return borderColor;
					}
					set	
					{
						borderColor = value;
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

				[JsonProperty(PropertyName = "Text")]
				public string Text
				{
					get
					{
						return text;
					}
					set	
					{
						text = value;
					}
				}

				[JsonProperty(PropertyName = "SizeNormalized")]
				public float? SizeNormalized
				{
					get
					{
						return sizeNormalized;
					}
					set	
					{
						sizeNormalized = value;
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
			}

			public class DescribeCasterComponents_ImageLayerContent
			{

				private string materialId;

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

			public class DescribeCasterComponents_CaptionLayerContent
			{

				private string color;

				private float? wordSpaceNormalized;

				private float? borderWidthNormalized;

				private string sourceLan;

				private int? wordCountPerLine;

				private string targetLan;

				private string borderColor;

				private string locationId;

				private float? lineSpaceNormalized;

				private bool? showSourceLan;

				private float? sizeNormalized;

				private int? wordsCount;

				private string fontName;

				private int? ptsOffset;

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

				[JsonProperty(PropertyName = "WordSpaceNormalized")]
				public float? WordSpaceNormalized
				{
					get
					{
						return wordSpaceNormalized;
					}
					set	
					{
						wordSpaceNormalized = value;
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

				[JsonProperty(PropertyName = "SourceLan")]
				public string SourceLan
				{
					get
					{
						return sourceLan;
					}
					set	
					{
						sourceLan = value;
					}
				}

				[JsonProperty(PropertyName = "WordCountPerLine")]
				public int? WordCountPerLine
				{
					get
					{
						return wordCountPerLine;
					}
					set	
					{
						wordCountPerLine = value;
					}
				}

				[JsonProperty(PropertyName = "TargetLan")]
				public string TargetLan
				{
					get
					{
						return targetLan;
					}
					set	
					{
						targetLan = value;
					}
				}

				[JsonProperty(PropertyName = "BorderColor")]
				public string BorderColor
				{
					get
					{
						return borderColor;
					}
					set	
					{
						borderColor = value;
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

				[JsonProperty(PropertyName = "LineSpaceNormalized")]
				public float? LineSpaceNormalized
				{
					get
					{
						return lineSpaceNormalized;
					}
					set	
					{
						lineSpaceNormalized = value;
					}
				}

				[JsonProperty(PropertyName = "ShowSourceLan")]
				public bool? ShowSourceLan
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

				[JsonProperty(PropertyName = "SizeNormalized")]
				public float? SizeNormalized
				{
					get
					{
						return sizeNormalized;
					}
					set	
					{
						sizeNormalized = value;
					}
				}

				[JsonProperty(PropertyName = "WordsCount")]
				public int? WordsCount
				{
					get
					{
						return wordsCount;
					}
					set	
					{
						wordsCount = value;
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

				[JsonProperty(PropertyName = "PtsOffset")]
				public int? PtsOffset
				{
					get
					{
						return ptsOffset;
					}
					set	
					{
						ptsOffset = value;
					}
				}
			}
		}
	}
}
