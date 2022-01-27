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
				physicalConnectionType.PhysicalConnectionId = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].PhysicalConnectionId");
				physicalConnectionType.AccessPointId = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].AccessPointId");
				physicalConnectionType.Type = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Type");
				physicalConnectionType.Status = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Status");
				physicalConnectionType.BusinessStatus = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].BusinessStatus");
				physicalConnectionType.CreationTime = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].CreationTime");
				physicalConnectionType.EnabledTime = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].EnabledTime");
				physicalConnectionType.LineOperator = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].LineOperator");
				physicalConnectionType.Spec = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Spec");
				physicalConnectionType.PeerLocation = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].PeerLocation");
				physicalConnectionType.PortType = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].PortType");
				physicalConnectionType.RedundantPhysicalConnectionId = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].RedundantPhysicalConnectionId");
				physicalConnectionType.Name = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Name");
				physicalConnectionType.Description = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Description");
				physicalConnectionType.AdLocation = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].AdLocation");
				physicalConnectionType.PortNumber = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].PortNumber");
				physicalConnectionType.CircuitCode = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].CircuitCode");
				physicalConnectionType.Bandwidth = _ctx.LongValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Bandwidth");
				physicalConnectionType.LoaStatus = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].LoaStatus");
				physicalConnectionType.Spec1 = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].Spec");
				physicalConnectionType.HasReservationData = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].HasReservationData");
				physicalConnectionType.ReservationInternetChargeType = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].ReservationInternetChargeType");
				physicalConnectionType.ReservationActiveTime = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].ReservationActiveTime");
				physicalConnectionType.ReservationOrderType = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].ReservationOrderType");
				physicalConnectionType.EndTime = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].EndTime");
				physicalConnectionType.ChargeType = _ctx.StringValue("DescribePhysicalConnections.PhysicalConnectionSet["+ i +"].ChargeType");

				describePhysicalConnectionsResponse_physicalConnectionSet.Add(physicalConnectionType);
			}
			describePhysicalConnectionsResponse.PhysicalConnectionSet = describePhysicalConnectionsResponse_physicalConnectionSet;
        
			return describePhysicalConnectionsResponse;
        }
    }
}
