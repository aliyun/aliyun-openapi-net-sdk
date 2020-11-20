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
    public class DescribeDomainUvDataResponseUnmarshaller
    {
        public static DescribeDomainUvDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainUvDataResponse describeDomainUvDataResponse = new DescribeDomainUvDataResponse();

			describeDomainUvDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainUvDataResponse.RequestId = _ctx.StringValue("DescribeDomainUvData.RequestId");
			describeDomainUvDataResponse.DomainName = _ctx.StringValue("DescribeDomainUvData.DomainName");
			describeDomainUvDataResponse.DataInterval = _ctx.StringValue("DescribeDomainUvData.DataInterval");
			describeDomainUvDataResponse.StartTime = _ctx.StringValue("DescribeDomainUvData.StartTime");
			describeDomainUvDataResponse.EndTime = _ctx.StringValue("DescribeDomainUvData.EndTime");

			List<DescribeDomainUvDataResponse.DescribeDomainUvData_UsageData> describeDomainUvDataResponse_uvDataInterval = new List<DescribeDomainUvDataResponse.DescribeDomainUvData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeDomainUvData.UvDataInterval.Length"); i++) {
				DescribeDomainUvDataResponse.DescribeDomainUvData_UsageData usageData = new DescribeDomainUvDataResponse.DescribeDomainUvData_UsageData();
				usageData.TimeStamp = _ctx.StringValue("DescribeDomainUvData.UvDataInterval["+ i +"].TimeStamp");
				usageData._Value = _ctx.StringValue("DescribeDomainUvData.UvDataInterval["+ i +"].Value");

				describeDomainUvDataResponse_uvDataInterval.Add(usageData);
			}
			describeDomainUvDataResponse.UvDataInterval = describeDomainUvDataResponse_uvDataInterval;
        
			return describeDomainUvDataResponse;
        }
    }
}
