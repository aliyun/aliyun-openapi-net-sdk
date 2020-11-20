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
    public class DescribeDomainHttpCodeDataResponseUnmarshaller
    {
        public static DescribeDomainHttpCodeDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainHttpCodeDataResponse describeDomainHttpCodeDataResponse = new DescribeDomainHttpCodeDataResponse();

			describeDomainHttpCodeDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainHttpCodeDataResponse.RequestId = _ctx.StringValue("DescribeDomainHttpCodeData.RequestId");
			describeDomainHttpCodeDataResponse.DomainName = _ctx.StringValue("DescribeDomainHttpCodeData.DomainName");
			describeDomainHttpCodeDataResponse.StartTime = _ctx.StringValue("DescribeDomainHttpCodeData.StartTime");
			describeDomainHttpCodeDataResponse.EndTime = _ctx.StringValue("DescribeDomainHttpCodeData.EndTime");
			describeDomainHttpCodeDataResponse.DataInterval = _ctx.StringValue("DescribeDomainHttpCodeData.DataInterval");

			List<DescribeDomainHttpCodeDataResponse.DescribeDomainHttpCodeData_UsageData> describeDomainHttpCodeDataResponse_httpCodeData = new List<DescribeDomainHttpCodeDataResponse.DescribeDomainHttpCodeData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeDomainHttpCodeData.HttpCodeData.Length"); i++) {
				DescribeDomainHttpCodeDataResponse.DescribeDomainHttpCodeData_UsageData usageData = new DescribeDomainHttpCodeDataResponse.DescribeDomainHttpCodeData_UsageData();
				usageData.TimeStamp = _ctx.StringValue("DescribeDomainHttpCodeData.HttpCodeData["+ i +"].TimeStamp");

				List<DescribeDomainHttpCodeDataResponse.DescribeDomainHttpCodeData_UsageData.DescribeDomainHttpCodeData_CodeProportionData> usageData_value = new List<DescribeDomainHttpCodeDataResponse.DescribeDomainHttpCodeData_UsageData.DescribeDomainHttpCodeData_CodeProportionData>();
				for (int j = 0; j < _ctx.Length("DescribeDomainHttpCodeData.HttpCodeData["+ i +"].Value.Length"); j++) {
					DescribeDomainHttpCodeDataResponse.DescribeDomainHttpCodeData_UsageData.DescribeDomainHttpCodeData_CodeProportionData codeProportionData = new DescribeDomainHttpCodeDataResponse.DescribeDomainHttpCodeData_UsageData.DescribeDomainHttpCodeData_CodeProportionData();
					codeProportionData.Code = _ctx.StringValue("DescribeDomainHttpCodeData.HttpCodeData["+ i +"].Value["+ j +"].Code");
					codeProportionData.Proportion = _ctx.StringValue("DescribeDomainHttpCodeData.HttpCodeData["+ i +"].Value["+ j +"].Proportion");
					codeProportionData.Count = _ctx.StringValue("DescribeDomainHttpCodeData.HttpCodeData["+ i +"].Value["+ j +"].Count");

					usageData_value.Add(codeProportionData);
				}
				usageData._Value = usageData_value;

				describeDomainHttpCodeDataResponse_httpCodeData.Add(usageData);
			}
			describeDomainHttpCodeDataResponse.HttpCodeData = describeDomainHttpCodeDataResponse_httpCodeData;
        
			return describeDomainHttpCodeDataResponse;
        }
    }
}
