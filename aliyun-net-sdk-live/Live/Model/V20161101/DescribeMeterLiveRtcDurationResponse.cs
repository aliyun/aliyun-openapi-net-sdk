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
	public class DescribeMeterLiveRtcDurationResponse : AcsResponse
	{

		private long? audioSummaryDuration;

		private string requestId;

		private long? totalSummaryDuration;

		private long? v480SummaryDuration;

		private long? v720SummaryDuration;

		private long? v1080SummaryDuration;

		private List<DescribeMeterLiveRtcDuration_DataItem> data;

		[JsonProperty(PropertyName = "AudioSummaryDuration")]
		public long? AudioSummaryDuration
		{
			get
			{
				return audioSummaryDuration;
			}
			set	
			{
				audioSummaryDuration = value;
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

		[JsonProperty(PropertyName = "TotalSummaryDuration")]
		public long? TotalSummaryDuration
		{
			get
			{
				return totalSummaryDuration;
			}
			set	
			{
				totalSummaryDuration = value;
			}
		}

		[JsonProperty(PropertyName = "V480SummaryDuration")]
		public long? V480SummaryDuration
		{
			get
			{
				return v480SummaryDuration;
			}
			set	
			{
				v480SummaryDuration = value;
			}
		}

		[JsonProperty(PropertyName = "V720SummaryDuration")]
		public long? V720SummaryDuration
		{
			get
			{
				return v720SummaryDuration;
			}
			set	
			{
				v720SummaryDuration = value;
			}
		}

		[JsonProperty(PropertyName = "V1080SummaryDuration")]
		public long? V1080SummaryDuration
		{
			get
			{
				return v1080SummaryDuration;
			}
			set	
			{
				v1080SummaryDuration = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public List<DescribeMeterLiveRtcDuration_DataItem> Data
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

		public class DescribeMeterLiveRtcDuration_DataItem
		{

			private long? audioDuration;

			private string timestamp;

			private long? totalDuration;

			private long? v480Duration;

			private long? v720Duration;

			private long? v1080Duration;

			[JsonProperty(PropertyName = "AudioDuration")]
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

			[JsonProperty(PropertyName = "Timestamp")]
			public string Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			[JsonProperty(PropertyName = "TotalDuration")]
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

			[JsonProperty(PropertyName = "V480Duration")]
			public long? V480Duration
			{
				get
				{
					return v480Duration;
				}
				set	
				{
					v480Duration = value;
				}
			}

			[JsonProperty(PropertyName = "V720Duration")]
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

			[JsonProperty(PropertyName = "V1080Duration")]
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
		}
	}
}
