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

		private string requestId;

		private List<DescribeLiveStreamWatermarks_Watermark> watermarkList;

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

			private string name;

			private string templateId;

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
