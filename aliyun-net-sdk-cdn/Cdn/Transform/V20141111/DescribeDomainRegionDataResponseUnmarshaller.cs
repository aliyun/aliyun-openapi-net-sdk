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
    public class DescribeDomainRegionDataResponseUnmarshaller
    {
        public static DescribeDomainRegionDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainRegionDataResponse describeDomainRegionDataResponse = new DescribeDomainRegionDataResponse();

			describeDomainRegionDataResponse.HttpResponse = context.HttpResponse;
			describeDomainRegionDataResponse.RequestId = context.StringValue("DescribeDomainRegionData.RequestId");
			describeDomainRegionDataResponse.DomainName = context.StringValue("DescribeDomainRegionData.DomainName");
			describeDomainRegionDataResponse.DataInterval = context.StringValue("DescribeDomainRegionData.DataInterval");
			describeDomainRegionDataResponse.StartTime = context.StringValue("DescribeDomainRegionData.StartTime");
			describeDomainRegionDataResponse.EndTime = context.StringValue("DescribeDomainRegionData.EndTime");

			List<DescribeDomainRegionDataResponse.DescribeDomainRegionData_RegionProportionData> describeDomainRegionDataResponse_value = new List<DescribeDomainRegionDataResponse.DescribeDomainRegionData_RegionProportionData>();
			for (int i = 0; i < context.Length("DescribeDomainRegionData.Value.Length"); i++) {
				DescribeDomainRegionDataResponse.DescribeDomainRegionData_RegionProportionData regionProportionData = new DescribeDomainRegionDataResponse.DescribeDomainRegionData_RegionProportionData();
				regionProportionData.Region = context.StringValue("DescribeDomainRegionData.Value["+ i +"].Region");
				regionProportionData.Proportion = context.StringValue("DescribeDomainRegionData.Value["+ i +"].Proportion");
				regionProportionData.RegionEname = context.StringValue("DescribeDomainRegionData.Value["+ i +"].RegionEname");
				regionProportionData.AvgObjectSize = context.StringValue("DescribeDomainRegionData.Value["+ i +"].AvgObjectSize");
				regionProportionData.AvgResponseTime = context.StringValue("DescribeDomainRegionData.Value["+ i +"].AvgResponseTime");
				regionProportionData.Bps = context.StringValue("DescribeDomainRegionData.Value["+ i +"].Bps");
				regionProportionData.ByteHitRate = context.StringValue("DescribeDomainRegionData.Value["+ i +"].ByteHitRate");
				regionProportionData.Qps = context.StringValue("DescribeDomainRegionData.Value["+ i +"].Qps");
				regionProportionData.ReqErrRate = context.StringValue("DescribeDomainRegionData.Value["+ i +"].ReqErrRate");
				regionProportionData.ReqHitRate = context.StringValue("DescribeDomainRegionData.Value["+ i +"].ReqHitRate");
				regionProportionData.AvgResponseRate = context.StringValue("DescribeDomainRegionData.Value["+ i +"].AvgResponseRate");
				regionProportionData.TotalBytes = context.StringValue("DescribeDomainRegionData.Value["+ i +"].TotalBytes");
				regionProportionData.BytesProportion = context.StringValue("DescribeDomainRegionData.Value["+ i +"].BytesProportion");
				regionProportionData.TotalQuery = context.StringValue("DescribeDomainRegionData.Value["+ i +"].TotalQuery");

				describeDomainRegionDataResponse_value.Add(regionProportionData);
			}
			describeDomainRegionDataResponse._Value = describeDomainRegionDataResponse_value;
        
			return describeDomainRegionDataResponse;
        }
    }
}