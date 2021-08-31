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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetScalingRulesResponseUnmarshaller
    {
        public static GetScalingRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetScalingRulesResponse getScalingRulesResponse = new GetScalingRulesResponse();

			getScalingRulesResponse.HttpResponse = _ctx.HttpResponse;
			getScalingRulesResponse.RequestId = _ctx.StringValue("GetScalingRules.RequestId");
			getScalingRulesResponse.Code = _ctx.IntegerValue("GetScalingRules.Code");
			getScalingRulesResponse.Message = _ctx.StringValue("GetScalingRules.Message");
			getScalingRulesResponse.UpdateTime = _ctx.LongValue("GetScalingRules.UpdateTime");

			GetScalingRulesResponse.GetScalingRules_Data data = new GetScalingRulesResponse.GetScalingRules_Data();
			data.ClusterType = _ctx.IntegerValue("GetScalingRules.Data.ClusterType");
			data.OversoldFactor = _ctx.IntegerValue("GetScalingRules.Data.OversoldFactor");
			data.VpcId = _ctx.StringValue("GetScalingRules.Data.VpcId");
			data.UpdateTime = _ctx.LongValue("GetScalingRules.Data.UpdateTime");

			List<GetScalingRulesResponse.GetScalingRules_Data.GetScalingRules_Rule> data_ruleList = new List<GetScalingRulesResponse.GetScalingRules_Data.GetScalingRules_Rule>();
			for (int i = 0; i < _ctx.Length("GetScalingRules.Data.RuleList.Length"); i++) {
				GetScalingRulesResponse.GetScalingRules_Data.GetScalingRules_Rule rule = new GetScalingRulesResponse.GetScalingRules_Data.GetScalingRules_Rule();
				rule.AppId = _ctx.StringValue("GetScalingRules.Data.RuleList["+ i +"].AppId");
				rule.GroupId = _ctx.StringValue("GetScalingRules.Data.RuleList["+ i +"].GroupId");
				rule.Enable = _ctx.BooleanValue("GetScalingRules.Data.RuleList["+ i +"].Enable");
				rule.Mode = _ctx.StringValue("GetScalingRules.Data.RuleList["+ i +"].Mode");
				rule.Cond = _ctx.StringValue("GetScalingRules.Data.RuleList["+ i +"].Cond");
				rule.Cpu = _ctx.IntegerValue("GetScalingRules.Data.RuleList["+ i +"].Cpu");
				rule.Rt = _ctx.IntegerValue("GetScalingRules.Data.RuleList["+ i +"].Rt");
				rule.ResourceFrom = _ctx.StringValue("GetScalingRules.Data.RuleList["+ i +"].ResourceFrom");
				rule.Step = _ctx.IntegerValue("GetScalingRules.Data.RuleList["+ i +"].Step");
				rule.InstNum = _ctx.IntegerValue("GetScalingRules.Data.RuleList["+ i +"].InstNum");
				rule.LoadNum = _ctx.IntegerValue("GetScalingRules.Data.RuleList["+ i +"].LoadNum");
				rule.TemplateId = _ctx.StringValue("GetScalingRules.Data.RuleList["+ i +"].TemplateId");
				rule.TemplateVersion = _ctx.IntegerValue("GetScalingRules.Data.RuleList["+ i +"].TemplateVersion");
				rule.VpcId = _ctx.StringValue("GetScalingRules.Data.RuleList["+ i +"].VpcId");
				rule.MetricType = _ctx.StringValue("GetScalingRules.Data.RuleList["+ i +"].MetricType");
				rule.VSwitchIds = _ctx.StringValue("GetScalingRules.Data.RuleList["+ i +"].VSwitchIds");
				rule.MultiAzPolicy = _ctx.StringValue("GetScalingRules.Data.RuleList["+ i +"].MultiAzPolicy");
				rule.SpecId = _ctx.StringValue("GetScalingRules.Data.RuleList["+ i +"].SpecId");
				rule.Duration = _ctx.IntegerValue("GetScalingRules.Data.RuleList["+ i +"].Duration");
				rule.CreateTime = _ctx.LongValue("GetScalingRules.Data.RuleList["+ i +"].CreateTime");
				rule.UpdateTime = _ctx.LongValue("GetScalingRules.Data.RuleList["+ i +"].UpdateTime");

				data_ruleList.Add(rule);
			}
			data.RuleList = data_ruleList;
			getScalingRulesResponse.Data = data;
        
			return getScalingRulesResponse;
        }
    }
}
