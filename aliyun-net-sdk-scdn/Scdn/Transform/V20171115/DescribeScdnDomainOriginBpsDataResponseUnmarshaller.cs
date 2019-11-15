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
        public static DescribeScdnDomainOriginBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainOriginBpsDataResponse describeScdnDomainOriginBpsDataResponse = new DescribeScdnDomainOriginBpsDataResponse();

			describeScdnDomainOriginBpsDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainOriginBpsDataResponse.RequestId = context.StringValue("DescribeScdnDomainOriginBpsData.RequestId");
			describeScdnDomainOriginBpsDataResponse.DomainName = context.StringValue("DescribeScdnDomainOriginBpsData.DomainName");
			describeScdnDomainOriginBpsDataResponse.StartTime = context.StringValue("DescribeScdnDomainOriginBpsData.StartTime");
			describeScdnDomainOriginBpsDataResponse.EndTime = context.StringValue("DescribeScdnDomainOriginBpsData.EndTime");
			describeScdnDomainOriginBpsDataResponse.DataInterval = context.StringValue("DescribeScdnDomainOriginBpsData.DataInterval");

			List<DescribeScdnDomainOriginBpsDataResponse.DescribeScdnDomainOriginBpsData_DataModule> describeScdnDomainOriginBpsDataResponse_originBpsDataPerInterval = new List<DescribeScdnDomainOriginBpsDataResponse.DescribeScdnDomainOriginBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeScdnDomainOriginBpsData.OriginBpsDataPerInterval.Length"); i++) {
				DescribeScdnDomainOriginBpsDataResponse.DescribeScdnDomainOriginBpsData_DataModule dataModule = new DescribeScdnDomainOriginBpsDataResponse.DescribeScdnDomainOriginBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeScdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.OriginBpsValue = context.StringValue("DescribeScdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].OriginBpsValue");
				dataModule.HttpOriginBpsValue = context.StringValue("DescribeScdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].HttpOriginBpsValue");
				dataModule.HttpsOriginBpsValue = context.StringValue("DescribeScdnDomainOriginBpsData.OriginBpsDataPerInterval["+ i +"].HttpsOriginBpsValue");

				describeScdnDomainOriginBpsDataResponse_originBpsDataPerInterval.Add(dataModule);
			}
			describeScdnDomainOriginBpsDataResponse.OriginBpsDataPerInterval = describeScdnDomainOriginBpsDataResponse_originBpsDataPerInterval;
        
			return describeScdnDomainOriginBpsDataResponse;
        }
    }
}
