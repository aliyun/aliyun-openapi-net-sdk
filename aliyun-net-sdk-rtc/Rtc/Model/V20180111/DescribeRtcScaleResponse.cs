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
	public class DescribeRtcScaleResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRtcScale_ScaleItem> scale;

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

		public List<DescribeRtcScale_ScaleItem> Scale
		{
			get
			{
				return scale;
			}
			set	
			{
				scale = value;
			}
		}

		public class DescribeRtcScale_ScaleItem
		{

			private string time;

			private long? channelCount;

			private long? userCount;

			private long? sessionCount;

			private long? audioDuration;

			private long? videoDuration;

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

			public long? ChannelCount
			{
				get
				{
					return channelCount;
				}
				set	
				{
					channelCount = value;
				}
			}

			public long? UserCount
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

			public long? SessionCount
			{
				get
				{
					return sessionCount;
				}
				set	
				{
					sessionCount = value;
				}
			}

			public long? AudioDuration
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

			public long? VideoDuration
			{
				get
				{
					return videoDuration;
				}
				set	
				{
					videoDuration = value;
				}
			}
		}
	}
}
