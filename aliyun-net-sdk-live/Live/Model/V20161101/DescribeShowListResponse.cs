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

		private string showList;

		private string requestId;

		private DescribeShowList_ShowListInfo showListInfo;

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

			private string highPriorityShowStartTime;

			private int? totalShowListRepeatTimes;

			private int? showListRepeatTimes;

			private string currentShowId;

			private string highPriorityShowId;

			private List<DescribeShowList_Show> showList;

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

				private string showName;

				private long? duration;

				private int? repeatTimes;

				private string showId;

				private DescribeShowList_ResourceInfo resourceInfo;

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

					private string resourceUrl;

					private string resourceType;

					private string resourceId;

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
				}
			}
		}
	}
}
