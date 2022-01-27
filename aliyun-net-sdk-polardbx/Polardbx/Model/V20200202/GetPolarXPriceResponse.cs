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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class GetPolarXPriceResponse : AcsResponse
	{

		private string requestId;

		private List<GetPolarXPrice_OrderPrice> orderPriceList;

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

		public List<GetPolarXPrice_OrderPrice> OrderPriceList
		{
			get
			{
				return orderPriceList;
			}
			set	
			{
				orderPriceList = value;
			}
		}

		public class GetPolarXPrice_OrderPrice
		{

			private string dBInstanceName;

			private string totalCostAmount;

			private string discountAmount;

			private string tradeAmount;

			private string originalAmount;

			private string payType;

			private List<GetPolarXPrice_Rule> rules;

			public string DBInstanceName
			{
				get
				{
					return dBInstanceName;
				}
				set	
				{
					dBInstanceName = value;
				}
			}

			public string TotalCostAmount
			{
				get
				{
					return totalCostAmount;
				}
				set	
				{
					totalCostAmount = value;
				}
			}

			public string DiscountAmount
			{
				get
				{
					return discountAmount;
				}
				set	
				{
					discountAmount = value;
				}
			}

			public string TradeAmount
			{
				get
				{
					return tradeAmount;
				}
				set	
				{
					tradeAmount = value;
				}
			}

			public string OriginalAmount
			{
				get
				{
					return originalAmount;
				}
				set	
				{
					originalAmount = value;
				}
			}

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public List<GetPolarXPrice_Rule> Rules
			{
				get
				{
					return rules;
				}
				set	
				{
					rules = value;
				}
			}

			public class GetPolarXPrice_Rule
			{

				private long? ruleDescId;

				private string name;

				private string title;

				public long? RuleDescId
				{
					get
					{
						return ruleDescId;
					}
					set	
					{
						ruleDescId = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}
			}
		}
	}
}
