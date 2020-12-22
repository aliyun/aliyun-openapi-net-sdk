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
    public class DescribeLoadBalancerTCPListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerTCPListenerAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLoadBalancerTCPListenerAttributeResponse describeLoadBalancerTCPListenerAttributeResponse = new DescribeLoadBalancerTCPListenerAttributeResponse();

			describeLoadBalancerTCPListenerAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeLoadBalancerTCPListenerAttributeResponse.RequestId = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.RequestId");
			describeLoadBalancerTCPListenerAttributeResponse.ListenerPort = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.ListenerPort");
			describeLoadBalancerTCPListenerAttributeResponse.BackendServerPort = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.BackendServerPort");
			describeLoadBalancerTCPListenerAttributeResponse.Status = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.Status");
			describeLoadBalancerTCPListenerAttributeResponse.Bandwidth = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.Bandwidth");
			describeLoadBalancerTCPListenerAttributeResponse.Scheduler = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.Scheduler");
			describeLoadBalancerTCPListenerAttributeResponse.SynProxy = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.SynProxy");
			describeLoadBalancerTCPListenerAttributeResponse.PersistenceTimeout = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.PersistenceTimeout");
			describeLoadBalancerTCPListenerAttributeResponse.EstablishedTimeout = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.EstablishedTimeout");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheck = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheck");
			describeLoadBalancerTCPListenerAttributeResponse.HealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthyThreshold");
			describeLoadBalancerTCPListenerAttributeResponse.UnhealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.UnhealthyThreshold");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckConnectTimeout = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckConnectTimeout");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckConnectPort = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckConnectPort");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckInterval = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckInterval");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckHttpCode = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckHttpCode");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckDomain = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckDomain");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckURI = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckURI");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckType = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckType");
			describeLoadBalancerTCPListenerAttributeResponse.HealthCheckMethod = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.HealthCheckMethod");
			describeLoadBalancerTCPListenerAttributeResponse.MaxConnection = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.MaxConnection");
			describeLoadBalancerTCPListenerAttributeResponse.VServerGroupId = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.VServerGroupId");
			describeLoadBalancerTCPListenerAttributeResponse.MasterSlaveServerGroupId = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.MasterSlaveServerGroupId");
			describeLoadBalancerTCPListenerAttributeResponse.AclId = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.AclId");
			describeLoadBalancerTCPListenerAttributeResponse.AclType = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.AclType");
			describeLoadBalancerTCPListenerAttributeResponse.AclStatus = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.AclStatus");
			describeLoadBalancerTCPListenerAttributeResponse.VpcIds = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.VpcIds");
			describeLoadBalancerTCPListenerAttributeResponse.Description = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.Description");
			describeLoadBalancerTCPListenerAttributeResponse.ConnectionDrain = _ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.ConnectionDrain");
			describeLoadBalancerTCPListenerAttributeResponse.ConnectionDrainTimeout = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.ConnectionDrainTimeout");

			List<string> describeLoadBalancerTCPListenerAttributeResponse_aclIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerTCPListenerAttribute.AclIds.Length"); i++) {
				describeLoadBalancerTCPListenerAttributeResponse_aclIds.Add(_ctx.StringValue("DescribeLoadBalancerTCPListenerAttribute.AclIds["+ i +"]"));
			}
			describeLoadBalancerTCPListenerAttributeResponse.AclIds = describeLoadBalancerTCPListenerAttributeResponse_aclIds;

			List<DescribeLoadBalancerTCPListenerAttributeResponse.DescribeLoadBalancerTCPListenerAttribute_PortRange> describeLoadBalancerTCPListenerAttributeResponse_portRanges = new List<DescribeLoadBalancerTCPListenerAttributeResponse.DescribeLoadBalancerTCPListenerAttribute_PortRange>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerTCPListenerAttribute.PortRanges.Length"); i++) {
				DescribeLoadBalancerTCPListenerAttributeResponse.DescribeLoadBalancerTCPListenerAttribute_PortRange portRange = new DescribeLoadBalancerTCPListenerAttributeResponse.DescribeLoadBalancerTCPListenerAttribute_PortRange();
				portRange.StartPort = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.PortRanges["+ i +"].StartPort");
				portRange.EndPort = _ctx.IntegerValue("DescribeLoadBalancerTCPListenerAttribute.PortRanges["+ i +"].EndPort");

				describeLoadBalancerTCPListenerAttributeResponse_portRanges.Add(portRange);
			}
			describeLoadBalancerTCPListenerAttributeResponse.PortRanges = describeLoadBalancerTCPListenerAttributeResponse_portRanges;
        
			return describeLoadBalancerTCPListenerAttributeResponse;
        }
    }
}
