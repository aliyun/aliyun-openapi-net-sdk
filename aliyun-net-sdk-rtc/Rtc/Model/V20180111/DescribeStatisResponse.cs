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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class DescribeStatisResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeStatis_StatisInfo> statisInfos;

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

		public List<DescribeStatis_StatisInfo> StatisInfos
		{
			get
			{
				return statisInfos;
			}
			set	
			{
				statisInfos = value;
			}
		}

		public class DescribeStatis_StatisInfo
		{

			private string time;

			private List<DescribeStatis_DurationItem> duration;

			private List<DescribeStatis_UserStatisItem> userStatis;

			private List<DescribeStatis_ChannelStatisItem> channelStatis;

			public string Time
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

			public List<DescribeStatis_DurationItem> Duration
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

			public List<DescribeStatis_UserStatisItem> UserStatis
			{
				get
				{
					return userStatis;
				}
				set	
				{
					userStatis = value;
				}
			}

			public List<DescribeStatis_ChannelStatisItem> ChannelStatis
			{
				get
				{
					return channelStatis;
				}
				set	
				{
					channelStatis = value;
				}
			}

			public class DescribeStatis_DurationItem
			{

				private float? totalDuration;

				private float? audioDuration;

				private float? sdDuration;

				private float? hdDuration;

				private float? fhdDuration;

				public float? TotalDuration
				{
					get
					{
						return totalDuration;
					}
					set	
					{
						totalDuration = value;
					}
				}

				public float? AudioDuration
				{
					get
					{
						return audioDuration;
					}
					set	
					{
						audioDuration = value;
					}
				}

				public float? SdDuration
				{
					get
					{
						return sdDuration;
					}
					set	
					{
						sdDuration = value;
					}
				}

				public float? HdDuration
				{
					get
					{
						return hdDuration;
					}
					set	
					{
						hdDuration = value;
					}
				}

				public float? FhdDuration
				{
					get
					{
						return fhdDuration;
					}
					set	
					{
						fhdDuration = value;
					}
				}
			}

			public class DescribeStatis_UserStatisItem
			{

				private long? activeUserCnt;

				private long? conSessionPeak;

				private string conSessionPeakTime;

				public long? ActiveUserCnt
				{
					get
					{
						return activeUserCnt;
					}
					set	
					{
						activeUserCnt = value;
					}
				}

				public long? ConSessionPeak
				{
					get
					{
						return conSessionPeak;
					}
					set	
					{
						conSessionPeak = value;
					}
				}

				public string ConSessionPeakTime
				{
					get
					{
						return conSessionPeakTime;
					}
					set	
					{
						conSessionPeakTime = value;
					}
				}
			}

			public class DescribeStatis_ChannelStatisItem
			{

				private long? accChannelCnt;

				private long? conChannelPeak;

				private string conChannelPeakTime;

				public long? AccChannelCnt
				{
					get
					{
						return accChannelCnt;
					}
					set	
					{
						accChannelCnt = value;
					}
				}

				public long? ConChannelPeak
				{
					get
					{
						return conChannelPeak;
					}
					set	
					{
						conChannelPeak = value;
					}
				}

				public string ConChannelPeakTime
				{
					get
					{
						return conChannelPeakTime;
					}
					set	
					{
						conChannelPeakTime = value;
					}
				}
			}
		}
	}
}