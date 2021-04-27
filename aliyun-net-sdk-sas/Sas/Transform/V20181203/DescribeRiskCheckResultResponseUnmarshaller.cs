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
        public static DescribeRiskCheckResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRiskCheckResultResponse describeRiskCheckResultResponse = new DescribeRiskCheckResultResponse();

			describeRiskCheckResultResponse.HttpResponse = _ctx.HttpResponse;
			describeRiskCheckResultResponse.RequestId = _ctx.StringValue("DescribeRiskCheckResult.RequestId");
			describeRiskCheckResultResponse.PageCount = _ctx.IntegerValue("DescribeRiskCheckResult.PageCount");
			describeRiskCheckResultResponse.Count = _ctx.IntegerValue("DescribeRiskCheckResult.Count");
			describeRiskCheckResultResponse.PageSize = _ctx.IntegerValue("DescribeRiskCheckResult.PageSize");
			describeRiskCheckResultResponse.TotalCount = _ctx.IntegerValue("DescribeRiskCheckResult.TotalCount");
			describeRiskCheckResultResponse.CurrentPage = _ctx.IntegerValue("DescribeRiskCheckResult.CurrentPage");

			List<DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay> describeRiskCheckResultResponse_list = new List<DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay>();
			for (int i = 0; i < _ctx.Length("DescribeRiskCheckResult.List.Length"); i++) {
				DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay riskCheckResultForDisplay = new DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay();
				riskCheckResultForDisplay.ItemId = _ctx.LongValue("DescribeRiskCheckResult.List["+ i +"].ItemId");
				riskCheckResultForDisplay.TaskId = _ctx.LongValue("DescribeRiskCheckResult.List["+ i +"].TaskId");
				riskCheckResultForDisplay.Title = _ctx.StringValue("DescribeRiskCheckResult.List["+ i +"].Title");
				riskCheckResultForDisplay.RiskLevel = _ctx.StringValue("DescribeRiskCheckResult.List["+ i +"].RiskLevel");
				riskCheckResultForDisplay.Status = _ctx.StringValue("DescribeRiskCheckResult.List["+ i +"].Status");
				riskCheckResultForDisplay.AffectedCount = _ctx.IntegerValue("DescribeRiskCheckResult.List["+ i +"].AffectedCount");
				riskCheckResultForDisplay.CheckTime = _ctx.LongValue("DescribeRiskCheckResult.List["+ i +"].CheckTime");
				riskCheckResultForDisplay.RemainingTime = _ctx.IntegerValue("DescribeRiskCheckResult.List["+ i +"].RemainingTime");
				riskCheckResultForDisplay.Sort = _ctx.IntegerValue("DescribeRiskCheckResult.List["+ i +"].Sort");
				riskCheckResultForDisplay.Type = _ctx.StringValue("DescribeRiskCheckResult.List["+ i +"].Type");
				riskCheckResultForDisplay.StartStatus = _ctx.StringValue("DescribeRiskCheckResult.List["+ i +"].StartStatus");
				riskCheckResultForDisplay.RepairStatus = _ctx.StringValue("DescribeRiskCheckResult.List["+ i +"].RepairStatus");
				riskCheckResultForDisplay.RiskAssertType = _ctx.StringValue("DescribeRiskCheckResult.List["+ i +"].RiskAssertType");

				List<DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay.DescribeRiskCheckResult_RiskItemResource> riskCheckResultForDisplay_riskItemResources = new List<DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay.DescribeRiskCheckResult_RiskItemResource>();
				for (int j = 0; j < _ctx.Length("DescribeRiskCheckResult.List["+ i +"].RiskItemResources.Length"); j++) {
					DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay.DescribeRiskCheckResult_RiskItemResource riskItemResource = new DescribeRiskCheckResultResponse.DescribeRiskCheckResult_RiskCheckResultForDisplay.DescribeRiskCheckResult_RiskItemResource();
					riskItemResource.ResourceName = _ctx.StringValue("DescribeRiskCheckResult.List["+ i +"].RiskItemResources["+ j +"].ResourceName");
					riskItemResource.ContentResource = _ctx.StringValue("DescribeRiskCheckResult.List["+ i +"].RiskItemResources["+ j +"].ContentResource");

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
