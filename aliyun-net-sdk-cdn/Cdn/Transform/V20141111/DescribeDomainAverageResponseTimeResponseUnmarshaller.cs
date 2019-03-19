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
    public class DescribeDomainAverageResponseTimeResponseUnmarshaller
    {
        public static DescribeDomainAverageResponseTimeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainAverageResponseTimeResponse describeDomainAverageResponseTimeResponse = new DescribeDomainAverageResponseTimeResponse();

			describeDomainAverageResponseTimeResponse.HttpResponse = context.HttpResponse;
			describeDomainAverageResponseTimeResponse.RequestId = context.StringValue("DescribeDomainAverageResponseTime.RequestId");
			describeDomainAverageResponseTimeResponse.DomainName = context.StringValue("DescribeDomainAverageResponseTime.DomainName");
			describeDomainAverageResponseTimeResponse.StartTime = context.StringValue("DescribeDomainAverageResponseTime.StartTime");
			describeDomainAverageResponseTimeResponse.EndTime = context.StringValue("DescribeDomainAverageResponseTime.EndTime");
			describeDomainAverageResponseTimeResponse.LocationNameEn = context.StringValue("DescribeDomainAverageResponseTime.LocationNameEn");
			describeDomainAverageResponseTimeResponse.IspNameEn = context.StringValue("DescribeDomainAverageResponseTime.IspNameEn");
			describeDomainAverageResponseTimeResponse.LocationName = context.StringValue("DescribeDomainAverageResponseTime.LocationName");
			describeDomainAverageResponseTimeResponse.IspName = context.StringValue("DescribeDomainAverageResponseTime.IspName");
			describeDomainAverageResponseTimeResponse.DataInterval = context.StringValue("DescribeDomainAverageResponseTime.DataInterval");

			List<DescribeDomainAverageResponseTimeResponse.DescribeDomainAverageResponseTime_DataModule> describeDomainAverageResponseTimeResponse_avgRTPerInterval = new List<DescribeDomainAverageResponseTimeResponse.DescribeDomainAverageResponseTime_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainAverageResponseTime.AvgRTPerInterval.Length"); i++) {
				DescribeDomainAverageResponseTimeResponse.DescribeDomainAverageResponseTime_DataModule dataModule = new DescribeDomainAverageResponseTimeResponse.DescribeDomainAverageResponseTime_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainAverageResponseTime.AvgRTPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainAverageResponseTime.AvgRTPerInterval["+ i +"].Value");

				describeDomainAverageResponseTimeResponse_avgRTPerInterval.Add(dataModule);
			}
			describeDomainAverageResponseTimeResponse.AvgRTPerInterval = describeDomainAverageResponseTimeResponse_avgRTPerInterval;
        
			return describeDomainAverageResponseTimeResponse;
        }
    }
}
