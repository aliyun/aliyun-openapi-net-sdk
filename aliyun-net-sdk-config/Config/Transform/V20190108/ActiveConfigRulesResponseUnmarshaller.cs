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
using Aliyun.Acs.Config.Model.V20190108;

namespace Aliyun.Acs.Config.Transform.V20190108
{
    public class ActiveConfigRulesResponseUnmarshaller
    {
        public static ActiveConfigRulesResponse Unmarshall(UnmarshallerContext context)
        {
			ActiveConfigRulesResponse activeConfigRulesResponse = new ActiveConfigRulesResponse();

			activeConfigRulesResponse.HttpResponse = context.HttpResponse;
			activeConfigRulesResponse.RequestId = context.StringValue("ActiveConfigRules.RequestId");

			ActiveConfigRulesResponse.ActiveConfigRules_OperateRuleResult operateRuleResult = new ActiveConfigRulesResponse.ActiveConfigRules_OperateRuleResult();

			List<ActiveConfigRulesResponse.ActiveConfigRules_OperateRuleResult.ActiveConfigRules_OperateRuleItem> operateRuleResult_operateRuleItemList = new List<ActiveConfigRulesResponse.ActiveConfigRules_OperateRuleResult.ActiveConfigRules_OperateRuleItem>();
			for (int i = 0; i < context.Length("ActiveConfigRules.OperateRuleResult.OperateRuleItemList.Length"); i++) {
				ActiveConfigRulesResponse.ActiveConfigRules_OperateRuleResult.ActiveConfigRules_OperateRuleItem operateRuleItem = new ActiveConfigRulesResponse.ActiveConfigRules_OperateRuleResult.ActiveConfigRules_OperateRuleItem();
				operateRuleItem.ConfigRuleId = context.StringValue("ActiveConfigRules.OperateRuleResult.OperateRuleItemList["+ i +"].ConfigRuleId");
				operateRuleItem.ErrorCode = context.StringValue("ActiveConfigRules.OperateRuleResult.OperateRuleItemList["+ i +"].ErrorCode");
				operateRuleItem.Success = context.BooleanValue("ActiveConfigRules.OperateRuleResult.OperateRuleItemList["+ i +"].Success");

				operateRuleResult_operateRuleItemList.Add(operateRuleItem);
			}
			operateRuleResult.OperateRuleItemList = operateRuleResult_operateRuleItemList;
			activeConfigRulesResponse.OperateRuleResult = operateRuleResult;
        
			return activeConfigRulesResponse;
        }
    }
}
