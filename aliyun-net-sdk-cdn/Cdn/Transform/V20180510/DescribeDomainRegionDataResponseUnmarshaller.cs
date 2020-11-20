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
    public class DescribeDomainRegionDataResponseUnmarshaller
    {
        public static DescribeDomainRegionDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainRegionDataResponse describeDomainRegionDataResponse = new DescribeDomainRegionDataResponse();

			describeDomainRegionDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainRegionDataResponse.RequestId = _ctx.StringValue("DescribeDomainRegionData.RequestId");
			describeDomainRegionDataResponse.DomainName = _ctx.StringValue("DescribeDomainRegionData.DomainName");
			describeDomainRegionDataResponse.DataInterval = _ctx.StringValue("DescribeDomainRegionData.DataInterval");
			describeDomainRegionDataResponse.StartTime = _ctx.StringValue("DescribeDomainRegionData.StartTime");
			describeDomainRegionDataResponse.EndTime = _ctx.StringValue("DescribeDomainRegionData.EndTime");

			List<DescribeDomainRegionDataResponse.DescribeDomainRegionData_RegionProportionData> describeDomainRegionDataResponse_value = new List<DescribeDomainRegionDataResponse.DescribeDomainRegionData_RegionProportionData>();
			for (int i = 0; i < _ctx.Length("DescribeDomainRegionData.Value.Length"); i++) {
				DescribeDomainRegionDataResponse.DescribeDomainRegionData_RegionProportionData regionProportionData = new DescribeDomainRegionDataResponse.DescribeDomainRegionData_RegionProportionData();
				regionProportionData.Region = _ctx.StringValue("DescribeDomainRegionData.Value["+ i +"].Region");
				regionProportionData.Proportion = _ctx.StringValue("DescribeDomainRegionData.Value["+ i +"].Proportion");
				regionProportionData.RegionEname = _ctx.StringValue("DescribeDomainRegionData.Value["+ i +"].RegionEname");
				regionProportionData.AvgObjectSize = _ctx.StringValue("DescribeDomainRegionData.Value["+ i +"].AvgObjectSize");
				regionProportionData.AvgResponseTime = _ctx.StringValue("DescribeDomainRegionData.Value["+ i +"].AvgResponseTime");
				regionProportionData.Bps = _ctx.StringValue("DescribeDomainRegionData.Value["+ i +"].Bps");
				regionProportionData.Qps = _ctx.StringValue("DescribeDomainRegionData.Value["+ i +"].Qps");
				regionProportionData.AvgResponseRate = _ctx.StringValue("DescribeDomainRegionData.Value["+ i +"].AvgResponseRate");
				regionProportionData.ReqErrRate = _ctx.StringValue("DescribeDomainRegionData.Value["+ i +"].ReqErrRate");
				regionProportionData.TotalBytes = _ctx.StringValue("DescribeDomainRegionData.Value["+ i +"].TotalBytes");
				regionProportionData.BytesProportion = _ctx.StringValue("DescribeDomainRegionData.Value["+ i +"].BytesProportion");
				regionProportionData.TotalQuery = _ctx.StringValue("DescribeDomainRegionData.Value["+ i +"].TotalQuery");

				describeDomainRegionDataResponse_value.Add(regionProportionData);
			}
			describeDomainRegionDataResponse._Value = describeDomainRegionDataResponse_value;
        
			return describeDomainRegionDataResponse;
        }
    }
}
