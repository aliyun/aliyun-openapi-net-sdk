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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class GenerateTemplatePolicyResponseUnmarshaller
    {
        public static GenerateTemplatePolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GenerateTemplatePolicyResponse generateTemplatePolicyResponse = new GenerateTemplatePolicyResponse();

			generateTemplatePolicyResponse.HttpResponse = _ctx.HttpResponse;
			generateTemplatePolicyResponse.RequestId = _ctx.StringValue("GenerateTemplatePolicy.RequestId");

			GenerateTemplatePolicyResponse.GenerateTemplatePolicy_Policy policy = new GenerateTemplatePolicyResponse.GenerateTemplatePolicy_Policy();
			policy.Version = _ctx.StringValue("GenerateTemplatePolicy.Policy.Version");

			List<GenerateTemplatePolicyResponse.GenerateTemplatePolicy_Policy.GenerateTemplatePolicy_StatementItem> policy_statement = new List<GenerateTemplatePolicyResponse.GenerateTemplatePolicy_Policy.GenerateTemplatePolicy_StatementItem>();
			for (int i = 0; i < _ctx.Length("GenerateTemplatePolicy.Policy.Statement.Length"); i++) {
				GenerateTemplatePolicyResponse.GenerateTemplatePolicy_Policy.GenerateTemplatePolicy_StatementItem statementItem = new GenerateTemplatePolicyResponse.GenerateTemplatePolicy_Policy.GenerateTemplatePolicy_StatementItem();
				statementItem.Resource = _ctx.StringValue("GenerateTemplatePolicy.Policy.Statement["+ i +"].Resource");
				statementItem.Effect = _ctx.StringValue("GenerateTemplatePolicy.Policy.Statement["+ i +"].Effect");

				List<string> statementItem_action = new List<string>();
				for (int j = 0; j < _ctx.Length("GenerateTemplatePolicy.Policy.Statement["+ i +"].Action.Length"); j++) {
					statementItem_action.Add(_ctx.StringValue("GenerateTemplatePolicy.Policy.Statement["+ i +"].Action["+ j +"]"));
				}
				statementItem.Action = statementItem_action;

				policy_statement.Add(statementItem);
			}
			policy.Statement = policy_statement;
			generateTemplatePolicyResponse.Policy = policy;
        
			return generateTemplatePolicyResponse;
        }
    }
}
