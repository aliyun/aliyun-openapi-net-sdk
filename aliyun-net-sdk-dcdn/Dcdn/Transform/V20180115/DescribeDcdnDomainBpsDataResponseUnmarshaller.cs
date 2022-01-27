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
        public static DescribeDcdnDomainBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainBpsDataResponse describeDcdnDomainBpsDataResponse = new DescribeDcdnDomainBpsDataResponse();

			describeDcdnDomainBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainBpsDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainBpsData.RequestId");
			describeDcdnDomainBpsDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainBpsData.DomainName");
			describeDcdnDomainBpsDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainBpsData.StartTime");
			describeDcdnDomainBpsDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainBpsData.EndTime");
			describeDcdnDomainBpsDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainBpsData.DataInterval");

			List<DescribeDcdnDomainBpsDataResponse.DescribeDcdnDomainBpsData_DataModule> describeDcdnDomainBpsDataResponse_bpsDataPerInterval = new List<DescribeDcdnDomainBpsDataResponse.DescribeDcdnDomainBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeDcdnDomainBpsDataResponse.DescribeDcdnDomainBpsData_DataModule dataModule = new DescribeDcdnDomainBpsDataResponse.DescribeDcdnDomainBpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDcdnDomainBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.Bps = _ctx.FloatValue("DescribeDcdnDomainBpsData.BpsDataPerInterval["+ i +"].Bps");
				dataModule.DynamicHttpBps = _ctx.FloatValue("DescribeDcdnDomainBpsData.BpsDataPerInterval["+ i +"].DynamicHttpBps");
				dataModule.DynamicHttpsBps = _ctx.FloatValue("DescribeDcdnDomainBpsData.BpsDataPerInterval["+ i +"].DynamicHttpsBps");
				dataModule.StaticHttpBps = _ctx.FloatValue("DescribeDcdnDomainBpsData.BpsDataPerInterval["+ i +"].StaticHttpBps");
				dataModule.StaticHttpsBps = _ctx.FloatValue("DescribeDcdnDomainBpsData.BpsDataPerInterval["+ i +"].StaticHttpsBps");

				describeDcdnDomainBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainBpsDataResponse.BpsDataPerInterval = describeDcdnDomainBpsDataResponse_bpsDataPerInterval;
        
			return describeDcdnDomainBpsDataResponse;
        }
    }
}
