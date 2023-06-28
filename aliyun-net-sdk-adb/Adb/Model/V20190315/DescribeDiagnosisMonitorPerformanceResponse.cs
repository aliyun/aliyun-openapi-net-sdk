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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeDiagnosisMonitorPerformanceResponse : AcsResponse
	{

		private int? performancesThreshold;

		private bool? performancesTruncated;

		private string requestId;

		private List<DescribeDiagnosisMonitorPerformance_Items> performances;

		public int? PerformancesThreshold
		{
			get
			{
				return performancesThreshold;
			}
			set	
			{
				performancesThreshold = value;
			}
		}

		public bool? PerformancesTruncated
		{
			get
			{
				return performancesTruncated;
			}
			set	
			{
				performancesTruncated = value;
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

		public List<DescribeDiagnosisMonitorPerformance_Items> Performances
		{
			get
			{
				return performances;
			}
			set	
			{
				performances = value;
			}
		}

		public class DescribeDiagnosisMonitorPerformance_Items
		{

			private string status;

			private string processId;

			private long? startTime;

			private long? cost;

			private long? scanRows;

			private long? peakMemory;

			private string rcHost;

			private long? scanSize;

			private string userName;

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string ProcessId
			{
				get
				{
					return processId;
				}
				set	
				{
					processId = value;
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

			public long? Cost
			{
				get
				{
					return cost;
				}
				set	
				{
					cost = value;
				}
			}

			public long? ScanRows
			{
				get
				{
					return scanRows;
				}
				set	
				{
					scanRows = value;
				}
			}

			public long? PeakMemory
			{
				get
				{
					return peakMemory;
				}
				set	
				{
					peakMemory = value;
				}
			}

			public string RcHost
			{
				get
				{
					return rcHost;
				}
				set	
				{
					rcHost = value;
				}
			}

			public long? ScanSize
			{
				get
				{
					return scanSize;
				}
				set	
				{
					scanSize = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}
		}
	}
}
