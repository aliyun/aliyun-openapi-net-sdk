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
    public class DescribeLoadBalancerUDPListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerUDPListenerAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLoadBalancerUDPListenerAttributeResponse describeLoadBalancerUDPListenerAttributeResponse = new DescribeLoadBalancerUDPListenerAttributeResponse();

			describeLoadBalancerUDPListenerAttributeResponse.HttpResponse = context.HttpResponse;
			describeLoadBalancerUDPListenerAttributeResponse.RequestId = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.RequestId");
			describeLoadBalancerUDPListenerAttributeResponse.ListenerPort = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.ListenerPort");
			describeLoadBalancerUDPListenerAttributeResponse.BackendServerPort = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.BackendServerPort");
			describeLoadBalancerUDPListenerAttributeResponse.Status = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.Status");
			describeLoadBalancerUDPListenerAttributeResponse.Bandwidth = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.Bandwidth");
			describeLoadBalancerUDPListenerAttributeResponse.Scheduler = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.Scheduler");
			describeLoadBalancerUDPListenerAttributeResponse.PersistenceTimeout = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.PersistenceTimeout");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheck = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheck");
			describeLoadBalancerUDPListenerAttributeResponse.HealthyThreshold = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthyThreshold");
			describeLoadBalancerUDPListenerAttributeResponse.UnhealthyThreshold = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.UnhealthyThreshold");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckConnectTimeout = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckConnectTimeout");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckConnectPort = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckConnectPort");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckInterval = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckInterval");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckReq = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckReq");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckExp = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckExp");
			describeLoadBalancerUDPListenerAttributeResponse.MaxConnection = context.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.MaxConnection");
			describeLoadBalancerUDPListenerAttributeResponse.VServerGroupId = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.VServerGroupId");
			describeLoadBalancerUDPListenerAttributeResponse.MasterSlaveServerGroupId = context.StringValue("DescribeLoadBalancerUDPListenerAttribute.MasterSlaveServerGroupId");
        
			return describeLoadBalancerUDPListenerAttributeResponse;
        }
    }
}