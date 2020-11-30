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
        public static DescribeDcdnDomainRealTimeHttpCodeDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainRealTimeHttpCodeDataResponse describeDcdnDomainRealTimeHttpCodeDataResponse = new DescribeDcdnDomainRealTimeHttpCodeDataResponse();

			describeDcdnDomainRealTimeHttpCodeDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainRealTimeHttpCodeDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.RequestId");
			describeDcdnDomainRealTimeHttpCodeDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.DomainName");
			describeDcdnDomainRealTimeHttpCodeDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.StartTime");
			describeDcdnDomainRealTimeHttpCodeDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.EndTime");
			describeDcdnDomainRealTimeHttpCodeDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.DataInterval");

			List<DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData> describeDcdnDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData = new List<DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData.Length"); i++) {
				DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData usageData = new DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData();
				usageData.TimeStamp = _ctx.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].TimeStamp");

				List<DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData.DescribeDcdnDomainRealTimeHttpCodeData_RealTimeCodeProportionData> usageData_value = new List<DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData.DescribeDcdnDomainRealTimeHttpCodeData_RealTimeCodeProportionData>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value.Length"); j++) {
					DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData.DescribeDcdnDomainRealTimeHttpCodeData_RealTimeCodeProportionData realTimeCodeProportionData = new DescribeDcdnDomainRealTimeHttpCodeDataResponse.DescribeDcdnDomainRealTimeHttpCodeData_UsageData.DescribeDcdnDomainRealTimeHttpCodeData_RealTimeCodeProportionData();
					realTimeCodeProportionData.Code = _ctx.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Code");
					realTimeCodeProportionData.Proportion = _ctx.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Proportion");
					realTimeCodeProportionData.Count = _ctx.StringValue("DescribeDcdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Count");

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
