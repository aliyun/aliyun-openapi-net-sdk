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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeZonesResponseUnmarshaller
    {
        public static DescribeZonesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeZonesResponse describeZonesResponse = new DescribeZonesResponse();

			describeZonesResponse.HttpResponse = _ctx.HttpResponse;
			describeZonesResponse.RequestId = _ctx.StringValue("DescribeZones.RequestId");

			List<DescribeZonesResponse.DescribeZones_Zone> describeZonesResponse_zones = new List<DescribeZonesResponse.DescribeZones_Zone>();
			for (int i = 0; i < _ctx.Length("DescribeZones.Zones.Length"); i++) {
				DescribeZonesResponse.DescribeZones_Zone zone = new DescribeZonesResponse.DescribeZones_Zone();
				zone.ZoneId = _ctx.StringValue("DescribeZones.Zones["+ i +"].ZoneId");
				zone.LocalName = _ctx.StringValue("DescribeZones.Zones["+ i +"].LocalName");

				List<DescribeZonesResponse.DescribeZones_Zone.DescribeZones_SlaveZone> zone_slaveZones = new List<DescribeZonesResponse.DescribeZones_Zone.DescribeZones_SlaveZone>();
				for (int j = 0; j < _ctx.Length("DescribeZones.Zones["+ i +"].SlaveZones.Length"); j++) {
					DescribeZonesResponse.DescribeZones_Zone.DescribeZones_SlaveZone slaveZone = new DescribeZonesResponse.DescribeZones_Zone.DescribeZones_SlaveZone();
					slaveZone.ZoneId = _ctx.StringValue("DescribeZones.Zones["+ i +"].SlaveZones["+ j +"].ZoneId");
					slaveZone.LocalName = _ctx.StringValue("DescribeZones.Zones["+ i +"].SlaveZones["+ j +"].LocalName");

					zone_slaveZones.Add(slaveZone);
				}
				zone.SlaveZones = zone_slaveZones;

				describeZonesResponse_zones.Add(zone);
			}
			describeZonesResponse.Zones = describeZonesResponse_zones;
        
			return describeZonesResponse;
        }
    }
}
