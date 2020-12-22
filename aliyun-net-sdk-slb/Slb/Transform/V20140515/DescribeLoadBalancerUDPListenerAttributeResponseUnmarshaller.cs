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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeLoadBalancerUDPListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerUDPListenerAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLoadBalancerUDPListenerAttributeResponse describeLoadBalancerUDPListenerAttributeResponse = new DescribeLoadBalancerUDPListenerAttributeResponse();

			describeLoadBalancerUDPListenerAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeLoadBalancerUDPListenerAttributeResponse.RequestId = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.RequestId");
			describeLoadBalancerUDPListenerAttributeResponse.ListenerPort = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.ListenerPort");
			describeLoadBalancerUDPListenerAttributeResponse.BackendServerPort = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.BackendServerPort");
			describeLoadBalancerUDPListenerAttributeResponse.Status = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.Status");
			describeLoadBalancerUDPListenerAttributeResponse.Bandwidth = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.Bandwidth");
			describeLoadBalancerUDPListenerAttributeResponse.Scheduler = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.Scheduler");
			describeLoadBalancerUDPListenerAttributeResponse.PersistenceTimeout = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.PersistenceTimeout");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheck = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheck");
			describeLoadBalancerUDPListenerAttributeResponse.HealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthyThreshold");
			describeLoadBalancerUDPListenerAttributeResponse.UnhealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.UnhealthyThreshold");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckConnectTimeout = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckConnectTimeout");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckConnectPort = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckConnectPort");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckInterval = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckInterval");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckReq = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckReq");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckExp = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckExp");
			describeLoadBalancerUDPListenerAttributeResponse.MaxConnection = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.MaxConnection");
			describeLoadBalancerUDPListenerAttributeResponse.VServerGroupId = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.VServerGroupId");
			describeLoadBalancerUDPListenerAttributeResponse.MasterSlaveServerGroupId = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.MasterSlaveServerGroupId");
			describeLoadBalancerUDPListenerAttributeResponse.AclId = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.AclId");
			describeLoadBalancerUDPListenerAttributeResponse.AclType = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.AclType");
			describeLoadBalancerUDPListenerAttributeResponse.AclStatus = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.AclStatus");
			describeLoadBalancerUDPListenerAttributeResponse.VpcIds = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.VpcIds");
			describeLoadBalancerUDPListenerAttributeResponse.Description = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.Description");
			describeLoadBalancerUDPListenerAttributeResponse.ConnectionDrain = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.ConnectionDrain");
			describeLoadBalancerUDPListenerAttributeResponse.ConnectionDrainTimeout = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.ConnectionDrainTimeout");

			List<string> describeLoadBalancerUDPListenerAttributeResponse_aclIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerUDPListenerAttribute.AclIds.Length"); i++) {
				describeLoadBalancerUDPListenerAttributeResponse_aclIds.Add(_ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.AclIds["+ i +"]"));
			}
			describeLoadBalancerUDPListenerAttributeResponse.AclIds = describeLoadBalancerUDPListenerAttributeResponse_aclIds;

			List<DescribeLoadBalancerUDPListenerAttributeResponse.DescribeLoadBalancerUDPListenerAttribute_PortRange> describeLoadBalancerUDPListenerAttributeResponse_portRanges = new List<DescribeLoadBalancerUDPListenerAttributeResponse.DescribeLoadBalancerUDPListenerAttribute_PortRange>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerUDPListenerAttribute.PortRanges.Length"); i++) {
				DescribeLoadBalancerUDPListenerAttributeResponse.DescribeLoadBalancerUDPListenerAttribute_PortRange portRange = new DescribeLoadBalancerUDPListenerAttributeResponse.DescribeLoadBalancerUDPListenerAttribute_PortRange();
				portRange.StartPort = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.PortRanges["+ i +"].StartPort");
				portRange.EndPort = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.PortRanges["+ i +"].EndPort");

				describeLoadBalancerUDPListenerAttributeResponse_portRanges.Add(portRange);
			}
			describeLoadBalancerUDPListenerAttributeResponse.PortRanges = describeLoadBalancerUDPListenerAttributeResponse_portRanges;
        
			return describeLoadBalancerUDPListenerAttributeResponse;
        }
    }
}
