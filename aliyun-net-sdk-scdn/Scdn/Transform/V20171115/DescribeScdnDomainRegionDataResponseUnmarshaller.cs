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
        public static DescribeScdnDomainRegionDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainRegionDataResponse describeScdnDomainRegionDataResponse = new DescribeScdnDomainRegionDataResponse();

			describeScdnDomainRegionDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainRegionDataResponse.RequestId = context.StringValue("DescribeScdnDomainRegionData.RequestId");
			describeScdnDomainRegionDataResponse.DomainName = context.StringValue("DescribeScdnDomainRegionData.DomainName");
			describeScdnDomainRegionDataResponse.DataInterval = context.StringValue("DescribeScdnDomainRegionData.DataInterval");
			describeScdnDomainRegionDataResponse.StartTime = context.StringValue("DescribeScdnDomainRegionData.StartTime");
			describeScdnDomainRegionDataResponse.EndTime = context.StringValue("DescribeScdnDomainRegionData.EndTime");

			List<DescribeScdnDomainRegionDataResponse.DescribeScdnDomainRegionData_RegionProportionData> describeScdnDomainRegionDataResponse_value = new List<DescribeScdnDomainRegionDataResponse.DescribeScdnDomainRegionData_RegionProportionData>();
			for (int i = 0; i < context.Length("DescribeScdnDomainRegionData.Value.Length"); i++) {
				DescribeScdnDomainRegionDataResponse.DescribeScdnDomainRegionData_RegionProportionData regionProportionData = new DescribeScdnDomainRegionDataResponse.DescribeScdnDomainRegionData_RegionProportionData();
				regionProportionData.Region = context.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].Region");
				regionProportionData.Proportion = context.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].Proportion");
				regionProportionData.RegionEname = context.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].RegionEname");
				regionProportionData.AvgObjectSize = context.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].AvgObjectSize");
				regionProportionData.AvgResponseTime = context.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].AvgResponseTime");
				regionProportionData.Bps = context.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].Bps");
				regionProportionData.Qps = context.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].Qps");
				regionProportionData.AvgResponseRate = context.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].AvgResponseRate");
				regionProportionData.ReqErrRate = context.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].ReqErrRate");
				regionProportionData.TotalBytes = context.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].TotalBytes");
				regionProportionData.BytesProportion = context.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].BytesProportion");
				regionProportionData.TotalQuery = context.StringValue("DescribeScdnDomainRegionData.Value["+ i +"].TotalQuery");

				describeScdnDomainRegionDataResponse_value.Add(regionProportionData);
			}
			describeScdnDomainRegionDataResponse._Value = describeScdnDomainRegionDataResponse_value;
        
			return describeScdnDomainRegionDataResponse;
        }
    }
}
