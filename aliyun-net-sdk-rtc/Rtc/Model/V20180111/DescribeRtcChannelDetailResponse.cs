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
	public class DescribeRtcChannelDetailResponse : AcsResponse
	{

		private string requestId;

		private string channelId;

		private long? pageSize;

		private long? pageNo;

		private long? totalCnt;

		private List<DescribeRtcChannelDetail_Detail> channelInfo;

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

		public long? PageSize
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

		public long? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
			}
		}

		public long? TotalCnt
		{
			get
			{
				return totalCnt;
			}
			set	
			{
				totalCnt = value;
			}
		}

		public List<DescribeRtcChannelDetail_Detail> ChannelInfo
		{
			get
			{
				return channelInfo;
			}
			set	
			{
				channelInfo = value;
			}
		}

		public class DescribeRtcChannelDetail_Detail
		{

			private string sid;

			private string uid;

			private string joinTime;

			private string leaveTime;

			private string sdkVersion;

			private string platform;

			private string oS;

			private string deviceType;

			public string Sid
			{
				get
				{
					return sid;
				}
				set	
				{
					sid = value;
				}
			}

			public string Uid
			{
				get
				{
					return uid;
				}
				set	
				{
					uid = value;
				}
			}

			public string JoinTime
			{
				get
				{
					return joinTime;
				}
				set	
				{
					joinTime = value;
				}
			}

			public string LeaveTime
			{
				get
				{
					return leaveTime;
				}
				set	
				{
					leaveTime = value;
				}
			}

			public string SdkVersion
			{
				get
				{
					return sdkVersion;
				}
				set	
				{
					sdkVersion = value;
				}
			}

			public string Platform
			{
				get
				{
					return platform;
				}
				set	
				{
					platform = value;
				}
			}

			public string OS
			{
				get
				{
					return oS;
				}
				set	
				{
					oS = value;
				}
			}

			public string DeviceType
			{
				get
				{
					return deviceType;
				}
				set	
				{
					deviceType = value;
				}
			}
		}
	}
}
