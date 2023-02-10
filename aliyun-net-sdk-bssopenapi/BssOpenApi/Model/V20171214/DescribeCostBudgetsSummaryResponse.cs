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
	public class DescribeCostBudgetsSummaryResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private DescribeCostBudgetsSummary_Data data;

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

		public DescribeCostBudgetsSummary_Data Data
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

		public class DescribeCostBudgetsSummary_Data
		{

			private string nextToken;

			private int? maxResults;

			private int? totalCount;

			private string hostId;

			private List<DescribeCostBudgetsSummary_Item> items;

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
				}
			}

			public int? MaxResults
			{
				get
				{
					return maxResults;
				}
				set	
				{
					maxResults = value;
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

			public string HostId
			{
				get
				{
					return hostId;
				}
				set	
				{
					hostId = value;
				}
			}

			public List<DescribeCostBudgetsSummary_Item> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class DescribeCostBudgetsSummary_Item
			{

				private string budgetName;

				private string budgetStatus;

				private string budgetType;

				private string budget;

				private string calculatedValues;

				private string consumePeriod;

				public string BudgetName
				{
					get
					{
						return budgetName;
					}
					set	
					{
						budgetName = value;
					}
				}

				public string BudgetStatus
				{
					get
					{
						return budgetStatus;
					}
					set	
					{
						budgetStatus = value;
					}
				}

				public string BudgetType
				{
					get
					{
						return budgetType;
					}
					set	
					{
						budgetType = value;
					}
				}

				public string Budget
				{
					get
					{
						return budget;
					}
					set	
					{
						budget = value;
					}
				}

				public string CalculatedValues
				{
					get
					{
						return calculatedValues;
					}
					set	
					{
						calculatedValues = value;
					}
				}

				public string ConsumePeriod
				{
					get
					{
						return consumePeriod;
					}
					set	
					{
						consumePeriod = value;
					}
				}
			}
		}
	}
}
