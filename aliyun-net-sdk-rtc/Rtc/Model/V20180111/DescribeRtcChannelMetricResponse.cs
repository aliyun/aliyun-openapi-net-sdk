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

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class DescribeRtcChannelMetricResponse : AcsResponse
	{

		private string requestId;

		private DescribeRtcChannelMetric_ChannelMetricInfo channelMetricInfo;

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

		public DescribeRtcChannelMetric_ChannelMetricInfo ChannelMetricInfo
		{
			get
			{
				return channelMetricInfo;
			}
			set	
			{
				channelMetricInfo = value;
			}
		}

		public class DescribeRtcChannelMetric_ChannelMetricInfo
		{

			private DescribeRtcChannelMetric_ChannelMetric channelMetric;

			private DescribeRtcChannelMetric_Duration duration;

			public DescribeRtcChannelMetric_ChannelMetric ChannelMetric
			{
				get
				{
					return channelMetric;
				}
				set	
				{
					channelMetric = value;
				}
			}

			public DescribeRtcChannelMetric_Duration Duration
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

			public class DescribeRtcChannelMetric_ChannelMetric
			{

				private string channelId;

				private int? userCount;

				private int? pubUserCount;

				private int? subUserCount;

				private string startTime;

				private string endTime;

				public string ChannelId
				{
					get
					{
						return channelId;
					}
					set	
					{
						channelId = value;
					}
				}

				public int? UserCount
				{
					get
					{
						return userCount;
					}
					set	
					{
						userCount = value;
					}
				}

				public int? PubUserCount
				{
					get
					{
						return pubUserCount;
					}
					set	
					{
						pubUserCount = value;
					}
				}

				public int? SubUserCount
				{
					get
					{
						return subUserCount;
					}
					set	
					{
						subUserCount = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string EndTime
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
			}

			public class DescribeRtcChannelMetric_Duration
			{

				private DescribeRtcChannelMetric_PubDuration pubDuration;

				private DescribeRtcChannelMetric_SubDuration subDuration;

				public DescribeRtcChannelMetric_PubDuration PubDuration
				{
					get
					{
						return pubDuration;
					}
					set	
					{
						pubDuration = value;
					}
				}

				public DescribeRtcChannelMetric_SubDuration SubDuration
				{
					get
					{
						return subDuration;
					}
					set	
					{
						subDuration = value;
					}
				}

				public class DescribeRtcChannelMetric_PubDuration
				{

					private int? audio;

					private int? video360;

					private int? video720;

					private int? video1080;

					private int? content;

					public int? Audio
					{
						get
						{
							return audio;
						}
						set	
						{
							audio = value;
						}
					}

					public int? Video360
					{
						get
						{
							return video360;
						}
						set	
						{
							video360 = value;
						}
					}

					public int? Video720
					{
						get
						{
							return video720;
						}
						set	
						{
							video720 = value;
						}
					}

					public int? Video1080
					{
						get
						{
							return video1080;
						}
						set	
						{
							video1080 = value;
						}
					}

					public int? Content
					{
						get
						{
							return content;
						}
						set	
						{
							content = value;
						}
					}
				}

				public class DescribeRtcChannelMetric_SubDuration
				{

					private int? audio;

					private int? video360;

					private int? video720;

					private int? video1080;

					private int? content;

					public int? Audio
					{
						get
						{
							return audio;
						}
						set	
						{
							audio = value;
						}
					}

					public int? Video360
					{
						get
						{
							return video360;
						}
						set	
						{
							video360 = value;
						}
					}

					public int? Video720
					{
						get
						{
							return video720;
						}
						set	
						{
							video720 = value;
						}
					}

					public int? Video1080
					{
						get
						{
							return video1080;
						}
						set	
						{
							video1080 = value;
						}
					}

					public int? Content
					{
						get
						{
							return content;
						}
						set	
						{
							content = value;
						}
					}
				}
			}
		}
	}
}
