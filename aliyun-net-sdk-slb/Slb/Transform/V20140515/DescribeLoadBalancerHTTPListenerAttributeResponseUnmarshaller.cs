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
    public class DescribeLoadBalancerHTTPListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerHTTPListenerAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLoadBalancerHTTPListenerAttributeResponse describeLoadBalancerHTTPListenerAttributeResponse = new DescribeLoadBalancerHTTPListenerAttributeResponse();

			describeLoadBalancerHTTPListenerAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeLoadBalancerHTTPListenerAttributeResponse.RequestId = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.RequestId");
			describeLoadBalancerHTTPListenerAttributeResponse.ListenerPort = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.ListenerPort");
			describeLoadBalancerHTTPListenerAttributeResponse.BackendServerPort = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.BackendServerPort");
			describeLoadBalancerHTTPListenerAttributeResponse.Bandwidth = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.Bandwidth");
			describeLoadBalancerHTTPListenerAttributeResponse.Status = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Status");
			describeLoadBalancerHTTPListenerAttributeResponse.SecurityStatus = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.SecurityStatus");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor");
			describeLoadBalancerHTTPListenerAttributeResponse.Scheduler = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Scheduler");
			describeLoadBalancerHTTPListenerAttributeResponse.StickySession = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.StickySession");
			describeLoadBalancerHTTPListenerAttributeResponse.StickySessionType = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.StickySessionType");
			describeLoadBalancerHTTPListenerAttributeResponse.CookieTimeout = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.CookieTimeout");
			describeLoadBalancerHTTPListenerAttributeResponse.Cookie = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Cookie");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheck = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheck");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckType = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckType");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckDomain = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckDomain");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckURI = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckURI");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthyThreshold");
			describeLoadBalancerHTTPListenerAttributeResponse.UnhealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.UnhealthyThreshold");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckTimeout = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckTimeout");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckInterval = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckInterval");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckConnectPort = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckConnectPort");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckHttpCode = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckHttpCode");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckMethod = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckMethod");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckHttpVersion = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckHttpVersion");
			describeLoadBalancerHTTPListenerAttributeResponse.MaxConnection = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.MaxConnection");
			describeLoadBalancerHTTPListenerAttributeResponse.VServerGroupId = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.VServerGroupId");
			describeLoadBalancerHTTPListenerAttributeResponse.Gzip = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Gzip");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor_SLBIP = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor_SLBIP");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor_SLBID = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor_SLBID");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor_proto = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor_proto");
			describeLoadBalancerHTTPListenerAttributeResponse.AclId = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.AclId");
			describeLoadBalancerHTTPListenerAttributeResponse.AclType = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.AclType");
			describeLoadBalancerHTTPListenerAttributeResponse.AclStatus = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.AclStatus");
			describeLoadBalancerHTTPListenerAttributeResponse.VpcIds = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.VpcIds");
			describeLoadBalancerHTTPListenerAttributeResponse.ListenerForward = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.ListenerForward");
			describeLoadBalancerHTTPListenerAttributeResponse.ForwardPort = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.ForwardPort");
			describeLoadBalancerHTTPListenerAttributeResponse.RequestTimeout = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.RequestTimeout");
			describeLoadBalancerHTTPListenerAttributeResponse.IdleTimeout = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.IdleTimeout");
			describeLoadBalancerHTTPListenerAttributeResponse.Description = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Description");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor_SLBPORT = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor_SLBPORT");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor_ClientSrcPort = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor_ClientSrcPort");
			describeLoadBalancerHTTPListenerAttributeResponse.ForwardCode = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.ForwardCode");

			List<string> describeLoadBalancerHTTPListenerAttributeResponse_aclIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerHTTPListenerAttribute.AclIds.Length"); i++) {
				describeLoadBalancerHTTPListenerAttributeResponse_aclIds.Add(_ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.AclIds["+ i +"]"));
			}
			describeLoadBalancerHTTPListenerAttributeResponse.AclIds = describeLoadBalancerHTTPListenerAttributeResponse_aclIds;

			List<DescribeLoadBalancerHTTPListenerAttributeResponse.DescribeLoadBalancerHTTPListenerAttribute_Rule> describeLoadBalancerHTTPListenerAttributeResponse_rules = new List<DescribeLoadBalancerHTTPListenerAttributeResponse.DescribeLoadBalancerHTTPListenerAttribute_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerHTTPListenerAttribute.Rules.Length"); i++) {
				DescribeLoadBalancerHTTPListenerAttributeResponse.DescribeLoadBalancerHTTPListenerAttribute_Rule rule = new DescribeLoadBalancerHTTPListenerAttributeResponse.DescribeLoadBalancerHTTPListenerAttribute_Rule();
				rule.RuleId = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Rules["+ i +"].RuleId");
				rule.RuleName = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Rules["+ i +"].RuleName");
				rule.Domain = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Rules["+ i +"].Domain");
				rule.Url = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Rules["+ i +"].Url");
				rule.VServerGroupId = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Rules["+ i +"].VServerGroupId");

				describeLoadBalancerHTTPListenerAttributeResponse_rules.Add(rule);
			}
			describeLoadBalancerHTTPListenerAttributeResponse.Rules = describeLoadBalancerHTTPListenerAttributeResponse_rules;
        
			return describeLoadBalancerHTTPListenerAttributeResponse;
        }
    }
}
