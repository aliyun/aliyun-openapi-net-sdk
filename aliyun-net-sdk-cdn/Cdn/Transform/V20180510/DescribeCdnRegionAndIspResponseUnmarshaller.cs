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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnRegionAndIspResponseUnmarshaller
    {
        public static DescribeCdnRegionAndIspResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnRegionAndIspResponse describeCdnRegionAndIspResponse = new DescribeCdnRegionAndIspResponse();

			describeCdnRegionAndIspResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnRegionAndIspResponse.RequestId = _ctx.StringValue("DescribeCdnRegionAndIsp.RequestId");

			List<DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Region> describeCdnRegionAndIspResponse_regions = new List<DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Region>();
			for (int i = 0; i < _ctx.Length("DescribeCdnRegionAndIsp.Regions.Length"); i++) {
				DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Region region = new DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Region();
				region.NameEn = _ctx.StringValue("DescribeCdnRegionAndIsp.Regions["+ i +"].NameEn");
				region.NameZh = _ctx.StringValue("DescribeCdnRegionAndIsp.Regions["+ i +"].NameZh");

				describeCdnRegionAndIspResponse_regions.Add(region);
			}
			describeCdnRegionAndIspResponse.Regions = describeCdnRegionAndIspResponse_regions;

			List<DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Isp> describeCdnRegionAndIspResponse_isps = new List<DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Isp>();
			for (int i = 0; i < _ctx.Length("DescribeCdnRegionAndIsp.Isps.Length"); i++) {
				DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Isp isp = new DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Isp();
				isp.NameEn = _ctx.StringValue("DescribeCdnRegionAndIsp.Isps["+ i +"].NameEn");
				isp.NameZh = _ctx.StringValue("DescribeCdnRegionAndIsp.Isps["+ i +"].NameZh");

				describeCdnRegionAndIspResponse_isps.Add(isp);
			}
			describeCdnRegionAndIspResponse.Isps = describeCdnRegionAndIspResponse_isps;
        
			return describeCdnRegionAndIspResponse;
        }
    }
}
