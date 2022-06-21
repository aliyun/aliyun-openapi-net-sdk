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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainBpsDataResponseUnmarshaller
    {
        public static DescribeLiveDomainBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainBpsDataResponse describeLiveDomainBpsDataResponse = new DescribeLiveDomainBpsDataResponse();

			describeLiveDomainBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainBpsDataResponse.RequestId = _ctx.StringValue("DescribeLiveDomainBpsData.RequestId");
			describeLiveDomainBpsDataResponse.DomainName = _ctx.StringValue("DescribeLiveDomainBpsData.DomainName");
			describeLiveDomainBpsDataResponse.StartTime = _ctx.StringValue("DescribeLiveDomainBpsData.StartTime");
			describeLiveDomainBpsDataResponse.EndTime = _ctx.StringValue("DescribeLiveDomainBpsData.EndTime");
			describeLiveDomainBpsDataResponse.DataInterval = _ctx.StringValue("DescribeLiveDomainBpsData.DataInterval");

			List<DescribeLiveDomainBpsDataResponse.DescribeLiveDomainBpsData_DataModule> describeLiveDomainBpsDataResponse_bpsDataPerInterval = new List<DescribeLiveDomainBpsDataResponse.DescribeLiveDomainBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeLiveDomainBpsDataResponse.DescribeLiveDomainBpsData_DataModule dataModule = new DescribeLiveDomainBpsDataResponse.DescribeLiveDomainBpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeLiveDomainBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.BpsValue = _ctx.StringValue("DescribeLiveDomainBpsData.BpsDataPerInterval["+ i +"].BpsValue");
				dataModule.HttpBpsValue = _ctx.StringValue("DescribeLiveDomainBpsData.BpsDataPerInterval["+ i +"].HttpBpsValue");
				dataModule.HttpsBpsValue = _ctx.StringValue("DescribeLiveDomainBpsData.BpsDataPerInterval["+ i +"].HttpsBpsValue");

				describeLiveDomainBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeLiveDomainBpsDataResponse.BpsDataPerInterval = describeLiveDomainBpsDataResponse_bpsDataPerInterval;
        
			return describeLiveDomainBpsDataResponse;
        }
    }
}
