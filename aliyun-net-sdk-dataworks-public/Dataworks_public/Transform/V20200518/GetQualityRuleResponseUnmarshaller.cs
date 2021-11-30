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
    public class GetQualityRuleResponseUnmarshaller
    {
        public static GetQualityRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetQualityRuleResponse getQualityRuleResponse = new GetQualityRuleResponse();

			getQualityRuleResponse.HttpResponse = _ctx.HttpResponse;
			getQualityRuleResponse.HttpStatusCode = _ctx.IntegerValue("GetQualityRule.HttpStatusCode");
			getQualityRuleResponse.RequestId = _ctx.StringValue("GetQualityRule.RequestId");
			getQualityRuleResponse.ErrorMessage = _ctx.StringValue("GetQualityRule.ErrorMessage");
			getQualityRuleResponse.ErrorCode = _ctx.StringValue("GetQualityRule.ErrorCode");
			getQualityRuleResponse.Success = _ctx.BooleanValue("GetQualityRule.Success");

			GetQualityRuleResponse.GetQualityRule_Data data = new GetQualityRuleResponse.GetQualityRule_Data();
			data.BlockType = _ctx.IntegerValue("GetQualityRule.Data.BlockType");
			data.OnDutyAccountName = _ctx.StringValue("GetQualityRule.Data.OnDutyAccountName");
			data.WarningThreshold = _ctx.StringValue("GetQualityRule.Data.WarningThreshold");
			data.Property = _ctx.StringValue("GetQualityRule.Data.Property");
			data.RuleType = _ctx.IntegerValue("GetQualityRule.Data.RuleType");
			data.Comment = _ctx.StringValue("GetQualityRule.Data.Comment");
			data.OnDuty = _ctx.StringValue("GetQualityRule.Data.OnDuty");
			data.Checker = _ctx.IntegerValue("GetQualityRule.Data.Checker");
			data.FixCheck = _ctx.BooleanValue("GetQualityRule.Data.FixCheck");
			data.MethodId = _ctx.IntegerValue("GetQualityRule.Data.MethodId");
			data.CriticalThreshold = _ctx.StringValue("GetQualityRule.Data.CriticalThreshold");
			data.PredictType = _ctx.IntegerValue("GetQualityRule.Data.PredictType");
			data.TemplateName = _ctx.StringValue("GetQualityRule.Data.TemplateName");
			data.CheckerName = _ctx.StringValue("GetQualityRule.Data.CheckerName");
			data.RuleName = _ctx.StringValue("GetQualityRule.Data.RuleName");
			data.MethodName = _ctx.StringValue("GetQualityRule.Data.MethodName");
			data.EntityId = _ctx.LongValue("GetQualityRule.Data.EntityId");
			data.WhereCondition = _ctx.StringValue("GetQualityRule.Data.WhereCondition");
			data._Operator = _ctx.StringValue("GetQualityRule.Data.Operator");
			data.ExpectValue = _ctx.StringValue("GetQualityRule.Data.ExpectValue");
			data.Trend = _ctx.StringValue("GetQualityRule.Data.Trend");
			data.TemplateId = _ctx.IntegerValue("GetQualityRule.Data.TemplateId");
			data.Id = _ctx.LongValue("GetQualityRule.Data.Id");
			getQualityRuleResponse.Data = data;
        
			return getQualityRuleResponse;
        }
    }
}
