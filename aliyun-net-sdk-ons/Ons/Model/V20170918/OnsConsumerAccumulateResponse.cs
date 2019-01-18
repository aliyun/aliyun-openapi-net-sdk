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

namespace Aliyun.Acs.Ons.Model.V20170918
{
	public class OnsConsumerAccumulateResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private OnsConsumerAccumulate_Data data;

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

		public string HelpUrl
		{
			get
			{
				return helpUrl;
			}
			set	
			{
				helpUrl = value;
			}
		}

		public OnsConsumerAccumulate_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class OnsConsumerAccumulate_Data
		{

			private bool? online;

			private long? totalDiff;

			private float? consumeTps;

			private long? lastTimestamp;

			private long? delayTime;

			private List<OnsConsumerAccumulate_DetailInTopicDo> detailInTopicList;

			public bool? Online
			{
				get
				{
					return online;
				}
				set	
				{
					online = value;
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

			public float? ConsumeTps
			{
				get
				{
					return consumeTps;
				}
				set	
				{
					consumeTps = value;
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

			public long? DelayTime
			{
				get
				{
					return delayTime;
				}
				set	
				{
					delayTime = value;
				}
			}

			public List<OnsConsumerAccumulate_DetailInTopicDo> DetailInTopicList
			{
				get
				{
					return detailInTopicList;
				}
				set	
				{
					detailInTopicList = value;
				}
			}

			public class OnsConsumerAccumulate_DetailInTopicDo
			{

				private string topic;

				private long? totalDiff;

				private long? lastTimestamp;

				private long? delayTime;

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

				public long? DelayTime
				{
					get
					{
						return delayTime;
					}
					set	
					{
						delayTime = value;
					}
				}
			}
		}
	}
}