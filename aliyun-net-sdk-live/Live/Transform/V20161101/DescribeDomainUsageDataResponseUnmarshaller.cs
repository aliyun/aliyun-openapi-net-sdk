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
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeDomainUsageDataResponseUnmarshaller
    {
        public static DescribeDomainUsageDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainUsageDataResponse describeDomainUsageDataResponse = new DescribeDomainUsageDataResponse();

			describeDomainUsageDataResponse.HttpResponse = context.HttpResponse;
			describeDomainUsageDataResponse.RequestId = context.StringValue("DescribeDomainUsageData.RequestId");
			describeDomainUsageDataResponse.DomainName = context.StringValue("DescribeDomainUsageData.DomainName");
			describeDomainUsageDataResponse.StartTime = context.StringValue("DescribeDomainUsageData.StartTime");
			describeDomainUsageDataResponse.EndTime = context.StringValue("DescribeDomainUsageData.EndTime");
			describeDomainUsageDataResponse.Field = context.StringValue("DescribeDomainUsageData.Field");
			describeDomainUsageDataResponse.Area = context.StringValue("DescribeDomainUsageData.Area");
			describeDomainUsageDataResponse.DataInterval = context.StringValue("DescribeDomainUsageData.DataInterval");

			List<DescribeDomainUsageDataResponse.DescribeDomainUsageData_DataModule> describeDomainUsageDataResponse_usageDataPerInterval = new List<DescribeDomainUsageDataResponse.DescribeDomainUsageData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainUsageData.UsageDataPerInterval.Length"); i++) {
				DescribeDomainUsageDataResponse.DescribeDomainUsageData_DataModule dataModule = new DescribeDomainUsageDataResponse.DescribeDomainUsageData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainUsageData.UsageDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainUsageData.UsageDataPerInterval["+ i +"].Value");

				describeDomainUsageDataResponse_usageDataPerInterval.Add(dataModule);
			}
			describeDomainUsageDataResponse.UsageDataPerInterval = describeDomainUsageDataResponse_usageDataPerInterval;
        
			return describeDomainUsageDataResponse;
        }
    }
}