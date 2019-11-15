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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDomainPvDataResponseUnmarshaller
    {
        public static DescribeScdnDomainPvDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainPvDataResponse describeScdnDomainPvDataResponse = new DescribeScdnDomainPvDataResponse();

			describeScdnDomainPvDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainPvDataResponse.RequestId = context.StringValue("DescribeScdnDomainPvData.RequestId");
			describeScdnDomainPvDataResponse.DomainName = context.StringValue("DescribeScdnDomainPvData.DomainName");
			describeScdnDomainPvDataResponse.StartTime = context.StringValue("DescribeScdnDomainPvData.StartTime");

			List<DescribeScdnDomainPvDataResponse.DescribeScdnDomainPvData_UsageData> describeScdnDomainPvDataResponse_pvDataInterval = new List<DescribeScdnDomainPvDataResponse.DescribeScdnDomainPvData_UsageData>();
			for (int i = 0; i < context.Length("DescribeScdnDomainPvData.PvDataInterval.Length"); i++) {
				DescribeScdnDomainPvDataResponse.DescribeScdnDomainPvData_UsageData usageData = new DescribeScdnDomainPvDataResponse.DescribeScdnDomainPvData_UsageData();
				usageData._Value = context.StringValue("DescribeScdnDomainPvData.PvDataInterval["+ i +"].Value");
				usageData.TimeStamp = context.StringValue("DescribeScdnDomainPvData.PvDataInterval["+ i +"].TimeStamp");

				describeScdnDomainPvDataResponse_pvDataInterval.Add(usageData);
			}
			describeScdnDomainPvDataResponse.PvDataInterval = describeScdnDomainPvDataResponse_pvDataInterval;
        
			return describeScdnDomainPvDataResponse;
        }
    }
}
