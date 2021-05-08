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
    public class ListRuleAreaResponseUnmarshaller
    {
        public static ListRuleAreaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRuleAreaResponse listRuleAreaResponse = new ListRuleAreaResponse();

			listRuleAreaResponse.HttpResponse = _ctx.HttpResponse;
			listRuleAreaResponse.Code = _ctx.StringValue("ListRuleArea.Code");
			listRuleAreaResponse.Success = _ctx.BooleanValue("ListRuleArea.Success");
			listRuleAreaResponse.Message = _ctx.StringValue("ListRuleArea.Message");
			listRuleAreaResponse.RequestId = _ctx.StringValue("ListRuleArea.RequestId");
			listRuleAreaResponse.PageNumber = _ctx.IntegerValue("ListRuleArea.PageNumber");
			listRuleAreaResponse.PageSize = _ctx.IntegerValue("ListRuleArea.PageSize");
			listRuleAreaResponse.Total = _ctx.LongValue("ListRuleArea.Total");

			List<ListRuleAreaResponse.ListRuleArea_Rule> listRuleAreaResponse_model = new List<ListRuleAreaResponse.ListRuleArea_Rule>();
			for (int i = 0; i < _ctx.Length("ListRuleArea.Model.Length"); i++) {
				ListRuleAreaResponse.ListRuleArea_Rule rule = new ListRuleAreaResponse.ListRuleArea_Rule();
				rule.RecordId = _ctx.StringValue("ListRuleArea.Model["+ i +"].RecordId");
				rule.TenantId = _ctx.StringValue("ListRuleArea.Model["+ i +"].TenantId");
				rule.RuleName = _ctx.StringValue("ListRuleArea.Model["+ i +"].RuleName");
				rule.RuleId = _ctx.StringValue("ListRuleArea.Model["+ i +"].RuleId");
				rule.RuleType = _ctx.StringValue("ListRuleArea.Model["+ i +"].RuleType");
				rule.MediaId = _ctx.StringValue("ListRuleArea.Model["+ i +"].MediaId");
				rule.MediaName = _ctx.StringValue("ListRuleArea.Model["+ i +"].MediaName");
				rule.AdSlotId = _ctx.StringValue("ListRuleArea.Model["+ i +"].AdSlotId");
				rule.AdSlotName = _ctx.StringValue("ListRuleArea.Model["+ i +"].AdSlotName");
				rule.Status = _ctx.StringValue("ListRuleArea.Model["+ i +"].Status");

				listRuleAreaResponse_model.Add(rule);
			}
			listRuleAreaResponse.Model = listRuleAreaResponse_model;
        
			return listRuleAreaResponse;
        }
    }
}
