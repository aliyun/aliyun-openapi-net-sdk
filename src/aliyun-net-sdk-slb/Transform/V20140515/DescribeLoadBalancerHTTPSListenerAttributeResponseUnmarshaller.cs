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
    public class DescribeLoadBalancerHttpsListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerHttpsListenerAttributeResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLoadBalancerHttpsListenerAttributeResponse describeLoadBalancerHttpsListenerAttributeResponse = new DescribeLoadBalancerHttpsListenerAttributeResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.RequestId"),
                ListenerPort = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.ListenerPort"),
                BackendServerPort = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.BackendServerPort"),
                Bandwidth = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.Bandwidth"),
                Status = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Status"),
                SecurityStatus = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.SecurityStatus"),
                XForwardedFor = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor"),
                Scheduler = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Scheduler"),
                StickySession = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.StickySession"),
                StickySessionType = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.StickySessionType"),
                CookieTimeout = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.CookieTimeout"),
                Cookie = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Cookie"),
                HealthCheck = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheck"),
                HealthCheckDomain = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckDomain"),
                HealthCheckUri = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckURI"),
                HealthyThreshold = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthyThreshold"),
                UnhealthyThreshold = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.UnhealthyThreshold"),
                HealthCheckTimeout = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckTimeout"),
                HealthCheckInterval = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckInterval"),
                HealthCheckConnectPort = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckConnectPort"),
                HealthCheckHttpCode = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckHttpCode"),
                ServerCertificateId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.ServerCertificateId"),
                CaCertificateId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.CACertificateId"),
                MaxConnection = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.MaxConnection"),
                VServerGroupId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.VServerGroupId")
            };
            return describeLoadBalancerHttpsListenerAttributeResponse;
        }
    }
}