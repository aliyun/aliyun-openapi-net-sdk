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
    public class DescribeDomainAverageResponseTimeResponseUnmarshaller
    {
        public static DescribeDomainAverageResponseTimeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainAverageResponseTimeResponse describeDomainAverageResponseTimeResponse = new DescribeDomainAverageResponseTimeResponse();

			describeDomainAverageResponseTimeResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainAverageResponseTimeResponse.RequestId = _ctx.StringValue("DescribeDomainAverageResponseTime.RequestId");
			describeDomainAverageResponseTimeResponse.DomainName = _ctx.StringValue("DescribeDomainAverageResponseTime.DomainName");
			describeDomainAverageResponseTimeResponse.StartTime = _ctx.StringValue("DescribeDomainAverageResponseTime.StartTime");
			describeDomainAverageResponseTimeResponse.EndTime = _ctx.StringValue("DescribeDomainAverageResponseTime.EndTime");
			describeDomainAverageResponseTimeResponse.DataInterval = _ctx.StringValue("DescribeDomainAverageResponseTime.DataInterval");

			List<DescribeDomainAverageResponseTimeResponse.DescribeDomainAverageResponseTime_DataModule> describeDomainAverageResponseTimeResponse_avgRTPerInterval = new List<DescribeDomainAverageResponseTimeResponse.DescribeDomainAverageResponseTime_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainAverageResponseTime.AvgRTPerInterval.Length"); i++) {
				DescribeDomainAverageResponseTimeResponse.DescribeDomainAverageResponseTime_DataModule dataModule = new DescribeDomainAverageResponseTimeResponse.DescribeDomainAverageResponseTime_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDomainAverageResponseTime.AvgRTPerInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeDomainAverageResponseTime.AvgRTPerInterval["+ i +"].Value");

				describeDomainAverageResponseTimeResponse_avgRTPerInterval.Add(dataModule);
			}
			describeDomainAverageResponseTimeResponse.AvgRTPerInterval = describeDomainAverageResponseTimeResponse_avgRTPerInterval;
        
			return describeDomainAverageResponseTimeResponse;
        }
    }
}
