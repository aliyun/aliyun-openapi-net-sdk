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
    public class GetRuleDetailResponseUnmarshaller
    {
        public static GetRuleDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRuleDetailResponse getRuleDetailResponse = new GetRuleDetailResponse();

			getRuleDetailResponse.HttpResponse = _ctx.HttpResponse;
			getRuleDetailResponse.Code = _ctx.StringValue("GetRuleDetail.Code");
			getRuleDetailResponse.Message = _ctx.StringValue("GetRuleDetail.Message");
			getRuleDetailResponse.RequestId = _ctx.StringValue("GetRuleDetail.RequestId");
			getRuleDetailResponse.Success = _ctx.BooleanValue("GetRuleDetail.Success");

			GetRuleDetailResponse.GetRuleDetail_Data data = new GetRuleDetailResponse.GetRuleDetail_Data();
			data.PageSize = _ctx.IntegerValue("GetRuleDetail.Data.PageSize");
			data.PageNumber = _ctx.IntegerValue("GetRuleDetail.Data.PageNumber");
			data.Count = _ctx.IntegerValue("GetRuleDetail.Data.Count");

			List<GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo> data_conditions = new List<GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo>();
			for (int i = 0; i < _ctx.Length("GetRuleDetail.Data.Conditions.Length"); i++) {
				GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo conditionBasicInfo = new GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo();
				conditionBasicInfo.ConditionInfoCid = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].ConditionInfoCid");
				conditionBasicInfo.OperLambda = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].OperLambda");

				GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo.GetRuleDetail_CheckRange checkRange = new GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo.GetRuleDetail_CheckRange();
				checkRange.Absolute = _ctx.BooleanValue("GetRuleDetail.Data.Conditions["+ i +"].CheckRange.Absolute");
				checkRange.Role = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].CheckRange.Role");

				GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo.GetRuleDetail_CheckRange.GetRuleDetail_Anchor anchor = new GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo.GetRuleDetail_CheckRange.GetRuleDetail_Anchor();
				anchor.HitTime = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].CheckRange.Anchor.HitTime");
				anchor.Location = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].CheckRange.Anchor.Location");
				anchor.AnchorCid = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].CheckRange.Anchor.AnchorCid");
				checkRange.Anchor = anchor;

				GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo.GetRuleDetail_CheckRange.GetRuleDetail_Range range = new GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo.GetRuleDetail_CheckRange.GetRuleDetail_Range();
				range.To = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].CheckRange.Range.To");
				range.From = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].CheckRange.Range.From");
				checkRange.Range = range;
				conditionBasicInfo.CheckRange = checkRange;

				List<GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo.GetRuleDetail_OperatorBasicInfo> conditionBasicInfo_operators = new List<GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo.GetRuleDetail_OperatorBasicInfo>();
				for (int j = 0; j < _ctx.Length("GetRuleDetail.Data.Conditions["+ i +"].Operators.Length"); j++) {
					GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo.GetRuleDetail_OperatorBasicInfo operatorBasicInfo = new GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo.GetRuleDetail_OperatorBasicInfo();
					operatorBasicInfo.Type = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Type");
					operatorBasicInfo.Oid = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Oid");
					operatorBasicInfo.OperName = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].OperName");

					GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo.GetRuleDetail_OperatorBasicInfo.GetRuleDetail_Param param = new GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_ConditionBasicInfo.GetRuleDetail_OperatorBasicInfo.GetRuleDetail_Param();
					param.DifferentRole = _ctx.BooleanValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.DifferentRole");
					param.Regex = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.Regex");
					param.TargetRole = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.TargetRole");
					param.VelocityInMint = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.VelocityInMint");
					param.Average = _ctx.BooleanValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.Average");
					param.KeywordExtension = _ctx.BooleanValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.KeywordExtension");
					param.Score = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.Score");
					param.NotRegex = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.NotRegex");
					param.CompareOperator = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.CompareOperator");
					param.DelayTime = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.DelayTime");
					param.KeywordMatchSize = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.KeywordMatchSize");
					param.HitTime = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.HitTime");
					param.BeginType = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.BeginType");
					param.Target = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.Target");
					param.MaxEmotionChangeValue = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.MaxEmotionChangeValue");
					param.Threshold = _ctx.FloatValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.Threshold");
					param.From = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.From");
					param.FromEnd = _ctx.BooleanValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.FromEnd");
					param.MinWordSize = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.MinWordSize");
					param.InSentence = _ctx.BooleanValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.InSentence");
					param.Phrase = _ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.Phrase");
					param.Similarity_threshold = _ctx.FloatValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.Similarity_threshold");
					param.CheckType = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.CheckType");
					param.Interval = _ctx.IntegerValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.Interval");
					param.ContextChatMatch = _ctx.BooleanValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.ContextChatMatch");

					List<string> param_excludes = new List<string>();
					for (int k = 0; k < _ctx.Length("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.Excludes.Length"); k++) {
						param_excludes.Add(_ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.Excludes["+ k +"]"));
					}
					param.Excludes = param_excludes;

					List<string> param_antModelInfo = new List<string>();
					for (int k = 0; k < _ctx.Length("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.AntModelInfo.Length"); k++) {
						param_antModelInfo.Add(_ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.AntModelInfo["+ k +"]"));
					}
					param.AntModelInfo = param_antModelInfo;

					List<string> param_pvalues = new List<string>();
					for (int k = 0; k < _ctx.Length("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.Pvalues.Length"); k++) {
						param_pvalues.Add(_ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.Pvalues["+ k +"]"));
					}
					param.Pvalues = param_pvalues;

					List<string> param_references = new List<string>();
					for (int k = 0; k < _ctx.Length("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.References.Length"); k++) {
						param_references.Add(_ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.References["+ k +"]"));
					}
					param.References = param_references;

					List<string> param_similarlySentences = new List<string>();
					for (int k = 0; k < _ctx.Length("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.SimilarlySentences.Length"); k++) {
						param_similarlySentences.Add(_ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.SimilarlySentences["+ k +"]"));
					}
					param.SimilarlySentences = param_similarlySentences;

					List<string> param_operKeyWords = new List<string>();
					for (int k = 0; k < _ctx.Length("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.OperKeyWords.Length"); k++) {
						param_operKeyWords.Add(_ctx.StringValue("GetRuleDetail.Data.Conditions["+ i +"].Operators["+ j +"].Param.OperKeyWords["+ k +"]"));
					}
					param.OperKeyWords = param_operKeyWords;
					operatorBasicInfo.Param = param;

					conditionBasicInfo_operators.Add(operatorBasicInfo);
				}
				conditionBasicInfo.Operators = conditionBasicInfo_operators;

				data_conditions.Add(conditionBasicInfo);
			}
			data.Conditions = data_conditions;

			List<GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_RuleBasicInfo> data_rules = new List<GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_RuleBasicInfo>();
			for (int i = 0; i < _ctx.Length("GetRuleDetail.Data.Rules.Length"); i++) {
				GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_RuleBasicInfo ruleBasicInfo = new GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_RuleBasicInfo();
				ruleBasicInfo.RuleLambda = _ctx.StringValue("GetRuleDetail.Data.Rules["+ i +"].RuleLambda");
				ruleBasicInfo.Rid = _ctx.StringValue("GetRuleDetail.Data.Rules["+ i +"].Rid");

				List<string> ruleBasicInfo_triggers = new List<string>();
				for (int j = 0; j < _ctx.Length("GetRuleDetail.Data.Rules["+ i +"].Triggers.Length"); j++) {
					ruleBasicInfo_triggers.Add(_ctx.StringValue("GetRuleDetail.Data.Rules["+ i +"].Triggers["+ j +"]"));
				}
				ruleBasicInfo.Triggers = ruleBasicInfo_triggers;

				List<GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_RuleBasicInfo.GetRuleDetail_BusinessCategoryBasicInfo> ruleBasicInfo_businessCategories = new List<GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_RuleBasicInfo.GetRuleDetail_BusinessCategoryBasicInfo>();
				for (int j = 0; j < _ctx.Length("GetRuleDetail.Data.Rules["+ i +"].BusinessCategories.Length"); j++) {
					GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_RuleBasicInfo.GetRuleDetail_BusinessCategoryBasicInfo businessCategoryBasicInfo = new GetRuleDetailResponse.GetRuleDetail_Data.GetRuleDetail_RuleBasicInfo.GetRuleDetail_BusinessCategoryBasicInfo();
					businessCategoryBasicInfo.BusinessName = _ctx.StringValue("GetRuleDetail.Data.Rules["+ i +"].BusinessCategories["+ j +"].BusinessName");
					businessCategoryBasicInfo.ServiceType = _ctx.IntegerValue("GetRuleDetail.Data.Rules["+ i +"].BusinessCategories["+ j +"].ServiceType");
					businessCategoryBasicInfo.Bid = _ctx.IntegerValue("GetRuleDetail.Data.Rules["+ i +"].BusinessCategories["+ j +"].Bid");

					ruleBasicInfo_businessCategories.Add(businessCategoryBasicInfo);
				}
				ruleBasicInfo.BusinessCategories = ruleBasicInfo_businessCategories;

				data_rules.Add(ruleBasicInfo);
			}
			data.Rules = data_rules;
			getRuleDetailResponse.Data = data;
        
			return getRuleDetailResponse;
        }
    }
}
