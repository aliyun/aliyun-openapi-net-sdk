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
    public class DescribeSchedulerRulesResponseUnmarshaller
    {
        public static DescribeSchedulerRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSchedulerRulesResponse describeSchedulerRulesResponse = new DescribeSchedulerRulesResponse();

			describeSchedulerRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeSchedulerRulesResponse.TotalCount = _ctx.StringValue("DescribeSchedulerRules.TotalCount");
			describeSchedulerRulesResponse.RequestId = _ctx.StringValue("DescribeSchedulerRules.RequestId");

			List<DescribeSchedulerRulesResponse.DescribeSchedulerRules_SchedulerRule> describeSchedulerRulesResponse_schedulerRules = new List<DescribeSchedulerRulesResponse.DescribeSchedulerRules_SchedulerRule>();
			for (int i = 0; i < _ctx.Length("DescribeSchedulerRules.SchedulerRules.Length"); i++) {
				DescribeSchedulerRulesResponse.DescribeSchedulerRules_SchedulerRule schedulerRule = new DescribeSchedulerRulesResponse.DescribeSchedulerRules_SchedulerRule();
				schedulerRule.RuleType = _ctx.StringValue("DescribeSchedulerRules.SchedulerRules["+ i +"].RuleType");
				schedulerRule.Cname = _ctx.StringValue("DescribeSchedulerRules.SchedulerRules["+ i +"].Cname");
				schedulerRule.RuleName = _ctx.StringValue("DescribeSchedulerRules.SchedulerRules["+ i +"].RuleName");

				DescribeSchedulerRulesResponse.DescribeSchedulerRules_SchedulerRule.DescribeSchedulerRules_Param param = new DescribeSchedulerRulesResponse.DescribeSchedulerRules_SchedulerRule.DescribeSchedulerRules_Param();
				param.ParamType = _ctx.StringValue("DescribeSchedulerRules.SchedulerRules["+ i +"].Param.ParamType");

				DescribeSchedulerRulesResponse.DescribeSchedulerRules_SchedulerRule.DescribeSchedulerRules_Param.DescribeSchedulerRules_ParamData paramData = new DescribeSchedulerRulesResponse.DescribeSchedulerRules_SchedulerRule.DescribeSchedulerRules_Param.DescribeSchedulerRules_ParamData();
				paramData.CloudInstanceId = _ctx.StringValue("DescribeSchedulerRules.SchedulerRules["+ i +"].Param.ParamData.CloudInstanceId");
				param.ParamData = paramData;
				schedulerRule.Param = param;

				List<DescribeSchedulerRulesResponse.DescribeSchedulerRules_SchedulerRule.DescribeSchedulerRules_Rule> schedulerRule_rules = new List<DescribeSchedulerRulesResponse.DescribeSchedulerRules_SchedulerRule.DescribeSchedulerRules_Rule>();
				for (int j = 0; j < _ctx.Length("DescribeSchedulerRules.SchedulerRules["+ i +"].Rules.Length"); j++) {
					DescribeSchedulerRulesResponse.DescribeSchedulerRules_SchedulerRule.DescribeSchedulerRules_Rule rule = new DescribeSchedulerRulesResponse.DescribeSchedulerRules_SchedulerRule.DescribeSchedulerRules_Rule();
					rule.Type = _ctx.StringValue("DescribeSchedulerRules.SchedulerRules["+ i +"].Rules["+ j +"].Type");
					rule.Status = _ctx.IntegerValue("DescribeSchedulerRules.SchedulerRules["+ i +"].Rules["+ j +"].Status");
					rule._Value = _ctx.StringValue("DescribeSchedulerRules.SchedulerRules["+ i +"].Rules["+ j +"].Value");
					rule.ValueType = _ctx.IntegerValue("DescribeSchedulerRules.SchedulerRules["+ i +"].Rules["+ j +"].ValueType");
					rule.Priority = _ctx.IntegerValue("DescribeSchedulerRules.SchedulerRules["+ i +"].Rules["+ j +"].Priority");
					rule.RestoreDelay = _ctx.IntegerValue("DescribeSchedulerRules.SchedulerRules["+ i +"].Rules["+ j +"].RestoreDelay");
					rule.RegionId = _ctx.StringValue("DescribeSchedulerRules.SchedulerRules["+ i +"].Rules["+ j +"].RegionId");

					schedulerRule_rules.Add(rule);
				}
				schedulerRule.Rules = schedulerRule_rules;

				describeSchedulerRulesResponse_schedulerRules.Add(schedulerRule);
			}
			describeSchedulerRulesResponse.SchedulerRules = describeSchedulerRulesResponse_schedulerRules;
        
			return describeSchedulerRulesResponse;
        }
    }
}
