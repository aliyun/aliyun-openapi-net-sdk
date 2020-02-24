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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class DescribeStatisticalDataResponseUnmarshaller
    {
        public static DescribeStatisticalDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStatisticalDataResponse describeStatisticalDataResponse = new DescribeStatisticalDataResponse();

			describeStatisticalDataResponse.HttpResponse = context.HttpResponse;
			describeStatisticalDataResponse.RequestId = context.StringValue("DescribeStatisticalData.RequestId");
			describeStatisticalDataResponse.ResolvedQuestionTotalNum = context.LongValue("DescribeStatisticalData.ResolvedQuestionTotalNum");
			describeStatisticalDataResponse.ConversationTotalNum = context.LongValue("DescribeStatisticalData.ConversationTotalNum");
			describeStatisticalDataResponse.TotalResolutionRate = context.StringValue("DescribeStatisticalData.TotalResolutionRate");
			describeStatisticalDataResponse.TotalValidAnswerRate = context.StringValue("DescribeStatisticalData.TotalValidAnswerRate");
			describeStatisticalDataResponse.TotalDialoguePassRate = context.StringValue("DescribeStatisticalData.TotalDialoguePassRate");
			describeStatisticalDataResponse.TotalKnowledgeHitRate = context.StringValue("DescribeStatisticalData.TotalKnowledgeHitRate");

			List<DescribeStatisticalDataResponse.DescribeStatisticalData_StatisticalDataReport> describeStatisticalDataResponse_statisticalDataReports = new List<DescribeStatisticalDataResponse.DescribeStatisticalData_StatisticalDataReport>();
			for (int i = 0; i < context.Length("DescribeStatisticalData.StatisticalDataReports.Length"); i++) {
				DescribeStatisticalDataResponse.DescribeStatisticalData_StatisticalDataReport statisticalDataReport = new DescribeStatisticalDataResponse.DescribeStatisticalData_StatisticalDataReport();
				statisticalDataReport.StatisticalDate = context.StringValue("DescribeStatisticalData.StatisticalDataReports["+ i +"].StatisticalDate");
				statisticalDataReport.ResolvedQuestionNum = context.IntegerValue("DescribeStatisticalData.StatisticalDataReports["+ i +"].ResolvedQuestionNum");
				statisticalDataReport.TotalConversationNum = context.IntegerValue("DescribeStatisticalData.StatisticalDataReports["+ i +"].TotalConversationNum");
				statisticalDataReport.ResolutionRate = context.StringValue("DescribeStatisticalData.StatisticalDataReports["+ i +"].ResolutionRate");
				statisticalDataReport.ValidAnswerRate = context.StringValue("DescribeStatisticalData.StatisticalDataReports["+ i +"].ValidAnswerRate");
				statisticalDataReport.DialoguePassRate = context.StringValue("DescribeStatisticalData.StatisticalDataReports["+ i +"].DialoguePassRate");
				statisticalDataReport.KnowledgeHitRate = context.StringValue("DescribeStatisticalData.StatisticalDataReports["+ i +"].KnowledgeHitRate");

				describeStatisticalDataResponse_statisticalDataReports.Add(statisticalDataReport);
			}
			describeStatisticalDataResponse.StatisticalDataReports = describeStatisticalDataResponse_statisticalDataReports;
        
			return describeStatisticalDataResponse;
        }
    }
}
