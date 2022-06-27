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
	public class DescribeCasterComponentsResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private List<DescribeCasterComponents_Component> components;

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

			private string componentId;

			private string componentName;

			private string locationId;

			private string componentType;

			private string effect;

			private DescribeCasterComponents_ComponentLayer componentLayer;

			private DescribeCasterComponents_TextLayerContent textLayerContent;

			private DescribeCasterComponents_ImageLayerContent imageLayerContent;

			private DescribeCasterComponents_CaptionLayerContent captionLayerContent;

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

				private float? heightNormalized;

				private float? widthNormalized;

				private string positionRefer;

				private int? transparency;

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

				private string text;

				private string color;

				private string fontName;

				private float? sizeNormalized;

				private float? borderWidthNormalized;

				private string borderColor;

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
			}

			public class DescribeCasterComponents_ImageLayerContent
			{

				private string materialId;

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

				private string locationId;

				private int? ptsOffset;

				private int? wordsCount;

				private string color;

				private string fontName;

				private string sourceLan;

				private string targetLan;

				private bool? showSourceLan;

				private float? sizeNormalized;

				private float? borderWidthNormalized;

				private string borderColor;

				private int? wordCountPerLine;

				private float? wordSpaceNormalized;

				private float? lineSpaceNormalized;

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
			}
		}
	}
}
