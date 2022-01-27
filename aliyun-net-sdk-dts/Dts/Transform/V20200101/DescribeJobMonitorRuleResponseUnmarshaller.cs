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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeJobMonitorRuleResponseUnmarshaller
    {
        public static DescribeJobMonitorRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeJobMonitorRuleResponse describeJobMonitorRuleResponse = new DescribeJobMonitorRuleResponse();

			describeJobMonitorRuleResponse.HttpResponse = _ctx.HttpResponse;
			describeJobMonitorRuleResponse.Code = _ctx.StringValue("DescribeJobMonitorRule.Code");
			describeJobMonitorRuleResponse.DtsJobId = _ctx.StringValue("DescribeJobMonitorRule.DtsJobId");
			describeJobMonitorRuleResponse.DynamicMessage = _ctx.StringValue("DescribeJobMonitorRule.DynamicMessage");
			describeJobMonitorRuleResponse.ErrCode = _ctx.StringValue("DescribeJobMonitorRule.ErrCode");
			describeJobMonitorRuleResponse.ErrMessage = _ctx.StringValue("DescribeJobMonitorRule.ErrMessage");
			describeJobMonitorRuleResponse.HttpStatusCode = _ctx.IntegerValue("DescribeJobMonitorRule.HttpStatusCode");
			describeJobMonitorRuleResponse.RequestId = _ctx.StringValue("DescribeJobMonitorRule.RequestId");
			describeJobMonitorRuleResponse.Success = _ctx.BooleanValue("DescribeJobMonitorRule.Success");

			List<DescribeJobMonitorRuleResponse.DescribeJobMonitorRule_MonitorRule> describeJobMonitorRuleResponse_monitorRules = new List<DescribeJobMonitorRuleResponse.DescribeJobMonitorRule_MonitorRule>();
			for (int i = 0; i < _ctx.Length("DescribeJobMonitorRule.MonitorRules.Length"); i++) {
				DescribeJobMonitorRuleResponse.DescribeJobMonitorRule_MonitorRule monitorRule = new DescribeJobMonitorRuleResponse.DescribeJobMonitorRule_MonitorRule();
				monitorRule.Phone = _ctx.StringValue("DescribeJobMonitorRule.MonitorRules["+ i +"].Phone");
				monitorRule.DelayRuleTime = _ctx.LongValue("DescribeJobMonitorRule.MonitorRules["+ i +"].DelayRuleTime");
				monitorRule.State = _ctx.StringValue("DescribeJobMonitorRule.MonitorRules["+ i +"].State");
				monitorRule.Type = _ctx.StringValue("DescribeJobMonitorRule.MonitorRules["+ i +"].Type");

				describeJobMonitorRuleResponse_monitorRules.Add(monitorRule);
			}
			describeJobMonitorRuleResponse.MonitorRules = describeJobMonitorRuleResponse_monitorRules;
        
			return describeJobMonitorRuleResponse;
        }
    }
}
