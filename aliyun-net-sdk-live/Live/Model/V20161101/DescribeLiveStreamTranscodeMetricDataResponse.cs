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
	public class DescribeLiveStreamTranscodeMetricDataResponse : AcsResponse
	{

		private string endTime;

		private string startTime;

		private string requestId;

		private string nextPageToken;

		private int? pageSize;

		private string domainName;

		private List<DescribeLiveStreamTranscodeMetricData_StreamData> streamDetailData;

		[JsonProperty(PropertyName = "EndTime")]
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

		[JsonProperty(PropertyName = "StartTime")]
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

		[JsonProperty(PropertyName = "NextPageToken")]
		public string NextPageToken
		{
			get
			{
				return nextPageToken;
			}
			set	
			{
				nextPageToken = value;
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		[JsonProperty(PropertyName = "DomainName")]
		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
			}
		}

		[JsonProperty(PropertyName = "StreamDetailData")]
		public List<DescribeLiveStreamTranscodeMetricData_StreamData> StreamDetailData
		{
			get
			{
				return streamDetailData;
			}
			set	
			{
				streamDetailData = value;
			}
		}

		public class DescribeLiveStreamTranscodeMetricData_StreamData
		{

			private string appName;

			private string streamName;

			private string region;

			private long? duration;

			private string fps;

			private string timeStamp;

			private string transcodeType;

			private string resolution;

			[JsonProperty(PropertyName = "AppName")]
			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			[JsonProperty(PropertyName = "StreamName")]
			public string StreamName
			{
				get
				{
					return streamName;
				}
				set	
				{
					streamName = value;
				}
			}

			[JsonProperty(PropertyName = "Region")]
			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
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

			[JsonProperty(PropertyName = "Fps")]
			public string Fps
			{
				get
				{
					return fps;
				}
				set	
				{
					fps = value;
				}
			}

			[JsonProperty(PropertyName = "TimeStamp")]
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

			[JsonProperty(PropertyName = "TranscodeType")]
			public string TranscodeType
			{
				get
				{
					return transcodeType;
				}
				set	
				{
					transcodeType = value;
				}
			}

			[JsonProperty(PropertyName = "Resolution")]
			public string Resolution
			{
				get
				{
					return resolution;
				}
				set	
				{
					resolution = value;
				}
			}
		}
	}
}
