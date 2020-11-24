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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeWebPreciseAccessRuleResponseUnmarshaller
    {
        public static DescribeWebPreciseAccessRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebPreciseAccessRuleResponse describeWebPreciseAccessRuleResponse = new DescribeWebPreciseAccessRuleResponse();

			describeWebPreciseAccessRuleResponse.HttpResponse = _ctx.HttpResponse;
			describeWebPreciseAccessRuleResponse.RequestId = _ctx.StringValue("DescribeWebPreciseAccessRule.RequestId");

			List<DescribeWebPreciseAccessRuleResponse.DescribeWebPreciseAccessRule_PreciseAccessConfig> describeWebPreciseAccessRuleResponse_preciseAccessConfigList = new List<DescribeWebPreciseAccessRuleResponse.DescribeWebPreciseAccessRule_PreciseAccessConfig>();
			for (int i = 0; i < _ctx.Length("DescribeWebPreciseAccessRule.PreciseAccessConfigList.Length"); i++) {
				DescribeWebPreciseAccessRuleResponse.DescribeWebPreciseAccessRule_PreciseAccessConfig preciseAccessConfig = new DescribeWebPreciseAccessRuleResponse.DescribeWebPreciseAccessRule_PreciseAccessConfig();
				preciseAccessConfig.Domain = _ctx.StringValue("DescribeWebPreciseAccessRule.PreciseAccessConfigList["+ i +"].Domain");

				List<DescribeWebPreciseAccessRuleResponse.DescribeWebPreciseAccessRule_PreciseAccessConfig.DescribeWebPreciseAccessRule_Rule> preciseAccessConfig_ruleList = new List<DescribeWebPreciseAccessRuleResponse.DescribeWebPreciseAccessRule_PreciseAccessConfig.DescribeWebPreciseAccessRule_Rule>();
				for (int j = 0; j < _ctx.Length("DescribeWebPreciseAccessRule.PreciseAccessConfigList["+ i +"].RuleList.Length"); j++) {
					DescribeWebPreciseAccessRuleResponse.DescribeWebPreciseAccessRule_PreciseAccessConfig.DescribeWebPreciseAccessRule_Rule rule = new DescribeWebPreciseAccessRuleResponse.DescribeWebPreciseAccessRule_PreciseAccessConfig.DescribeWebPreciseAccessRule_Rule();
					rule.Owner = _ctx.StringValue("DescribeWebPreciseAccessRule.PreciseAccessConfigList["+ i +"].RuleList["+ j +"].Owner");
					rule.Expires = _ctx.LongValue("DescribeWebPreciseAccessRule.PreciseAccessConfigList["+ i +"].RuleList["+ j +"].Expires");
					rule.Name = _ctx.StringValue("DescribeWebPreciseAccessRule.PreciseAccessConfigList["+ i +"].RuleList["+ j +"].Name");
					rule.Action = _ctx.StringValue("DescribeWebPreciseAccessRule.PreciseAccessConfigList["+ i +"].RuleList["+ j +"].Action");

					List<DescribeWebPreciseAccessRuleResponse.DescribeWebPreciseAccessRule_PreciseAccessConfig.DescribeWebPreciseAccessRule_Rule.DescribeWebPreciseAccessRule_Condition> rule_conditionList = new List<DescribeWebPreciseAccessRuleResponse.DescribeWebPreciseAccessRule_PreciseAccessConfig.DescribeWebPreciseAccessRule_Rule.DescribeWebPreciseAccessRule_Condition>();
					for (int k = 0; k < _ctx.Length("DescribeWebPreciseAccessRule.PreciseAccessConfigList["+ i +"].RuleList["+ j +"].ConditionList.Length"); k++) {
						DescribeWebPreciseAccessRuleResponse.DescribeWebPreciseAccessRule_PreciseAccessConfig.DescribeWebPreciseAccessRule_Rule.DescribeWebPreciseAccessRule_Condition condition = new DescribeWebPreciseAccessRuleResponse.DescribeWebPreciseAccessRule_PreciseAccessConfig.DescribeWebPreciseAccessRule_Rule.DescribeWebPreciseAccessRule_Condition();
						condition.MatchMethod = _ctx.StringValue("DescribeWebPreciseAccessRule.PreciseAccessConfigList["+ i +"].RuleList["+ j +"].ConditionList["+ k +"].MatchMethod");
						condition.Field = _ctx.StringValue("DescribeWebPreciseAccessRule.PreciseAccessConfigList["+ i +"].RuleList["+ j +"].ConditionList["+ k +"].Field");
						condition.HeaderName = _ctx.StringValue("DescribeWebPreciseAccessRule.PreciseAccessConfigList["+ i +"].RuleList["+ j +"].ConditionList["+ k +"].HeaderName");
						condition.Content = _ctx.StringValue("DescribeWebPreciseAccessRule.PreciseAccessConfigList["+ i +"].RuleList["+ j +"].ConditionList["+ k +"].Content");

						rule_conditionList.Add(condition);
					}
					rule.ConditionList = rule_conditionList;

					preciseAccessConfig_ruleList.Add(rule);
				}
				preciseAccessConfig.RuleList = preciseAccessConfig_ruleList;

				describeWebPreciseAccessRuleResponse_preciseAccessConfigList.Add(preciseAccessConfig);
			}
			describeWebPreciseAccessRuleResponse.PreciseAccessConfigList = describeWebPreciseAccessRuleResponse_preciseAccessConfigList;
        
			return describeWebPreciseAccessRuleResponse;
        }
    }
}
