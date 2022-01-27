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
    public class DescribeRuleAttributeResponseUnmarshaller
    {
        public static DescribeRuleAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRuleAttributeResponse describeRuleAttributeResponse = new DescribeRuleAttributeResponse();

			describeRuleAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeRuleAttributeResponse.RuleId = _ctx.StringValue("DescribeRuleAttribute.RuleId");
			describeRuleAttributeResponse.RequestId = _ctx.StringValue("DescribeRuleAttribute.RequestId");
			describeRuleAttributeResponse.RuleName = _ctx.StringValue("DescribeRuleAttribute.RuleName");
			describeRuleAttributeResponse.LoadBalancerId = _ctx.StringValue("DescribeRuleAttribute.LoadBalancerId");
			describeRuleAttributeResponse.ListenerPort = _ctx.StringValue("DescribeRuleAttribute.ListenerPort");
			describeRuleAttributeResponse.Domain = _ctx.StringValue("DescribeRuleAttribute.Domain");
			describeRuleAttributeResponse.Url = _ctx.StringValue("DescribeRuleAttribute.Url");
			describeRuleAttributeResponse.VServerGroupId = _ctx.StringValue("DescribeRuleAttribute.VServerGroupId");
			describeRuleAttributeResponse.ListenerSync = _ctx.StringValue("DescribeRuleAttribute.ListenerSync");
			describeRuleAttributeResponse.Scheduler = _ctx.StringValue("DescribeRuleAttribute.Scheduler");
			describeRuleAttributeResponse.StickySession = _ctx.StringValue("DescribeRuleAttribute.StickySession");
			describeRuleAttributeResponse.StickySessionType = _ctx.StringValue("DescribeRuleAttribute.StickySessionType");
			describeRuleAttributeResponse.CookieTimeout = _ctx.IntegerValue("DescribeRuleAttribute.CookieTimeout");
			describeRuleAttributeResponse.Cookie = _ctx.StringValue("DescribeRuleAttribute.Cookie");
			describeRuleAttributeResponse.HealthCheck = _ctx.StringValue("DescribeRuleAttribute.HealthCheck");
			describeRuleAttributeResponse.HealthCheckDomain = _ctx.StringValue("DescribeRuleAttribute.HealthCheckDomain");
			describeRuleAttributeResponse.HealthCheckURI = _ctx.StringValue("DescribeRuleAttribute.HealthCheckURI");
			describeRuleAttributeResponse.HealthyThreshold = _ctx.IntegerValue("DescribeRuleAttribute.HealthyThreshold");
			describeRuleAttributeResponse.UnhealthyThreshold = _ctx.IntegerValue("DescribeRuleAttribute.UnhealthyThreshold");
			describeRuleAttributeResponse.HealthCheckTimeout = _ctx.IntegerValue("DescribeRuleAttribute.HealthCheckTimeout");
			describeRuleAttributeResponse.HealthCheckInterval = _ctx.IntegerValue("DescribeRuleAttribute.HealthCheckInterval");
			describeRuleAttributeResponse.HealthCheckConnectPort = _ctx.IntegerValue("DescribeRuleAttribute.HealthCheckConnectPort");
			describeRuleAttributeResponse.HealthCheckHttpCode = _ctx.StringValue("DescribeRuleAttribute.HealthCheckHttpCode");
        
			return describeRuleAttributeResponse;
        }
    }
}
