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
    public class StopConfigRulesResponseUnmarshaller
    {
        public static StopConfigRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StopConfigRulesResponse stopConfigRulesResponse = new StopConfigRulesResponse();

			stopConfigRulesResponse.HttpResponse = _ctx.HttpResponse;
			stopConfigRulesResponse.RequestId = _ctx.StringValue("StopConfigRules.RequestId");

			StopConfigRulesResponse.StopConfigRules_OperateRuleResult operateRuleResult = new StopConfigRulesResponse.StopConfigRules_OperateRuleResult();

			List<StopConfigRulesResponse.StopConfigRules_OperateRuleResult.StopConfigRules_OperateRuleItem> operateRuleResult_operateRuleItemList = new List<StopConfigRulesResponse.StopConfigRules_OperateRuleResult.StopConfigRules_OperateRuleItem>();
			for (int i = 0; i < _ctx.Length("StopConfigRules.OperateRuleResult.OperateRuleItemList.Length"); i++) {
				StopConfigRulesResponse.StopConfigRules_OperateRuleResult.StopConfigRules_OperateRuleItem operateRuleItem = new StopConfigRulesResponse.StopConfigRules_OperateRuleResult.StopConfigRules_OperateRuleItem();
				operateRuleItem.ConfigRuleId = _ctx.StringValue("StopConfigRules.OperateRuleResult.OperateRuleItemList["+ i +"].ConfigRuleId");
				operateRuleItem.ErrorCode = _ctx.StringValue("StopConfigRules.OperateRuleResult.OperateRuleItemList["+ i +"].ErrorCode");
				operateRuleItem.Success = _ctx.BooleanValue("StopConfigRules.OperateRuleResult.OperateRuleItemList["+ i +"].Success");

				operateRuleResult_operateRuleItemList.Add(operateRuleItem);
			}
			operateRuleResult.OperateRuleItemList = operateRuleResult_operateRuleItemList;
			stopConfigRulesResponse.OperateRuleResult = operateRuleResult;
        
			return stopConfigRulesResponse;
        }
    }
}
