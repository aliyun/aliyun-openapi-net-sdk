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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribePriceResponse : AcsResponse
	{

		private string expressionCode;

		private bool? cuxiao;

		private float? discountPrice;

		private string cycle;

		private float? tradePrice;

		private float? originalPrice;

		private int? duration;

		private string currency;

		private string expressionMessage;

		private string infoTitle;

		private string productCode;

		private List<DescribePrice_PromotionRule> promotionRules;

		private List<DescribePrice_Coupon> coupons;

		[JsonProperty(PropertyName = "ExpressionCode")]
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

		[JsonProperty(PropertyName = "Cuxiao")]
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

		[JsonProperty(PropertyName = "DiscountPrice")]
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

		[JsonProperty(PropertyName = "Cycle")]
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

		[JsonProperty(PropertyName = "TradePrice")]
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

		[JsonProperty(PropertyName = "OriginalPrice")]
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

		[JsonProperty(PropertyName = "Duration")]
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

		[JsonProperty(PropertyName = "Currency")]
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

		[JsonProperty(PropertyName = "ExpressionMessage")]
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

		[JsonProperty(PropertyName = "InfoTitle")]
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

		[JsonProperty(PropertyName = "ProductCode")]
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

		[JsonProperty(PropertyName = "PromotionRules")]
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

		[JsonProperty(PropertyName = "Coupons")]
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

			private string title;

			private string name;

			private string ruleId;

			[JsonProperty(PropertyName = "Title")]
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

			[JsonProperty(PropertyName = "Name")]
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

			[JsonProperty(PropertyName = "RuleId")]
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
		}

		public class DescribePrice_Coupon
		{

			private string couponOptionCode;

			private string couponOptionNo;

			private string couponName;

			private string couponDesc;

			private bool? isSelected;

			private float? canPromFee;

			[JsonProperty(PropertyName = "CouponOptionCode")]
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

			[JsonProperty(PropertyName = "CouponOptionNo")]
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

			[JsonProperty(PropertyName = "CouponName")]
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

			[JsonProperty(PropertyName = "CouponDesc")]
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

			[JsonProperty(PropertyName = "IsSelected")]
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

			[JsonProperty(PropertyName = "CanPromFee")]
			public float? CanPromFee
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
		}
	}
}
