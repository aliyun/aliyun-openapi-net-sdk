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
	public class DescribeShowListResponse : AcsResponse
	{

		private string requestId;

		private string showList;

		private DescribeShowList_ShowListInfo showListInfo;

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

		[JsonProperty(PropertyName = "ShowList")]
		public string ShowList
		{
			get
			{
				return showList;
			}
			set	
			{
				showList = value;
			}
		}

		[JsonProperty(PropertyName = "ShowListInfo")]
		public DescribeShowList_ShowListInfo ShowListInfo
		{
			get
			{
				return showListInfo;
			}
			set	
			{
				showListInfo = value;
			}
		}

		public class DescribeShowList_ShowListInfo
		{

			private string currentShowId;

			private string background;

			private string watermark;

			private string highPriorityShowId;

			private string highPriorityShowStartTime;

			private int? showListRepeatTimes;

			private int? totalShowListRepeatTimes;

			private List<DescribeShowList_Show> showList;

			[JsonProperty(PropertyName = "CurrentShowId")]
			public string CurrentShowId
			{
				get
				{
					return currentShowId;
				}
				set	
				{
					currentShowId = value;
				}
			}

			[JsonProperty(PropertyName = "Background")]
			public string Background
			{
				get
				{
					return background;
				}
				set	
				{
					background = value;
				}
			}

			[JsonProperty(PropertyName = "Watermark")]
			public string Watermark
			{
				get
				{
					return watermark;
				}
				set	
				{
					watermark = value;
				}
			}

			[JsonProperty(PropertyName = "HighPriorityShowId")]
			public string HighPriorityShowId
			{
				get
				{
					return highPriorityShowId;
				}
				set	
				{
					highPriorityShowId = value;
				}
			}

			[JsonProperty(PropertyName = "HighPriorityShowStartTime")]
			public string HighPriorityShowStartTime
			{
				get
				{
					return highPriorityShowStartTime;
				}
				set	
				{
					highPriorityShowStartTime = value;
				}
			}

			[JsonProperty(PropertyName = "ShowListRepeatTimes")]
			public int? ShowListRepeatTimes
			{
				get
				{
					return showListRepeatTimes;
				}
				set	
				{
					showListRepeatTimes = value;
				}
			}

			[JsonProperty(PropertyName = "TotalShowListRepeatTimes")]
			public int? TotalShowListRepeatTimes
			{
				get
				{
					return totalShowListRepeatTimes;
				}
				set	
				{
					totalShowListRepeatTimes = value;
				}
			}

			[JsonProperty(PropertyName = "ShowList")]
			public List<DescribeShowList_Show> ShowList
			{
				get
				{
					return showList;
				}
				set	
				{
					showList = value;
				}
			}

			public class DescribeShowList_Show
			{

				private long? duration;

				private int? repeatTimes;

				private string showId;

				private string showName;

				private DescribeShowList_ResourceInfo resourceInfo;

				[JsonProperty(PropertyName = "Duration")]
				public long? Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				[JsonProperty(PropertyName = "RepeatTimes")]
				public int? RepeatTimes
				{
					get
					{
						return repeatTimes;
					}
					set	
					{
						repeatTimes = value;
					}
				}

				[JsonProperty(PropertyName = "ShowId")]
				public string ShowId
				{
					get
					{
						return showId;
					}
					set	
					{
						showId = value;
					}
				}

				[JsonProperty(PropertyName = "ShowName")]
				public string ShowName
				{
					get
					{
						return showName;
					}
					set	
					{
						showName = value;
					}
				}

				[JsonProperty(PropertyName = "ResourceInfo")]
				public DescribeShowList_ResourceInfo ResourceInfo
				{
					get
					{
						return resourceInfo;
					}
					set	
					{
						resourceInfo = value;
					}
				}

				public class DescribeShowList_ResourceInfo
				{

					private int? liveInputType;

					private string resourceId;

					private string resourceType;

					private string resourceUrl;

					[JsonProperty(PropertyName = "LiveInputType")]
					public int? LiveInputType
					{
						get
						{
							return liveInputType;
						}
						set	
						{
							liveInputType = value;
						}
					}

					[JsonProperty(PropertyName = "ResourceId")]
					public string ResourceId
					{
						get
						{
							return resourceId;
						}
						set	
						{
							resourceId = value;
						}
					}

					[JsonProperty(PropertyName = "ResourceType")]
					public string ResourceType
					{
						get
						{
							return resourceType;
						}
						set	
						{
							resourceType = value;
						}
					}

					[JsonProperty(PropertyName = "ResourceUrl")]
					public string ResourceUrl
					{
						get
						{
							return resourceUrl;
						}
						set	
						{
							resourceUrl = value;
						}
					}
				}
			}
		}
	}
}
