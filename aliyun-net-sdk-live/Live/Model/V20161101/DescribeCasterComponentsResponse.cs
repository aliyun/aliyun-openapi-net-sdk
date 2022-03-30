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

				private int? transparency;

				private float? widthNormalized;

				private float? heightNormalized;

				private string positionRefer;

				private List<string> positionNormalizeds;

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

			public class DescribeCasterComponents_TextLayerContent
			{

				private string color;

				private string borderColor;

				private float? borderWidthNormalized;

				private string text;

				private float? sizeNormalized;

				private string fontName;

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
