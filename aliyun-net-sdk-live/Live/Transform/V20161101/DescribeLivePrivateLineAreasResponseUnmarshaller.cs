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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLivePrivateLineAreasResponseUnmarshaller
    {
        public static DescribeLivePrivateLineAreasResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLivePrivateLineAreasResponse describeLivePrivateLineAreasResponse = new DescribeLivePrivateLineAreasResponse();

			describeLivePrivateLineAreasResponse.HttpResponse = _ctx.HttpResponse;
			describeLivePrivateLineAreasResponse.RequestId = _ctx.StringValue("DescribeLivePrivateLineAreas.RequestId");

			List<DescribeLivePrivateLineAreasResponse.DescribeLivePrivateLineAreas_LiveArea> describeLivePrivateLineAreasResponse_liveAreasList = new List<DescribeLivePrivateLineAreasResponse.DescribeLivePrivateLineAreas_LiveArea>();
			for (int i = 0; i < _ctx.Length("DescribeLivePrivateLineAreas.LiveAreasList.Length"); i++) {
				DescribeLivePrivateLineAreasResponse.DescribeLivePrivateLineAreas_LiveArea liveArea = new DescribeLivePrivateLineAreasResponse.DescribeLivePrivateLineAreas_LiveArea();
				liveArea.RegionType = _ctx.StringValue("DescribeLivePrivateLineAreas.LiveAreasList["+ i +"].RegionType");

				List<DescribeLivePrivateLineAreasResponse.DescribeLivePrivateLineAreas_LiveArea.DescribeLivePrivateLineAreas_Region> liveArea_regions = new List<DescribeLivePrivateLineAreasResponse.DescribeLivePrivateLineAreas_LiveArea.DescribeLivePrivateLineAreas_Region>();
				for (int j = 0; j < _ctx.Length("DescribeLivePrivateLineAreas.LiveAreasList["+ i +"].Regions.Length"); j++) {
					DescribeLivePrivateLineAreasResponse.DescribeLivePrivateLineAreas_LiveArea.DescribeLivePrivateLineAreas_Region region = new DescribeLivePrivateLineAreasResponse.DescribeLivePrivateLineAreas_LiveArea.DescribeLivePrivateLineAreas_Region();
					region.LocalName = _ctx.StringValue("DescribeLivePrivateLineAreas.LiveAreasList["+ i +"].Regions["+ j +"].LocalName");
					region.RegionId = _ctx.StringValue("DescribeLivePrivateLineAreas.LiveAreasList["+ i +"].Regions["+ j +"].RegionId");

					liveArea_regions.Add(region);
				}
				liveArea.Regions = liveArea_regions;

				describeLivePrivateLineAreasResponse_liveAreasList.Add(liveArea);
			}
			describeLivePrivateLineAreasResponse.LiveAreasList = describeLivePrivateLineAreasResponse_liveAreasList;
        
			return describeLivePrivateLineAreasResponse;
        }
    }
}
