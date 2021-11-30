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
    public class DeleteRuleResponseUnmarshaller
    {
        public static DeleteRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteRuleResponse deleteRuleResponse = new DeleteRuleResponse();

			deleteRuleResponse.HttpResponse = _ctx.HttpResponse;
			deleteRuleResponse.Code = _ctx.StringValue("DeleteRule.Code");
			deleteRuleResponse.Success = _ctx.BooleanValue("DeleteRule.Success");
			deleteRuleResponse.Message = _ctx.StringValue("DeleteRule.Message");
			deleteRuleResponse.RequestId = _ctx.StringValue("DeleteRule.RequestId");

			DeleteRuleResponse.DeleteRule_Model model = new DeleteRuleResponse.DeleteRule_Model();
			model.CreateTime = _ctx.LongValue("DeleteRule.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("DeleteRule.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("DeleteRule.Model.TenantId");
			model.RuleName = _ctx.StringValue("DeleteRule.Model.RuleName");
			model.RuleRId = _ctx.StringValue("DeleteRule.Model.RuleRId");
			model.RuleType = _ctx.StringValue("DeleteRule.Model.RuleType");
			model.RelatedAdSlots = _ctx.StringValue("DeleteRule.Model.RelatedAdSlots");
			model.RuleConfig = _ctx.StringValue("DeleteRule.Model.RuleConfig");
			model.Status = _ctx.StringValue("DeleteRule.Model.Status");
			model.ExtInfo = _ctx.StringValue("DeleteRule.Model.ExtInfo");
			model.Version = _ctx.LongValue("DeleteRule.Model.Version");
			model.RuleId = _ctx.StringValue("DeleteRule.Model.RuleId");
			deleteRuleResponse.Model = model;
        
			return deleteRuleResponse;
        }
    }
}
