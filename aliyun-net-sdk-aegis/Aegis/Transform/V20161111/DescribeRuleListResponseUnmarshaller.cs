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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeRuleListResponseUnmarshaller
    {
        public static DescribeRuleListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRuleListResponse describeRuleListResponse = new DescribeRuleListResponse();

			describeRuleListResponse.HttpResponse = context.HttpResponse;
			describeRuleListResponse.RequestId = context.StringValue("DescribeRuleList.RequestId");
			describeRuleListResponse.Success = context.BooleanValue("DescribeRuleList.Success");

			DescribeRuleListResponse.DescribeRuleList_PageInfo pageInfo = new DescribeRuleListResponse.DescribeRuleList_PageInfo();
			pageInfo.PageSize = context.IntegerValue("DescribeRuleList.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeRuleList.PageInfo.CurrentPage");
			pageInfo.TotalCount = context.IntegerValue("DescribeRuleList.PageInfo.TotalCount");
			describeRuleListResponse.PageInfo = pageInfo;

			List<DescribeRuleListResponse.DescribeRuleList_RulesItem> describeRuleListResponse_rules = new List<DescribeRuleListResponse.DescribeRuleList_RulesItem>();
			for (int i = 0; i < context.Length("DescribeRuleList.Rules.Length"); i++) {
				DescribeRuleListResponse.DescribeRuleList_RulesItem rulesItem = new DescribeRuleListResponse.DescribeRuleList_RulesItem();
				rulesItem.WarnLevel = context.StringValue("DescribeRuleList.Rules["+ i +"].WarnLevel");
				rulesItem.Modified = context.LongValue("DescribeRuleList.Rules["+ i +"].Modified");
				rulesItem.Create = context.LongValue("DescribeRuleList.Rules["+ i +"].Create");
				rulesItem.RuleName = context.StringValue("DescribeRuleList.Rules["+ i +"].RuleName");
				rulesItem.Description = context.StringValue("DescribeRuleList.Rules["+ i +"].Description");
				rulesItem.Id = context.IntegerValue("DescribeRuleList.Rules["+ i +"].Id");
				rulesItem.DataSourceId = context.IntegerValue("DescribeRuleList.Rules["+ i +"].DataSourceId");
				rulesItem.Expressions = context.StringValue("DescribeRuleList.Rules["+ i +"].Expressions");
				rulesItem.Actions = context.StringValue("DescribeRuleList.Rules["+ i +"].Actions");
				rulesItem.StatisticsRules = context.StringValue("DescribeRuleList.Rules["+ i +"].StatisticsRules");
				rulesItem.NeedGroup = context.BooleanValue("DescribeRuleList.Rules["+ i +"].NeedGroup");
				rulesItem.StatusCode = context.StringValue("DescribeRuleList.Rules["+ i +"].StatusCode");

				List<DescribeRuleListResponse.DescribeRuleList_RulesItem.DescribeRuleList_RuleGroup> rulesItem_ruleGroups = new List<DescribeRuleListResponse.DescribeRuleList_RulesItem.DescribeRuleList_RuleGroup>();
				for (int j = 0; j < context.Length("DescribeRuleList.Rules["+ i +"].RuleGroups.Length"); j++) {
					DescribeRuleListResponse.DescribeRuleList_RulesItem.DescribeRuleList_RuleGroup ruleGroup = new DescribeRuleListResponse.DescribeRuleList_RulesItem.DescribeRuleList_RuleGroup();
					ruleGroup.GroupName = context.StringValue("DescribeRuleList.Rules["+ i +"].RuleGroups["+ j +"].GroupName");
					ruleGroup.RuleNum = context.IntegerValue("DescribeRuleList.Rules["+ i +"].RuleGroups["+ j +"].RuleNum");
					ruleGroup.Modified = context.LongValue("DescribeRuleList.Rules["+ i +"].RuleGroups["+ j +"].Modified");
					ruleGroup.Create = context.LongValue("DescribeRuleList.Rules["+ i +"].RuleGroups["+ j +"].Create");
					ruleGroup.Description = context.StringValue("DescribeRuleList.Rules["+ i +"].RuleGroups["+ j +"].Description");
					ruleGroup.Id = context.IntegerValue("DescribeRuleList.Rules["+ i +"].RuleGroups["+ j +"].Id");
					ruleGroup.AliUid = context.IntegerValue("DescribeRuleList.Rules["+ i +"].RuleGroups["+ j +"].AliUid");

					rulesItem_ruleGroups.Add(ruleGroup);
				}
				rulesItem.RuleGroups = rulesItem_ruleGroups;

				describeRuleListResponse_rules.Add(rulesItem);
			}
			describeRuleListResponse.Rules = describeRuleListResponse_rules;
        
			return describeRuleListResponse;
        }
    }
}
