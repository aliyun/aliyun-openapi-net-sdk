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
        public static DescribeDcdnDomainOriginTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainOriginTrafficDataResponse describeDcdnDomainOriginTrafficDataResponse = new DescribeDcdnDomainOriginTrafficDataResponse();

			describeDcdnDomainOriginTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainOriginTrafficDataResponse.RequestId = context.StringValue("DescribeDcdnDomainOriginTrafficData.RequestId");
			describeDcdnDomainOriginTrafficDataResponse.DomainName = context.StringValue("DescribeDcdnDomainOriginTrafficData.DomainName");
			describeDcdnDomainOriginTrafficDataResponse.StartTime = context.StringValue("DescribeDcdnDomainOriginTrafficData.StartTime");
			describeDcdnDomainOriginTrafficDataResponse.EndTime = context.StringValue("DescribeDcdnDomainOriginTrafficData.EndTime");
			describeDcdnDomainOriginTrafficDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainOriginTrafficData.DataInterval");

			List<DescribeDcdnDomainOriginTrafficDataResponse.DescribeDcdnDomainOriginTrafficData_DataModule> describeDcdnDomainOriginTrafficDataResponse_originTrafficDataPerInterval = new List<DescribeDcdnDomainOriginTrafficDataResponse.DescribeDcdnDomainOriginTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval.Length"); i++) {
				DescribeDcdnDomainOriginTrafficDataResponse.DescribeDcdnDomainOriginTrafficData_DataModule dataModule = new DescribeDcdnDomainOriginTrafficDataResponse.DescribeDcdnDomainOriginTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.OriginTraffic = context.FloatValue("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].OriginTraffic");
				dataModule.DynamicHttpOriginTraffic = context.FloatValue("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].DynamicHttpOriginTraffic");
				dataModule.DynamicHttpsOriginTraffic = context.FloatValue("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].DynamicHttpsOriginTraffic");
				dataModule.StaticHttpOriginTraffic = context.FloatValue("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].StaticHttpOriginTraffic");
				dataModule.StaticHttpsOriginTraffic = context.FloatValue("DescribeDcdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].StaticHttpsOriginTraffic");

				describeDcdnDomainOriginTrafficDataResponse_originTrafficDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainOriginTrafficDataResponse.OriginTrafficDataPerInterval = describeDcdnDomainOriginTrafficDataResponse_originTrafficDataPerInterval;
        
			return describeDcdnDomainOriginTrafficDataResponse;
        }
    }
}
