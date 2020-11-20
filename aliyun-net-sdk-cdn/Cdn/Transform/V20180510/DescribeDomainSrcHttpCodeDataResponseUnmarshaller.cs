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
    public class DescribeDomainSrcHttpCodeDataResponseUnmarshaller
    {
        public static DescribeDomainSrcHttpCodeDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainSrcHttpCodeDataResponse describeDomainSrcHttpCodeDataResponse = new DescribeDomainSrcHttpCodeDataResponse();

			describeDomainSrcHttpCodeDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainSrcHttpCodeDataResponse.RequestId = _ctx.StringValue("DescribeDomainSrcHttpCodeData.RequestId");
			describeDomainSrcHttpCodeDataResponse.DomainName = _ctx.StringValue("DescribeDomainSrcHttpCodeData.DomainName");
			describeDomainSrcHttpCodeDataResponse.StartTime = _ctx.StringValue("DescribeDomainSrcHttpCodeData.StartTime");
			describeDomainSrcHttpCodeDataResponse.EndTime = _ctx.StringValue("DescribeDomainSrcHttpCodeData.EndTime");
			describeDomainSrcHttpCodeDataResponse.DataInterval = _ctx.StringValue("DescribeDomainSrcHttpCodeData.DataInterval");

			List<DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData> describeDomainSrcHttpCodeDataResponse_httpCodeData = new List<DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeDomainSrcHttpCodeData.HttpCodeData.Length"); i++) {
				DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData usageData = new DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData();
				usageData.TimeStamp = _ctx.StringValue("DescribeDomainSrcHttpCodeData.HttpCodeData["+ i +"].TimeStamp");

				List<DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData.DescribeDomainSrcHttpCodeData_CodeProportionData> usageData_value = new List<DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData.DescribeDomainSrcHttpCodeData_CodeProportionData>();
				for (int j = 0; j < _ctx.Length("DescribeDomainSrcHttpCodeData.HttpCodeData["+ i +"].Value.Length"); j++) {
					DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData.DescribeDomainSrcHttpCodeData_CodeProportionData codeProportionData = new DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData.DescribeDomainSrcHttpCodeData_CodeProportionData();
					codeProportionData.Code = _ctx.StringValue("DescribeDomainSrcHttpCodeData.HttpCodeData["+ i +"].Value["+ j +"].Code");
					codeProportionData.Proportion = _ctx.StringValue("DescribeDomainSrcHttpCodeData.HttpCodeData["+ i +"].Value["+ j +"].Proportion");
					codeProportionData.Count = _ctx.StringValue("DescribeDomainSrcHttpCodeData.HttpCodeData["+ i +"].Value["+ j +"].Count");

					usageData_value.Add(codeProportionData);
				}
				usageData._Value = usageData_value;

				describeDomainSrcHttpCodeDataResponse_httpCodeData.Add(usageData);
			}
			describeDomainSrcHttpCodeDataResponse.HttpCodeData = describeDomainSrcHttpCodeDataResponse_httpCodeData;
        
			return describeDomainSrcHttpCodeDataResponse;
        }
    }
}
