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
    public class CreateRuleResponseUnmarshaller
    {
        public static CreateRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateRuleResponse createRuleResponse = new CreateRuleResponse();

			createRuleResponse.HttpResponse = _ctx.HttpResponse;
			createRuleResponse.Code = _ctx.StringValue("CreateRule.Code");
			createRuleResponse.Success = _ctx.BooleanValue("CreateRule.Success");
			createRuleResponse.Message = _ctx.StringValue("CreateRule.Message");
			createRuleResponse.RequestId = _ctx.StringValue("CreateRule.RequestId");

			CreateRuleResponse.CreateRule_Model model = new CreateRuleResponse.CreateRule_Model();
			model.CreateTime = _ctx.LongValue("CreateRule.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("CreateRule.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("CreateRule.Model.TenantId");
			model.RuleName = _ctx.StringValue("CreateRule.Model.RuleName");
			model.RuleRId = _ctx.StringValue("CreateRule.Model.RuleRId");
			model.RuleType = _ctx.StringValue("CreateRule.Model.RuleType");
			model.RelatedAdSlots = _ctx.StringValue("CreateRule.Model.RelatedAdSlots");
			model.RuleConfig = _ctx.StringValue("CreateRule.Model.RuleConfig");
			model.Status = _ctx.StringValue("CreateRule.Model.Status");
			model.AccessStatus = _ctx.StringValue("CreateRule.Model.AccessStatus");
			model.ExtInfo = _ctx.StringValue("CreateRule.Model.ExtInfo");
			model.Version = _ctx.LongValue("CreateRule.Model.Version");
			model.RuleId = _ctx.StringValue("CreateRule.Model.RuleId");
			createRuleResponse.Model = model;
        
			return createRuleResponse;
        }
    }
}
