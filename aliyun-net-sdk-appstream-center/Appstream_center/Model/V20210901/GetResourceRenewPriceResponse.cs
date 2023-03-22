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

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
	public class GetResourceRenewPriceResponse : AcsResponse
	{

		private string requestId;

		private GetResourceRenewPrice_Data data;

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

		[JsonProperty(PropertyName = "Data")]
		public GetResourceRenewPrice_Data Data
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

		public class GetResourceRenewPrice_Data
		{

			private List<GetResourceRenewPrice_Rule> rules;

			private GetResourceRenewPrice_Price price;

			[JsonProperty(PropertyName = "Rules")]
			public List<GetResourceRenewPrice_Rule> Rules
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

			[JsonProperty(PropertyName = "Price")]
			public GetResourceRenewPrice_Price Price
			{
				get
				{
					return price;
				}
				set	
				{
					price = value;
				}
			}

			public class GetResourceRenewPrice_Rule
			{

				private long? ruleId;

				private string description;

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

			public class GetResourceRenewPrice_Price
			{

				private string originalPrice;

				private string discountPrice;

				private string tradePrice;

				private string currency;

				private List<GetResourceRenewPrice_Promotion> promotions;

				[JsonProperty(PropertyName = "OriginalPrice")]
				public string OriginalPrice
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
				public string DiscountPrice
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

				[JsonProperty(PropertyName = "TradePrice")]
				public string TradePrice
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

				[JsonProperty(PropertyName = "Promotions")]
				public List<GetResourceRenewPrice_Promotion> Promotions
				{
					get
					{
						return promotions;
					}
					set	
					{
						promotions = value;
					}
				}

				public class GetResourceRenewPrice_Promotion
				{

					private string optionCode;

					private string promotionId;

					private string promotionName;

					private string promotionDesc;

					private bool? selected;

					[JsonProperty(PropertyName = "OptionCode")]
					public string OptionCode
					{
						get
						{
							return optionCode;
						}
						set	
						{
							optionCode = value;
						}
					}

					[JsonProperty(PropertyName = "PromotionId")]
					public string PromotionId
					{
						get
						{
							return promotionId;
						}
						set	
						{
							promotionId = value;
						}
					}

					[JsonProperty(PropertyName = "PromotionName")]
					public string PromotionName
					{
						get
						{
							return promotionName;
						}
						set	
						{
							promotionName = value;
						}
					}

					[JsonProperty(PropertyName = "PromotionDesc")]
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

					[JsonProperty(PropertyName = "Selected")]
					public bool? Selected
					{
						get
						{
							return selected;
						}
						set	
						{
							selected = value;
						}
					}
				}
			}
		}
	}
}
