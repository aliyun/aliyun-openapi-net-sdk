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
    public class ListRuleActionsResponseUnmarshaller
    {
        public static ListRuleActionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListRuleActionsResponse listRuleActionsResponse = new ListRuleActionsResponse();

			listRuleActionsResponse.HttpResponse = context.HttpResponse;
			listRuleActionsResponse.RequestId = context.StringValue("ListRuleActions.RequestId");
			listRuleActionsResponse.Success = context.BooleanValue("ListRuleActions.Success");
			listRuleActionsResponse.Code = context.StringValue("ListRuleActions.Code");
			listRuleActionsResponse.ErrorMessage = context.StringValue("ListRuleActions.ErrorMessage");

			List<ListRuleActionsResponse.ListRuleActions_RuleActionInfo> listRuleActionsResponse_ruleActionList = new List<ListRuleActionsResponse.ListRuleActions_RuleActionInfo>();
			for (int i = 0; i < context.Length("ListRuleActions.RuleActionList.Length"); i++) {
				ListRuleActionsResponse.ListRuleActions_RuleActionInfo ruleActionInfo = new ListRuleActionsResponse.ListRuleActions_RuleActionInfo();
				ruleActionInfo.Id = context.LongValue("ListRuleActions.RuleActionList["+ i +"].Id");
				ruleActionInfo.RuleId = context.LongValue("ListRuleActions.RuleActionList["+ i +"].RuleId");
				ruleActionInfo.Type = context.StringValue("ListRuleActions.RuleActionList["+ i +"].Type");
				ruleActionInfo.Configuration = context.StringValue("ListRuleActions.RuleActionList["+ i +"].Configuration");
				ruleActionInfo.ErrorActionFlag = context.BooleanValue("ListRuleActions.RuleActionList["+ i +"].ErrorActionFlag");

				listRuleActionsResponse_ruleActionList.Add(ruleActionInfo);
			}
			listRuleActionsResponse.RuleActionList = listRuleActionsResponse_ruleActionList;
        
			return listRuleActionsResponse;
        }
    }
}
