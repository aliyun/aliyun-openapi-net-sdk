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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeDiskMonitorDataResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeDiskMonitorData_DiskMonitorData> monitorData;

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

		public List<DescribeDiskMonitorData_DiskMonitorData> MonitorData
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

		public class DescribeDiskMonitorData_DiskMonitorData
		{

			private int? bPSRead;

			private int? iOPSRead;

			private int? latencyRead;

			private int? bPSTotal;

			private int? iOPSTotal;

			private string timeStamp;

			private int? latencyWrite;

			private int? iOPSWrite;

			private string diskId;

			private int? bPSWrite;

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

			public int? LatencyRead
			{
				get
				{
					return latencyRead;
				}
				set	
				{
					latencyRead = value;
				}
			}

			public int? BPSTotal
			{
				get
				{
					return bPSTotal;
				}
				set	
				{
					bPSTotal = value;
				}
			}

			public int? IOPSTotal
			{
				get
				{
					return iOPSTotal;
				}
				set	
				{
					iOPSTotal = value;
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

			public int? LatencyWrite
			{
				get
				{
					return latencyWrite;
				}
				set	
				{
					latencyWrite = value;
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

			public string DiskId
			{
				get
				{
					return diskId;
				}
				set	
				{
					diskId = value;
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
		}
	}
}
