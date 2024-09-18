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
    public class QueryCubePerformanceResponseUnmarshaller
    {
        public static QueryCubePerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCubePerformanceResponse queryCubePerformanceResponse = new QueryCubePerformanceResponse();

			queryCubePerformanceResponse.HttpResponse = _ctx.HttpResponse;
			queryCubePerformanceResponse.RequestId = _ctx.StringValue("QueryCubePerformance.RequestId");
			queryCubePerformanceResponse.Success = _ctx.BooleanValue("QueryCubePerformance.Success");

			List<QueryCubePerformanceResponse.QueryCubePerformance_Data> queryCubePerformanceResponse_result = new List<QueryCubePerformanceResponse.QueryCubePerformance_Data>();
			for (int i = 0; i < _ctx.Length("QueryCubePerformance.Result.Length"); i++) {
				QueryCubePerformanceResponse.QueryCubePerformance_Data data = new QueryCubePerformanceResponse.QueryCubePerformance_Data();
				data.CacheCostTimeAvg = _ctx.DoubleValue("QueryCubePerformance.Result["+ i +"].CacheCostTimeAvg");
				data.CacheQueryCount = _ctx.IntegerValue("QueryCubePerformance.Result["+ i +"].CacheQueryCount");
				data.CostTimeAvg = _ctx.DoubleValue("QueryCubePerformance.Result["+ i +"].CostTimeAvg");
				data.CubeId = _ctx.StringValue("QueryCubePerformance.Result["+ i +"].CubeId");
				data.CubeName = _ctx.StringValue("QueryCubePerformance.Result["+ i +"].CubeName");
				data.QueryCount = _ctx.IntegerValue("QueryCubePerformance.Result["+ i +"].QueryCount");
				data.QueryCountAvg = _ctx.DoubleValue("QueryCubePerformance.Result["+ i +"].QueryCountAvg");
				data.QueryOverFivePercentNum = _ctx.DoubleValue("QueryCubePerformance.Result["+ i +"].QueryOverFivePercentNum");
				data.QueryOverFiveSecPercent = _ctx.StringValue("QueryCubePerformance.Result["+ i +"].QueryOverFiveSecPercent");
				data.QueryOverTenSecPercent = _ctx.StringValue("QueryCubePerformance.Result["+ i +"].QueryOverTenSecPercent");
				data.QueryOverTenSecPercentNum = _ctx.DoubleValue("QueryCubePerformance.Result["+ i +"].QueryOverTenSecPercentNum");
				data.QueryTimeoutCount = _ctx.IntegerValue("QueryCubePerformance.Result["+ i +"].QueryTimeoutCount");
				data.QueryTimeoutCountPercent = _ctx.DoubleValue("QueryCubePerformance.Result["+ i +"].QueryTimeoutCountPercent");
				data.QuickIndexCostTimeAvg = _ctx.DoubleValue("QueryCubePerformance.Result["+ i +"].QuickIndexCostTimeAvg");
				data.QuickIndexQueryCount = _ctx.IntegerValue("QueryCubePerformance.Result["+ i +"].QuickIndexQueryCount");
				data.RepeatQueryPercent = _ctx.StringValue("QueryCubePerformance.Result["+ i +"].RepeatQueryPercent");
				data.RepeatQueryPercentNum = _ctx.DoubleValue("QueryCubePerformance.Result["+ i +"].RepeatQueryPercentNum");
				data.RepeatSqlQueryCount = _ctx.IntegerValue("QueryCubePerformance.Result["+ i +"].RepeatSqlQueryCount");
				data.RepeatSqlQueryPercent = _ctx.StringValue("QueryCubePerformance.Result["+ i +"].RepeatSqlQueryPercent");
				data.WorkspaceId = _ctx.StringValue("QueryCubePerformance.Result["+ i +"].WorkspaceId");
				data.WorkspaceName = _ctx.StringValue("QueryCubePerformance.Result["+ i +"].WorkspaceName");

				queryCubePerformanceResponse_result.Add(data);
			}
			queryCubePerformanceResponse.Result = queryCubePerformanceResponse_result;
        
			return queryCubePerformanceResponse;
        }
    }
}
