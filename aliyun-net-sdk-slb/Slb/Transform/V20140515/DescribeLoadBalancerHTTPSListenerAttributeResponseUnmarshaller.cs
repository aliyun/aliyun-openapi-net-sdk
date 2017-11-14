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
    public class DescribeLoadBalancerHTTPSListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerHTTPSListenerAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLoadBalancerHTTPSListenerAttributeResponse describeLoadBalancerHTTPSListenerAttributeResponse = new DescribeLoadBalancerHTTPSListenerAttributeResponse();

			describeLoadBalancerHTTPSListenerAttributeResponse.HttpResponse = context.HttpResponse;
			describeLoadBalancerHTTPSListenerAttributeResponse.RequestId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.RequestId");
			describeLoadBalancerHTTPSListenerAttributeResponse.ListenerPort = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.ListenerPort");
			describeLoadBalancerHTTPSListenerAttributeResponse.BackendServerPort = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.BackendServerPort");
			describeLoadBalancerHTTPSListenerAttributeResponse.Bandwidth = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.Bandwidth");
			describeLoadBalancerHTTPSListenerAttributeResponse.Status = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Status");
			describeLoadBalancerHTTPSListenerAttributeResponse.SecurityStatus = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.SecurityStatus");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor");
			describeLoadBalancerHTTPSListenerAttributeResponse.Scheduler = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Scheduler");
			describeLoadBalancerHTTPSListenerAttributeResponse.StickySession = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.StickySession");
			describeLoadBalancerHTTPSListenerAttributeResponse.StickySessionType = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.StickySessionType");
			describeLoadBalancerHTTPSListenerAttributeResponse.CookieTimeout = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.CookieTimeout");
			describeLoadBalancerHTTPSListenerAttributeResponse.Cookie = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Cookie");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheck = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheck");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckDomain = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckDomain");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckURI = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckURI");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthyThreshold = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthyThreshold");
			describeLoadBalancerHTTPSListenerAttributeResponse.UnhealthyThreshold = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.UnhealthyThreshold");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckTimeout = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckTimeout");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckInterval = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckInterval");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckConnectPort = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckConnectPort");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckHttpCode = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckHttpCode");
			describeLoadBalancerHTTPSListenerAttributeResponse.ServerCertificateId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.ServerCertificateId");
			describeLoadBalancerHTTPSListenerAttributeResponse.CACertificateId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.CACertificateId");
			describeLoadBalancerHTTPSListenerAttributeResponse.MaxConnection = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.MaxConnection");
			describeLoadBalancerHTTPSListenerAttributeResponse.VServerGroupId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.VServerGroupId");
			describeLoadBalancerHTTPSListenerAttributeResponse.Gzip = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Gzip");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_SLBIP = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_SLBIP");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_SLBID = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_SLBID");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_proto = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_proto");
        
			return describeLoadBalancerHTTPSListenerAttributeResponse;
        }
    }
}