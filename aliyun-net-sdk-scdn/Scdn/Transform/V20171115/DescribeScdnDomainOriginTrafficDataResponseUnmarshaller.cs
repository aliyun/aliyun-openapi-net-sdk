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
    public class DescribeScdnDomainOriginTrafficDataResponseUnmarshaller
    {
        public static DescribeScdnDomainOriginTrafficDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnDomainOriginTrafficDataResponse describeScdnDomainOriginTrafficDataResponse = new DescribeScdnDomainOriginTrafficDataResponse();

			describeScdnDomainOriginTrafficDataResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnDomainOriginTrafficDataResponse.RequestId = _ctx.StringValue("DescribeScdnDomainOriginTrafficData.RequestId");
			describeScdnDomainOriginTrafficDataResponse.DomainName = _ctx.StringValue("DescribeScdnDomainOriginTrafficData.DomainName");
			describeScdnDomainOriginTrafficDataResponse.StartTime = _ctx.StringValue("DescribeScdnDomainOriginTrafficData.StartTime");
			describeScdnDomainOriginTrafficDataResponse.EndTime = _ctx.StringValue("DescribeScdnDomainOriginTrafficData.EndTime");
			describeScdnDomainOriginTrafficDataResponse.DataInterval = _ctx.StringValue("DescribeScdnDomainOriginTrafficData.DataInterval");

			List<DescribeScdnDomainOriginTrafficDataResponse.DescribeScdnDomainOriginTrafficData_DataModule> describeScdnDomainOriginTrafficDataResponse_originTrafficDataPerInterval = new List<DescribeScdnDomainOriginTrafficDataResponse.DescribeScdnDomainOriginTrafficData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDomainOriginTrafficData.OriginTrafficDataPerInterval.Length"); i++) {
				DescribeScdnDomainOriginTrafficDataResponse.DescribeScdnDomainOriginTrafficData_DataModule dataModule = new DescribeScdnDomainOriginTrafficDataResponse.DescribeScdnDomainOriginTrafficData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeScdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.TrafficValue = _ctx.StringValue("DescribeScdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].TrafficValue");
				dataModule.HttpTrafficValue = _ctx.StringValue("DescribeScdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].HttpTrafficValue");
				dataModule.HttpsTrafficValue = _ctx.StringValue("DescribeScdnDomainOriginTrafficData.OriginTrafficDataPerInterval["+ i +"].HttpsTrafficValue");

				describeScdnDomainOriginTrafficDataResponse_originTrafficDataPerInterval.Add(dataModule);
			}
			describeScdnDomainOriginTrafficDataResponse.OriginTrafficDataPerInterval = describeScdnDomainOriginTrafficDataResponse_originTrafficDataPerInterval;
        
			return describeScdnDomainOriginTrafficDataResponse;
        }
    }
}
