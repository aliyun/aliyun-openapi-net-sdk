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
    public class ListEnhanhcedNatGatewayAvailableZonesResponseUnmarshaller
    {
        public static ListEnhanhcedNatGatewayAvailableZonesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEnhanhcedNatGatewayAvailableZonesResponse listEnhanhcedNatGatewayAvailableZonesResponse = new ListEnhanhcedNatGatewayAvailableZonesResponse();

			listEnhanhcedNatGatewayAvailableZonesResponse.HttpResponse = _ctx.HttpResponse;
			listEnhanhcedNatGatewayAvailableZonesResponse.RequestId = _ctx.StringValue("ListEnhanhcedNatGatewayAvailableZones.RequestId");

			List<ListEnhanhcedNatGatewayAvailableZonesResponse.ListEnhanhcedNatGatewayAvailableZones_Zone> listEnhanhcedNatGatewayAvailableZonesResponse_zones = new List<ListEnhanhcedNatGatewayAvailableZonesResponse.ListEnhanhcedNatGatewayAvailableZones_Zone>();
			for (int i = 0; i < _ctx.Length("ListEnhanhcedNatGatewayAvailableZones.Zones.Length"); i++) {
				ListEnhanhcedNatGatewayAvailableZonesResponse.ListEnhanhcedNatGatewayAvailableZones_Zone zone = new ListEnhanhcedNatGatewayAvailableZonesResponse.ListEnhanhcedNatGatewayAvailableZones_Zone();
				zone.ZoneId = _ctx.StringValue("ListEnhanhcedNatGatewayAvailableZones.Zones["+ i +"].ZoneId");
				zone.LocalName = _ctx.StringValue("ListEnhanhcedNatGatewayAvailableZones.Zones["+ i +"].LocalName");

				listEnhanhcedNatGatewayAvailableZonesResponse_zones.Add(zone);
			}
			listEnhanhcedNatGatewayAvailableZonesResponse.Zones = listEnhanhcedNatGatewayAvailableZonesResponse_zones;
        
			return listEnhanhcedNatGatewayAvailableZonesResponse;
        }
    }
}
