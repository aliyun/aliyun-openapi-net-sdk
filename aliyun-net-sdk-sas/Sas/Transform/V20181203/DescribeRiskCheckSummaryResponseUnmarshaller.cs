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
    public class DescribeRiskCheckSummaryResponseUnmarshaller
    {
        public static DescribeRiskCheckSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRiskCheckSummaryResponse describeRiskCheckSummaryResponse = new DescribeRiskCheckSummaryResponse();

			describeRiskCheckSummaryResponse.HttpResponse = context.HttpResponse;
			describeRiskCheckSummaryResponse.RequestId = context.StringValue("DescribeRiskCheckSummary.RequestId");

			DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary riskCheckSummary = new DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary();
			riskCheckSummary.RiskCount = context.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.RiskCount");
			riskCheckSummary.PreviousCount = context.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.PreviousCount");
			riskCheckSummary.ItemCount = context.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.ItemCount");
			riskCheckSummary.RiskRate = context.FloatValue("DescribeRiskCheckSummary.RiskCheckSummary.RiskRate");
			riskCheckSummary.AffectedAssetCount = context.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.AffectedAssetCount");
			riskCheckSummary.PreviousTime = context.LongValue("DescribeRiskCheckSummary.RiskCheckSummary.PreviousTime");
			riskCheckSummary.EnabledRiskCount = context.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.EnabledRiskCount");
			riskCheckSummary.DisabledRiskCount = context.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.DisabledRiskCount");

			List<DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_LevelCount> riskCheckSummary_riskLevelCount = new List<DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_LevelCount>();
			for (int i = 0; i < context.Length("DescribeRiskCheckSummary.RiskCheckSummary.RiskLevelCount.Length"); i++) {
				DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_LevelCount levelCount = new DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_LevelCount();
				levelCount.Key = context.StringValue("DescribeRiskCheckSummary.RiskCheckSummary.RiskLevelCount["+ i +"].Key");
				levelCount.Count = context.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.RiskLevelCount["+ i +"].Count");

				riskCheckSummary_riskLevelCount.Add(levelCount);
			}
			riskCheckSummary.RiskLevelCount = riskCheckSummary_riskLevelCount;

			List<DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group> riskCheckSummary_groups = new List<DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group>();
			for (int i = 0; i < context.Length("DescribeRiskCheckSummary.RiskCheckSummary.Groups.Length"); i++) {
				DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group group = new DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group();
				group.Id = context.LongValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].Id");
				group.Title = context.StringValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].Title");
				group.Status = context.StringValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].Status");
				group.RemainingTime = context.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].RemainingTime");
				group.Sort = context.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].Sort");

				List<DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group.DescribeRiskCheckSummary_StatusCount> group_countByStatus = new List<DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group.DescribeRiskCheckSummary_StatusCount>();
				for (int j = 0; j < context.Length("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].CountByStatus.Length"); j++) {
					DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group.DescribeRiskCheckSummary_StatusCount statusCount = new DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group.DescribeRiskCheckSummary_StatusCount();
					statusCount.Status = context.StringValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].CountByStatus["+ j +"].Status");
					statusCount.Count = context.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].CountByStatus["+ j +"].Count");

					group_countByStatus.Add(statusCount);
				}
				group.CountByStatus = group_countByStatus;

				riskCheckSummary_groups.Add(group);
			}
			riskCheckSummary.Groups = riskCheckSummary_groups;
			describeRiskCheckSummaryResponse.RiskCheckSummary = riskCheckSummary;
        
			return describeRiskCheckSummaryResponse;
        }
    }
}
