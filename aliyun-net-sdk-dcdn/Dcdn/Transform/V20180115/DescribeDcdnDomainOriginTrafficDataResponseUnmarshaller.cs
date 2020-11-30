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
    public class DescribeDcdnDomainOriginTrafficDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainOriginTrafficDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainOriginTrafficDataResponse describeDcdnDomainOriginTrafficDataResponse = new DescribeDcdnDomainOriginTrafficDataResponse();

			describeDcdnDomainOriginTrafficDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainOriginTrafficDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainOriginTrafficData.RequestId");
			describeDcdnDomainOriginTrafficDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainOriginTrafficData.DomainName");
			describeDcdnDomainOriginTrafficDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainOriginTrafficData.StartTime");
			describeDcdnDomainOriginTrafficDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainOriginTrafficData.EndTime");
			describeDcdnDomainOriginTrafficDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainOriginTrafficData.DataInterval");

			List<DescribeDcdnDomainOriginTrafficDataResponse.DescribeDcdnDomainOriginTrafficData_DataModule> describeDcdnDomainOriginTrafficDataResponse_originTrafficDataPerInterval = new List<DescribeDcdnDomainOriginTrafficDataResponse.DescribeDcdnDomainOriginTrafficData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval.Length"); i++) {
				DescribeDcdnDomainOriginTrafficDataResponse.DescribeDcdnDomainOriginTrafficData_DataModule dataModule = new DescribeDcdnDomainOriginTrafficDataResponse.DescribeDcdnDomainOriginTrafficData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.OriginTraffic = _ctx.FloatValue("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].OriginTraffic");
				dataModule.DynamicHttpOriginTraffic = _ctx.FloatValue("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].DynamicHttpOriginTraffic");
				dataModule.DynamicHttpsOriginTraffic = _ctx.FloatValue("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].DynamicHttpsOriginTraffic");
				dataModule.StaticHttpOriginTraffic = _ctx.FloatValue("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].StaticHttpOriginTraffic");
				dataModule.StaticHttpsOriginTraffic = _ctx.FloatValue("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].StaticHttpsOriginTraffic");

				describeDcdnDomainOriginTrafficDataResponse_originTrafficDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainOriginTrafficDataResponse.OriginTrafficDataPerInterval = describeDcdnDomainOriginTrafficDataResponse_originTrafficDataPerInterval;
        
			return describeDcdnDomainOriginTrafficDataResponse;
        }
    }
}
