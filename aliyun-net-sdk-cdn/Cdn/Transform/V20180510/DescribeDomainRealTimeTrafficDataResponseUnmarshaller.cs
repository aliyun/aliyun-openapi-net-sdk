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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainRealTimeTrafficDataResponseUnmarshaller
    {
        public static DescribeDomainRealTimeTrafficDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainRealTimeTrafficDataResponse describeDomainRealTimeTrafficDataResponse = new DescribeDomainRealTimeTrafficDataResponse();

			describeDomainRealTimeTrafficDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainRealTimeTrafficDataResponse.RequestId = _ctx.StringValue("DescribeDomainRealTimeTrafficData.RequestId");
			describeDomainRealTimeTrafficDataResponse.DomainName = _ctx.StringValue("DescribeDomainRealTimeTrafficData.DomainName");
			describeDomainRealTimeTrafficDataResponse.StartTime = _ctx.StringValue("DescribeDomainRealTimeTrafficData.StartTime");
			describeDomainRealTimeTrafficDataResponse.EndTime = _ctx.StringValue("DescribeDomainRealTimeTrafficData.EndTime");
			describeDomainRealTimeTrafficDataResponse.DataInterval = _ctx.StringValue("DescribeDomainRealTimeTrafficData.DataInterval");

			List<DescribeDomainRealTimeTrafficDataResponse.DescribeDomainRealTimeTrafficData_DataModule> describeDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval = new List<DescribeDomainRealTimeTrafficDataResponse.DescribeDomainRealTimeTrafficData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval.Length"); i++) {
				DescribeDomainRealTimeTrafficDataResponse.DescribeDomainRealTimeTrafficData_DataModule dataModule = new DescribeDomainRealTimeTrafficDataResponse.DescribeDomainRealTimeTrafficData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval["+ i +"].Value");

				describeDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval.Add(dataModule);
			}
			describeDomainRealTimeTrafficDataResponse.RealTimeTrafficDataPerInterval = describeDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval;
        
			return describeDomainRealTimeTrafficDataResponse;
        }
    }
}
