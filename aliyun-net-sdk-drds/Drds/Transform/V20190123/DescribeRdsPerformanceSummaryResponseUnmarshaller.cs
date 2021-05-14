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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeRdsPerformanceSummaryResponseUnmarshaller
    {
        public static DescribeRdsPerformanceSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRdsPerformanceSummaryResponse describeRdsPerformanceSummaryResponse = new DescribeRdsPerformanceSummaryResponse();

			describeRdsPerformanceSummaryResponse.HttpResponse = _ctx.HttpResponse;
			describeRdsPerformanceSummaryResponse.RequestId = _ctx.StringValue("DescribeRdsPerformanceSummary.RequestId");
			describeRdsPerformanceSummaryResponse.Success = _ctx.BooleanValue("DescribeRdsPerformanceSummary.Success");

			List<DescribeRdsPerformanceSummaryResponse.DescribeRdsPerformanceSummary_RdsPerformanceInfo> describeRdsPerformanceSummaryResponse_rdsPerformanceInfos = new List<DescribeRdsPerformanceSummaryResponse.DescribeRdsPerformanceSummary_RdsPerformanceInfo>();
			for (int i = 0; i < _ctx.Length("DescribeRdsPerformanceSummary.RdsPerformanceInfos.Length"); i++) {
				DescribeRdsPerformanceSummaryResponse.DescribeRdsPerformanceSummary_RdsPerformanceInfo rdsPerformanceInfo = new DescribeRdsPerformanceSummaryResponse.DescribeRdsPerformanceSummary_RdsPerformanceInfo();
				rdsPerformanceInfo.RdsId = _ctx.StringValue("DescribeRdsPerformanceSummary.RdsPerformanceInfos["+ i +"].RdsId");
				rdsPerformanceInfo.Cpu = _ctx.FloatValue("DescribeRdsPerformanceSummary.RdsPerformanceInfos["+ i +"].Cpu");
				rdsPerformanceInfo.Iops = _ctx.FloatValue("DescribeRdsPerformanceSummary.RdsPerformanceInfos["+ i +"].Iops");
				rdsPerformanceInfo.ActiveSessions = _ctx.IntegerValue("DescribeRdsPerformanceSummary.RdsPerformanceInfos["+ i +"].ActiveSessions");
				rdsPerformanceInfo.TotalSessions = _ctx.IntegerValue("DescribeRdsPerformanceSummary.RdsPerformanceInfos["+ i +"].TotalSessions");
				rdsPerformanceInfo.SpaceUsage = _ctx.LongValue("DescribeRdsPerformanceSummary.RdsPerformanceInfos["+ i +"].SpaceUsage");

				describeRdsPerformanceSummaryResponse_rdsPerformanceInfos.Add(rdsPerformanceInfo);
			}
			describeRdsPerformanceSummaryResponse.RdsPerformanceInfos = describeRdsPerformanceSummaryResponse_rdsPerformanceInfos;
        
			return describeRdsPerformanceSummaryResponse;
        }
    }
}
