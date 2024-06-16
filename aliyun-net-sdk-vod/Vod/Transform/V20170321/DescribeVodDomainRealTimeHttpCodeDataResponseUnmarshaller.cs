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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainRealTimeHttpCodeDataResponseUnmarshaller
    {
        public static DescribeVodDomainRealTimeHttpCodeDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainRealTimeHttpCodeDataResponse describeVodDomainRealTimeHttpCodeDataResponse = new DescribeVodDomainRealTimeHttpCodeDataResponse();

			describeVodDomainRealTimeHttpCodeDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainRealTimeHttpCodeDataResponse.EndTime = _ctx.StringValue("DescribeVodDomainRealTimeHttpCodeData.EndTime");
			describeVodDomainRealTimeHttpCodeDataResponse.StartTime = _ctx.StringValue("DescribeVodDomainRealTimeHttpCodeData.StartTime");
			describeVodDomainRealTimeHttpCodeDataResponse.RequestId = _ctx.StringValue("DescribeVodDomainRealTimeHttpCodeData.RequestId");
			describeVodDomainRealTimeHttpCodeDataResponse.DomainName = _ctx.StringValue("DescribeVodDomainRealTimeHttpCodeData.DomainName");
			describeVodDomainRealTimeHttpCodeDataResponse.DataInterval = _ctx.StringValue("DescribeVodDomainRealTimeHttpCodeData.DataInterval");

			List<DescribeVodDomainRealTimeHttpCodeDataResponse.DescribeVodDomainRealTimeHttpCodeData_UsageData> describeVodDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData = new List<DescribeVodDomainRealTimeHttpCodeDataResponse.DescribeVodDomainRealTimeHttpCodeData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainRealTimeHttpCodeData.RealTimeHttpCodeData.Length"); i++) {
				DescribeVodDomainRealTimeHttpCodeDataResponse.DescribeVodDomainRealTimeHttpCodeData_UsageData usageData = new DescribeVodDomainRealTimeHttpCodeDataResponse.DescribeVodDomainRealTimeHttpCodeData_UsageData();
				usageData.TimeStamp = _ctx.StringValue("DescribeVodDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].TimeStamp");

				List<DescribeVodDomainRealTimeHttpCodeDataResponse.DescribeVodDomainRealTimeHttpCodeData_UsageData.DescribeVodDomainRealTimeHttpCodeData_RealTimeCodeProportionData> usageData_value = new List<DescribeVodDomainRealTimeHttpCodeDataResponse.DescribeVodDomainRealTimeHttpCodeData_UsageData.DescribeVodDomainRealTimeHttpCodeData_RealTimeCodeProportionData>();
				for (int j = 0; j < _ctx.Length("DescribeVodDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value.Length"); j++) {
					DescribeVodDomainRealTimeHttpCodeDataResponse.DescribeVodDomainRealTimeHttpCodeData_UsageData.DescribeVodDomainRealTimeHttpCodeData_RealTimeCodeProportionData realTimeCodeProportionData = new DescribeVodDomainRealTimeHttpCodeDataResponse.DescribeVodDomainRealTimeHttpCodeData_UsageData.DescribeVodDomainRealTimeHttpCodeData_RealTimeCodeProportionData();
					realTimeCodeProportionData.Code = _ctx.StringValue("DescribeVodDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Code");
					realTimeCodeProportionData.Proportion = _ctx.StringValue("DescribeVodDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Proportion");
					realTimeCodeProportionData.Count = _ctx.StringValue("DescribeVodDomainRealTimeHttpCodeData.RealTimeHttpCodeData["+ i +"].Value["+ j +"].Count");

					usageData_value.Add(realTimeCodeProportionData);
				}
				usageData._Value = usageData_value;

				describeVodDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData.Add(usageData);
			}
			describeVodDomainRealTimeHttpCodeDataResponse.RealTimeHttpCodeData = describeVodDomainRealTimeHttpCodeDataResponse_realTimeHttpCodeData;
        
			return describeVodDomainRealTimeHttpCodeDataResponse;
        }
    }
}
