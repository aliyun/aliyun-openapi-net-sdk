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
    public class DescribeDcdnDomainIpaTrafficDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainIpaTrafficDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainIpaTrafficDataResponse describeDcdnDomainIpaTrafficDataResponse = new DescribeDcdnDomainIpaTrafficDataResponse();

			describeDcdnDomainIpaTrafficDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainIpaTrafficDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainIpaTrafficData.RequestId");
			describeDcdnDomainIpaTrafficDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainIpaTrafficData.DomainName");
			describeDcdnDomainIpaTrafficDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainIpaTrafficData.StartTime");
			describeDcdnDomainIpaTrafficDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainIpaTrafficData.EndTime");
			describeDcdnDomainIpaTrafficDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainIpaTrafficData.DataInterval");

			List<DescribeDcdnDomainIpaTrafficDataResponse.DescribeDcdnDomainIpaTrafficData_DataModule> describeDcdnDomainIpaTrafficDataResponse_trafficDataPerInterval = new List<DescribeDcdnDomainIpaTrafficDataResponse.DescribeDcdnDomainIpaTrafficData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainIpaTrafficData.TrafficDataPerInterval.Length"); i++) {
				DescribeDcdnDomainIpaTrafficDataResponse.DescribeDcdnDomainIpaTrafficData_DataModule dataModule = new DescribeDcdnDomainIpaTrafficDataResponse.DescribeDcdnDomainIpaTrafficData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDcdnDomainIpaTrafficData.TrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.IpaTraffic = _ctx.FloatValue("DescribeDcdnDomainIpaTrafficData.TrafficDataPerInterval["+ i +"].IpaTraffic");

				describeDcdnDomainIpaTrafficDataResponse_trafficDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainIpaTrafficDataResponse.TrafficDataPerInterval = describeDcdnDomainIpaTrafficDataResponse_trafficDataPerInterval;
        
			return describeDcdnDomainIpaTrafficDataResponse;
        }
    }
}
