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
using Aliyun.Acs.Slb.Model.V20130221;

namespace Aliyun.Acs.Slb.Transform.V20130221
{
    public class DescribeLoadBalancerHTTPListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerHTTPListenerAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLoadBalancerHTTPListenerAttributeResponse describeLoadBalancerHTTPListenerAttributeResponse = new DescribeLoadBalancerHTTPListenerAttributeResponse();

			describeLoadBalancerHTTPListenerAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeLoadBalancerHTTPListenerAttributeResponse.Status = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Status");
			describeLoadBalancerHTTPListenerAttributeResponse.VServerGroupId = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.VServerGroupId");
			describeLoadBalancerHTTPListenerAttributeResponse.Cookie = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Cookie");
			describeLoadBalancerHTTPListenerAttributeResponse.Gzip = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Gzip");
			describeLoadBalancerHTTPListenerAttributeResponse.RequestId = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.RequestId");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckConnectPort = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckConnectPort");
			describeLoadBalancerHTTPListenerAttributeResponse.Bandwidth = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.Bandwidth");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckTimeout = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckTimeout");
			describeLoadBalancerHTTPListenerAttributeResponse.BackendServerPort = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.BackendServerPort");
			describeLoadBalancerHTTPListenerAttributeResponse.CookieTimeout = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.CookieTimeout");
			describeLoadBalancerHTTPListenerAttributeResponse.URI = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.URI");
			describeLoadBalancerHTTPListenerAttributeResponse.UnhealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.UnhealthyThreshold");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor_SLBID = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor_SLBID");
			describeLoadBalancerHTTPListenerAttributeResponse.SecurityStatus = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.SecurityStatus");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckHttpCode = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckHttpCode");
			describeLoadBalancerHTTPListenerAttributeResponse.Domain = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Domain");
			describeLoadBalancerHTTPListenerAttributeResponse.MaxConnection = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.MaxConnection");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor");
			describeLoadBalancerHTTPListenerAttributeResponse.ListenerPort = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.ListenerPort");
			describeLoadBalancerHTTPListenerAttributeResponse.StickySessionType = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.StickySessionType");
			describeLoadBalancerHTTPListenerAttributeResponse.Scheduler = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Scheduler");
			describeLoadBalancerHTTPListenerAttributeResponse.Interval = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.Interval");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthyThreshold");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor_proto = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor_proto");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor_SLBIP = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor_SLBIP");
			describeLoadBalancerHTTPListenerAttributeResponse.StickySession = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.StickySession");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheck = _ctx.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheck");
        
			return describeLoadBalancerHTTPListenerAttributeResponse;
        }
    }
}
