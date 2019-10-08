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

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class QueryPushStatByAppResponse : AcsResponse
	{

		private string requestId;

		private List<QueryPushStatByApp_AppPushStat> appPushStats;

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

		public List<QueryPushStatByApp_AppPushStat> AppPushStats
		{
			get
			{
				return appPushStats;
			}
			set	
			{
				appPushStats = value;
			}
		}

		public class QueryPushStatByApp_AppPushStat
		{

			private string time;

			private long? acceptCount;

			private long? sentCount;

			private long? receivedCount;

			private long? openedCount;

			private long? deletedCount;

			private long? smsSentCount;

			private long? smsSkipCount;

			private long? smsFailedCount;

			private long? smsReceiveSuccessCount;

			private long? smsReceiveFailedCount;

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

			public long? AcceptCount
			{
				get
				{
					return acceptCount;
				}
				set	
				{
					acceptCount = value;
				}
			}

			public long? SentCount
			{
				get
				{
					return sentCount;
				}
				set	
				{
					sentCount = value;
				}
			}

			public long? ReceivedCount
			{
				get
				{
					return receivedCount;
				}
				set	
				{
					receivedCount = value;
				}
			}

			public long? OpenedCount
			{
				get
				{
					return openedCount;
				}
				set	
				{
					openedCount = value;
				}
			}

			public long? DeletedCount
			{
				get
				{
					return deletedCount;
				}
				set	
				{
					deletedCount = value;
				}
			}

			public long? SmsSentCount
			{
				get
				{
					return smsSentCount;
				}
				set	
				{
					smsSentCount = value;
				}
			}

			public long? SmsSkipCount
			{
				get
				{
					return smsSkipCount;
				}
				set	
				{
					smsSkipCount = value;
				}
			}

			public long? SmsFailedCount
			{
				get
				{
					return smsFailedCount;
				}
				set	
				{
					smsFailedCount = value;
				}
			}

			public long? SmsReceiveSuccessCount
			{
				get
				{
					return smsReceiveSuccessCount;
				}
				set	
				{
					smsReceiveSuccessCount = value;
				}
			}

			public long? SmsReceiveFailedCount
			{
				get
				{
					return smsReceiveFailedCount;
				}
				set	
				{
					smsReceiveFailedCount = value;
				}
			}
		}
	}
}
