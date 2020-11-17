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
    public class ListConfigRulesResponseUnmarshaller
    {
        public static ListConfigRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListConfigRulesResponse listConfigRulesResponse = new ListConfigRulesResponse();

			listConfigRulesResponse.HttpResponse = _ctx.HttpResponse;
			listConfigRulesResponse.RequestId = _ctx.StringValue("ListConfigRules.RequestId");

			ListConfigRulesResponse.ListConfigRules_ConfigRules configRules = new ListConfigRulesResponse.ListConfigRules_ConfigRules();
			configRules.PageNumber = _ctx.IntegerValue("ListConfigRules.ConfigRules.PageNumber");
			configRules.PageSize = _ctx.IntegerValue("ListConfigRules.ConfigRules.PageSize");
			configRules.TotalCount = _ctx.LongValue("ListConfigRules.ConfigRules.TotalCount");

			List<ListConfigRulesResponse.ListConfigRules_ConfigRules.ListConfigRules_ConfigRule> configRules_configRuleList = new List<ListConfigRulesResponse.ListConfigRules_ConfigRules.ListConfigRules_ConfigRule>();
			for (int i = 0; i < _ctx.Length("ListConfigRules.ConfigRules.ConfigRuleList.Length"); i++) {
				ListConfigRulesResponse.ListConfigRules_ConfigRules.ListConfigRules_ConfigRule configRule = new ListConfigRulesResponse.ListConfigRules_ConfigRules.ListConfigRules_ConfigRule();
				configRule.AccountId = _ctx.LongValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].AccountId");
				configRule.ConfigRuleArn = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].ConfigRuleArn");
				configRule.ConfigRuleId = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].ConfigRuleId");
				configRule.ConfigRuleName = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].ConfigRuleName");
				configRule.ConfigRuleState = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].ConfigRuleState");
				configRule.Description = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].Description");
				configRule.RiskLevel = _ctx.IntegerValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].RiskLevel");
				configRule.SourceIdentifier = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].SourceIdentifier");
				configRule.SourceOwner = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].SourceOwner");
				configRule.AutomationType = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].AutomationType");

				ListConfigRulesResponse.ListConfigRules_ConfigRules.ListConfigRules_ConfigRule.ListConfigRules_Compliance compliance = new ListConfigRulesResponse.ListConfigRules_ConfigRules.ListConfigRules_ConfigRule.ListConfigRules_Compliance();
				compliance.ComplianceType = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].Compliance.ComplianceType");
				compliance.Count = _ctx.IntegerValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].Compliance.Count");
				configRule.Compliance = compliance;

				ListConfigRulesResponse.ListConfigRules_ConfigRules.ListConfigRules_ConfigRule.ListConfigRules_CreateBy createBy = new ListConfigRulesResponse.ListConfigRules_ConfigRules.ListConfigRules_ConfigRule.ListConfigRules_CreateBy();
				createBy.CreatorId = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].CreateBy.CreatorId");
				createBy.CreatorName = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].CreateBy.CreatorName");
				createBy.CreatorType = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].CreateBy.CreatorType");
				createBy.ConfigRuleSceneId = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].CreateBy.ConfigRuleSceneId");
				createBy.ConfigRuleSceneName = _ctx.StringValue("ListConfigRules.ConfigRules.ConfigRuleList["+ i +"].CreateBy.ConfigRuleSceneName");
				configRule.CreateBy = createBy;

				configRules_configRuleList.Add(configRule);
			}
			configRules.ConfigRuleList = configRules_configRuleList;
			listConfigRulesResponse.ConfigRules = configRules;
        
			return listConfigRulesResponse;
        }
    }
}
