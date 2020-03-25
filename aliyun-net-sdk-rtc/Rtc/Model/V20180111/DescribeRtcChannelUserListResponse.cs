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
	public class DescribeRtcChannelUserListResponse : AcsResponse
	{

		private string requestId;

		private long? pageSize;

		private long? pageNo;

		private long? totalCnt;

		private List<DescribeRtcChannelUserList_UserListItem> userList;

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

		public List<DescribeRtcChannelUserList_UserListItem> UserList
		{
			get
			{
				return userList;
			}
			set	
			{
				userList = value;
			}
		}

		public class DescribeRtcChannelUserList_UserListItem
		{

			private string channelId;

			private string userId;

			private string startTime;

			private string endTime;

			private string serviceArea;

			private int? subAudio;

			private int? pubAudio;

			private int? subVideo360;

			private int? pubVideo360;

			private int? subVideo720;

			private int? pubVideo720;

			private int? subVideo1080;

			private int? pubVideo1080;

			private int? subContent;

			private int? pubContent;

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

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
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

			public string ServiceArea
			{
				get
				{
					return serviceArea;
				}
				set	
				{
					serviceArea = value;
				}
			}

			public int? SubAudio
			{
				get
				{
					return subAudio;
				}
				set	
				{
					subAudio = value;
				}
			}

			public int? PubAudio
			{
				get
				{
					return pubAudio;
				}
				set	
				{
					pubAudio = value;
				}
			}

			public int? SubVideo360
			{
				get
				{
					return subVideo360;
				}
				set	
				{
					subVideo360 = value;
				}
			}

			public int? PubVideo360
			{
				get
				{
					return pubVideo360;
				}
				set	
				{
					pubVideo360 = value;
				}
			}

			public int? SubVideo720
			{
				get
				{
					return subVideo720;
				}
				set	
				{
					subVideo720 = value;
				}
			}

			public int? PubVideo720
			{
				get
				{
					return pubVideo720;
				}
				set	
				{
					pubVideo720 = value;
				}
			}

			public int? SubVideo1080
			{
				get
				{
					return subVideo1080;
				}
				set	
				{
					subVideo1080 = value;
				}
			}

			public int? PubVideo1080
			{
				get
				{
					return pubVideo1080;
				}
				set	
				{
					pubVideo1080 = value;
				}
			}

			public int? SubContent
			{
				get
				{
					return subContent;
				}
				set	
				{
					subContent = value;
				}
			}

			public int? PubContent
			{
				get
				{
					return pubContent;
				}
				set	
				{
					pubContent = value;
				}
			}
		}
	}
}
