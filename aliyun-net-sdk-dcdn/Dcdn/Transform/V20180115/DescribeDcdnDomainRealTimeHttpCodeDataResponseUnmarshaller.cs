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
    public class DescribeDcdnDomainRealTimeHttpCodeDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainRealTimeHttpCodeDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainRealTimeHttpCodeDataResponse describeDcdnDomainRealTimeHttpCodeDataResponse = new DescribeDcdnDomainRealTimeHttpCodeDataResponse();

			describeDcdnDomainRealTimeHttpCodeDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainRealTimeHttpCodeDataResponse.RequestId = context.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.RequestId");
			describeDcdnDomainRealTimeHttpCodeDataResponse.DomainName = context.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.DomainName");
			describeDcdnDomainRealTimeHttpCodeDataResponse.StartTime = context.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.StartTime");
			describeDcdnDomainRealTimeHttpCodeDataResponse.EndTime = context.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.EndTime");
			describeDcdnDomainRealTimeHttpCodeDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.DataInterval");

			List<DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData> describeDcdnDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData = new List<DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData.Length"); i++) {
				DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData usageData = new DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData();
				usageData.TimeStamp = context.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].TimeStamp");

				List<DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData.DescribeDcdnDomainRealTimeHttpCodeData_RealTimeCodeProportionData> usageData_value = new List<DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData.DescribeDcdnDomainRealTimeHttpCodeData_RealTimeCodeProportionData>();
				for (int j = 0; j < context.Length("DescribeDcdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value.Length"); j++) {
					DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData.DescribeDcdnDomainRealTimeHttpCodeData_RealTimeCodeProportionData realTimeCodeProportionData = new DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData.DescribeDcdnDomainRealTimeHttpCodeData_RealTimeCodeProportionData();
					realTimeCodeProportionData.Code = context.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Code");
					realTimeCodeProportionData.Proportion = context.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Proportion");
					realTimeCodeProportionData.Count = context.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Count");

					usageData_value.Add(realTimeCodeProportionData);
				}
				usageData._Value = usageData_value;

				describeDcdnDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData.Add(usageData);
			}
			describeDcdnDomainRealTimeHttpCodeDataResponse.RealTimeHttpCodeData = describeDcdnDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData;
        
			return describeDcdnDomainRealTimeHttpCodeDataResponse;
        }
    }
}
