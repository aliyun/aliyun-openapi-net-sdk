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

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
	public class GetGatewayStatusStatResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetGatewayStatusStat_Data data;

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

		public GetGatewayStatusStat_Data Data
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

		public class GetGatewayStatusStat_Data
		{

			private string gwEui;

			private float? cpuRadio;

			private float? memoryRadio;

			private long? rxCount;

			private long? txCount;

			private string onlineState;

			private long? onlineHour;

			private bool? enabled;

			public string GwEui
			{
				get
				{
					return gwEui;
				}
				set	
				{
					gwEui = value;
				}
			}

			public float? CpuRadio
			{
				get
				{
					return cpuRadio;
				}
				set	
				{
					cpuRadio = value;
				}
			}

			public float? MemoryRadio
			{
				get
				{
					return memoryRadio;
				}
				set	
				{
					memoryRadio = value;
				}
			}

			public long? RxCount
			{
				get
				{
					return rxCount;
				}
				set	
				{
					rxCount = value;
				}
			}

			public long? TxCount
			{
				get
				{
					return txCount;
				}
				set	
				{
					txCount = value;
				}
			}

			public string OnlineState
			{
				get
				{
					return onlineState;
				}
				set	
				{
					onlineState = value;
				}
			}

			public long? OnlineHour
			{
				get
				{
					return onlineHour;
				}
				set	
				{
					onlineHour = value;
				}
			}

			public bool? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}
		}
	}
}
