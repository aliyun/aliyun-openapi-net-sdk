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
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainUvDataResponseUnmarshaller
    {
        public static DescribeDomainUvDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainUvDataResponse describeDomainUvDataResponse = new DescribeDomainUvDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainUvData.RequestId"),
                DomainName = context.StringValue("DescribeDomainUvData.DomainName"),
                DataInterval = context.StringValue("DescribeDomainUvData.DataInterval"),
                StartTime = context.StringValue("DescribeDomainUvData.StartTime"),
                EndTime = context.StringValue("DescribeDomainUvData.EndTime")
            };
            List<DescribeDomainUvDataResponse.UsageData> uvDataInterval = new List<DescribeDomainUvDataResponse.UsageData>();
			for (int i = 0; i < context.Length("DescribeDomainUvData.UvDataInterval.Length"); i++) {
                DescribeDomainUvDataResponse.UsageData usageData = new DescribeDomainUvDataResponse.UsageData()
                {
                    TimeStamp = context.StringValue($"DescribeDomainUvData.UvDataInterval[{i}].TimeStamp"),
                    Value = context.StringValue($"DescribeDomainUvData.UvDataInterval[{i}].Value")
                };
                uvDataInterval.Add(usageData);
			}
			describeDomainUvDataResponse.UvDataInterval = uvDataInterval;
        
			return describeDomainUvDataResponse;
        }
    }
}