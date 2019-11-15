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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnDomainRealTimeReqHitRateDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainRealTimeReqHitRateDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainRealTimeReqHitRateDataResponse describeDcdnDomainRealTimeReqHitRateDataResponse = new DescribeDcdnDomainRealTimeReqHitRateDataResponse();

			describeDcdnDomainRealTimeReqHitRateDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainRealTimeReqHitRateDataResponse.RequestId = context.StringValue("DescribeDcdnDomainRealTimeReqHitRateData.RequestId");

			List<DescribeDcdnDomainRealTimeReqHitRateDataResponse.DescribeDcdnDomainRealTimeReqHitRateData_ReqHitRateDataModel> describeDcdnDomainRealTimeReqHitRateDataResponse_data = new List<DescribeDcdnDomainRealTimeReqHitRateDataResponse.DescribeDcdnDomainRealTimeReqHitRateData_ReqHitRateDataModel>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainRealTimeReqHitRateData.Data.Length"); i++) {
				DescribeDcdnDomainRealTimeReqHitRateDataResponse.DescribeDcdnDomainRealTimeReqHitRateData_ReqHitRateDataModel reqHitRateDataModel = new DescribeDcdnDomainRealTimeReqHitRateDataResponse.DescribeDcdnDomainRealTimeReqHitRateData_ReqHitRateDataModel();
				reqHitRateDataModel.ReqHitRate = context.FloatValue("DescribeDcdnDomainRealTimeReqHitRateData.Data["+ i +"].ReqHitRate");
				reqHitRateDataModel.TimeStamp = context.StringValue("DescribeDcdnDomainRealTimeReqHitRateData.Data["+ i +"].TimeStamp");

				describeDcdnDomainRealTimeReqHitRateDataResponse_data.Add(reqHitRateDataModel);
			}
			describeDcdnDomainRealTimeReqHitRateDataResponse.Data = describeDcdnDomainRealTimeReqHitRateDataResponse_data;
        
			return describeDcdnDomainRealTimeReqHitRateDataResponse;
        }
    }
}
