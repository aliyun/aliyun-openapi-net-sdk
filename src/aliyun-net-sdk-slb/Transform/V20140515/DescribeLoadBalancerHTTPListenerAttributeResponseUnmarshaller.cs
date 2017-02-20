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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeLoadBalancerHttpListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerHttpListenerAttributeResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLoadBalancerHttpListenerAttributeResponse describeLoadBalancerHttpListenerAttributeResponse = new DescribeLoadBalancerHttpListenerAttributeResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.RequestId"),
                ListenerPort = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.ListenerPort"),
                BackendServerPort = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.BackendServerPort"),
                Bandwidth = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.Bandwidth"),
                Status = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Status"),
                SecurityStatus = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.SecurityStatus"),
                XForwardedFor = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor"),
                Scheduler = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Scheduler"),
                StickySession = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.StickySession"),
                StickySessionType = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.StickySessionType"),
                CookieTimeout = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.CookieTimeout"),
                Cookie = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Cookie"),
                HealthCheck = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheck"),
                HealthCheckDomain = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckDomain"),
                HealthCheckUri = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckURI"),
                HealthyThreshold = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthyThreshold"),
                UnhealthyThreshold = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.UnhealthyThreshold"),
                HealthCheckTimeout = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckTimeout"),
                HealthCheckInterval = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckInterval"),
                HealthCheckConnectPort = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckConnectPort"),
                HealthCheckHttpCode = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckHttpCode"),
                MaxConnection = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.MaxConnection"),
                VServerGroupId = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.VServerGroupId")
            };
            return describeLoadBalancerHttpListenerAttributeResponse;
        }
    }
}