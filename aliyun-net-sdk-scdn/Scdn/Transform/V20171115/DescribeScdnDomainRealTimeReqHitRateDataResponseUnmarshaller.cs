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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDomainRealTimeReqHitRateDataResponseUnmarshaller
    {
        public static DescribeScdnDomainRealTimeReqHitRateDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainRealTimeReqHitRateDataResponse describeScdnDomainRealTimeReqHitRateDataResponse = new DescribeScdnDomainRealTimeReqHitRateDataResponse();

			describeScdnDomainRealTimeReqHitRateDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainRealTimeReqHitRateDataResponse.RequestId = context.StringValue("DescribeScdnDomainRealTimeReqHitRateData.RequestId");

			List<DescribeScdnDomainRealTimeReqHitRateDataResponse.DescribeScdnDomainRealTimeReqHitRateData_ReqHitRateDataModel> describeScdnDomainRealTimeReqHitRateDataResponse_data = new List<DescribeScdnDomainRealTimeReqHitRateDataResponse.DescribeScdnDomainRealTimeReqHitRateData_ReqHitRateDataModel>();
			for (int i = 0; i < context.Length("DescribeScdnDomainRealTimeReqHitRateData.Data.Length"); i++) {
				DescribeScdnDomainRealTimeReqHitRateDataResponse.DescribeScdnDomainRealTimeReqHitRateData_ReqHitRateDataModel reqHitRateDataModel = new DescribeScdnDomainRealTimeReqHitRateDataResponse.DescribeScdnDomainRealTimeReqHitRateData_ReqHitRateDataModel();
				reqHitRateDataModel.ReqHitRate = context.FloatValue("DescribeScdnDomainRealTimeReqHitRateData.Data["+ i +"].ReqHitRate");
				reqHitRateDataModel.TimeStamp = context.StringValue("DescribeScdnDomainRealTimeReqHitRateData.Data["+ i +"].TimeStamp");

				describeScdnDomainRealTimeReqHitRateDataResponse_data.Add(reqHitRateDataModel);
			}
			describeScdnDomainRealTimeReqHitRateDataResponse.Data = describeScdnDomainRealTimeReqHitRateDataResponse_data;
        
			return describeScdnDomainRealTimeReqHitRateDataResponse;
        }
    }
}
