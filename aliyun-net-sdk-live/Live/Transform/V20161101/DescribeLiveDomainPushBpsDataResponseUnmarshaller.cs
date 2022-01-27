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
    public class DescribeLiveDomainPushBpsDataResponseUnmarshaller
    {
        public static DescribeLiveDomainPushBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainPushBpsDataResponse describeLiveDomainPushBpsDataResponse = new DescribeLiveDomainPushBpsDataResponse();

			describeLiveDomainPushBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainPushBpsDataResponse.RequestId = _ctx.StringValue("DescribeLiveDomainPushBpsData.RequestId");
			describeLiveDomainPushBpsDataResponse.DomainName = _ctx.StringValue("DescribeLiveDomainPushBpsData.DomainName");
			describeLiveDomainPushBpsDataResponse.StartTime = _ctx.StringValue("DescribeLiveDomainPushBpsData.StartTime");
			describeLiveDomainPushBpsDataResponse.EndTime = _ctx.StringValue("DescribeLiveDomainPushBpsData.EndTime");
			describeLiveDomainPushBpsDataResponse.DataInterval = _ctx.StringValue("DescribeLiveDomainPushBpsData.DataInterval");

			List<DescribeLiveDomainPushBpsDataResponse.DescribeLiveDomainPushBpsData_DataModule> describeLiveDomainPushBpsDataResponse_bpsDataPerInterval = new List<DescribeLiveDomainPushBpsDataResponse.DescribeLiveDomainPushBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainPushBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeLiveDomainPushBpsDataResponse.DescribeLiveDomainPushBpsData_DataModule dataModule = new DescribeLiveDomainPushBpsDataResponse.DescribeLiveDomainPushBpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeLiveDomainPushBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.BpsValue = _ctx.StringValue("DescribeLiveDomainPushBpsData.BpsDataPerInterval["+ i +"].BpsValue");

				describeLiveDomainPushBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeLiveDomainPushBpsDataResponse.BpsDataPerInterval = describeLiveDomainPushBpsDataResponse_bpsDataPerInterval;
        
			return describeLiveDomainPushBpsDataResponse;
        }
    }
}
