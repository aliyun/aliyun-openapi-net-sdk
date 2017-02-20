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
    public class DescribeLoadBalancerUdpListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerUdpListenerAttributeResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLoadBalancerUdpListenerAttributeResponse describeLoadBalancerUdpListenerAttributeResponse = new DescribeLoadBalancerUdpListenerAttributeResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.RequestId"),
                ListenerPort = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.ListenerPort"),
                BackendServerPort = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.BackendServerPort"),
                Status = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.Status"),
                Bandwidth = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.Bandwidth"),
                Scheduler = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.Scheduler"),
                PersistenceTimeout = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.PersistenceTimeout"),
                HealthCheck = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheck"),
                HealthyThreshold = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthyThreshold"),
                UnhealthyThreshold = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.UnhealthyThreshold"),
                HealthCheckConnectTimeout = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckConnectTimeout"),
                HealthCheckConnectPort = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckConnectPort"),
                HealthCheckInterval = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckInterval"),
                HealthCheckReq = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckReq"),
                HealthCheckExp = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckExp"),
                MaxConnection = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.MaxConnection"),
                VServerGroupId = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.VServerGroupId")
            };
            return describeLoadBalancerUdpListenerAttributeResponse;
        }
    }
}