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
	public class DescribeRtcChannelListResponse : AcsResponse
	{

		private string requestId;

		private long? pageSize;

		private long? pageNo;

		private long? totalCnt;

		private List<DescribeRtcChannelList_ChannelListItem> channelList;

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

		public List<DescribeRtcChannelList_ChannelListItem> ChannelList
		{
			get
			{
				return channelList;
			}
			set	
			{
				channelList = value;
			}
		}

		public class DescribeRtcChannelList_ChannelListItem
		{

			private string channelId;

			private string startTime;

			private string endTime;

			private long? totalUserCnt;

			private List<string> callArea;

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

			public long? TotalUserCnt
			{
				get
				{
					return totalUserCnt;
				}
				set	
				{
					totalUserCnt = value;
				}
			}

			public List<string> CallArea
			{
				get
				{
					return callArea;
				}
				set	
				{
					callArea = value;
				}
			}
		}
	}
}
