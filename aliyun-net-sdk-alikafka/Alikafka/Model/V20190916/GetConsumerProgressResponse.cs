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
	public class GetConsumerProgressResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private GetConsumerProgress_ConsumerProgress consumerProgress;

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

		public GetConsumerProgress_ConsumerProgress ConsumerProgress
		{
			get
			{
				return consumerProgress;
			}
			set	
			{
				consumerProgress = value;
			}
		}

		public class GetConsumerProgress_ConsumerProgress
		{

			private long? lastTimestamp;

			private long? totalDiff;

			private List<GetConsumerProgress_TopicListItem> topicList;

			public long? LastTimestamp
			{
				get
				{
					return lastTimestamp;
				}
				set	
				{
					lastTimestamp = value;
				}
			}

			public long? TotalDiff
			{
				get
				{
					return totalDiff;
				}
				set	
				{
					totalDiff = value;
				}
			}

			public List<GetConsumerProgress_TopicListItem> TopicList
			{
				get
				{
					return topicList;
				}
				set	
				{
					topicList = value;
				}
			}

			public class GetConsumerProgress_TopicListItem
			{

				private long? totalDiff;

				private long? lastTimestamp;

				private string topic;

				private List<GetConsumerProgress_OffsetListItem> offsetList;

				public long? TotalDiff
				{
					get
					{
						return totalDiff;
					}
					set	
					{
						totalDiff = value;
					}
				}

				public long? LastTimestamp
				{
					get
					{
						return lastTimestamp;
					}
					set	
					{
						lastTimestamp = value;
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

				public List<GetConsumerProgress_OffsetListItem> OffsetList
				{
					get
					{
						return offsetList;
					}
					set	
					{
						offsetList = value;
					}
				}

				public class GetConsumerProgress_OffsetListItem
				{

					private int? partition;

					private long? brokerOffset;

					private long? consumerOffset;

					private long? lastTimestamp;

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

					public long? BrokerOffset
					{
						get
						{
							return brokerOffset;
						}
						set	
						{
							brokerOffset = value;
						}
					}

					public long? ConsumerOffset
					{
						get
						{
							return consumerOffset;
						}
						set	
						{
							consumerOffset = value;
						}
					}

					public long? LastTimestamp
					{
						get
						{
							return lastTimestamp;
						}
						set	
						{
							lastTimestamp = value;
						}
					}
				}
			}
		}
	}
}
