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
        public static DescribePhysicalConnectionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePhysicalConnectionsResponse describePhysicalConnectionsResponse = new DescribePhysicalConnectionsResponse();

			describePhysicalConnectionsResponse.HttpResponse = context.HttpResponse;
			describePhysicalConnectionsResponse.RequestId = context.StringValue("DescribePhysicalConnections.RequestId");
			describePhysicalConnectionsResponse.PageNumber = context.IntegerValue("DescribePhysicalConnections.PageNumber");
			describePhysicalConnectionsResponse.PageSize = context.IntegerValue("DescribePhysicalConnections.PageSize");
			describePhysicalConnectionsResponse.TotalCount = context.IntegerValue("DescribePhysicalConnections.TotalCount");

			List<DescribePhysicalConnectionsResponse.DescribePhysicalConnections_PhysicalConnectionType> describePhysicalConnectionsResponse_physicalConnectionSet = new List<DescribePhysicalConnectionsResponse.DescribePhysicalConnections_PhysicalConnectionType>();
			for (int i = 0; i < context.Length("DescribePhysicalConnections.PhysicalConnectionSet.Length"); i++) {
				DescribePhysicalConnectionsResponse.DescribePhysicalConnections_PhysicalConnectionType physicalConnectionType = new DescribePhysicalConnectionsResponse.DescribePhysicalConnections_PhysicalConnectionType();
				physicalConnectionType.PhysicalConnectionId = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].PhysicalConnectionId");
				physicalConnectionType.AccessPointId = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].AccessPointId");
				physicalConnectionType.Type = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Type");
				physicalConnectionType.Status = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Status");
				physicalConnectionType.BusinessStatus = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].BusinessStatus");
				physicalConnectionType.CreationTime = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].CreationTime");
				physicalConnectionType.EnabledTime = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].EnabledTime");
				physicalConnectionType.LineOperator = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].LineOperator");
				physicalConnectionType.Spec = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Spec");
				physicalConnectionType.PeerLocation = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].PeerLocation");
				physicalConnectionType.PortType = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].PortType");
				physicalConnectionType.RedundantPhysicalConnectionId = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].RedundantPhysicalConnectionId");
				physicalConnectionType.Name = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Name");
				physicalConnectionType.Description = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Description");
				physicalConnectionType.AdLocation = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].AdLocation");
				physicalConnectionType.PortNumber = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].PortNumber");
				physicalConnectionType.CircuitCode = context.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].CircuitCode");
				physicalConnectionType.Bandwidth = context.LongValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Bandwidth");

				describePhysicalConnectionsResponse_physicalConnectionSet.Add(physicalConnectionType);
			}
			describePhysicalConnectionsResponse.PhysicalConnectionSet = describePhysicalConnectionsResponse_physicalConnectionSet;
        
			return describePhysicalConnectionsResponse;
        }
    }
}
