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
    public class DescribeDcdnDomainRealTimeSrcBpsDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainRealTimeSrcBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainRealTimeSrcBpsDataResponse describeDcdnDomainRealTimeSrcBpsDataResponse = new DescribeDcdnDomainRealTimeSrcBpsDataResponse();

			describeDcdnDomainRealTimeSrcBpsDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainRealTimeSrcBpsDataResponse.RequestId = context.StringValue("DescribeDcdnDomainRealTimeSrcBpsData.RequestId");
			describeDcdnDomainRealTimeSrcBpsDataResponse.DomainName = context.StringValue("DescribeDcdnDomainRealTimeSrcBpsData.DomainName");
			describeDcdnDomainRealTimeSrcBpsDataResponse.StartTime = context.StringValue("DescribeDcdnDomainRealTimeSrcBpsData.StartTime");
			describeDcdnDomainRealTimeSrcBpsDataResponse.EndTime = context.StringValue("DescribeDcdnDomainRealTimeSrcBpsData.EndTime");
			describeDcdnDomainRealTimeSrcBpsDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainRealTimeSrcBpsData.DataInterval");

			List<DescribeDcdnDomainRealTimeSrcBpsDataResponse.DescribeDcdnDomainRealTimeSrcBpsData_DataModule> describeDcdnDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval = new List<DescribeDcdnDomainRealTimeSrcBpsDataResponse.DescribeDcdnDomainRealTimeSrcBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval.Length"); i++) {
				DescribeDcdnDomainRealTimeSrcBpsDataResponse.DescribeDcdnDomainRealTimeSrcBpsData_DataModule dataModule = new DescribeDcdnDomainRealTimeSrcBpsDataResponse.DescribeDcdnDomainRealTimeSrcBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDcdnDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDcdnDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval["+ i +"].Value");

				describeDcdnDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainRealTimeSrcBpsDataResponse.RealTimeSrcBpsDataPerInterval = describeDcdnDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval;
        
			return describeDcdnDomainRealTimeSrcBpsDataResponse;
        }
    }
}
