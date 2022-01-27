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
    public class ModifyRuleResponseUnmarshaller
    {
        public static ModifyRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyRuleResponse modifyRuleResponse = new ModifyRuleResponse();

			modifyRuleResponse.HttpResponse = _ctx.HttpResponse;
			modifyRuleResponse.Code = _ctx.StringValue("ModifyRule.Code");
			modifyRuleResponse.Success = _ctx.BooleanValue("ModifyRule.Success");
			modifyRuleResponse.Message = _ctx.StringValue("ModifyRule.Message");
			modifyRuleResponse.RequestId = _ctx.StringValue("ModifyRule.RequestId");

			ModifyRuleResponse.ModifyRule_Model model = new ModifyRuleResponse.ModifyRule_Model();
			model.CreateTime = _ctx.LongValue("ModifyRule.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("ModifyRule.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("ModifyRule.Model.TenantId");
			model.RuleName = _ctx.StringValue("ModifyRule.Model.RuleName");
			model.RuleRId = _ctx.StringValue("ModifyRule.Model.RuleRId");
			model.RuleType = _ctx.StringValue("ModifyRule.Model.RuleType");
			model.RelatedAdSlots = _ctx.StringValue("ModifyRule.Model.RelatedAdSlots");
			model.RuleConfig = _ctx.StringValue("ModifyRule.Model.RuleConfig");
			model.Status = _ctx.StringValue("ModifyRule.Model.Status");
			model.ExtInfo = _ctx.StringValue("ModifyRule.Model.ExtInfo");
			model.Version = _ctx.LongValue("ModifyRule.Model.Version");
			model.RuleId = _ctx.StringValue("ModifyRule.Model.RuleId");
			modifyRuleResponse.Model = model;
        
			return modifyRuleResponse;
        }
    }
}
