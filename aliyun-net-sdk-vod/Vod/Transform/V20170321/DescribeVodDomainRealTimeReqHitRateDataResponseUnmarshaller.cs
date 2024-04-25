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
    public class DescribeVodDomainRealTimeReqHitRateDataResponseUnmarshaller
    {
        public static DescribeVodDomainRealTimeReqHitRateDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainRealTimeReqHitRateDataResponse describeVodDomainRealTimeReqHitRateDataResponse = new DescribeVodDomainRealTimeReqHitRateDataResponse();

			describeVodDomainRealTimeReqHitRateDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainRealTimeReqHitRateDataResponse.RequestId = _ctx.StringValue("DescribeVodDomainRealTimeReqHitRateData.RequestId");

			List<DescribeVodDomainRealTimeReqHitRateDataResponse.DescribeVodDomainRealTimeReqHitRateData_ReqHitRateDataModel> describeVodDomainRealTimeReqHitRateDataResponse_data = new List<DescribeVodDomainRealTimeReqHitRateDataResponse.DescribeVodDomainRealTimeReqHitRateData_ReqHitRateDataModel>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainRealTimeReqHitRateData.Data.Length"); i++) {
				DescribeVodDomainRealTimeReqHitRateDataResponse.DescribeVodDomainRealTimeReqHitRateData_ReqHitRateDataModel reqHitRateDataModel = new DescribeVodDomainRealTimeReqHitRateDataResponse.DescribeVodDomainRealTimeReqHitRateData_ReqHitRateDataModel();
				reqHitRateDataModel.ReqHitRate = _ctx.FloatValue("DescribeVodDomainRealTimeReqHitRateData.Data["+ i +"].ReqHitRate");
				reqHitRateDataModel.TimeStamp = _ctx.StringValue("DescribeVodDomainRealTimeReqHitRateData.Data["+ i +"].TimeStamp");

				describeVodDomainRealTimeReqHitRateDataResponse_data.Add(reqHitRateDataModel);
			}
			describeVodDomainRealTimeReqHitRateDataResponse.Data = describeVodDomainRealTimeReqHitRateDataResponse_data;
        
			return describeVodDomainRealTimeReqHitRateDataResponse;
        }
    }
}
