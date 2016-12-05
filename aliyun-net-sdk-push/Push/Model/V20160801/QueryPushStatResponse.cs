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

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class QueryPushStatResponse : AcsResponse
	{

		private List<PushStat> pushStats;

		public List<PushStat> PushStats
		{
			get
			{
				return pushStats;
			}
			set	
			{
				pushStats = value;
			}
		}

		public class PushStat{

			private string messageId;

			private long? sentCount;

			private long? receivedCount;

			private long? openedCount;

			private long? deletedCount;

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
		}
	}
}