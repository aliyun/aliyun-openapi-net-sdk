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
    public class DescribeDcdnDomainWebsocketBpsDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainWebsocketBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainWebsocketBpsDataResponse describeDcdnDomainWebsocketBpsDataResponse = new DescribeDcdnDomainWebsocketBpsDataResponse();

			describeDcdnDomainWebsocketBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainWebsocketBpsDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainWebsocketBpsData.RequestId");
			describeDcdnDomainWebsocketBpsDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainWebsocketBpsData.DomainName");
			describeDcdnDomainWebsocketBpsDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainWebsocketBpsData.StartTime");
			describeDcdnDomainWebsocketBpsDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainWebsocketBpsData.EndTime");
			describeDcdnDomainWebsocketBpsDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainWebsocketBpsData.DataInterval");

			List<DescribeDcdnDomainWebsocketBpsDataResponse.DescribeDcdnDomainWebsocketBpsData_DataModule> describeDcdnDomainWebsocketBpsDataResponse_bpsDataPerInterval = new List<DescribeDcdnDomainWebsocketBpsDataResponse.DescribeDcdnDomainWebsocketBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainWebsocketBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeDcdnDomainWebsocketBpsDataResponse.DescribeDcdnDomainWebsocketBpsData_DataModule dataModule = new DescribeDcdnDomainWebsocketBpsDataResponse.DescribeDcdnDomainWebsocketBpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDcdnDomainWebsocketBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.WebsocketBps = _ctx.FloatValue("DescribeDcdnDomainWebsocketBpsData.BpsDataPerInterval["+ i +"].WebsocketBps");

				describeDcdnDomainWebsocketBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainWebsocketBpsDataResponse.BpsDataPerInterval = describeDcdnDomainWebsocketBpsDataResponse_bpsDataPerInterval;
        
			return describeDcdnDomainWebsocketBpsDataResponse;
        }
    }
}
