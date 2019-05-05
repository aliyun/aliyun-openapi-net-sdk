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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeRulesResponseUnmarshaller
    {
        public static DescribeRulesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRulesResponse describeRulesResponse = new DescribeRulesResponse();

			describeRulesResponse.HttpResponse = context.HttpResponse;
			describeRulesResponse.RequestId = context.StringValue("DescribeRules.RequestId");

			List<DescribeRulesResponse.DescribeRules_Rule> describeRulesResponse_rules = new List<DescribeRulesResponse.DescribeRules_Rule>();
			for (int i = 0; i < context.Length("DescribeRules.Rules.Length"); i++) {
				DescribeRulesResponse.DescribeRules_Rule rule = new DescribeRulesResponse.DescribeRules_Rule();
				rule.RuleId = context.StringValue("DescribeRules.Rules["+ i +"].RuleId");
				rule.RuleName = context.StringValue("DescribeRules.Rules["+ i +"].RuleName");
				rule.Domain = context.StringValue("DescribeRules.Rules["+ i +"].Domain");
				rule.Url = context.StringValue("DescribeRules.Rules["+ i +"].Url");
				rule.VServerGroupId = context.StringValue("DescribeRules.Rules["+ i +"].VServerGroupId");
				rule.ListenerSync = context.StringValue("DescribeRules.Rules["+ i +"].ListenerSync");
				rule.Scheduler = context.StringValue("DescribeRules.Rules["+ i +"].Scheduler");
				rule.StickySession = context.StringValue("DescribeRules.Rules["+ i +"].StickySession");
				rule.StickySessionType = context.StringValue("DescribeRules.Rules["+ i +"].StickySessionType");
				rule.CookieTimeout = context.IntegerValue("DescribeRules.Rules["+ i +"].CookieTimeout");
				rule.Cookie = context.StringValue("DescribeRules.Rules["+ i +"].Cookie");
				rule.HealthCheck = context.StringValue("DescribeRules.Rules["+ i +"].HealthCheck");
				rule.HealthCheckDomain = context.StringValue("DescribeRules.Rules["+ i +"].HealthCheckDomain");
				rule.HealthCheckURI = context.StringValue("DescribeRules.Rules["+ i +"].HealthCheckURI");
				rule.HealthyThreshold = context.IntegerValue("DescribeRules.Rules["+ i +"].HealthyThreshold");
				rule.UnhealthyThreshold = context.IntegerValue("DescribeRules.Rules["+ i +"].UnhealthyThreshold");
				rule.HealthCheckTimeout = context.IntegerValue("DescribeRules.Rules["+ i +"].HealthCheckTimeout");
				rule.HealthCheckInterval = context.IntegerValue("DescribeRules.Rules["+ i +"].HealthCheckInterval");
				rule.HealthCheckConnectPort = context.IntegerValue("DescribeRules.Rules["+ i +"].HealthCheckConnectPort");
				rule.HealthCheckHttpCode = context.StringValue("DescribeRules.Rules["+ i +"].HealthCheckHttpCode");

				describeRulesResponse_rules.Add(rule);
			}
			describeRulesResponse.Rules = describeRulesResponse_rules;
        
			return describeRulesResponse;
        }
    }
}
