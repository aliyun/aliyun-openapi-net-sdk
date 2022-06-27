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
    public class DescribeLiveDomainRealTimeBpsDataResponseUnmarshaller
    {
        public static DescribeLiveDomainRealTimeBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainRealTimeBpsDataResponse describeLiveDomainRealTimeBpsDataResponse = new DescribeLiveDomainRealTimeBpsDataResponse();

			describeLiveDomainRealTimeBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainRealTimeBpsDataResponse.RequestId = _ctx.StringValue("DescribeLiveDomainRealTimeBpsData.RequestId");
			describeLiveDomainRealTimeBpsDataResponse.DomainName = _ctx.StringValue("DescribeLiveDomainRealTimeBpsData.DomainName");
			describeLiveDomainRealTimeBpsDataResponse.StartTime = _ctx.StringValue("DescribeLiveDomainRealTimeBpsData.StartTime");
			describeLiveDomainRealTimeBpsDataResponse.EndTime = _ctx.StringValue("DescribeLiveDomainRealTimeBpsData.EndTime");
			describeLiveDomainRealTimeBpsDataResponse.DataInterval = _ctx.StringValue("DescribeLiveDomainRealTimeBpsData.DataInterval");

			List<DescribeLiveDomainRealTimeBpsDataResponse.DescribeLiveDomainRealTimeBpsData_DataModule> describeLiveDomainRealTimeBpsDataResponse_realTimeBpsDataPerInterval = new List<DescribeLiveDomainRealTimeBpsDataResponse.DescribeLiveDomainRealTimeBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainRealTimeBpsData.RealTimeBpsDataPerInterval.Length"); i++) {
				DescribeLiveDomainRealTimeBpsDataResponse.DescribeLiveDomainRealTimeBpsData_DataModule dataModule = new DescribeLiveDomainRealTimeBpsDataResponse.DescribeLiveDomainRealTimeBpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeLiveDomainRealTimeBpsData.RealTimeBpsDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeLiveDomainRealTimeBpsData.RealTimeBpsDataPerInterval["+ i +"].Value");

				describeLiveDomainRealTimeBpsDataResponse_realTimeBpsDataPerInterval.Add(dataModule);
			}
			describeLiveDomainRealTimeBpsDataResponse.RealTimeBpsDataPerInterval = describeLiveDomainRealTimeBpsDataResponse_realTimeBpsDataPerInterval;
        
			return describeLiveDomainRealTimeBpsDataResponse;
        }
    }
}
