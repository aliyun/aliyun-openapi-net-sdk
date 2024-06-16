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
    public class DescribeVodDomainReqHitRateDataResponseUnmarshaller
    {
        public static DescribeVodDomainReqHitRateDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainReqHitRateDataResponse describeVodDomainReqHitRateDataResponse = new DescribeVodDomainReqHitRateDataResponse();

			describeVodDomainReqHitRateDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainReqHitRateDataResponse.EndTime = _ctx.StringValue("DescribeVodDomainReqHitRateData.EndTime");
			describeVodDomainReqHitRateDataResponse.RequestId = _ctx.StringValue("DescribeVodDomainReqHitRateData.RequestId");
			describeVodDomainReqHitRateDataResponse.StartTime = _ctx.StringValue("DescribeVodDomainReqHitRateData.StartTime");
			describeVodDomainReqHitRateDataResponse.DomainName = _ctx.StringValue("DescribeVodDomainReqHitRateData.DomainName");
			describeVodDomainReqHitRateDataResponse.DataInterval = _ctx.StringValue("DescribeVodDomainReqHitRateData.DataInterval");

			List<DescribeVodDomainReqHitRateDataResponse.DescribeVodDomainReqHitRateData_DataModule> describeVodDomainReqHitRateDataResponse_data = new List<DescribeVodDomainReqHitRateDataResponse.DescribeVodDomainReqHitRateData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainReqHitRateData.Data.Length"); i++) {
				DescribeVodDomainReqHitRateDataResponse.DescribeVodDomainReqHitRateData_DataModule dataModule = new DescribeVodDomainReqHitRateDataResponse.DescribeVodDomainReqHitRateData_DataModule();
				dataModule._Value = _ctx.StringValue("DescribeVodDomainReqHitRateData.Data["+ i +"].Value");
				dataModule.TimeStamp = _ctx.StringValue("DescribeVodDomainReqHitRateData.Data["+ i +"].TimeStamp");
				dataModule.HttpsValue = _ctx.StringValue("DescribeVodDomainReqHitRateData.Data["+ i +"].HttpsValue");

				describeVodDomainReqHitRateDataResponse_data.Add(dataModule);
			}
			describeVodDomainReqHitRateDataResponse.Data = describeVodDomainReqHitRateDataResponse_data;
        
			return describeVodDomainReqHitRateDataResponse;
        }
    }
}
