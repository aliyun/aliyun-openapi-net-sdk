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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeRdsPerformanceSummaryResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeRdsPerformanceSummary_RdsPerformanceInfo> rdsPerformanceInfos;

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

		public List<DescribeRdsPerformanceSummary_RdsPerformanceInfo> RdsPerformanceInfos
		{
			get
			{
				return rdsPerformanceInfos;
			}
			set	
			{
				rdsPerformanceInfos = value;
			}
		}

		public class DescribeRdsPerformanceSummary_RdsPerformanceInfo
		{

			private string rdsId;

			private float? cpu;

			private float? iops;

			private int? activeSessions;

			private int? totalSessions;

			private long? spaceUsage;

			public string RdsId
			{
				get
				{
					return rdsId;
				}
				set	
				{
					rdsId = value;
				}
			}

			public float? Cpu
			{
				get
				{
					return cpu;
				}
				set	
				{
					cpu = value;
				}
			}

			public float? Iops
			{
				get
				{
					return iops;
				}
				set	
				{
					iops = value;
				}
			}

			public int? ActiveSessions
			{
				get
				{
					return activeSessions;
				}
				set	
				{
					activeSessions = value;
				}
			}

			public int? TotalSessions
			{
				get
				{
					return totalSessions;
				}
				set	
				{
					totalSessions = value;
				}
			}

			public long? SpaceUsage
			{
				get
				{
					return spaceUsage;
				}
				set	
				{
					spaceUsage = value;
				}
			}
		}
	}
}
