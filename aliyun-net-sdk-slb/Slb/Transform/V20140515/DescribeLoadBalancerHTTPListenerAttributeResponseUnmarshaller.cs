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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeLoadBalancerHTTPListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerHTTPListenerAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLoadBalancerHTTPListenerAttributeResponse describeLoadBalancerHTTPListenerAttributeResponse = new DescribeLoadBalancerHTTPListenerAttributeResponse();

			describeLoadBalancerHTTPListenerAttributeResponse.HttpResponse = context.HttpResponse;
			describeLoadBalancerHTTPListenerAttributeResponse.RequestId = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.RequestId");
			describeLoadBalancerHTTPListenerAttributeResponse.ListenerPort = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.ListenerPort");
			describeLoadBalancerHTTPListenerAttributeResponse.BackendServerPort = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.BackendServerPort");
			describeLoadBalancerHTTPListenerAttributeResponse.Bandwidth = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.Bandwidth");
			describeLoadBalancerHTTPListenerAttributeResponse.Status = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Status");
			describeLoadBalancerHTTPListenerAttributeResponse.SecurityStatus = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.SecurityStatus");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor");
			describeLoadBalancerHTTPListenerAttributeResponse.Scheduler = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Scheduler");
			describeLoadBalancerHTTPListenerAttributeResponse.StickySession = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.StickySession");
			describeLoadBalancerHTTPListenerAttributeResponse.StickySessionType = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.StickySessionType");
			describeLoadBalancerHTTPListenerAttributeResponse.CookieTimeout = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.CookieTimeout");
			describeLoadBalancerHTTPListenerAttributeResponse.Cookie = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Cookie");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheck = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheck");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckDomain = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckDomain");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckURI = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckURI");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthyThreshold = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthyThreshold");
			describeLoadBalancerHTTPListenerAttributeResponse.UnhealthyThreshold = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.UnhealthyThreshold");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckTimeout = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckTimeout");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckInterval = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckInterval");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckConnectPort = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckConnectPort");
			describeLoadBalancerHTTPListenerAttributeResponse.HealthCheckHttpCode = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.HealthCheckHttpCode");
			describeLoadBalancerHTTPListenerAttributeResponse.MaxConnection = context.IntegerValue("DescribeLoadBalancerHTTPListenerAttribute.MaxConnection");
			describeLoadBalancerHTTPListenerAttributeResponse.VServerGroupId = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.VServerGroupId");
			describeLoadBalancerHTTPListenerAttributeResponse.Gzip = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.Gzip");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor_SLBIP = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor_SLBIP");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor_SLBID = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor_SLBID");
			describeLoadBalancerHTTPListenerAttributeResponse.XForwardedFor_proto = context.StringValue("DescribeLoadBalancerHTTPListenerAttribute.XForwardedFor_proto");
        
			return describeLoadBalancerHTTPListenerAttributeResponse;
        }
    }
}