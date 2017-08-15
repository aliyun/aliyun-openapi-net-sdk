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
			describeLoadBalancerAttributeResponse.ResourceGroupId = context.StringValue("DescribeLoadBalancerAttribute.ResourceGroupId");
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
			describeLoadBalancerAttributeResponse.AutoReleaseTime = context.LongValue("DescribeLoadBalancerAttribute.AutoReleaseTime");
			describeLoadBalancerAttributeResponse.Bandwidth = context.IntegerValue("DescribeLoadBalancerAttribute.Bandwidth");
			describeLoadBalancerAttributeResponse.LoadBalancerSpec = context.StringValue("DescribeLoadBalancerAttribute.LoadBalancerSpec");
			describeLoadBalancerAttributeResponse.CreateTime = context.StringValue("DescribeLoadBalancerAttribute.CreateTime");
			describeLoadBalancerAttributeResponse.CreateTimeStamp = context.LongValue("DescribeLoadBalancerAttribute.CreateTimeStamp");
			describeLoadBalancerAttributeResponse.EndTime = context.StringValue("DescribeLoadBalancerAttribute.EndTime");
			describeLoadBalancerAttributeResponse.EndTimeStamp = context.LongValue("DescribeLoadBalancerAttribute.EndTimeStamp");
			describeLoadBalancerAttributeResponse.PayType = context.StringValue("DescribeLoadBalancerAttribute.PayType");
			describeLoadBalancerAttributeResponse.MasterZoneId = context.StringValue("DescribeLoadBalancerAttribute.MasterZoneId");
			describeLoadBalancerAttributeResponse.SlaveZoneId = context.StringValue("DescribeLoadBalancerAttribute.SlaveZoneId");

			List<string> describeLoadBalancerAttributeResponse_listenerPorts = new List<string>();
			for (int i = 0; i < context.Length("DescribeLoadBalancerAttribute.ListenerPorts.Length"); i++) {
				describeLoadBalancerAttributeResponse_listenerPorts.Add(context.StringValue("DescribeLoadBalancerAttribute.ListenerPorts["+ i +"]"));
			}
			describeLoadBalancerAttributeResponse.ListenerPorts = describeLoadBalancerAttributeResponse_listenerPorts;

			List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocal> describeLoadBalancerAttributeResponse_listenerPortsAndProtocal = new List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocal>();
			for (int i = 0; i < context.Length("DescribeLoadBalancerAttribute.ListenerPortsAndProtocal.Length"); i++) {
				DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocal listenerPortAndProtocal = new DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocal();
				listenerPortAndProtocal.ListenerPort = context.IntegerValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocal["+ i +"].ListenerPort");
				listenerPortAndProtocal.ListenerProtocal = context.StringValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocal["+ i +"].ListenerProtocal");

				describeLoadBalancerAttributeResponse_listenerPortsAndProtocal.Add(listenerPortAndProtocal);
			}
			describeLoadBalancerAttributeResponse.ListenerPortsAndProtocal = describeLoadBalancerAttributeResponse_listenerPortsAndProtocal;

			List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocol> describeLoadBalancerAttributeResponse_listenerPortsAndProtocol = new List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocol>();
			for (int i = 0; i < context.Length("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol.Length"); i++) {
				DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocol listenerPortAndProtocol = new DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocol();
				listenerPortAndProtocol.ListenerPort = context.IntegerValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol["+ i +"].ListenerPort");
				listenerPortAndProtocol.ListenerProtocol = context.StringValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol["+ i +"].ListenerProtocol");

				describeLoadBalancerAttributeResponse_listenerPortsAndProtocol.Add(listenerPortAndProtocol);
			}
			describeLoadBalancerAttributeResponse.ListenerPortsAndProtocol = describeLoadBalancerAttributeResponse_listenerPortsAndProtocol;

			List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_BackendServer> describeLoadBalancerAttributeResponse_backendServers = new List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_BackendServer>();
			for (int i = 0; i < context.Length("DescribeLoadBalancerAttribute.BackendServers.Length"); i++) {
				DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_BackendServer backendServer = new DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_BackendServer();
				backendServer.ServerId = context.StringValue("DescribeLoadBalancerAttribute.BackendServers["+ i +"].ServerId");
				backendServer.Weight = context.IntegerValue("DescribeLoadBalancerAttribute.BackendServers["+ i +"].Weight");

				describeLoadBalancerAttributeResponse_backendServers.Add(backendServer);
			}
			describeLoadBalancerAttributeResponse.BackendServers = describeLoadBalancerAttributeResponse_backendServers;
        
			return describeLoadBalancerAttributeResponse;
        }
    }
}