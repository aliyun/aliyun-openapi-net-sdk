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
    public class GetRuleResponseUnmarshaller
    {
        public static GetRuleResponse Unmarshall(UnmarshallerContext context)
        {
			GetRuleResponse getRuleResponse = new GetRuleResponse();

			getRuleResponse.HttpResponse = context.HttpResponse;
			getRuleResponse.RequestId = context.StringValue("GetRule.RequestId");
			getRuleResponse.Success = context.BooleanValue("GetRule.Success");
			getRuleResponse.Code = context.StringValue("GetRule.Code");
			getRuleResponse.ErrorMessage = context.StringValue("GetRule.ErrorMessage");

			GetRuleResponse.GetRule_RuleInfo ruleInfo = new GetRuleResponse.GetRule_RuleInfo();
			ruleInfo.Id = context.LongValue("GetRule.RuleInfo.Id");
			ruleInfo.Select = context.StringValue("GetRule.RuleInfo.Select");
			ruleInfo.Topic = context.StringValue("GetRule.RuleInfo.Topic");
			ruleInfo.ShortTopic = context.StringValue("GetRule.RuleInfo.ShortTopic");
			ruleInfo._Where = context.StringValue("GetRule.RuleInfo.Where");
			ruleInfo.Status = context.StringValue("GetRule.RuleInfo.Status");
			ruleInfo.CreateUserId = context.LongValue("GetRule.RuleInfo.CreateUserId");
			ruleInfo.ProductKey = context.StringValue("GetRule.RuleInfo.ProductKey");
			ruleInfo.Name = context.StringValue("GetRule.RuleInfo.Name");
			ruleInfo.RuleDesc = context.StringValue("GetRule.RuleInfo.RuleDesc");
			ruleInfo.DataType = context.StringValue("GetRule.RuleInfo.DataType");
			ruleInfo.Created = context.StringValue("GetRule.RuleInfo.Created");
			ruleInfo.UtcCreated = context.StringValue("GetRule.RuleInfo.UtcCreated");
			ruleInfo.Modified = context.StringValue("GetRule.RuleInfo.Modified");
			ruleInfo.UtcModified = context.StringValue("GetRule.RuleInfo.UtcModified");
			ruleInfo.TopicType = context.IntegerValue("GetRule.RuleInfo.TopicType");
			getRuleResponse.RuleInfo = ruleInfo;
        
			return getRuleResponse;
        }
    }
}
