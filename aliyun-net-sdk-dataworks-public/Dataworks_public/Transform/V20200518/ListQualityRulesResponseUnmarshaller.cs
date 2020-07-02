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
        public static ListQualityRulesResponse Unmarshall(UnmarshallerContext context)
        {
			ListQualityRulesResponse listQualityRulesResponse = new ListQualityRulesResponse();

			listQualityRulesResponse.HttpResponse = context.HttpResponse;
			listQualityRulesResponse.ErrorCode = context.StringValue("ListQualityRules.ErrorCode");
			listQualityRulesResponse.Success = context.BooleanValue("ListQualityRules.Success");
			listQualityRulesResponse.ErrorMessage = context.StringValue("ListQualityRules.ErrorMessage");
			listQualityRulesResponse.HttpStatusCode = context.IntegerValue("ListQualityRules.HttpStatusCode");
			listQualityRulesResponse.RequestId = context.StringValue("ListQualityRules.RequestId");

			ListQualityRulesResponse.ListQualityRules_Data data = new ListQualityRulesResponse.ListQualityRules_Data();
			data.TotalCount = context.LongValue("ListQualityRules.Data.TotalCount");
			data.PageNumber = context.IntegerValue("ListQualityRules.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListQualityRules.Data.PageSize");

			List<ListQualityRulesResponse.ListQualityRules_Data.ListQualityRules_RulesItem> data_rules = new List<ListQualityRulesResponse.ListQualityRules_Data.ListQualityRules_RulesItem>();
			for (int i = 0; i < context.Length("ListQualityRules.Data.Rules.Length"); i++) {
				ListQualityRulesResponse.ListQualityRules_Data.ListQualityRules_RulesItem rulesItem = new ListQualityRulesResponse.ListQualityRules_Data.ListQualityRules_RulesItem();
				rulesItem.ProjectName = context.StringValue("ListQualityRules.Data.Rules["+ i +"].ProjectName");
				rulesItem.TableName = context.StringValue("ListQualityRules.Data.Rules["+ i +"].TableName");
				rulesItem.Id = context.IntegerValue("ListQualityRules.Data.Rules["+ i +"].Id");
				rulesItem.EntityId = context.IntegerValue("ListQualityRules.Data.Rules["+ i +"].EntityId");
				rulesItem.Property = context.StringValue("ListQualityRules.Data.Rules["+ i +"].Property");
				rulesItem.MethodId = context.IntegerValue("ListQualityRules.Data.Rules["+ i +"].MethodId");
				rulesItem.MethodName = context.StringValue("ListQualityRules.Data.Rules["+ i +"].MethodName");
				rulesItem.OnDuty = context.StringValue("ListQualityRules.Data.Rules["+ i +"].OnDuty");
				rulesItem.RuleType = context.IntegerValue("ListQualityRules.Data.Rules["+ i +"].RuleType");
				rulesItem.BlockType = context.IntegerValue("ListQualityRules.Data.Rules["+ i +"].BlockType");
				rulesItem.TemplateId = context.IntegerValue("ListQualityRules.Data.Rules["+ i +"].TemplateId");
				rulesItem.TemplateName = context.StringValue("ListQualityRules.Data.Rules["+ i +"].TemplateName");
				rulesItem.RuleCheckerRelationId = context.IntegerValue("ListQualityRules.Data.Rules["+ i +"].RuleCheckerRelationId");
				rulesItem.CheckerId = context.IntegerValue("ListQualityRules.Data.Rules["+ i +"].CheckerId");
				rulesItem.FixCheck = context.BooleanValue("ListQualityRules.Data.Rules["+ i +"].FixCheck");
				rulesItem.Trend = context.StringValue("ListQualityRules.Data.Rules["+ i +"].Trend");
				rulesItem.WarningThreshold = context.StringValue("ListQualityRules.Data.Rules["+ i +"].WarningThreshold");
				rulesItem.CriticalThreshold = context.StringValue("ListQualityRules.Data.Rules["+ i +"].CriticalThreshold");
				rulesItem.HistoryWarningThreshold = context.StringValue("ListQualityRules.Data.Rules["+ i +"].HistoryWarningThreshold");
				rulesItem.HistoryCriticalThreshold = context.StringValue("ListQualityRules.Data.Rules["+ i +"].HistoryCriticalThreshold");
				rulesItem.PropertyKey = context.StringValue("ListQualityRules.Data.Rules["+ i +"].PropertyKey");
				rulesItem.MatchExpression = context.StringValue("ListQualityRules.Data.Rules["+ i +"].MatchExpression");
				rulesItem.Comment = context.StringValue("ListQualityRules.Data.Rules["+ i +"].Comment");
				rulesItem.ExpectValue = context.StringValue("ListQualityRules.Data.Rules["+ i +"].ExpectValue");

				data_rules.Add(rulesItem);
			}
			data.Rules = data_rules;
			listQualityRulesResponse.Data = data;
        
			return listQualityRulesResponse;
        }
    }
}
