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
    public class DescribePhysicalConnectionsResponseUnmarshaller
    {
        public static DescribePhysicalConnectionsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribePhysicalConnectionsResponse describePhysicalConnectionsResponse = new DescribePhysicalConnectionsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribePhysicalConnections.RequestId"),
                PageNumber = context.IntegerValue("DescribePhysicalConnections.PageNumber"),
                PageSize = context.IntegerValue("DescribePhysicalConnections.PageSize"),
                TotalCount = context.IntegerValue("DescribePhysicalConnections.TotalCount")
            };
            List<DescribePhysicalConnectionsResponse.PhysicalConnectionType> physicalConnectionSet = new List<DescribePhysicalConnectionsResponse.PhysicalConnectionType>();
			for (int i = 0; i < context.Length("DescribePhysicalConnections.PhysicalConnectionSet.Length"); i++) {
                DescribePhysicalConnectionsResponse.PhysicalConnectionType physicalConnectionType = new DescribePhysicalConnectionsResponse.PhysicalConnectionType()
                {
                    PhysicalConnectionId = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].PhysicalConnectionId"),
                    AccessPointId = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].AccessPointId"),
                    Type = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].Type"),
                    Status = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].Status"),
                    BusinessStatus = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].BusinessStatus"),
                    CreationTime = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].CreationTime"),
                    EnabledTime = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].EnabledTime"),
                    LineOperator = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].LineOperator"),
                    Spec = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].Spec"),
                    PeerLocation = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].PeerLocation"),
                    PortType = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].PortType"),
                    RedundantPhysicalConnectionId = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].RedundantPhysicalConnectionId"),
                    Name = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].Name"),
                    Description = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].Description"),
                    AdLocation = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].AdLocation"),
                    PortNumber = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].PortNumber"),
                    CircuitCode = context.StringValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].CircuitCode"),
                    Bandwidth = context.LongValue($"DescribePhysicalConnections.PhysicalConnectionSet[{i}].Bandwidth")
                };
                physicalConnectionSet.Add(physicalConnectionType);
			}
			describePhysicalConnectionsResponse.PhysicalConnectionSet = physicalConnectionSet;
        
			return describePhysicalConnectionsResponse;
        }
    }
}