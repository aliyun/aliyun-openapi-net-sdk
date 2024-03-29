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
	public class DescribeDefenseCountStatisticsResponse : AcsResponse
	{

		private string requestId;

		private DescribeDefenseCountStatistics_DefenseCountStatistics defenseCountStatistics;

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

		public DescribeDefenseCountStatistics_DefenseCountStatistics DefenseCountStatistics
		{
			get
			{
				return defenseCountStatistics;
			}
			set	
			{
				defenseCountStatistics = value;
			}
		}

		public class DescribeDefenseCountStatistics_DefenseCountStatistics
		{

			private int? flowPackCountRemain;

			private int? maxUsableDefenseCountCurrentMonth;

			private int? defenseCountTotalUsageOfCurrentMonth;

			private int? secHighSpeedCountRemain;

			public int? FlowPackCountRemain
			{
				get
				{
					return flowPackCountRemain;
				}
				set	
				{
					flowPackCountRemain = value;
				}
			}

			public int? MaxUsableDefenseCountCurrentMonth
			{
				get
				{
					return maxUsableDefenseCountCurrentMonth;
				}
				set	
				{
					maxUsableDefenseCountCurrentMonth = value;
				}
			}

			public int? DefenseCountTotalUsageOfCurrentMonth
			{
				get
				{
					return defenseCountTotalUsageOfCurrentMonth;
				}
				set	
				{
					defenseCountTotalUsageOfCurrentMonth = value;
				}
			}

			public int? SecHighSpeedCountRemain
			{
				get
				{
					return secHighSpeedCountRemain;
				}
				set	
				{
					secHighSpeedCountRemain = value;
				}
			}
		}
	}
}
