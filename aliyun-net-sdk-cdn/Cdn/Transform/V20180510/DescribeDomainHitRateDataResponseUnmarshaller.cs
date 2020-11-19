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
    public class DescribeDomainHitRateDataResponseUnmarshaller
    {
        public static DescribeDomainHitRateDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainHitRateDataResponse describeDomainHitRateDataResponse = new DescribeDomainHitRateDataResponse();

			describeDomainHitRateDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainHitRateDataResponse.RequestId = _ctx.StringValue("DescribeDomainHitRateData.RequestId");
			describeDomainHitRateDataResponse.DomainName = _ctx.StringValue("DescribeDomainHitRateData.DomainName");
			describeDomainHitRateDataResponse.StartTime = _ctx.StringValue("DescribeDomainHitRateData.StartTime");
			describeDomainHitRateDataResponse.EndTime = _ctx.StringValue("DescribeDomainHitRateData.EndTime");
			describeDomainHitRateDataResponse.DataInterval = _ctx.StringValue("DescribeDomainHitRateData.DataInterval");

			List<DescribeDomainHitRateDataResponse.DescribeDomainHitRateData_DataModule> describeDomainHitRateDataResponse_hitRateInterval = new List<DescribeDomainHitRateDataResponse.DescribeDomainHitRateData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainHitRateData.HitRateInterval.Length"); i++) {
				DescribeDomainHitRateDataResponse.DescribeDomainHitRateData_DataModule dataModule = new DescribeDomainHitRateDataResponse.DescribeDomainHitRateData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDomainHitRateData.HitRateInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeDomainHitRateData.HitRateInterval["+ i +"].Value");
				dataModule.HttpsValue = _ctx.StringValue("DescribeDomainHitRateData.HitRateInterval["+ i +"].HttpsValue");

				describeDomainHitRateDataResponse_hitRateInterval.Add(dataModule);
			}
			describeDomainHitRateDataResponse.HitRateInterval = describeDomainHitRateDataResponse_hitRateInterval;
        
			return describeDomainHitRateDataResponse;
        }
    }
}
