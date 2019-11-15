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
    public class DescribeDcdnDomainUvDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainUvDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainUvDataResponse describeDcdnDomainUvDataResponse = new DescribeDcdnDomainUvDataResponse();

			describeDcdnDomainUvDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainUvDataResponse.RequestId = context.StringValue("DescribeDcdnDomainUvData.RequestId");
			describeDcdnDomainUvDataResponse.DomainName = context.StringValue("DescribeDcdnDomainUvData.DomainName");
			describeDcdnDomainUvDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainUvData.DataInterval");
			describeDcdnDomainUvDataResponse.StartTime = context.StringValue("DescribeDcdnDomainUvData.StartTime");
			describeDcdnDomainUvDataResponse.EndTime = context.StringValue("DescribeDcdnDomainUvData.EndTime");

			List<DescribeDcdnDomainUvDataResponse.DescribeDcdnDomainUvData_UsageData> describeDcdnDomainUvDataResponse_uvDataInterval = new List<DescribeDcdnDomainUvDataResponse.DescribeDcdnDomainUvData_UsageData>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainUvData.UvDataInterval.Length"); i++) {
				DescribeDcdnDomainUvDataResponse.DescribeDcdnDomainUvData_UsageData usageData = new DescribeDcdnDomainUvDataResponse.DescribeDcdnDomainUvData_UsageData();
				usageData.TimeStamp = context.StringValue("DescribeDcdnDomainUvData.UvDataInterval["+ i +"].TimeStamp");
				usageData._Value = context.StringValue("DescribeDcdnDomainUvData.UvDataInterval["+ i +"].Value");

				describeDcdnDomainUvDataResponse_uvDataInterval.Add(usageData);
			}
			describeDcdnDomainUvDataResponse.UvDataInterval = describeDcdnDomainUvDataResponse_uvDataInterval;
        
			return describeDcdnDomainUvDataResponse;
        }
    }
}
