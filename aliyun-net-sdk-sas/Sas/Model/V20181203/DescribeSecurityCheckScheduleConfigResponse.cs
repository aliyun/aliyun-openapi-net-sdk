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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeSecurityCheckScheduleConfigResponse : AcsResponse
	{

		private string requestId;

		private DescribeSecurityCheckScheduleConfig_RiskCheckJobConfig riskCheckJobConfig;

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

		public DescribeSecurityCheckScheduleConfig_RiskCheckJobConfig RiskCheckJobConfig
		{
			get
			{
				return riskCheckJobConfig;
			}
			set	
			{
				riskCheckJobConfig = value;
			}
		}

		public class DescribeSecurityCheckScheduleConfig_RiskCheckJobConfig
		{

			private int? endTime;

			private int? startTime;

			private string daysOfWeek;

			public int? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public int? StartTime
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

			public string DaysOfWeek
			{
				get
				{
					return daysOfWeek;
				}
				set	
				{
					daysOfWeek = value;
				}
			}
		}
	}
}
