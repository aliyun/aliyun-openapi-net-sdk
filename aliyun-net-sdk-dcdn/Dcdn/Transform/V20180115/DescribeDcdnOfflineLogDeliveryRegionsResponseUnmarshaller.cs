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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnOfflineLogDeliveryRegionsResponseUnmarshaller
    {
        public static DescribeDcdnOfflineLogDeliveryRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnOfflineLogDeliveryRegionsResponse describeDcdnOfflineLogDeliveryRegionsResponse = new DescribeDcdnOfflineLogDeliveryRegionsResponse();

			describeDcdnOfflineLogDeliveryRegionsResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnOfflineLogDeliveryRegionsResponse.RequestId = _ctx.StringValue("DescribeDcdnOfflineLogDeliveryRegions.RequestId");

			List<DescribeDcdnOfflineLogDeliveryRegionsResponse.DescribeDcdnOfflineLogDeliveryRegions_Area> describeDcdnOfflineLogDeliveryRegionsResponse_areas = new List<DescribeDcdnOfflineLogDeliveryRegionsResponse.DescribeDcdnOfflineLogDeliveryRegions_Area>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnOfflineLogDeliveryRegions.Areas.Length"); i++) {
				DescribeDcdnOfflineLogDeliveryRegionsResponse.DescribeDcdnOfflineLogDeliveryRegions_Area area = new DescribeDcdnOfflineLogDeliveryRegionsResponse.DescribeDcdnOfflineLogDeliveryRegions_Area();
				area.AreaId = _ctx.StringValue("DescribeDcdnOfflineLogDeliveryRegions.Areas["+ i +"].AreaId");
				area.AreaName = _ctx.StringValue("DescribeDcdnOfflineLogDeliveryRegions.Areas["+ i +"].AreaName");

				List<DescribeDcdnOfflineLogDeliveryRegionsResponse.DescribeDcdnOfflineLogDeliveryRegions_Area.DescribeDcdnOfflineLogDeliveryRegions_RegionInfo> area_regionInfos = new List<DescribeDcdnOfflineLogDeliveryRegionsResponse.DescribeDcdnOfflineLogDeliveryRegions_Area.DescribeDcdnOfflineLogDeliveryRegions_RegionInfo>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnOfflineLogDeliveryRegions.Areas["+ i +"].RegionInfos.Length"); j++) {
					DescribeDcdnOfflineLogDeliveryRegionsResponse.DescribeDcdnOfflineLogDeliveryRegions_Area.DescribeDcdnOfflineLogDeliveryRegions_RegionInfo regionInfo = new DescribeDcdnOfflineLogDeliveryRegionsResponse.DescribeDcdnOfflineLogDeliveryRegions_Area.DescribeDcdnOfflineLogDeliveryRegions_RegionInfo();
					regionInfo.RegionId = _ctx.StringValue("DescribeDcdnOfflineLogDeliveryRegions.Areas["+ i +"].RegionInfos["+ j +"].RegionId");
					regionInfo.RegionName = _ctx.StringValue("DescribeDcdnOfflineLogDeliveryRegions.Areas["+ i +"].RegionInfos["+ j +"].RegionName");
					regionInfo.IsOverseas = _ctx.StringValue("DescribeDcdnOfflineLogDeliveryRegions.Areas["+ i +"].RegionInfos["+ j +"].IsOverseas");
					regionInfo.OssEndpoint = _ctx.StringValue("DescribeDcdnOfflineLogDeliveryRegions.Areas["+ i +"].RegionInfos["+ j +"].OssEndpoint");

					area_regionInfos.Add(regionInfo);
				}
				area.RegionInfos = area_regionInfos;

				describeDcdnOfflineLogDeliveryRegionsResponse_areas.Add(area);
			}
			describeDcdnOfflineLogDeliveryRegionsResponse.Areas = describeDcdnOfflineLogDeliveryRegionsResponse_areas;
        
			return describeDcdnOfflineLogDeliveryRegionsResponse;
        }
    }
}
