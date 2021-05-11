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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDomainRegionDataResponseUnmarshaller
    {
        public static DescribeScdnDomainRegionDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnDomainRegionDataResponse describeScdnDomainRegionDataResponse = new DescribeScdnDomainRegionDataResponse();

			describeScdnDomainRegionDataResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnDomainRegionDataResponse.RequestId = _ctx.StringValue("DescribeScdnDomainRegionData.RequestId");
			describeScdnDomainRegionDataResponse.DomainName = _ctx.StringValue("DescribeScdnDomainRegionData.DomainName");
			describeScdnDomainRegionDataResponse.DataInterval = _ctx.StringValue("DescribeScdnDomainRegionData.DataInterval");
			describeScdnDomainRegionDataResponse.StartTime = _ctx.StringValue("DescribeScdnDomainRegionData.StartTime");
			describeScdnDomainRegionDataResponse.EndTime = _ctx.StringValue("DescribeScdnDomainRegionData.EndTime");

			List<DescribeScdnDomainRegionDataResponse.DescribeScdnDomainRegionData_RegionProportionData> describeScdnDomainRegionDataResponse_value = new List<DescribeScdnDomainRegionDataResponse.DescribeScdnDomainRegionData_RegionProportionData>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDomainRegionData.Value.Length"); i++) {
				DescribeScdnDomainRegionDataResponse.DescribeScdnDomainRegionData_RegionProportionData regionProportionData = new DescribeScdnDomainRegionDataResponse.DescribeScdnDomainRegionData_RegionProportionData();
				regionProportionData.Region = _ctx.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].Region");
				regionProportionData.Proportion = _ctx.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].Proportion");
				regionProportionData.RegionEname = _ctx.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].RegionEname");
				regionProportionData.AvgObjectSize = _ctx.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].AvgObjectSize");
				regionProportionData.AvgResponseTime = _ctx.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].AvgResponseTime");
				regionProportionData.Bps = _ctx.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].Bps");
				regionProportionData.Qps = _ctx.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].Qps");
				regionProportionData.AvgResponseRate = _ctx.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].AvgResponseRate");
				regionProportionData.ReqErrRate = _ctx.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].ReqErrRate");
				regionProportionData.TotalBytes = _ctx.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].TotalBytes");
				regionProportionData.BytesProportion = _ctx.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].BytesProportion");
				regionProportionData.TotalQuery = _ctx.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].TotalQuery");

				describeScdnDomainRegionDataResponse_value.Add(regionProportionData);
			}
			describeScdnDomainRegionDataResponse._Value = describeScdnDomainRegionDataResponse_value;
        
			return describeScdnDomainRegionDataResponse;
        }
    }
}
