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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListRuleResponseUnmarshaller
    {
        public static ListRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRuleResponse listRuleResponse = new ListRuleResponse();

			listRuleResponse.HttpResponse = _ctx.HttpResponse;
			listRuleResponse.RequestId = _ctx.StringValue("ListRule.RequestId");
			listRuleResponse.Success = _ctx.BooleanValue("ListRule.Success");
			listRuleResponse.Code = _ctx.StringValue("ListRule.Code");
			listRuleResponse.ErrorMessage = _ctx.StringValue("ListRule.ErrorMessage");
			listRuleResponse.Page = _ctx.IntegerValue("ListRule.Page");
			listRuleResponse.Total = _ctx.IntegerValue("ListRule.Total");
			listRuleResponse.PageSize = _ctx.IntegerValue("ListRule.PageSize");

			List<ListRuleResponse.ListRule_RuleInfo> listRuleResponse_data = new List<ListRuleResponse.ListRule_RuleInfo>();
			for (int i = 0; i < _ctx.Length("ListRule.Data.Length"); i++) {
				ListRuleResponse.ListRule_RuleInfo ruleInfo = new ListRuleResponse.ListRule_RuleInfo();
				ruleInfo.Id = _ctx.LongValue("ListRule.Data["+ i +"].Id");
				ruleInfo.Select = _ctx.StringValue("ListRule.Data["+ i +"].Select");
				ruleInfo.Topic = _ctx.StringValue("ListRule.Data["+ i +"].Topic");
				ruleInfo.ShortTopic = _ctx.StringValue("ListRule.Data["+ i +"].ShortTopic");
				ruleInfo._Where = _ctx.StringValue("ListRule.Data["+ i +"].Where");
				ruleInfo.Status = _ctx.StringValue("ListRule.Data["+ i +"].Status");
				ruleInfo.CreateUserId = _ctx.LongValue("ListRule.Data["+ i +"].CreateUserId");
				ruleInfo.ProductKey = _ctx.StringValue("ListRule.Data["+ i +"].ProductKey");
				ruleInfo.Name = _ctx.StringValue("ListRule.Data["+ i +"].Name");
				ruleInfo.DataType = _ctx.StringValue("ListRule.Data["+ i +"].DataType");
				ruleInfo.RuleDesc = _ctx.StringValue("ListRule.Data["+ i +"].RuleDesc");
				ruleInfo.Created = _ctx.StringValue("ListRule.Data["+ i +"].Created");
				ruleInfo.UtcCreated = _ctx.StringValue("ListRule.Data["+ i +"].UtcCreated");
				ruleInfo.Modified = _ctx.StringValue("ListRule.Data["+ i +"].Modified");
				ruleInfo.UtcModified = _ctx.StringValue("ListRule.Data["+ i +"].UtcModified");

				listRuleResponse_data.Add(ruleInfo);
			}
			listRuleResponse.Data = listRuleResponse_data;
        
			return listRuleResponse;
        }
    }
}
