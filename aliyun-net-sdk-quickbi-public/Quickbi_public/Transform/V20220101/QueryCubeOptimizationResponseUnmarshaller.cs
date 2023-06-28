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
    public class QueryCubeOptimizationResponseUnmarshaller
    {
        public static QueryCubeOptimizationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCubeOptimizationResponse queryCubeOptimizationResponse = new QueryCubeOptimizationResponse();

			queryCubeOptimizationResponse.HttpResponse = _ctx.HttpResponse;
			queryCubeOptimizationResponse.RequestId = _ctx.StringValue("QueryCubeOptimization.RequestId");
			queryCubeOptimizationResponse.Success = _ctx.BooleanValue("QueryCubeOptimization.Success");

			List<QueryCubeOptimizationResponse.QueryCubeOptimization_Data> queryCubeOptimizationResponse_result = new List<QueryCubeOptimizationResponse.QueryCubeOptimization_Data>();
			for (int i = 0; i < _ctx.Length("QueryCubeOptimization.Result.Length"); i++) {
				QueryCubeOptimizationResponse.QueryCubeOptimization_Data data = new QueryCubeOptimizationResponse.QueryCubeOptimization_Data();
				data.AdviceType = _ctx.StringValue("QueryCubeOptimization.Result["+ i +"].AdviceType");

				QueryCubeOptimizationResponse.QueryCubeOptimization_Data.QueryCubeOptimization_CubePerformanceDiagnoseModel cubePerformanceDiagnoseModel = new QueryCubeOptimizationResponse.QueryCubeOptimization_Data.QueryCubeOptimization_CubePerformanceDiagnoseModel();
				cubePerformanceDiagnoseModel.CubeId = _ctx.StringValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.CubeId");
				cubePerformanceDiagnoseModel.CubeName = _ctx.StringValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.CubeName");
				cubePerformanceDiagnoseModel.QueryTimeoutCount = _ctx.IntegerValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.QueryTimeoutCount");
				cubePerformanceDiagnoseModel.RepeatSqlQueryPercent = _ctx.StringValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.RepeatSqlQueryPercent");
				cubePerformanceDiagnoseModel.WorkspaceName = _ctx.StringValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.WorkspaceName");
				cubePerformanceDiagnoseModel.WorkspaceId = _ctx.StringValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.WorkspaceId");
				cubePerformanceDiagnoseModel.RepeatQueryPercentNum = _ctx.DoubleValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.RepeatQueryPercentNum");
				cubePerformanceDiagnoseModel.RepeatQueryPercent = _ctx.StringValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.RepeatQueryPercent");
				cubePerformanceDiagnoseModel.QuickIndexCostTimeAvg = _ctx.DoubleValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.QuickIndexCostTimeAvg");
				cubePerformanceDiagnoseModel.QuickIndexQueryCount = _ctx.IntegerValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.QuickIndexQueryCount");
				cubePerformanceDiagnoseModel.CacheCostTimeAvg = _ctx.DoubleValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.CacheCostTimeAvg");
				cubePerformanceDiagnoseModel.CacheQueryCount = _ctx.IntegerValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.CacheQueryCount");
				cubePerformanceDiagnoseModel.RepeatSqlQueryCount = _ctx.IntegerValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.RepeatSqlQueryCount");
				cubePerformanceDiagnoseModel.CostTimeAvg = _ctx.DoubleValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.CostTimeAvg");
				cubePerformanceDiagnoseModel.QueryCountAvg = _ctx.DoubleValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.QueryCountAvg");
				cubePerformanceDiagnoseModel.QueryCount = _ctx.IntegerValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.QueryCount");
				cubePerformanceDiagnoseModel.QueryTimeoutCountPercent = _ctx.DoubleValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.QueryTimeoutCountPercent");
				cubePerformanceDiagnoseModel.QueryOverTenSecPercentNum = _ctx.DoubleValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.QueryOverTenSecPercentNum");
				cubePerformanceDiagnoseModel.QueryOverFivePercentNum = _ctx.DoubleValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.QueryOverFivePercentNum");
				cubePerformanceDiagnoseModel.QueryOverTenSecPercent = _ctx.StringValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.QueryOverTenSecPercent");
				cubePerformanceDiagnoseModel.QueryOverFiveSecPercent = _ctx.StringValue("QueryCubeOptimization.Result["+ i +"].CubePerformanceDiagnoseModel.QueryOverFiveSecPercent");
				data.CubePerformanceDiagnoseModel = cubePerformanceDiagnoseModel;

				queryCubeOptimizationResponse_result.Add(data);
			}
			queryCubeOptimizationResponse.Result = queryCubeOptimizationResponse_result;
        
			return queryCubeOptimizationResponse;
        }
    }
}
