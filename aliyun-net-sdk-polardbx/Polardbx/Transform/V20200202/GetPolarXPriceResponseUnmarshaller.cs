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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class GetPolarXPriceResponseUnmarshaller
    {
        public static GetPolarXPriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPolarXPriceResponse getPolarXPriceResponse = new GetPolarXPriceResponse();

			getPolarXPriceResponse.HttpResponse = _ctx.HttpResponse;
			getPolarXPriceResponse.RequestId = _ctx.StringValue("GetPolarXPrice.RequestId");

			List<GetPolarXPriceResponse.GetPolarXPrice_OrderPrice> getPolarXPriceResponse_orderPriceList = new List<GetPolarXPriceResponse.GetPolarXPrice_OrderPrice>();
			for (int i = 0; i < _ctx.Length("GetPolarXPrice.OrderPriceList.Length"); i++) {
				GetPolarXPriceResponse.GetPolarXPrice_OrderPrice orderPrice = new GetPolarXPriceResponse.GetPolarXPrice_OrderPrice();
				orderPrice.DBInstanceName = _ctx.StringValue("GetPolarXPrice.OrderPriceList["+ i +"].DBInstanceName");
				orderPrice.TotalCostAmount = _ctx.StringValue("GetPolarXPrice.OrderPriceList["+ i +"].TotalCostAmount");
				orderPrice.DiscountAmount = _ctx.StringValue("GetPolarXPrice.OrderPriceList["+ i +"].DiscountAmount");
				orderPrice.TradeAmount = _ctx.StringValue("GetPolarXPrice.OrderPriceList["+ i +"].TradeAmount");
				orderPrice.OriginalAmount = _ctx.StringValue("GetPolarXPrice.OrderPriceList["+ i +"].OriginalAmount");
				orderPrice.PayType = _ctx.StringValue("GetPolarXPrice.OrderPriceList["+ i +"].PayType");

				List<GetPolarXPriceResponse.GetPolarXPrice_OrderPrice.GetPolarXPrice_Rule> orderPrice_rules = new List<GetPolarXPriceResponse.GetPolarXPrice_OrderPrice.GetPolarXPrice_Rule>();
				for (int j = 0; j < _ctx.Length("GetPolarXPrice.OrderPriceList["+ i +"].Rules.Length"); j++) {
					GetPolarXPriceResponse.GetPolarXPrice_OrderPrice.GetPolarXPrice_Rule rule = new GetPolarXPriceResponse.GetPolarXPrice_OrderPrice.GetPolarXPrice_Rule();
					rule.RuleDescId = _ctx.LongValue("GetPolarXPrice.OrderPriceList["+ i +"].Rules["+ j +"].RuleDescId");
					rule.Name = _ctx.StringValue("GetPolarXPrice.OrderPriceList["+ i +"].Rules["+ j +"].Name");
					rule.Title = _ctx.StringValue("GetPolarXPrice.OrderPriceList["+ i +"].Rules["+ j +"].Title");

					orderPrice_rules.Add(rule);
				}
				orderPrice.Rules = orderPrice_rules;

				getPolarXPriceResponse_orderPriceList.Add(orderPrice);
			}
			getPolarXPriceResponse.OrderPriceList = getPolarXPriceResponse_orderPriceList;
        
			return getPolarXPriceResponse;
        }
    }
}
