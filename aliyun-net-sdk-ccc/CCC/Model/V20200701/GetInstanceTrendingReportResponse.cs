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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class GetInstanceTrendingReportResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private GetInstanceTrendingReport_Data data;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public GetInstanceTrendingReport_Data Data
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

		public class GetInstanceTrendingReport_Data
		{

			private List<GetInstanceTrendingReport_InboundItem> inbound;

			private List<GetInstanceTrendingReport_OutboundItem> outbound;

			public List<GetInstanceTrendingReport_InboundItem> Inbound
			{
				get
				{
					return inbound;
				}
				set	
				{
					inbound = value;
				}
			}

			public List<GetInstanceTrendingReport_OutboundItem> Outbound
			{
				get
				{
					return outbound;
				}
				set	
				{
					outbound = value;
				}
			}

			public class GetInstanceTrendingReport_InboundItem
			{

				private long? statsTime;

				private long? callsQueued;

				private long? callsAbandonedInRing;

				private long? callsHandled;

				private long? totalCalls;

				private long? callsAbandonedInIVR;

				private long? callsAbandonedInQueue;

				public long? StatsTime
				{
					get
					{
						return statsTime;
					}
					set	
					{
						statsTime = value;
					}
				}

				public long? CallsQueued
				{
					get
					{
						return callsQueued;
					}
					set	
					{
						callsQueued = value;
					}
				}

				public long? CallsAbandonedInRing
				{
					get
					{
						return callsAbandonedInRing;
					}
					set	
					{
						callsAbandonedInRing = value;
					}
				}

				public long? CallsHandled
				{
					get
					{
						return callsHandled;
					}
					set	
					{
						callsHandled = value;
					}
				}

				public long? TotalCalls
				{
					get
					{
						return totalCalls;
					}
					set	
					{
						totalCalls = value;
					}
				}

				public long? CallsAbandonedInIVR
				{
					get
					{
						return callsAbandonedInIVR;
					}
					set	
					{
						callsAbandonedInIVR = value;
					}
				}

				public long? CallsAbandonedInQueue
				{
					get
					{
						return callsAbandonedInQueue;
					}
					set	
					{
						callsAbandonedInQueue = value;
					}
				}
			}

			public class GetInstanceTrendingReport_OutboundItem
			{

				private long? statsTime;

				private long? callsAnswered;

				private long? totalCalls;

				public long? StatsTime
				{
					get
					{
						return statsTime;
					}
					set	
					{
						statsTime = value;
					}
				}

				public long? CallsAnswered
				{
					get
					{
						return callsAnswered;
					}
					set	
					{
						callsAnswered = value;
					}
				}

				public long? TotalCalls
				{
					get
					{
						return totalCalls;
					}
					set	
					{
						totalCalls = value;
					}
				}
			}
		}
	}
}
