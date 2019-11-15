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
    public class DescribeScdnDomainRealTimeHttpCodeDataResponseUnmarshaller
    {
        public static DescribeScdnDomainRealTimeHttpCodeDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainRealTimeHttpCodeDataResponse describeScdnDomainRealTimeHttpCodeDataResponse = new DescribeScdnDomainRealTimeHttpCodeDataResponse();

			describeScdnDomainRealTimeHttpCodeDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainRealTimeHttpCodeDataResponse.RequestId = context.StringValue("DescribeScdnDomainRealTimeHttpCodeData.RequestId");
			describeScdnDomainRealTimeHttpCodeDataResponse.DomainName = context.StringValue("DescribeScdnDomainRealTimeHttpCodeData.DomainName");
			describeScdnDomainRealTimeHttpCodeDataResponse.StartTime = context.StringValue("DescribeScdnDomainRealTimeHttpCodeData.StartTime");
			describeScdnDomainRealTimeHttpCodeDataResponse.EndTime = context.StringValue("DescribeScdnDomainRealTimeHttpCodeData.EndTime");
			describeScdnDomainRealTimeHttpCodeDataResponse.DataInterval = context.StringValue("DescribeScdnDomainRealTimeHttpCodeData.DataInterval");

			List<DescribeScdnDomainRealTimeHttpCodeDataResponse.DescribeScdnDomainRealTimeHttpCodeData_UsageData> describeScdnDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData = new List<DescribeScdnDomainRealTimeHttpCodeDataResponse.DescribeScdnDomainRealTimeHttpCodeData_UsageData>();
			for (int i = 0; i < context.Length("DescribeScdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData.Length"); i++) {
				DescribeScdnDomainRealTimeHttpCodeDataResponse.DescribeScdnDomainRealTimeHttpCodeData_UsageData usageData = new DescribeScdnDomainRealTimeHttpCodeDataResponse.DescribeScdnDomainRealTimeHttpCodeData_UsageData();
				usageData.TimeStamp = context.StringValue("DescribeScdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].TimeStamp");

				List<DescribeScdnDomainRealTimeHttpCodeDataResponse.DescribeScdnDomainRealTimeHttpCodeData_UsageData.DescribeScdnDomainRealTimeHttpCodeData_RealTimeCodeProportionData> usageData_value = new List<DescribeScdnDomainRealTimeHttpCodeDataResponse.DescribeScdnDomainRealTimeHttpCodeData_UsageData.DescribeScdnDomainRealTimeHttpCodeData_RealTimeCodeProportionData>();
				for (int j = 0; j < context.Length("DescribeScdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value.Length"); j++) {
					DescribeScdnDomainRealTimeHttpCodeDataResponse.DescribeScdnDomainRealTimeHttpCodeData_UsageData.DescribeScdnDomainRealTimeHttpCodeData_RealTimeCodeProportionData realTimeCodeProportionData = new DescribeScdnDomainRealTimeHttpCodeDataResponse.DescribeScdnDomainRealTimeHttpCodeData_UsageData.DescribeScdnDomainRealTimeHttpCodeData_RealTimeCodeProportionData();
					realTimeCodeProportionData.Code = context.StringValue("DescribeScdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Code");
					realTimeCodeProportionData.Proportion = context.StringValue("DescribeScdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Proportion");
					realTimeCodeProportionData.Count = context.StringValue("DescribeScdnDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Count");

					usageData_value.Add(realTimeCodeProportionData);
				}
				usageData._Value = usageData_value;

				describeScdnDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData.Add(usageData);
			}
			describeScdnDomainRealTimeHttpCodeDataResponse.RealTimeHttpCodeData = describeScdnDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData;
        
			return describeScdnDomainRealTimeHttpCodeDataResponse;
        }
    }
}
