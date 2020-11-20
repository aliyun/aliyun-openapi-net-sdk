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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainRealTimeSrcBpsDataResponseUnmarshaller
    {
        public static DescribeDomainRealTimeSrcBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainRealTimeSrcBpsDataResponse describeDomainRealTimeSrcBpsDataResponse = new DescribeDomainRealTimeSrcBpsDataResponse();

			describeDomainRealTimeSrcBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainRealTimeSrcBpsDataResponse.RequestId = _ctx.StringValue("DescribeDomainRealTimeSrcBpsData.RequestId");
			describeDomainRealTimeSrcBpsDataResponse.DomainName = _ctx.StringValue("DescribeDomainRealTimeSrcBpsData.DomainName");
			describeDomainRealTimeSrcBpsDataResponse.StartTime = _ctx.StringValue("DescribeDomainRealTimeSrcBpsData.StartTime");
			describeDomainRealTimeSrcBpsDataResponse.EndTime = _ctx.StringValue("DescribeDomainRealTimeSrcBpsData.EndTime");
			describeDomainRealTimeSrcBpsDataResponse.DataInterval = _ctx.StringValue("DescribeDomainRealTimeSrcBpsData.DataInterval");

			List<DescribeDomainRealTimeSrcBpsDataResponse.DescribeDomainRealTimeSrcBpsData_DataModule> describeDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval = new List<DescribeDomainRealTimeSrcBpsDataResponse.DescribeDomainRealTimeSrcBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval.Length"); i++) {
				DescribeDomainRealTimeSrcBpsDataResponse.DescribeDomainRealTimeSrcBpsData_DataModule dataModule = new DescribeDomainRealTimeSrcBpsDataResponse.DescribeDomainRealTimeSrcBpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval["+ i +"].Value");

				describeDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval.Add(dataModule);
			}
			describeDomainRealTimeSrcBpsDataResponse.RealTimeSrcBpsDataPerInterval = describeDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval;
        
			return describeDomainRealTimeSrcBpsDataResponse;
        }
    }
}
