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
    public class DescribeDcdnDomainUsageDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainUsageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainUsageDataResponse describeDcdnDomainUsageDataResponse = new DescribeDcdnDomainUsageDataResponse();

			describeDcdnDomainUsageDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainUsageDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainUsageData.RequestId");
			describeDcdnDomainUsageDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainUsageData.DomainName");
			describeDcdnDomainUsageDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainUsageData.StartTime");
			describeDcdnDomainUsageDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainUsageData.EndTime");
			describeDcdnDomainUsageDataResponse.Type = _ctx.StringValue("DescribeDcdnDomainUsageData.Type");
			describeDcdnDomainUsageDataResponse.Area = _ctx.StringValue("DescribeDcdnDomainUsageData.Area");
			describeDcdnDomainUsageDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainUsageData.DataInterval");

			List<DescribeDcdnDomainUsageDataResponse.DescribeDcdnDomainUsageData_DataModule> describeDcdnDomainUsageDataResponse_usageDataPerInterval = new List<DescribeDcdnDomainUsageDataResponse.DescribeDcdnDomainUsageData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainUsageData.UsageDataPerInterval.Length"); i++) {
				DescribeDcdnDomainUsageDataResponse.DescribeDcdnDomainUsageData_DataModule dataModule = new DescribeDcdnDomainUsageDataResponse.DescribeDcdnDomainUsageData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDcdnDomainUsageData.UsageDataPerInterval["+ i +"].TimeStamp");
				dataModule.PeakTime = _ctx.StringValue("DescribeDcdnDomainUsageData.UsageDataPerInterval["+ i +"].PeakTime");
				dataModule._Value = _ctx.StringValue("DescribeDcdnDomainUsageData.UsageDataPerInterval["+ i +"].Value");
				dataModule.SpecialValue = _ctx.StringValue("DescribeDcdnDomainUsageData.UsageDataPerInterval["+ i +"].SpecialValue");

				describeDcdnDomainUsageDataResponse_usageDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainUsageDataResponse.UsageDataPerInterval = describeDcdnDomainUsageDataResponse_usageDataPerInterval;
        
			return describeDcdnDomainUsageDataResponse;
        }
    }
}
