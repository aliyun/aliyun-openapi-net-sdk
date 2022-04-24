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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class DescribeResourceUsageTotalResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeResourceUsageTotal_Data data;

		public string Code
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

		public DescribeResourceUsageTotal_Data Data
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

		public class DescribeResourceUsageTotal_Data
		{

			private List<DescribeResourceUsageTotal_Item> periodCoverage;

			private DescribeResourceUsageTotal_TotalUsage totalUsage;

			public List<DescribeResourceUsageTotal_Item> PeriodCoverage
			{
				get
				{
					return periodCoverage;
				}
				set	
				{
					periodCoverage = value;
				}
			}

			public DescribeResourceUsageTotal_TotalUsage TotalUsage
			{
				get
				{
					return totalUsage;
				}
				set	
				{
					totalUsage = value;
				}
			}

			public class DescribeResourceUsageTotal_Item
			{

				private float? usagePercentage;

				private string period;

				public float? UsagePercentage
				{
					get
					{
						return usagePercentage;
					}
					set	
					{
						usagePercentage = value;
					}
				}

				public string Period
				{
					get
					{
						return period;
					}
					set	
					{
						period = value;
					}
				}
			}

			public class DescribeResourceUsageTotal_TotalUsage
			{

				private float? postpaidCost;

				private float? savedCost;

				private float? usagePercentage;

				private float? potentialSavedCost;

				private float? reservationCost;

				public float? PostpaidCost
				{
					get
					{
						return postpaidCost;
					}
					set	
					{
						postpaidCost = value;
					}
				}

				public float? SavedCost
				{
					get
					{
						return savedCost;
					}
					set	
					{
						savedCost = value;
					}
				}

				public float? UsagePercentage
				{
					get
					{
						return usagePercentage;
					}
					set	
					{
						usagePercentage = value;
					}
				}

				public float? PotentialSavedCost
				{
					get
					{
						return potentialSavedCost;
					}
					set	
					{
						potentialSavedCost = value;
					}
				}

				public float? ReservationCost
				{
					get
					{
						return reservationCost;
					}
					set	
					{
						reservationCost = value;
					}
				}
			}
		}
	}
}
