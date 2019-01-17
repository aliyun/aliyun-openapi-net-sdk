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
    public class DescribeVodDomainRealTimeReqHitRateDataResponseUnmarshaller
    {
        public static DescribeVodDomainRealTimeReqHitRateDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainRealTimeReqHitRateDataResponse describeVodDomainRealTimeReqHitRateDataResponse = new DescribeVodDomainRealTimeReqHitRateDataResponse();

			describeVodDomainRealTimeReqHitRateDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainRealTimeReqHitRateDataResponse.RequestId = context.StringValue("DescribeVodDomainRealTimeReqHitRateData.RequestId");

			List<DescribeVodDomainRealTimeReqHitRateDataResponse.DescribeVodDomainRealTimeReqHitRateData_ReqHitRateDataModel> describeVodDomainRealTimeReqHitRateDataResponse_data = new List<DescribeVodDomainRealTimeReqHitRateDataResponse.DescribeVodDomainRealTimeReqHitRateData_ReqHitRateDataModel>();
			for (int i = 0; i < context.Length("DescribeVodDomainRealTimeReqHitRateData.Data.Length"); i++) {
				DescribeVodDomainRealTimeReqHitRateDataResponse.DescribeVodDomainRealTimeReqHitRateData_ReqHitRateDataModel reqHitRateDataModel = new DescribeVodDomainRealTimeReqHitRateDataResponse.DescribeVodDomainRealTimeReqHitRateData_ReqHitRateDataModel();
				reqHitRateDataModel.ReqHitRate = context.FloatValue("DescribeVodDomainRealTimeReqHitRateData.Data["+ i +"].ReqHitRate");
				reqHitRateDataModel.TimeStamp = context.StringValue("DescribeVodDomainRealTimeReqHitRateData.Data["+ i +"].TimeStamp");

				describeVodDomainRealTimeReqHitRateDataResponse_data.Add(reqHitRateDataModel);
			}
			describeVodDomainRealTimeReqHitRateDataResponse.Data = describeVodDomainRealTimeReqHitRateDataResponse_data;
        
			return describeVodDomainRealTimeReqHitRateDataResponse;
        }
    }
}