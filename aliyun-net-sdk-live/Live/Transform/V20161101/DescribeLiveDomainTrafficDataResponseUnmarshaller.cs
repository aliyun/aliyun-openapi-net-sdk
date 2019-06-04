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
        public static DescribeLiveDomainTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveDomainTrafficDataResponse describeLiveDomainTrafficDataResponse = new DescribeLiveDomainTrafficDataResponse();

			describeLiveDomainTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeLiveDomainTrafficDataResponse.RequestId = context.StringValue("DescribeLiveDomainTrafficData.RequestId");
			describeLiveDomainTrafficDataResponse.DomainName = context.StringValue("DescribeLiveDomainTrafficData.DomainName");
			describeLiveDomainTrafficDataResponse.StartTime = context.StringValue("DescribeLiveDomainTrafficData.StartTime");
			describeLiveDomainTrafficDataResponse.EndTime = context.StringValue("DescribeLiveDomainTrafficData.EndTime");
			describeLiveDomainTrafficDataResponse.DataInterval = context.StringValue("DescribeLiveDomainTrafficData.DataInterval");

			List<DescribeLiveDomainTrafficDataResponse.DescribeLiveDomainTrafficData_DataModule> describeLiveDomainTrafficDataResponse_trafficDataPerInterval = new List<DescribeLiveDomainTrafficDataResponse.DescribeLiveDomainTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeLiveDomainTrafficData.TrafficDataPerInterval.Length"); i++) {
				DescribeLiveDomainTrafficDataResponse.DescribeLiveDomainTrafficData_DataModule dataModule = new DescribeLiveDomainTrafficDataResponse.DescribeLiveDomainTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeLiveDomainTrafficData.TrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.TrafficValue = context.StringValue("DescribeLiveDomainTrafficData.TrafficDataPerInterval["+ i +"].TrafficValue");
				dataModule.HttpTrafficValue = context.StringValue("DescribeLiveDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpTrafficValue");
				dataModule.HttpsTrafficValue = context.StringValue("DescribeLiveDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpsTrafficValue");

				describeLiveDomainTrafficDataResponse_trafficDataPerInterval.Add(dataModule);
			}
			describeLiveDomainTrafficDataResponse.TrafficDataPerInterval = describeLiveDomainTrafficDataResponse_trafficDataPerInterval;
        
			return describeLiveDomainTrafficDataResponse;
        }
    }
}
