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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListQualityRulesResponseUnmarshaller
    {
        public static ListQualityRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQualityRulesResponse listQualityRulesResponse = new ListQualityRulesResponse();

			listQualityRulesResponse.HttpResponse = _ctx.HttpResponse;
			listQualityRulesResponse.HttpStatusCode = _ctx.IntegerValue("ListQualityRules.HttpStatusCode");
			listQualityRulesResponse.RequestId = _ctx.StringValue("ListQualityRules.RequestId");
			listQualityRulesResponse.ErrorMessage = _ctx.StringValue("ListQualityRules.ErrorMessage");
			listQualityRulesResponse.Success = _ctx.BooleanValue("ListQualityRules.Success");
			listQualityRulesResponse.ErrorCode = _ctx.StringValue("ListQualityRules.ErrorCode");

			ListQualityRulesResponse.ListQualityRules_Data data = new ListQualityRulesResponse.ListQualityRules_Data();
			data.PageNumber = _ctx.IntegerValue("ListQualityRules.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListQualityRules.Data.PageSize");
			data.TotalCount = _ctx.LongValue("ListQualityRules.Data.TotalCount");

			List<ListQualityRulesResponse.ListQualityRules_Data.ListQualityRules_RulesItem> data_rules = new List<ListQualityRulesResponse.ListQualityRules_Data.ListQualityRules_RulesItem>();
			for (int i = 0; i < _ctx.Length("ListQualityRules.Data.Rules.Length"); i++) {
				ListQualityRulesResponse.ListQualityRules_Data.ListQualityRules_RulesItem rulesItem = new ListQualityRulesResponse.ListQualityRules_Data.ListQualityRules_RulesItem();
				rulesItem.BlockType = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].BlockType");
				rulesItem.OnDutyAccountName = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].OnDutyAccountName");
				rulesItem.Property = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].Property");
				rulesItem.WarningThreshold = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].WarningThreshold");
				rulesItem.TableName = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].TableName");
				rulesItem.OnDuty = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].OnDuty");
				rulesItem.Comment = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].Comment");
				rulesItem.RuleCheckerRelationId = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].RuleCheckerRelationId");
				rulesItem.FixCheck = _ctx.BooleanValue("ListQualityRules.Data.Rules["+ i +"].FixCheck");
				rulesItem.MethodId = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].MethodId");
				rulesItem.TemplateName = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].TemplateName");
				rulesItem.Trend = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].Trend");
				rulesItem.HistoryWarningThreshold = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].HistoryWarningThreshold");
				rulesItem.RuleType = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].RuleType");
				rulesItem.MatchExpression = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].MatchExpression");
				rulesItem.ProjectName = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].ProjectName");
				rulesItem.PropertyKey = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].PropertyKey");
				rulesItem.CriticalThreshold = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].CriticalThreshold");
				rulesItem.HistoryCriticalThreshold = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].HistoryCriticalThreshold");
				rulesItem.MethodName = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].MethodName");
				rulesItem.CheckerId = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].CheckerId");
				rulesItem.EntityId = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].EntityId");
				rulesItem.ExpectValue = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].ExpectValue");
				rulesItem.TemplateId = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].TemplateId");
				rulesItem.Id = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].Id");
				rulesItem.RuleName = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].RuleName");

				data_rules.Add(rulesItem);
			}
			data.Rules = data_rules;
			listQualityRulesResponse.Data = data;
        
			return listQualityRulesResponse;
        }
    }
}
