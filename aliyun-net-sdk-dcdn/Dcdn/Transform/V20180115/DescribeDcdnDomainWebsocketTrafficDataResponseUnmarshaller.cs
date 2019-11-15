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
    public class DescribeDcdnDomainWebsocketTrafficDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainWebsocketTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainWebsocketTrafficDataResponse describeDcdnDomainWebsocketTrafficDataResponse = new DescribeDcdnDomainWebsocketTrafficDataResponse();

			describeDcdnDomainWebsocketTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainWebsocketTrafficDataResponse.RequestId = context.StringValue("DescribeDcdnDomainWebsocketTrafficData.RequestId");
			describeDcdnDomainWebsocketTrafficDataResponse.DomainName = context.StringValue("DescribeDcdnDomainWebsocketTrafficData.DomainName");
			describeDcdnDomainWebsocketTrafficDataResponse.StartTime = context.StringValue("DescribeDcdnDomainWebsocketTrafficData.StartTime");
			describeDcdnDomainWebsocketTrafficDataResponse.EndTime = context.StringValue("DescribeDcdnDomainWebsocketTrafficData.EndTime");
			describeDcdnDomainWebsocketTrafficDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainWebsocketTrafficData.DataInterval");

			List<DescribeDcdnDomainWebsocketTrafficDataResponse.DescribeDcdnDomainWebsocketTrafficData_DataModule> describeDcdnDomainWebsocketTrafficDataResponse_trafficDataPerInterval = new List<DescribeDcdnDomainWebsocketTrafficDataResponse.DescribeDcdnDomainWebsocketTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainWebsocketTrafficData.TrafficDataPerInterval.Length"); i++) {
				DescribeDcdnDomainWebsocketTrafficDataResponse.DescribeDcdnDomainWebsocketTrafficData_DataModule dataModule = new DescribeDcdnDomainWebsocketTrafficDataResponse.DescribeDcdnDomainWebsocketTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDcdnDomainWebsocketTrafficData.TrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.WebsocketTraffic = context.FloatValue("DescribeDcdnDomainWebsocketTrafficData.TrafficDataPerInterval["+ i +"].WebsocketTraffic");

				describeDcdnDomainWebsocketTrafficDataResponse_trafficDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainWebsocketTrafficDataResponse.TrafficDataPerInterval = describeDcdnDomainWebsocketTrafficDataResponse_trafficDataPerInterval;
        
			return describeDcdnDomainWebsocketTrafficDataResponse;
        }
    }
}
