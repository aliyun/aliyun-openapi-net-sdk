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
    public class AddACLRuleResponseUnmarshaller
    {
        public static AddACLRuleResponse Unmarshall(UnmarshallerContext context)
        {
			AddACLRuleResponse addACLRuleResponse = new AddACLRuleResponse();

			addACLRuleResponse.HttpResponse = context.HttpResponse;
			addACLRuleResponse.RequestId = context.StringValue("AddACLRule.RequestId");
			addACLRuleResponse.AcrId = context.StringValue("AddACLRule.AcrId");
			addACLRuleResponse.AclId = context.StringValue("AddACLRule.AclId");
			addACLRuleResponse.Description = context.StringValue("AddACLRule.Description");
			addACLRuleResponse.Direction = context.StringValue("AddACLRule.Direction");
			addACLRuleResponse.SourceCidr = context.StringValue("AddACLRule.SourceCidr");
			addACLRuleResponse.DestCidr = context.StringValue("AddACLRule.DestCidr");
			addACLRuleResponse.IpProtocol = context.StringValue("AddACLRule.IpProtocol");
			addACLRuleResponse.SourcePortRange = context.StringValue("AddACLRule.SourcePortRange");
			addACLRuleResponse.DestPortRange = context.StringValue("AddACLRule.DestPortRange");
			addACLRuleResponse.Policy = context.StringValue("AddACLRule.Policy");
			addACLRuleResponse.Priority = context.IntegerValue("AddACLRule.Priority");
			addACLRuleResponse.GmtCreate = context.LongValue("AddACLRule.GmtCreate");
			addACLRuleResponse.Type = context.StringValue("AddACLRule.Type");
			addACLRuleResponse.Name = context.StringValue("AddACLRule.Name");
        
			return addACLRuleResponse;
        }
    }
}
