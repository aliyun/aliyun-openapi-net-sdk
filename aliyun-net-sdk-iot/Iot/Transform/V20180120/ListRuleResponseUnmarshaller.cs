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
        public static ListRuleResponse Unmarshall(UnmarshallerContext context)
        {
			ListRuleResponse listRuleResponse = new ListRuleResponse();

			listRuleResponse.HttpResponse = context.HttpResponse;
			listRuleResponse.RequestId = context.StringValue("ListRule.RequestId");
			listRuleResponse.Success = context.BooleanValue("ListRule.Success");
			listRuleResponse.Code = context.StringValue("ListRule.Code");
			listRuleResponse.ErrorMessage = context.StringValue("ListRule.ErrorMessage");
			listRuleResponse.Page = context.IntegerValue("ListRule.Page");
			listRuleResponse.Total = context.IntegerValue("ListRule.Total");
			listRuleResponse.PageSize = context.IntegerValue("ListRule.PageSize");

			List<ListRuleResponse.ListRule_RuleInfo> listRuleResponse_data = new List<ListRuleResponse.ListRule_RuleInfo>();
			for (int i = 0; i < context.Length("ListRule.Data.Length"); i++) {
				ListRuleResponse.ListRule_RuleInfo ruleInfo = new ListRuleResponse.ListRule_RuleInfo();
				ruleInfo.Id = context.LongValue("ListRule.Data["+ i +"].Id");
				ruleInfo.Select = context.StringValue("ListRule.Data["+ i +"].Select");
				ruleInfo.Topic = context.StringValue("ListRule.Data["+ i +"].Topic");
				ruleInfo.ShortTopic = context.StringValue("ListRule.Data["+ i +"].ShortTopic");
				ruleInfo._Where = context.StringValue("ListRule.Data["+ i +"].Where");
				ruleInfo.Status = context.StringValue("ListRule.Data["+ i +"].Status");
				ruleInfo.CreateUserId = context.LongValue("ListRule.Data["+ i +"].CreateUserId");
				ruleInfo.ProductKey = context.StringValue("ListRule.Data["+ i +"].ProductKey");
				ruleInfo.Name = context.StringValue("ListRule.Data["+ i +"].Name");
				ruleInfo.DataType = context.StringValue("ListRule.Data["+ i +"].DataType");
				ruleInfo.RuleDesc = context.StringValue("ListRule.Data["+ i +"].RuleDesc");
				ruleInfo.Created = context.StringValue("ListRule.Data["+ i +"].Created");
				ruleInfo.UtcCreated = context.StringValue("ListRule.Data["+ i +"].UtcCreated");
				ruleInfo.Modified = context.StringValue("ListRule.Data["+ i +"].Modified");
				ruleInfo.UtcModified = context.StringValue("ListRule.Data["+ i +"].UtcModified");

				listRuleResponse_data.Add(ruleInfo);
			}
			listRuleResponse.Data = listRuleResponse_data;
        
			return listRuleResponse;
        }
    }
}
