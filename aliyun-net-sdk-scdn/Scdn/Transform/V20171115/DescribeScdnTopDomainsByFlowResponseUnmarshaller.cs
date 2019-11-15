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
    public class DescribeScdnTopDomainsByFlowResponseUnmarshaller
    {
        public static DescribeScdnTopDomainsByFlowResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnTopDomainsByFlowResponse describeScdnTopDomainsByFlowResponse = new DescribeScdnTopDomainsByFlowResponse();

			describeScdnTopDomainsByFlowResponse.HttpResponse = context.HttpResponse;
			describeScdnTopDomainsByFlowResponse.RequestId = context.StringValue("DescribeScdnTopDomainsByFlow.RequestId");
			describeScdnTopDomainsByFlowResponse.StartTime = context.StringValue("DescribeScdnTopDomainsByFlow.StartTime");
			describeScdnTopDomainsByFlowResponse.EndTime = context.StringValue("DescribeScdnTopDomainsByFlow.EndTime");
			describeScdnTopDomainsByFlowResponse.DomainCount = context.LongValue("DescribeScdnTopDomainsByFlow.DomainCount");
			describeScdnTopDomainsByFlowResponse.DomainOnlineCount = context.LongValue("DescribeScdnTopDomainsByFlow.DomainOnlineCount");

			List<DescribeScdnTopDomainsByFlowResponse.DescribeScdnTopDomainsByFlow_TopDomain> describeScdnTopDomainsByFlowResponse_topDomains = new List<DescribeScdnTopDomainsByFlowResponse.DescribeScdnTopDomainsByFlow_TopDomain>();
			for (int i = 0; i < context.Length("DescribeScdnTopDomainsByFlow.TopDomains.Length"); i++) {
				DescribeScdnTopDomainsByFlowResponse.DescribeScdnTopDomainsByFlow_TopDomain topDomain = new DescribeScdnTopDomainsByFlowResponse.DescribeScdnTopDomainsByFlow_TopDomain();
				topDomain.DomainName = context.StringValue("DescribeScdnTopDomainsByFlow.TopDomains["+ i +"].DomainName");
				topDomain.Rank = context.LongValue("DescribeScdnTopDomainsByFlow.TopDomains["+ i +"].Rank");
				topDomain.TotalTraffic = context.StringValue("DescribeScdnTopDomainsByFlow.TopDomains["+ i +"].TotalTraffic");
				topDomain.TrafficPercent = context.StringValue("DescribeScdnTopDomainsByFlow.TopDomains["+ i +"].TrafficPercent");
				topDomain.MaxBps = context.LongValue("DescribeScdnTopDomainsByFlow.TopDomains["+ i +"].MaxBps");
				topDomain.MaxBpsTime = context.StringValue("DescribeScdnTopDomainsByFlow.TopDomains["+ i +"].MaxBpsTime");
				topDomain.TotalAccess = context.LongValue("DescribeScdnTopDomainsByFlow.TopDomains["+ i +"].TotalAccess");

				describeScdnTopDomainsByFlowResponse_topDomains.Add(topDomain);
			}
			describeScdnTopDomainsByFlowResponse.TopDomains = describeScdnTopDomainsByFlowResponse_topDomains;
        
			return describeScdnTopDomainsByFlowResponse;
        }
    }
}
