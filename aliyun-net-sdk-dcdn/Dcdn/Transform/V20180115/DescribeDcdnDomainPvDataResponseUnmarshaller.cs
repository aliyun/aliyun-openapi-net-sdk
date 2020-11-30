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
        public static DescribeDcdnDomainPvDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainPvDataResponse describeDcdnDomainPvDataResponse = new DescribeDcdnDomainPvDataResponse();

			describeDcdnDomainPvDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainPvDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainPvData.RequestId");
			describeDcdnDomainPvDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainPvData.DomainName");
			describeDcdnDomainPvDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainPvData.StartTime");
			describeDcdnDomainPvDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainPvData.EndTime");
			describeDcdnDomainPvDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainPvData.DataInterval");

			List<DescribeDcdnDomainPvDataResponse.DescribeDcdnDomainPvData_UsageData> describeDcdnDomainPvDataResponse_pvDataInterval = new List<DescribeDcdnDomainPvDataResponse.DescribeDcdnDomainPvData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainPvData.PvDataInterval.Length"); i++) {
				DescribeDcdnDomainPvDataResponse.DescribeDcdnDomainPvData_UsageData usageData = new DescribeDcdnDomainPvDataResponse.DescribeDcdnDomainPvData_UsageData();
				usageData._Value = _ctx.StringValue("DescribeDcdnDomainPvData.PvDataInterval["+ i +"].Value");
				usageData.TimeStamp = _ctx.StringValue("DescribeDcdnDomainPvData.PvDataInterval["+ i +"].TimeStamp");

				describeDcdnDomainPvDataResponse_pvDataInterval.Add(usageData);
			}
			describeDcdnDomainPvDataResponse.PvDataInterval = describeDcdnDomainPvDataResponse_pvDataInterval;
        
			return describeDcdnDomainPvDataResponse;
        }
    }
}
