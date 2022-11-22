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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeInstanceCreatableZoneResponseUnmarshaller
    {
        public static DescribeInstanceCreatableZoneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceCreatableZoneResponse describeInstanceCreatableZoneResponse = new DescribeInstanceCreatableZoneResponse();

			describeInstanceCreatableZoneResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceCreatableZoneResponse.RequestId = _ctx.StringValue("DescribeInstanceCreatableZone.RequestId");

			List<DescribeInstanceCreatableZoneResponse.DescribeInstanceCreatableZone_ZoneListItem> describeInstanceCreatableZoneResponse_zoneList = new List<DescribeInstanceCreatableZoneResponse.DescribeInstanceCreatableZone_ZoneListItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceCreatableZone.ZoneList.Length"); i++) {
				DescribeInstanceCreatableZoneResponse.DescribeInstanceCreatableZone_ZoneListItem zoneListItem = new DescribeInstanceCreatableZoneResponse.DescribeInstanceCreatableZone_ZoneListItem();
				zoneListItem.IsInCluster = _ctx.BooleanValue("DescribeInstanceCreatableZone.ZoneList["+ i +"].IsInCluster");
				zoneListItem.Zone = _ctx.StringValue("DescribeInstanceCreatableZone.ZoneList["+ i +"].Zone");

				describeInstanceCreatableZoneResponse_zoneList.Add(zoneListItem);
			}
			describeInstanceCreatableZoneResponse.ZoneList = describeInstanceCreatableZoneResponse_zoneList;
        
			return describeInstanceCreatableZoneResponse;
        }
    }
}
