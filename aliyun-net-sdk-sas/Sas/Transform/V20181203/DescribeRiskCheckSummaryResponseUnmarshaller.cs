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
        public static DescribeRiskCheckSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRiskCheckSummaryResponse describeRiskCheckSummaryResponse = new DescribeRiskCheckSummaryResponse();

			describeRiskCheckSummaryResponse.HttpResponse = _ctx.HttpResponse;
			describeRiskCheckSummaryResponse.RequestId = _ctx.StringValue("DescribeRiskCheckSummary.RequestId");

			DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary riskCheckSummary = new DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary();
			riskCheckSummary.ItemCount = _ctx.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.ItemCount");
			riskCheckSummary.AffectedAssetCount = _ctx.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.AffectedAssetCount");
			riskCheckSummary.DisabledRiskCount = _ctx.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.DisabledRiskCount");
			riskCheckSummary.RiskCount = _ctx.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.RiskCount");
			riskCheckSummary.RiskRate = _ctx.FloatValue("DescribeRiskCheckSummary.RiskCheckSummary.RiskRate");
			riskCheckSummary.PreviousCount = _ctx.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.PreviousCount");
			riskCheckSummary.PreviousTime = _ctx.LongValue("DescribeRiskCheckSummary.RiskCheckSummary.PreviousTime");
			riskCheckSummary.EnabledRiskCount = _ctx.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.EnabledRiskCount");

			List<DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_LevelCount> riskCheckSummary_riskLevelCount = new List<DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_LevelCount>();
			for (int i = 0; i < _ctx.Length("DescribeRiskCheckSummary.RiskCheckSummary.RiskLevelCount.Length"); i++) {
				DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_LevelCount levelCount = new DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_LevelCount();
				levelCount.Key = _ctx.StringValue("DescribeRiskCheckSummary.RiskCheckSummary.RiskLevelCount["+ i +"].Key");
				levelCount.Count = _ctx.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.RiskLevelCount["+ i +"].Count");

				riskCheckSummary_riskLevelCount.Add(levelCount);
			}
			riskCheckSummary.RiskLevelCount = riskCheckSummary_riskLevelCount;

			List<DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group> riskCheckSummary_groups = new List<DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group>();
			for (int i = 0; i < _ctx.Length("DescribeRiskCheckSummary.RiskCheckSummary.Groups.Length"); i++) {
				DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group group = new DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group();
				group.RemainingTime = _ctx.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].RemainingTime");
				group.Status = _ctx.StringValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].Status");
				group.Sort = _ctx.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].Sort");
				group.Title = _ctx.StringValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].Title");
				group.Id = _ctx.LongValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].Id");

				List<DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group.DescribeRiskCheckSummary_StatusCount> group_countByStatus = new List<DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group.DescribeRiskCheckSummary_StatusCount>();
				for (int j = 0; j < _ctx.Length("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].CountByStatus.Length"); j++) {
					DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group.DescribeRiskCheckSummary_StatusCount statusCount = new DescribeRiskCheckSummaryResponse.DescribeRiskCheckSummary_RiskCheckSummary.DescribeRiskCheckSummary_Group.DescribeRiskCheckSummary_StatusCount();
					statusCount.Status = _ctx.StringValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].CountByStatus["+ j +"].Status");
					statusCount.Count = _ctx.IntegerValue("DescribeRiskCheckSummary.RiskCheckSummary.Groups["+ i +"].CountByStatus["+ j +"].Count");

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
