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
    public class DescribeLoadBalancerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLoadBalancerAttributeResponse describeLoadBalancerAttributeResponse = new DescribeLoadBalancerAttributeResponse();

			describeLoadBalancerAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeLoadBalancerAttributeResponse.RequestId = _ctx.StringValue("DescribeLoadBalancerAttribute.RequestId");
			describeLoadBalancerAttributeResponse.LoadBalancerId = _ctx.StringValue("DescribeLoadBalancerAttribute.LoadBalancerId");
			describeLoadBalancerAttributeResponse.ResourceGroupId = _ctx.StringValue("DescribeLoadBalancerAttribute.ResourceGroupId");
			describeLoadBalancerAttributeResponse.LoadBalancerName = _ctx.StringValue("DescribeLoadBalancerAttribute.LoadBalancerName");
			describeLoadBalancerAttributeResponse.LoadBalancerStatus = _ctx.StringValue("DescribeLoadBalancerAttribute.LoadBalancerStatus");
			describeLoadBalancerAttributeResponse.RegionId = _ctx.StringValue("DescribeLoadBalancerAttribute.RegionId");
			describeLoadBalancerAttributeResponse.RegionIdAlias = _ctx.StringValue("DescribeLoadBalancerAttribute.RegionIdAlias");
			describeLoadBalancerAttributeResponse.Address = _ctx.StringValue("DescribeLoadBalancerAttribute.Address");
			describeLoadBalancerAttributeResponse.AddressType = _ctx.StringValue("DescribeLoadBalancerAttribute.AddressType");
			describeLoadBalancerAttributeResponse.VpcId = _ctx.StringValue("DescribeLoadBalancerAttribute.VpcId");
			describeLoadBalancerAttributeResponse.VSwitchId = _ctx.StringValue("DescribeLoadBalancerAttribute.VSwitchId");
			describeLoadBalancerAttributeResponse.NetworkType = _ctx.StringValue("DescribeLoadBalancerAttribute.NetworkType");
			describeLoadBalancerAttributeResponse.InternetChargeType = _ctx.StringValue("DescribeLoadBalancerAttribute.InternetChargeType");
			describeLoadBalancerAttributeResponse.AutoReleaseTime = _ctx.LongValue("DescribeLoadBalancerAttribute.AutoReleaseTime");
			describeLoadBalancerAttributeResponse.Bandwidth = _ctx.IntegerValue("DescribeLoadBalancerAttribute.Bandwidth");
			describeLoadBalancerAttributeResponse.LoadBalancerSpec = _ctx.StringValue("DescribeLoadBalancerAttribute.LoadBalancerSpec");
			describeLoadBalancerAttributeResponse.CreateTime = _ctx.StringValue("DescribeLoadBalancerAttribute.CreateTime");
			describeLoadBalancerAttributeResponse.CreateTimeStamp = _ctx.LongValue("DescribeLoadBalancerAttribute.CreateTimeStamp");
			describeLoadBalancerAttributeResponse.EndTime = _ctx.StringValue("DescribeLoadBalancerAttribute.EndTime");
			describeLoadBalancerAttributeResponse.EndTimeStamp = _ctx.LongValue("DescribeLoadBalancerAttribute.EndTimeStamp");
			describeLoadBalancerAttributeResponse.PayType = _ctx.StringValue("DescribeLoadBalancerAttribute.PayType");
			describeLoadBalancerAttributeResponse.MasterZoneId = _ctx.StringValue("DescribeLoadBalancerAttribute.MasterZoneId");
			describeLoadBalancerAttributeResponse.SlaveZoneId = _ctx.StringValue("DescribeLoadBalancerAttribute.SlaveZoneId");
			describeLoadBalancerAttributeResponse.AddressIPVersion = _ctx.StringValue("DescribeLoadBalancerAttribute.AddressIPVersion");
			describeLoadBalancerAttributeResponse.CloudType = _ctx.StringValue("DescribeLoadBalancerAttribute.CloudType");
			describeLoadBalancerAttributeResponse.RenewalDuration = _ctx.IntegerValue("DescribeLoadBalancerAttribute.RenewalDuration");
			describeLoadBalancerAttributeResponse.RenewalStatus = _ctx.StringValue("DescribeLoadBalancerAttribute.RenewalStatus");
			describeLoadBalancerAttributeResponse.RenewalCycUnit = _ctx.StringValue("DescribeLoadBalancerAttribute.RenewalCycUnit");
			describeLoadBalancerAttributeResponse.HasReservedInfo = _ctx.StringValue("DescribeLoadBalancerAttribute.HasReservedInfo");
			describeLoadBalancerAttributeResponse.ReservedInfoOrderType = _ctx.StringValue("DescribeLoadBalancerAttribute.ReservedInfoOrderType");
			describeLoadBalancerAttributeResponse.ReservedInfoInternetChargeType = _ctx.StringValue("DescribeLoadBalancerAttribute.ReservedInfoInternetChargeType");
			describeLoadBalancerAttributeResponse.ReservedInfoBandwidth = _ctx.StringValue("DescribeLoadBalancerAttribute.ReservedInfoBandwidth");
			describeLoadBalancerAttributeResponse.ReservedInfoActiveTime = _ctx.StringValue("DescribeLoadBalancerAttribute.ReservedInfoActiveTime");
			describeLoadBalancerAttributeResponse.DeleteProtection = _ctx.StringValue("DescribeLoadBalancerAttribute.DeleteProtection");
			describeLoadBalancerAttributeResponse.AssociatedCenId = _ctx.StringValue("DescribeLoadBalancerAttribute.AssociatedCenId");
			describeLoadBalancerAttributeResponse.AssociatedCenStatus = _ctx.StringValue("DescribeLoadBalancerAttribute.AssociatedCenStatus");
			describeLoadBalancerAttributeResponse.CloudInstanceType = _ctx.StringValue("DescribeLoadBalancerAttribute.CloudInstanceType");
			describeLoadBalancerAttributeResponse.CloudInstanceId = _ctx.StringValue("DescribeLoadBalancerAttribute.CloudInstanceId");
			describeLoadBalancerAttributeResponse.TunnelType = _ctx.StringValue("DescribeLoadBalancerAttribute.TunnelType");
			describeLoadBalancerAttributeResponse.CloudInstanceUid = _ctx.LongValue("DescribeLoadBalancerAttribute.CloudInstanceUid");
			describeLoadBalancerAttributeResponse.SupportPrivateLink = _ctx.BooleanValue("DescribeLoadBalancerAttribute.SupportPrivateLink");
			describeLoadBalancerAttributeResponse.BusinessStatus = _ctx.StringValue("DescribeLoadBalancerAttribute.BusinessStatus");
			describeLoadBalancerAttributeResponse.ModificationProtectionStatus = _ctx.StringValue("DescribeLoadBalancerAttribute.ModificationProtectionStatus");
			describeLoadBalancerAttributeResponse.ModificationProtectionReason = _ctx.StringValue("DescribeLoadBalancerAttribute.ModificationProtectionReason");

			List<string> describeLoadBalancerAttributeResponse_listenerPorts = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerAttribute.ListenerPorts.Length"); i++) {
				describeLoadBalancerAttributeResponse_listenerPorts.Add(_ctx.StringValue("DescribeLoadBalancerAttribute.ListenerPorts["+ i +"]"));
			}
			describeLoadBalancerAttributeResponse.ListenerPorts = describeLoadBalancerAttributeResponse_listenerPorts;

			List<string> describeLoadBalancerAttributeResponse_labels = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerAttribute.Labels.Length"); i++) {
				describeLoadBalancerAttributeResponse_labels.Add(_ctx.StringValue("DescribeLoadBalancerAttribute.Labels["+ i +"]"));
			}
			describeLoadBalancerAttributeResponse.Labels = describeLoadBalancerAttributeResponse_labels;

			List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocal> describeLoadBalancerAttributeResponse_listenerPortsAndProtocal = new List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocal>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerAttribute.ListenerPortsAndProtocal.Length"); i++) {
				DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocal listenerPortAndProtocal = new DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocal();
				listenerPortAndProtocal.ListenerPort = _ctx.IntegerValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocal["+ i +"].ListenerPort");
				listenerPortAndProtocal.ListenerProtocal = _ctx.StringValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocal["+ i +"].ListenerProtocal");

				describeLoadBalancerAttributeResponse_listenerPortsAndProtocal.Add(listenerPortAndProtocal);
			}
			describeLoadBalancerAttributeResponse.ListenerPortsAndProtocal = describeLoadBalancerAttributeResponse_listenerPortsAndProtocal;

			List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocol> describeLoadBalancerAttributeResponse_listenerPortsAndProtocol = new List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocol>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol.Length"); i++) {
				DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocol listenerPortAndProtocol = new DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_ListenerPortAndProtocol();
				listenerPortAndProtocol.ListenerPort = _ctx.IntegerValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol["+ i +"].ListenerPort");
				listenerPortAndProtocol.ListenerProtocol = _ctx.StringValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol["+ i +"].ListenerProtocol");
				listenerPortAndProtocol.ListenerForward = _ctx.StringValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol["+ i +"].ListenerForward");
				listenerPortAndProtocol.ForwardPort = _ctx.IntegerValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol["+ i +"].ForwardPort");
				listenerPortAndProtocol.Description = _ctx.StringValue("DescribeLoadBalancerAttribute.ListenerPortsAndProtocol["+ i +"].Description");

				describeLoadBalancerAttributeResponse_listenerPortsAndProtocol.Add(listenerPortAndProtocol);
			}
			describeLoadBalancerAttributeResponse.ListenerPortsAndProtocol = describeLoadBalancerAttributeResponse_listenerPortsAndProtocol;

			List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_BackendServer> describeLoadBalancerAttributeResponse_backendServers = new List<DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_BackendServer>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerAttribute.BackendServers.Length"); i++) {
				DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_BackendServer backendServer = new DescribeLoadBalancerAttributeResponse.DescribeLoadBalancerAttribute_BackendServer();
				backendServer.ServerId = _ctx.StringValue("DescribeLoadBalancerAttribute.BackendServers["+ i +"].ServerId");
				backendServer.Weight = _ctx.IntegerValue("DescribeLoadBalancerAttribute.BackendServers["+ i +"].Weight");
				backendServer.Type = _ctx.StringValue("DescribeLoadBalancerAttribute.BackendServers["+ i +"].Type");
				backendServer.ServerIp = _ctx.StringValue("DescribeLoadBalancerAttribute.BackendServers["+ i +"].ServerIp");
				backendServer.VpcId = _ctx.StringValue("DescribeLoadBalancerAttribute.BackendServers["+ i +"].VpcId");
				backendServer.Description = _ctx.StringValue("DescribeLoadBalancerAttribute.BackendServers["+ i +"].Description");

				describeLoadBalancerAttributeResponse_backendServers.Add(backendServer);
			}
			describeLoadBalancerAttributeResponse.BackendServers = describeLoadBalancerAttributeResponse_backendServers;
        
			return describeLoadBalancerAttributeResponse;
        }
    }
}
