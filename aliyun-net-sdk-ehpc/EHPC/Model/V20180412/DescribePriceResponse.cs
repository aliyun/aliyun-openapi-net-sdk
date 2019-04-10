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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class DescribePriceResponse : AcsResponse
	{

		private string requestId;

		private float? totalTradePrice;

		private List<DescribePrice_PriceInfo> prices;

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

		public float? TotalTradePrice
		{
			get
			{
				return totalTradePrice;
			}
			set	
			{
				totalTradePrice = value;
			}
		}

		public List<DescribePrice_PriceInfo> Prices
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

		public class DescribePrice_PriceInfo
		{

			private string nodeType;

			private float? originalPrice;

			private float? tradePrice;

			private string currency;

			public string NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
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
