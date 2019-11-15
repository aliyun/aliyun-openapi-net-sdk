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
    public class DescribeDcdnTopDomainsByFlowResponseUnmarshaller
    {
        public static DescribeDcdnTopDomainsByFlowResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnTopDomainsByFlowResponse describeDcdnTopDomainsByFlowResponse = new DescribeDcdnTopDomainsByFlowResponse();

			describeDcdnTopDomainsByFlowResponse.HttpResponse = context.HttpResponse;
			describeDcdnTopDomainsByFlowResponse.RequestId = context.StringValue("DescribeDcdnTopDomainsByFlow.RequestId");
			describeDcdnTopDomainsByFlowResponse.StartTime = context.StringValue("DescribeDcdnTopDomainsByFlow.StartTime");
			describeDcdnTopDomainsByFlowResponse.EndTime = context.StringValue("DescribeDcdnTopDomainsByFlow.EndTime");
			describeDcdnTopDomainsByFlowResponse.DomainCount = context.LongValue("DescribeDcdnTopDomainsByFlow.DomainCount");
			describeDcdnTopDomainsByFlowResponse.DomainOnlineCount = context.LongValue("DescribeDcdnTopDomainsByFlow.DomainOnlineCount");

			List<DescribeDcdnTopDomainsByFlowResponse.DescribeDcdnTopDomainsByFlow_TopDomain> describeDcdnTopDomainsByFlowResponse_topDomains = new List<DescribeDcdnTopDomainsByFlowResponse.DescribeDcdnTopDomainsByFlow_TopDomain>();
			for (int i = 0; i < context.Length("DescribeDcdnTopDomainsByFlow.TopDomains.Length"); i++) {
				DescribeDcdnTopDomainsByFlowResponse.DescribeDcdnTopDomainsByFlow_TopDomain topDomain = new DescribeDcdnTopDomainsByFlowResponse.DescribeDcdnTopDomainsByFlow_TopDomain();
				topDomain.DomainName = context.StringValue("DescribeDcdnTopDomainsByFlow.TopDomains["+ i +"].DomainName");
				topDomain.Rank = context.LongValue("DescribeDcdnTopDomainsByFlow.TopDomains["+ i +"].Rank");
				topDomain.TotalTraffic = context.StringValue("DescribeDcdnTopDomainsByFlow.TopDomains["+ i +"].TotalTraffic");
				topDomain.TrafficPercent = context.StringValue("DescribeDcdnTopDomainsByFlow.TopDomains["+ i +"].TrafficPercent");
				topDomain.MaxBps = context.LongValue("DescribeDcdnTopDomainsByFlow.TopDomains["+ i +"].MaxBps");
				topDomain.MaxBpsTime = context.StringValue("DescribeDcdnTopDomainsByFlow.TopDomains["+ i +"].MaxBpsTime");
				topDomain.TotalAccess = context.LongValue("DescribeDcdnTopDomainsByFlow.TopDomains["+ i +"].TotalAccess");

				describeDcdnTopDomainsByFlowResponse_topDomains.Add(topDomain);
			}
			describeDcdnTopDomainsByFlowResponse.TopDomains = describeDcdnTopDomainsByFlowResponse_topDomains;
        
			return describeDcdnTopDomainsByFlowResponse;
        }
    }
}
