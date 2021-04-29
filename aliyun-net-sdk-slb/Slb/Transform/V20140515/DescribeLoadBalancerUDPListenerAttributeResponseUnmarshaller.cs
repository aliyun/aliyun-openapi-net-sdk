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
			describeLoadBalancerUDPListenerAttributeResponse.AclId = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.AclId");
			describeLoadBalancerUDPListenerAttributeResponse.AclStatus = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.AclStatus");
			describeLoadBalancerUDPListenerAttributeResponse.AclType = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.AclType");
			describeLoadBalancerUDPListenerAttributeResponse.BackendServerPort = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.BackendServerPort");
			describeLoadBalancerUDPListenerAttributeResponse.Bandwidth = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.Bandwidth");
			describeLoadBalancerUDPListenerAttributeResponse.ConnectionDrain = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.ConnectionDrain");
			describeLoadBalancerUDPListenerAttributeResponse.ConnectionDrainTimeout = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.ConnectionDrainTimeout");
			describeLoadBalancerUDPListenerAttributeResponse.Description = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.Description");
			describeLoadBalancerUDPListenerAttributeResponse.FailoverStrategy = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.FailoverStrategy");
			describeLoadBalancerUDPListenerAttributeResponse.FailoverThreshold = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.FailoverThreshold");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheck = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheck");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckConnectPort = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckConnectPort");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckConnectTimeout = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckConnectTimeout");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckDomain = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckDomain");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckExp = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckExp");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckHttpCode = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckHttpCode");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckInterval = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckInterval");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckMethod = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckMethod");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckReq = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckReq");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckType = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckType");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckURI = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckURI");
			describeLoadBalancerUDPListenerAttributeResponse.HealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.HealthyThreshold");
			describeLoadBalancerUDPListenerAttributeResponse.ListenerPort = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.ListenerPort");
			describeLoadBalancerUDPListenerAttributeResponse.MasterServerGroupId = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.MasterServerGroupId");
			describeLoadBalancerUDPListenerAttributeResponse.MasterSlaveModeEnabled = _ctx.BooleanValue("DescribeLoadBalancerUDPListenerAttribute.MasterSlaveModeEnabled");
			describeLoadBalancerUDPListenerAttributeResponse.MasterSlaveServerGroupId = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.MasterSlaveServerGroupId");
			describeLoadBalancerUDPListenerAttributeResponse.MaxConnection = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.MaxConnection");
			describeLoadBalancerUDPListenerAttributeResponse.PersistenceTimeout = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.PersistenceTimeout");
			describeLoadBalancerUDPListenerAttributeResponse.ProxyProtocolV2Enabled = _ctx.BooleanValue("DescribeLoadBalancerUDPListenerAttribute.ProxyProtocolV2Enabled");
			describeLoadBalancerUDPListenerAttributeResponse.QuicVersion = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.QuicVersion");
			describeLoadBalancerUDPListenerAttributeResponse.RequestId = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.RequestId");
			describeLoadBalancerUDPListenerAttributeResponse.Scheduler = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.Scheduler");
			describeLoadBalancerUDPListenerAttributeResponse.SlaveServerGroupId = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.SlaveServerGroupId");
			describeLoadBalancerUDPListenerAttributeResponse.Status = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.Status");
			describeLoadBalancerUDPListenerAttributeResponse.UnhealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.UnhealthyThreshold");
			describeLoadBalancerUDPListenerAttributeResponse.VServerGroupId = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.VServerGroupId");
			describeLoadBalancerUDPListenerAttributeResponse.VpcIds = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.VpcIds");
			describeLoadBalancerUDPListenerAttributeResponse.WorkingServerGroupId = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.WorkingServerGroupId");
			describeLoadBalancerUDPListenerAttributeResponse.HealthCheckSwitch = _ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.HealthCheckSwitch");

			List<string> describeLoadBalancerUDPListenerAttributeResponse_aclIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerUDPListenerAttribute.AclIds.Length"); i++) {
				describeLoadBalancerUDPListenerAttributeResponse_aclIds.Add(_ctx.StringValue("DescribeLoadBalancerUDPListenerAttribute.AclIds["+ i +"]"));
			}
			describeLoadBalancerUDPListenerAttributeResponse.AclIds = describeLoadBalancerUDPListenerAttributeResponse_aclIds;

			List<DescribeLoadBalancerUDPListenerAttributeResponse.DescribeLoadBalancerUDPListenerAttribute_PortRange> describeLoadBalancerUDPListenerAttributeResponse_portRanges = new List<DescribeLoadBalancerUDPListenerAttributeResponse.DescribeLoadBalancerUDPListenerAttribute_PortRange>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerUDPListenerAttribute.PortRanges.Length"); i++) {
				DescribeLoadBalancerUDPListenerAttributeResponse.DescribeLoadBalancerUDPListenerAttribute_PortRange portRange = new DescribeLoadBalancerUDPListenerAttributeResponse.DescribeLoadBalancerUDPListenerAttribute_PortRange();
				portRange.EndPort = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.PortRanges["+ i +"].EndPort");
				portRange.StartPort = _ctx.IntegerValue("DescribeLoadBalancerUDPListenerAttribute.PortRanges["+ i +"].StartPort");

				describeLoadBalancerUDPListenerAttributeResponse_portRanges.Add(portRange);
			}
			describeLoadBalancerUDPListenerAttributeResponse.PortRanges = describeLoadBalancerUDPListenerAttributeResponse_portRanges;
        
			return describeLoadBalancerUDPListenerAttributeResponse;
        }
    }
}
