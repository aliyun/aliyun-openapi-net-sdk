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
    public class ListQualityResultsByRuleResponseUnmarshaller
    {
        public static ListQualityResultsByRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQualityResultsByRuleResponse listQualityResultsByRuleResponse = new ListQualityResultsByRuleResponse();

			listQualityResultsByRuleResponse.HttpResponse = _ctx.HttpResponse;
			listQualityResultsByRuleResponse.HttpStatusCode = _ctx.IntegerValue("ListQualityResultsByRule.HttpStatusCode");
			listQualityResultsByRuleResponse.ErrorMessage = _ctx.StringValue("ListQualityResultsByRule.ErrorMessage");
			listQualityResultsByRuleResponse.RequestId = _ctx.StringValue("ListQualityResultsByRule.RequestId");
			listQualityResultsByRuleResponse.ErrorCode = _ctx.StringValue("ListQualityResultsByRule.ErrorCode");
			listQualityResultsByRuleResponse.Success = _ctx.BooleanValue("ListQualityResultsByRule.Success");

			ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data data = new ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data();
			data.PageNumber = _ctx.IntegerValue("ListQualityResultsByRule.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListQualityResultsByRule.Data.PageSize");
			data.TotalCount = _ctx.LongValue("ListQualityResultsByRule.Data.TotalCount");

			List<ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data.ListQualityResultsByRule_RuleChecksItem> data_ruleChecks = new List<ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data.ListQualityResultsByRule_RuleChecksItem>();
			for (int i = 0; i < _ctx.Length("ListQualityResultsByRule.Data.RuleChecks.Length"); i++) {
				ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data.ListQualityResultsByRule_RuleChecksItem ruleChecksItem = new ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data.ListQualityResultsByRule_RuleChecksItem();
				ruleChecksItem.BlockType = _ctx.IntegerValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].BlockType");
				ruleChecksItem.WarningThreshold = _ctx.FloatValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].WarningThreshold");
				ruleChecksItem.Property = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].Property");
				ruleChecksItem.TableName = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].TableName");
				ruleChecksItem.Comment = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].Comment");
				ruleChecksItem.CheckResultStatus = _ctx.IntegerValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].CheckResultStatus");
				ruleChecksItem.TemplateName = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].TemplateName");
				ruleChecksItem.CheckerName = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].CheckerName");
				ruleChecksItem.RuleId = _ctx.IntegerValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].RuleId");
				ruleChecksItem.FixedCheck = _ctx.BooleanValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].FixedCheck");
				ruleChecksItem.Op = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].Op");
				ruleChecksItem.UpperValue = _ctx.FloatValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].UpperValue");
				ruleChecksItem.ActualExpression = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].ActualExpression");
				ruleChecksItem.ExternalId = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].ExternalId");
				ruleChecksItem.TimeCost = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].TimeCost");
				ruleChecksItem.Trend = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].Trend");
				ruleChecksItem.ExternalType = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].ExternalType");
				ruleChecksItem.BizDate = _ctx.LongValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].BizDate");
				ruleChecksItem.CheckResult = _ctx.IntegerValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].CheckResult");
				ruleChecksItem.ResultString = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].ResultString");
				ruleChecksItem.MatchExpression = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].MatchExpression");
				ruleChecksItem.CheckerType = _ctx.IntegerValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].CheckerType");
				ruleChecksItem.ProjectName = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].ProjectName");
				ruleChecksItem.BeginTime = _ctx.LongValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].BeginTime");
				ruleChecksItem.DateType = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].DateType");
				ruleChecksItem.CriticalThreshold = _ctx.FloatValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].CriticalThreshold");
				ruleChecksItem.IsPrediction = _ctx.BooleanValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].IsPrediction");
				ruleChecksItem.RuleName = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].RuleName");
				ruleChecksItem.CheckerId = _ctx.IntegerValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].CheckerId");
				ruleChecksItem.DiscreteCheck = _ctx.BooleanValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].DiscreteCheck");
				ruleChecksItem.EndTime = _ctx.LongValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].EndTime");
				ruleChecksItem.MethodName = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].MethodName");
				ruleChecksItem.LowerValue = _ctx.FloatValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].LowerValue");
				ruleChecksItem.EntityId = _ctx.IntegerValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].EntityId");
				ruleChecksItem.WhereCondition = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].WhereCondition");
				ruleChecksItem.ExpectValue = _ctx.FloatValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].ExpectValue");
				ruleChecksItem.TemplateId = _ctx.IntegerValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].TemplateId");
				ruleChecksItem.TaskId = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].TaskId");
				ruleChecksItem.Id = _ctx.IntegerValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].Id");

				List<ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_ReferenceValueItem> ruleChecksItem_referenceValue = new List<ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_ReferenceValueItem>();
				for (int j = 0; j < _ctx.Length("ListQualityResultsByRule.Data.RuleChecks["+ i +"].ReferenceValue.Length"); j++) {
					ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_ReferenceValueItem referenceValueItem = new ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_ReferenceValueItem();
					referenceValueItem.DiscreteProperty = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].ReferenceValue["+ j +"].DiscreteProperty");
					referenceValueItem._Value = _ctx.FloatValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].ReferenceValue["+ j +"].Value");
					referenceValueItem.BizDate = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].ReferenceValue["+ j +"].BizDate");
					referenceValueItem.SingleCheckResult = _ctx.IntegerValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].ReferenceValue["+ j +"].SingleCheckResult");
					referenceValueItem.Threshold = _ctx.FloatValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].ReferenceValue["+ j +"].Threshold");

					ruleChecksItem_referenceValue.Add(referenceValueItem);
				}
				ruleChecksItem.ReferenceValue = ruleChecksItem_referenceValue;

				List<ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_SampleValueItem> ruleChecksItem_sampleValue = new List<ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_SampleValueItem>();
				for (int j = 0; j < _ctx.Length("ListQualityResultsByRule.Data.RuleChecks["+ i +"].SampleValue.Length"); j++) {
					ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_SampleValueItem sampleValueItem = new ListQualityResultsByRuleResponse.ListQualityResultsByRule_Data.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_SampleValueItem();
					sampleValueItem.DiscreteProperty = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].SampleValue["+ j +"].DiscreteProperty");
					sampleValueItem.BizDate = _ctx.StringValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].SampleValue["+ j +"].BizDate");
					sampleValueItem._Value = _ctx.FloatValue("ListQualityResultsByRule.Data.RuleChecks["+ i +"].SampleValue["+ j +"].Value");

					ruleChecksItem_sampleValue.Add(sampleValueItem);
				}
				ruleChecksItem.SampleValue = ruleChecksItem_sampleValue;

				data_ruleChecks.Add(ruleChecksItem);
			}
			data.RuleChecks = data_ruleChecks;
			listQualityResultsByRuleResponse.Data = data;
        
			return listQualityResultsByRuleResponse;
        }
    }
}
