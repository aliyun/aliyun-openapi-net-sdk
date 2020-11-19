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
    public class DescribeDomainRealTimeReqHitRateDataResponseUnmarshaller
    {
        public static DescribeDomainRealTimeReqHitRateDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainRealTimeReqHitRateDataResponse describeDomainRealTimeReqHitRateDataResponse = new DescribeDomainRealTimeReqHitRateDataResponse();

			describeDomainRealTimeReqHitRateDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainRealTimeReqHitRateDataResponse.RequestId = _ctx.StringValue("DescribeDomainRealTimeReqHitRateData.RequestId");

			List<DescribeDomainRealTimeReqHitRateDataResponse.DescribeDomainRealTimeReqHitRateData_ReqHitRateDataModel> describeDomainRealTimeReqHitRateDataResponse_data = new List<DescribeDomainRealTimeReqHitRateDataResponse.DescribeDomainRealTimeReqHitRateData_ReqHitRateDataModel>();
			for (int i = 0; i < _ctx.Length("DescribeDomainRealTimeReqHitRateData.Data.Length"); i++) {
				DescribeDomainRealTimeReqHitRateDataResponse.DescribeDomainRealTimeReqHitRateData_ReqHitRateDataModel reqHitRateDataModel = new DescribeDomainRealTimeReqHitRateDataResponse.DescribeDomainRealTimeReqHitRateData_ReqHitRateDataModel();
				reqHitRateDataModel.ReqHitRate = _ctx.FloatValue("DescribeDomainRealTimeReqHitRateData.Data["+ i +"].ReqHitRate");
				reqHitRateDataModel.TimeStamp = _ctx.StringValue("DescribeDomainRealTimeReqHitRateData.Data["+ i +"].TimeStamp");

				describeDomainRealTimeReqHitRateDataResponse_data.Add(reqHitRateDataModel);
			}
			describeDomainRealTimeReqHitRateDataResponse.Data = describeDomainRealTimeReqHitRateDataResponse_data;
        
			return describeDomainRealTimeReqHitRateDataResponse;
        }
    }
}
