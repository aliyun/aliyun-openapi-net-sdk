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
    public class DescribeTopDomainsByFlowResponseUnmarshaller
    {
        public static DescribeTopDomainsByFlowResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeTopDomainsByFlowResponse describeTopDomainsByFlowResponse = new DescribeTopDomainsByFlowResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeTopDomainsByFlow.RequestId"),
                StartTime = context.StringValue("DescribeTopDomainsByFlow.StartTime"),
                EndTime = context.StringValue("DescribeTopDomainsByFlow.EndTime"),
                DomainCount = context.LongValue("DescribeTopDomainsByFlow.DomainCount"),
                DomainOnlineCount = context.LongValue("DescribeTopDomainsByFlow.DomainOnlineCount")
            };
            List<DescribeTopDomainsByFlowResponse.TopDomain> topDomains = new List<DescribeTopDomainsByFlowResponse.TopDomain>();
			for (int i = 0; i < context.Length("DescribeTopDomainsByFlow.TopDomains.Length"); i++) {
                DescribeTopDomainsByFlowResponse.TopDomain topDomain = new DescribeTopDomainsByFlowResponse.TopDomain()
                {
                    DomainName = context.StringValue($"DescribeTopDomainsByFlow.TopDomains[{i}].DomainName"),
                    Rank = context.LongValue($"DescribeTopDomainsByFlow.TopDomains[{i}].Rank"),
                    TotalTraffic = context.StringValue($"DescribeTopDomainsByFlow.TopDomains[{i}].TotalTraffic"),
                    TrafficPercent = context.StringValue($"DescribeTopDomainsByFlow.TopDomains[{i}].TrafficPercent"),
                    MaxBps = context.LongValue($"DescribeTopDomainsByFlow.TopDomains[{i}].MaxBps"),
                    MaxBpsTime = context.StringValue($"DescribeTopDomainsByFlow.TopDomains[{i}].MaxBpsTime"),
                    TotalAccess = context.LongValue($"DescribeTopDomainsByFlow.TopDomains[{i}].TotalAccess")
                };
                topDomains.Add(topDomain);
			}
			describeTopDomainsByFlowResponse.TopDomains = topDomains;
        
			return describeTopDomainsByFlowResponse;
        }
    }
}