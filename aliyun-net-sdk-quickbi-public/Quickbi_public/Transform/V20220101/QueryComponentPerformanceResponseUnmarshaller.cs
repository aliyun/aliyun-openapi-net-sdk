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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class QueryComponentPerformanceResponseUnmarshaller
    {
        public static QueryComponentPerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryComponentPerformanceResponse queryComponentPerformanceResponse = new QueryComponentPerformanceResponse();

			queryComponentPerformanceResponse.HttpResponse = _ctx.HttpResponse;
			queryComponentPerformanceResponse.RequestId = _ctx.StringValue("QueryComponentPerformance.RequestId");
			queryComponentPerformanceResponse.Success = _ctx.BooleanValue("QueryComponentPerformance.Success");

			List<QueryComponentPerformanceResponse.QueryComponentPerformance_Data> queryComponentPerformanceResponse_result = new List<QueryComponentPerformanceResponse.QueryComponentPerformance_Data>();
			for (int i = 0; i < _ctx.Length("QueryComponentPerformance.Result.Length"); i++) {
				QueryComponentPerformanceResponse.QueryComponentPerformance_Data data = new QueryComponentPerformanceResponse.QueryComponentPerformance_Data();
				data.QueryTimeoutCountPercent = _ctx.DoubleValue("QueryComponentPerformance.Result["+ i +"].QueryTimeoutCountPercent");
				data.QueryOverTenSecPercentNum = _ctx.DoubleValue("QueryComponentPerformance.Result["+ i +"].QueryOverTenSecPercentNum");
				data.RepeatSqlQueryPercent = _ctx.StringValue("QueryComponentPerformance.Result["+ i +"].RepeatSqlQueryPercent");
				data.WorkspaceId = _ctx.StringValue("QueryComponentPerformance.Result["+ i +"].WorkspaceId");
				data.ReportId = _ctx.StringValue("QueryComponentPerformance.Result["+ i +"].ReportId");
				data.QueryOverTenSecPercent = _ctx.StringValue("QueryComponentPerformance.Result["+ i +"].QueryOverTenSecPercent");
				data.QuickIndexQueryCount = _ctx.IntegerValue("QueryComponentPerformance.Result["+ i +"].QuickIndexQueryCount");
				data.QueryTimeoutCount = _ctx.IntegerValue("QueryComponentPerformance.Result["+ i +"].QueryTimeoutCount");
				data.CacheQueryCount = _ctx.IntegerValue("QueryComponentPerformance.Result["+ i +"].CacheQueryCount");
				data.CacheCostTimeAvg = _ctx.DoubleValue("QueryComponentPerformance.Result["+ i +"].CacheCostTimeAvg");
				data.QueryCountAvg = _ctx.DoubleValue("QueryComponentPerformance.Result["+ i +"].QueryCountAvg");
				data.QuickIndexCostTimeAvg = _ctx.DoubleValue("QueryComponentPerformance.Result["+ i +"].QuickIndexCostTimeAvg");
				data.ReportName = _ctx.StringValue("QueryComponentPerformance.Result["+ i +"].ReportName");
				data.CostTimeAvg = _ctx.DoubleValue("QueryComponentPerformance.Result["+ i +"].CostTimeAvg");
				data.QueryCount = _ctx.IntegerValue("QueryComponentPerformance.Result["+ i +"].QueryCount");
				data.WorkspaceName = _ctx.StringValue("QueryComponentPerformance.Result["+ i +"].WorkspaceName");
				data.ComponentName = _ctx.StringValue("QueryComponentPerformance.Result["+ i +"].ComponentName");
				data.QueryOverFivePercentNum = _ctx.DoubleValue("QueryComponentPerformance.Result["+ i +"].QueryOverFivePercentNum");
				data.QueryOverFiveSecPercent = _ctx.StringValue("QueryComponentPerformance.Result["+ i +"].QueryOverFiveSecPercent");
				data.RepeatQueryPercentNum = _ctx.DoubleValue("QueryComponentPerformance.Result["+ i +"].RepeatQueryPercentNum");
				data.RepeatSqlQueryCount = _ctx.IntegerValue("QueryComponentPerformance.Result["+ i +"].RepeatSqlQueryCount");
				data.ComponentId = _ctx.StringValue("QueryComponentPerformance.Result["+ i +"].ComponentId");
				data.RepeatQueryPercent = _ctx.StringValue("QueryComponentPerformance.Result["+ i +"].RepeatQueryPercent");
				data.ReportType = _ctx.StringValue("QueryComponentPerformance.Result["+ i +"].ReportType");

				queryComponentPerformanceResponse_result.Add(data);
			}
			queryComponentPerformanceResponse.Result = queryComponentPerformanceResponse_result;
        
			return queryComponentPerformanceResponse;
        }
    }
}
