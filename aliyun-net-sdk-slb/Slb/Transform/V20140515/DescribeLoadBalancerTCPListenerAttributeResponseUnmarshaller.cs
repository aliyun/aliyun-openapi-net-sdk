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
    public class DescribeLoadBalancerTCPListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerTCPListenerAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLoadBalancerTCPListenerAttributeResponse describeLoadBalancerTCPListenerAttributeResponse = new DescribeLoadBalancerTCPListenerAttributeResponse();

			describeLoadBalancerTCPListenerAttributeResponse.HttpResponse = context.HttpResponse;
			describeLoadBalancerTCPListenerAttributeResponse.RequestId = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.RequestId");
			describeLoadBalancerTCPListenerAttributeResponse.ListenerPort = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.ListenerPort");
			describeLoadBalancerTCPListenerAttributeResponse.BackendServerPort = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.BackendServerPort");
			describeLoadBalancerTCPListenerAttributeResponse.Status = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.Status");
			describeLoadBalancerTCPListenerAttributeResponse.Bandwidth = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.Bandwidth");
			describeLoadBalancerTCPListenerAttributeResponse.Scheduler = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.Scheduler");
			describeLoadBalancerTCPListenerAttributeResponse.SynProxy = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.SynProxy");
			describeLoadBalancerTCPListenerAttributeResponse.PersistenceTimeout = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.PersistenceTimeout");
			describeLoadBalancerTCPListenerAttributeResponse.EstablishedTimeout = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.EstablishedTimeout");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheck = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheck");
			describeLoadBalancerTCPListenerAttributeResponse.HealthyThreshold = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthyThreshold");
			describeLoadBalancerTCPListenerAttributeResponse.UnhealthyThreshold = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.UnhealthyThreshold");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckConnectTimeout = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckConnectTimeout");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckConnectPort = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckConnectPort");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckInterval = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckInterval");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckHttpCode = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckHttpCode");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckDomain = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckDomain");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckURI = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckURI");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckType = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckType");
			describeLoadBalancerTCPListenerAttributeResponse.MaxConnection = context.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.MaxConnection");
			describeLoadBalancerTCPListenerAttributeResponse.VServerGroupId = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.VServerGroupId");
			describeLoadBalancerTCPListenerAttributeResponse.MasterSlaveServerGroupId = context.StringValue("DescribeLoadBalancerTCPListenerAttribute.MasterSlaveServerGroupId");
        
			return describeLoadBalancerTCPListenerAttributeResponse;
        }
    }
}