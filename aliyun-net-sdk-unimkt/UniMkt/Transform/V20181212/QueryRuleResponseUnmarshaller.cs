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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class QueryRuleResponseUnmarshaller
    {
        public static QueryRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRuleResponse queryRuleResponse = new QueryRuleResponse();

			queryRuleResponse.HttpResponse = _ctx.HttpResponse;
			queryRuleResponse.Code = _ctx.StringValue("QueryRule.Code");
			queryRuleResponse.Success = _ctx.BooleanValue("QueryRule.Success");
			queryRuleResponse.Message = _ctx.StringValue("QueryRule.Message");
			queryRuleResponse.RequestId = _ctx.StringValue("QueryRule.RequestId");

			QueryRuleResponse.QueryRule_Model model = new QueryRuleResponse.QueryRule_Model();
			model.CreateTime = _ctx.LongValue("QueryRule.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("QueryRule.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("QueryRule.Model.TenantId");
			model.RuleName = _ctx.StringValue("QueryRule.Model.RuleName");
			model.RuleRId = _ctx.StringValue("QueryRule.Model.RuleRId");
			model.RuleType = _ctx.StringValue("QueryRule.Model.RuleType");
			model.RelatedAdSlots = _ctx.StringValue("QueryRule.Model.RelatedAdSlots");
			model.RuleConfig = _ctx.StringValue("QueryRule.Model.RuleConfig");
			model.Status = _ctx.StringValue("QueryRule.Model.Status");
			model.AccessStatus = _ctx.StringValue("QueryRule.Model.AccessStatus");
			model.ExtInfo = _ctx.StringValue("QueryRule.Model.ExtInfo");
			model.Version = _ctx.LongValue("QueryRule.Model.Version");
			model.RuleId = _ctx.StringValue("QueryRule.Model.RuleId");
			queryRuleResponse.Model = model;
        
			return queryRuleResponse;
        }
    }
}
