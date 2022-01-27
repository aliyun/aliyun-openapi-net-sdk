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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class ModifySchedulerRuleResponseUnmarshaller
    {
        public static ModifySchedulerRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifySchedulerRuleResponse modifySchedulerRuleResponse = new ModifySchedulerRuleResponse();

			modifySchedulerRuleResponse.HttpResponse = _ctx.HttpResponse;
			modifySchedulerRuleResponse.RequestId = _ctx.StringValue("ModifySchedulerRule.RequestId");
			modifySchedulerRuleResponse.Cname = _ctx.StringValue("ModifySchedulerRule.Cname");
			modifySchedulerRuleResponse.RuleName = _ctx.StringValue("ModifySchedulerRule.RuleName");
        
			return modifySchedulerRuleResponse;
        }
    }
}
