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

namespace Aliyun.Acs.vs.Model.V20181212
{
	public class DescribeDeviceChannelsResponse : AcsResponse
	{

		private string requestId;

		private long? pageSize;

		private long? pageNum;

		private long? pageCount;

		private long? totalCount;

		private List<DescribeDeviceChannels_Channel> channels;

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

		public long? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
			}
		}

		public long? PageCount
		{
			get
			{
				return pageCount;
			}
			set	
			{
				pageCount = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeDeviceChannels_Channel> Channels
		{
			get
			{
				return channels;
			}
			set	
			{
				channels = value;
			}
		}

		public class DescribeDeviceChannels_Channel
		{

			private string name;

			private string gbId;

			private string streamId;

			private string streamStatus;

			private string deviceId;

			private string deviceStatus;

			private long? channelId;

			private string _params;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string GbId
			{
				get
				{
					return gbId;
				}
				set	
				{
					gbId = value;
				}
			}

			public string StreamId
			{
				get
				{
					return streamId;
				}
				set	
				{
					streamId = value;
				}
			}

			public string StreamStatus
			{
				get
				{
					return streamStatus;
				}
				set	
				{
					streamStatus = value;
				}
			}

			public string DeviceId
			{
				get
				{
					return deviceId;
				}
				set	
				{
					deviceId = value;
				}
			}

			public string DeviceStatus
			{
				get
				{
					return deviceStatus;
				}
				set	
				{
					deviceStatus = value;
				}
			}

			public long? ChannelId
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

			public string _Params
			{
				get
				{
					return _params;
				}
				set	
				{
					_params = value;
				}
			}
		}
	}
}
