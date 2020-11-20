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
    public class DeleteConfigRulesResponseUnmarshaller
    {
        public static DeleteConfigRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteConfigRulesResponse deleteConfigRulesResponse = new DeleteConfigRulesResponse();

			deleteConfigRulesResponse.HttpResponse = _ctx.HttpResponse;
			deleteConfigRulesResponse.RequestId = _ctx.StringValue("DeleteConfigRules.RequestId");

			DeleteConfigRulesResponse.DeleteConfigRules_OperateRuleResult operateRuleResult = new DeleteConfigRulesResponse.DeleteConfigRules_OperateRuleResult();

			List<DeleteConfigRulesResponse.DeleteConfigRules_OperateRuleResult.DeleteConfigRules_OperateRuleItem> operateRuleResult_operateRuleItemList = new List<DeleteConfigRulesResponse.DeleteConfigRules_OperateRuleResult.DeleteConfigRules_OperateRuleItem>();
			for (int i = 0; i < _ctx.Length("DeleteConfigRules.OperateRuleResult.OperateRuleItemList.Length"); i++) {
				DeleteConfigRulesResponse.DeleteConfigRules_OperateRuleResult.DeleteConfigRules_OperateRuleItem operateRuleItem = new DeleteConfigRulesResponse.DeleteConfigRules_OperateRuleResult.DeleteConfigRules_OperateRuleItem();
				operateRuleItem.ConfigRuleId = _ctx.StringValue("DeleteConfigRules.OperateRuleResult.OperateRuleItemList["+ i +"].ConfigRuleId");
				operateRuleItem.ErrorCode = _ctx.StringValue("DeleteConfigRules.OperateRuleResult.OperateRuleItemList["+ i +"].ErrorCode");
				operateRuleItem.Success = _ctx.BooleanValue("DeleteConfigRules.OperateRuleResult.OperateRuleItemList["+ i +"].Success");

				operateRuleResult_operateRuleItemList.Add(operateRuleItem);
			}
			operateRuleResult.OperateRuleItemList = operateRuleResult_operateRuleItemList;
			deleteConfigRulesResponse.OperateRuleResult = operateRuleResult;
        
			return deleteConfigRulesResponse;
        }
    }
}
