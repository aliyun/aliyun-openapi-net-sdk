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

namespace Aliyun.Acs.Push.Model.V20150827
{
	public class ListDevicePushRecordsResponse : AcsResponse
	{

		private int? total;

		private int? pageSize;

		private int? page;

		private List<DevicePushStat> messageList;

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

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

		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
			}
		}

		public List<DevicePushStat> MessageList
		{
			get
			{
				return messageList;
			}
			set	
			{
				messageList = value;
			}
		}

		public class DevicePushStat{

			private string messageId;

			private string pushStatus;

			private string deviceStatusWhenPush;

			private string pushTime;

			private string lastModifyTime;

			public string MessageId
			{
				get
				{
					return messageId;
				}
				set	
				{
					messageId = value;
				}
			}

			public string PushStatus
			{
				get
				{
					return pushStatus;
				}
				set	
				{
					pushStatus = value;
				}
			}

			public string DeviceStatusWhenPush
			{
				get
				{
					return deviceStatusWhenPush;
				}
				set	
				{
					deviceStatusWhenPush = value;
				}
			}

			public string PushTime
			{
				get
				{
					return pushTime;
				}
				set	
				{
					pushTime = value;
				}
			}

			public string LastModifyTime
			{
				get
				{
					return lastModifyTime;
				}
				set	
				{
					lastModifyTime = value;
				}
			}
		}
	}
}