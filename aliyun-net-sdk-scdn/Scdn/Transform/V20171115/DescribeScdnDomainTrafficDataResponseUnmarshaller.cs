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
    public class DescribeScdnDomainTrafficDataResponseUnmarshaller
    {
        public static DescribeScdnDomainTrafficDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnDomainTrafficDataResponse describeScdnDomainTrafficDataResponse = new DescribeScdnDomainTrafficDataResponse();

			describeScdnDomainTrafficDataResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnDomainTrafficDataResponse.RequestId = _ctx.StringValue("DescribeScdnDomainTrafficData.RequestId");
			describeScdnDomainTrafficDataResponse.DomainName = _ctx.StringValue("DescribeScdnDomainTrafficData.DomainName");
			describeScdnDomainTrafficDataResponse.StartTime = _ctx.StringValue("DescribeScdnDomainTrafficData.StartTime");
			describeScdnDomainTrafficDataResponse.EndTime = _ctx.StringValue("DescribeScdnDomainTrafficData.EndTime");
			describeScdnDomainTrafficDataResponse.DataInterval = _ctx.StringValue("DescribeScdnDomainTrafficData.DataInterval");

			List<DescribeScdnDomainTrafficDataResponse.DescribeScdnDomainTrafficData_DataModule> describeScdnDomainTrafficDataResponse_trafficDataPerInterval = new List<DescribeScdnDomainTrafficDataResponse.DescribeScdnDomainTrafficData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDomainTrafficData.TrafficDataPerInterval.Length"); i++) {
				DescribeScdnDomainTrafficDataResponse.DescribeScdnDomainTrafficData_DataModule dataModule = new DescribeScdnDomainTrafficDataResponse.DescribeScdnDomainTrafficData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeScdnDomainTrafficData.TrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.TrafficValue = _ctx.StringValue("DescribeScdnDomainTrafficData.TrafficDataPerInterval["+ i +"].TrafficValue");
				dataModule.HttpTrafficValue = _ctx.StringValue("DescribeScdnDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpTrafficValue");
				dataModule.HttpsTrafficValue = _ctx.StringValue("DescribeScdnDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpsTrafficValue");

				describeScdnDomainTrafficDataResponse_trafficDataPerInterval.Add(dataModule);
			}
			describeScdnDomainTrafficDataResponse.TrafficDataPerInterval = describeScdnDomainTrafficDataResponse_trafficDataPerInterval;
        
			return describeScdnDomainTrafficDataResponse;
        }
    }
}
