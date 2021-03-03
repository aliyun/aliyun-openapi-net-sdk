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
    public class DescribeDcdnRegionAndIspResponseUnmarshaller
    {
        public static DescribeDcdnRegionAndIspResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnRegionAndIspResponse describeDcdnRegionAndIspResponse = new DescribeDcdnRegionAndIspResponse();

			describeDcdnRegionAndIspResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnRegionAndIspResponse.RequestId = _ctx.StringValue("DescribeDcdnRegionAndIsp.RequestId");

			List<DescribeDcdnRegionAndIspResponse.DescribeDcdnRegionAndIsp_Region> describeDcdnRegionAndIspResponse_regions = new List<DescribeDcdnRegionAndIspResponse.DescribeDcdnRegionAndIsp_Region>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnRegionAndIsp.Regions.Length"); i++) {
				DescribeDcdnRegionAndIspResponse.DescribeDcdnRegionAndIsp_Region region = new DescribeDcdnRegionAndIspResponse.DescribeDcdnRegionAndIsp_Region();
				region.NameZh = _ctx.StringValue("DescribeDcdnRegionAndIsp.Regions["+ i +"].NameZh");
				region.NameEn = _ctx.StringValue("DescribeDcdnRegionAndIsp.Regions["+ i +"].NameEn");

				describeDcdnRegionAndIspResponse_regions.Add(region);
			}
			describeDcdnRegionAndIspResponse.Regions = describeDcdnRegionAndIspResponse_regions;

			List<DescribeDcdnRegionAndIspResponse.DescribeDcdnRegionAndIsp_Isp> describeDcdnRegionAndIspResponse_isps = new List<DescribeDcdnRegionAndIspResponse.DescribeDcdnRegionAndIsp_Isp>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnRegionAndIsp.Isps.Length"); i++) {
				DescribeDcdnRegionAndIspResponse.DescribeDcdnRegionAndIsp_Isp isp = new DescribeDcdnRegionAndIspResponse.DescribeDcdnRegionAndIsp_Isp();
				isp.NameZh = _ctx.StringValue("DescribeDcdnRegionAndIsp.Isps["+ i +"].NameZh");
				isp.NameEn = _ctx.StringValue("DescribeDcdnRegionAndIsp.Isps["+ i +"].NameEn");

				describeDcdnRegionAndIspResponse_isps.Add(isp);
			}
			describeDcdnRegionAndIspResponse.Isps = describeDcdnRegionAndIspResponse_isps;
        
			return describeDcdnRegionAndIspResponse;
        }
    }
}
