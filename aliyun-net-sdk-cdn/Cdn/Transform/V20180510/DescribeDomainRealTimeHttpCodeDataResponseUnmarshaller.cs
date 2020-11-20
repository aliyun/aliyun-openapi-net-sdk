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
    public class DescribeDomainRealTimeHttpCodeDataResponseUnmarshaller
    {
        public static DescribeDomainRealTimeHttpCodeDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainRealTimeHttpCodeDataResponse describeDomainRealTimeHttpCodeDataResponse = new DescribeDomainRealTimeHttpCodeDataResponse();

			describeDomainRealTimeHttpCodeDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainRealTimeHttpCodeDataResponse.RequestId = _ctx.StringValue("DescribeDomainRealTimeHttpCodeData.RequestId");
			describeDomainRealTimeHttpCodeDataResponse.DomainName = _ctx.StringValue("DescribeDomainRealTimeHttpCodeData.DomainName");
			describeDomainRealTimeHttpCodeDataResponse.StartTime = _ctx.StringValue("DescribeDomainRealTimeHttpCodeData.StartTime");
			describeDomainRealTimeHttpCodeDataResponse.EndTime = _ctx.StringValue("DescribeDomainRealTimeHttpCodeData.EndTime");
			describeDomainRealTimeHttpCodeDataResponse.DataInterval = _ctx.StringValue("DescribeDomainRealTimeHttpCodeData.DataInterval");

			List<DescribeDomainRealTimeHttpCodeDataResponse.DescribeDomainRealTimeHttpCodeData_UsageData> describeDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData = new List<DescribeDomainRealTimeHttpCodeDataResponse.DescribeDomainRealTimeHttpCodeData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeDomainRealTimeHttpCodeData.RealTimeHttpCodeData.Length"); i++) {
				DescribeDomainRealTimeHttpCodeDataResponse.DescribeDomainRealTimeHttpCodeData_UsageData usageData = new DescribeDomainRealTimeHttpCodeDataResponse.DescribeDomainRealTimeHttpCodeData_UsageData();
				usageData.TimeStamp = _ctx.StringValue("DescribeDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].TimeStamp");

				List<DescribeDomainRealTimeHttpCodeDataResponse.DescribeDomainRealTimeHttpCodeData_UsageData.DescribeDomainRealTimeHttpCodeData_RealTimeCodeProportionData> usageData_value = new List<DescribeDomainRealTimeHttpCodeDataResponse.DescribeDomainRealTimeHttpCodeData_UsageData.DescribeDomainRealTimeHttpCodeData_RealTimeCodeProportionData>();
				for (int j = 0; j < _ctx.Length("DescribeDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value.Length"); j++) {
					DescribeDomainRealTimeHttpCodeDataResponse.DescribeDomainRealTimeHttpCodeData_UsageData.DescribeDomainRealTimeHttpCodeData_RealTimeCodeProportionData realTimeCodeProportionData = new DescribeDomainRealTimeHttpCodeDataResponse.DescribeDomainRealTimeHttpCodeData_UsageData.DescribeDomainRealTimeHttpCodeData_RealTimeCodeProportionData();
					realTimeCodeProportionData.Code = _ctx.StringValue("DescribeDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Code");
					realTimeCodeProportionData.Proportion = _ctx.StringValue("DescribeDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Proportion");
					realTimeCodeProportionData.Count = _ctx.StringValue("DescribeDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Count");

					usageData_value.Add(realTimeCodeProportionData);
				}
				usageData._Value = usageData_value;

				describeDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData.Add(usageData);
			}
			describeDomainRealTimeHttpCodeDataResponse.RealTimeHttpCodeData = describeDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData;
        
			return describeDomainRealTimeHttpCodeDataResponse;
        }
    }
}
