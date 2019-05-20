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

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class QueryTrademarkPriceResponse : AcsResponse
	{

		private string requestId;

		private float? discountPrice;

		private float? originalPrice;

		private float? tradePrice;

		private string currency;

		private List<QueryTrademarkPrice_PricesItem> prices;

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

		public List<QueryTrademarkPrice_PricesItem> Prices
		{
			get
			{
				return prices;
			}
			set	
			{
				prices = value;
			}
		}

		public class QueryTrademarkPrice_PricesItem
		{

			private string classificationCode;

			private float? discountPrice;

			private float? originalPrice;

			private float? tradePrice;

			private string currency;

			public string ClassificationCode
			{
				get
				{
					return classificationCode;
				}
				set	
				{
					classificationCode = value;
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
		}
	}
}
