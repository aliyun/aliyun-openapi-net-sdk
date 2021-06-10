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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeVirtualBorderRoutersResponseUnmarshaller
    {
        public static DescribeVirtualBorderRoutersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVirtualBorderRoutersResponse describeVirtualBorderRoutersResponse = new DescribeVirtualBorderRoutersResponse();

			describeVirtualBorderRoutersResponse.HttpResponse = _ctx.HttpResponse;
			describeVirtualBorderRoutersResponse.RequestId = _ctx.StringValue("DescribeVirtualBorderRouters.RequestId");
			describeVirtualBorderRoutersResponse.PageNumber = _ctx.IntegerValue("DescribeVirtualBorderRouters.PageNumber");
			describeVirtualBorderRoutersResponse.PageSize = _ctx.IntegerValue("DescribeVirtualBorderRouters.PageSize");
			describeVirtualBorderRoutersResponse.TotalCount = _ctx.IntegerValue("DescribeVirtualBorderRouters.TotalCount");

			List<DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType> describeVirtualBorderRoutersResponse_virtualBorderRouterSet = new List<DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType>();
			for (int i = 0; i < _ctx.Length("DescribeVirtualBorderRouters.VirtualBorderRouterSet.Length"); i++) {
				DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType virtualBorderRouterType = new DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType();
				virtualBorderRouterType.VbrId = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].VbrId");
				virtualBorderRouterType.CreationTime = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].CreationTime");
				virtualBorderRouterType.ActivationTime = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].ActivationTime");
				virtualBorderRouterType.TerminationTime = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].TerminationTime");
				virtualBorderRouterType.RecoveryTime = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].RecoveryTime");
				virtualBorderRouterType.Status = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].Status");
				virtualBorderRouterType.VlanId = _ctx.IntegerValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].VlanId");
				virtualBorderRouterType.CircuitCode = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].CircuitCode");
				virtualBorderRouterType.RouteTableId = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].RouteTableId");
				virtualBorderRouterType.VlanInterfaceId = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].VlanInterfaceId");
				virtualBorderRouterType.LocalGatewayIp = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].LocalGatewayIp");
				virtualBorderRouterType.PeerGatewayIp = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PeerGatewayIp");
				virtualBorderRouterType.PeeringSubnetMask = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PeeringSubnetMask");
				virtualBorderRouterType.PhysicalConnectionId = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PhysicalConnectionId");
				virtualBorderRouterType.PhysicalConnectionStatus = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PhysicalConnectionStatus");
				virtualBorderRouterType.PhysicalConnectionBusinessStatus = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PhysicalConnectionBusinessStatus");
				virtualBorderRouterType.PhysicalConnectionOwnerUid = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PhysicalConnectionOwnerUid");
				virtualBorderRouterType.AccessPointId = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AccessPointId");
				virtualBorderRouterType.Name = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].Name");
				virtualBorderRouterType.Description = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].Description");
				virtualBorderRouterType.PConnVbrExpireTime = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PConnVbrExpireTime");
				virtualBorderRouterType.EccId = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].EccId");
				virtualBorderRouterType.Type = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].Type");
				virtualBorderRouterType.MinTxInterval = _ctx.LongValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].MinTxInterval");
				virtualBorderRouterType.MinRxInterval = _ctx.LongValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].MinRxInterval");
				virtualBorderRouterType.DetectMultiplier = _ctx.LongValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].DetectMultiplier");
				virtualBorderRouterType.LocalIpv6GatewayIp = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].LocalIpv6GatewayIp");
				virtualBorderRouterType.PeerIpv6GatewayIp = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PeerIpv6GatewayIp");
				virtualBorderRouterType.PeeringIpv6SubnetMask = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PeeringIpv6SubnetMask");
				virtualBorderRouterType.EnableIpv6 = _ctx.BooleanValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].EnableIpv6");
				virtualBorderRouterType.CloudBoxInstanceId = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].CloudBoxInstanceId");

				List<DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedPhysicalConnection> virtualBorderRouterType_associatedPhysicalConnections = new List<DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedPhysicalConnection>();
				for (int j = 0; j < _ctx.Length("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections.Length"); j++) {
					DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedPhysicalConnection associatedPhysicalConnection = new DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedPhysicalConnection();
					associatedPhysicalConnection.CircuitCode = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].CircuitCode");
					associatedPhysicalConnection.VlanInterfaceId = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].VlanInterfaceId");
					associatedPhysicalConnection.LocalGatewayIp = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].LocalGatewayIp");
					associatedPhysicalConnection.PeerGatewayIp = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PeerGatewayIp");
					associatedPhysicalConnection.PeeringSubnetMask = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PeeringSubnetMask");
					associatedPhysicalConnection.PhysicalConnectionId = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PhysicalConnectionId");
					associatedPhysicalConnection.PhysicalConnectionStatus = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PhysicalConnectionStatus");
					associatedPhysicalConnection.PhysicalConnectionBusinessStatus = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PhysicalConnectionBusinessStatus");
					associatedPhysicalConnection.PhysicalConnectionOwnerUid = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PhysicalConnectionOwnerUid");
					associatedPhysicalConnection.VlanId = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].VlanId");
					associatedPhysicalConnection.LocalIpv6GatewayIp = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].LocalIpv6GatewayIp");
					associatedPhysicalConnection.PeerIpv6GatewayIp = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PeerIpv6GatewayIp");
					associatedPhysicalConnection.PeeringIpv6SubnetMask = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PeeringIpv6SubnetMask");
					associatedPhysicalConnection.Status = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].Status");
					associatedPhysicalConnection.EnableIpv6 = _ctx.BooleanValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].EnableIpv6");

					virtualBorderRouterType_associatedPhysicalConnections.Add(associatedPhysicalConnection);
				}
				virtualBorderRouterType.AssociatedPhysicalConnections = virtualBorderRouterType_associatedPhysicalConnections;

				List<DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedCen> virtualBorderRouterType_associatedCens = new List<DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedCen>();
				for (int j = 0; j < _ctx.Length("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedCens.Length"); j++) {
					DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedCen associatedCen = new DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedCen();
					associatedCen.CenId = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedCens["+ j +"].CenId");
					associatedCen.CenOwnerId = _ctx.LongValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedCens["+ j +"].CenOwnerId");
					associatedCen.CenStatus = _ctx.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedCens["+ j +"].CenStatus");

					virtualBorderRouterType_associatedCens.Add(associatedCen);
				}
				virtualBorderRouterType.AssociatedCens = virtualBorderRouterType_associatedCens;

				describeVirtualBorderRoutersResponse_virtualBorderRouterSet.Add(virtualBorderRouterType);
			}
			describeVirtualBorderRoutersResponse.VirtualBorderRouterSet = describeVirtualBorderRoutersResponse_virtualBorderRouterSet;
        
			return describeVirtualBorderRoutersResponse;
        }
    }
}
