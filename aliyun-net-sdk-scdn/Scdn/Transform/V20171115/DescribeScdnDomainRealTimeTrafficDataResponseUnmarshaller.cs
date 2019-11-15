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
    public class DescribeScdnDomainRealTimeTrafficDataResponseUnmarshaller
    {
        public static DescribeScdnDomainRealTimeTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainRealTimeTrafficDataResponse describeScdnDomainRealTimeTrafficDataResponse = new DescribeScdnDomainRealTimeTrafficDataResponse();

			describeScdnDomainRealTimeTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainRealTimeTrafficDataResponse.RequestId = context.StringValue("DescribeScdnDomainRealTimeTrafficData.RequestId");
			describeScdnDomainRealTimeTrafficDataResponse.DomainName = context.StringValue("DescribeScdnDomainRealTimeTrafficData.DomainName");
			describeScdnDomainRealTimeTrafficDataResponse.StartTime = context.StringValue("DescribeScdnDomainRealTimeTrafficData.StartTime");
			describeScdnDomainRealTimeTrafficDataResponse.EndTime = context.StringValue("DescribeScdnDomainRealTimeTrafficData.EndTime");
			describeScdnDomainRealTimeTrafficDataResponse.DataInterval = context.StringValue("DescribeScdnDomainRealTimeTrafficData.DataInterval");

			List<DescribeScdnDomainRealTimeTrafficDataResponse.DescribeScdnDomainRealTimeTrafficData_DataModule> describeScdnDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval = new List<DescribeScdnDomainRealTimeTrafficDataResponse.DescribeScdnDomainRealTimeTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeScdnDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval.Length"); i++) {
				DescribeScdnDomainRealTimeTrafficDataResponse.DescribeScdnDomainRealTimeTrafficData_DataModule dataModule = new DescribeScdnDomainRealTimeTrafficDataResponse.DescribeScdnDomainRealTimeTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeScdnDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeScdnDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval["+ i +"].Value");

				describeScdnDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval.Add(dataModule);
			}
			describeScdnDomainRealTimeTrafficDataResponse.RealTimeTrafficDataPerInterval = describeScdnDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval;
        
			return describeScdnDomainRealTimeTrafficDataResponse;
        }
    }
}
