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
        public static DescribeDomainSrcHttpCodeDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainSrcHttpCodeDataResponse describeDomainSrcHttpCodeDataResponse = new DescribeDomainSrcHttpCodeDataResponse();

            describeDomainSrcHttpCodeDataResponse.HttpResponse = context.HttpResponse;
            describeDomainSrcHttpCodeDataResponse.RequestId = context.StringValue("DescribeDomainSrcHttpCodeData.RequestId");
            describeDomainSrcHttpCodeDataResponse.DomainName = context.StringValue("DescribeDomainSrcHttpCodeData.DomainName");
            describeDomainSrcHttpCodeDataResponse.StartTime = context.StringValue("DescribeDomainSrcHttpCodeData.StartTime");
            describeDomainSrcHttpCodeDataResponse.EndTime = context.StringValue("DescribeDomainSrcHttpCodeData.EndTime");
            describeDomainSrcHttpCodeDataResponse.DataInterval = context.StringValue("DescribeDomainSrcHttpCodeData.DataInterval");

            List<DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData> describeDomainSrcHttpCodeDataResponse_httpCodeData = new List<DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData>();
            for (int i = 0; i < context.Length("DescribeDomainSrcHttpCodeData.HttpCodeData.Length"); i++)
            {
                DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData usageData = new DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData();
                usageData.TimeStamp = context.StringValue("DescribeDomainSrcHttpCodeData.HttpCodeData[" + i + "].TimeStamp");

                List<DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData.DescribeDomainSrcHttpCodeData_CodeProportionData> usageData_value = new List<DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData.DescribeDomainSrcHttpCodeData_CodeProportionData>();
                for (int j = 0; j < context.Length("DescribeDomainSrcHttpCodeData.HttpCodeData[" + i + "].Value.Length"); j++)
                {
                    DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData.DescribeDomainSrcHttpCodeData_CodeProportionData codeProportionData = new DescribeDomainSrcHttpCodeDataResponse.DescribeDomainSrcHttpCodeData_UsageData.DescribeDomainSrcHttpCodeData_CodeProportionData();
                    codeProportionData.Code = context.StringValue("DescribeDomainSrcHttpCodeData.HttpCodeData[" + i + "].Value[" + j + "].Code");
                    codeProportionData.Proportion = context.StringValue("DescribeDomainSrcHttpCodeData.HttpCodeData[" + i + "].Value[" + j + "].Proportion");
                    codeProportionData.Count = context.StringValue("DescribeDomainSrcHttpCodeData.HttpCodeData[" + i + "].Value[" + j + "].Count");

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
