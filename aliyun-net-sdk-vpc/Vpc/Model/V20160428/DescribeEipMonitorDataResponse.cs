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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeEipMonitorDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeEipMonitorData_EipMonitorData> eipMonitorDatas;

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

		public List<DescribeEipMonitorData_EipMonitorData> EipMonitorDatas
		{
			get
			{
				return eipMonitorDatas;
			}
			set	
			{
				eipMonitorDatas = value;
			}
		}

		public class DescribeEipMonitorData_EipMonitorData
		{

			private long? eipTX;

			private int? eipPackets;

			private int? eipBandwidth;

			private string timeStamp;

			private long? eipFlow;

			private long? eipRX;

			public long? EipTX
			{
				get
				{
					return eipTX;
				}
				set	
				{
					eipTX = value;
				}
			}

			public int? EipPackets
			{
				get
				{
					return eipPackets;
				}
				set	
				{
					eipPackets = value;
				}
			}

			public int? EipBandwidth
			{
				get
				{
					return eipBandwidth;
				}
				set	
				{
					eipBandwidth = value;
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

			public long? EipFlow
			{
				get
				{
					return eipFlow;
				}
				set	
				{
					eipFlow = value;
				}
			}

			public long? EipRX
			{
				get
				{
					return eipRX;
				}
				set	
				{
					eipRX = value;
				}
			}
		}
	}
}
