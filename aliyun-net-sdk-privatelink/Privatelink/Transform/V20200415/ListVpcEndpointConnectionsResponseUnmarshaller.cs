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
using Aliyun.Acs.Privatelink.Model.V20200415;

namespace Aliyun.Acs.Privatelink.Transform.V20200415
{
    public class ListVpcEndpointConnectionsResponseUnmarshaller
    {
        public static ListVpcEndpointConnectionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpcEndpointConnectionsResponse listVpcEndpointConnectionsResponse = new ListVpcEndpointConnectionsResponse();

			listVpcEndpointConnectionsResponse.HttpResponse = _ctx.HttpResponse;
			listVpcEndpointConnectionsResponse.NextToken = _ctx.StringValue("ListVpcEndpointConnections.NextToken");
			listVpcEndpointConnectionsResponse.RequestId = _ctx.StringValue("ListVpcEndpointConnections.RequestId");
			listVpcEndpointConnectionsResponse.MaxResults = _ctx.StringValue("ListVpcEndpointConnections.MaxResults");

			List<ListVpcEndpointConnectionsResponse.ListVpcEndpointConnections_Connection> listVpcEndpointConnectionsResponse_connections = new List<ListVpcEndpointConnectionsResponse.ListVpcEndpointConnections_Connection>();
			for (int i = 0; i < _ctx.Length("ListVpcEndpointConnections.Connections.Length"); i++) {
				ListVpcEndpointConnectionsResponse.ListVpcEndpointConnections_Connection connection = new ListVpcEndpointConnectionsResponse.ListVpcEndpointConnections_Connection();
				connection.ResourceOwner = _ctx.BooleanValue("ListVpcEndpointConnections.Connections["+ i +"].ResourceOwner");
				connection.ModifiedTime = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].ModifiedTime");
				connection.Bandwidth = _ctx.IntegerValue("ListVpcEndpointConnections.Connections["+ i +"].Bandwidth");
				connection.EndpointOwnerId = _ctx.LongValue("ListVpcEndpointConnections.Connections["+ i +"].EndpointOwnerId");
				connection.ServiceId = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].ServiceId");
				connection.ConnectionStatus = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].ConnectionStatus");
				connection.EndpointId = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].EndpointId");
				connection.EndpointVpcId = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].EndpointVpcId");

				List<ListVpcEndpointConnectionsResponse.ListVpcEndpointConnections_Connection.ListVpcEndpointConnections_Zone> connection_zones = new List<ListVpcEndpointConnectionsResponse.ListVpcEndpointConnections_Connection.ListVpcEndpointConnections_Zone>();
				for (int j = 0; j < _ctx.Length("ListVpcEndpointConnections.Connections["+ i +"].Zones.Length"); j++) {
					ListVpcEndpointConnectionsResponse.ListVpcEndpointConnections_Connection.ListVpcEndpointConnections_Zone zone = new ListVpcEndpointConnectionsResponse.ListVpcEndpointConnections_Connection.ListVpcEndpointConnections_Zone();
					zone.VSwitchId = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].Zones["+ j +"].VSwitchId");
					zone.ZoneId = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].Zones["+ j +"].ZoneId");
					zone.ResourceId = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].Zones["+ j +"].ResourceId");
					zone.EniId = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].Zones["+ j +"].EniId");
					zone.ZoneDomain = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].Zones["+ j +"].ZoneDomain");
					zone.ZoneStatus = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].Zones["+ j +"].ZoneStatus");
					zone.ReplacedResourceId = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].Zones["+ j +"].ReplacedResourceId");
					zone.ReplacedEniId = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].Zones["+ j +"].ReplacedEniId");
					zone.StatusInfo = _ctx.StringValue("ListVpcEndpointConnections.Connections["+ i +"].Zones["+ j +"].StatusInfo");

					connection_zones.Add(zone);
				}
				connection.Zones = connection_zones;

				listVpcEndpointConnectionsResponse_connections.Add(connection);
			}
			listVpcEndpointConnectionsResponse.Connections = listVpcEndpointConnectionsResponse_connections;
        
			return listVpcEndpointConnectionsResponse;
        }
    }
}
