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

namespace Aliyun.Acs.videorecog.Model.V20200320
{
	public class SplitVideoPartsResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private SplitVideoParts_Data data;

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

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "Data")]
		public SplitVideoParts_Data Data
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

		public class SplitVideoParts_Data
		{

			private List<SplitVideoParts_ElementsItem> elements;

			private List<SplitVideoParts_SplitVideoPartResultsItem> splitVideoPartResults;

			[JsonProperty(PropertyName = "Elements")]
			public List<SplitVideoParts_ElementsItem> Elements
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

			[JsonProperty(PropertyName = "SplitVideoPartResults")]
			public List<SplitVideoParts_SplitVideoPartResultsItem> SplitVideoPartResults
			{
				get
				{
					return splitVideoPartResults;
				}
				set	
				{
					splitVideoPartResults = value;
				}
			}

			public class SplitVideoParts_ElementsItem
			{

				private float? beginTime;

				private float? endTime;

				private long? index;

				[JsonProperty(PropertyName = "BeginTime")]
				public float? BeginTime
				{
					get
					{
						return beginTime;
					}
					set	
					{
						beginTime = value;
					}
				}

				[JsonProperty(PropertyName = "EndTime")]
				public float? EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				[JsonProperty(PropertyName = "Index")]
				public long? Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}
			}

			public class SplitVideoParts_SplitVideoPartResultsItem
			{

				private float? beginTime;

				private float? endTime;

				private string theme;

				private string type;

				private string by;

				[JsonProperty(PropertyName = "BeginTime")]
				public float? BeginTime
				{
					get
					{
						return beginTime;
					}
					set	
					{
						beginTime = value;
					}
				}

				[JsonProperty(PropertyName = "EndTime")]
				public float? EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				[JsonProperty(PropertyName = "Theme")]
				public string Theme
				{
					get
					{
						return theme;
					}
					set	
					{
						theme = value;
					}
				}

				[JsonProperty(PropertyName = "Type")]
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

				[JsonProperty(PropertyName = "By")]
				public string By
				{
					get
					{
						return by;
					}
					set	
					{
						by = value;
					}
				}
			}
		}
	}
}
