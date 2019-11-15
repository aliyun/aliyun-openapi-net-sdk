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
    public class DescribeDcdnDomainBpsDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainBpsDataResponse describeDcdnDomainBpsDataResponse = new DescribeDcdnDomainBpsDataResponse();

			describeDcdnDomainBpsDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainBpsDataResponse.RequestId = context.StringValue("DescribeDcdnDomainBpsData.RequestId");
			describeDcdnDomainBpsDataResponse.DomainName = context.StringValue("DescribeDcdnDomainBpsData.DomainName");
			describeDcdnDomainBpsDataResponse.StartTime = context.StringValue("DescribeDcdnDomainBpsData.StartTime");
			describeDcdnDomainBpsDataResponse.EndTime = context.StringValue("DescribeDcdnDomainBpsData.EndTime");
			describeDcdnDomainBpsDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainBpsData.DataInterval");

			List<DescribeDcdnDomainBpsDataResponse.DescribeDcdnDomainBpsData_DataModule> describeDcdnDomainBpsDataResponse_bpsDataPerInterval = new List<DescribeDcdnDomainBpsDataResponse.DescribeDcdnDomainBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeDcdnDomainBpsDataResponse.DescribeDcdnDomainBpsData_DataModule dataModule = new DescribeDcdnDomainBpsDataResponse.DescribeDcdnDomainBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDcdnDomainBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.Bps = context.FloatValue("DescribeDcdnDomainBpsData.BpsDataPerInterval["+ i +"].Bps");
				dataModule.DynamicHttpBps = context.FloatValue("DescribeDcdnDomainBpsData.BpsDataPerInterval["+ i +"].DynamicHttpBps");
				dataModule.DynamicHttpsBps = context.FloatValue("DescribeDcdnDomainBpsData.BpsDataPerInterval["+ i +"].DynamicHttpsBps");
				dataModule.StaticHttpBps = context.FloatValue("DescribeDcdnDomainBpsData.BpsDataPerInterval["+ i +"].StaticHttpBps");
				dataModule.StaticHttpsBps = context.FloatValue("DescribeDcdnDomainBpsData.BpsDataPerInterval["+ i +"].StaticHttpsBps");

				describeDcdnDomainBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainBpsDataResponse.BpsDataPerInterval = describeDcdnDomainBpsDataResponse_bpsDataPerInterval;
        
			return describeDcdnDomainBpsDataResponse;
        }
    }
}
