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
using Aliyun.Acs.Config.Model.V20190108;

namespace Aliyun.Acs.Config.Transform.V20190108
{
    public class DescribeEvaluationResultsResponseUnmarshaller
    {
        public static DescribeEvaluationResultsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEvaluationResultsResponse describeEvaluationResultsResponse = new DescribeEvaluationResultsResponse();

			describeEvaluationResultsResponse.HttpResponse = context.HttpResponse;
			describeEvaluationResultsResponse.RequestId = context.StringValue("DescribeEvaluationResults.RequestId");

			DescribeEvaluationResultsResponse.DescribeEvaluationResults_EvaluationResults evaluationResults = new DescribeEvaluationResultsResponse.DescribeEvaluationResults_EvaluationResults();
			evaluationResults.PageNumber = context.IntegerValue("DescribeEvaluationResults.EvaluationResults.PageNumber");
			evaluationResults.PageSize = context.IntegerValue("DescribeEvaluationResults.EvaluationResults.PageSize");
			evaluationResults.TotalCount = context.LongValue("DescribeEvaluationResults.EvaluationResults.TotalCount");

			List<DescribeEvaluationResultsResponse.DescribeEvaluationResults_EvaluationResults.DescribeEvaluationResults_EvaluationResult> evaluationResults_evaluationResultList = new List<DescribeEvaluationResultsResponse.DescribeEvaluationResults_EvaluationResults.DescribeEvaluationResults_EvaluationResult>();
			for (int i = 0; i < context.Length("DescribeEvaluationResults.EvaluationResults.EvaluationResultList.Length"); i++) {
				DescribeEvaluationResultsResponse.DescribeEvaluationResults_EvaluationResults.DescribeEvaluationResults_EvaluationResult evaluationResult = new DescribeEvaluationResultsResponse.DescribeEvaluationResults_EvaluationResults.DescribeEvaluationResults_EvaluationResult();
				evaluationResult.Annotation = context.StringValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].Annotation");
				evaluationResult.ComplianceType = context.StringValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].ComplianceType");
				evaluationResult.ConfigRuleInvokedTimestamp = context.LongValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].ConfigRuleInvokedTimestamp");
				evaluationResult.InvokingEventMessageType = context.StringValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].InvokingEventMessageType");
				evaluationResult.ResultRecordedTimestamp = context.LongValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].ResultRecordedTimestamp");
				evaluationResult.RiskLevel = context.IntegerValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].RiskLevel");

				DescribeEvaluationResultsResponse.DescribeEvaluationResults_EvaluationResults.DescribeEvaluationResults_EvaluationResult.DescribeEvaluationResults_EvaluationResultIdentifier evaluationResultIdentifier = new DescribeEvaluationResultsResponse.DescribeEvaluationResults_EvaluationResults.DescribeEvaluationResults_EvaluationResult.DescribeEvaluationResults_EvaluationResultIdentifier();
				evaluationResultIdentifier.OrderingTimestamp = context.LongValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].EvaluationResultIdentifier.OrderingTimestamp");

				DescribeEvaluationResultsResponse.DescribeEvaluationResults_EvaluationResults.DescribeEvaluationResults_EvaluationResult.DescribeEvaluationResults_EvaluationResultIdentifier.DescribeEvaluationResults_EvaluationResultQualifier evaluationResultQualifier = new DescribeEvaluationResultsResponse.DescribeEvaluationResults_EvaluationResults.DescribeEvaluationResults_EvaluationResult.DescribeEvaluationResults_EvaluationResultIdentifier.DescribeEvaluationResults_EvaluationResultQualifier();
				evaluationResultQualifier.ConfigRuleArn = context.StringValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].EvaluationResultIdentifier.EvaluationResultQualifier.ConfigRuleArn");
				evaluationResultQualifier.ConfigRuleId = context.StringValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].EvaluationResultIdentifier.EvaluationResultQualifier.ConfigRuleId");
				evaluationResultQualifier.ConfigRuleName = context.StringValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].EvaluationResultIdentifier.EvaluationResultQualifier.ConfigRuleName");
				evaluationResultQualifier.ResourceId = context.StringValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].EvaluationResultIdentifier.EvaluationResultQualifier.ResourceId");
				evaluationResultQualifier.ResourceType = context.StringValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].EvaluationResultIdentifier.EvaluationResultQualifier.ResourceType");
				evaluationResultQualifier.RegionId = context.StringValue("DescribeEvaluationResults.EvaluationResults.EvaluationResultList["+ i +"].EvaluationResultIdentifier.EvaluationResultQualifier.RegionId");
				evaluationResultIdentifier.EvaluationResultQualifier = evaluationResultQualifier;
				evaluationResult.EvaluationResultIdentifier = evaluationResultIdentifier;

				evaluationResults_evaluationResultList.Add(evaluationResult);
			}
			evaluationResults.EvaluationResultList = evaluationResults_evaluationResultList;
			describeEvaluationResultsResponse.EvaluationResults = evaluationResults;
        
			return describeEvaluationResultsResponse;
        }
    }
}
