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
    public class DescribeDomainRealTimeSrcBpsDataResponseUnmarshaller
    {
        public static DescribeDomainRealTimeSrcBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainRealTimeSrcBpsDataResponse describeDomainRealTimeSrcBpsDataResponse = new DescribeDomainRealTimeSrcBpsDataResponse();

			describeDomainRealTimeSrcBpsDataResponse.HttpResponse = context.HttpResponse;
			describeDomainRealTimeSrcBpsDataResponse.RequestId = context.StringValue("DescribeDomainRealTimeSrcBpsData.RequestId");
			describeDomainRealTimeSrcBpsDataResponse.DomainName = context.StringValue("DescribeDomainRealTimeSrcBpsData.DomainName");
			describeDomainRealTimeSrcBpsDataResponse.StartTime = context.StringValue("DescribeDomainRealTimeSrcBpsData.StartTime");
			describeDomainRealTimeSrcBpsDataResponse.EndTime = context.StringValue("DescribeDomainRealTimeSrcBpsData.EndTime");
			describeDomainRealTimeSrcBpsDataResponse.DataInterval = context.StringValue("DescribeDomainRealTimeSrcBpsData.DataInterval");

			List<DescribeDomainRealTimeSrcBpsDataResponse.DescribeDomainRealTimeSrcBpsData_DataModule> describeDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval = new List<DescribeDomainRealTimeSrcBpsDataResponse.DescribeDomainRealTimeSrcBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval.Length"); i++) {
				DescribeDomainRealTimeSrcBpsDataResponse.DescribeDomainRealTimeSrcBpsData_DataModule dataModule = new DescribeDomainRealTimeSrcBpsDataResponse.DescribeDomainRealTimeSrcBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval["+ i +"]._Value");

				describeDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval.Add(dataModule);
			}
			describeDomainRealTimeSrcBpsDataResponse.RealTimeSrcBpsDataPerInterval = describeDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval;
        
			return describeDomainRealTimeSrcBpsDataResponse;
        }
    }
}
