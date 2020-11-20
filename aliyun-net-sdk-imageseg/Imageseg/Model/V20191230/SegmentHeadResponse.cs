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

namespace Aliyun.Acs.imageseg.Model.V20191230
{
	public class SegmentHeadResponse : AcsResponse
	{

		private string requestId;

		private SegmentHead_Data data;

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

		public SegmentHead_Data Data
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

		public class SegmentHead_Data
		{

			private List<SegmentHead_Element> elements;

			public List<SegmentHead_Element> Elements
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

			public class SegmentHead_Element
			{

				private string imageURL;

				private int? x;

				private int? y;

				private int? width;

				private int? height;

				public string ImageURL
				{
					get
					{
						return imageURL;
					}
					set	
					{
						imageURL = value;
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
		}
	}
}
