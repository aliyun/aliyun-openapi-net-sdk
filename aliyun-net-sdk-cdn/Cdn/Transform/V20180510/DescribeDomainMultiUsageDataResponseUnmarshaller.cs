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
    public class DescribeDomainMultiUsageDataResponseUnmarshaller
    {
        public static DescribeDomainMultiUsageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainMultiUsageDataResponse describeDomainMultiUsageDataResponse = new DescribeDomainMultiUsageDataResponse();

			describeDomainMultiUsageDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainMultiUsageDataResponse.RequestId = _ctx.StringValue("DescribeDomainMultiUsageData.RequestId");
			describeDomainMultiUsageDataResponse.StartTime = _ctx.StringValue("DescribeDomainMultiUsageData.StartTime");
			describeDomainMultiUsageDataResponse.EndTime = _ctx.StringValue("DescribeDomainMultiUsageData.EndTime");

			List<DescribeDomainMultiUsageDataResponse.DescribeDomainMultiUsageData_RequestDataModule> describeDomainMultiUsageDataResponse_requestPerInterval = new List<DescribeDomainMultiUsageDataResponse.DescribeDomainMultiUsageData_RequestDataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainMultiUsageData.RequestPerInterval.Length"); i++) {
				DescribeDomainMultiUsageDataResponse.DescribeDomainMultiUsageData_RequestDataModule requestDataModule = new DescribeDomainMultiUsageDataResponse.DescribeDomainMultiUsageData_RequestDataModule();
				requestDataModule.TimeStamp = _ctx.StringValue("DescribeDomainMultiUsageData.RequestPerInterval["+ i +"].TimeStamp");
				requestDataModule.Domain = _ctx.StringValue("DescribeDomainMultiUsageData.RequestPerInterval["+ i +"].Domain");
				requestDataModule.Request = _ctx.LongValue("DescribeDomainMultiUsageData.RequestPerInterval["+ i +"].Request");
				requestDataModule.Type = _ctx.StringValue("DescribeDomainMultiUsageData.RequestPerInterval["+ i +"].Type");

				describeDomainMultiUsageDataResponse_requestPerInterval.Add(requestDataModule);
			}
			describeDomainMultiUsageDataResponse.RequestPerInterval = describeDomainMultiUsageDataResponse_requestPerInterval;

			List<DescribeDomainMultiUsageDataResponse.DescribeDomainMultiUsageData_TrafficDataModule> describeDomainMultiUsageDataResponse_trafficPerInterval = new List<DescribeDomainMultiUsageDataResponse.DescribeDomainMultiUsageData_TrafficDataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainMultiUsageData.TrafficPerInterval.Length"); i++) {
				DescribeDomainMultiUsageDataResponse.DescribeDomainMultiUsageData_TrafficDataModule trafficDataModule = new DescribeDomainMultiUsageDataResponse.DescribeDomainMultiUsageData_TrafficDataModule();
				trafficDataModule.TimeStamp = _ctx.StringValue("DescribeDomainMultiUsageData.TrafficPerInterval["+ i +"].TimeStamp");
				trafficDataModule.Domain = _ctx.StringValue("DescribeDomainMultiUsageData.TrafficPerInterval["+ i +"].Domain");
				trafficDataModule.Bps = _ctx.FloatValue("DescribeDomainMultiUsageData.TrafficPerInterval["+ i +"].Bps");
				trafficDataModule.Type = _ctx.StringValue("DescribeDomainMultiUsageData.TrafficPerInterval["+ i +"].Type");
				trafficDataModule.Area = _ctx.StringValue("DescribeDomainMultiUsageData.TrafficPerInterval["+ i +"].Area");

				describeDomainMultiUsageDataResponse_trafficPerInterval.Add(trafficDataModule);
			}
			describeDomainMultiUsageDataResponse.TrafficPerInterval = describeDomainMultiUsageDataResponse_trafficPerInterval;
        
			return describeDomainMultiUsageDataResponse;
        }
    }
}
