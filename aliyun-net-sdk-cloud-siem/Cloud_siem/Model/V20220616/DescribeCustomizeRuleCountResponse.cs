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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class DescribeCustomizeRuleCountResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private DescribeCustomizeRuleCount_Data data;

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

		public int? Code
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

		public DescribeCustomizeRuleCount_Data Data
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

		public class DescribeCustomizeRuleCount_Data
		{

			private int? inUseRuleNum;

			private int? highRuleNum;

			private int? mediumRuleNum;

			private int? lowRuleNum;

			private int? totalRuleNum;

			private int? customizeRuleNum;

			private int? predefinedRuleNum;

			private int? unEventRuleNum;

			private int? expertRuleNum;

			private int? graphComputingRuleNum;

			private int? singleAlertRuleNum;

			private int? aggregationRuleNum;

			public int? InUseRuleNum
			{
				get
				{
					return inUseRuleNum;
				}
				set	
				{
					inUseRuleNum = value;
				}
			}

			public int? HighRuleNum
			{
				get
				{
					return highRuleNum;
				}
				set	
				{
					highRuleNum = value;
				}
			}

			public int? MediumRuleNum
			{
				get
				{
					return mediumRuleNum;
				}
				set	
				{
					mediumRuleNum = value;
				}
			}

			public int? LowRuleNum
			{
				get
				{
					return lowRuleNum;
				}
				set	
				{
					lowRuleNum = value;
				}
			}

			public int? TotalRuleNum
			{
				get
				{
					return totalRuleNum;
				}
				set	
				{
					totalRuleNum = value;
				}
			}

			public int? CustomizeRuleNum
			{
				get
				{
					return customizeRuleNum;
				}
				set	
				{
					customizeRuleNum = value;
				}
			}

			public int? PredefinedRuleNum
			{
				get
				{
					return predefinedRuleNum;
				}
				set	
				{
					predefinedRuleNum = value;
				}
			}

			public int? UnEventRuleNum
			{
				get
				{
					return unEventRuleNum;
				}
				set	
				{
					unEventRuleNum = value;
				}
			}

			public int? ExpertRuleNum
			{
				get
				{
					return expertRuleNum;
				}
				set	
				{
					expertRuleNum = value;
				}
			}

			public int? GraphComputingRuleNum
			{
				get
				{
					return graphComputingRuleNum;
				}
				set	
				{
					graphComputingRuleNum = value;
				}
			}

			public int? SingleAlertRuleNum
			{
				get
				{
					return singleAlertRuleNum;
				}
				set	
				{
					singleAlertRuleNum = value;
				}
			}

			public int? AggregationRuleNum
			{
				get
				{
					return aggregationRuleNum;
				}
				set	
				{
					aggregationRuleNum = value;
				}
			}
		}
	}
}
