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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class PublishRuleResponseUnmarshaller
    {
        public static PublishRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PublishRuleResponse publishRuleResponse = new PublishRuleResponse();

			publishRuleResponse.HttpResponse = _ctx.HttpResponse;
			publishRuleResponse.RequestId = _ctx.StringValue("PublishRule.requestId");
			publishRuleResponse.Code = _ctx.StringValue("PublishRule.code");
			publishRuleResponse.Message = _ctx.StringValue("PublishRule.message");

			PublishRuleResponse.PublishRule_Result result = new PublishRuleResponse.PublishRule_Result();
			result.RuleId = _ctx.StringValue("PublishRule.Result.ruleId");
			publishRuleResponse.Result = result;
        
			return publishRuleResponse;
        }
    }
}
