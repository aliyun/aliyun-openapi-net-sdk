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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeZonesResponseUnmarshaller
    {
        public static DescribeZonesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeZonesResponse describeZonesResponse = new DescribeZonesResponse();

			describeZonesResponse.HttpResponse = context.HttpResponse;
			describeZonesResponse.RequestId = context.StringValue("DescribeZones.RequestId");

			List<DescribeZonesResponse.Zone> zones = new List<DescribeZonesResponse.Zone>();
			for (int i = 0; i < context.Length("DescribeZones.Zones.Length"); i++) {
				DescribeZonesResponse.Zone zone = new DescribeZonesResponse.Zone();
				zone.ZoneId = context.StringValue("DescribeZones.Zones["+ i +"].ZoneId");
				zone.LocalName = context.StringValue("DescribeZones.Zones["+ i +"].LocalName");

				List<string> availableResourceCreation = new List<string>();
				for (int j = 0; j < context.Length("DescribeZones.Zones["+ i +"].AvailableResourceCreation.Length"); j++) {
					availableResourceCreation.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableResourceCreation["+ j +"]"));
				}
				zone.AvailableResourceCreation = availableResourceCreation;

				List<string> availableDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("DescribeZones.Zones["+ i +"].AvailableDiskCategories.Length"); j++) {
					availableDiskCategories.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableDiskCategories["+ j +"]"));
				}
				zone.AvailableDiskCategories = availableDiskCategories;

				zones.Add(zone);
			}
			describeZonesResponse.Zones = zones;
        
			return describeZonesResponse;
        }
    }
}