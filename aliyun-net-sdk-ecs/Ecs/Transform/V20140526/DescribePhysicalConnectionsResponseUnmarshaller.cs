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
    public class DescribePhysicalConnectionsResponseUnmarshaller
    {
        public static DescribePhysicalConnectionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePhysicalConnectionsResponse describePhysicalConnectionsResponse = new DescribePhysicalConnectionsResponse();

			describePhysicalConnectionsResponse.HttpResponse = _ctx.HttpResponse;
			describePhysicalConnectionsResponse.RequestId = _ctx.StringValue("DescribePhysicalConnections.RequestId");
			describePhysicalConnectionsResponse.PageNumber = _ctx.IntegerValue("DescribePhysicalConnections.PageNumber");
			describePhysicalConnectionsResponse.PageSize = _ctx.IntegerValue("DescribePhysicalConnections.PageSize");
			describePhysicalConnectionsResponse.TotalCount = _ctx.IntegerValue("DescribePhysicalConnections.TotalCount");

			List<DescribePhysicalConnectionsResponse.DescribePhysicalConnections_PhysicalConnectionType> describePhysicalConnectionsResponse_physicalConnectionSet = new List<DescribePhysicalConnectionsResponse.DescribePhysicalConnections_PhysicalConnectionType>();
			for (int i = 0; i < _ctx.Length("DescribePhysicalConnections.PhysicalConnectionSet.Length"); i++) {
				DescribePhysicalConnectionsResponse.DescribePhysicalConnections_PhysicalConnectionType physicalConnectionType = new DescribePhysicalConnectionsResponse.DescribePhysicalConnections_PhysicalConnectionType();
				physicalConnectionType.AdLocation = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].AdLocation");
				physicalConnectionType.CreationTime = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].CreationTime");
				physicalConnectionType.Status = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Status");
				physicalConnectionType.Type = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Type");
				physicalConnectionType.PortNumber = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].PortNumber");
				physicalConnectionType.CircuitCode = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].CircuitCode");
				physicalConnectionType.Spec = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Spec");
				physicalConnectionType.Bandwidth = _ctx.LongValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Bandwidth");
				physicalConnectionType.Description = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Description");
				physicalConnectionType.PortType = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].PortType");
				physicalConnectionType.EnabledTime = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].EnabledTime");
				physicalConnectionType.BusinessStatus = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].BusinessStatus");
				physicalConnectionType.LineOperator = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].LineOperator");
				physicalConnectionType.Name = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Name");
				physicalConnectionType.RedundantPhysicalConnectionId = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].RedundantPhysicalConnectionId");
				physicalConnectionType.PeerLocation = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].PeerLocation");
				physicalConnectionType.AccessPointId = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].AccessPointId");
				physicalConnectionType.PhysicalConnectionId = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].PhysicalConnectionId");

				describePhysicalConnectionsResponse_physicalConnectionSet.Add(physicalConnectionType);
			}
			describePhysicalConnectionsResponse.PhysicalConnectionSet = describePhysicalConnectionsResponse_physicalConnectionSet;
        
			return describePhysicalConnectionsResponse;
        }
    }
}
