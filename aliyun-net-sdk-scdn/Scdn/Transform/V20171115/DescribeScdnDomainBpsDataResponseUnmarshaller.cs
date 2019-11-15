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
    public class DescribeScdnDomainBpsDataResponseUnmarshaller
    {
        public static DescribeScdnDomainBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainBpsDataResponse describeScdnDomainBpsDataResponse = new DescribeScdnDomainBpsDataResponse();

			describeScdnDomainBpsDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainBpsDataResponse.RequestId = context.StringValue("DescribeScdnDomainBpsData.RequestId");
			describeScdnDomainBpsDataResponse.DomainName = context.StringValue("DescribeScdnDomainBpsData.DomainName");
			describeScdnDomainBpsDataResponse.StartTime = context.StringValue("DescribeScdnDomainBpsData.StartTime");
			describeScdnDomainBpsDataResponse.EndTime = context.StringValue("DescribeScdnDomainBpsData.EndTime");
			describeScdnDomainBpsDataResponse.DataInterval = context.StringValue("DescribeScdnDomainBpsData.DataInterval");

			List<DescribeScdnDomainBpsDataResponse.DescribeScdnDomainBpsData_DataModule> describeScdnDomainBpsDataResponse_bpsDataPerInterval = new List<DescribeScdnDomainBpsDataResponse.DescribeScdnDomainBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeScdnDomainBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeScdnDomainBpsDataResponse.DescribeScdnDomainBpsData_DataModule dataModule = new DescribeScdnDomainBpsDataResponse.DescribeScdnDomainBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeScdnDomainBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.BpsValue = context.StringValue("DescribeScdnDomainBpsData.BpsDataPerInterval["+ i +"].BpsValue");
				dataModule.HttpBpsValue = context.StringValue("DescribeScdnDomainBpsData.BpsDataPerInterval["+ i +"].HttpBpsValue");
				dataModule.HttpsBpsValue = context.StringValue("DescribeScdnDomainBpsData.BpsDataPerInterval["+ i +"].HttpsBpsValue");

				describeScdnDomainBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeScdnDomainBpsDataResponse.BpsDataPerInterval = describeScdnDomainBpsDataResponse_bpsDataPerInterval;
        
			return describeScdnDomainBpsDataResponse;
        }
    }
}
