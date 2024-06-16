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
    public class DescribeLoadBalancerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLoadBalancerAttributeResponse describeLoadBalancerAttributeResponse = new DescribeLoadBalancerAttributeResponse();

			describeLoadBalancerAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeLoadBalancerAttributeResponse.VpcId = _ctx.StringValue("DescribeLoadBalancerAttribute.VpcId");
			describeLoadBalancerAttributeResponse.CreateTimeStamp = _ctx.LongValue("DescribeLoadBalancerAttribute.CreateTimeStamp");
			describeLoadBalancerAttributeResponse.LoadBalancerSpec = _ctx.StringValue("DescribeLoadBalancerAttribute.LoadBalancerSpec");
			describeLoadBalancerAttributeResponse.AutoReleaseTime = _ctx.LongValue("DescribeLoadBalancerAttribute.AutoReleaseTime");
			describeLoadBalancerAttributeResponse.IsPublicAddress = _ctx.StringValue("DescribeLoadBalancerAttribute.IsPublicAddress");
			describeLoadBalancerAttributeResponse.CreateTime = _ctx.StringValue("DescribeLoadBalancerAttribute.CreateTime");
			describeLoadBalancerAttributeResponse.LoadBalancerId = _ctx.StringValue("DescribeLoadBalancerAttribute.LoadBalancerId");
			describeLoadBalancerAttributeResponse.PayType = _ctx.StringValue("DescribeLoadBalancerAttribute.PayType");
			describeLoadBalancerAttributeResponse.AddressType = _ctx.StringValue("DescribeLoadBalancerAttribute.AddressType");
			describeLoadBalancerAttributeResponse.NetworkType = _ctx.StringValue("DescribeLoadBalancerAttribute.NetworkType");
			describeLoadBalancerAttributeResponse.RegionId = _ctx.StringValue("DescribeLoadBalancerAttribute.RegionId");
			describeLoadBalancerAttributeResponse.EndTime = _ctx.StringValue("DescribeLoadBalancerAttribute.EndTime");
			describeLoadBalancerAttributeResponse.VSwitchId = _ctx.StringValue("DescribeLoadBalancerAttribute.VSwitchId");
			describeLoadBalancerAttributeResponse.RequestId = _ctx.StringValue("DescribeLoadBalancerAttribute.RequestId");
			describeLoadBalancerAttributeResponse.Bandwidth = _ctx.IntegerValue("DescribeLoadBalancerAttribute.Bandwidth");
			describeLoadBalancerAttributeResponse.LoadBalancerStatus = _ctx.StringValue("DescribeLoadBalancerAttribute.LoadBalancerStatus");
			describeLoadBalancerAttributeResponse.LoadBalancerName = _ctx.StringValue("DescribeLoadBalancerAttribute.LoadBalancerName");
			describeLoadBalancerAttributeResponse.InternetChargeType = _ctx.StringValue("DescribeLoadBalancerAttribute.InternetChargeType");
			describeLoadBalancerAttributeResponse.Address = _ctx.StringValue("DescribeLoadBalancerAttribute.Address");
			describeLoadBalancerAttributeResponse.SlaveZoneId = _ctx.StringValue("DescribeLoadBalancerAttribute.SlaveZoneId");
			describeLoadBalancerAttributeResponse.EndTimeStamp = _ctx.LongValue("DescribeLoadBalancerAttribute.EndTimeStamp");
			describeLoadBalancerAttributeResponse.RegionIdAlias = _ctx.StringValue("DescribeLoadBalancerAttribute.RegionIdAlias");
			describeLoadBalancerAttributeResponse.MasterZoneId = _ctx.StringValue("DescribeLoadBalancerAttribute.MasterZoneId");

			List<string> describeLoadBalancerAttributeResponse_listenerPorts = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerAttribute.ListenerPorts.Length"); i++) {
				describeLoadBalancerAttributeResponse_listenerPorts.Add(_ctx.StringValue("DescribeLoadBalancerAttribute.ListenerPorts["+ i +"]"));
			}
			describeLoadBalancerAttributeResponse.ListenerPorts = describeLoadBalancerAttributeResponse_listenerPorts;

			List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocal> describeLoadBalancerAttributeResponse_listenerPortsAndProtocal = new List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocal>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerAttribute.ListenerPortsAndProtocal.Length"); i++) {
				DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocal listenerPortAndProtocal = new DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocal();
				listenerPortAndProtocal.ListenerProtocal = _ctx.StringValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocal["+ i +"].ListenerProtocal");
				listenerPortAndProtocal.ListenerPort = _ctx.IntegerValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocal["+ i +"].ListenerPort");

				describeLoadBalancerAttributeResponse_listenerPortsAndProtocal.Add(listenerPortAndProtocal);
			}
			describeLoadBalancerAttributeResponse.ListenerPortsAndProtocal = describeLoadBalancerAttributeResponse_listenerPortsAndProtocal;

			List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocol> describeLoadBalancerAttributeResponse_listenerPortsAndProtocol = new List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocol>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol.Length"); i++) {
				DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocol listenerPortAndProtocol = new DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocol();
				listenerPortAndProtocol.ListenerPort = _ctx.IntegerValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol["+ i +"].ListenerPort");
				listenerPortAndProtocol.ListenerProtocol = _ctx.StringValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol["+ i +"].ListenerProtocol");

				describeLoadBalancerAttributeResponse_listenerPortsAndProtocol.Add(listenerPortAndProtocol);
			}
			describeLoadBalancerAttributeResponse.ListenerPortsAndProtocol = describeLoadBalancerAttributeResponse_listenerPortsAndProtocol;

			List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_BackendServer> describeLoadBalancerAttributeResponse_backendServers = new List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_BackendServer>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerAttribute.BackendServers.Length"); i++) {
				DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_BackendServer backendServer = new DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_BackendServer();
				backendServer.Weight = _ctx.IntegerValue("DescribeLoadBalancerAttribute.BackendServers["+ i +"].Weight");
				backendServer.ServerId = _ctx.StringValue("DescribeLoadBalancerAttribute.BackendServers["+ i +"].ServerId");

				describeLoadBalancerAttributeResponse_backendServers.Add(backendServer);
			}
			describeLoadBalancerAttributeResponse.BackendServers = describeLoadBalancerAttributeResponse_backendServers;
        
			return describeLoadBalancerAttributeResponse;
        }
    }
}
