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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryTrademarkPriceResponseUnmarshaller
    {
        public static QueryTrademarkPriceResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTrademarkPriceResponse queryTrademarkPriceResponse = new QueryTrademarkPriceResponse();

			queryTrademarkPriceResponse.HttpResponse = context.HttpResponse;
			queryTrademarkPriceResponse.RequestId = context.StringValue("QueryTrademarkPrice.RequestId");
			queryTrademarkPriceResponse.DiscountPrice = context.FloatValue("QueryTrademarkPrice.DiscountPrice");
			queryTrademarkPriceResponse.OriginalPrice = context.FloatValue("QueryTrademarkPrice.OriginalPrice");
			queryTrademarkPriceResponse.TradePrice = context.FloatValue("QueryTrademarkPrice.TradePrice");
			queryTrademarkPriceResponse.Currency = context.StringValue("QueryTrademarkPrice.Currency");

			List<QueryTrademarkPriceResponse.QueryTrademarkPrice_PricesItem> queryTrademarkPriceResponse_prices = new List<QueryTrademarkPriceResponse.QueryTrademarkPrice_PricesItem>();
			for (int i = 0; i < context.Length("QueryTrademarkPrice.Prices.Length"); i++) {
				QueryTrademarkPriceResponse.QueryTrademarkPrice_PricesItem pricesItem = new QueryTrademarkPriceResponse.QueryTrademarkPrice_PricesItem();
				pricesItem.ClassificationCode = context.StringValue("QueryTrademarkPrice.Prices["+ i +"].ClassificationCode");
				pricesItem.DiscountPrice = context.FloatValue("QueryTrademarkPrice.Prices["+ i +"].DiscountPrice");
				pricesItem.OriginalPrice = context.FloatValue("QueryTrademarkPrice.Prices["+ i +"].OriginalPrice");
				pricesItem.TradePrice = context.FloatValue("QueryTrademarkPrice.Prices["+ i +"].TradePrice");
				pricesItem.Currency = context.StringValue("QueryTrademarkPrice.Prices["+ i +"].Currency");

				queryTrademarkPriceResponse_prices.Add(pricesItem);
			}
			queryTrademarkPriceResponse.Prices = queryTrademarkPriceResponse_prices;
        
			return queryTrademarkPriceResponse;
        }
    }
}
