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
    public class ListVirtualPhysicalConnectionsResponseUnmarshaller
    {
        public static ListVirtualPhysicalConnectionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVirtualPhysicalConnectionsResponse listVirtualPhysicalConnectionsResponse = new ListVirtualPhysicalConnectionsResponse();

			listVirtualPhysicalConnectionsResponse.HttpResponse = _ctx.HttpResponse;
			listVirtualPhysicalConnectionsResponse.RequestId = _ctx.StringValue("ListVirtualPhysicalConnections.RequestId");
			listVirtualPhysicalConnectionsResponse.NextToken = _ctx.StringValue("ListVirtualPhysicalConnections.NextToken");
			listVirtualPhysicalConnectionsResponse.TotalCount = _ctx.IntegerValue("ListVirtualPhysicalConnections.TotalCount");
			listVirtualPhysicalConnectionsResponse.Count = _ctx.IntegerValue("ListVirtualPhysicalConnections.Count");

			List<ListVirtualPhysicalConnectionsResponse.ListVirtualPhysicalConnections_VirtualPhysicalConnection> listVirtualPhysicalConnectionsResponse_virtualPhysicalConnections = new List<ListVirtualPhysicalConnectionsResponse.ListVirtualPhysicalConnections_VirtualPhysicalConnection>();
			for (int i = 0; i < _ctx.Length("ListVirtualPhysicalConnections.VirtualPhysicalConnections.Length"); i++) {
				ListVirtualPhysicalConnectionsResponse.ListVirtualPhysicalConnections_VirtualPhysicalConnection virtualPhysicalConnection = new ListVirtualPhysicalConnectionsResponse.ListVirtualPhysicalConnections_VirtualPhysicalConnection();
				virtualPhysicalConnection.Type = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].Type");
				virtualPhysicalConnection.Status = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].Status");
				virtualPhysicalConnection.CreationTime = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].CreationTime");
				virtualPhysicalConnection.AdLocation = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].AdLocation");
				virtualPhysicalConnection.PortNumber = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].PortNumber");
				virtualPhysicalConnection.Spec = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].Spec");
				virtualPhysicalConnection.ChargeType = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].ChargeType");
				virtualPhysicalConnection.Description = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].Description");
				virtualPhysicalConnection.Bandwidth = _ctx.LongValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].Bandwidth");
				virtualPhysicalConnection.EnabledTime = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].EnabledTime");
				virtualPhysicalConnection.LineOperator = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].LineOperator");
				virtualPhysicalConnection.PeerLocation = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].PeerLocation");
				virtualPhysicalConnection.RedundantPhysicalConnectionId = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].RedundantPhysicalConnectionId");
				virtualPhysicalConnection.Name = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].Name");
				virtualPhysicalConnection.CircuitCode = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].CircuitCode");
				virtualPhysicalConnection.EndTime = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].EndTime");
				virtualPhysicalConnection.PortType = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].PortType");
				virtualPhysicalConnection.BusinessStatus = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].BusinessStatus");
				virtualPhysicalConnection.LoaStatus = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].LoaStatus");
				virtualPhysicalConnection.AccessPointId = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].AccessPointId");
				virtualPhysicalConnection.PhysicalConnectionId = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].PhysicalConnectionId");
				virtualPhysicalConnection.ProductType = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].ProductType");
				virtualPhysicalConnection.ParentPhysicalConnectionId = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].ParentPhysicalConnectionId");
				virtualPhysicalConnection.VirtualPhysicalConnectionStatus = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].VirtualPhysicalConnectionStatus");
				virtualPhysicalConnection.ParentPhysicalConnectionAliUid = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].ParentPhysicalConnectionAliUid");
				virtualPhysicalConnection.OrderMode = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].OrderMode");
				virtualPhysicalConnection.AliUid = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].AliUid");
				virtualPhysicalConnection.VlanId = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].VlanId");
				virtualPhysicalConnection.ExpectSpec = _ctx.StringValue("ListVirtualPhysicalConnections.VirtualPhysicalConnections["+ i +"].ExpectSpec");

				listVirtualPhysicalConnectionsResponse_virtualPhysicalConnections.Add(virtualPhysicalConnection);
			}
			listVirtualPhysicalConnectionsResponse.VirtualPhysicalConnections = listVirtualPhysicalConnectionsResponse_virtualPhysicalConnections;
        
			return listVirtualPhysicalConnectionsResponse;
        }
    }
}
