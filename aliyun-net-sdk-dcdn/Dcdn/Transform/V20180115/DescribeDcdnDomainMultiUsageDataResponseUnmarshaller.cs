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
    public class DescribeDcdnDomainMultiUsageDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainMultiUsageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainMultiUsageDataResponse describeDcdnDomainMultiUsageDataResponse = new DescribeDcdnDomainMultiUsageDataResponse();

			describeDcdnDomainMultiUsageDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainMultiUsageDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainMultiUsageData.RequestId");
			describeDcdnDomainMultiUsageDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainMultiUsageData.StartTime");
			describeDcdnDomainMultiUsageDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainMultiUsageData.EndTime");

			List<DescribeDcdnDomainMultiUsageDataResponse.DescribeDcdnDomainMultiUsageData_RequestDataModule> describeDcdnDomainMultiUsageDataResponse_requestPerInterval = new List<DescribeDcdnDomainMultiUsageDataResponse.DescribeDcdnDomainMultiUsageData_RequestDataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainMultiUsageData.RequestPerInterval.Length"); i++) {
				DescribeDcdnDomainMultiUsageDataResponse.DescribeDcdnDomainMultiUsageData_RequestDataModule requestDataModule = new DescribeDcdnDomainMultiUsageDataResponse.DescribeDcdnDomainMultiUsageData_RequestDataModule();
				requestDataModule.TimeStamp = _ctx.StringValue("DescribeDcdnDomainMultiUsageData.RequestPerInterval["+ i +"].TimeStamp");
				requestDataModule.Domain = _ctx.StringValue("DescribeDcdnDomainMultiUsageData.RequestPerInterval["+ i +"].Domain");
				requestDataModule.Request = _ctx.LongValue("DescribeDcdnDomainMultiUsageData.RequestPerInterval["+ i +"].Request");
				requestDataModule.Type = _ctx.StringValue("DescribeDcdnDomainMultiUsageData.RequestPerInterval["+ i +"].Type");

				describeDcdnDomainMultiUsageDataResponse_requestPerInterval.Add(requestDataModule);
			}
			describeDcdnDomainMultiUsageDataResponse.RequestPerInterval = describeDcdnDomainMultiUsageDataResponse_requestPerInterval;

			List<DescribeDcdnDomainMultiUsageDataResponse.DescribeDcdnDomainMultiUsageData_TrafficDataModule> describeDcdnDomainMultiUsageDataResponse_trafficPerInterval = new List<DescribeDcdnDomainMultiUsageDataResponse.DescribeDcdnDomainMultiUsageData_TrafficDataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainMultiUsageData.TrafficPerInterval.Length"); i++) {
				DescribeDcdnDomainMultiUsageDataResponse.DescribeDcdnDomainMultiUsageData_TrafficDataModule trafficDataModule = new DescribeDcdnDomainMultiUsageDataResponse.DescribeDcdnDomainMultiUsageData_TrafficDataModule();
				trafficDataModule.TimeStamp = _ctx.StringValue("DescribeDcdnDomainMultiUsageData.TrafficPerInterval["+ i +"].TimeStamp");
				trafficDataModule.Domain = _ctx.StringValue("DescribeDcdnDomainMultiUsageData.TrafficPerInterval["+ i +"].Domain");
				trafficDataModule.Bps = _ctx.FloatValue("DescribeDcdnDomainMultiUsageData.TrafficPerInterval["+ i +"].Bps");
				trafficDataModule.Type = _ctx.StringValue("DescribeDcdnDomainMultiUsageData.TrafficPerInterval["+ i +"].Type");
				trafficDataModule.Area = _ctx.StringValue("DescribeDcdnDomainMultiUsageData.TrafficPerInterval["+ i +"].Area");

				describeDcdnDomainMultiUsageDataResponse_trafficPerInterval.Add(trafficDataModule);
			}
			describeDcdnDomainMultiUsageDataResponse.TrafficPerInterval = describeDcdnDomainMultiUsageDataResponse_trafficPerInterval;
        
			return describeDcdnDomainMultiUsageDataResponse;
        }
    }
}
