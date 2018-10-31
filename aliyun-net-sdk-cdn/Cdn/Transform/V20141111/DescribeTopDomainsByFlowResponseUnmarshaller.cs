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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeTopDomainsByFlowResponseUnmarshaller
    {
        public static DescribeTopDomainsByFlowResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTopDomainsByFlowResponse describeTopDomainsByFlowResponse = new DescribeTopDomainsByFlowResponse();

			describeTopDomainsByFlowResponse.HttpResponse = context.HttpResponse;
			describeTopDomainsByFlowResponse.RequestId = context.StringValue("DescribeTopDomainsByFlow.RequestId");
			describeTopDomainsByFlowResponse.StartTime = context.StringValue("DescribeTopDomainsByFlow.StartTime");
			describeTopDomainsByFlowResponse.EndTime = context.StringValue("DescribeTopDomainsByFlow.EndTime");
			describeTopDomainsByFlowResponse.DomainCount = context.LongValue("DescribeTopDomainsByFlow.DomainCount");
			describeTopDomainsByFlowResponse.DomainOnlineCount = context.LongValue("DescribeTopDomainsByFlow.DomainOnlineCount");

			List<DescribeTopDomainsByFlowResponse.DescribeTopDomainsByFlow_TopDomain> describeTopDomainsByFlowResponse_topDomains = new List<DescribeTopDomainsByFlowResponse.DescribeTopDomainsByFlow_TopDomain>();
			for (int i = 0; i < context.Length("DescribeTopDomainsByFlow.TopDomains.Length"); i++) {
				DescribeTopDomainsByFlowResponse.DescribeTopDomainsByFlow_TopDomain topDomain = new DescribeTopDomainsByFlowResponse.DescribeTopDomainsByFlow_TopDomain();
				topDomain.DomainName = context.StringValue("DescribeTopDomainsByFlow.TopDomains["+ i +"].DomainName");
				topDomain.Rank = context.LongValue("DescribeTopDomainsByFlow.TopDomains["+ i +"].Rank");
				topDomain.TotalTraffic = context.StringValue("DescribeTopDomainsByFlow.TopDomains["+ i +"].TotalTraffic");
				topDomain.TrafficPercent = context.StringValue("DescribeTopDomainsByFlow.TopDomains["+ i +"].TrafficPercent");
				topDomain.MaxBps = context.LongValue("DescribeTopDomainsByFlow.TopDomains["+ i +"].MaxBps");
				topDomain.MaxBpsTime = context.StringValue("DescribeTopDomainsByFlow.TopDomains["+ i +"].MaxBpsTime");
				topDomain.TotalAccess = context.LongValue("DescribeTopDomainsByFlow.TopDomains["+ i +"].TotalAccess");

				describeTopDomainsByFlowResponse_topDomains.Add(topDomain);
			}
			describeTopDomainsByFlowResponse.TopDomains = describeTopDomainsByFlowResponse_topDomains;
        
			return describeTopDomainsByFlowResponse;
        }
    }
}