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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsTopDomainsByFlowResponseUnmarshaller
    {
        public static DescribeVsTopDomainsByFlowResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsTopDomainsByFlowResponse describeVsTopDomainsByFlowResponse = new DescribeVsTopDomainsByFlowResponse();

			describeVsTopDomainsByFlowResponse.HttpResponse = context.HttpResponse;
			describeVsTopDomainsByFlowResponse.RequestId = context.StringValue("DescribeVsTopDomainsByFlow.RequestId");
			describeVsTopDomainsByFlowResponse.StartTime = context.StringValue("DescribeVsTopDomainsByFlow.StartTime");
			describeVsTopDomainsByFlowResponse.EndTime = context.StringValue("DescribeVsTopDomainsByFlow.EndTime");
			describeVsTopDomainsByFlowResponse.DomainCount = context.LongValue("DescribeVsTopDomainsByFlow.DomainCount");
			describeVsTopDomainsByFlowResponse.DomainOnlineCount = context.LongValue("DescribeVsTopDomainsByFlow.DomainOnlineCount");

			List<DescribeVsTopDomainsByFlowResponse.DescribeVsTopDomainsByFlow_TopDomain> describeVsTopDomainsByFlowResponse_topDomains = new List<DescribeVsTopDomainsByFlowResponse.DescribeVsTopDomainsByFlow_TopDomain>();
			for (int i = 0; i < context.Length("DescribeVsTopDomainsByFlow.TopDomains.Length"); i++) {
				DescribeVsTopDomainsByFlowResponse.DescribeVsTopDomainsByFlow_TopDomain topDomain = new DescribeVsTopDomainsByFlowResponse.DescribeVsTopDomainsByFlow_TopDomain();
				topDomain.DomainName = context.StringValue("DescribeVsTopDomainsByFlow.TopDomains["+ i +"].DomainName");
				topDomain.Rank = context.LongValue("DescribeVsTopDomainsByFlow.TopDomains["+ i +"].Rank");
				topDomain.TotalTraffic = context.StringValue("DescribeVsTopDomainsByFlow.TopDomains["+ i +"].TotalTraffic");
				topDomain.TrafficPercent = context.StringValue("DescribeVsTopDomainsByFlow.TopDomains["+ i +"].TrafficPercent");
				topDomain.MaxBps = context.LongValue("DescribeVsTopDomainsByFlow.TopDomains["+ i +"].MaxBps");
				topDomain.MaxBpsTime = context.StringValue("DescribeVsTopDomainsByFlow.TopDomains["+ i +"].MaxBpsTime");
				topDomain.TotalAccess = context.LongValue("DescribeVsTopDomainsByFlow.TopDomains["+ i +"].TotalAccess");

				describeVsTopDomainsByFlowResponse_topDomains.Add(topDomain);
			}
			describeVsTopDomainsByFlowResponse.TopDomains = describeVsTopDomainsByFlowResponse_topDomains;
        
			return describeVsTopDomainsByFlowResponse;
        }
    }
}
