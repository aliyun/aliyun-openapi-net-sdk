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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainRealTimeDataResponseUnmarshaller
    {
        public static DescribeDomainRealTimeDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainRealTimeDataResponse describeDomainRealTimeDataResponse = new DescribeDomainRealTimeDataResponse();

			describeDomainRealTimeDataResponse.HttpResponse = context.HttpResponse;
			describeDomainRealTimeDataResponse.RequestId = context.StringValue("DescribeDomainRealTimeData.RequestId");
			describeDomainRealTimeDataResponse.DomainName = context.StringValue("DescribeDomainRealTimeData.DomainName");
			describeDomainRealTimeDataResponse.Field = context.StringValue("DescribeDomainRealTimeData.Field");
			describeDomainRealTimeDataResponse.StartTime = context.StringValue("DescribeDomainRealTimeData.StartTime");
			describeDomainRealTimeDataResponse.EndTime = context.StringValue("DescribeDomainRealTimeData.EndTime");

			List<DescribeDomainRealTimeDataResponse.DescribeDomainRealTimeData_DataModule> describeDomainRealTimeDataResponse_dataPerInterval = new List<DescribeDomainRealTimeDataResponse.DescribeDomainRealTimeData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainRealTimeData.DataPerInterval.Length"); i++) {
				DescribeDomainRealTimeDataResponse.DescribeDomainRealTimeData_DataModule dataModule = new DescribeDomainRealTimeDataResponse.DescribeDomainRealTimeData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainRealTimeData.DataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainRealTimeData.DataPerInterval["+ i +"].Value");

				describeDomainRealTimeDataResponse_dataPerInterval.Add(dataModule);
			}
			describeDomainRealTimeDataResponse.DataPerInterval = describeDomainRealTimeDataResponse_dataPerInterval;
        
			return describeDomainRealTimeDataResponse;
        }
    }
}