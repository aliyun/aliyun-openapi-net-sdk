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
    public class DescribeDcdnDomainTrafficDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainTrafficDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainTrafficDataResponse describeDcdnDomainTrafficDataResponse = new DescribeDcdnDomainTrafficDataResponse();

			describeDcdnDomainTrafficDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainTrafficDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainTrafficData.RequestId");
			describeDcdnDomainTrafficDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainTrafficData.DomainName");
			describeDcdnDomainTrafficDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainTrafficData.StartTime");
			describeDcdnDomainTrafficDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainTrafficData.EndTime");
			describeDcdnDomainTrafficDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainTrafficData.DataInterval");

			List<DescribeDcdnDomainTrafficDataResponse.DescribeDcdnDomainTrafficData_DataModule> describeDcdnDomainTrafficDataResponse_trafficDataPerInterval = new List<DescribeDcdnDomainTrafficDataResponse.DescribeDcdnDomainTrafficData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainTrafficData.TrafficDataPerInterval.Length"); i++) {
				DescribeDcdnDomainTrafficDataResponse.DescribeDcdnDomainTrafficData_DataModule dataModule = new DescribeDcdnDomainTrafficDataResponse.DescribeDcdnDomainTrafficData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDcdnDomainTrafficData.TrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.Traffic = _ctx.FloatValue("DescribeDcdnDomainTrafficData.TrafficDataPerInterval["+ i +"].Traffic");
				dataModule.DynamicHttpTraffic = _ctx.FloatValue("DescribeDcdnDomainTrafficData.TrafficDataPerInterval["+ i +"].DynamicHttpTraffic");
				dataModule.DynamicHttpsTraffic = _ctx.FloatValue("DescribeDcdnDomainTrafficData.TrafficDataPerInterval["+ i +"].DynamicHttpsTraffic");
				dataModule.StaticHttpTraffic = _ctx.FloatValue("DescribeDcdnDomainTrafficData.TrafficDataPerInterval["+ i +"].StaticHttpTraffic");
				dataModule.StaticHttpsTraffic = _ctx.FloatValue("DescribeDcdnDomainTrafficData.TrafficDataPerInterval["+ i +"].StaticHttpsTraffic");

				describeDcdnDomainTrafficDataResponse_trafficDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainTrafficDataResponse.TrafficDataPerInterval = describeDcdnDomainTrafficDataResponse_trafficDataPerInterval;
        
			return describeDcdnDomainTrafficDataResponse;
        }
    }
}
