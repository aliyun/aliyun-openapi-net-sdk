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
    public class ListQualityCheckSchemeResponseUnmarshaller
    {
        public static ListQualityCheckSchemeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQualityCheckSchemeResponse listQualityCheckSchemeResponse = new ListQualityCheckSchemeResponse();

			listQualityCheckSchemeResponse.HttpResponse = _ctx.HttpResponse;
			listQualityCheckSchemeResponse.RequestId = _ctx.StringValue("ListQualityCheckScheme.RequestId");
			listQualityCheckSchemeResponse.Success = _ctx.BooleanValue("ListQualityCheckScheme.Success");
			listQualityCheckSchemeResponse.ResultCountId = _ctx.StringValue("ListQualityCheckScheme.ResultCountId");
			listQualityCheckSchemeResponse.Code = _ctx.StringValue("ListQualityCheckScheme.Code");
			listQualityCheckSchemeResponse.Message = _ctx.StringValue("ListQualityCheckScheme.Message");
			listQualityCheckSchemeResponse.PageNumber = _ctx.IntegerValue("ListQualityCheckScheme.PageNumber");
			listQualityCheckSchemeResponse.PageSize = _ctx.IntegerValue("ListQualityCheckScheme.PageSize");
			listQualityCheckSchemeResponse.Count = _ctx.IntegerValue("ListQualityCheckScheme.Count");

			List<ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem> listQualityCheckSchemeResponse_data = new List<ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem>();
			for (int i = 0; i < _ctx.Length("ListQualityCheckScheme.Data.Length"); i++) {
				ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem dataItem = new ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem();
				dataItem.SchemeId = _ctx.LongValue("ListQualityCheckScheme.Data["+ i +"].SchemeId");
				dataItem.Name = _ctx.StringValue("ListQualityCheckScheme.Data["+ i +"].Name");
				dataItem.Description = _ctx.StringValue("ListQualityCheckScheme.Data["+ i +"].Description");
				dataItem.DataType = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].DataType");
				dataItem.Type = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].Type");
				dataItem.TemplateType = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].TemplateType");
				dataItem.Status = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].Status");
				dataItem.CreateUserName = _ctx.StringValue("ListQualityCheckScheme.Data["+ i +"].CreateUserName");
				dataItem.CreateTime = _ctx.StringValue("ListQualityCheckScheme.Data["+ i +"].CreateTime");
				dataItem.UpdateUserName = _ctx.StringValue("ListQualityCheckScheme.Data["+ i +"].UpdateUserName");
				dataItem.UpdateTime = _ctx.StringValue("ListQualityCheckScheme.Data["+ i +"].UpdateTime");
				dataItem.Version = _ctx.LongValue("ListQualityCheckScheme.Data["+ i +"].Version");

				List<ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem.ListQualityCheckScheme_SchemeCheckTypeListItem> dataItem_schemeCheckTypeList = new List<ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem.ListQualityCheckScheme_SchemeCheckTypeListItem>();
				for (int j = 0; j < _ctx.Length("ListQualityCheckScheme.Data["+ i +"].SchemeCheckTypeList.Length"); j++) {
					ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem.ListQualityCheckScheme_SchemeCheckTypeListItem schemeCheckTypeListItem = new ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem.ListQualityCheckScheme_SchemeCheckTypeListItem();
					schemeCheckTypeListItem.CheckType = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].SchemeCheckTypeList["+ j +"].CheckType");
					schemeCheckTypeListItem.Enable = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].SchemeCheckTypeList["+ j +"].Enable");
					schemeCheckTypeListItem.CheckName = _ctx.StringValue("ListQualityCheckScheme.Data["+ i +"].SchemeCheckTypeList["+ j +"].CheckName");
					schemeCheckTypeListItem.TargetType = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].SchemeCheckTypeList["+ j +"].TargetType");
					schemeCheckTypeListItem.Score = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].SchemeCheckTypeList["+ j +"].Score");

					dataItem_schemeCheckTypeList.Add(schemeCheckTypeListItem);
				}
				dataItem.SchemeCheckTypeList = dataItem_schemeCheckTypeList;

				List<ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem.ListQualityCheckScheme_RuleListItem> dataItem_ruleList = new List<ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem.ListQualityCheckScheme_RuleListItem>();
				for (int j = 0; j < _ctx.Length("ListQualityCheckScheme.Data["+ i +"].RuleList.Length"); j++) {
					ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem.ListQualityCheckScheme_RuleListItem ruleListItem = new ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem.ListQualityCheckScheme_RuleListItem();

					List<ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem.ListQualityCheckScheme_RuleListItem.ListQualityCheckScheme_RulesItem> ruleListItem_rules = new List<ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem.ListQualityCheckScheme_RuleListItem.ListQualityCheckScheme_RulesItem>();
					for (int k = 0; k < _ctx.Length("ListQualityCheckScheme.Data["+ i +"].RuleList["+ j +"].Rules.Length"); k++) {
						ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem.ListQualityCheckScheme_RuleListItem.ListQualityCheckScheme_RulesItem rulesItem = new ListQualityCheckSchemeResponse.ListQualityCheckScheme_DataItem.ListQualityCheckScheme_RuleListItem.ListQualityCheckScheme_RulesItem();
						rulesItem.Rid = _ctx.LongValue("ListQualityCheckScheme.Data["+ i +"].RuleList["+ j +"].Rules["+ k +"].Rid");
						rulesItem.Name = _ctx.StringValue("ListQualityCheckScheme.Data["+ i +"].RuleList["+ j +"].Rules["+ k +"].Name");
						rulesItem.RuleScoreType = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].RuleList["+ j +"].Rules["+ k +"].RuleScoreType");
						rulesItem.ScoreNum = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].RuleList["+ j +"].Rules["+ k +"].ScoreNum");
						rulesItem.ScoreType = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].RuleList["+ j +"].Rules["+ k +"].ScoreType");
						rulesItem.CheckType = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].RuleList["+ j +"].Rules["+ k +"].CheckType");
						rulesItem.TargetType = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].RuleList["+ j +"].Rules["+ k +"].TargetType");
						rulesItem.ScoreNumType = _ctx.IntegerValue("ListQualityCheckScheme.Data["+ i +"].RuleList["+ j +"].Rules["+ k +"].ScoreNumType");

						ruleListItem_rules.Add(rulesItem);
					}
					ruleListItem.Rules = ruleListItem_rules;

					dataItem_ruleList.Add(ruleListItem);
				}
				dataItem.RuleList = dataItem_ruleList;

				listQualityCheckSchemeResponse_data.Add(dataItem);
			}
			listQualityCheckSchemeResponse.Data = listQualityCheckSchemeResponse_data;
        
			return listQualityCheckSchemeResponse;
        }
    }
}
