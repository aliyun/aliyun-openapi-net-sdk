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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeRiskCheckResultResponseUnmarshaller
    {
        public static DescribeRiskCheckResultResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRiskCheckResultResponse describeRiskCheckResultResponse = new DescribeRiskCheckResultResponse();

			describeRiskCheckResultResponse.HttpResponse = context.HttpResponse;
			describeRiskCheckResultResponse.RequestId = context.StringValue("DescribeRiskCheckResult.RequestId");
			describeRiskCheckResultResponse.PageCount = context.IntegerValue("DescribeRiskCheckResult.PageCount");
			describeRiskCheckResultResponse.Count = context.IntegerValue("DescribeRiskCheckResult.Count");
			describeRiskCheckResultResponse.PageSize = context.IntegerValue("DescribeRiskCheckResult.PageSize");
			describeRiskCheckResultResponse.TotalCount = context.IntegerValue("DescribeRiskCheckResult.TotalCount");
			describeRiskCheckResultResponse.CurrentPage = context.IntegerValue("DescribeRiskCheckResult.CurrentPage");

			List<DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay> describeRiskCheckResultResponse_list = new List<DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay>();
			for (int i = 0; i < context.Length("DescribeRiskCheckResult.List.Length"); i++) {
				DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay riskCheckResultForDisplay = new DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay();
				riskCheckResultForDisplay.ItemId = context.LongValue("DescribeRiskCheckResult.List["+ i +"].ItemId");
				riskCheckResultForDisplay.TaskId = context.LongValue("DescribeRiskCheckResult.List["+ i +"].TaskId");
				riskCheckResultForDisplay.Title = context.StringValue("DescribeRiskCheckResult.List["+ i +"].Title");
				riskCheckResultForDisplay.RiskLevel = context.StringValue("DescribeRiskCheckResult.List["+ i +"].RiskLevel");
				riskCheckResultForDisplay.Status = context.StringValue("DescribeRiskCheckResult.List["+ i +"].Status");
				riskCheckResultForDisplay.AffectedCount = context.IntegerValue("DescribeRiskCheckResult.List["+ i +"].AffectedCount");
				riskCheckResultForDisplay.CheckTime = context.LongValue("DescribeRiskCheckResult.List["+ i +"].CheckTime");
				riskCheckResultForDisplay.RemainingTime = context.IntegerValue("DescribeRiskCheckResult.List["+ i +"].RemainingTime");
				riskCheckResultForDisplay.Sort = context.IntegerValue("DescribeRiskCheckResult.List["+ i +"].Sort");
				riskCheckResultForDisplay.Type = context.StringValue("DescribeRiskCheckResult.List["+ i +"].Type");
				riskCheckResultForDisplay.StartStatus = context.StringValue("DescribeRiskCheckResult.List["+ i +"].StartStatus");
				riskCheckResultForDisplay.RepairStatus = context.StringValue("DescribeRiskCheckResult.List["+ i +"].RepairStatus");
				riskCheckResultForDisplay.RiskAssertType = context.StringValue("DescribeRiskCheckResult.List["+ i +"].RiskAssertType");

				List<DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay.DescribeRiskCheckResult_RiskItemResource> riskCheckResultForDisplay_riskItemResources = new List<DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay.DescribeRiskCheckResult_RiskItemResource>();
				for (int j = 0; j < context.Length("DescribeRiskCheckResult.List["+ i +"].RiskItemResources.Length"); j++) {
					DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay.DescribeRiskCheckResult_RiskItemResource riskItemResource = new DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay.DescribeRiskCheckResult_RiskItemResource();
					riskItemResource.ResourceName = context.StringValue("DescribeRiskCheckResult.List["+ i +"].RiskItemResources["+ j +"].ResourceName");
					riskItemResource.ContentResource = context.StringValue("DescribeRiskCheckResult.List["+ i +"].RiskItemResources["+ j +"].ContentResource");

					riskCheckResultForDisplay_riskItemResources.Add(riskItemResource);
				}
				riskCheckResultForDisplay.RiskItemResources = riskCheckResultForDisplay_riskItemResources;

				describeRiskCheckResultResponse_list.Add(riskCheckResultForDisplay);
			}
			describeRiskCheckResultResponse.List = describeRiskCheckResultResponse_list;
        
			return describeRiskCheckResultResponse;
        }
    }
}
