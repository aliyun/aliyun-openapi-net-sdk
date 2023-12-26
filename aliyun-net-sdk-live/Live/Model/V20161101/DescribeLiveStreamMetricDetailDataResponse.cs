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
	public class DescribeLiveStreamMetricDetailDataResponse : AcsResponse
	{

		private string endTime;

		private string startTime;

		private string requestId;

		private string nextPageToken;

		private int? pageSize;

		private string domainName;

		private List<DescribeLiveStreamMetricDetailData_StreamData> streamDetailData;

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
		public List<DescribeLiveStreamMetricDetailData_StreamData> StreamDetailData
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

		public class DescribeLiveStreamMetricDetailData_StreamData
		{

			private long? p2pTraffic;

			private float? rtmpBps;

			private float? hlsBps;

			private float? p2pBps;

			private string streamName;

			private long? p2pCount;

			private long? traffic;

			private long? rtmpCount;

			private long? rtsCount;

			private float? rtsBps;

			private float? bps;

			private long? hlsTraffic;

			private float? flvBps;

			private long? count;

			private long? rtsTraffic;

			private long? rtmpTraffic;

			private long? hlsCount;

			private string appName;

			private long? flvCount;

			private long? flvTraffic;

			private string timeStamp;

			private string newConns;

			[JsonProperty(PropertyName = "P2pTraffic")]
			public long? P2pTraffic
			{
				get
				{
					return p2pTraffic;
				}
				set	
				{
					p2pTraffic = value;
				}
			}

			[JsonProperty(PropertyName = "RtmpBps")]
			public float? RtmpBps
			{
				get
				{
					return rtmpBps;
				}
				set	
				{
					rtmpBps = value;
				}
			}

			[JsonProperty(PropertyName = "HlsBps")]
			public float? HlsBps
			{
				get
				{
					return hlsBps;
				}
				set	
				{
					hlsBps = value;
				}
			}

			[JsonProperty(PropertyName = "P2pBps")]
			public float? P2pBps
			{
				get
				{
					return p2pBps;
				}
				set	
				{
					p2pBps = value;
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

			[JsonProperty(PropertyName = "P2pCount")]
			public long? P2pCount
			{
				get
				{
					return p2pCount;
				}
				set	
				{
					p2pCount = value;
				}
			}

			[JsonProperty(PropertyName = "Traffic")]
			public long? Traffic
			{
				get
				{
					return traffic;
				}
				set	
				{
					traffic = value;
				}
			}

			[JsonProperty(PropertyName = "RtmpCount")]
			public long? RtmpCount
			{
				get
				{
					return rtmpCount;
				}
				set	
				{
					rtmpCount = value;
				}
			}

			[JsonProperty(PropertyName = "RtsCount")]
			public long? RtsCount
			{
				get
				{
					return rtsCount;
				}
				set	
				{
					rtsCount = value;
				}
			}

			[JsonProperty(PropertyName = "RtsBps")]
			public float? RtsBps
			{
				get
				{
					return rtsBps;
				}
				set	
				{
					rtsBps = value;
				}
			}

			[JsonProperty(PropertyName = "Bps")]
			public float? Bps
			{
				get
				{
					return bps;
				}
				set	
				{
					bps = value;
				}
			}

			[JsonProperty(PropertyName = "HlsTraffic")]
			public long? HlsTraffic
			{
				get
				{
					return hlsTraffic;
				}
				set	
				{
					hlsTraffic = value;
				}
			}

			[JsonProperty(PropertyName = "FlvBps")]
			public float? FlvBps
			{
				get
				{
					return flvBps;
				}
				set	
				{
					flvBps = value;
				}
			}

			[JsonProperty(PropertyName = "Count")]
			public long? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			[JsonProperty(PropertyName = "RtsTraffic")]
			public long? RtsTraffic
			{
				get
				{
					return rtsTraffic;
				}
				set	
				{
					rtsTraffic = value;
				}
			}

			[JsonProperty(PropertyName = "RtmpTraffic")]
			public long? RtmpTraffic
			{
				get
				{
					return rtmpTraffic;
				}
				set	
				{
					rtmpTraffic = value;
				}
			}

			[JsonProperty(PropertyName = "HlsCount")]
			public long? HlsCount
			{
				get
				{
					return hlsCount;
				}
				set	
				{
					hlsCount = value;
				}
			}

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

			[JsonProperty(PropertyName = "FlvCount")]
			public long? FlvCount
			{
				get
				{
					return flvCount;
				}
				set	
				{
					flvCount = value;
				}
			}

			[JsonProperty(PropertyName = "FlvTraffic")]
			public long? FlvTraffic
			{
				get
				{
					return flvTraffic;
				}
				set	
				{
					flvTraffic = value;
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

			[JsonProperty(PropertyName = "NewConns")]
			public string NewConns
			{
				get
				{
					return newConns;
				}
				set	
				{
					newConns = value;
				}
			}
		}
	}
}
