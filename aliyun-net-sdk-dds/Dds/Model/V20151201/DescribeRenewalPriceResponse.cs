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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeRenewalPriceResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRenewalPrice_SubOrder> subOrders;

		private List<DescribeRenewalPrice_Rule> rules;

		private DescribeRenewalPrice_Order order;

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

		public List<DescribeRenewalPrice_SubOrder> SubOrders
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

		public List<DescribeRenewalPrice_Rule> Rules
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

		public DescribeRenewalPrice_Order Order
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

		public class DescribeRenewalPrice_SubOrder
		{

			private float? originalAmount;

			private float? discountAmount;

			private float? tradeAmount;

			private string instanceId;

			private List<string> ruleIds;

			public float? OriginalAmount
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

			public float? DiscountAmount
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

			public float? TradeAmount
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

		public class DescribeRenewalPrice_Rule
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

		public class DescribeRenewalPrice_Order
		{

			private float? originalAmount;

			private float? discountAmount;

			private float? tradeAmount;

			private string currency;

			private List<DescribeRenewalPrice_Coupon> coupons;

			private List<string> ruleIds1;

			public float? OriginalAmount
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

			public float? DiscountAmount
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

			public float? TradeAmount
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

			public List<DescribeRenewalPrice_Coupon> Coupons
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

			public class DescribeRenewalPrice_Coupon
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
