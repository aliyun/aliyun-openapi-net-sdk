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
    public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseUnmarshaller
    {
        public static DescribeVirtualBorderRoutersForPhysicalConnectionResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeVirtualBorderRoutersForPhysicalConnectionResponse describeVirtualBorderRoutersForPhysicalConnectionResponse = new DescribeVirtualBorderRoutersForPhysicalConnectionResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.RequestId"),
                PageNumber = context.IntegerValue("DescribeVirtualBorderRoutersForPhysicalConnection.PageNumber"),
                PageSize = context.IntegerValue("DescribeVirtualBorderRoutersForPhysicalConnection.PageSize"),
                TotalCount = context.IntegerValue("DescribeVirtualBorderRoutersForPhysicalConnection.TotalCount")
            };
            List<DescribeVirtualBorderRoutersForPhysicalConnectionResponse.VirtualBorderRouterForPhysicalConnectionType> virtualBorderRouterForPhysicalConnectionSet = new List<DescribeVirtualBorderRoutersForPhysicalConnectionResponse.VirtualBorderRouterForPhysicalConnectionType>();
			for (int i = 0; i < context.Length("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet.Length"); i++) {
                DescribeVirtualBorderRoutersForPhysicalConnectionResponse.VirtualBorderRouterForPhysicalConnectionType virtualBorderRouterForPhysicalConnectionType = new DescribeVirtualBorderRoutersForPhysicalConnectionResponse.VirtualBorderRouterForPhysicalConnectionType()
                {
                    VbrId = context.StringValue($"DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet[{i}].VbrId"),
                    VbrOwnerUid = context.LongValue($"DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet[{i}].VbrOwnerUid"),
                    CreationTime = context.StringValue($"DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet[{i}].CreationTime"),
                    ActivationTime = context.StringValue($"DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet[{i}].ActivationTime"),
                    TerminationTime = context.StringValue($"DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet[{i}].TerminationTime"),
                    RecoveryTime = context.StringValue($"DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet[{i}].RecoveryTime"),
                    VlanId = context.IntegerValue($"DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet[{i}].VlanId"),
                    CircuitCode = context.StringValue($"DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet[{i}].CircuitCode")
                };
                virtualBorderRouterForPhysicalConnectionSet.Add(virtualBorderRouterForPhysicalConnectionType);
			}
			describeVirtualBorderRoutersForPhysicalConnectionResponse.VirtualBorderRouterForPhysicalConnectionSet = virtualBorderRouterForPhysicalConnectionSet;
        
			return describeVirtualBorderRoutersForPhysicalConnectionResponse;
        }
    }
}