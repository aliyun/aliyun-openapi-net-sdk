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
    public class DescribeDcdnDomainRegionDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainRegionDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainRegionDataResponse describeDcdnDomainRegionDataResponse = new DescribeDcdnDomainRegionDataResponse();

			describeDcdnDomainRegionDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainRegionDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainRegionData.RequestId");
			describeDcdnDomainRegionDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainRegionData.DomainName");
			describeDcdnDomainRegionDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainRegionData.DataInterval");
			describeDcdnDomainRegionDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainRegionData.StartTime");
			describeDcdnDomainRegionDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainRegionData.EndTime");

			List<DescribeDcdnDomainRegionDataResponse.DescribeDcdnDomainRegionData_RegionProportionData> describeDcdnDomainRegionDataResponse_value = new List<DescribeDcdnDomainRegionDataResponse.DescribeDcdnDomainRegionData_RegionProportionData>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainRegionData.Value.Length"); i++) {
				DescribeDcdnDomainRegionDataResponse.DescribeDcdnDomainRegionData_RegionProportionData regionProportionData = new DescribeDcdnDomainRegionDataResponse.DescribeDcdnDomainRegionData_RegionProportionData();
				regionProportionData.Region = _ctx.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].Region");
				regionProportionData.Proportion = _ctx.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].Proportion");
				regionProportionData.RegionEname = _ctx.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].RegionEname");
				regionProportionData.AvgObjectSize = _ctx.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].AvgObjectSize");
				regionProportionData.AvgResponseTime = _ctx.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].AvgResponseTime");
				regionProportionData.Bps = _ctx.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].Bps");
				regionProportionData.Qps = _ctx.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].Qps");
				regionProportionData.AvgResponseRate = _ctx.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].AvgResponseRate");
				regionProportionData.TotalBytes = _ctx.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].TotalBytes");
				regionProportionData.BytesProportion = _ctx.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].BytesProportion");
				regionProportionData.TotalQuery = _ctx.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].TotalQuery");

				describeDcdnDomainRegionDataResponse_value.Add(regionProportionData);
			}
			describeDcdnDomainRegionDataResponse._Value = describeDcdnDomainRegionDataResponse_value;
        
			return describeDcdnDomainRegionDataResponse;
        }
    }
}
