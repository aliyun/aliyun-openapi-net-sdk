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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeConfigurationPriceResponseUnmarshaller
    {
        public static DescribeConfigurationPriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeConfigurationPriceResponse describeConfigurationPriceResponse = new DescribeConfigurationPriceResponse();

			describeConfigurationPriceResponse.HttpResponse = _ctx.HttpResponse;
			describeConfigurationPriceResponse.RequestId = _ctx.StringValue("DescribeConfigurationPrice.RequestId");
			describeConfigurationPriceResponse.Message = _ctx.StringValue("DescribeConfigurationPrice.Message");
			describeConfigurationPriceResponse.TraceId = _ctx.StringValue("DescribeConfigurationPrice.TraceId");
			describeConfigurationPriceResponse.ErrorCode = _ctx.StringValue("DescribeConfigurationPrice.ErrorCode");
			describeConfigurationPriceResponse.Code = _ctx.StringValue("DescribeConfigurationPrice.Code");
			describeConfigurationPriceResponse.Success = _ctx.BooleanValue("DescribeConfigurationPrice.Success");

			DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data data = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data();

			DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_BagUsage bagUsage = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_BagUsage();
			bagUsage.Cpu = _ctx.FloatValue("DescribeConfigurationPrice.Data.BagUsage.Cpu");
			bagUsage.Mem = _ctx.FloatValue("DescribeConfigurationPrice.Data.BagUsage.Mem");
			data.BagUsage = bagUsage;

			DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_Order order = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_Order();
			order.OriginalAmount = _ctx.FloatValue("DescribeConfigurationPrice.Data.Order.OriginalAmount");
			order.DiscountAmount = _ctx.FloatValue("DescribeConfigurationPrice.Data.Order.DiscountAmount");
			order.TradeAmount = _ctx.FloatValue("DescribeConfigurationPrice.Data.Order.TradeAmount");

			List<string> order_ruleIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeConfigurationPrice.Data.Order.RuleIds.Length"); i++) {
				order_ruleIds.Add(_ctx.StringValue("DescribeConfigurationPrice.Data.Order.RuleIds["+ i +"]"));
			}
			order.RuleIds = order_ruleIds;
			data.Order = order;

			List<DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_Rule> data_rules = new List<DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeConfigurationPrice.Data.Rules.Length"); i++) {
				DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_Rule rule = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_Rule();
				rule.RuleDescId = _ctx.LongValue("DescribeConfigurationPrice.Data.Rules["+ i +"].RuleDescId");
				rule.Name = _ctx.StringValue("DescribeConfigurationPrice.Data.Rules["+ i +"].Name");

				data_rules.Add(rule);
			}
			data.Rules = data_rules;
			describeConfigurationPriceResponse.Data = data;
        
			return describeConfigurationPriceResponse;
        }
    }
}
