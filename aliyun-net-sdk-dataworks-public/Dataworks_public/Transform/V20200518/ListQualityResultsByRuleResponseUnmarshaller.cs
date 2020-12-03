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
			listQualityResultsByRuleResponse.RequestId = _ctx.StringValue("ListQualityResultsByRule.RequestId");

			ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults qualityResults = new ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults();
			qualityResults.TotalCount = _ctx.LongValue("ListQualityResultsByRule.QualityResults.TotalCount");
			qualityResults.PageNumber = _ctx.IntegerValue("ListQualityResultsByRule.QualityResults.PageNumber");
			qualityResults.PageSize = _ctx.IntegerValue("ListQualityResultsByRule.QualityResults.PageSize");

			List<ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults.ListQualityResultsByRule_RuleChecksItem> qualityResults_ruleChecks = new List<ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults.ListQualityResultsByRule_RuleChecksItem>();
			for (int i = 0; i < _ctx.Length("ListQualityResultsByRule.QualityResults.RuleChecks.Length"); i++) {
				ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults.ListQualityResultsByRule_RuleChecksItem ruleChecksItem = new ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults.ListQualityResultsByRule_RuleChecksItem();
				ruleChecksItem.Id = _ctx.IntegerValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].Id");
				ruleChecksItem.TaskId = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].TaskId");
				ruleChecksItem.EntityId = _ctx.IntegerValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].EntityId");
				ruleChecksItem.RuleId = _ctx.IntegerValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].RuleId");
				ruleChecksItem.Property = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].Property");
				ruleChecksItem.BizDate = _ctx.LongValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].BizDate");
				ruleChecksItem.DateType = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].DateType");
				ruleChecksItem.ActualExpression = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].ActualExpression");
				ruleChecksItem.MatchExpression = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].MatchExpression");
				ruleChecksItem.BlockType = _ctx.IntegerValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].BlockType");
				ruleChecksItem.CheckResult = _ctx.IntegerValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].CheckResult");
				ruleChecksItem.CheckResultStatus = _ctx.IntegerValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].CheckResultStatus");
				ruleChecksItem.MethodName = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].MethodName");
				ruleChecksItem.Comment = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].Comment");
				ruleChecksItem.WhereCondition = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].WhereCondition");
				ruleChecksItem.BeginTime = _ctx.LongValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].BeginTime");
				ruleChecksItem.EndTime = _ctx.LongValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].EndTime");
				ruleChecksItem.TimeCost = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].TimeCost");
				ruleChecksItem.ExternalType = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].ExternalType");
				ruleChecksItem.ExternalId = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].ExternalId");
				ruleChecksItem.DiscreteCheck = _ctx.BooleanValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].DiscreteCheck");
				ruleChecksItem.FixedCheck = _ctx.BooleanValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].FixedCheck");
				ruleChecksItem.Trend = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].Trend");
				ruleChecksItem.WarningThreshold = _ctx.FloatValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].WarningThreshold");
				ruleChecksItem.CriticalThreshold = _ctx.FloatValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].CriticalThreshold");
				ruleChecksItem.ExpectValue = _ctx.FloatValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].ExpectValue");
				ruleChecksItem.Op = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].Op");
				ruleChecksItem.ProjectName = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].ProjectName");
				ruleChecksItem.TableName = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].TableName");
				ruleChecksItem.TemplateId = _ctx.IntegerValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].TemplateId");
				ruleChecksItem.TemplateName = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].TemplateName");
				ruleChecksItem.ResultString = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].ResultString");
				ruleChecksItem.CheckerId = _ctx.IntegerValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].CheckerId");
				ruleChecksItem.CheckerType = _ctx.IntegerValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].CheckerType");
				ruleChecksItem.RuleName = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].RuleName");
				ruleChecksItem.IsPrediction = _ctx.BooleanValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].IsPrediction");
				ruleChecksItem.UpperValue = _ctx.FloatValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].UpperValue");
				ruleChecksItem.LowerValue = _ctx.FloatValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].LowerValue");
				ruleChecksItem.CheckerName = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].CheckerName");

				List<ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_ReferenceValueItem> ruleChecksItem_referenceValue = new List<ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_ReferenceValueItem>();
				for (int j = 0; j < _ctx.Length("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].ReferenceValue.Length"); j++) {
					ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_ReferenceValueItem referenceValueItem = new ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_ReferenceValueItem();
					referenceValueItem.BizDate = _ctx.LongValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].ReferenceValue["+ j +"].BizDate");
					referenceValueItem.DiscreteProperty = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].ReferenceValue["+ j +"].DiscreteProperty");
					referenceValueItem._Value = _ctx.FloatValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].ReferenceValue["+ j +"].Value");
					referenceValueItem.Threshold = _ctx.FloatValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].ReferenceValue["+ j +"].Threshold");
					referenceValueItem.SingleCheckResult = _ctx.IntegerValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].ReferenceValue["+ j +"].SingleCheckResult");

					ruleChecksItem_referenceValue.Add(referenceValueItem);
				}
				ruleChecksItem.ReferenceValue = ruleChecksItem_referenceValue;

				List<ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_SampleValueItem> ruleChecksItem_sampleValue = new List<ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_SampleValueItem>();
				for (int j = 0; j < _ctx.Length("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].SampleValue.Length"); j++) {
					ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_SampleValueItem sampleValueItem = new ListQualityResultsByRuleResponse.ListQualityResultsByRule_QualityResults.ListQualityResultsByRule_RuleChecksItem.ListQualityResultsByRule_SampleValueItem();
					sampleValueItem.BizDate = _ctx.LongValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].SampleValue["+ j +"].BizDate");
					sampleValueItem.DiscreteProperty = _ctx.StringValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].SampleValue["+ j +"].DiscreteProperty");
					sampleValueItem._Value = _ctx.FloatValue("ListQualityResultsByRule.QualityResults.RuleChecks["+ i +"].SampleValue["+ j +"].Value");

					ruleChecksItem_sampleValue.Add(sampleValueItem);
				}
				ruleChecksItem.SampleValue = ruleChecksItem_sampleValue;

				qualityResults_ruleChecks.Add(ruleChecksItem);
			}
			qualityResults.RuleChecks = qualityResults_ruleChecks;
			listQualityResultsByRuleResponse.QualityResults = qualityResults;
        
			return listQualityResultsByRuleResponse;
        }
    }
}
