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
    public class ConfigDataSetResponseUnmarshaller
    {
        public static ConfigDataSetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ConfigDataSetResponse configDataSetResponse = new ConfigDataSetResponse();

			configDataSetResponse.HttpResponse = _ctx.HttpResponse;
			configDataSetResponse.Code = _ctx.StringValue("ConfigDataSet.Code");
			configDataSetResponse.Message = _ctx.StringValue("ConfigDataSet.Message");
			configDataSetResponse.RequestId = _ctx.StringValue("ConfigDataSet.RequestId");
			configDataSetResponse.Success = _ctx.BooleanValue("ConfigDataSet.Success");

			ConfigDataSetResponse.ConfigDataSet_Data data = new ConfigDataSetResponse.ConfigDataSet_Data();
			data.RoleConfigStatus = _ctx.IntegerValue("ConfigDataSet.Data.RoleConfigStatus");
			data.ChannelType = _ctx.IntegerValue("ConfigDataSet.Data.ChannelType");
			data.JudgeType = _ctx.IntegerValue("ConfigDataSet.Data.JudgeType");
			data.SetId = _ctx.LongValue("ConfigDataSet.Data.SetId");

			ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo ruleInfo = new ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo();

			List<ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo> ruleInfo_conditions = new List<ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo>();
			for (int i = 0; i < _ctx.Length("ConfigDataSet.Data.RuleInfo.Conditions.Length"); i++) {
				ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo conditionBasicInfo = new ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo();
				conditionBasicInfo.Lambda = _ctx.StringValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].Lambda");
				conditionBasicInfo.Cid = _ctx.StringValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].Cid");

				ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo.ConfigDataSet_CheckRange checkRange = new ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo.ConfigDataSet_CheckRange();
				checkRange.Role = _ctx.StringValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].CheckRange.Role");
				checkRange.RoleId = _ctx.IntegerValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].CheckRange.RoleId");

				ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo.ConfigDataSet_CheckRange.ConfigDataSet_Anchor anchor = new ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo.ConfigDataSet_CheckRange.ConfigDataSet_Anchor();
				anchor.HitTime = _ctx.IntegerValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].CheckRange.Anchor.HitTime");
				anchor.Cid = _ctx.StringValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].CheckRange.Anchor.Cid");
				anchor.Location = _ctx.StringValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].CheckRange.Anchor.Location");
				checkRange.Anchor = anchor;

				ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo.ConfigDataSet_CheckRange.ConfigDataSet_Range range = new ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo.ConfigDataSet_CheckRange.ConfigDataSet_Range();
				range.To = _ctx.IntegerValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].CheckRange.Range.To");
				range.From = _ctx.IntegerValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].CheckRange.Range.From");
				checkRange.Range = range;
				conditionBasicInfo.CheckRange = checkRange;

				List<ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo.ConfigDataSet_OperatorBasicInfo> conditionBasicInfo_operators = new List<ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo.ConfigDataSet_OperatorBasicInfo>();
				for (int j = 0; j < _ctx.Length("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].Operators.Length"); j++) {
					ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo.ConfigDataSet_OperatorBasicInfo operatorBasicInfo = new ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo.ConfigDataSet_OperatorBasicInfo();
					operatorBasicInfo.Type = _ctx.StringValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].Operators["+ j +"].Type");
					operatorBasicInfo.Oid = _ctx.StringValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].Operators["+ j +"].Oid");

					ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo.ConfigDataSet_OperatorBasicInfo.ConfigDataSet_Param param = new ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_ConditionBasicInfo.ConfigDataSet_OperatorBasicInfo.ConfigDataSet_Param();
					param.InSentence = _ctx.BooleanValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].Operators["+ j +"].Param.InSentence");

					List<string> param_keywords = new List<string>();
					for (int k = 0; k < _ctx.Length("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].Operators["+ j +"].Param.Keywords.Length"); k++) {
						param_keywords.Add(_ctx.StringValue("ConfigDataSet.Data.RuleInfo.Conditions["+ i +"].Operators["+ j +"].Param.Keywords["+ k +"]"));
					}
					param.Keywords = param_keywords;
					operatorBasicInfo.Param = param;

					conditionBasicInfo_operators.Add(operatorBasicInfo);
				}
				conditionBasicInfo.Operators = conditionBasicInfo_operators;

				ruleInfo_conditions.Add(conditionBasicInfo);
			}
			ruleInfo.Conditions = ruleInfo_conditions;

			List<ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_RuleBasicInfo> ruleInfo_rules = new List<ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_RuleBasicInfo>();
			for (int i = 0; i < _ctx.Length("ConfigDataSet.Data.RuleInfo.Rules.Length"); i++) {
				ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_RuleBasicInfo ruleBasicInfo = new ConfigDataSetResponse.ConfigDataSet_Data.ConfigDataSet_RuleInfo.ConfigDataSet_RuleBasicInfo();
				ruleBasicInfo.Lambda = _ctx.StringValue("ConfigDataSet.Data.RuleInfo.Rules["+ i +"].Lambda");
				ruleBasicInfo.ExternalProperty = _ctx.IntegerValue("ConfigDataSet.Data.RuleInfo.Rules["+ i +"].ExternalProperty");
				ruleBasicInfo.Rid = _ctx.StringValue("ConfigDataSet.Data.RuleInfo.Rules["+ i +"].Rid");

				ruleInfo_rules.Add(ruleBasicInfo);
			}
			ruleInfo.Rules = ruleInfo_rules;
			data.RuleInfo = ruleInfo;
			configDataSetResponse.Data = data;
        
			return configDataSetResponse;
        }
    }
}
