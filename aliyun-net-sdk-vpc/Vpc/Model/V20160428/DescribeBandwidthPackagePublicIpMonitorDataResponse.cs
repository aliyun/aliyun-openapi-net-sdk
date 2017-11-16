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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeBandwidthPackagePublicIpMonitorDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeBandwidthPackagePublicIpMonitorData_MonitorData> monitorDatas;

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

		public List<DescribeBandwidthPackagePublicIpMonitorData_MonitorData> MonitorDatas
		{
			get
			{
				return monitorDatas;
			}
			set	
			{
				monitorDatas = value;
			}
		}

		public class DescribeBandwidthPackagePublicIpMonitorData_MonitorData
		{

			private long? rX;

			private long? tX;

			private long? receivedBandwidth;

			private long? transportedBandwidth;

			private long? flow;

			private long? bandwidth;

			private long? packets;

			private string timeStamp;

			public long? RX
			{
				get
				{
					return rX;
				}
				set	
				{
					rX = value;
				}
			}

			public long? TX
			{
				get
				{
					return tX;
				}
				set	
				{
					tX = value;
				}
			}

			public long? ReceivedBandwidth
			{
				get
				{
					return receivedBandwidth;
				}
				set	
				{
					receivedBandwidth = value;
				}
			}

			public long? TransportedBandwidth
			{
				get
				{
					return transportedBandwidth;
				}
				set	
				{
					transportedBandwidth = value;
				}
			}

			public long? Flow
			{
				get
				{
					return flow;
				}
				set	
				{
					flow = value;
				}
			}

			public long? Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

			public long? Packets
			{
				get
				{
					return packets;
				}
				set	
				{
					packets = value;
				}
			}

			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}
		}
	}
}