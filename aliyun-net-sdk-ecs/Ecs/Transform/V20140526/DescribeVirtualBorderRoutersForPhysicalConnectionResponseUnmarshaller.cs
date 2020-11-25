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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseUnmarshaller
    {
        public static DescribeVirtualBorderRoutersForPhysicalConnectionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVirtualBorderRoutersForPhysicalConnectionResponse describeVirtualBorderRoutersForPhysicalConnectionResponse = new DescribeVirtualBorderRoutersForPhysicalConnectionResponse();

			describeVirtualBorderRoutersForPhysicalConnectionResponse.HttpResponse = _ctx.HttpResponse;
			describeVirtualBorderRoutersForPhysicalConnectionResponse.RequestId = _ctx.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.RequestId");
			describeVirtualBorderRoutersForPhysicalConnectionResponse.PageNumber = _ctx.IntegerValue("DescribeVirtualBorderRoutersForPhysicalConnection.PageNumber");
			describeVirtualBorderRoutersForPhysicalConnectionResponse.PageSize = _ctx.IntegerValue("DescribeVirtualBorderRoutersForPhysicalConnection.PageSize");
			describeVirtualBorderRoutersForPhysicalConnectionResponse.TotalCount = _ctx.IntegerValue("DescribeVirtualBorderRoutersForPhysicalConnection.TotalCount");

			List<DescribeVirtualBorderRoutersForPhysicalConnectionResponse.DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType> describeVirtualBorderRoutersForPhysicalConnectionResponse_virtualBorderRouterForPhysicalConnectionSet = new List<DescribeVirtualBorderRoutersForPhysicalConnectionResponse.DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType>();
			for (int i = 0; i < _ctx.Length("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet.Length"); i++) {
				DescribeVirtualBorderRoutersForPhysicalConnectionResponse.DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType virtualBorderRouterForPhysicalConnectionType = new DescribeVirtualBorderRoutersForPhysicalConnectionResponse.DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType();
				virtualBorderRouterForPhysicalConnectionType.VbrId = _ctx.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].VbrId");
				virtualBorderRouterForPhysicalConnectionType.VbrOwnerUid = _ctx.LongValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].VbrOwnerUid");
				virtualBorderRouterForPhysicalConnectionType.CreationTime = _ctx.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].CreationTime");
				virtualBorderRouterForPhysicalConnectionType.ActivationTime = _ctx.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].ActivationTime");
				virtualBorderRouterForPhysicalConnectionType.TerminationTime = _ctx.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].TerminationTime");
				virtualBorderRouterForPhysicalConnectionType.RecoveryTime = _ctx.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].RecoveryTime");
				virtualBorderRouterForPhysicalConnectionType.VlanId = _ctx.IntegerValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].VlanId");
				virtualBorderRouterForPhysicalConnectionType.CircuitCode = _ctx.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].CircuitCode");

				describeVirtualBorderRoutersForPhysicalConnectionResponse_virtualBorderRouterForPhysicalConnectionSet.Add(virtualBorderRouterForPhysicalConnectionType);
			}
			describeVirtualBorderRoutersForPhysicalConnectionResponse.VirtualBorderRouterForPhysicalConnectionSet = describeVirtualBorderRoutersForPhysicalConnectionResponse_virtualBorderRouterForPhysicalConnectionSet;
        
			return describeVirtualBorderRoutersForPhysicalConnectionResponse;
        }
    }
}
