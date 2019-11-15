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
    public class DescribeDcdnDomainRealTimeSrcTrafficDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainRealTimeSrcTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainRealTimeSrcTrafficDataResponse describeDcdnDomainRealTimeSrcTrafficDataResponse = new DescribeDcdnDomainRealTimeSrcTrafficDataResponse();

			describeDcdnDomainRealTimeSrcTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainRealTimeSrcTrafficDataResponse.RequestId = context.StringValue("DescribeDcdnDomainRealTimeSrcTrafficData.RequestId");
			describeDcdnDomainRealTimeSrcTrafficDataResponse.DomainName = context.StringValue("DescribeDcdnDomainRealTimeSrcTrafficData.DomainName");
			describeDcdnDomainRealTimeSrcTrafficDataResponse.StartTime = context.StringValue("DescribeDcdnDomainRealTimeSrcTrafficData.StartTime");
			describeDcdnDomainRealTimeSrcTrafficDataResponse.EndTime = context.StringValue("DescribeDcdnDomainRealTimeSrcTrafficData.EndTime");
			describeDcdnDomainRealTimeSrcTrafficDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainRealTimeSrcTrafficData.DataInterval");

			List<DescribeDcdnDomainRealTimeSrcTrafficDataResponse.DescribeDcdnDomainRealTimeSrcTrafficData_DataModule> describeDcdnDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval = new List<DescribeDcdnDomainRealTimeSrcTrafficDataResponse.DescribeDcdnDomainRealTimeSrcTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval.Length"); i++) {
				DescribeDcdnDomainRealTimeSrcTrafficDataResponse.DescribeDcdnDomainRealTimeSrcTrafficData_DataModule dataModule = new DescribeDcdnDomainRealTimeSrcTrafficDataResponse.DescribeDcdnDomainRealTimeSrcTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDcdnDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDcdnDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval["+ i +"].Value");

				describeDcdnDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainRealTimeSrcTrafficDataResponse.RealTimeSrcTrafficDataPerInterval = describeDcdnDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval;
        
			return describeDcdnDomainRealTimeSrcTrafficDataResponse;
        }
    }
}
