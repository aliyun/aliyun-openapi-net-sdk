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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Iot.Model.V20160530;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20160530
{
    public class GetRuleResponseUnmarshaller
    {
        public static GetRuleResponse Unmarshall(UnmarshallerContext context)
        {
			GetRuleResponse getRuleResponse = new GetRuleResponse();

			getRuleResponse.HttpResponse = context.HttpResponse;
			getRuleResponse.RequestId = context.StringValue("GetRule.RequestId");
			getRuleResponse.Success = context.BooleanValue("GetRule.Success");
			getRuleResponse.ErrorMessage = context.StringValue("GetRule.ErrorMessage");

			GetRuleResponse.RuleInfo_ ruleInfo = new GetRuleResponse.RuleInfo_();
			ruleInfo.Id = context.LongValue("GetRule.RuleInfo.Id");
			ruleInfo.Select = context.StringValue("GetRule.RuleInfo.Select");
			ruleInfo.Topic = context.StringValue("GetRule.RuleInfo.Topic");
			ruleInfo.ShortTopic = context.StringValue("GetRule.RuleInfo.ShortTopic");
			ruleInfo.Where = context.StringValue("GetRule.RuleInfo.Where");
			ruleInfo.Status = context.StringValue("GetRule.RuleInfo.Status");
			ruleInfo.CreateUserId = context.LongValue("GetRule.RuleInfo.CreateUserId");
			ruleInfo.ProductKey = context.LongValue("GetRule.RuleInfo.ProductKey");
			ruleInfo.Name = context.StringValue("GetRule.RuleInfo.Name");
			ruleInfo.RuleDesc = context.StringValue("GetRule.RuleInfo.RuleDesc");
			ruleInfo.Created = context.StringValue("GetRule.RuleInfo.Created");
			ruleInfo.Modified = context.StringValue("GetRule.RuleInfo.Modified");
			getRuleResponse.RuleInfo = ruleInfo;
        
			return getRuleResponse;
        }
    }
}