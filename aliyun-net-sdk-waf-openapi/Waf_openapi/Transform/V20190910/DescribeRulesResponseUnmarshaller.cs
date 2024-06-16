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
    public class DescribeRulesResponseUnmarshaller
    {
        public static DescribeRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRulesResponse describeRulesResponse = new DescribeRulesResponse();

			describeRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeRulesResponse.RuleGroupTemplateId = _ctx.StringValue("DescribeRules.RuleGroupTemplateId");
			describeRulesResponse.RuleGroupName = _ctx.StringValue("DescribeRules.RuleGroupName");
			describeRulesResponse.RequestId = _ctx.StringValue("DescribeRules.RequestId");
			describeRulesResponse.TotalCount = _ctx.IntegerValue("DescribeRules.TotalCount");
			describeRulesResponse.RuleGroupTemplateName = _ctx.StringValue("DescribeRules.RuleGroupTemplateName");
			describeRulesResponse.IsSubscribe = _ctx.LongValue("DescribeRules.IsSubscribe");

			List<DescribeRulesResponse.DescribeRules_RulesItem> describeRulesResponse_rules = new List<DescribeRulesResponse.DescribeRules_RulesItem>();
			for (int i = 0; i < _ctx.Length("DescribeRules.Rules.Length"); i++) {
				DescribeRulesResponse.DescribeRules_RulesItem rulesItem = new DescribeRulesResponse.DescribeRules_RulesItem();
				rulesItem.RiskLevel = _ctx.IntegerValue("DescribeRules.Rules["+ i +"].RiskLevel");
				rulesItem.UpdateTime = _ctx.LongValue("DescribeRules.Rules["+ i +"].UpdateTime");
				rulesItem.Description = _ctx.StringValue("DescribeRules.Rules["+ i +"].Description");
				rulesItem.CveUrl = _ctx.StringValue("DescribeRules.Rules["+ i +"].CveUrl");
				rulesItem.ApplicationType = _ctx.IntegerValue("DescribeRules.Rules["+ i +"].ApplicationType");
				rulesItem.CveId = _ctx.StringValue("DescribeRules.Rules["+ i +"].CveId");
				rulesItem.ProtectionType = _ctx.IntegerValue("DescribeRules.Rules["+ i +"].ProtectionType");
				rulesItem.RuleName = _ctx.StringValue("DescribeRules.Rules["+ i +"].RuleName");
				rulesItem.RuleId = _ctx.LongValue("DescribeRules.Rules["+ i +"].RuleId");

				describeRulesResponse_rules.Add(rulesItem);
			}
			describeRulesResponse.Rules = describeRulesResponse_rules;
        
			return describeRulesResponse;
        }
    }
}
