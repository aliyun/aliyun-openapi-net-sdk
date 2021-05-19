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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class ListTaskAssignRulesResponseUnmarshaller
    {
        public static ListTaskAssignRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTaskAssignRulesResponse listTaskAssignRulesResponse = new ListTaskAssignRulesResponse();

			listTaskAssignRulesResponse.HttpResponse = _ctx.HttpResponse;
			listTaskAssignRulesResponse.RequestId = _ctx.StringValue("ListTaskAssignRules.RequestId");
			listTaskAssignRulesResponse.Success = _ctx.BooleanValue("ListTaskAssignRules.Success");
			listTaskAssignRulesResponse.Code = _ctx.StringValue("ListTaskAssignRules.Code");
			listTaskAssignRulesResponse.Message = _ctx.StringValue("ListTaskAssignRules.Message");
			listTaskAssignRulesResponse.PageNumber = _ctx.IntegerValue("ListTaskAssignRules.PageNumber");
			listTaskAssignRulesResponse.PageSize = _ctx.IntegerValue("ListTaskAssignRules.PageSize");
			listTaskAssignRulesResponse.Count = _ctx.IntegerValue("ListTaskAssignRules.Count");

			List<ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo> listTaskAssignRulesResponse_data = new List<ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo>();
			for (int i = 0; i < _ctx.Length("ListTaskAssignRules.Data.Length"); i++) {
				ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo taskAssignRuleInfo = new ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo();
				taskAssignRuleInfo.RuleId = _ctx.LongValue("ListTaskAssignRules.Data["+ i +"].RuleId");
				taskAssignRuleInfo.Enabled = _ctx.IntegerValue("ListTaskAssignRules.Data["+ i +"].Enabled");
				taskAssignRuleInfo.CallType = _ctx.IntegerValue("ListTaskAssignRules.Data["+ i +"].CallType");
				taskAssignRuleInfo.Priority = _ctx.IntegerValue("ListTaskAssignRules.Data["+ i +"].Priority");
				taskAssignRuleInfo.DurationMin = _ctx.IntegerValue("ListTaskAssignRules.Data["+ i +"].DurationMin");
				taskAssignRuleInfo.DurationMax = _ctx.IntegerValue("ListTaskAssignRules.Data["+ i +"].DurationMax");
				taskAssignRuleInfo.CreateTime = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].CreateTime");
				taskAssignRuleInfo.UpdateTime = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].UpdateTime");
				taskAssignRuleInfo.AgentsStr = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].AgentsStr");
				taskAssignRuleInfo.SkillGroupsStr = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].SkillGroupsStr");
				taskAssignRuleInfo.CallTimeStart = _ctx.LongValue("ListTaskAssignRules.Data["+ i +"].CallTimeStart");
				taskAssignRuleInfo.CallTimeEnd = _ctx.LongValue("ListTaskAssignRules.Data["+ i +"].CallTimeEnd");
				taskAssignRuleInfo.AssignmentType = _ctx.IntegerValue("ListTaskAssignRules.Data["+ i +"].AssignmentType");
				taskAssignRuleInfo.RuleName = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].RuleName");

				ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_SamplingMode samplingMode = new ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_SamplingMode();
				samplingMode.Dimension = _ctx.IntegerValue("ListTaskAssignRules.Data["+ i +"].SamplingMode.Dimension");
				samplingMode.Proportion = _ctx.FloatValue("ListTaskAssignRules.Data["+ i +"].SamplingMode.Proportion");
				samplingMode.Limit = _ctx.IntegerValue("ListTaskAssignRules.Data["+ i +"].SamplingMode.Limit");
				samplingMode.NumberOfDraws = _ctx.IntegerValue("ListTaskAssignRules.Data["+ i +"].SamplingMode.NumberOfDraws");
				samplingMode.AnyNumberOfDraws = _ctx.IntegerValue("ListTaskAssignRules.Data["+ i +"].SamplingMode.AnyNumberOfDraws");
				samplingMode.Designated = _ctx.BooleanValue("ListTaskAssignRules.Data["+ i +"].SamplingMode.Designated");
				samplingMode.RandomInspectionNumber = _ctx.IntegerValue("ListTaskAssignRules.Data["+ i +"].SamplingMode.RandomInspectionNumber");

				List<ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_SamplingMode.ListTaskAssignRules_SamplingModeAgent> samplingMode_samplingModeAgents = new List<ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_SamplingMode.ListTaskAssignRules_SamplingModeAgent>();
				for (int j = 0; j < _ctx.Length("ListTaskAssignRules.Data["+ i +"].SamplingMode.SamplingModeAgents.Length"); j++) {
					ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_SamplingMode.ListTaskAssignRules_SamplingModeAgent samplingModeAgent = new ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_SamplingMode.ListTaskAssignRules_SamplingModeAgent();
					samplingModeAgent.AgentId = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].SamplingMode.SamplingModeAgents["+ j +"].AgentId");
					samplingModeAgent.AgentName = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].SamplingMode.SamplingModeAgents["+ j +"].AgentName");

					samplingMode_samplingModeAgents.Add(samplingModeAgent);
				}
				samplingMode.SamplingModeAgents = samplingMode_samplingModeAgents;
				taskAssignRuleInfo.SamplingMode = samplingMode;

				List<ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_Agent> taskAssignRuleInfo_agents = new List<ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_Agent>();
				for (int j = 0; j < _ctx.Length("ListTaskAssignRules.Data["+ i +"].Agents.Length"); j++) {
					ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_Agent agent = new ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_Agent();
					agent.AgentId = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].Agents["+ j +"].AgentId");
					agent.AgentName = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].Agents["+ j +"].AgentName");

					taskAssignRuleInfo_agents.Add(agent);
				}
				taskAssignRuleInfo.Agents = taskAssignRuleInfo_agents;

				List<ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_SkillGroup> taskAssignRuleInfo_skillGroups = new List<ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_SkillGroup>();
				for (int j = 0; j < _ctx.Length("ListTaskAssignRules.Data["+ i +"].SkillGroups.Length"); j++) {
					ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_SkillGroup skillGroup = new ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_SkillGroup();
					skillGroup.SkillId = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].SkillGroups["+ j +"].SkillId");
					skillGroup.SkillName = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].SkillGroups["+ j +"].SkillName");

					taskAssignRuleInfo_skillGroups.Add(skillGroup);
				}
				taskAssignRuleInfo.SkillGroups = taskAssignRuleInfo_skillGroups;

				List<ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_Reviewer> taskAssignRuleInfo_reviewers = new List<ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_Reviewer>();
				for (int j = 0; j < _ctx.Length("ListTaskAssignRules.Data["+ i +"].Reviewers.Length"); j++) {
					ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_Reviewer reviewer = new ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_Reviewer();
					reviewer.ReviewerId = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].Reviewers["+ j +"].ReviewerId");
					reviewer.ReviewerName = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].Reviewers["+ j +"].ReviewerName");

					taskAssignRuleInfo_reviewers.Add(reviewer);
				}
				taskAssignRuleInfo.Reviewers = taskAssignRuleInfo_reviewers;

				List<ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_RuleBasicInfo> taskAssignRuleInfo_rules = new List<ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_RuleBasicInfo>();
				for (int j = 0; j < _ctx.Length("ListTaskAssignRules.Data["+ i +"].Rules.Length"); j++) {
					ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_RuleBasicInfo ruleBasicInfo = new ListTaskAssignRulesResponse.ListTaskAssignRules_TaskAssignRuleInfo.ListTaskAssignRules_RuleBasicInfo();
					ruleBasicInfo.Rid = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].Rules["+ j +"].Rid");
					ruleBasicInfo.Name = _ctx.StringValue("ListTaskAssignRules.Data["+ i +"].Rules["+ j +"].Name");

					taskAssignRuleInfo_rules.Add(ruleBasicInfo);
				}
				taskAssignRuleInfo.Rules = taskAssignRuleInfo_rules;

				listTaskAssignRulesResponse_data.Add(taskAssignRuleInfo);
			}
			listTaskAssignRulesResponse.Data = listTaskAssignRulesResponse_data;
        
			return listTaskAssignRulesResponse;
        }
    }
}
