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
    public class DescribeScdnDomainHitRateDataResponseUnmarshaller
    {
        public static DescribeScdnDomainHitRateDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainHitRateDataResponse describeScdnDomainHitRateDataResponse = new DescribeScdnDomainHitRateDataResponse();

			describeScdnDomainHitRateDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainHitRateDataResponse.RequestId = context.StringValue("DescribeScdnDomainHitRateData.RequestId");
			describeScdnDomainHitRateDataResponse.DomainName = context.StringValue("DescribeScdnDomainHitRateData.DomainName");
			describeScdnDomainHitRateDataResponse.StartTime = context.StringValue("DescribeScdnDomainHitRateData.StartTime");
			describeScdnDomainHitRateDataResponse.EndTime = context.StringValue("DescribeScdnDomainHitRateData.EndTime");
			describeScdnDomainHitRateDataResponse.DataInterval = context.StringValue("DescribeScdnDomainHitRateData.DataInterval");

			List<DescribeScdnDomainHitRateDataResponse.DescribeScdnDomainHitRateData_DataModule> describeScdnDomainHitRateDataResponse_hitRatePerInterval = new List<DescribeScdnDomainHitRateDataResponse.DescribeScdnDomainHitRateData_DataModule>();
			for (int i = 0; i < context.Length("DescribeScdnDomainHitRateData.HitRatePerInterval.Length"); i++) {
				DescribeScdnDomainHitRateDataResponse.DescribeScdnDomainHitRateData_DataModule dataModule = new DescribeScdnDomainHitRateDataResponse.DescribeScdnDomainHitRateData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeScdnDomainHitRateData.HitRatePerInterval["+ i +"].TimeStamp");
				dataModule.ReqHitRate = context.StringValue("DescribeScdnDomainHitRateData.HitRatePerInterval["+ i +"].ReqHitRate");
				dataModule.ByteHitRate = context.StringValue("DescribeScdnDomainHitRateData.HitRatePerInterval["+ i +"].ByteHitRate");

				describeScdnDomainHitRateDataResponse_hitRatePerInterval.Add(dataModule);
			}
			describeScdnDomainHitRateDataResponse.HitRatePerInterval = describeScdnDomainHitRateDataResponse_hitRatePerInterval;
        
			return describeScdnDomainHitRateDataResponse;
        }
    }
}
