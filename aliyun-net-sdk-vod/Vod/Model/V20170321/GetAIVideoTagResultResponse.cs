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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetAIVideoTagResultResponse : AcsResponse
	{

		private string requestId;

		private GetAIVideoTagResult_VideoTagResult videoTagResult;

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

		public GetAIVideoTagResult_VideoTagResult VideoTagResult
		{
			get
			{
				return videoTagResult;
			}
			set	
			{
				videoTagResult = value;
			}
		}

		public class GetAIVideoTagResult_VideoTagResult
		{

			private List<GetAIVideoTagResult_CategoryItem> category;

			private List<GetAIVideoTagResult_PersonItem> person;

			private List<GetAIVideoTagResult_TimeItem> time;

			private List<GetAIVideoTagResult_LocationItem> location;

			private List<GetAIVideoTagResult_KeywordItem> keyword;

			public List<GetAIVideoTagResult_CategoryItem> Category
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

			public List<GetAIVideoTagResult_PersonItem> Person
			{
				get
				{
					return person;
				}
				set	
				{
					person = value;
				}
			}

			public List<GetAIVideoTagResult_TimeItem> Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public List<GetAIVideoTagResult_LocationItem> Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public List<GetAIVideoTagResult_KeywordItem> Keyword
			{
				get
				{
					return keyword;
				}
				set	
				{
					keyword = value;
				}
			}

			public class GetAIVideoTagResult_CategoryItem
			{

				private string tag;

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}
			}

			public class GetAIVideoTagResult_PersonItem
			{

				private string faceUrl;

				private string tag;

				private List<string> times;

				public string FaceUrl
				{
					get
					{
						return faceUrl;
					}
					set	
					{
						faceUrl = value;
					}
				}

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}

				public List<string> Times
				{
					get
					{
						return times;
					}
					set	
					{
						times = value;
					}
				}
			}

			public class GetAIVideoTagResult_TimeItem
			{

				private string tag;

				private List<string> times1;

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}

				public List<string> Times1
				{
					get
					{
						return times1;
					}
					set	
					{
						times1 = value;
					}
				}
			}

			public class GetAIVideoTagResult_LocationItem
			{

				private string tag;

				private List<string> times2;

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}

				public List<string> Times2
				{
					get
					{
						return times2;
					}
					set	
					{
						times2 = value;
					}
				}
			}

			public class GetAIVideoTagResult_KeywordItem
			{

				private string tag;

				private List<string> times3;

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}

				public List<string> Times3
				{
					get
					{
						return times3;
					}
					set	
					{
						times3 = value;
					}
				}
			}
		}
	}
}
