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
    public class DescribeScdnDomainRealTimeSrcBpsDataResponseUnmarshaller
    {
        public static DescribeScdnDomainRealTimeSrcBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainRealTimeSrcBpsDataResponse describeScdnDomainRealTimeSrcBpsDataResponse = new DescribeScdnDomainRealTimeSrcBpsDataResponse();

			describeScdnDomainRealTimeSrcBpsDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainRealTimeSrcBpsDataResponse.RequestId = context.StringValue("DescribeScdnDomainRealTimeSrcBpsData.RequestId");
			describeScdnDomainRealTimeSrcBpsDataResponse.DomainName = context.StringValue("DescribeScdnDomainRealTimeSrcBpsData.DomainName");
			describeScdnDomainRealTimeSrcBpsDataResponse.StartTime = context.StringValue("DescribeScdnDomainRealTimeSrcBpsData.StartTime");
			describeScdnDomainRealTimeSrcBpsDataResponse.EndTime = context.StringValue("DescribeScdnDomainRealTimeSrcBpsData.EndTime");
			describeScdnDomainRealTimeSrcBpsDataResponse.DataInterval = context.StringValue("DescribeScdnDomainRealTimeSrcBpsData.DataInterval");

			List<DescribeScdnDomainRealTimeSrcBpsDataResponse.DescribeScdnDomainRealTimeSrcBpsData_DataModule> describeScdnDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval = new List<DescribeScdnDomainRealTimeSrcBpsDataResponse.DescribeScdnDomainRealTimeSrcBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeScdnDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval.Length"); i++) {
				DescribeScdnDomainRealTimeSrcBpsDataResponse.DescribeScdnDomainRealTimeSrcBpsData_DataModule dataModule = new DescribeScdnDomainRealTimeSrcBpsDataResponse.DescribeScdnDomainRealTimeSrcBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeScdnDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeScdnDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval["+ i +"].Value");

				describeScdnDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval.Add(dataModule);
			}
			describeScdnDomainRealTimeSrcBpsDataResponse.RealTimeSrcBpsDataPerInterval = describeScdnDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval;
        
			return describeScdnDomainRealTimeSrcBpsDataResponse;
        }
    }
}
