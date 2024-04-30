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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribePriceResponse : AcsResponse
	{

		private string orderParams;

		private string requestId;

		private bool? showDiscount;

		private float? tradeMaxRCUAmount;

		private float? tradeMinRCUAmount;

		private List<DescribePrice_Rule> rules;

		private DescribePrice_PriceInfo priceInfo;

		private DescribePrice_ServerlessPrice serverlessPrice;

		[JsonProperty(PropertyName = "OrderParams")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "ShowDiscount")]
		public bool? ShowDiscount
		{
			get
			{
				return showDiscount;
			}
			set	
			{
				showDiscount = value;
			}
		}

		[JsonProperty(PropertyName = "TradeMaxRCUAmount")]
		public float? TradeMaxRCUAmount
		{
			get
			{
				return tradeMaxRCUAmount;
			}
			set	
			{
				tradeMaxRCUAmount = value;
			}
		}

		[JsonProperty(PropertyName = "TradeMinRCUAmount")]
		public float? TradeMinRCUAmount
		{
			get
			{
				return tradeMinRCUAmount;
			}
			set	
			{
				tradeMinRCUAmount = value;
			}
		}

		[JsonProperty(PropertyName = "Rules")]
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

		[JsonProperty(PropertyName = "PriceInfo")]
		public DescribePrice_PriceInfo PriceInfo
		{
			get
			{
				return priceInfo;
			}
			set	
			{
				priceInfo = value;
			}
		}

		[JsonProperty(PropertyName = "ServerlessPrice")]
		public DescribePrice_ServerlessPrice ServerlessPrice
		{
			get
			{
				return serverlessPrice;
			}
			set	
			{
				serverlessPrice = value;
			}
		}

		public class DescribePrice_Rule
		{

			private string name;

			private string description;

			private long? ruleId;

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

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "RuleId")]
			public long? RuleId
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

		public class DescribePrice_PriceInfo
		{

			private float? originalPrice;

			private float? discountPrice;

			private string currency;

			private float? tradePrice;

			private float? tradeMinRCUAmount;

			private float? tradeMaxRCUAmount;

			private string orderLines;

			private List<DescribePrice_Coupon> coupons;

			private List<string> ruleIds;

			private DescribePrice_ActivityInfo activityInfo;

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

			[JsonProperty(PropertyName = "TradeMinRCUAmount")]
			public float? TradeMinRCUAmount
			{
				get
				{
					return tradeMinRCUAmount;
				}
				set	
				{
					tradeMinRCUAmount = value;
				}
			}

			[JsonProperty(PropertyName = "TradeMaxRCUAmount")]
			public float? TradeMaxRCUAmount
			{
				get
				{
					return tradeMaxRCUAmount;
				}
				set	
				{
					tradeMaxRCUAmount = value;
				}
			}

			[JsonProperty(PropertyName = "OrderLines")]
			public string OrderLines
			{
				get
				{
					return orderLines;
				}
				set	
				{
					orderLines = value;
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

			[JsonProperty(PropertyName = "RuleIds")]
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

			[JsonProperty(PropertyName = "ActivityInfo")]
			public DescribePrice_ActivityInfo ActivityInfo
			{
				get
				{
					return activityInfo;
				}
				set	
				{
					activityInfo = value;
				}
			}

			public class DescribePrice_Coupon
			{

				private string isSelected;

				private string couponNo;

				private string name;

				private string description;

				[JsonProperty(PropertyName = "IsSelected")]
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

				[JsonProperty(PropertyName = "CouponNo")]
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

				[JsonProperty(PropertyName = "Description")]
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
			}

			public class DescribePrice_ActivityInfo
			{

				private string checkErrMsg;

				private string errorCode;

				private string success;

				[JsonProperty(PropertyName = "CheckErrMsg")]
				public string CheckErrMsg
				{
					get
					{
						return checkErrMsg;
					}
					set	
					{
						checkErrMsg = value;
					}
				}

				[JsonProperty(PropertyName = "ErrorCode")]
				public string ErrorCode
				{
					get
					{
						return errorCode;
					}
					set	
					{
						errorCode = value;
					}
				}

				[JsonProperty(PropertyName = "Success")]
				public string Success
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
			}
		}

		public class DescribePrice_ServerlessPrice
		{

			private float? totalOriginalMinAmount;

			private float? totalOriginalMaxAmount;

			private float? rCUOriginalMinAmount;

			private float? rCUOriginalMaxAmount;

			private float? rCUDiscountMinAmount;

			private float? rCUDiscountMaxAmount;

			private float? tradeMinRCUAmount;

			private float? tradeMaxRCUAmount;

			private float? storageOriginalAmount;

			private float? storageDiscountAmount;

			[JsonProperty(PropertyName = "TotalOriginalMinAmount")]
			public float? TotalOriginalMinAmount
			{
				get
				{
					return totalOriginalMinAmount;
				}
				set	
				{
					totalOriginalMinAmount = value;
				}
			}

			[JsonProperty(PropertyName = "TotalOriginalMaxAmount")]
			public float? TotalOriginalMaxAmount
			{
				get
				{
					return totalOriginalMaxAmount;
				}
				set	
				{
					totalOriginalMaxAmount = value;
				}
			}

			[JsonProperty(PropertyName = "RCUOriginalMinAmount")]
			public float? RCUOriginalMinAmount
			{
				get
				{
					return rCUOriginalMinAmount;
				}
				set	
				{
					rCUOriginalMinAmount = value;
				}
			}

			[JsonProperty(PropertyName = "RCUOriginalMaxAmount")]
			public float? RCUOriginalMaxAmount
			{
				get
				{
					return rCUOriginalMaxAmount;
				}
				set	
				{
					rCUOriginalMaxAmount = value;
				}
			}

			[JsonProperty(PropertyName = "RCUDiscountMinAmount")]
			public float? RCUDiscountMinAmount
			{
				get
				{
					return rCUDiscountMinAmount;
				}
				set	
				{
					rCUDiscountMinAmount = value;
				}
			}

			[JsonProperty(PropertyName = "RCUDiscountMaxAmount")]
			public float? RCUDiscountMaxAmount
			{
				get
				{
					return rCUDiscountMaxAmount;
				}
				set	
				{
					rCUDiscountMaxAmount = value;
				}
			}

			[JsonProperty(PropertyName = "TradeMinRCUAmount")]
			public float? TradeMinRCUAmount
			{
				get
				{
					return tradeMinRCUAmount;
				}
				set	
				{
					tradeMinRCUAmount = value;
				}
			}

			[JsonProperty(PropertyName = "TradeMaxRCUAmount")]
			public float? TradeMaxRCUAmount
			{
				get
				{
					return tradeMaxRCUAmount;
				}
				set	
				{
					tradeMaxRCUAmount = value;
				}
			}

			[JsonProperty(PropertyName = "StorageOriginalAmount")]
			public float? StorageOriginalAmount
			{
				get
				{
					return storageOriginalAmount;
				}
				set	
				{
					storageOriginalAmount = value;
				}
			}

			[JsonProperty(PropertyName = "StorageDiscountAmount")]
			public float? StorageDiscountAmount
			{
				get
				{
					return storageDiscountAmount;
				}
				set	
				{
					storageDiscountAmount = value;
				}
			}
		}
	}
}
