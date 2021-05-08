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
    public class ListRuleResponseUnmarshaller
    {
        public static ListRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRuleResponse listRuleResponse = new ListRuleResponse();

			listRuleResponse.HttpResponse = _ctx.HttpResponse;
			listRuleResponse.Code = _ctx.StringValue("ListRule.Code");
			listRuleResponse.Success = _ctx.BooleanValue("ListRule.Success");
			listRuleResponse.Message = _ctx.StringValue("ListRule.Message");
			listRuleResponse.RequestId = _ctx.StringValue("ListRule.RequestId");
			listRuleResponse.PageNumber = _ctx.IntegerValue("ListRule.PageNumber");
			listRuleResponse.PageSize = _ctx.IntegerValue("ListRule.PageSize");
			listRuleResponse.Total = _ctx.LongValue("ListRule.Total");

			List<ListRuleResponse.ListRule_Rule> listRuleResponse_model = new List<ListRuleResponse.ListRule_Rule>();
			for (int i = 0; i < _ctx.Length("ListRule.Model.Length"); i++) {
				ListRuleResponse.ListRule_Rule rule = new ListRuleResponse.ListRule_Rule();
				rule.CreateTime = _ctx.LongValue("ListRule.Model["+ i +"].CreateTime");
				rule.ModifyTime = _ctx.LongValue("ListRule.Model["+ i +"].ModifyTime");
				rule.TenantId = _ctx.StringValue("ListRule.Model["+ i +"].TenantId");
				rule.RuleName = _ctx.StringValue("ListRule.Model["+ i +"].RuleName");
				rule.RuleRId = _ctx.StringValue("ListRule.Model["+ i +"].RuleRId");
				rule.RuleType = _ctx.StringValue("ListRule.Model["+ i +"].RuleType");
				rule.RelatedAdSlots = _ctx.StringValue("ListRule.Model["+ i +"].RelatedAdSlots");
				rule.RuleConfig = _ctx.StringValue("ListRule.Model["+ i +"].RuleConfig");
				rule.Status = _ctx.StringValue("ListRule.Model["+ i +"].Status");
				rule.ExtInfo = _ctx.StringValue("ListRule.Model["+ i +"].ExtInfo");
				rule.Version = _ctx.LongValue("ListRule.Model["+ i +"].Version");
				rule.RuleId = _ctx.StringValue("ListRule.Model["+ i +"].RuleId");

				listRuleResponse_model.Add(rule);
			}
			listRuleResponse.Model = listRuleResponse_model;
        
			return listRuleResponse;
        }
    }
}
