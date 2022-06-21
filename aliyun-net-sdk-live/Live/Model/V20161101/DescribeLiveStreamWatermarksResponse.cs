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

			private string templateId;

			private string name;

			private int? type;

			private string description;

			private int? refWidth;

			private int? refHeight;

			private float? xOffset;

			private float? yOffset;

			private int? height;

			private int? transparency;

			private string offsetCorner;

			private string pictureUrl;

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
		}
	}
}
