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
    public class DescribeDcdnDomainPvDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainPvDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainPvDataResponse describeDcdnDomainPvDataResponse = new DescribeDcdnDomainPvDataResponse();

			describeDcdnDomainPvDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainPvDataResponse.RequestId = context.StringValue("DescribeDcdnDomainPvData.RequestId");
			describeDcdnDomainPvDataResponse.DomainName = context.StringValue("DescribeDcdnDomainPvData.DomainName");
			describeDcdnDomainPvDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainPvData.DataInterval");
			describeDcdnDomainPvDataResponse.StartTime = context.StringValue("DescribeDcdnDomainPvData.StartTime");
			describeDcdnDomainPvDataResponse.EndTime = context.StringValue("DescribeDcdnDomainPvData.EndTime");

			List<DescribeDcdnDomainPvDataResponse.DescribeDcdnDomainPvData_UsageData> describeDcdnDomainPvDataResponse_pvDataInterval = new List<DescribeDcdnDomainPvDataResponse.DescribeDcdnDomainPvData_UsageData>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainPvData.PvDataInterval.Length"); i++) {
				DescribeDcdnDomainPvDataResponse.DescribeDcdnDomainPvData_UsageData usageData = new DescribeDcdnDomainPvDataResponse.DescribeDcdnDomainPvData_UsageData();
				usageData.TimeStamp = context.StringValue("DescribeDcdnDomainPvData.PvDataInterval["+ i +"].TimeStamp");
				usageData._Value = context.StringValue("DescribeDcdnDomainPvData.PvDataInterval["+ i +"].Value");

				describeDcdnDomainPvDataResponse_pvDataInterval.Add(usageData);
			}
			describeDcdnDomainPvDataResponse.PvDataInterval = describeDcdnDomainPvDataResponse_pvDataInterval;
        
			return describeDcdnDomainPvDataResponse;
        }
    }
}
