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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ModifyPhoneNumberResponseUnmarshaller
    {
        public static ModifyPhoneNumberResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyPhoneNumberResponse modifyPhoneNumberResponse = new ModifyPhoneNumberResponse();

			modifyPhoneNumberResponse.HttpResponse = context.HttpResponse;
			modifyPhoneNumberResponse.RequestId = context.StringValue("ModifyPhoneNumber.RequestId");
			modifyPhoneNumberResponse.Success = context.BooleanValue("ModifyPhoneNumber.Success");
			modifyPhoneNumberResponse.Code = context.StringValue("ModifyPhoneNumber.Code");
			modifyPhoneNumberResponse.Message = context.StringValue("ModifyPhoneNumber.Message");
			modifyPhoneNumberResponse.HttpStatusCode = context.IntegerValue("ModifyPhoneNumber.HttpStatusCode");

			ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber phoneNumber = new ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber();
			phoneNumber.PhoneNumberId = context.StringValue("ModifyPhoneNumber.PhoneNumber.PhoneNumberId");
			phoneNumber.InstanceId = context.StringValue("ModifyPhoneNumber.PhoneNumber.InstanceId");
			phoneNumber.Number = context.StringValue("ModifyPhoneNumber.PhoneNumber.Number");
			phoneNumber.PhoneNumberDescription = context.StringValue("ModifyPhoneNumber.PhoneNumber.PhoneNumberDescription");
			phoneNumber.TestOnly = context.BooleanValue("ModifyPhoneNumber.PhoneNumber.TestOnly");
			phoneNumber.RemainingTime = context.IntegerValue("ModifyPhoneNumber.PhoneNumber.RemainingTime");
			phoneNumber.AllowOutbound = context.BooleanValue("ModifyPhoneNumber.PhoneNumber.AllowOutbound");
			phoneNumber.Usage = context.StringValue("ModifyPhoneNumber.PhoneNumber.Usage");
			phoneNumber.Trunks = context.IntegerValue("ModifyPhoneNumber.PhoneNumber.Trunks");

			ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber.ModifyPhoneNumber_ContactFlow contactFlow = new ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber.ModifyPhoneNumber_ContactFlow();
			contactFlow.ContactFlowId = context.StringValue("ModifyPhoneNumber.PhoneNumber.ContactFlow.ContactFlowId");
			contactFlow.InstanceId = context.StringValue("ModifyPhoneNumber.PhoneNumber.ContactFlow.InstanceId");
			contactFlow.ContactFlowName = context.StringValue("ModifyPhoneNumber.PhoneNumber.ContactFlow.ContactFlowName");
			contactFlow.ContactFlowDescription = context.StringValue("ModifyPhoneNumber.PhoneNumber.ContactFlow.ContactFlowDescription");
			contactFlow.Type = context.StringValue("ModifyPhoneNumber.PhoneNumber.ContactFlow.Type");
			phoneNumber.ContactFlow = contactFlow;

			List<ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber.ModifyPhoneNumber_SkillGroup> phoneNumber_skillGroups = new List<ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber.ModifyPhoneNumber_SkillGroup>();
			for (int i = 0; i < context.Length("ModifyPhoneNumber.PhoneNumber.SkillGroups.Length"); i++) {
				ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber.ModifyPhoneNumber_SkillGroup skillGroup = new ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber.ModifyPhoneNumber_SkillGroup();
				skillGroup.SkillGroupId = context.StringValue("ModifyPhoneNumber.PhoneNumber.SkillGroups["+ i +"].SkillGroupId");
				skillGroup.SkillGroupName = context.StringValue("ModifyPhoneNumber.PhoneNumber.SkillGroups["+ i +"].SkillGroupName");

				phoneNumber_skillGroups.Add(skillGroup);
			}
			phoneNumber.SkillGroups = phoneNumber_skillGroups;
			modifyPhoneNumberResponse.PhoneNumber = phoneNumber;
        
			return modifyPhoneNumberResponse;
        }
    }
}
