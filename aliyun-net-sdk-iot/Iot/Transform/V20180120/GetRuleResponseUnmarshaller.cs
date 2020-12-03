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
        public static GetRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRuleResponse getRuleResponse = new GetRuleResponse();

			getRuleResponse.HttpResponse = _ctx.HttpResponse;
			getRuleResponse.RequestId = _ctx.StringValue("GetRule.RequestId");
			getRuleResponse.Success = _ctx.BooleanValue("GetRule.Success");
			getRuleResponse.Code = _ctx.StringValue("GetRule.Code");
			getRuleResponse.ErrorMessage = _ctx.StringValue("GetRule.ErrorMessage");

			GetRuleResponse.GetRule_RuleInfo ruleInfo = new GetRuleResponse.GetRule_RuleInfo();
			ruleInfo.Id = _ctx.LongValue("GetRule.RuleInfo.Id");
			ruleInfo.Select = _ctx.StringValue("GetRule.RuleInfo.Select");
			ruleInfo.Topic = _ctx.StringValue("GetRule.RuleInfo.Topic");
			ruleInfo.ShortTopic = _ctx.StringValue("GetRule.RuleInfo.ShortTopic");
			ruleInfo._Where = _ctx.StringValue("GetRule.RuleInfo.Where");
			ruleInfo.Status = _ctx.StringValue("GetRule.RuleInfo.Status");
			ruleInfo.CreateUserId = _ctx.LongValue("GetRule.RuleInfo.CreateUserId");
			ruleInfo.ProductKey = _ctx.StringValue("GetRule.RuleInfo.ProductKey");
			ruleInfo.Name = _ctx.StringValue("GetRule.RuleInfo.Name");
			ruleInfo.RuleDesc = _ctx.StringValue("GetRule.RuleInfo.RuleDesc");
			ruleInfo.DataType = _ctx.StringValue("GetRule.RuleInfo.DataType");
			ruleInfo.Created = _ctx.StringValue("GetRule.RuleInfo.Created");
			ruleInfo.UtcCreated = _ctx.StringValue("GetRule.RuleInfo.UtcCreated");
			ruleInfo.Modified = _ctx.StringValue("GetRule.RuleInfo.Modified");
			ruleInfo.UtcModified = _ctx.StringValue("GetRule.RuleInfo.UtcModified");
			ruleInfo.TopicType = _ctx.IntegerValue("GetRule.RuleInfo.TopicType");
			getRuleResponse.RuleInfo = ruleInfo;
        
			return getRuleResponse;
        }
    }
}
