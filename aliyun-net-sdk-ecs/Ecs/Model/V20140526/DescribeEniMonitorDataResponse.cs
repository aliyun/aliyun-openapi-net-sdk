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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeEniMonitorDataResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeEniMonitorData_EniMonitorData> monitorData;

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

		public int? TotalCount
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

		public List<DescribeEniMonitorData_EniMonitorData> MonitorData
		{
			get
			{
				return monitorData;
			}
			set	
			{
				monitorData = value;
			}
		}

		public class DescribeEniMonitorData_EniMonitorData
		{

			private string eniId;

			private string timeStamp;

			private string packetTx;

			private string packetRx;

			private string intranetTx;

			private string intranetRx;

			private string dropPacketTx;

			private string dropPacketRx;

			public string EniId
			{
				get
				{
					return eniId;
				}
				set	
				{
					eniId = value;
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

			public string PacketTx
			{
				get
				{
					return packetTx;
				}
				set	
				{
					packetTx = value;
				}
			}

			public string PacketRx
			{
				get
				{
					return packetRx;
				}
				set	
				{
					packetRx = value;
				}
			}

			public string IntranetTx
			{
				get
				{
					return intranetTx;
				}
				set	
				{
					intranetTx = value;
				}
			}

			public string IntranetRx
			{
				get
				{
					return intranetRx;
				}
				set	
				{
					intranetRx = value;
				}
			}

			public string DropPacketTx
			{
				get
				{
					return dropPacketTx;
				}
				set	
				{
					dropPacketTx = value;
				}
			}

			public string DropPacketRx
			{
				get
				{
					return dropPacketRx;
				}
				set	
				{
					dropPacketRx = value;
				}
			}
		}
	}
}
