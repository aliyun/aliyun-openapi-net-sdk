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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeInstanceModificationPriceResponseUnmarshaller
    {
        public static DescribeInstanceModificationPriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceModificationPriceResponse describeInstanceModificationPriceResponse = new DescribeInstanceModificationPriceResponse();

			describeInstanceModificationPriceResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceModificationPriceResponse.RequestId = _ctx.StringValue("DescribeInstanceModificationPrice.RequestId");

			DescribeInstanceModificationPriceResponse.DescribeInstanceModificationPrice_PriceInfo priceInfo = new DescribeInstanceModificationPriceResponse.DescribeInstanceModificationPrice_PriceInfo();

			DescribeInstanceModificationPriceResponse.DescribeInstanceModificationPrice_PriceInfo.DescribeInstanceModificationPrice_Price price = new DescribeInstanceModificationPriceResponse.DescribeInstanceModificationPrice_PriceInfo.DescribeInstanceModificationPrice_Price();
			price.OriginalPrice = _ctx.FloatValue("DescribeInstanceModificationPrice.PriceInfo.Price.OriginalPrice");
			price.DiscountPrice = _ctx.FloatValue("DescribeInstanceModificationPrice.PriceInfo.Price.DiscountPrice");
			price.TradePrice = _ctx.FloatValue("DescribeInstanceModificationPrice.PriceInfo.Price.TradePrice");
			price.Currency = _ctx.StringValue("DescribeInstanceModificationPrice.PriceInfo.Price.Currency");
			priceInfo.Price = price;

			List<DescribeInstanceModificationPriceResponse.DescribeInstanceModificationPrice_PriceInfo.DescribeInstanceModificationPrice_Rule> priceInfo_rules = new List<DescribeInstanceModificationPriceResponse.DescribeInstanceModificationPrice_PriceInfo.DescribeInstanceModificationPrice_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceModificationPrice.PriceInfo.Rules.Length"); i++) {
				DescribeInstanceModificationPriceResponse.DescribeInstanceModificationPrice_PriceInfo.DescribeInstanceModificationPrice_Rule rule = new DescribeInstanceModificationPriceResponse.DescribeInstanceModificationPrice_PriceInfo.DescribeInstanceModificationPrice_Rule();
				rule.RuleId = _ctx.LongValue("DescribeInstanceModificationPrice.PriceInfo.Rules["+ i +"].RuleId");
				rule.Description = _ctx.StringValue("DescribeInstanceModificationPrice.PriceInfo.Rules["+ i +"].Description");

				priceInfo_rules.Add(rule);
			}
			priceInfo.Rules = priceInfo_rules;
			describeInstanceModificationPriceResponse.PriceInfo = priceInfo;
        
			return describeInstanceModificationPriceResponse;
        }
    }
}
