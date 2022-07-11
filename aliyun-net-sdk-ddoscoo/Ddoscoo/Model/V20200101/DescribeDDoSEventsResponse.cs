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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeDDoSEventsResponse : AcsResponse
	{

		private long? total;

		private string requestId;

		private List<DescribeDDoSEvents_Data> dDoSEvents;

		public long? Total
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

		public List<DescribeDDoSEvents_Data> DDoSEvents
		{
			get
			{
				return dDoSEvents;
			}
			set	
			{
				dDoSEvents = value;
			}
		}

		public class DescribeDDoSEvents_Data
		{

			private long? endTime;

			private long? startTime;

			private string eventType;

			private string region;

			private string ip;

			private string port;

			private long? bps;

			private long? pps;

			public long? EndTime
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

			public long? StartTime
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

			public string EventType
			{
				get
				{
					return eventType;
				}
				set	
				{
					eventType = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public string Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public long? Bps
			{
				get
				{
					return bps;
				}
				set	
				{
					bps = value;
				}
			}

			public long? Pps
			{
				get
				{
					return pps;
				}
				set	
				{
					pps = value;
				}
			}
		}
	}
}
