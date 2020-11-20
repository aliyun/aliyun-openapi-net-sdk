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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeIndexRecommendationResponseUnmarshaller
    {
        public static DescribeIndexRecommendationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIndexRecommendationResponse describeIndexRecommendationResponse = new DescribeIndexRecommendationResponse();

			describeIndexRecommendationResponse.HttpResponse = _ctx.HttpResponse;
			describeIndexRecommendationResponse.RequestId = _ctx.StringValue("DescribeIndexRecommendation.RequestId");
			describeIndexRecommendationResponse.TotalRecordCount = _ctx.IntegerValue("DescribeIndexRecommendation.TotalRecordCount");
			describeIndexRecommendationResponse.PageNumber = _ctx.IntegerValue("DescribeIndexRecommendation.PageNumber");
			describeIndexRecommendationResponse.PageRecordCount = _ctx.IntegerValue("DescribeIndexRecommendation.PageRecordCount");

			List<DescribeIndexRecommendationResponse.DescribeIndexRecommendation_Analyzation> describeIndexRecommendationResponse_analyzations = new List<DescribeIndexRecommendationResponse.DescribeIndexRecommendation_Analyzation>();
			for (int i = 0; i < _ctx.Length("DescribeIndexRecommendation.Analyzations.Length"); i++) {
				DescribeIndexRecommendationResponse.DescribeIndexRecommendation_Analyzation analyzation = new DescribeIndexRecommendationResponse.DescribeIndexRecommendation_Analyzation();
				analyzation.Database = _ctx.StringValue("DescribeIndexRecommendation.Analyzations["+ i +"].Database");
				analyzation._Namespace = _ctx.StringValue("DescribeIndexRecommendation.Analyzations["+ i +"].Namespace");
				analyzation.Operation = _ctx.StringValue("DescribeIndexRecommendation.Analyzations["+ i +"].Operation");
				analyzation.Query = _ctx.StringValue("DescribeIndexRecommendation.Analyzations["+ i +"].Query");
				analyzation.Sort = _ctx.StringValue("DescribeIndexRecommendation.Analyzations["+ i +"].Sort");
				analyzation.Count = _ctx.LongValue("DescribeIndexRecommendation.Analyzations["+ i +"].Count");
				analyzation.TotalExecutionTime = _ctx.LongValue("DescribeIndexRecommendation.Analyzations["+ i +"].TotalExecutionTime");
				analyzation.AverageExecutionTime = _ctx.LongValue("DescribeIndexRecommendation.Analyzations["+ i +"].AverageExecutionTime");
				analyzation.AverageReturnRowCount = _ctx.LongValue("DescribeIndexRecommendation.Analyzations["+ i +"].AverageReturnRowCount");
				analyzation.AverageDocsExaminedCount = _ctx.LongValue("DescribeIndexRecommendation.Analyzations["+ i +"].AverageDocsExaminedCount");
				analyzation.AverageKeysExaminedCount = _ctx.LongValue("DescribeIndexRecommendation.Analyzations["+ i +"].AverageKeysExaminedCount");
				analyzation.InMemorySort = _ctx.StringValue("DescribeIndexRecommendation.Analyzations["+ i +"].InMemorySort");
				analyzation.LastExecutionTime = _ctx.StringValue("DescribeIndexRecommendation.Analyzations["+ i +"].LastExecutionTime");
				analyzation.ExecutionPlan = _ctx.StringValue("DescribeIndexRecommendation.Analyzations["+ i +"].ExecutionPlan");

				List<string> analyzation_indexCombines = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeIndexRecommendation.Analyzations["+ i +"].IndexCombines.Length"); j++) {
					analyzation_indexCombines.Add(_ctx.StringValue("DescribeIndexRecommendation.Analyzations["+ i +"].IndexCombines["+ j +"]"));
				}
				analyzation.IndexCombines = analyzation_indexCombines;

				List<DescribeIndexRecommendationResponse.DescribeIndexRecommendation_Analyzation.DescribeIndexRecommendation_Recommendation> analyzation_indexRecommendations = new List<DescribeIndexRecommendationResponse.DescribeIndexRecommendation_Analyzation.DescribeIndexRecommendation_Recommendation>();
				for (int j = 0; j < _ctx.Length("DescribeIndexRecommendation.Analyzations["+ i +"].IndexRecommendations.Length"); j++) {
					DescribeIndexRecommendationResponse.DescribeIndexRecommendation_Analyzation.DescribeIndexRecommendation_Recommendation recommendation = new DescribeIndexRecommendationResponse.DescribeIndexRecommendation_Analyzation.DescribeIndexRecommendation_Recommendation();
					recommendation.RecmdType = _ctx.StringValue("DescribeIndexRecommendation.Analyzations["+ i +"].IndexRecommendations["+ j +"].RecmdType");
					recommendation.Content = _ctx.StringValue("DescribeIndexRecommendation.Analyzations["+ i +"].IndexRecommendations["+ j +"].Content");

					analyzation_indexRecommendations.Add(recommendation);
				}
				analyzation.IndexRecommendations = analyzation_indexRecommendations;

				describeIndexRecommendationResponse_analyzations.Add(analyzation);
			}
			describeIndexRecommendationResponse.Analyzations = describeIndexRecommendationResponse_analyzations;
        
			return describeIndexRecommendationResponse;
        }
    }
}
