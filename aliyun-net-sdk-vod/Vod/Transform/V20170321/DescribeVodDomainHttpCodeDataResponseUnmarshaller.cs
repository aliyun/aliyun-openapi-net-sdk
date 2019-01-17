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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainHttpCodeDataResponseUnmarshaller
    {
        public static DescribeVodDomainHttpCodeDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainHttpCodeDataResponse describeVodDomainHttpCodeDataResponse = new DescribeVodDomainHttpCodeDataResponse();

			describeVodDomainHttpCodeDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainHttpCodeDataResponse.RequestId = context.StringValue("DescribeVodDomainHttpCodeData.RequestId");
			describeVodDomainHttpCodeDataResponse.DomainName = context.StringValue("DescribeVodDomainHttpCodeData.DomainName");
			describeVodDomainHttpCodeDataResponse.StartTime = context.StringValue("DescribeVodDomainHttpCodeData.StartTime");
			describeVodDomainHttpCodeDataResponse.EndTime = context.StringValue("DescribeVodDomainHttpCodeData.EndTime");
			describeVodDomainHttpCodeDataResponse.DataInterval = context.StringValue("DescribeVodDomainHttpCodeData.DataInterval");

			List<DescribeVodDomainHttpCodeDataResponse.DescribeVodDomainHttpCodeData_UsageData> describeVodDomainHttpCodeDataResponse_httpCodeData = new List<DescribeVodDomainHttpCodeDataResponse.DescribeVodDomainHttpCodeData_UsageData>();
			for (int i = 0; i < context.Length("DescribeVodDomainHttpCodeData.HttpCodeData.Length"); i++) {
				DescribeVodDomainHttpCodeDataResponse.DescribeVodDomainHttpCodeData_UsageData usageData = new DescribeVodDomainHttpCodeDataResponse.DescribeVodDomainHttpCodeData_UsageData();
				usageData.TimeStamp = context.StringValue("DescribeVodDomainHttpCodeData.HttpCodeData["+ i +"].TimeStamp");

				List<DescribeVodDomainHttpCodeDataResponse.DescribeVodDomainHttpCodeData_UsageData.DescribeVodDomainHttpCodeData_CodeProportionData> usageData_value = new List<DescribeVodDomainHttpCodeDataResponse.DescribeVodDomainHttpCodeData_UsageData.DescribeVodDomainHttpCodeData_CodeProportionData>();
				for (int j = 0; j < context.Length("DescribeVodDomainHttpCodeData.HttpCodeData["+ i +"].Value.Length"); j++) {
					DescribeVodDomainHttpCodeDataResponse.DescribeVodDomainHttpCodeData_UsageData.DescribeVodDomainHttpCodeData_CodeProportionData codeProportionData = new DescribeVodDomainHttpCodeDataResponse.DescribeVodDomainHttpCodeData_UsageData.DescribeVodDomainHttpCodeData_CodeProportionData();
					codeProportionData.Code = context.StringValue("DescribeVodDomainHttpCodeData.HttpCodeData["+ i +"].Value["+ j +"].Code");
					codeProportionData.Proportion = context.StringValue("DescribeVodDomainHttpCodeData.HttpCodeData["+ i +"].Value["+ j +"].Proportion");
					codeProportionData.Count = context.StringValue("DescribeVodDomainHttpCodeData.HttpCodeData["+ i +"].Value["+ j +"].Count");

					usageData_value.Add(codeProportionData);
				}
				usageData._Value = usageData_value;

				describeVodDomainHttpCodeDataResponse_httpCodeData.Add(usageData);
			}
			describeVodDomainHttpCodeDataResponse.HttpCodeData = describeVodDomainHttpCodeDataResponse_httpCodeData;
        
			return describeVodDomainHttpCodeDataResponse;
        }
    }
}