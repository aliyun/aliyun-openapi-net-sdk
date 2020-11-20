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
    public class DescribeDcdnDomainRealTimeTrafficDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainRealTimeTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainRealTimeTrafficDataResponse describeDcdnDomainRealTimeTrafficDataResponse = new DescribeDcdnDomainRealTimeTrafficDataResponse();

			describeDcdnDomainRealTimeTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainRealTimeTrafficDataResponse.RequestId = context.StringValue("DescribeDcdnDomainRealTimeTrafficData.RequestId");
			describeDcdnDomainRealTimeTrafficDataResponse.DomainName = context.StringValue("DescribeDcdnDomainRealTimeTrafficData.DomainName");
			describeDcdnDomainRealTimeTrafficDataResponse.StartTime = context.StringValue("DescribeDcdnDomainRealTimeTrafficData.StartTime");
			describeDcdnDomainRealTimeTrafficDataResponse.EndTime = context.StringValue("DescribeDcdnDomainRealTimeTrafficData.EndTime");
			describeDcdnDomainRealTimeTrafficDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainRealTimeTrafficData.DataInterval");

			List<DescribeDcdnDomainRealTimeTrafficDataResponse.DescribeDcdnDomainRealTimeTrafficData_DataModule> describeDcdnDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval = new List<DescribeDcdnDomainRealTimeTrafficDataResponse.DescribeDcdnDomainRealTimeTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval.Length"); i++) {
				DescribeDcdnDomainRealTimeTrafficDataResponse.DescribeDcdnDomainRealTimeTrafficData_DataModule dataModule = new DescribeDcdnDomainRealTimeTrafficDataResponse.DescribeDcdnDomainRealTimeTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDcdnDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDcdnDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval["+ i +"].Value");

				describeDcdnDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainRealTimeTrafficDataResponse.RealTimeTrafficDataPerInterval = describeDcdnDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval;
        
			return describeDcdnDomainRealTimeTrafficDataResponse;
        }
    }
}
