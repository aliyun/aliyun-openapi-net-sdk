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
    public class DescribeScdnDomainOriginBpsDataResponseUnmarshaller
    {
        public static DescribeScdnDomainOriginBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnDomainOriginBpsDataResponse describeScdnDomainOriginBpsDataResponse = new DescribeScdnDomainOriginBpsDataResponse();

			describeScdnDomainOriginBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnDomainOriginBpsDataResponse.RequestId = _ctx.StringValue("DescribeScdnDomainOriginBpsData.RequestId");
			describeScdnDomainOriginBpsDataResponse.DomainName = _ctx.StringValue("DescribeScdnDomainOriginBpsData.DomainName");
			describeScdnDomainOriginBpsDataResponse.StartTime = _ctx.StringValue("DescribeScdnDomainOriginBpsData.StartTime");
			describeScdnDomainOriginBpsDataResponse.EndTime = _ctx.StringValue("DescribeScdnDomainOriginBpsData.EndTime");
			describeScdnDomainOriginBpsDataResponse.DataInterval = _ctx.StringValue("DescribeScdnDomainOriginBpsData.DataInterval");

			List<DescribeScdnDomainOriginBpsDataResponse.DescribeScdnDomainOriginBpsData_DataModule> describeScdnDomainOriginBpsDataResponse_originBpsDataPerInterval = new List<DescribeScdnDomainOriginBpsDataResponse.DescribeScdnDomainOriginBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDomainOriginBpsData.OriginBpsDataPerInterval.Length"); i++) {
				DescribeScdnDomainOriginBpsDataResponse.DescribeScdnDomainOriginBpsData_DataModule dataModule = new DescribeScdnDomainOriginBpsDataResponse.DescribeScdnDomainOriginBpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeScdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.OriginBpsValue = _ctx.StringValue("DescribeScdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].OriginBpsValue");
				dataModule.HttpOriginBpsValue = _ctx.StringValue("DescribeScdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].HttpOriginBpsValue");
				dataModule.HttpsOriginBpsValue = _ctx.StringValue("DescribeScdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].HttpsOriginBpsValue");

				describeScdnDomainOriginBpsDataResponse_originBpsDataPerInterval.Add(dataModule);
			}
			describeScdnDomainOriginBpsDataResponse.OriginBpsDataPerInterval = describeScdnDomainOriginBpsDataResponse_originBpsDataPerInterval;
        
			return describeScdnDomainOriginBpsDataResponse;
        }
    }
}
