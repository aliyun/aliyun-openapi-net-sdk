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

			DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_RequestPrice requestPrice = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_RequestPrice();

			DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_RequestPrice.DescribeConfigurationPrice_Order1 order1 = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_RequestPrice.DescribeConfigurationPrice_Order1();
			order1.OriginalAmount = _ctx.FloatValue("DescribeConfigurationPrice.Data.RequestPrice.Order.OriginalAmount");
			order1.DiscountAmount = _ctx.FloatValue("DescribeConfigurationPrice.Data.RequestPrice.Order.DiscountAmount");
			order1.TradeAmount = _ctx.FloatValue("DescribeConfigurationPrice.Data.RequestPrice.Order.TradeAmount");

			List<string> order1_ruleIds4 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeConfigurationPrice.Data.RequestPrice.Order.RuleIds.Length"); i++) {
				order1_ruleIds4.Add(_ctx.StringValue("DescribeConfigurationPrice.Data.RequestPrice.Order.RuleIds["+ i +"]"));
			}
			order1.RuleIds4 = order1_ruleIds4;
			requestPrice.Order1 = order1;

			List<DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_RequestPrice.DescribeConfigurationPrice_Rule3> requestPrice_rules2 = new List<DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_RequestPrice.DescribeConfigurationPrice_Rule3>();
			for (int i = 0; i < _ctx.Length("DescribeConfigurationPrice.Data.RequestPrice.Rules.Length"); i++) {
				DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_RequestPrice.DescribeConfigurationPrice_Rule3 rule3 = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_RequestPrice.DescribeConfigurationPrice_Rule3();
				rule3.RuleDescId = _ctx.LongValue("DescribeConfigurationPrice.Data.RequestPrice.Rules["+ i +"].RuleDescId");
				rule3.Name = _ctx.StringValue("DescribeConfigurationPrice.Data.RequestPrice.Rules["+ i +"].Name");

				requestPrice_rules2.Add(rule3);
			}
			requestPrice.Rules2 = requestPrice_rules2;
			data.RequestPrice = requestPrice;

			DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_TrafficPrice trafficPrice = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_TrafficPrice();

			DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_TrafficPrice.DescribeConfigurationPrice_Order5 order5 = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_TrafficPrice.DescribeConfigurationPrice_Order5();
			order5.OriginalAmount = _ctx.FloatValue("DescribeConfigurationPrice.Data.TrafficPrice.Order.OriginalAmount");
			order5.DiscountAmount = _ctx.FloatValue("DescribeConfigurationPrice.Data.TrafficPrice.Order.DiscountAmount");
			order5.TradeAmount = _ctx.FloatValue("DescribeConfigurationPrice.Data.TrafficPrice.Order.TradeAmount");

			List<string> order5_ruleIds8 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeConfigurationPrice.Data.TrafficPrice.Order.RuleIds.Length"); i++) {
				order5_ruleIds8.Add(_ctx.StringValue("DescribeConfigurationPrice.Data.TrafficPrice.Order.RuleIds["+ i +"]"));
			}
			order5.RuleIds8 = order5_ruleIds8;
			trafficPrice.Order5 = order5;

			List<DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_TrafficPrice.DescribeConfigurationPrice_Rule7> trafficPrice_rules6 = new List<DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_TrafficPrice.DescribeConfigurationPrice_Rule7>();
			for (int i = 0; i < _ctx.Length("DescribeConfigurationPrice.Data.TrafficPrice.Rules.Length"); i++) {
				DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_TrafficPrice.DescribeConfigurationPrice_Rule7 rule7 = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_TrafficPrice.DescribeConfigurationPrice_Rule7();
				rule7.RuleDescId = _ctx.FloatValue("DescribeConfigurationPrice.Data.TrafficPrice.Rules["+ i +"].RuleDescId");
				rule7.Name = _ctx.StringValue("DescribeConfigurationPrice.Data.TrafficPrice.Rules["+ i +"].Name");

				trafficPrice_rules6.Add(rule7);
			}
			trafficPrice.Rules6 = trafficPrice_rules6;
			data.TrafficPrice = trafficPrice;

			DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_CpuMemPrice cpuMemPrice = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_CpuMemPrice();

			DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_CpuMemPrice.DescribeConfigurationPrice_Order9 order9 = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_CpuMemPrice.DescribeConfigurationPrice_Order9();
			order9.OriginalAmount = _ctx.FloatValue("DescribeConfigurationPrice.Data.CpuMemPrice.Order.OriginalAmount");
			order9.DiscountAmount = _ctx.FloatValue("DescribeConfigurationPrice.Data.CpuMemPrice.Order.DiscountAmount");
			order9.TradeAmount = _ctx.FloatValue("DescribeConfigurationPrice.Data.CpuMemPrice.Order.TradeAmount");

			List<string> order9_ruleIds12 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeConfigurationPrice.Data.CpuMemPrice.Order.RuleIds.Length"); i++) {
				order9_ruleIds12.Add(_ctx.StringValue("DescribeConfigurationPrice.Data.CpuMemPrice.Order.RuleIds["+ i +"]"));
			}
			order9.RuleIds12 = order9_ruleIds12;
			cpuMemPrice.Order9 = order9;

			List<DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_CpuMemPrice.DescribeConfigurationPrice_Rule11> cpuMemPrice_rules10 = new List<DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_CpuMemPrice.DescribeConfigurationPrice_Rule11>();
			for (int i = 0; i < _ctx.Length("DescribeConfigurationPrice.Data.CpuMemPrice.Rules.Length"); i++) {
				DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_CpuMemPrice.DescribeConfigurationPrice_Rule11 rule11 = new DescribeConfigurationPriceResponse.DescribeConfigurationPrice_Data.DescribeConfigurationPrice_CpuMemPrice.DescribeConfigurationPrice_Rule11();
				rule11.RuleDescId = _ctx.FloatValue("DescribeConfigurationPrice.Data.CpuMemPrice.Rules["+ i +"].RuleDescId");
				rule11.Name = _ctx.StringValue("DescribeConfigurationPrice.Data.CpuMemPrice.Rules["+ i +"].Name");

				cpuMemPrice_rules10.Add(rule11);
			}
			cpuMemPrice.Rules10 = cpuMemPrice_rules10;
			data.CpuMemPrice = cpuMemPrice;

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
