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
    public class DescribeLoadBalancerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLoadBalancerAttributeResponse describeLoadBalancerAttributeResponse = new DescribeLoadBalancerAttributeResponse();

			describeLoadBalancerAttributeResponse.HttpResponse = context.HttpResponse;
			describeLoadBalancerAttributeResponse.RequestId = context.StringValue("DescribeLoadBalancerAttribute.RequestId");
			describeLoadBalancerAttributeResponse.LoadBalancerId = context.StringValue("DescribeLoadBalancerAttribute.LoadBalancerId");
			describeLoadBalancerAttributeResponse.LoadBalancerName = context.StringValue("DescribeLoadBalancerAttribute.LoadBalancerName");
			describeLoadBalancerAttributeResponse.LoadBalancerStatus = context.StringValue("DescribeLoadBalancerAttribute.LoadBalancerStatus");
			describeLoadBalancerAttributeResponse.RegionId = context.StringValue("DescribeLoadBalancerAttribute.RegionId");
			describeLoadBalancerAttributeResponse.RegionIdAlias = context.StringValue("DescribeLoadBalancerAttribute.RegionIdAlias");
			describeLoadBalancerAttributeResponse.Address = context.StringValue("DescribeLoadBalancerAttribute.Address");
			describeLoadBalancerAttributeResponse.AddressType = context.StringValue("DescribeLoadBalancerAttribute.AddressType");
			describeLoadBalancerAttributeResponse.VpcId = context.StringValue("DescribeLoadBalancerAttribute.VpcId");
			describeLoadBalancerAttributeResponse.VSwitchId = context.StringValue("DescribeLoadBalancerAttribute.VSwitchId");
			describeLoadBalancerAttributeResponse.NetworkType = context.StringValue("DescribeLoadBalancerAttribute.NetworkType");
			describeLoadBalancerAttributeResponse.InternetChargeType = context.StringValue("DescribeLoadBalancerAttribute.InternetChargeType");
			describeLoadBalancerAttributeResponse.Bandwidth = context.IntegerValue("DescribeLoadBalancerAttribute.Bandwidth");
			describeLoadBalancerAttributeResponse.CreateTime = context.StringValue("DescribeLoadBalancerAttribute.CreateTime");
			describeLoadBalancerAttributeResponse.CreateTimeStamp = context.LongValue("DescribeLoadBalancerAttribute.CreateTimeStamp");
			describeLoadBalancerAttributeResponse.MasterZoneId = context.StringValue("DescribeLoadBalancerAttribute.MasterZoneId");
			describeLoadBalancerAttributeResponse.SlaveZoneId = context.StringValue("DescribeLoadBalancerAttribute.SlaveZoneId");

			List<string> listenerPorts = new List<string>();
			for (int i = 0; i < context.Length("DescribeLoadBalancerAttribute.ListenerPorts.Length"); i++) {
				listenerPorts.Add(context.StringValue("DescribeLoadBalancerAttribute.ListenerPorts["+ i +"]"));
			}
			describeLoadBalancerAttributeResponse.ListenerPorts = listenerPorts;

			List<DescribeLoadBalancerAttributeResponse.ListenerPortAndProtocal> listenerPortsAndProtocal = new List<DescribeLoadBalancerAttributeResponse.ListenerPortAndProtocal>();
			for (int i = 0; i < context.Length("DescribeLoadBalancerAttribute.ListenerPortsAndProtocal.Length"); i++) {
				DescribeLoadBalancerAttributeResponse.ListenerPortAndProtocal listenerPortAndProtocal = new DescribeLoadBalancerAttributeResponse.ListenerPortAndProtocal();
				listenerPortAndProtocal.ListenerPort = context.IntegerValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocal["+ i +"].ListenerPort");
				listenerPortAndProtocal.ListenerProtocal = context.StringValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocal["+ i +"].ListenerProtocal");

				listenerPortsAndProtocal.Add(listenerPortAndProtocal);
			}
			describeLoadBalancerAttributeResponse.ListenerPortsAndProtocal = listenerPortsAndProtocal;

			List<DescribeLoadBalancerAttributeResponse.ListenerPortAndProtocol> listenerPortsAndProtocol = new List<DescribeLoadBalancerAttributeResponse.ListenerPortAndProtocol>();
			for (int i = 0; i < context.Length("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol.Length"); i++) {
				DescribeLoadBalancerAttributeResponse.ListenerPortAndProtocol listenerPortAndProtocol = new DescribeLoadBalancerAttributeResponse.ListenerPortAndProtocol();
				listenerPortAndProtocol.ListenerPort = context.IntegerValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol["+ i +"].ListenerPort");
				listenerPortAndProtocol.ListenerProtocol = context.StringValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol["+ i +"].ListenerProtocol");

				listenerPortsAndProtocol.Add(listenerPortAndProtocol);
			}
			describeLoadBalancerAttributeResponse.ListenerPortsAndProtocol = listenerPortsAndProtocol;

			List<DescribeLoadBalancerAttributeResponse.BackendServer> backendServers = new List<DescribeLoadBalancerAttributeResponse.BackendServer>();
			for (int i = 0; i < context.Length("DescribeLoadBalancerAttribute.BackendServers.Length"); i++) {
				DescribeLoadBalancerAttributeResponse.BackendServer backendServer = new DescribeLoadBalancerAttributeResponse.BackendServer();
				backendServer.ServerId = context.StringValue("DescribeLoadBalancerAttribute.BackendServers["+ i +"].ServerId");
				backendServer.Weight = context.IntegerValue("DescribeLoadBalancerAttribute.BackendServers["+ i +"].Weight");

				backendServers.Add(backendServer);
			}
			describeLoadBalancerAttributeResponse.BackendServers = backendServers;
        
			return describeLoadBalancerAttributeResponse;
        }
    }
}