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
    public class DescribeScdnDomainRealTimeSrcTrafficDataResponseUnmarshaller
    {
        public static DescribeScdnDomainRealTimeSrcTrafficDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnDomainRealTimeSrcTrafficDataResponse describeScdnDomainRealTimeSrcTrafficDataResponse = new DescribeScdnDomainRealTimeSrcTrafficDataResponse();

			describeScdnDomainRealTimeSrcTrafficDataResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnDomainRealTimeSrcTrafficDataResponse.RequestId = _ctx.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.RequestId");
			describeScdnDomainRealTimeSrcTrafficDataResponse.DomainName = _ctx.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.DomainName");
			describeScdnDomainRealTimeSrcTrafficDataResponse.StartTime = _ctx.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.StartTime");
			describeScdnDomainRealTimeSrcTrafficDataResponse.EndTime = _ctx.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.EndTime");
			describeScdnDomainRealTimeSrcTrafficDataResponse.DataInterval = _ctx.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.DataInterval");

			List<DescribeScdnDomainRealTimeSrcTrafficDataResponse.DescribeScdnDomainRealTimeSrcTrafficData_DataModule> describeScdnDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval = new List<DescribeScdnDomainRealTimeSrcTrafficDataResponse.DescribeScdnDomainRealTimeSrcTrafficData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval.Length"); i++) {
				DescribeScdnDomainRealTimeSrcTrafficDataResponse.DescribeScdnDomainRealTimeSrcTrafficData_DataModule dataModule = new DescribeScdnDomainRealTimeSrcTrafficDataResponse.DescribeScdnDomainRealTimeSrcTrafficData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeScdnDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval["+ i +"].Value");

				describeScdnDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval.Add(dataModule);
			}
			describeScdnDomainRealTimeSrcTrafficDataResponse.RealTimeSrcTrafficDataPerInterval = describeScdnDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval;
        
			return describeScdnDomainRealTimeSrcTrafficDataResponse;
        }
    }
}
