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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryConsumerGroupStatusResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private int? accumulationCount;

		private int? consumerSpeed;

		private string lastConsumerTime;

		private string code;

		private int? accumulatedConsumeCountPerMinute;

		private int? realTimeConsumeCountPerMinute;

		private List<QueryConsumerGroupStatus_ConsumerGroupClientConnectionInfo> clientConnectionStatusList;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public int? AccumulationCount
		{
			get
			{
				return accumulationCount;
			}
			set	
			{
				accumulationCount = value;
			}
		}

		public int? ConsumerSpeed
		{
			get
			{
				return consumerSpeed;
			}
			set	
			{
				consumerSpeed = value;
			}
		}

		public string LastConsumerTime
		{
			get
			{
				return lastConsumerTime;
			}
			set	
			{
				lastConsumerTime = value;
			}
		}

		public string Code
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

		public int? AccumulatedConsumeCountPerMinute
		{
			get
			{
				return accumulatedConsumeCountPerMinute;
			}
			set	
			{
				accumulatedConsumeCountPerMinute = value;
			}
		}

		public int? RealTimeConsumeCountPerMinute
		{
			get
			{
				return realTimeConsumeCountPerMinute;
			}
			set	
			{
				realTimeConsumeCountPerMinute = value;
			}
		}

		public List<QueryConsumerGroupStatus_ConsumerGroupClientConnectionInfo> ClientConnectionStatusList
		{
			get
			{
				return clientConnectionStatusList;
			}
			set	
			{
				clientConnectionStatusList = value;
			}
		}

		public class QueryConsumerGroupStatus_ConsumerGroupClientConnectionInfo
		{

			private string clientId;

			private string clientIpPort;

			private long? onlineTime;

			private int? realTimeConsumeCountPerMinute;

			private int? accumulatedConsumeCountPerMinute;

			public string ClientId
			{
				get
				{
					return clientId;
				}
				set	
				{
					clientId = value;
				}
			}

			public string ClientIpPort
			{
				get
				{
					return clientIpPort;
				}
				set	
				{
					clientIpPort = value;
				}
			}

			public long? OnlineTime
			{
				get
				{
					return onlineTime;
				}
				set	
				{
					onlineTime = value;
				}
			}

			public int? RealTimeConsumeCountPerMinute
			{
				get
				{
					return realTimeConsumeCountPerMinute;
				}
				set	
				{
					realTimeConsumeCountPerMinute = value;
				}
			}

			public int? AccumulatedConsumeCountPerMinute
			{
				get
				{
					return accumulatedConsumeCountPerMinute;
				}
				set	
				{
					accumulatedConsumeCountPerMinute = value;
				}
			}
		}
	}
}
