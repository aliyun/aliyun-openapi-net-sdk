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
        public static DescribeRuleAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRuleAttributeResponse describeRuleAttributeResponse = new DescribeRuleAttributeResponse();

			describeRuleAttributeResponse.HttpResponse = context.HttpResponse;
			describeRuleAttributeResponse.RuleId = context.StringValue("DescribeRuleAttribute.RuleId");
			describeRuleAttributeResponse.RequestId = context.StringValue("DescribeRuleAttribute.RequestId");
			describeRuleAttributeResponse.RuleName = context.StringValue("DescribeRuleAttribute.RuleName");
			describeRuleAttributeResponse.LoadBalancerId = context.StringValue("DescribeRuleAttribute.LoadBalancerId");
			describeRuleAttributeResponse.ListenerPort = context.StringValue("DescribeRuleAttribute.ListenerPort");
			describeRuleAttributeResponse.Domain = context.StringValue("DescribeRuleAttribute.Domain");
			describeRuleAttributeResponse.Url = context.StringValue("DescribeRuleAttribute.Url");
			describeRuleAttributeResponse.VServerGroupId = context.StringValue("DescribeRuleAttribute.VServerGroupId");
			describeRuleAttributeResponse.ListenerSync = context.StringValue("DescribeRuleAttribute.ListenerSync");
			describeRuleAttributeResponse.Scheduler = context.StringValue("DescribeRuleAttribute.Scheduler");
			describeRuleAttributeResponse.StickySession = context.StringValue("DescribeRuleAttribute.StickySession");
			describeRuleAttributeResponse.StickySessionType = context.StringValue("DescribeRuleAttribute.StickySessionType");
			describeRuleAttributeResponse.CookieTimeout = context.IntegerValue("DescribeRuleAttribute.CookieTimeout");
			describeRuleAttributeResponse.Cookie = context.StringValue("DescribeRuleAttribute.Cookie");
			describeRuleAttributeResponse.HealthCheck = context.StringValue("DescribeRuleAttribute.HealthCheck");
			describeRuleAttributeResponse.HealthCheckDomain = context.StringValue("DescribeRuleAttribute.HealthCheckDomain");
			describeRuleAttributeResponse.HealthCheckURI = context.StringValue("DescribeRuleAttribute.HealthCheckURI");
			describeRuleAttributeResponse.HealthyThreshold = context.IntegerValue("DescribeRuleAttribute.HealthyThreshold");
			describeRuleAttributeResponse.UnhealthyThreshold = context.IntegerValue("DescribeRuleAttribute.UnhealthyThreshold");
			describeRuleAttributeResponse.HealthCheckTimeout = context.IntegerValue("DescribeRuleAttribute.HealthCheckTimeout");
			describeRuleAttributeResponse.HealthCheckInterval = context.IntegerValue("DescribeRuleAttribute.HealthCheckInterval");
			describeRuleAttributeResponse.HealthCheckConnectPort = context.IntegerValue("DescribeRuleAttribute.HealthCheckConnectPort");
			describeRuleAttributeResponse.HealthCheckHttpCode = context.StringValue("DescribeRuleAttribute.HealthCheckHttpCode");
        
			return describeRuleAttributeResponse;
        }
    }
}
