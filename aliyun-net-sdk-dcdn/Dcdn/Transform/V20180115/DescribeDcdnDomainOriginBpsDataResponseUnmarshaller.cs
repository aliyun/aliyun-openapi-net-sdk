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
    public class DescribeDcdnDomainOriginBpsDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainOriginBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainOriginBpsDataResponse describeDcdnDomainOriginBpsDataResponse = new DescribeDcdnDomainOriginBpsDataResponse();

			describeDcdnDomainOriginBpsDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainOriginBpsDataResponse.RequestId = context.StringValue("DescribeDcdnDomainOriginBpsData.RequestId");
			describeDcdnDomainOriginBpsDataResponse.DomainName = context.StringValue("DescribeDcdnDomainOriginBpsData.DomainName");
			describeDcdnDomainOriginBpsDataResponse.StartTime = context.StringValue("DescribeDcdnDomainOriginBpsData.StartTime");
			describeDcdnDomainOriginBpsDataResponse.EndTime = context.StringValue("DescribeDcdnDomainOriginBpsData.EndTime");
			describeDcdnDomainOriginBpsDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainOriginBpsData.DataInterval");

			List<DescribeDcdnDomainOriginBpsDataResponse.DescribeDcdnDomainOriginBpsData_DataModule> describeDcdnDomainOriginBpsDataResponse_originBpsDataPerInterval = new List<DescribeDcdnDomainOriginBpsDataResponse.DescribeDcdnDomainOriginBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainOriginBpsData.OriginBpsDataPerInterval.Length"); i++) {
				DescribeDcdnDomainOriginBpsDataResponse.DescribeDcdnDomainOriginBpsData_DataModule dataModule = new DescribeDcdnDomainOriginBpsDataResponse.DescribeDcdnDomainOriginBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDcdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.OriginBps = context.FloatValue("DescribeDcdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].OriginBps");
				dataModule.DynamicHttpOriginBps = context.FloatValue("DescribeDcdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].DynamicHttpOriginBps");
				dataModule.DynamicHttpsOriginBps = context.FloatValue("DescribeDcdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].DynamicHttpsOriginBps");
				dataModule.StaticHttpOriginBps = context.FloatValue("DescribeDcdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].StaticHttpOriginBps");
				dataModule.StaticHttpsOriginBps = context.FloatValue("DescribeDcdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].StaticHttpsOriginBps");

				describeDcdnDomainOriginBpsDataResponse_originBpsDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainOriginBpsDataResponse.OriginBpsDataPerInterval = describeDcdnDomainOriginBpsDataResponse_originBpsDataPerInterval;
        
			return describeDcdnDomainOriginBpsDataResponse;
        }
    }
}
