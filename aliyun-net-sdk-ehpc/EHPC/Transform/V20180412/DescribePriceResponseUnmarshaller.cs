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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20180412;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class DescribePriceResponseUnmarshaller
    {
        public static DescribePriceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePriceResponse describePriceResponse = new DescribePriceResponse();

			describePriceResponse.HttpResponse = context.HttpResponse;
			describePriceResponse.RequestId = context.StringValue("DescribePrice.RequestId");
			describePriceResponse.TotalTradePrice = context.FloatValue("DescribePrice.TotalTradePrice");

			List<DescribePriceResponse.DescribePrice_PriceInfo> describePriceResponse_prices = new List<DescribePriceResponse.DescribePrice_PriceInfo>();
			for (int i = 0; i < context.Length("DescribePrice.Prices.Length"); i++) {
				DescribePriceResponse.DescribePrice_PriceInfo priceInfo = new DescribePriceResponse.DescribePrice_PriceInfo();
				priceInfo.NodeType = context.StringValue("DescribePrice.Prices["+ i +"].NodeType");
				priceInfo.OriginalPrice = context.FloatValue("DescribePrice.Prices["+ i +"].OriginalPrice");
				priceInfo.TradePrice = context.FloatValue("DescribePrice.Prices["+ i +"].TradePrice");
				priceInfo.Currency = context.StringValue("DescribePrice.Prices["+ i +"].Currency");

				describePriceResponse_prices.Add(priceInfo);
			}
			describePriceResponse.Prices = describePriceResponse_prices;
        
			return describePriceResponse;
        }
    }
}