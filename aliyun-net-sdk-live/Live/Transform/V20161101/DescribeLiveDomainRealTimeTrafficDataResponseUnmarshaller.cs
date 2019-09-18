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
    public class DescribeLiveDomainRealTimeTrafficDataResponseUnmarshaller
    {
        public static DescribeLiveDomainRealTimeTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveDomainRealTimeTrafficDataResponse describeLiveDomainRealTimeTrafficDataResponse = new DescribeLiveDomainRealTimeTrafficDataResponse();

			describeLiveDomainRealTimeTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeLiveDomainRealTimeTrafficDataResponse.RequestId = context.StringValue("DescribeLiveDomainRealTimeTrafficData.RequestId");
			describeLiveDomainRealTimeTrafficDataResponse.DomainName = context.StringValue("DescribeLiveDomainRealTimeTrafficData.DomainName");
			describeLiveDomainRealTimeTrafficDataResponse.StartTime = context.StringValue("DescribeLiveDomainRealTimeTrafficData.StartTime");
			describeLiveDomainRealTimeTrafficDataResponse.EndTime = context.StringValue("DescribeLiveDomainRealTimeTrafficData.EndTime");
			describeLiveDomainRealTimeTrafficDataResponse.DataInterval = context.StringValue("DescribeLiveDomainRealTimeTrafficData.DataInterval");

			List<DescribeLiveDomainRealTimeTrafficDataResponse.DescribeLiveDomainRealTimeTrafficData_DataModule> describeLiveDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval = new List<DescribeLiveDomainRealTimeTrafficDataResponse.DescribeLiveDomainRealTimeTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeLiveDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval.Length"); i++) {
				DescribeLiveDomainRealTimeTrafficDataResponse.DescribeLiveDomainRealTimeTrafficData_DataModule dataModule = new DescribeLiveDomainRealTimeTrafficDataResponse.DescribeLiveDomainRealTimeTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeLiveDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeLiveDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval["+ i +"].Value");

				describeLiveDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval.Add(dataModule);
			}
			describeLiveDomainRealTimeTrafficDataResponse.RealTimeTrafficDataPerInterval = describeLiveDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval;
        
			return describeLiveDomainRealTimeTrafficDataResponse;
        }
    }
}
