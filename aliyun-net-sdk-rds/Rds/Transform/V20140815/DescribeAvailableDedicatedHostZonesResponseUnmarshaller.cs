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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeAvailableDedicatedHostZonesResponseUnmarshaller
    {
        public static DescribeAvailableDedicatedHostZonesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableDedicatedHostZonesResponse describeAvailableDedicatedHostZonesResponse = new DescribeAvailableDedicatedHostZonesResponse();

			describeAvailableDedicatedHostZonesResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableDedicatedHostZonesResponse.RequestId = _ctx.StringValue("DescribeAvailableDedicatedHostZones.RequestId");

			List<DescribeAvailableDedicatedHostZonesResponse.DescribeAvailableDedicatedHostZones_DedicatedHostZones> describeAvailableDedicatedHostZonesResponse_zones = new List<DescribeAvailableDedicatedHostZonesResponse.DescribeAvailableDedicatedHostZones_DedicatedHostZones>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableDedicatedHostZones.Zones.Length"); i++) {
				DescribeAvailableDedicatedHostZonesResponse.DescribeAvailableDedicatedHostZones_DedicatedHostZones dedicatedHostZones = new DescribeAvailableDedicatedHostZonesResponse.DescribeAvailableDedicatedHostZones_DedicatedHostZones();
				dedicatedHostZones.ZoneId = _ctx.StringValue("DescribeAvailableDedicatedHostZones.Zones["+ i +"].ZoneId");
				dedicatedHostZones.Description = _ctx.StringValue("DescribeAvailableDedicatedHostZones.Zones["+ i +"].Description");

				describeAvailableDedicatedHostZonesResponse_zones.Add(dedicatedHostZones);
			}
			describeAvailableDedicatedHostZonesResponse.Zones = describeAvailableDedicatedHostZonesResponse_zones;
        
			return describeAvailableDedicatedHostZonesResponse;
        }
    }
}
