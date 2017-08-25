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

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeLiveStreamOnlineBpsResponse : AcsResponse
	{

		private string requestId;

		private long? totalUserNumber;

		private float? flvBps;

		private float? hlsBps;

		private List<DescribeLiveStreamOnlineBps_LiveStreamOnlineBpsInfo> liveStreamOnlineBpsInfos;

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

		public long? TotalUserNumber
		{
			get
			{
				return totalUserNumber;
			}
			set	
			{
				totalUserNumber = value;
			}
		}

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

		public List<DescribeLiveStreamOnlineBps_LiveStreamOnlineBpsInfo> LiveStreamOnlineBpsInfos
		{
			get
			{
				return liveStreamOnlineBpsInfos;
			}
			set	
			{
				liveStreamOnlineBpsInfos = value;
			}
		}

		public class DescribeLiveStreamOnlineBps_LiveStreamOnlineBpsInfo
		{

			private string streamUrl;

			private float? upBps;

			private float? downBps;

			private string time;

			public string StreamUrl
			{
				get
				{
					return streamUrl;
				}
				set	
				{
					streamUrl = value;
				}
			}

			public float? UpBps
			{
				get
				{
					return upBps;
				}
				set	
				{
					upBps = value;
				}
			}

			public float? DownBps
			{
				get
				{
					return downBps;
				}
				set	
				{
					downBps = value;
				}
			}

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
		}
	}
}