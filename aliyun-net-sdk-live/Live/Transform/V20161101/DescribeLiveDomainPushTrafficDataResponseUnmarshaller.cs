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
    public class DescribeLiveDomainPushTrafficDataResponseUnmarshaller
    {
        public static DescribeLiveDomainPushTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveDomainPushTrafficDataResponse describeLiveDomainPushTrafficDataResponse = new DescribeLiveDomainPushTrafficDataResponse();

			describeLiveDomainPushTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeLiveDomainPushTrafficDataResponse.RequestId = context.StringValue("DescribeLiveDomainPushTrafficData.RequestId");
			describeLiveDomainPushTrafficDataResponse.DomainName = context.StringValue("DescribeLiveDomainPushTrafficData.DomainName");
			describeLiveDomainPushTrafficDataResponse.StartTime = context.StringValue("DescribeLiveDomainPushTrafficData.StartTime");
			describeLiveDomainPushTrafficDataResponse.EndTime = context.StringValue("DescribeLiveDomainPushTrafficData.EndTime");
			describeLiveDomainPushTrafficDataResponse.DataInterval = context.StringValue("DescribeLiveDomainPushTrafficData.DataInterval");

			List<DescribeLiveDomainPushTrafficDataResponse.DescribeLiveDomainPushTrafficData_DataModule> describeLiveDomainPushTrafficDataResponse_trafficDataPerInterval = new List<DescribeLiveDomainPushTrafficDataResponse.DescribeLiveDomainPushTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeLiveDomainPushTrafficData.TrafficDataPerInterval.Length"); i++) {
				DescribeLiveDomainPushTrafficDataResponse.DescribeLiveDomainPushTrafficData_DataModule dataModule = new DescribeLiveDomainPushTrafficDataResponse.DescribeLiveDomainPushTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeLiveDomainPushTrafficData.TrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.TrafficValue = context.StringValue("DescribeLiveDomainPushTrafficData.TrafficDataPerInterval["+ i +"].TrafficValue");

				describeLiveDomainPushTrafficDataResponse_trafficDataPerInterval.Add(dataModule);
			}
			describeLiveDomainPushTrafficDataResponse.TrafficDataPerInterval = describeLiveDomainPushTrafficDataResponse_trafficDataPerInterval;
        
			return describeLiveDomainPushTrafficDataResponse;
        }
    }
}
