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
    public class DescribeLoadBalancerTCPListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerTCPListenerAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLoadBalancerTCPListenerAttributeResponse describeLoadBalancerTCPListenerAttributeResponse = new DescribeLoadBalancerTCPListenerAttributeResponse();

			describeLoadBalancerTCPListenerAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeLoadBalancerTCPListenerAttributeResponse.VServerGroupId = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.VServerGroupId");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckHttpCode = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckHttpCode");
			describeLoadBalancerTCPListenerAttributeResponse.ConnectPort = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.ConnectPort");
			describeLoadBalancerTCPListenerAttributeResponse.Status = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.Status");
			describeLoadBalancerTCPListenerAttributeResponse.MaxConnection = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.MaxConnection");
			describeLoadBalancerTCPListenerAttributeResponse.PersistenceTimeout = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.PersistenceTimeout");
			describeLoadBalancerTCPListenerAttributeResponse.ListenerPort = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.ListenerPort");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckURI = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckURI");
			describeLoadBalancerTCPListenerAttributeResponse.SynProxy = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.SynProxy");
			describeLoadBalancerTCPListenerAttributeResponse.Scheduler = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.Scheduler");
			describeLoadBalancerTCPListenerAttributeResponse.RequestId = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.RequestId");
			describeLoadBalancerTCPListenerAttributeResponse.Interval = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.Interval");
			describeLoadBalancerTCPListenerAttributeResponse.Bandwidth = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.Bandwidth");
			describeLoadBalancerTCPListenerAttributeResponse.EstablishedTimeout = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.EstablishedTimeout");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckType = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckType");
			describeLoadBalancerTCPListenerAttributeResponse.MasterSlaveServerGroupId = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.MasterSlaveServerGroupId");
			describeLoadBalancerTCPListenerAttributeResponse.BackendServerPort = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.BackendServerPort");
			describeLoadBalancerTCPListenerAttributeResponse.HealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthyThreshold");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckDomain = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckDomain");
			describeLoadBalancerTCPListenerAttributeResponse.UnhealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.UnhealthyThreshold");
			describeLoadBalancerTCPListenerAttributeResponse.ConnectTimeout = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.ConnectTimeout");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheck = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheck");
        
			return describeLoadBalancerTCPListenerAttributeResponse;
        }
    }
}
