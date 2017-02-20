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
    public class DescribeLoadBalancerTcpListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerTcpListenerAttributeResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLoadBalancerTcpListenerAttributeResponse describeLoadBalancerTcpListenerAttributeResponse = new DescribeLoadBalancerTcpListenerAttributeResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.RequestId"),
                ListenerPort = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.ListenerPort"),
                BackendServerPort = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.BackendServerPort"),
                Status = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.Status"),
                Bandwidth = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.Bandwidth"),
                Scheduler = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.Scheduler"),
                SynProxy = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.SynProxy"),
                PersistenceTimeout = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.PersistenceTimeout"),
                HealthCheck = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheck"),
                HealthyThreshold = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthyThreshold"),
                UnhealthyThreshold = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.UnhealthyThreshold"),
                HealthCheckConnectTimeout = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckConnectTimeout"),
                HealthCheckConnectPort = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckConnectPort"),
                HealthCheckInterval = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckInterval"),
                HealthCheckHttpCode = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckHttpCode"),
                HealthCheckDomain = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckDomain"),
                HealthCheckUri = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckURI"),
                HealthCheckType = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckType"),
                MaxConnection = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.MaxConnection"),
                VServerGroupId = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.VServerGroupId")
            };
            return describeLoadBalancerTcpListenerAttributeResponse;
        }
    }
}