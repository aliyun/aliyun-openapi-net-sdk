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
    public class DescribeDomainPvDataResponseUnmarshaller
    {
        public static DescribeDomainPvDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainPvDataResponse describeDomainPvDataResponse = new DescribeDomainPvDataResponse();

			describeDomainPvDataResponse.HttpResponse = context.HttpResponse;
			describeDomainPvDataResponse.RequestId = context.StringValue("DescribeDomainPvData.RequestId");
			describeDomainPvDataResponse.DomainName = context.StringValue("DescribeDomainPvData.DomainName");
			describeDomainPvDataResponse.DataInterval = context.StringValue("DescribeDomainPvData.DataInterval");
			describeDomainPvDataResponse.StartTime = context.StringValue("DescribeDomainPvData.StartTime");
			describeDomainPvDataResponse.EndTime = context.StringValue("DescribeDomainPvData.EndTime");

			List<DescribeDomainPvDataResponse.DescribeDomainPvData_UsageData> describeDomainPvDataResponse_pvDataInterval = new List<DescribeDomainPvDataResponse.DescribeDomainPvData_UsageData>();
			for (int i = 0; i < context.Length("DescribeDomainPvData.PvDataInterval.Length"); i++) {
				DescribeDomainPvDataResponse.DescribeDomainPvData_UsageData usageData = new DescribeDomainPvDataResponse.DescribeDomainPvData_UsageData();
				usageData.TimeStamp = context.StringValue("DescribeDomainPvData.PvDataInterval["+ i +"].TimeStamp");
				usageData._Value = context.StringValue("DescribeDomainPvData.PvDataInterval["+ i +"].Value");

				describeDomainPvDataResponse_pvDataInterval.Add(usageData);
			}
			describeDomainPvDataResponse.PvDataInterval = describeDomainPvDataResponse_pvDataInterval;
        
			return describeDomainPvDataResponse;
        }
    }
}