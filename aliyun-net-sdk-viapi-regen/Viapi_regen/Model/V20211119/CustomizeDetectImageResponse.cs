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
	public class CustomizeDetectImageResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private CustomizeDetectImage_Data data;

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

		public CustomizeDetectImage_Data Data
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

		public class CustomizeDetectImage_Data
		{

			private List<CustomizeDetectImage_ElementsItem> elements;

			public List<CustomizeDetectImage_ElementsItem> Elements
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

			public class CustomizeDetectImage_ElementsItem
			{

				private float? score;

				private string category;

				private CustomizeDetectImage_Boxes boxes;

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

				public CustomizeDetectImage_Boxes Boxes
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

				public class CustomizeDetectImage_Boxes
				{

					private float? x;

					private float? y;

					private float? width;

					private float? height;

					public float? X
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

					public float? Y
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

					public float? Width
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

					public float? Height
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
			}
		}
	}
}
