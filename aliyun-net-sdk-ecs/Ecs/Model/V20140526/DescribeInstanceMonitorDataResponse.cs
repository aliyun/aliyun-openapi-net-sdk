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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeInstanceMonitorDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstanceMonitorData_InstanceMonitorData> monitorData;

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

		public List<DescribeInstanceMonitorData_InstanceMonitorData> MonitorData
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

		public class DescribeInstanceMonitorData_InstanceMonitorData
		{

			private string instanceId;

			private int? cPU;

			private int? intranetRX;

			private int? intranetTX;

			private int? intranetBandwidth;

			private int? internetRX;

			private int? internetTX;

			private int? internetBandwidth;

			private int? iOPSRead;

			private int? iOPSWrite;

			private int? bPSRead;

			private int? bPSWrite;

			private float? cPUCreditUsage;

			private float? cPUCreditBalance;

			private string timeStamp;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public int? CPU
			{
				get
				{
					return cPU;
				}
				set	
				{
					cPU = value;
				}
			}

			public int? IntranetRX
			{
				get
				{
					return intranetRX;
				}
				set	
				{
					intranetRX = value;
				}
			}

			public int? IntranetTX
			{
				get
				{
					return intranetTX;
				}
				set	
				{
					intranetTX = value;
				}
			}

			public int? IntranetBandwidth
			{
				get
				{
					return intranetBandwidth;
				}
				set	
				{
					intranetBandwidth = value;
				}
			}

			public int? InternetRX
			{
				get
				{
					return internetRX;
				}
				set	
				{
					internetRX = value;
				}
			}

			public int? InternetTX
			{
				get
				{
					return internetTX;
				}
				set	
				{
					internetTX = value;
				}
			}

			public int? InternetBandwidth
			{
				get
				{
					return internetBandwidth;
				}
				set	
				{
					internetBandwidth = value;
				}
			}

			public int? IOPSRead
			{
				get
				{
					return iOPSRead;
				}
				set	
				{
					iOPSRead = value;
				}
			}

			public int? IOPSWrite
			{
				get
				{
					return iOPSWrite;
				}
				set	
				{
					iOPSWrite = value;
				}
			}

			public int? BPSRead
			{
				get
				{
					return bPSRead;
				}
				set	
				{
					bPSRead = value;
				}
			}

			public int? BPSWrite
			{
				get
				{
					return bPSWrite;
				}
				set	
				{
					bPSWrite = value;
				}
			}

			public float? CPUCreditUsage
			{
				get
				{
					return cPUCreditUsage;
				}
				set	
				{
					cPUCreditUsage = value;
				}
			}

			public float? CPUCreditBalance
			{
				get
				{
					return cPUCreditBalance;
				}
				set	
				{
					cPUCreditBalance = value;
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