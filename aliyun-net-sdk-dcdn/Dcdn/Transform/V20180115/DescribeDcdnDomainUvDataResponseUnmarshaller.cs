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
        public static DescribeDcdnDomainUvDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainUvDataResponse describeDcdnDomainUvDataResponse = new DescribeDcdnDomainUvDataResponse();

			describeDcdnDomainUvDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainUvDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainUvData.RequestId");
			describeDcdnDomainUvDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainUvData.DomainName");
			describeDcdnDomainUvDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainUvData.StartTime");
			describeDcdnDomainUvDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainUvData.EndTime");
			describeDcdnDomainUvDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainUvData.DataInterval");

			List<DescribeDcdnDomainUvDataResponse.DescribeDcdnDomainUvData_UsageData> describeDcdnDomainUvDataResponse_uvDataInterval = new List<DescribeDcdnDomainUvDataResponse.DescribeDcdnDomainUvData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainUvData.UvDataInterval.Length"); i++) {
				DescribeDcdnDomainUvDataResponse.DescribeDcdnDomainUvData_UsageData usageData = new DescribeDcdnDomainUvDataResponse.DescribeDcdnDomainUvData_UsageData();
				usageData._Value = _ctx.StringValue("DescribeDcdnDomainUvData.UvDataInterval["+ i +"].Value");
				usageData.TimeStamp = _ctx.StringValue("DescribeDcdnDomainUvData.UvDataInterval["+ i +"].TimeStamp");

				describeDcdnDomainUvDataResponse_uvDataInterval.Add(usageData);
			}
			describeDcdnDomainUvDataResponse.UvDataInterval = describeDcdnDomainUvDataResponse_uvDataInterval;
        
			return describeDcdnDomainUvDataResponse;
        }
    }
}
