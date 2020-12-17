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
    public class GetSkillGroupConfigResponseUnmarshaller
    {
        public static GetSkillGroupConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSkillGroupConfigResponse getSkillGroupConfigResponse = new GetSkillGroupConfigResponse();

			getSkillGroupConfigResponse.HttpResponse = _ctx.HttpResponse;
			getSkillGroupConfigResponse.RequestId = _ctx.StringValue("GetSkillGroupConfig.RequestId");
			getSkillGroupConfigResponse.Success = _ctx.BooleanValue("GetSkillGroupConfig.Success");
			getSkillGroupConfigResponse.Code = _ctx.StringValue("GetSkillGroupConfig.Code");
			getSkillGroupConfigResponse.Message = _ctx.StringValue("GetSkillGroupConfig.Message");

			GetSkillGroupConfigResponse.GetSkillGroupConfig_Data data = new GetSkillGroupConfigResponse.GetSkillGroupConfig_Data();
			data.Id = _ctx.LongValue("GetSkillGroupConfig.Data.Id");
			data.InstanceId = _ctx.StringValue("GetSkillGroupConfig.Data.InstanceId");
			data.ModelId = _ctx.LongValue("GetSkillGroupConfig.Data.ModelId");
			data.ModelName = _ctx.StringValue("GetSkillGroupConfig.Data.ModelName");
			data.Name = _ctx.StringValue("GetSkillGroupConfig.Data.Name");
			data.Rid = _ctx.StringValue("GetSkillGroupConfig.Data.Rid");
			data.SkillGroupId = _ctx.StringValue("GetSkillGroupConfig.Data.SkillGroupId");
			data.SkillGroupName = _ctx.StringValue("GetSkillGroupConfig.Data.SkillGroupName");
			data.Status = _ctx.IntegerValue("GetSkillGroupConfig.Data.Status");
			data.Type = _ctx.IntegerValue("GetSkillGroupConfig.Data.Type");
			data.VocabId = _ctx.LongValue("GetSkillGroupConfig.Data.VocabId");
			data.VocabName = _ctx.StringValue("GetSkillGroupConfig.Data.VocabName");
			data.CreateTime = _ctx.StringValue("GetSkillGroupConfig.Data.CreateTime");
			data.UpdateTime = _ctx.StringValue("GetSkillGroupConfig.Data.UpdateTime");
			data.QualityCheckType = _ctx.IntegerValue("GetSkillGroupConfig.Data.QualityCheckType");
			data.AllContentQualityCheck = _ctx.IntegerValue("GetSkillGroupConfig.Data.AllContentQualityCheck");
			data.AllRids = _ctx.StringValue("GetSkillGroupConfig.Data.AllRids");
			data.SkillGroupFrom = _ctx.IntegerValue("GetSkillGroupConfig.Data.SkillGroupFrom");

			List<GetSkillGroupConfigResponse.GetSkillGroupConfig_Data.GetSkillGroupConfig_RuleNameInfo> data_ruleList = new List<GetSkillGroupConfigResponse.GetSkillGroupConfig_Data.GetSkillGroupConfig_RuleNameInfo>();
			for (int i = 0; i < _ctx.Length("GetSkillGroupConfig.Data.RuleList.Length"); i++) {
				GetSkillGroupConfigResponse.GetSkillGroupConfig_Data.GetSkillGroupConfig_RuleNameInfo ruleNameInfo = new GetSkillGroupConfigResponse.GetSkillGroupConfig_Data.GetSkillGroupConfig_RuleNameInfo();
				ruleNameInfo.Rid = _ctx.LongValue("GetSkillGroupConfig.Data.RuleList["+ i +"].Rid");
				ruleNameInfo.RuleName = _ctx.StringValue("GetSkillGroupConfig.Data.RuleList["+ i +"].RuleName");

				data_ruleList.Add(ruleNameInfo);
			}
			data.RuleList = data_ruleList;

			List<GetSkillGroupConfigResponse.GetSkillGroupConfig_Data.GetSkillGroupConfig_RuleNameInfo> data_allRuleList = new List<GetSkillGroupConfigResponse.GetSkillGroupConfig_Data.GetSkillGroupConfig_RuleNameInfo>();
			for (int i = 0; i < _ctx.Length("GetSkillGroupConfig.Data.AllRuleList.Length"); i++) {
				GetSkillGroupConfigResponse.GetSkillGroupConfig_Data.GetSkillGroupConfig_RuleNameInfo ruleNameInfo = new GetSkillGroupConfigResponse.GetSkillGroupConfig_Data.GetSkillGroupConfig_RuleNameInfo();
				ruleNameInfo.Rid = _ctx.LongValue("GetSkillGroupConfig.Data.AllRuleList["+ i +"].Rid");
				ruleNameInfo.RuleName = _ctx.StringValue("GetSkillGroupConfig.Data.AllRuleList["+ i +"].RuleName");

				data_allRuleList.Add(ruleNameInfo);
			}
			data.AllRuleList = data_allRuleList;
			getSkillGroupConfigResponse.Data = data;
        
			return getSkillGroupConfigResponse;
        }
    }
}
