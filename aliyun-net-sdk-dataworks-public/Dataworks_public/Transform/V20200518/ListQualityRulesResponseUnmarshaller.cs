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
			listQualityRulesResponse.ErrorCode = _ctx.StringValue("ListQualityRules.ErrorCode");
			listQualityRulesResponse.Success = _ctx.BooleanValue("ListQualityRules.Success");
			listQualityRulesResponse.ErrorMessage = _ctx.StringValue("ListQualityRules.ErrorMessage");
			listQualityRulesResponse.HttpStatusCode = _ctx.IntegerValue("ListQualityRules.HttpStatusCode");
			listQualityRulesResponse.RequestId = _ctx.StringValue("ListQualityRules.RequestId");

			ListQualityRulesResponse.ListQualityRules_Data data = new ListQualityRulesResponse.ListQualityRules_Data();
			data.TotalCount = _ctx.LongValue("ListQualityRules.Data.TotalCount");
			data.PageNumber = _ctx.IntegerValue("ListQualityRules.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListQualityRules.Data.PageSize");

			List<ListQualityRulesResponse.ListQualityRules_Data.ListQualityRules_RulesItem> data_rules = new List<ListQualityRulesResponse.ListQualityRules_Data.ListQualityRules_RulesItem>();
			for (int i = 0; i < _ctx.Length("ListQualityRules.Data.Rules.Length"); i++) {
				ListQualityRulesResponse.ListQualityRules_Data.ListQualityRules_RulesItem rulesItem = new ListQualityRulesResponse.ListQualityRules_Data.ListQualityRules_RulesItem();
				rulesItem.ProjectName = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].ProjectName");
				rulesItem.TableName = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].TableName");
				rulesItem.Id = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].Id");
				rulesItem.EntityId = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].EntityId");
				rulesItem.Property = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].Property");
				rulesItem.MethodId = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].MethodId");
				rulesItem.MethodName = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].MethodName");
				rulesItem.OnDuty = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].OnDuty");
				rulesItem.RuleType = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].RuleType");
				rulesItem.BlockType = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].BlockType");
				rulesItem.TemplateId = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].TemplateId");
				rulesItem.TemplateName = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].TemplateName");
				rulesItem.RuleCheckerRelationId = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].RuleCheckerRelationId");
				rulesItem.CheckerId = _ctx.IntegerValue("ListQualityRules.Data.Rules["+ i +"].CheckerId");
				rulesItem.FixCheck = _ctx.BooleanValue("ListQualityRules.Data.Rules["+ i +"].FixCheck");
				rulesItem.Trend = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].Trend");
				rulesItem.WarningThreshold = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].WarningThreshold");
				rulesItem.CriticalThreshold = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].CriticalThreshold");
				rulesItem.HistoryWarningThreshold = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].HistoryWarningThreshold");
				rulesItem.HistoryCriticalThreshold = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].HistoryCriticalThreshold");
				rulesItem.PropertyKey = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].PropertyKey");
				rulesItem.MatchExpression = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].MatchExpression");
				rulesItem.Comment = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].Comment");
				rulesItem.ExpectValue = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].ExpectValue");
				rulesItem.OnDutyAccountName = _ctx.StringValue("ListQualityRules.Data.Rules["+ i +"].OnDutyAccountName");

				data_rules.Add(rulesItem);
			}
			data.Rules = data_rules;
			listQualityRulesResponse.Data = data;
        
			return listQualityRulesResponse;
        }
    }
}
