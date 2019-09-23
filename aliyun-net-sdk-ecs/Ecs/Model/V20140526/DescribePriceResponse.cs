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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribePriceResponse : AcsResponse
	{

		private string requestId;

		private DescribePrice_PriceInfo priceInfo;

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

		public class DescribePrice_PriceInfo
		{

			private List<DescribePrice_Rule> rules;

			private DescribePrice_Price price;

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

			public DescribePrice_Price Price
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

			public class DescribePrice_Rule
			{

				private long? ruleId;

				private string description;

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

			public class DescribePrice_Price
			{

				private float? originalPrice;

				private float? discountPrice;

				private float? tradePrice;

				private float? reservedInstanceHourPrice;

				private string currency;

				private List<DescribePrice_ResourcePriceModel> detailInfos;

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

				public float? ReservedInstanceHourPrice
				{
					get
					{
						return reservedInstanceHourPrice;
					}
					set	
					{
						reservedInstanceHourPrice = value;
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

				public List<DescribePrice_ResourcePriceModel> DetailInfos
				{
					get
					{
						return detailInfos;
					}
					set	
					{
						detailInfos = value;
					}
				}

				public class DescribePrice_ResourcePriceModel
				{

					private string resource;

					private float? originalPrice;

					private float? discountPrice;

					private float? tradePrice;

					private List<DescribePrice_Rule1> subRules;

					public string Resource
					{
						get
						{
							return resource;
						}
						set	
						{
							resource = value;
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

					public List<DescribePrice_Rule1> SubRules
					{
						get
						{
							return subRules;
						}
						set	
						{
							subRules = value;
						}
					}

					public class DescribePrice_Rule1
					{

						private long? ruleId;

						private string description;

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
				}
			}
		}
	}
}
