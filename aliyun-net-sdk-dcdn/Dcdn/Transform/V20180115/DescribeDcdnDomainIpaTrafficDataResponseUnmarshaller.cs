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
        public static DescribeDcdnDomainIpaTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainIpaTrafficDataResponse describeDcdnDomainIpaTrafficDataResponse = new DescribeDcdnDomainIpaTrafficDataResponse();

			describeDcdnDomainIpaTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainIpaTrafficDataResponse.RequestId = context.StringValue("DescribeDcdnDomainIpaTrafficData.RequestId");
			describeDcdnDomainIpaTrafficDataResponse.DomainName = context.StringValue("DescribeDcdnDomainIpaTrafficData.DomainName");
			describeDcdnDomainIpaTrafficDataResponse.StartTime = context.StringValue("DescribeDcdnDomainIpaTrafficData.StartTime");
			describeDcdnDomainIpaTrafficDataResponse.EndTime = context.StringValue("DescribeDcdnDomainIpaTrafficData.EndTime");
			describeDcdnDomainIpaTrafficDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainIpaTrafficData.DataInterval");

			List<DescribeDcdnDomainIpaTrafficDataResponse.DescribeDcdnDomainIpaTrafficData_DataModule> describeDcdnDomainIpaTrafficDataResponse_trafficDataPerInterval = new List<DescribeDcdnDomainIpaTrafficDataResponse.DescribeDcdnDomainIpaTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainIpaTrafficData.TrafficDataPerInterval.Length"); i++) {
				DescribeDcdnDomainIpaTrafficDataResponse.DescribeDcdnDomainIpaTrafficData_DataModule dataModule = new DescribeDcdnDomainIpaTrafficDataResponse.DescribeDcdnDomainIpaTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDcdnDomainIpaTrafficData.TrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.IpaTraffic = context.FloatValue("DescribeDcdnDomainIpaTrafficData.TrafficDataPerInterval["+ i +"].IpaTraffic");

				describeDcdnDomainIpaTrafficDataResponse_trafficDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainIpaTrafficDataResponse.TrafficDataPerInterval = describeDcdnDomainIpaTrafficDataResponse_trafficDataPerInterval;
        
			return describeDcdnDomainIpaTrafficDataResponse;
        }
    }
}
