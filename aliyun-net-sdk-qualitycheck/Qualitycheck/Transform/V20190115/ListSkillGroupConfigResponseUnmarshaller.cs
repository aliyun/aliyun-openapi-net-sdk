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
    public class ListSkillGroupConfigResponseUnmarshaller
    {
        public static ListSkillGroupConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSkillGroupConfigResponse listSkillGroupConfigResponse = new ListSkillGroupConfigResponse();

			listSkillGroupConfigResponse.HttpResponse = _ctx.HttpResponse;
			listSkillGroupConfigResponse.RequestId = _ctx.StringValue("ListSkillGroupConfig.RequestId");
			listSkillGroupConfigResponse.Success = _ctx.BooleanValue("ListSkillGroupConfig.Success");
			listSkillGroupConfigResponse.Code = _ctx.StringValue("ListSkillGroupConfig.Code");
			listSkillGroupConfigResponse.Message = _ctx.StringValue("ListSkillGroupConfig.Message");

			List<ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig> listSkillGroupConfigResponse_data = new List<ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig>();
			for (int i = 0; i < _ctx.Length("ListSkillGroupConfig.Data.Length"); i++) {
				ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig skillGroupConfig = new ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig();
				skillGroupConfig.Id = _ctx.LongValue("ListSkillGroupConfig.Data["+ i +"].Id");
				skillGroupConfig.InstanceId = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].InstanceId");
				skillGroupConfig.ModelId = _ctx.LongValue("ListSkillGroupConfig.Data["+ i +"].ModelId");
				skillGroupConfig.ModelName = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].ModelName");
				skillGroupConfig.Name = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].Name");
				skillGroupConfig.Rid = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].Rid");
				skillGroupConfig.SkillGroupId = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].SkillGroupId");
				skillGroupConfig.SkillGroupName = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].SkillGroupName");
				skillGroupConfig.Status = _ctx.IntegerValue("ListSkillGroupConfig.Data["+ i +"].Status");
				skillGroupConfig.Type = _ctx.IntegerValue("ListSkillGroupConfig.Data["+ i +"].Type");
				skillGroupConfig.VocabId = _ctx.LongValue("ListSkillGroupConfig.Data["+ i +"].VocabId");
				skillGroupConfig.VocabName = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].VocabName");
				skillGroupConfig.CreateTime = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].CreateTime");
				skillGroupConfig.UpdateTime = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].UpdateTime");
				skillGroupConfig.QualityCheckType = _ctx.IntegerValue("ListSkillGroupConfig.Data["+ i +"].QualityCheckType");
				skillGroupConfig.AllContentQualityCheck = _ctx.IntegerValue("ListSkillGroupConfig.Data["+ i +"].AllContentQualityCheck");
				skillGroupConfig.AllRids = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].AllRids");
				skillGroupConfig.SkillGroupFrom = _ctx.IntegerValue("ListSkillGroupConfig.Data["+ i +"].SkillGroupFrom");
				skillGroupConfig.ScreenSwitch = _ctx.BooleanValue("ListSkillGroupConfig.Data["+ i +"].ScreenSwitch");

				List<ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig.ListSkillGroupConfig_RuleNameInfo> skillGroupConfig_ruleList = new List<ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig.ListSkillGroupConfig_RuleNameInfo>();
				for (int j = 0; j < _ctx.Length("ListSkillGroupConfig.Data["+ i +"].RuleList.Length"); j++) {
					ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig.ListSkillGroupConfig_RuleNameInfo ruleNameInfo = new ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig.ListSkillGroupConfig_RuleNameInfo();
					ruleNameInfo.Rid = _ctx.LongValue("ListSkillGroupConfig.Data["+ i +"].RuleList["+ j +"].Rid");
					ruleNameInfo.RuleName = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].RuleList["+ j +"].RuleName");

					skillGroupConfig_ruleList.Add(ruleNameInfo);
				}
				skillGroupConfig.RuleList = skillGroupConfig_ruleList;

				List<ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig.ListSkillGroupConfig_RuleNameInfo> skillGroupConfig_allRuleList = new List<ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig.ListSkillGroupConfig_RuleNameInfo>();
				for (int j = 0; j < _ctx.Length("ListSkillGroupConfig.Data["+ i +"].AllRuleList.Length"); j++) {
					ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig.ListSkillGroupConfig_RuleNameInfo ruleNameInfo = new ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig.ListSkillGroupConfig_RuleNameInfo();
					ruleNameInfo.Rid = _ctx.LongValue("ListSkillGroupConfig.Data["+ i +"].AllRuleList["+ j +"].Rid");
					ruleNameInfo.RuleName = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].AllRuleList["+ j +"].RuleName");

					skillGroupConfig_allRuleList.Add(ruleNameInfo);
				}
				skillGroupConfig.AllRuleList = skillGroupConfig_allRuleList;

				List<ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig.ListSkillGroupConfig_SkillGroupScreen> skillGroupConfig_skillGroupScreens = new List<ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig.ListSkillGroupConfig_SkillGroupScreen>();
				for (int j = 0; j < _ctx.Length("ListSkillGroupConfig.Data["+ i +"].SkillGroupScreens.Length"); j++) {
					ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig.ListSkillGroupConfig_SkillGroupScreen skillGroupScreen = new ListSkillGroupConfigResponse.ListSkillGroupConfig_SkillGroupConfig.ListSkillGroupConfig_SkillGroupScreen();
					skillGroupScreen.Name = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].SkillGroupScreens["+ j +"].Name");
					skillGroupScreen.DataType = _ctx.IntegerValue("ListSkillGroupConfig.Data["+ i +"].SkillGroupScreens["+ j +"].DataType");
					skillGroupScreen.Symbol = _ctx.IntegerValue("ListSkillGroupConfig.Data["+ i +"].SkillGroupScreens["+ j +"].Symbol");
					skillGroupScreen._Value = _ctx.StringValue("ListSkillGroupConfig.Data["+ i +"].SkillGroupScreens["+ j +"].Value");

					skillGroupConfig_skillGroupScreens.Add(skillGroupScreen);
				}
				skillGroupConfig.SkillGroupScreens = skillGroupConfig_skillGroupScreens;

				listSkillGroupConfigResponse_data.Add(skillGroupConfig);
			}
			listSkillGroupConfigResponse.Data = listSkillGroupConfigResponse_data;
        
			return listSkillGroupConfigResponse;
        }
    }
}
