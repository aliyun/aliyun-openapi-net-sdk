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

namespace Aliyun.Acs.alikafka.Model.V20190916
{
	public class GetTopicStatusResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private GetTopicStatus_TopicStatus topicStatus;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public GetTopicStatus_TopicStatus TopicStatus
		{
			get
			{
				return topicStatus;
			}
			set	
			{
				topicStatus = value;
			}
		}

		public class GetTopicStatus_TopicStatus
		{

			private long? totalCount;

			private long? lastTimeStamp;

			private List<GetTopicStatus_OffsetTableItem> offsetTable;

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

			public long? LastTimeStamp
			{
				get
				{
					return lastTimeStamp;
				}
				set	
				{
					lastTimeStamp = value;
				}
			}

			public List<GetTopicStatus_OffsetTableItem> OffsetTable
			{
				get
				{
					return offsetTable;
				}
				set	
				{
					offsetTable = value;
				}
			}

			public class GetTopicStatus_OffsetTableItem
			{

				private int? partition;

				private long? minOffset;

				private long? lastUpdateTimestamp;

				private long? maxOffset;

				private string topic;

				public int? Partition
				{
					get
					{
						return partition;
					}
					set	
					{
						partition = value;
					}
				}

				public long? MinOffset
				{
					get
					{
						return minOffset;
					}
					set	
					{
						minOffset = value;
					}
				}

				public long? LastUpdateTimestamp
				{
					get
					{
						return lastUpdateTimestamp;
					}
					set	
					{
						lastUpdateTimestamp = value;
					}
				}

				public long? MaxOffset
				{
					get
					{
						return maxOffset;
					}
					set	
					{
						maxOffset = value;
					}
				}

				public string Topic
				{
					get
					{
						return topic;
					}
					set	
					{
						topic = value;
					}
				}
			}
		}
	}
}
