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
        public static DescribeDcdnDomainRegionDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainRegionDataResponse describeDcdnDomainRegionDataResponse = new DescribeDcdnDomainRegionDataResponse();

			describeDcdnDomainRegionDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainRegionDataResponse.RequestId = context.StringValue("DescribeDcdnDomainRegionData.RequestId");
			describeDcdnDomainRegionDataResponse.DomainName = context.StringValue("DescribeDcdnDomainRegionData.DomainName");
			describeDcdnDomainRegionDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainRegionData.DataInterval");
			describeDcdnDomainRegionDataResponse.StartTime = context.StringValue("DescribeDcdnDomainRegionData.StartTime");
			describeDcdnDomainRegionDataResponse.EndTime = context.StringValue("DescribeDcdnDomainRegionData.EndTime");

			List<DescribeDcdnDomainRegionDataResponse.DescribeDcdnDomainRegionData_RegionProportionData> describeDcdnDomainRegionDataResponse_value = new List<DescribeDcdnDomainRegionDataResponse.DescribeDcdnDomainRegionData_RegionProportionData>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainRegionData.Value.Length"); i++) {
				DescribeDcdnDomainRegionDataResponse.DescribeDcdnDomainRegionData_RegionProportionData regionProportionData = new DescribeDcdnDomainRegionDataResponse.DescribeDcdnDomainRegionData_RegionProportionData();
				regionProportionData.Region = context.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].Region");
				regionProportionData.Proportion = context.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].Proportion");
				regionProportionData.RegionEname = context.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].RegionEname");
				regionProportionData.AvgObjectSize = context.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].AvgObjectSize");
				regionProportionData.AvgResponseTime = context.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].AvgResponseTime");
				regionProportionData.Bps = context.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].Bps");
				regionProportionData.Qps = context.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].Qps");
				regionProportionData.AvgResponseRate = context.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].AvgResponseRate");
				regionProportionData.TotalBytes = context.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].TotalBytes");
				regionProportionData.BytesProportion = context.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].BytesProportion");
				regionProportionData.TotalQuery = context.StringValue("DescribeDcdnDomainRegionData.Value["+ i +"].TotalQuery");

				describeDcdnDomainRegionDataResponse_value.Add(regionProportionData);
			}
			describeDcdnDomainRegionDataResponse._Value = describeDcdnDomainRegionDataResponse_value;
        
			return describeDcdnDomainRegionDataResponse;
        }
    }
}
