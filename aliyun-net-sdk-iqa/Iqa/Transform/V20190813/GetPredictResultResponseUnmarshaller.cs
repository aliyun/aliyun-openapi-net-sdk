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
using Aliyun.Acs.iqa.Model.V20190813;

namespace Aliyun.Acs.iqa.Transform.V20190813
{
    public class GetPredictResultResponseUnmarshaller
    {
        public static GetPredictResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetPredictResultResponse getPredictResultResponse = new GetPredictResultResponse();

			getPredictResultResponse.HttpResponse = context.HttpResponse;
			getPredictResultResponse.RequestId = context.StringValue("GetPredictResult.RequestId");
			getPredictResultResponse.ProjectId = context.StringValue("GetPredictResult.ProjectId");
			getPredictResultResponse.Question = context.StringValue("GetPredictResult.Question");
			getPredictResultResponse.TopK = context.IntegerValue("GetPredictResult.TopK");
			getPredictResultResponse.TraceTag = context.StringValue("GetPredictResult.TraceTag");
			getPredictResultResponse.CostTime = context.LongValue("GetPredictResult.CostTime");
			getPredictResultResponse.Trace = context.StringValue("GetPredictResult.Trace");

			List<GetPredictResultResponse.GetPredictResult_PredictResult> getPredictResultResponse_predictResults = new List<GetPredictResultResponse.GetPredictResult_PredictResult>();
			for (int i = 0; i < context.Length("GetPredictResult.PredictResults.Length"); i++) {
				GetPredictResultResponse.GetPredictResult_PredictResult predictResult = new GetPredictResultResponse.GetPredictResult_PredictResult();
				predictResult.Rank = context.IntegerValue("GetPredictResult.PredictResults["+ i +"].Rank");
				predictResult.QuestionId = context.StringValue("GetPredictResult.PredictResults["+ i +"].QuestionId");
				predictResult.Question = context.StringValue("GetPredictResult.PredictResults["+ i +"].Question");
				predictResult.Score = context.FloatValue("GetPredictResult.PredictResults["+ i +"].Score");
				predictResult.Answer = context.StringValue("GetPredictResult.PredictResults["+ i +"].Answer");

				getPredictResultResponse_predictResults.Add(predictResult);
			}
			getPredictResultResponse.PredictResults = getPredictResultResponse_predictResults;
        
			return getPredictResultResponse;
        }
    }
}
