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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class DescribePriceResponseUnmarshaller
    {
        public static DescribePriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePriceResponse describePriceResponse = new DescribePriceResponse();

			describePriceResponse.HttpResponse = _ctx.HttpResponse;
			describePriceResponse.RequestId = _ctx.StringValue("DescribePrice.RequestId");
			describePriceResponse.TotalTradePrice = _ctx.FloatValue("DescribePrice.TotalTradePrice");

			List<DescribePriceResponse.DescribePrice_PriceInfo> describePriceResponse_prices = new List<DescribePriceResponse.DescribePrice_PriceInfo>();
			for (int i = 0; i < _ctx.Length("DescribePrice.Prices.Length"); i++) {
				DescribePriceResponse.DescribePrice_PriceInfo priceInfo = new DescribePriceResponse.DescribePrice_PriceInfo();
				priceInfo.NodeType = _ctx.StringValue("DescribePrice.Prices["+ i +"].NodeType");
				priceInfo.OriginalPrice = _ctx.FloatValue("DescribePrice.Prices["+ i +"].OriginalPrice");
				priceInfo.TradePrice = _ctx.FloatValue("DescribePrice.Prices["+ i +"].TradePrice");
				priceInfo.Currency = _ctx.StringValue("DescribePrice.Prices["+ i +"].Currency");

				describePriceResponse_prices.Add(priceInfo);
			}
			describePriceResponse.Prices = describePriceResponse_prices;
        
			return describePriceResponse;
        }
    }
}
