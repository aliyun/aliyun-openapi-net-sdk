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
    public class DescribeDcdnDomainRealTimeSrcHttpCodeDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse describeDcdnDomainRealTimeSrcHttpCodeDataResponse = new DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse();

			describeDcdnDomainRealTimeSrcHttpCodeDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainRealTimeSrcHttpCodeDataResponse.RequestId = context.StringValue("DescribeDcdnDomainRealTimeSrcHttpCodeData.RequestId");
			describeDcdnDomainRealTimeSrcHttpCodeDataResponse.DomainName = context.StringValue("DescribeDcdnDomainRealTimeSrcHttpCodeData.DomainName");
			describeDcdnDomainRealTimeSrcHttpCodeDataResponse.StartTime = context.StringValue("DescribeDcdnDomainRealTimeSrcHttpCodeData.StartTime");
			describeDcdnDomainRealTimeSrcHttpCodeDataResponse.EndTime = context.StringValue("DescribeDcdnDomainRealTimeSrcHttpCodeData.EndTime");
			describeDcdnDomainRealTimeSrcHttpCodeDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainRealTimeSrcHttpCodeData.DataInterval");

			List<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse.DescribeDcdnDomainRealTimeSrcHttpCodeData_UsageData> describeDcdnDomainRealTimeSrcHttpCodeDataResponse_realTimeSrcHttpCodeData = new List<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse.DescribeDcdnDomainRealTimeSrcHttpCodeData_UsageData>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainRealTimeSrcHttpCodeData.RealTimeSrcHttpCodeData.Length"); i++) {
				DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse.DescribeDcdnDomainRealTimeSrcHttpCodeData_UsageData usageData = new DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse.DescribeDcdnDomainRealTimeSrcHttpCodeData_UsageData();
				usageData.TimeStamp = context.StringValue("DescribeDcdnDomainRealTimeSrcHttpCodeData.RealTimeSrcHttpCodeData["+ i +"].TimeStamp");

				List<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse.DescribeDcdnDomainRealTimeSrcHttpCodeData_UsageData.DescribeDcdnDomainRealTimeSrcHttpCodeData_RealTimeSrcCodeProportionData> usageData_value = new List<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse.DescribeDcdnDomainRealTimeSrcHttpCodeData_UsageData.DescribeDcdnDomainRealTimeSrcHttpCodeData_RealTimeSrcCodeProportionData>();
				for (int j = 0; j < context.Length("DescribeDcdnDomainRealTimeSrcHttpCodeData.RealTimeSrcHttpCodeData["+ i +"].Value.Length"); j++) {
					DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse.DescribeDcdnDomainRealTimeSrcHttpCodeData_UsageData.DescribeDcdnDomainRealTimeSrcHttpCodeData_RealTimeSrcCodeProportionData realTimeSrcCodeProportionData = new DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse.DescribeDcdnDomainRealTimeSrcHttpCodeData_UsageData.DescribeDcdnDomainRealTimeSrcHttpCodeData_RealTimeSrcCodeProportionData();
					realTimeSrcCodeProportionData.Code = context.StringValue("DescribeDcdnDomainRealTimeSrcHttpCodeData.RealTimeSrcHttpCodeData["+ i +"].Value["+ j +"].Code");
					realTimeSrcCodeProportionData.Proportion = context.StringValue("DescribeDcdnDomainRealTimeSrcHttpCodeData.RealTimeSrcHttpCodeData["+ i +"].Value["+ j +"].Proportion");
					realTimeSrcCodeProportionData.Count = context.StringValue("DescribeDcdnDomainRealTimeSrcHttpCodeData.RealTimeSrcHttpCodeData["+ i +"].Value["+ j +"].Count");

					usageData_value.Add(realTimeSrcCodeProportionData);
				}
				usageData._Value = usageData_value;

				describeDcdnDomainRealTimeSrcHttpCodeDataResponse_realTimeSrcHttpCodeData.Add(usageData);
			}
			describeDcdnDomainRealTimeSrcHttpCodeDataResponse.RealTimeSrcHttpCodeData = describeDcdnDomainRealTimeSrcHttpCodeDataResponse_realTimeSrcHttpCodeData;
        
			return describeDcdnDomainRealTimeSrcHttpCodeDataResponse;
        }
    }
}
