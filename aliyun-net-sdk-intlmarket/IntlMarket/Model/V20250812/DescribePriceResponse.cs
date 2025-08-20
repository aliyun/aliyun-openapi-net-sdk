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

namespace Aliyun.Acs.IntlMarket.Model.V20250812
{
	public class DescribePriceResponse : AcsResponse
	{

		private string expressionCode;

		private float? originalPrice;

		private string productCode;

		private int? duration;

		private bool? cuxiao;

		private float? tradePrice;

		private string cycle;

		private string infoTitle;

		private float? discountPrice;

		private string currency;

		private string expressionMessage;

		private string requestId;

		private string code;

		private string message;

		private List<DescribePrice_PromotionRule> promotionRules;

		private List<DescribePrice_Coupon> coupons;

		public string ExpressionCode
		{
			get
			{
				return expressionCode;
			}
			set	
			{
				expressionCode = value;
			}
		}

		public float? OriginalPrice
		{
			get
			{
				return originalPrice;
			}
			set	
			{
				originalPrice = value;
			}
		}

		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
			}
		}

		public int? Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
			}
		}

		public bool? Cuxiao
		{
			get
			{
				return cuxiao;
			}
			set	
			{
				cuxiao = value;
			}
		}

		public float? TradePrice
		{
			get
			{
				return tradePrice;
			}
			set	
			{
				tradePrice = value;
			}
		}

		public string Cycle
		{
			get
			{
				return cycle;
			}
			set	
			{
				cycle = value;
			}
		}

		public string InfoTitle
		{
			get
			{
				return infoTitle;
			}
			set	
			{
				infoTitle = value;
			}
		}

		public float? DiscountPrice
		{
			get
			{
				return discountPrice;
			}
			set	
			{
				discountPrice = value;
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

		public string ExpressionMessage
		{
			get
			{
				return expressionMessage;
			}
			set	
			{
				expressionMessage = value;
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

		public List<DescribePrice_PromotionRule> PromotionRules
		{
			get
			{
				return promotionRules;
			}
			set	
			{
				promotionRules = value;
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

		public class DescribePrice_PromotionRule
		{

			private string ruleId;

			private string title;

			private string name;

			public string RuleId
			{
				get
				{
					return ruleId;
				}
				set	
				{
					ruleId = value;
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

		public class DescribePrice_Coupon
		{

			private string couponOptionNo;

			private string promotionDesc;

			private string couponName;

			private long? canPromFee;

			private string couponDesc;

			private bool? isSelected;

			private string couponOptionCode;

			public string CouponOptionNo
			{
				get
				{
					return couponOptionNo;
				}
				set	
				{
					couponOptionNo = value;
				}
			}

			public string PromotionDesc
			{
				get
				{
					return promotionDesc;
				}
				set	
				{
					promotionDesc = value;
				}
			}

			public string CouponName
			{
				get
				{
					return couponName;
				}
				set	
				{
					couponName = value;
				}
			}

			public long? CanPromFee
			{
				get
				{
					return canPromFee;
				}
				set	
				{
					canPromFee = value;
				}
			}

			public string CouponDesc
			{
				get
				{
					return couponDesc;
				}
				set	
				{
					couponDesc = value;
				}
			}

			public bool? IsSelected
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

			public string CouponOptionCode
			{
				get
				{
					return couponOptionCode;
				}
				set	
				{
					couponOptionCode = value;
				}
			}
		}
	}
}
