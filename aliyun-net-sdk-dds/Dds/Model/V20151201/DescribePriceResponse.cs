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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribePriceResponse : AcsResponse
	{

		private string requestId;

		private string traceId;

		private string orderParams;

		private List<DescribePrice_SubOrder> subOrders;

		private List<DescribePrice_Rule> rules;

		private DescribePrice_Order order;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
			}
		}

		public string OrderParams
		{
			get
			{
				return orderParams;
			}
			set	
			{
				orderParams = value;
			}
		}

		public List<DescribePrice_SubOrder> SubOrders
		{
			get
			{
				return subOrders;
			}
			set	
			{
				subOrders = value;
			}
		}

		public List<DescribePrice_Rule> Rules
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

		public DescribePrice_Order Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
			}
		}

		public class DescribePrice_SubOrder
		{

			private string originalAmount;

			private string discountAmount;

			private string tradeAmount;

			private string instanceId;

			private List<string> ruleIds;

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

			public List<string> RuleIds
			{
				get
				{
					return ruleIds;
				}
				set	
				{
					ruleIds = value;
				}
			}
		}

		public class DescribePrice_Rule
		{

			private long? ruleDescId;

			private string title;

			private string name;

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
		}

		public class DescribePrice_Order
		{

			private string originalAmount;

			private string discountAmount;

			private string tradeAmount;

			private string currency;

			private List<DescribePrice_Coupon> coupons;

			private List<string> ruleIds1;

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

			public string Currency
			{
				get
				{
					return currency;
				}
				set	
				{
					currency = value;
				}
			}

			public List<DescribePrice_Coupon> Coupons
			{
				get
				{
					return coupons;
				}
				set	
				{
					coupons = value;
				}
			}

			public List<string> RuleIds1
			{
				get
				{
					return ruleIds1;
				}
				set	
				{
					ruleIds1 = value;
				}
			}

			public class DescribePrice_Coupon
			{

				private string description;

				private string isSelected;

				private string couponNo;

				private string name;

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

				public string IsSelected
				{
					get
					{
						return isSelected;
					}
					set	
					{
						isSelected = value;
					}
				}

				public string CouponNo
				{
					get
					{
						return couponNo;
					}
					set	
					{
						couponNo = value;
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
			}
		}
	}
}
