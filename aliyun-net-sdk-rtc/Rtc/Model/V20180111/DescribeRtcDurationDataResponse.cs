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
	public class DescribeRtcDurationDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRtcDurationData_DurationModule> durationDataPerInterval;

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

		public List<DescribeRtcDurationData_DurationModule> DurationDataPerInterval
		{
			get
			{
				return durationDataPerInterval;
			}
			set	
			{
				durationDataPerInterval = value;
			}
		}

		public class DescribeRtcDurationData_DurationModule
		{

			private string timeStamp;

			private long? totalDuration;

			private long? audioDuration;

			private long? v360Duration;

			private long? v720Duration;

			private long? v1080Duration;

			private long? contentDuration;

			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			public long? TotalDuration
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

			public long? V360Duration
			{
				get
				{
					return v360Duration;
				}
				set	
				{
					v360Duration = value;
				}
			}

			public long? V720Duration
			{
				get
				{
					return v720Duration;
				}
				set	
				{
					v720Duration = value;
				}
			}

			public long? V1080Duration
			{
				get
				{
					return v1080Duration;
				}
				set	
				{
					v1080Duration = value;
				}
			}

			public long? ContentDuration
			{
				get
				{
					return contentDuration;
				}
				set	
				{
					contentDuration = value;
				}
			}
		}
	}
}
