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
    public class ListVpcEndpointZonesResponseUnmarshaller
    {
        public static ListVpcEndpointZonesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpcEndpointZonesResponse listVpcEndpointZonesResponse = new ListVpcEndpointZonesResponse();

			listVpcEndpointZonesResponse.HttpResponse = _ctx.HttpResponse;
			listVpcEndpointZonesResponse.RequestId = _ctx.StringValue("ListVpcEndpointZones.RequestId");
			listVpcEndpointZonesResponse.NextToken = _ctx.StringValue("ListVpcEndpointZones.NextToken");
			listVpcEndpointZonesResponse.MaxResults = _ctx.StringValue("ListVpcEndpointZones.MaxResults");

			List<ListVpcEndpointZonesResponse.ListVpcEndpointZones_Zone> listVpcEndpointZonesResponse_zones = new List<ListVpcEndpointZonesResponse.ListVpcEndpointZones_Zone>();
			for (int i = 0; i < _ctx.Length("ListVpcEndpointZones.Zones.Length"); i++) {
				ListVpcEndpointZonesResponse.ListVpcEndpointZones_Zone zone = new ListVpcEndpointZonesResponse.ListVpcEndpointZones_Zone();
				zone.EniId = _ctx.StringValue("ListVpcEndpointZones.Zones["+ i +"].EniId");
				zone.ZoneId = _ctx.StringValue("ListVpcEndpointZones.Zones["+ i +"].ZoneId");
				zone.ServiceStatus = _ctx.StringValue("ListVpcEndpointZones.Zones["+ i +"].ServiceStatus");
				zone.VSwitchId = _ctx.StringValue("ListVpcEndpointZones.Zones["+ i +"].VSwitchId");
				zone.EniIp = _ctx.StringValue("ListVpcEndpointZones.Zones["+ i +"].EniIp");
				zone.ZoneStatus = _ctx.StringValue("ListVpcEndpointZones.Zones["+ i +"].ZoneStatus");
				zone.RegionId = _ctx.StringValue("ListVpcEndpointZones.Zones["+ i +"].RegionId");
				zone.ZoneDomain = _ctx.StringValue("ListVpcEndpointZones.Zones["+ i +"].ZoneDomain");

				listVpcEndpointZonesResponse_zones.Add(zone);
			}
			listVpcEndpointZonesResponse.Zones = listVpcEndpointZonesResponse_zones;
        
			return listVpcEndpointZonesResponse;
        }
    }
}
