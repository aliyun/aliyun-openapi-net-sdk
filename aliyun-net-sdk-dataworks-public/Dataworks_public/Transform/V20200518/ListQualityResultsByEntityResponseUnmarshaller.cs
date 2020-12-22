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
    public class ListQualityResultsByEntityResponseUnmarshaller
    {
        public static ListQualityResultsByEntityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQualityResultsByEntityResponse listQualityResultsByEntityResponse = new ListQualityResultsByEntityResponse();

			listQualityResultsByEntityResponse.HttpResponse = _ctx.HttpResponse;
			listQualityResultsByEntityResponse.RequestId = _ctx.StringValue("ListQualityResultsByEntity.RequestId");
			listQualityResultsByEntityResponse.HttpStatusCode = _ctx.IntegerValue("ListQualityResultsByEntity.HttpStatusCode");
			listQualityResultsByEntityResponse.ErrorMessage = _ctx.StringValue("ListQualityResultsByEntity.ErrorMessage");
			listQualityResultsByEntityResponse.ErrorCode = _ctx.StringValue("ListQualityResultsByEntity.ErrorCode");
			listQualityResultsByEntityResponse.Success = _ctx.BooleanValue("ListQualityResultsByEntity.Success");

			ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data data = new ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data();
			data.TotalCount = _ctx.LongValue("ListQualityResultsByEntity.Data.TotalCount");
			data.PageNumber = _ctx.IntegerValue("ListQualityResultsByEntity.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListQualityResultsByEntity.Data.PageSize");

			List<ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data.ListQualityResultsByEntity_RuleChecksItem> data_ruleChecks = new List<ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data.ListQualityResultsByEntity_RuleChecksItem>();
			for (int i = 0; i < _ctx.Length("ListQualityResultsByEntity.Data.RuleChecks.Length"); i++) {
				ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data.ListQualityResultsByEntity_RuleChecksItem ruleChecksItem = new ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data.ListQualityResultsByEntity_RuleChecksItem();
				ruleChecksItem.Id = _ctx.IntegerValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].Id");
				ruleChecksItem.TaskId = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].TaskId");
				ruleChecksItem.EntityId = _ctx.IntegerValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].EntityId");
				ruleChecksItem.RuleId = _ctx.IntegerValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].RuleId");
				ruleChecksItem.Property = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].Property");
				ruleChecksItem.BizDate = _ctx.LongValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].BizDate");
				ruleChecksItem.DateType = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].DateType");
				ruleChecksItem.ActualExpression = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].ActualExpression");
				ruleChecksItem.MatchExpression = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].MatchExpression");
				ruleChecksItem.BlockType = _ctx.IntegerValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].BlockType");
				ruleChecksItem.CheckResult = _ctx.IntegerValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].CheckResult");
				ruleChecksItem.CheckResultStatus = _ctx.IntegerValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].CheckResultStatus");
				ruleChecksItem.MethodName = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].MethodName");
				ruleChecksItem.Comment = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].Comment");
				ruleChecksItem.WhereCondition = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].WhereCondition");
				ruleChecksItem.BeginTime = _ctx.LongValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].BeginTime");
				ruleChecksItem.EndTime = _ctx.LongValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].EndTime");
				ruleChecksItem.TimeCost = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].TimeCost");
				ruleChecksItem.ExternalType = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].ExternalType");
				ruleChecksItem.ExternalId = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].ExternalId");
				ruleChecksItem.DiscreteCheck = _ctx.BooleanValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].DiscreteCheck");
				ruleChecksItem.FixedCheck = _ctx.BooleanValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].FixedCheck");
				ruleChecksItem.Trend = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].Trend");
				ruleChecksItem.WarningThreshold = _ctx.FloatValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].WarningThreshold");
				ruleChecksItem.CriticalThreshold = _ctx.FloatValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].CriticalThreshold");
				ruleChecksItem.ExpectValue = _ctx.FloatValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].ExpectValue");
				ruleChecksItem.Op = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].Op");
				ruleChecksItem.ProjectName = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].ProjectName");
				ruleChecksItem.TableName = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].TableName");
				ruleChecksItem.TemplateId = _ctx.IntegerValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].TemplateId");
				ruleChecksItem.TemplateName = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].TemplateName");
				ruleChecksItem.ResultString = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].ResultString");
				ruleChecksItem.CheckerId = _ctx.IntegerValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].CheckerId");
				ruleChecksItem.CheckerType = _ctx.IntegerValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].CheckerType");
				ruleChecksItem.RuleName = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].RuleName");
				ruleChecksItem.IsPrediction = _ctx.BooleanValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].IsPrediction");
				ruleChecksItem.UpperValue = _ctx.FloatValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].UpperValue");
				ruleChecksItem.LowerValue = _ctx.FloatValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].LowerValue");
				ruleChecksItem.CheckerName = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].CheckerName");

				List<ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data.ListQualityResultsByEntity_RuleChecksItem.ListQualityResultsByEntity_ReferenceValueItem> ruleChecksItem_referenceValue = new List<ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data.ListQualityResultsByEntity_RuleChecksItem.ListQualityResultsByEntity_ReferenceValueItem>();
				for (int j = 0; j < _ctx.Length("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].ReferenceValue.Length"); j++) {
					ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data.ListQualityResultsByEntity_RuleChecksItem.ListQualityResultsByEntity_ReferenceValueItem referenceValueItem = new ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data.ListQualityResultsByEntity_RuleChecksItem.ListQualityResultsByEntity_ReferenceValueItem();
					referenceValueItem.BizDate = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].ReferenceValue["+ j +"].BizDate");
					referenceValueItem.DiscreteProperty = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].ReferenceValue["+ j +"].DiscreteProperty");
					referenceValueItem._Value = _ctx.FloatValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].ReferenceValue["+ j +"].Value");
					referenceValueItem.Threshold = _ctx.FloatValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].ReferenceValue["+ j +"].Threshold");
					referenceValueItem.SingleCheckResult = _ctx.IntegerValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].ReferenceValue["+ j +"].SingleCheckResult");

					ruleChecksItem_referenceValue.Add(referenceValueItem);
				}
				ruleChecksItem.ReferenceValue = ruleChecksItem_referenceValue;

				List<ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data.ListQualityResultsByEntity_RuleChecksItem.ListQualityResultsByEntity_SampleValueItem> ruleChecksItem_sampleValue = new List<ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data.ListQualityResultsByEntity_RuleChecksItem.ListQualityResultsByEntity_SampleValueItem>();
				for (int j = 0; j < _ctx.Length("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].SampleValue.Length"); j++) {
					ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data.ListQualityResultsByEntity_RuleChecksItem.ListQualityResultsByEntity_SampleValueItem sampleValueItem = new ListQualityResultsByEntityResponse.ListQualityResultsByEntity_Data.ListQualityResultsByEntity_RuleChecksItem.ListQualityResultsByEntity_SampleValueItem();
					sampleValueItem.BizDate = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].SampleValue["+ j +"].BizDate");
					sampleValueItem.DiscreteProperty = _ctx.StringValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].SampleValue["+ j +"].DiscreteProperty");
					sampleValueItem._Value = _ctx.FloatValue("ListQualityResultsByEntity.Data.RuleChecks["+ i +"].SampleValue["+ j +"].Value");

					ruleChecksItem_sampleValue.Add(sampleValueItem);
				}
				ruleChecksItem.SampleValue = ruleChecksItem_sampleValue;

				data_ruleChecks.Add(ruleChecksItem);
			}
			data.RuleChecks = data_ruleChecks;
			listQualityResultsByEntityResponse.Data = data;
        
			return listQualityResultsByEntityResponse;
        }
    }
}
