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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class ListNatGatewayEcsMetricResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private List<ListNatGatewayEcsMetric_MetricData> metricDataList;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public List<ListNatGatewayEcsMetric_MetricData> MetricDataList
		{
			get
			{
				return metricDataList;
			}
			set	
			{
				metricDataList = value;
			}
		}

		public class ListNatGatewayEcsMetric_MetricData
		{

			private string natGatewayId;

			private string privateIpAddress;

			private long? timestamp;

			private long? activeSessionNum;

			private long? newSessionRate;

			private long? rxBps;

			private long? txBps;

			private long? rxPps;

			private long? txPps;

			public string NatGatewayId
			{
				get
				{
					return natGatewayId;
				}
				set	
				{
					natGatewayId = value;
				}
			}

			public string PrivateIpAddress
			{
				get
				{
					return privateIpAddress;
				}
				set	
				{
					privateIpAddress = value;
				}
			}

			public long? Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			public long? ActiveSessionNum
			{
				get
				{
					return activeSessionNum;
				}
				set	
				{
					activeSessionNum = value;
				}
			}

			public long? NewSessionRate
			{
				get
				{
					return newSessionRate;
				}
				set	
				{
					newSessionRate = value;
				}
			}

			public long? RxBps
			{
				get
				{
					return rxBps;
				}
				set	
				{
					rxBps = value;
				}
			}

			public long? TxBps
			{
				get
				{
					return txBps;
				}
				set	
				{
					txBps = value;
				}
			}

			public long? RxPps
			{
				get
				{
					return rxPps;
				}
				set	
				{
					rxPps = value;
				}
			}

			public long? TxPps
			{
				get
				{
					return txPps;
				}
				set	
				{
					txPps = value;
				}
			}
		}
	}
}
