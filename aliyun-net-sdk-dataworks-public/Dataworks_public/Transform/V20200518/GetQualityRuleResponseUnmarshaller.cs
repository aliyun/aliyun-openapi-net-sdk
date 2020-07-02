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
        public static GetQualityRuleResponse Unmarshall(UnmarshallerContext context)
        {
			GetQualityRuleResponse getQualityRuleResponse = new GetQualityRuleResponse();

			getQualityRuleResponse.HttpResponse = context.HttpResponse;
			getQualityRuleResponse.Success = context.BooleanValue("GetQualityRule.Success");
			getQualityRuleResponse.ErrorCode = context.StringValue("GetQualityRule.ErrorCode");
			getQualityRuleResponse.ErrorMessage = context.StringValue("GetQualityRule.ErrorMessage");
			getQualityRuleResponse.HttpStatusCode = context.IntegerValue("GetQualityRule.HttpStatusCode");
			getQualityRuleResponse.RequestId = context.StringValue("GetQualityRule.RequestId");

			GetQualityRuleResponse.GetQualityRule_Data data = new GetQualityRuleResponse.GetQualityRule_Data();
			data.Id = context.LongValue("GetQualityRule.Data.Id");
			data.EntityId = context.LongValue("GetQualityRule.Data.EntityId");
			data.Property = context.StringValue("GetQualityRule.Data.Property");
			data.MethodId = context.IntegerValue("GetQualityRule.Data.MethodId");
			data.MethodName = context.StringValue("GetQualityRule.Data.MethodName");
			data.WhereCondition = context.StringValue("GetQualityRule.Data.WhereCondition");
			data.OnDuty = context.StringValue("GetQualityRule.Data.OnDuty");
			data.RuleType = context.IntegerValue("GetQualityRule.Data.RuleType");
			data.BlockType = context.IntegerValue("GetQualityRule.Data.BlockType");
			data.TemplateId = context.IntegerValue("GetQualityRule.Data.TemplateId");
			data.TemplateName = context.StringValue("GetQualityRule.Data.TemplateName");
			data.Comment = context.StringValue("GetQualityRule.Data.Comment");
			data.RuleName = context.StringValue("GetQualityRule.Data.RuleName");
			data.PredictType = context.IntegerValue("GetQualityRule.Data.PredictType");
			data.WarningThreshold = context.StringValue("GetQualityRule.Data.WarningThreshold");
			data.CriticalThreshold = context.StringValue("GetQualityRule.Data.CriticalThreshold");
			data._Operator = context.StringValue("GetQualityRule.Data.Operator");
			data.ExpectValue = context.StringValue("GetQualityRule.Data.ExpectValue");
			data.Trend = context.StringValue("GetQualityRule.Data.Trend");
			data.CheckerName = context.StringValue("GetQualityRule.Data.CheckerName");
			data.Checker = context.IntegerValue("GetQualityRule.Data.Checker");
			data.FixCheck = context.BooleanValue("GetQualityRule.Data.FixCheck");
			getQualityRuleResponse.Data = data;
        
			return getQualityRuleResponse;
        }
    }
}
