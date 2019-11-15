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
        public static DescribeScdnDomainTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainTrafficDataResponse describeScdnDomainTrafficDataResponse = new DescribeScdnDomainTrafficDataResponse();

			describeScdnDomainTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainTrafficDataResponse.RequestId = context.StringValue("DescribeScdnDomainTrafficData.RequestId");
			describeScdnDomainTrafficDataResponse.DomainName = context.StringValue("DescribeScdnDomainTrafficData.DomainName");
			describeScdnDomainTrafficDataResponse.StartTime = context.StringValue("DescribeScdnDomainTrafficData.StartTime");
			describeScdnDomainTrafficDataResponse.EndTime = context.StringValue("DescribeScdnDomainTrafficData.EndTime");
			describeScdnDomainTrafficDataResponse.DataInterval = context.StringValue("DescribeScdnDomainTrafficData.DataInterval");

			List<DescribeScdnDomainTrafficDataResponse.DescribeScdnDomainTrafficData_DataModule> describeScdnDomainTrafficDataResponse_trafficDataPerInterval = new List<DescribeScdnDomainTrafficDataResponse.DescribeScdnDomainTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeScdnDomainTrafficData.TrafficDataPerInterval.Length"); i++) {
				DescribeScdnDomainTrafficDataResponse.DescribeScdnDomainTrafficData_DataModule dataModule = new DescribeScdnDomainTrafficDataResponse.DescribeScdnDomainTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeScdnDomainTrafficData.TrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.TrafficValue = context.StringValue("DescribeScdnDomainTrafficData.TrafficDataPerInterval["+ i +"].TrafficValue");
				dataModule.HttpTrafficValue = context.StringValue("DescribeScdnDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpTrafficValue");
				dataModule.HttpsTrafficValue = context.StringValue("DescribeScdnDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpsTrafficValue");

				describeScdnDomainTrafficDataResponse_trafficDataPerInterval.Add(dataModule);
			}
			describeScdnDomainTrafficDataResponse.TrafficDataPerInterval = describeScdnDomainTrafficDataResponse_trafficDataPerInterval;
        
			return describeScdnDomainTrafficDataResponse;
        }
    }
}
