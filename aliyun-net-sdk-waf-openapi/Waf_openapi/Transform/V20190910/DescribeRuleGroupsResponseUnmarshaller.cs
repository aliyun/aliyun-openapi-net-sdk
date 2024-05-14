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
using Aliyun.Acs.waf_openapi.Model.V20190910;

namespace Aliyun.Acs.waf_openapi.Transform.V20190910
{
    public class DescribeRuleGroupsResponseUnmarshaller
    {
        public static DescribeRuleGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRuleGroupsResponse describeRuleGroupsResponse = new DescribeRuleGroupsResponse();

			describeRuleGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeRuleGroupsResponse.RequestId = _ctx.StringValue("DescribeRuleGroups.RequestId");
			describeRuleGroupsResponse.TaskStatus = _ctx.IntegerValue("DescribeRuleGroups.TaskStatus");
			describeRuleGroupsResponse.Total = _ctx.IntegerValue("DescribeRuleGroups.Total");
			describeRuleGroupsResponse.WafTaskId = _ctx.StringValue("DescribeRuleGroups.WafTaskId");

			List<DescribeRuleGroupsResponse.DescribeRuleGroups_RuleGroupsItem> describeRuleGroupsResponse_ruleGroups = new List<DescribeRuleGroupsResponse.DescribeRuleGroups_RuleGroupsItem>();
			for (int i = 0; i < _ctx.Length("DescribeRuleGroups.RuleGroups.Length"); i++) {
				DescribeRuleGroupsResponse.DescribeRuleGroups_RuleGroupsItem ruleGroupsItem = new DescribeRuleGroupsResponse.DescribeRuleGroups_RuleGroupsItem();
				ruleGroupsItem.Type = _ctx.IntegerValue("DescribeRuleGroups.RuleGroups["+ i +"].Type");
				ruleGroupsItem.RuleCnt = _ctx.IntegerValue("DescribeRuleGroups.RuleGroups["+ i +"].RuleCnt");
				ruleGroupsItem.RuleGroupUpdateTime = _ctx.LongValue("DescribeRuleGroups.RuleGroups["+ i +"].RuleGroupUpdateTime");
				ruleGroupsItem.PolicyId = _ctx.LongValue("DescribeRuleGroups.RuleGroups["+ i +"].PolicyId");
				ruleGroupsItem.Name = _ctx.StringValue("DescribeRuleGroups.RuleGroups["+ i +"].Name");
				ruleGroupsItem.TemplatePolicyId = _ctx.LongValue("DescribeRuleGroups.RuleGroups["+ i +"].TemplatePolicyId");
				ruleGroupsItem.RuleGroupTemplateName = _ctx.StringValue("DescribeRuleGroups.RuleGroups["+ i +"].RuleGroupTemplateName");
				ruleGroupsItem.Desc = _ctx.StringValue("DescribeRuleGroups.RuleGroups["+ i +"].Desc");
				ruleGroupsItem.WafVersion = _ctx.LongValue("DescribeRuleGroups.RuleGroups["+ i +"].WafVersion");

				List<string> ruleGroupsItem_domainList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeRuleGroups.RuleGroups["+ i +"].DomainList.Length"); j++) {
					ruleGroupsItem_domainList.Add(_ctx.StringValue("DescribeRuleGroups.RuleGroups["+ i +"].DomainList["+ j +"]"));
				}
				ruleGroupsItem.DomainList = ruleGroupsItem_domainList;

				describeRuleGroupsResponse_ruleGroups.Add(ruleGroupsItem);
			}
			describeRuleGroupsResponse.RuleGroups = describeRuleGroupsResponse_ruleGroups;
        
			return describeRuleGroupsResponse;
        }
    }
}
