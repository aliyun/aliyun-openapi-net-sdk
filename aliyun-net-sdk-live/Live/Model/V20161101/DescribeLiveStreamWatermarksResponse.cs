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
	public class DescribeLiveStreamWatermarksResponse : AcsResponse
	{

		private int? total;

		private string requestId;

		private List<DescribeLiveStreamWatermarks_Watermark> watermarkList;

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

		[JsonProperty(PropertyName = "WatermarkList")]
		public List<DescribeLiveStreamWatermarks_Watermark> WatermarkList
		{
			get
			{
				return watermarkList;
			}
			set	
			{
				watermarkList = value;
			}
		}

		public class DescribeLiveStreamWatermarks_Watermark
		{

			private int? type;

			private float? xOffset;

			private int? refWidth;

			private float? yOffset;

			private int? height;

			private int? refHeight;

			private string pictureUrl;

			private int? transparency;

			private string description;

			private string offsetCorner;

			private int? ruleCount;

			private string name;

			private string templateId;

			[JsonProperty(PropertyName = "Type")]
			public int? Type
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

			[JsonProperty(PropertyName = "XOffset")]
			public float? XOffset
			{
				get
				{
					return xOffset;
				}
				set	
				{
					xOffset = value;
				}
			}

			[JsonProperty(PropertyName = "RefWidth")]
			public int? RefWidth
			{
				get
				{
					return refWidth;
				}
				set	
				{
					refWidth = value;
				}
			}

			[JsonProperty(PropertyName = "YOffset")]
			public float? YOffset
			{
				get
				{
					return yOffset;
				}
				set	
				{
					yOffset = value;
				}
			}

			[JsonProperty(PropertyName = "Height")]
			public int? Height
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

			[JsonProperty(PropertyName = "RefHeight")]
			public int? RefHeight
			{
				get
				{
					return refHeight;
				}
				set	
				{
					refHeight = value;
				}
			}

			[JsonProperty(PropertyName = "PictureUrl")]
			public string PictureUrl
			{
				get
				{
					return pictureUrl;
				}
				set	
				{
					pictureUrl = value;
				}
			}

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

			[JsonProperty(PropertyName = "OffsetCorner")]
			public string OffsetCorner
			{
				get
				{
					return offsetCorner;
				}
				set	
				{
					offsetCorner = value;
				}
			}

			[JsonProperty(PropertyName = "RuleCount")]
			public int? RuleCount
			{
				get
				{
					return ruleCount;
				}
				set	
				{
					ruleCount = value;
				}
			}

			[JsonProperty(PropertyName = "Name")]
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

			[JsonProperty(PropertyName = "TemplateId")]
			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}
		}
	}
}
