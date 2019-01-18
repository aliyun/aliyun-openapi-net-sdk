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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainBpsDataResponseUnmarshaller
    {
        public static DescribeLiveDomainBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveDomainBpsDataResponse describeLiveDomainBpsDataResponse = new DescribeLiveDomainBpsDataResponse();

			describeLiveDomainBpsDataResponse.HttpResponse = context.HttpResponse;
			describeLiveDomainBpsDataResponse.RequestId = context.StringValue("DescribeLiveDomainBpsData.RequestId");
			describeLiveDomainBpsDataResponse.DomainName = context.StringValue("DescribeLiveDomainBpsData.DomainName");
			describeLiveDomainBpsDataResponse.StartTime = context.StringValue("DescribeLiveDomainBpsData.StartTime");
			describeLiveDomainBpsDataResponse.EndTime = context.StringValue("DescribeLiveDomainBpsData.EndTime");
			describeLiveDomainBpsDataResponse.DataInterval = context.StringValue("DescribeLiveDomainBpsData.DataInterval");

			List<DescribeLiveDomainBpsDataResponse.DescribeLiveDomainBpsData_DataModule> describeLiveDomainBpsDataResponse_bpsDataPerInterval = new List<DescribeLiveDomainBpsDataResponse.DescribeLiveDomainBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeLiveDomainBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeLiveDomainBpsDataResponse.DescribeLiveDomainBpsData_DataModule dataModule = new DescribeLiveDomainBpsDataResponse.DescribeLiveDomainBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeLiveDomainBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.BpsValue = context.StringValue("DescribeLiveDomainBpsData.BpsDataPerInterval["+ i +"].BpsValue");
				dataModule.HttpBpsValue = context.StringValue("DescribeLiveDomainBpsData.BpsDataPerInterval["+ i +"].HttpBpsValue");
				dataModule.HttpsBpsValue = context.StringValue("DescribeLiveDomainBpsData.BpsDataPerInterval["+ i +"].HttpsBpsValue");

				describeLiveDomainBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeLiveDomainBpsDataResponse.BpsDataPerInterval = describeLiveDomainBpsDataResponse_bpsDataPerInterval;
        
			return describeLiveDomainBpsDataResponse;
        }
    }
}