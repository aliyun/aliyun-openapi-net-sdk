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
    public class DescribeDomainISPDataResponseUnmarshaller
    {
        public static DescribeDomainISPDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainISPDataResponse describeDomainISPDataResponse = new DescribeDomainISPDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainISPData.RequestId"),
                DomainName = context.StringValue("DescribeDomainISPData.DomainName"),
                DataInterval = context.StringValue("DescribeDomainISPData.DataInterval"),
                StartTime = context.StringValue("DescribeDomainISPData.StartTime"),
                EndTime = context.StringValue("DescribeDomainISPData.EndTime")
            };
            List<DescribeDomainISPDataResponse.ISPProportionData> value = new List<DescribeDomainISPDataResponse.ISPProportionData>();
			for (int i = 0; i < context.Length("DescribeDomainISPData.Value.Length"); i++) {
                DescribeDomainISPDataResponse.ISPProportionData iSpProportionData = new DescribeDomainISPDataResponse.ISPProportionData()
                {
                    ISP = context.StringValue($"DescribeDomainISPData.Value[{i}].ISP"),
                    Proportion = context.StringValue($"DescribeDomainISPData.Value[{i}].Proportion"),
                    IspEname = context.StringValue($"DescribeDomainISPData.Value[{i}].IspEname"),
                    AvgObjectSize = context.StringValue($"DescribeDomainISPData.Value[{i}].AvgObjectSize"),
                    AvgResponseTime = context.StringValue($"DescribeDomainISPData.Value[{i}].AvgResponseTime"),
                    Bps = context.StringValue($"DescribeDomainISPData.Value[{i}].Bps"),
                    ByteHitRate = context.StringValue($"DescribeDomainISPData.Value[{i}].ByteHitRate"),
                    Qps = context.StringValue($"DescribeDomainISPData.Value[{i}].Qps"),
                    ReqErrRate = context.StringValue($"DescribeDomainISPData.Value[{i}].ReqErrRate"),
                    ReqHitRate = context.StringValue($"DescribeDomainISPData.Value[{i}].ReqHitRate"),
                    AvgResponseRate = context.StringValue($"DescribeDomainISPData.Value[{i}].AvgResponseRate"),
                    TotalBytes = context.StringValue($"DescribeDomainISPData.Value[{i}].TotalBytes"),
                    BytesProportion = context.StringValue($"DescribeDomainISPData.Value[{i}].BytesProportion"),
                    TotalQuery = context.StringValue($"DescribeDomainISPData.Value[{i}].TotalQuery")
                };
                value.Add(iSpProportionData);
			}
			describeDomainISPDataResponse.Value = value;
        
			return describeDomainISPDataResponse;
        }
    }
}