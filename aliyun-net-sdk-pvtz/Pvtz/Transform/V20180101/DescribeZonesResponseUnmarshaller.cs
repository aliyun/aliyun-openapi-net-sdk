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
using Aliyun.Acs.pvtz.Model.V20180101;

namespace Aliyun.Acs.pvtz.Transform.V20180101
{
    public class DescribeZonesResponseUnmarshaller
    {
        public static DescribeZonesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeZonesResponse describeZonesResponse = new DescribeZonesResponse();

			describeZonesResponse.HttpResponse = context.HttpResponse;
			describeZonesResponse.RequestId = context.StringValue("DescribeZones.RequestId");
			describeZonesResponse.TotalItems = context.IntegerValue("DescribeZones.TotalItems");
			describeZonesResponse.TotalPages = context.IntegerValue("DescribeZones.TotalPages");
			describeZonesResponse.PageSize = context.IntegerValue("DescribeZones.PageSize");
			describeZonesResponse.PageNumber = context.IntegerValue("DescribeZones.PageNumber");

			List<DescribeZonesResponse.DescribeZones_Zone> describeZonesResponse_zones = new List<DescribeZonesResponse.DescribeZones_Zone>();
			for (int i = 0; i < context.Length("DescribeZones.Zones.Length"); i++) {
				DescribeZonesResponse.DescribeZones_Zone zone = new DescribeZonesResponse.DescribeZones_Zone();
				zone.ZoneId = context.StringValue("DescribeZones.Zones["+ i +"].ZoneId");
				zone.ZoneName = context.StringValue("DescribeZones.Zones["+ i +"].ZoneName");
				zone.Remark = context.StringValue("DescribeZones.Zones["+ i +"].Remark");
				zone.RecordCount = context.IntegerValue("DescribeZones.Zones["+ i +"].RecordCount");
				zone.CreateTime = context.StringValue("DescribeZones.Zones["+ i +"].CreateTime");
				zone.CreateTimestamp = context.LongValue("DescribeZones.Zones["+ i +"].CreateTimestamp");
				zone.UpdateTime = context.StringValue("DescribeZones.Zones["+ i +"].UpdateTime");
				zone.UpdateTimestamp = context.LongValue("DescribeZones.Zones["+ i +"].UpdateTimestamp");
				zone.IsPtr = context.BooleanValue("DescribeZones.Zones["+ i +"].IsPtr");
				zone.ProxyPattern = context.StringValue("DescribeZones.Zones["+ i +"].ProxyPattern");

				describeZonesResponse_zones.Add(zone);
			}
			describeZonesResponse.Zones = describeZonesResponse_zones;
        
			return describeZonesResponse;
        }
    }
}
