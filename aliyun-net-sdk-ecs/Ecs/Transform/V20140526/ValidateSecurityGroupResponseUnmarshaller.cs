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
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class ValidateSecurityGroupResponseUnmarshaller
    {
        public static ValidateSecurityGroupResponse Unmarshall(UnmarshallerContext context)
        {
			ValidateSecurityGroupResponse validateSecurityGroupResponse = new ValidateSecurityGroupResponse();

			validateSecurityGroupResponse.HttpResponse = context.HttpResponse;
			validateSecurityGroupResponse.RequestId = context.StringValue("ValidateSecurityGroup.RequestId");
			validateSecurityGroupResponse.Policy = context.StringValue("ValidateSecurityGroup.Policy");

			ValidateSecurityGroupResponse.ValidateSecurityGroup_TriggeredGroupRule triggeredGroupRule = new ValidateSecurityGroupResponse.ValidateSecurityGroup_TriggeredGroupRule();
			triggeredGroupRule.IpProtocol = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.IpProtocol");
			triggeredGroupRule.PortRange = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.PortRange");
			triggeredGroupRule.SourceGroupId = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.SourceGroupId");
			triggeredGroupRule.SourceGroupName = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.SourceGroupName");
			triggeredGroupRule.SourceCidrIp = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.SourceCidrIp");
			triggeredGroupRule.Policy = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.Policy");
			triggeredGroupRule.NicType = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.NicType");
			triggeredGroupRule.SourceGroupOwnerAccount = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.SourceGroupOwnerAccount");
			triggeredGroupRule.DestGroupId = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.DestGroupId");
			triggeredGroupRule.DestGroupName = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.DestGroupName");
			triggeredGroupRule.DestCidrIp = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.DestCidrIp");
			triggeredGroupRule.DestGroupOwnerAccount = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.DestGroupOwnerAccount");
			triggeredGroupRule.Priority = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.Priority");
			triggeredGroupRule.Direction = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.Direction");
			triggeredGroupRule.Description = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.Description");
			triggeredGroupRule.CreateTime = context.StringValue("ValidateSecurityGroup.TriggeredGroupRule.CreateTime");
			validateSecurityGroupResponse.TriggeredGroupRule = triggeredGroupRule;
        
			return validateSecurityGroupResponse;
        }
    }
}