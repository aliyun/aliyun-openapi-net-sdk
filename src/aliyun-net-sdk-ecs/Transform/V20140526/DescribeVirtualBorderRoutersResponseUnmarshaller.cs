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
using Aliyun.Acs.Ecs.Model.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeVirtualBorderRoutersResponseUnmarshaller
    {
        public static DescribeVirtualBorderRoutersResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeVirtualBorderRoutersResponse describeVirtualBorderRoutersResponse = new DescribeVirtualBorderRoutersResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeVirtualBorderRouters.RequestId"),
                PageNumber = context.IntegerValue("DescribeVirtualBorderRouters.PageNumber"),
                PageSize = context.IntegerValue("DescribeVirtualBorderRouters.PageSize"),
                TotalCount = context.IntegerValue("DescribeVirtualBorderRouters.TotalCount")
            };
            List<DescribeVirtualBorderRoutersResponse.VirtualBorderRouterType> virtualBorderRouterSet = new List<DescribeVirtualBorderRoutersResponse.VirtualBorderRouterType>();
			for (int i = 0; i < context.Length("DescribeVirtualBorderRouters.VirtualBorderRouterSet.Length"); i++) {
                DescribeVirtualBorderRoutersResponse.VirtualBorderRouterType virtualBorderRouterType = new DescribeVirtualBorderRoutersResponse.VirtualBorderRouterType()
                {
                    VbrId = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].VbrId"),
                    CreationTime = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].CreationTime"),
                    ActivationTime = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].ActivationTime"),
                    TerminationTime = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].TerminationTime"),
                    RecoveryTime = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].RecoveryTime"),
                    Status = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].Status"),
                    VlanId = context.IntegerValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].VlanId"),
                    CircuitCode = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].CircuitCode"),
                    RouteTableId = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].RouteTableId"),
                    VlanInterfaceId = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].VlanInterfaceId"),
                    LocalGatewayIp = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].LocalGatewayIp"),
                    PeerGatewayIp = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].PeerGatewayIp"),
                    PeeringSubnetMask = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].PeeringSubnetMask"),
                    PhysicalConnectionId = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].PhysicalConnectionId"),
                    PhysicalConnectionStatus = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].PhysicalConnectionStatus"),
                    PhysicalConnectionBusinessStatus = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].PhysicalConnectionBusinessStatus"),
                    PhysicalConnectionOwnerUid = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].PhysicalConnectionOwnerUid"),
                    AccessPointId = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].AccessPointId"),
                    Name = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].Name"),
                    Description = context.StringValue($"DescribeVirtualBorderRouters.VirtualBorderRouterSet[{i}].Description")
                };
                virtualBorderRouterSet.Add(virtualBorderRouterType);
			}
			describeVirtualBorderRoutersResponse.VirtualBorderRouterSet = virtualBorderRouterSet;
        
			return describeVirtualBorderRoutersResponse;
        }
    }
}