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
    public class DescribeDomainRealTimeSrcHttpCodeDataResponseUnmarshaller
    {
        public static DescribeDomainRealTimeSrcHttpCodeDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainRealTimeSrcHttpCodeDataResponse describeDomainRealTimeSrcHttpCodeDataResponse = new DescribeDomainRealTimeSrcHttpCodeDataResponse();

			describeDomainRealTimeSrcHttpCodeDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainRealTimeSrcHttpCodeDataResponse.RequestId = _ctx.StringValue("DescribeDomainRealTimeSrcHttpCodeData.RequestId");
			describeDomainRealTimeSrcHttpCodeDataResponse.DomainName = _ctx.StringValue("DescribeDomainRealTimeSrcHttpCodeData.DomainName");
			describeDomainRealTimeSrcHttpCodeDataResponse.StartTime = _ctx.StringValue("DescribeDomainRealTimeSrcHttpCodeData.StartTime");
			describeDomainRealTimeSrcHttpCodeDataResponse.EndTime = _ctx.StringValue("DescribeDomainRealTimeSrcHttpCodeData.EndTime");
			describeDomainRealTimeSrcHttpCodeDataResponse.DataInterval = _ctx.StringValue("DescribeDomainRealTimeSrcHttpCodeData.DataInterval");

			List<DescribeDomainRealTimeSrcHttpCodeDataResponse.DescribeDomainRealTimeSrcHttpCodeData_UsageData> describeDomainRealTimeSrcHttpCodeDataResponse_realTimeSrcHttpCodeData = new List<DescribeDomainRealTimeSrcHttpCodeDataResponse.DescribeDomainRealTimeSrcHttpCodeData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeDomainRealTimeSrcHttpCodeData.RealTimeSrcHttpCodeData.Length"); i++) {
				DescribeDomainRealTimeSrcHttpCodeDataResponse.DescribeDomainRealTimeSrcHttpCodeData_UsageData usageData = new DescribeDomainRealTimeSrcHttpCodeDataResponse.DescribeDomainRealTimeSrcHttpCodeData_UsageData();
				usageData.TimeStamp = _ctx.StringValue("DescribeDomainRealTimeSrcHttpCodeData.RealTimeSrcHttpCodeData["+ i +"].TimeStamp");

				List<DescribeDomainRealTimeSrcHttpCodeDataResponse.DescribeDomainRealTimeSrcHttpCodeData_UsageData.DescribeDomainRealTimeSrcHttpCodeData_RealTimeSrcCodeProportionData> usageData_value = new List<DescribeDomainRealTimeSrcHttpCodeDataResponse.DescribeDomainRealTimeSrcHttpCodeData_UsageData.DescribeDomainRealTimeSrcHttpCodeData_RealTimeSrcCodeProportionData>();
				for (int j = 0; j < _ctx.Length("DescribeDomainRealTimeSrcHttpCodeData.RealTimeSrcHttpCodeData["+ i +"].Value.Length"); j++) {
					DescribeDomainRealTimeSrcHttpCodeDataResponse.DescribeDomainRealTimeSrcHttpCodeData_UsageData.DescribeDomainRealTimeSrcHttpCodeData_RealTimeSrcCodeProportionData realTimeSrcCodeProportionData = new DescribeDomainRealTimeSrcHttpCodeDataResponse.DescribeDomainRealTimeSrcHttpCodeData_UsageData.DescribeDomainRealTimeSrcHttpCodeData_RealTimeSrcCodeProportionData();
					realTimeSrcCodeProportionData.Code = _ctx.StringValue("DescribeDomainRealTimeSrcHttpCodeData.RealTimeSrcHttpCodeData["+ i +"].Value["+ j +"].Code");
					realTimeSrcCodeProportionData.Proportion = _ctx.StringValue("DescribeDomainRealTimeSrcHttpCodeData.RealTimeSrcHttpCodeData["+ i +"].Value["+ j +"].Proportion");
					realTimeSrcCodeProportionData.Count = _ctx.StringValue("DescribeDomainRealTimeSrcHttpCodeData.RealTimeSrcHttpCodeData["+ i +"].Value["+ j +"].Count");

					usageData_value.Add(realTimeSrcCodeProportionData);
				}
				usageData._Value = usageData_value;

				describeDomainRealTimeSrcHttpCodeDataResponse_realTimeSrcHttpCodeData.Add(usageData);
			}
			describeDomainRealTimeSrcHttpCodeDataResponse.RealTimeSrcHttpCodeData = describeDomainRealTimeSrcHttpCodeDataResponse_realTimeSrcHttpCodeData;
        
			return describeDomainRealTimeSrcHttpCodeDataResponse;
        }
    }
}
