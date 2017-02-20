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
    public class DescribeDomainCcDataResponseUnmarshaller
    {
        public static DescribeDomainCcDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainCcDataResponse describeDomainCcDataResponse = new DescribeDomainCcDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainCCData.RequestId"),
                DomainName = context.StringValue("DescribeDomainCCData.DomainName"),
                DataInterval = context.StringValue("DescribeDomainCCData.DataInterval"),
                StartTime = context.StringValue("DescribeDomainCCData.StartTime"),
                EndTime = context.StringValue("DescribeDomainCCData.EndTime")
            };
            List<DescribeDomainCcDataResponse.CcDatas> cCDataList = new List<DescribeDomainCcDataResponse.CcDatas>();
			for (int i = 0; i < context.Length("DescribeDomainCCData.CCDataList.Length"); i++) {
                DescribeDomainCcDataResponse.CcDatas cCDatas = new DescribeDomainCcDataResponse.CcDatas()
                {
                    TimeStamp = context.StringValue($"DescribeDomainCCData.CCDataList[{i}].TimeStamp"),
                    Count = context.StringValue($"DescribeDomainCCData.CCDataList[{i}].Count")
                };
                cCDataList.Add(cCDatas);
			}
			describeDomainCcDataResponse.CcDataList = cCDataList;
        
			return describeDomainCcDataResponse;
        }
    }
}