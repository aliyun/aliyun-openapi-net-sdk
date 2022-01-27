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
    public class DescribeDcdnDomainHitRateDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainHitRateDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainHitRateDataResponse describeDcdnDomainHitRateDataResponse = new DescribeDcdnDomainHitRateDataResponse();

			describeDcdnDomainHitRateDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainHitRateDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainHitRateData.RequestId");
			describeDcdnDomainHitRateDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainHitRateData.DomainName");
			describeDcdnDomainHitRateDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainHitRateData.StartTime");
			describeDcdnDomainHitRateDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainHitRateData.EndTime");
			describeDcdnDomainHitRateDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainHitRateData.DataInterval");

			List<DescribeDcdnDomainHitRateDataResponse.DescribeDcdnDomainHitRateData_DataModule> describeDcdnDomainHitRateDataResponse_hitRatePerInterval = new List<DescribeDcdnDomainHitRateDataResponse.DescribeDcdnDomainHitRateData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainHitRateData.HitRatePerInterval.Length"); i++) {
				DescribeDcdnDomainHitRateDataResponse.DescribeDcdnDomainHitRateData_DataModule dataModule = new DescribeDcdnDomainHitRateDataResponse.DescribeDcdnDomainHitRateData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDcdnDomainHitRateData.HitRatePerInterval["+ i +"].TimeStamp");
				dataModule.ReqHitRate = _ctx.FloatValue("DescribeDcdnDomainHitRateData.HitRatePerInterval["+ i +"].ReqHitRate");
				dataModule.ByteHitRate = _ctx.FloatValue("DescribeDcdnDomainHitRateData.HitRatePerInterval["+ i +"].ByteHitRate");

				describeDcdnDomainHitRateDataResponse_hitRatePerInterval.Add(dataModule);
			}
			describeDcdnDomainHitRateDataResponse.HitRatePerInterval = describeDcdnDomainHitRateDataResponse_hitRatePerInterval;
        
			return describeDcdnDomainHitRateDataResponse;
        }
    }
}
