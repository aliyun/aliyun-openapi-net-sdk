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
    public class DescribeScdnDomainUvDataResponseUnmarshaller
    {
        public static DescribeScdnDomainUvDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainUvDataResponse describeScdnDomainUvDataResponse = new DescribeScdnDomainUvDataResponse();

			describeScdnDomainUvDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainUvDataResponse.RequestId = context.StringValue("DescribeScdnDomainUvData.RequestId");
			describeScdnDomainUvDataResponse.DomainName = context.StringValue("DescribeScdnDomainUvData.DomainName");
			describeScdnDomainUvDataResponse.StartTime = context.StringValue("DescribeScdnDomainUvData.StartTime");

			List<DescribeScdnDomainUvDataResponse.DescribeScdnDomainUvData_UsageData> describeScdnDomainUvDataResponse_uvDataInterval = new List<DescribeScdnDomainUvDataResponse.DescribeScdnDomainUvData_UsageData>();
			for (int i = 0; i < context.Length("DescribeScdnDomainUvData.UvDataInterval.Length"); i++) {
				DescribeScdnDomainUvDataResponse.DescribeScdnDomainUvData_UsageData usageData = new DescribeScdnDomainUvDataResponse.DescribeScdnDomainUvData_UsageData();
				usageData._Value = context.StringValue("DescribeScdnDomainUvData.UvDataInterval["+ i +"].Value");
				usageData.TimeStamp = context.StringValue("DescribeScdnDomainUvData.UvDataInterval["+ i +"].TimeStamp");

				describeScdnDomainUvDataResponse_uvDataInterval.Add(usageData);
			}
			describeScdnDomainUvDataResponse.UvDataInterval = describeScdnDomainUvDataResponse_uvDataInterval;
        
			return describeScdnDomainUvDataResponse;
        }
    }
}
