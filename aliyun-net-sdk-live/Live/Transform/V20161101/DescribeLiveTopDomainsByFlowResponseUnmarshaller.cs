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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveTopDomainsByFlowResponseUnmarshaller
    {
        public static DescribeLiveTopDomainsByFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveTopDomainsByFlowResponse describeLiveTopDomainsByFlowResponse = new DescribeLiveTopDomainsByFlowResponse();

			describeLiveTopDomainsByFlowResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveTopDomainsByFlowResponse.RequestId = _ctx.StringValue("DescribeLiveTopDomainsByFlow.RequestId");
			describeLiveTopDomainsByFlowResponse.StartTime = _ctx.StringValue("DescribeLiveTopDomainsByFlow.StartTime");
			describeLiveTopDomainsByFlowResponse.EndTime = _ctx.StringValue("DescribeLiveTopDomainsByFlow.EndTime");
			describeLiveTopDomainsByFlowResponse.DomainCount = _ctx.LongValue("DescribeLiveTopDomainsByFlow.DomainCount");
			describeLiveTopDomainsByFlowResponse.DomainOnlineCount = _ctx.LongValue("DescribeLiveTopDomainsByFlow.DomainOnlineCount");

			List<DescribeLiveTopDomainsByFlowResponse.DescribeLiveTopDomainsByFlow_TopDomain> describeLiveTopDomainsByFlowResponse_topDomains = new List<DescribeLiveTopDomainsByFlowResponse.DescribeLiveTopDomainsByFlow_TopDomain>();
			for (int i = 0; i < _ctx.Length("DescribeLiveTopDomainsByFlow.TopDomains.Length"); i++) {
				DescribeLiveTopDomainsByFlowResponse.DescribeLiveTopDomainsByFlow_TopDomain topDomain = new DescribeLiveTopDomainsByFlowResponse.DescribeLiveTopDomainsByFlow_TopDomain();
				topDomain.DomainName = _ctx.StringValue("DescribeLiveTopDomainsByFlow.TopDomains["+ i +"].DomainName");
				topDomain.Rank = _ctx.LongValue("DescribeLiveTopDomainsByFlow.TopDomains["+ i +"].Rank");
				topDomain.TotalTraffic = _ctx.StringValue("DescribeLiveTopDomainsByFlow.TopDomains["+ i +"].TotalTraffic");
				topDomain.TrafficPercent = _ctx.StringValue("DescribeLiveTopDomainsByFlow.TopDomains["+ i +"].TrafficPercent");
				topDomain.MaxBps = _ctx.LongValue("DescribeLiveTopDomainsByFlow.TopDomains["+ i +"].MaxBps");
				topDomain.MaxBpsTime = _ctx.StringValue("DescribeLiveTopDomainsByFlow.TopDomains["+ i +"].MaxBpsTime");
				topDomain.TotalAccess = _ctx.LongValue("DescribeLiveTopDomainsByFlow.TopDomains["+ i +"].TotalAccess");

				describeLiveTopDomainsByFlowResponse_topDomains.Add(topDomain);
			}
			describeLiveTopDomainsByFlowResponse.TopDomains = describeLiveTopDomainsByFlowResponse_topDomains;
        
			return describeLiveTopDomainsByFlowResponse;
        }
    }
}
