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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainTrafficDataResponseUnmarshaller
    {
        public static DescribeLiveDomainTrafficDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainTrafficDataResponse describeLiveDomainTrafficDataResponse = new DescribeLiveDomainTrafficDataResponse();

			describeLiveDomainTrafficDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainTrafficDataResponse.RequestId = _ctx.StringValue("DescribeLiveDomainTrafficData.RequestId");
			describeLiveDomainTrafficDataResponse.DomainName = _ctx.StringValue("DescribeLiveDomainTrafficData.DomainName");
			describeLiveDomainTrafficDataResponse.StartTime = _ctx.StringValue("DescribeLiveDomainTrafficData.StartTime");
			describeLiveDomainTrafficDataResponse.EndTime = _ctx.StringValue("DescribeLiveDomainTrafficData.EndTime");
			describeLiveDomainTrafficDataResponse.DataInterval = _ctx.StringValue("DescribeLiveDomainTrafficData.DataInterval");

			List<DescribeLiveDomainTrafficDataResponse.DescribeLiveDomainTrafficData_DataModule> describeLiveDomainTrafficDataResponse_trafficDataPerInterval = new List<DescribeLiveDomainTrafficDataResponse.DescribeLiveDomainTrafficData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainTrafficData.TrafficDataPerInterval.Length"); i++) {
				DescribeLiveDomainTrafficDataResponse.DescribeLiveDomainTrafficData_DataModule dataModule = new DescribeLiveDomainTrafficDataResponse.DescribeLiveDomainTrafficData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeLiveDomainTrafficData.TrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.TrafficValue = _ctx.StringValue("DescribeLiveDomainTrafficData.TrafficDataPerInterval["+ i +"].TrafficValue");
				dataModule.HttpTrafficValue = _ctx.StringValue("DescribeLiveDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpTrafficValue");
				dataModule.HttpsTrafficValue = _ctx.StringValue("DescribeLiveDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpsTrafficValue");

				describeLiveDomainTrafficDataResponse_trafficDataPerInterval.Add(dataModule);
			}
			describeLiveDomainTrafficDataResponse.TrafficDataPerInterval = describeLiveDomainTrafficDataResponse_trafficDataPerInterval;
        
			return describeLiveDomainTrafficDataResponse;
        }
    }
}
