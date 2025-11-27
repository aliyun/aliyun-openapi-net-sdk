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
    public class QueryReportPerformanceResponseUnmarshaller
    {
        public static QueryReportPerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryReportPerformanceResponse queryReportPerformanceResponse = new QueryReportPerformanceResponse();

			queryReportPerformanceResponse.HttpResponse = _ctx.HttpResponse;
			queryReportPerformanceResponse.RequestId = _ctx.StringValue("QueryReportPerformance.RequestId");
			queryReportPerformanceResponse.Success = _ctx.BooleanValue("QueryReportPerformance.Success");

			List<QueryReportPerformanceResponse.QueryReportPerformance_Data> queryReportPerformanceResponse_result = new List<QueryReportPerformanceResponse.QueryReportPerformance_Data>();
			for (int i = 0; i < _ctx.Length("QueryReportPerformance.Result.Length"); i++) {
				QueryReportPerformanceResponse.QueryReportPerformance_Data data = new QueryReportPerformanceResponse.QueryReportPerformance_Data();
				data.CacheCostTimeAvg = _ctx.DoubleValue("QueryReportPerformance.Result["+ i +"].CacheCostTimeAvg");
				data.CacheQueryCount = _ctx.IntegerValue("QueryReportPerformance.Result["+ i +"].CacheQueryCount");
				data.ComponentQueryCount = _ctx.IntegerValue("QueryReportPerformance.Result["+ i +"].ComponentQueryCount");
				data.ComponentQueryCountAvg = _ctx.DoubleValue("QueryReportPerformance.Result["+ i +"].ComponentQueryCountAvg");
				data.CostTimeAvg = _ctx.DoubleValue("QueryReportPerformance.Result["+ i +"].CostTimeAvg");
				data.QueryCount = _ctx.IntegerValue("QueryReportPerformance.Result["+ i +"].QueryCount");
				data.QueryCountAvg = _ctx.DoubleValue("QueryReportPerformance.Result["+ i +"].QueryCountAvg");
				data.QueryOverFivePercentNum = _ctx.DoubleValue("QueryReportPerformance.Result["+ i +"].QueryOverFivePercentNum");
				data.QueryOverFiveSecPercent = _ctx.StringValue("QueryReportPerformance.Result["+ i +"].QueryOverFiveSecPercent");
				data.QueryOverTenSecPercent = _ctx.StringValue("QueryReportPerformance.Result["+ i +"].QueryOverTenSecPercent");
				data.QueryOverTenSecPercentNum = _ctx.DoubleValue("QueryReportPerformance.Result["+ i +"].QueryOverTenSecPercentNum");
				data.QueryTimeoutCount = _ctx.IntegerValue("QueryReportPerformance.Result["+ i +"].QueryTimeoutCount");
				data.QueryTimeoutCountPercent = _ctx.DoubleValue("QueryReportPerformance.Result["+ i +"].QueryTimeoutCountPercent");
				data.QuickIndexCostTimeAvg = _ctx.DoubleValue("QueryReportPerformance.Result["+ i +"].QuickIndexCostTimeAvg");
				data.QuickIndexQueryCount = _ctx.IntegerValue("QueryReportPerformance.Result["+ i +"].QuickIndexQueryCount");
				data.RepeatQueryPercent = _ctx.StringValue("QueryReportPerformance.Result["+ i +"].RepeatQueryPercent");
				data.RepeatQueryPercentNum = _ctx.DoubleValue("QueryReportPerformance.Result["+ i +"].RepeatQueryPercentNum");
				data.RepeatSqlQueryCount = _ctx.IntegerValue("QueryReportPerformance.Result["+ i +"].RepeatSqlQueryCount");
				data.RepeatSqlQueryPercent = _ctx.StringValue("QueryReportPerformance.Result["+ i +"].RepeatSqlQueryPercent");
				data.ReportId = _ctx.StringValue("QueryReportPerformance.Result["+ i +"].ReportId");
				data.ReportName = _ctx.StringValue("QueryReportPerformance.Result["+ i +"].ReportName");
				data.ReportType = _ctx.StringValue("QueryReportPerformance.Result["+ i +"].ReportType");
				data.WorkspaceId = _ctx.StringValue("QueryReportPerformance.Result["+ i +"].WorkspaceId");
				data.WorkspaceName = _ctx.StringValue("QueryReportPerformance.Result["+ i +"].WorkspaceName");

				queryReportPerformanceResponse_result.Add(data);
			}
			queryReportPerformanceResponse.Result = queryReportPerformanceResponse_result;
        
			return queryReportPerformanceResponse;
        }
    }
}
