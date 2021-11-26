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
    public class GetRuleResponseUnmarshaller
    {
        public static GetRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRuleResponse getRuleResponse = new GetRuleResponse();

			getRuleResponse.HttpResponse = _ctx.HttpResponse;
			getRuleResponse.Code = _ctx.StringValue("GetRule.Code");
			getRuleResponse.Message = _ctx.StringValue("GetRule.Message");
			getRuleResponse.RequestId = _ctx.StringValue("GetRule.RequestId");
			getRuleResponse.Success = _ctx.BooleanValue("GetRule.Success");

			GetRuleResponse.GetRule_Data data = new GetRuleResponse.GetRule_Data();

			List<GetRuleResponse.GetRule_Data.GetRule_RuleInfo> data_rules = new List<GetRuleResponse.GetRule_Data.GetRule_RuleInfo>();
			for (int i = 0; i < _ctx.Length("GetRule.Data.Rules.Length"); i++) {
				GetRuleResponse.GetRule_Data.GetRule_RuleInfo ruleInfo = new GetRuleResponse.GetRule_Data.GetRule_RuleInfo();
				ruleInfo.Status = _ctx.IntegerValue("GetRule.Data.Rules["+ i +"].Status");
				ruleInfo.Type = _ctx.IntegerValue("GetRule.Data.Rules["+ i +"].Type");
				ruleInfo.ScoreSubId = _ctx.IntegerValue("GetRule.Data.Rules["+ i +"].ScoreSubId");
				ruleInfo.IsOnline = _ctx.IntegerValue("GetRule.Data.Rules["+ i +"].IsOnline");
				ruleInfo.CreateTime = _ctx.StringValue("GetRule.Data.Rules["+ i +"].CreateTime");
				ruleInfo.CreateEmpid = _ctx.StringValue("GetRule.Data.Rules["+ i +"].CreateEmpid");
				ruleInfo.LastUpdateEmpid = _ctx.StringValue("GetRule.Data.Rules["+ i +"].LastUpdateEmpid");
				ruleInfo.IsDelete = _ctx.IntegerValue("GetRule.Data.Rules["+ i +"].IsDelete");
				ruleInfo.Rid = _ctx.StringValue("GetRule.Data.Rules["+ i +"].Rid");
				ruleInfo.RuleScoreType = _ctx.IntegerValue("GetRule.Data.Rules["+ i +"].RuleScoreType");
				ruleInfo.EndTime = _ctx.StringValue("GetRule.Data.Rules["+ i +"].EndTime");
				ruleInfo.Weight = _ctx.StringValue("GetRule.Data.Rules["+ i +"].Weight");
				ruleInfo.StartTime = _ctx.StringValue("GetRule.Data.Rules["+ i +"].StartTime");
				ruleInfo.RuleLambda = _ctx.StringValue("GetRule.Data.Rules["+ i +"].RuleLambda");
				ruleInfo.ScoreSubName = _ctx.StringValue("GetRule.Data.Rules["+ i +"].ScoreSubName");
				ruleInfo.AutoReview = _ctx.IntegerValue("GetRule.Data.Rules["+ i +"].AutoReview");
				ruleInfo.Comments = _ctx.StringValue("GetRule.Data.Rules["+ i +"].Comments");
				ruleInfo.LastUpdateTime = _ctx.StringValue("GetRule.Data.Rules["+ i +"].LastUpdateTime");
				ruleInfo.ScoreName = _ctx.StringValue("GetRule.Data.Rules["+ i +"].ScoreName");
				ruleInfo.Name = _ctx.StringValue("GetRule.Data.Rules["+ i +"].Name");
				ruleInfo.ScoreId = _ctx.IntegerValue("GetRule.Data.Rules["+ i +"].ScoreId");

				List<string> ruleInfo_businessCategoryNameList = new List<string>();
				for (int j = 0; j < _ctx.Length("GetRule.Data.Rules["+ i +"].BusinessCategoryNameList.Length"); j++) {
					ruleInfo_businessCategoryNameList.Add(_ctx.StringValue("GetRule.Data.Rules["+ i +"].BusinessCategoryNameList["+ j +"]"));
				}
				ruleInfo.BusinessCategoryNameList = ruleInfo_businessCategoryNameList;

				data_rules.Add(ruleInfo);
			}
			data.Rules = data_rules;
			getRuleResponse.Data = data;
        
			return getRuleResponse;
        }
    }
}
