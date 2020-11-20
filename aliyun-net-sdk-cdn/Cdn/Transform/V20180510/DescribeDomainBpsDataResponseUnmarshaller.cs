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
    public class DescribeDomainBpsDataResponseUnmarshaller
    {
        public static DescribeDomainBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainBpsDataResponse describeDomainBpsDataResponse = new DescribeDomainBpsDataResponse();

			describeDomainBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainBpsDataResponse.RequestId = _ctx.StringValue("DescribeDomainBpsData.RequestId");
			describeDomainBpsDataResponse.DomainName = _ctx.StringValue("DescribeDomainBpsData.DomainName");
			describeDomainBpsDataResponse.StartTime = _ctx.StringValue("DescribeDomainBpsData.StartTime");
			describeDomainBpsDataResponse.EndTime = _ctx.StringValue("DescribeDomainBpsData.EndTime");
			describeDomainBpsDataResponse.LocationNameEn = _ctx.StringValue("DescribeDomainBpsData.LocationNameEn");
			describeDomainBpsDataResponse.IspNameEn = _ctx.StringValue("DescribeDomainBpsData.IspNameEn");
			describeDomainBpsDataResponse.DataInterval = _ctx.StringValue("DescribeDomainBpsData.DataInterval");

			List<DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule> describeDomainBpsDataResponse_bpsDataPerInterval = new List<DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule dataModule = new DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].Value");
				dataModule.DomesticValue = _ctx.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].DomesticValue");
				dataModule.OverseasValue = _ctx.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].OverseasValue");
				dataModule.HttpsValue = _ctx.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].HttpsValue");
				dataModule.HttpsDomesticValue = _ctx.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].HttpsDomesticValue");
				dataModule.HttpsOverseasValue = _ctx.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].HttpsOverseasValue");

				describeDomainBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeDomainBpsDataResponse.BpsDataPerInterval = describeDomainBpsDataResponse_bpsDataPerInterval;
        
			return describeDomainBpsDataResponse;
        }
    }
}
