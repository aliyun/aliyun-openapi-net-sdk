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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20180510;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainTrafficDataResponseUnmarshaller
    {
        public static DescribeDomainTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainTrafficDataResponse describeDomainTrafficDataResponse = new DescribeDomainTrafficDataResponse();

			describeDomainTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeDomainTrafficDataResponse.RequestId = context.StringValue("DescribeDomainTrafficData.RequestId");
			describeDomainTrafficDataResponse.DomainName = context.StringValue("DescribeDomainTrafficData.DomainName");
			describeDomainTrafficDataResponse.StartTime = context.StringValue("DescribeDomainTrafficData.StartTime");
			describeDomainTrafficDataResponse.EndTime = context.StringValue("DescribeDomainTrafficData.EndTime");
			describeDomainTrafficDataResponse.DataInterval = context.StringValue("DescribeDomainTrafficData.DataInterval");

			List<DescribeDomainTrafficDataResponse.DescribeDomainTrafficData_DataModule> describeDomainTrafficDataResponse_trafficDataPerInterval = new List<DescribeDomainTrafficDataResponse.DescribeDomainTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainTrafficData.TrafficDataPerInterval.Length"); i++) {
				DescribeDomainTrafficDataResponse.DescribeDomainTrafficData_DataModule dataModule = new DescribeDomainTrafficDataResponse.DescribeDomainTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainTrafficData.TrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainTrafficData.TrafficDataPerInterval["+ i +"].Value");
				dataModule.DomesticValue = context.StringValue("DescribeDomainTrafficData.TrafficDataPerInterval["+ i +"].DomesticValue");
				dataModule.OverseasValue = context.StringValue("DescribeDomainTrafficData.TrafficDataPerInterval["+ i +"].OverseasValue");
				dataModule.HttpsValue = context.StringValue("DescribeDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpsValue");
				dataModule.HttpsDomesticValue = context.StringValue("DescribeDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpsDomesticValue");
				dataModule.HttpsOverseasValue = context.StringValue("DescribeDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpsOverseasValue");

				describeDomainTrafficDataResponse_trafficDataPerInterval.Add(dataModule);
			}
			describeDomainTrafficDataResponse.TrafficDataPerInterval = describeDomainTrafficDataResponse_trafficDataPerInterval;
        
			return describeDomainTrafficDataResponse;
        }
    }
}