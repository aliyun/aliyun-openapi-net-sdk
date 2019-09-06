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
        public static DescribeVirtualBorderRoutersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVirtualBorderRoutersResponse describeVirtualBorderRoutersResponse = new DescribeVirtualBorderRoutersResponse();

			describeVirtualBorderRoutersResponse.HttpResponse = context.HttpResponse;
			describeVirtualBorderRoutersResponse.RequestId = context.StringValue("DescribeVirtualBorderRouters.RequestId");
			describeVirtualBorderRoutersResponse.PageNumber = context.IntegerValue("DescribeVirtualBorderRouters.PageNumber");
			describeVirtualBorderRoutersResponse.PageSize = context.IntegerValue("DescribeVirtualBorderRouters.PageSize");
			describeVirtualBorderRoutersResponse.TotalCount = context.IntegerValue("DescribeVirtualBorderRouters.TotalCount");

			List<DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType> describeVirtualBorderRoutersResponse_virtualBorderRouterSet = new List<DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType>();
			for (int i = 0; i < context.Length("DescribeVirtualBorderRouters.VirtualBorderRouterSet.Length"); i++) {
				DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType virtualBorderRouterType = new DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType();
				virtualBorderRouterType.VbrId = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].VbrId");
				virtualBorderRouterType.CreationTime = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].CreationTime");
				virtualBorderRouterType.ActivationTime = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].ActivationTime");
				virtualBorderRouterType.TerminationTime = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].TerminationTime");
				virtualBorderRouterType.RecoveryTime = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].RecoveryTime");
				virtualBorderRouterType.Status = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].Status");
				virtualBorderRouterType.VlanId = context.IntegerValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].VlanId");
				virtualBorderRouterType.CircuitCode = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].CircuitCode");
				virtualBorderRouterType.RouteTableId = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].RouteTableId");
				virtualBorderRouterType.VlanInterfaceId = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].VlanInterfaceId");
				virtualBorderRouterType.LocalGatewayIp = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].LocalGatewayIp");
				virtualBorderRouterType.PeerGatewayIp = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PeerGatewayIp");
				virtualBorderRouterType.PeeringSubnetMask = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PeeringSubnetMask");
				virtualBorderRouterType.PhysicalConnectionId = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PhysicalConnectionId");
				virtualBorderRouterType.PhysicalConnectionStatus = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PhysicalConnectionStatus");
				virtualBorderRouterType.PhysicalConnectionBusinessStatus = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PhysicalConnectionBusinessStatus");
				virtualBorderRouterType.PhysicalConnectionOwnerUid = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].PhysicalConnectionOwnerUid");
				virtualBorderRouterType.AccessPointId = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AccessPointId");
				virtualBorderRouterType.Name = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].Name");
				virtualBorderRouterType.Description = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].Description");
				virtualBorderRouterType.EccId = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].EccId");
				virtualBorderRouterType.Type = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].Type");
				virtualBorderRouterType.MinTxInterval = context.LongValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].MinTxInterval");
				virtualBorderRouterType.MinRxInterval = context.LongValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].MinRxInterval");
				virtualBorderRouterType.DetectMultiplier = context.LongValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].DetectMultiplier");

				List<DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedPhysicalConnection> virtualBorderRouterType_associatedPhysicalConnections = new List<DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedPhysicalConnection>();
				for (int j = 0; j < context.Length("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections.Length"); j++) {
					DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedPhysicalConnection associatedPhysicalConnection = new DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedPhysicalConnection();
					associatedPhysicalConnection.CircuitCode = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].CircuitCode");
					associatedPhysicalConnection.VlanInterfaceId = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].VlanInterfaceId");
					associatedPhysicalConnection.LocalGatewayIp = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].LocalGatewayIp");
					associatedPhysicalConnection.PeerGatewayIp = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PeerGatewayIp");
					associatedPhysicalConnection.PeeringSubnetMask = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PeeringSubnetMask");
					associatedPhysicalConnection.PhysicalConnectionId = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PhysicalConnectionId");
					associatedPhysicalConnection.PhysicalConnectionStatus = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PhysicalConnectionStatus");
					associatedPhysicalConnection.PhysicalConnectionBusinessStatus = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PhysicalConnectionBusinessStatus");
					associatedPhysicalConnection.PhysicalConnectionOwnerUid = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].PhysicalConnectionOwnerUid");
					associatedPhysicalConnection.VlanId = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedPhysicalConnections["+ j +"].VlanId");

					virtualBorderRouterType_associatedPhysicalConnections.Add(associatedPhysicalConnection);
				}
				virtualBorderRouterType.AssociatedPhysicalConnections = virtualBorderRouterType_associatedPhysicalConnections;

				List<DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedCen> virtualBorderRouterType_associatedCens = new List<DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedCen>();
				for (int j = 0; j < context.Length("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedCens.Length"); j++) {
					DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedCen associatedCen = new DescribeVirtualBorderRoutersResponse.DescribeVirtualBorderRouters_VirtualBorderRouterType.DescribeVirtualBorderRouters_AssociatedCen();
					associatedCen.CenId = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedCens["+ j +"].CenId");
					associatedCen.CenOwnerId = context.LongValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedCens["+ j +"].CenOwnerId");
					associatedCen.CenStatus = context.StringValue("DescribeVirtualBorderRouters.VirtualBorderRouterSet["+ i +"].AssociatedCens["+ j +"].CenStatus");

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
