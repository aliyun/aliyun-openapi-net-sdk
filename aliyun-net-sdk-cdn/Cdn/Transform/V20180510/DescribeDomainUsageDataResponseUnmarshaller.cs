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
    public class DescribeDomainUsageDataResponseUnmarshaller
    {
        public static DescribeDomainUsageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainUsageDataResponse describeDomainUsageDataResponse = new DescribeDomainUsageDataResponse();

			describeDomainUsageDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainUsageDataResponse.RequestId = _ctx.StringValue("DescribeDomainUsageData.RequestId");
			describeDomainUsageDataResponse.DomainName = _ctx.StringValue("DescribeDomainUsageData.DomainName");
			describeDomainUsageDataResponse.StartTime = _ctx.StringValue("DescribeDomainUsageData.StartTime");
			describeDomainUsageDataResponse.EndTime = _ctx.StringValue("DescribeDomainUsageData.EndTime");
			describeDomainUsageDataResponse.Type = _ctx.StringValue("DescribeDomainUsageData.Type");
			describeDomainUsageDataResponse.Area = _ctx.StringValue("DescribeDomainUsageData.Area");
			describeDomainUsageDataResponse.DataInterval = _ctx.StringValue("DescribeDomainUsageData.DataInterval");

			List<DescribeDomainUsageDataResponse.DescribeDomainUsageData_DataModule> describeDomainUsageDataResponse_usageDataPerInterval = new List<DescribeDomainUsageDataResponse.DescribeDomainUsageData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainUsageData.UsageDataPerInterval.Length"); i++) {
				DescribeDomainUsageDataResponse.DescribeDomainUsageData_DataModule dataModule = new DescribeDomainUsageDataResponse.DescribeDomainUsageData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDomainUsageData.UsageDataPerInterval["+ i +"].TimeStamp");
				dataModule.PeakTime = _ctx.StringValue("DescribeDomainUsageData.UsageDataPerInterval["+ i +"].PeakTime");
				dataModule._Value = _ctx.StringValue("DescribeDomainUsageData.UsageDataPerInterval["+ i +"].Value");
				dataModule.SpecialValue = _ctx.StringValue("DescribeDomainUsageData.UsageDataPerInterval["+ i +"].SpecialValue");

				describeDomainUsageDataResponse_usageDataPerInterval.Add(dataModule);
			}
			describeDomainUsageDataResponse.UsageDataPerInterval = describeDomainUsageDataResponse_usageDataPerInterval;
        
			return describeDomainUsageDataResponse;
        }
    }
}
