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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class ModifyACLRuleResponseUnmarshaller
    {
        public static ModifyACLRuleResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyACLRuleResponse modifyACLRuleResponse = new ModifyACLRuleResponse();

			modifyACLRuleResponse.HttpResponse = context.HttpResponse;
			modifyACLRuleResponse.RequestId = context.StringValue("ModifyACLRule.RequestId");
			modifyACLRuleResponse.AcrId = context.StringValue("ModifyACLRule.AcrId");
			modifyACLRuleResponse.AclId = context.StringValue("ModifyACLRule.AclId");
			modifyACLRuleResponse.Description = context.StringValue("ModifyACLRule.Description");
			modifyACLRuleResponse.Direction = context.StringValue("ModifyACLRule.Direction");
			modifyACLRuleResponse.SourceCidr = context.StringValue("ModifyACLRule.SourceCidr");
			modifyACLRuleResponse.DestCidr = context.StringValue("ModifyACLRule.DestCidr");
			modifyACLRuleResponse.IpProtocol = context.StringValue("ModifyACLRule.IpProtocol");
			modifyACLRuleResponse.SourcePortRange = context.StringValue("ModifyACLRule.SourcePortRange");
			modifyACLRuleResponse.DestPortRange = context.StringValue("ModifyACLRule.DestPortRange");
			modifyACLRuleResponse.Policy = context.StringValue("ModifyACLRule.Policy");
			modifyACLRuleResponse.Priority = context.IntegerValue("ModifyACLRule.Priority");
			modifyACLRuleResponse.GmtCreate = context.LongValue("ModifyACLRule.GmtCreate");
			modifyACLRuleResponse.Name = context.StringValue("ModifyACLRule.Name");
        
			return modifyACLRuleResponse;
        }
    }
}
