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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeCdnRegionAndIspResponseUnmarshaller
    {
        public static DescribeCdnRegionAndIspResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCdnRegionAndIspResponse describeCdnRegionAndIspResponse = new DescribeCdnRegionAndIspResponse();

			describeCdnRegionAndIspResponse.HttpResponse = context.HttpResponse;
			describeCdnRegionAndIspResponse.RequestId = context.StringValue("DescribeCdnRegionAndIsp.RequestId");

			List<DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Region> describeCdnRegionAndIspResponse_regions = new List<DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Region>();
			for (int i = 0; i < context.Length("DescribeCdnRegionAndIsp.Regions.Length"); i++) {
				DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Region region = new DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Region();
				region.NameZh = context.StringValue("DescribeCdnRegionAndIsp.Regions["+ i +"].NameZh");
				region.NameEn = context.StringValue("DescribeCdnRegionAndIsp.Regions["+ i +"].NameEn");

				describeCdnRegionAndIspResponse_regions.Add(region);
			}
			describeCdnRegionAndIspResponse.Regions = describeCdnRegionAndIspResponse_regions;

			List<DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Isp> describeCdnRegionAndIspResponse_isps = new List<DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Isp>();
			for (int i = 0; i < context.Length("DescribeCdnRegionAndIsp.Isps.Length"); i++) {
				DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Isp isp = new DescribeCdnRegionAndIspResponse.DescribeCdnRegionAndIsp_Isp();
				isp.NameZh = context.StringValue("DescribeCdnRegionAndIsp.Isps["+ i +"].NameZh");
				isp.NameEn = context.StringValue("DescribeCdnRegionAndIsp.Isps["+ i +"].NameEn");

				describeCdnRegionAndIspResponse_isps.Add(isp);
			}
			describeCdnRegionAndIspResponse.Isps = describeCdnRegionAndIspResponse_isps;
        
			return describeCdnRegionAndIspResponse;
        }
    }
}