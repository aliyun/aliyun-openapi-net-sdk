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
    public class DescribeDomainSrcFlowDataResponseUnmarshaller
    {
        public static DescribeDomainSrcFlowDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainSrcFlowDataResponse describeDomainSrcFlowDataResponse = new DescribeDomainSrcFlowDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainSrcFlowData.RequestId"),
                DomainName = context.StringValue("DescribeDomainSrcFlowData.DomainName"),
                DataInterval = context.StringValue("DescribeDomainSrcFlowData.DataInterval"),
                StartTime = context.StringValue("DescribeDomainSrcFlowData.StartTime"),
                EndTime = context.StringValue("DescribeDomainSrcFlowData.EndTime")
            };
            List<DescribeDomainSrcFlowDataResponse.DataModule> srcFlowDataPerInterval = new List<DescribeDomainSrcFlowDataResponse.DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainSrcFlowData.SrcFlowDataPerInterval.Length"); i++) {
                DescribeDomainSrcFlowDataResponse.DataModule dataModule = new DescribeDomainSrcFlowDataResponse.DataModule()
                {
                    TimeStamp = context.StringValue($"DescribeDomainSrcFlowData.SrcFlowDataPerInterval[{i}].TimeStamp"),
                    Value = context.StringValue($"DescribeDomainSrcFlowData.SrcFlowDataPerInterval[{i}].Value")
                };
                srcFlowDataPerInterval.Add(dataModule);
			}
			describeDomainSrcFlowDataResponse.SrcFlowDataPerInterval = srcFlowDataPerInterval;
        
			return describeDomainSrcFlowDataResponse;
        }
    }
}