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

namespace Aliyun.Acs.imagerecog.Model.V20190930
{
	public class DetectImageElementsResponse : AcsResponse
	{

		private string requestId;

		private DetectImageElements_Data data;

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

		public DetectImageElements_Data Data
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

		public class DetectImageElements_Data
		{

			private List<DetectImageElements_Element> elements;

			public List<DetectImageElements_Element> Elements
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

			public class DetectImageElements_Element
			{

				private string type;

				private int? width;

				private int? height;

				private int? y;

				private float? score;

				private int? x;

				public string Type
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
			}
		}
	}
}
