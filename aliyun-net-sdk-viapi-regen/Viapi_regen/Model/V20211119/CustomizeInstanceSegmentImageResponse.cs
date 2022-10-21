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

namespace Aliyun.Acs.viapi_regen.Model.V20211119
{
	public class CustomizeInstanceSegmentImageResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private CustomizeInstanceSegmentImage_Data data;

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public CustomizeInstanceSegmentImage_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class CustomizeInstanceSegmentImage_Data
		{

			private List<CustomizeInstanceSegmentImage_ElementsItem> elements;

			public List<CustomizeInstanceSegmentImage_ElementsItem> Elements
			{
				get
				{
					return elements;
				}
				set	
				{
					elements = value;
				}
			}

			public class CustomizeInstanceSegmentImage_ElementsItem
			{

				private float? score;

				private string category;

				private List<CustomizeInstanceSegmentImage_ContoursItem> contours;

				private CustomizeInstanceSegmentImage_Boxes boxes;

				private CustomizeInstanceSegmentImage_Mask mask;

				public float? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
					}
				}

				public string Category
				{
					get
					{
						return category;
					}
					set	
					{
						category = value;
					}
				}

				public List<CustomizeInstanceSegmentImage_ContoursItem> Contours
				{
					get
					{
						return contours;
					}
					set	
					{
						contours = value;
					}
				}

				public CustomizeInstanceSegmentImage_Boxes Boxes
				{
					get
					{
						return boxes;
					}
					set	
					{
						boxes = value;
					}
				}

				public CustomizeInstanceSegmentImage_Mask Mask
				{
					get
					{
						return mask;
					}
					set	
					{
						mask = value;
					}
				}

				public class CustomizeInstanceSegmentImage_ContoursItem
				{

					private int? x;

					private int? y;

					public int? X
					{
						get
						{
							return x;
						}
						set	
						{
							x = value;
						}
					}

					public int? Y
					{
						get
						{
							return y;
						}
						set	
						{
							y = value;
						}
					}
				}

				public class CustomizeInstanceSegmentImage_Boxes
				{

					private int? x;

					private int? y;

					private int? width;

					private int? height;

					public int? X
					{
						get
						{
							return x;
						}
						set	
						{
							x = value;
						}
					}

					public int? Y
					{
						get
						{
							return y;
						}
						set	
						{
							y = value;
						}
					}

					public int? Width
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
				}

				public class CustomizeInstanceSegmentImage_Mask
				{

					private string counts;

					private List<string> sizes;

					public string Counts
					{
						get
						{
							return counts;
						}
						set	
						{
							counts = value;
						}
					}

					public List<string> Sizes
					{
						get
						{
							return sizes;
						}
						set	
						{
							sizes = value;
						}
					}
				}
			}
		}
	}
}
