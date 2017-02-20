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
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainRegionDataResponseUnmarshaller
    {
        public static DescribeDomainRegionDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainRegionDataResponse describeDomainRegionDataResponse = new DescribeDomainRegionDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainRegionData.RequestId"),
                DomainName = context.StringValue("DescribeDomainRegionData.DomainName"),
                DataInterval = context.StringValue("DescribeDomainRegionData.DataInterval"),
                StartTime = context.StringValue("DescribeDomainRegionData.StartTime"),
                EndTime = context.StringValue("DescribeDomainRegionData.EndTime")
            };
            List<DescribeDomainRegionDataResponse.RegionProportionData> value = new List<DescribeDomainRegionDataResponse.RegionProportionData>();
			for (int i = 0; i < context.Length("DescribeDomainRegionData.Value.Length"); i++) {
                DescribeDomainRegionDataResponse.RegionProportionData regionProportionData = new DescribeDomainRegionDataResponse.RegionProportionData()
                {
                    Region = context.StringValue($"DescribeDomainRegionData.Value[{i}].Region"),
                    Proportion = context.StringValue($"DescribeDomainRegionData.Value[{i}].Proportion"),
                    RegionEname = context.StringValue($"DescribeDomainRegionData.Value[{i}].RegionEname"),
                    AvgObjectSize = context.StringValue($"DescribeDomainRegionData.Value[{i}].AvgObjectSize"),
                    AvgResponseTime = context.StringValue($"DescribeDomainRegionData.Value[{i}].AvgResponseTime"),
                    Bps = context.StringValue($"DescribeDomainRegionData.Value[{i}].Bps"),
                    ByteHitRate = context.StringValue($"DescribeDomainRegionData.Value[{i}].ByteHitRate"),
                    Qps = context.StringValue($"DescribeDomainRegionData.Value[{i}].Qps"),
                    ReqErrRate = context.StringValue($"DescribeDomainRegionData.Value[{i}].ReqErrRate"),
                    ReqHitRate = context.StringValue($"DescribeDomainRegionData.Value[{i}].ReqHitRate"),
                    AvgResponseRate = context.StringValue($"DescribeDomainRegionData.Value[{i}].AvgResponseRate"),
                    TotalBytes = context.StringValue($"DescribeDomainRegionData.Value[{i}].TotalBytes"),
                    BytesProportion = context.StringValue($"DescribeDomainRegionData.Value[{i}].BytesProportion"),
                    TotalQuery = context.StringValue($"DescribeDomainRegionData.Value[{i}].TotalQuery")
                };
                value.Add(regionProportionData);
			}
			describeDomainRegionDataResponse.Value = value;
        
			return describeDomainRegionDataResponse;
        }
    }
}