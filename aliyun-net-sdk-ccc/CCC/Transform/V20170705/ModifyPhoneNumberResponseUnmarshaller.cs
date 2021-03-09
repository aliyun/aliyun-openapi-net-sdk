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
        public static ModifyPhoneNumberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyPhoneNumberResponse modifyPhoneNumberResponse = new ModifyPhoneNumberResponse();

			modifyPhoneNumberResponse.HttpResponse = _ctx.HttpResponse;
			modifyPhoneNumberResponse.RequestId = _ctx.StringValue("ModifyPhoneNumber.RequestId");
			modifyPhoneNumberResponse.Success = _ctx.BooleanValue("ModifyPhoneNumber.Success");
			modifyPhoneNumberResponse.Code = _ctx.StringValue("ModifyPhoneNumber.Code");
			modifyPhoneNumberResponse.Message = _ctx.StringValue("ModifyPhoneNumber.Message");
			modifyPhoneNumberResponse.HttpStatusCode = _ctx.IntegerValue("ModifyPhoneNumber.HttpStatusCode");

			ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber phoneNumber = new ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber();
			phoneNumber.PhoneNumberId = _ctx.StringValue("ModifyPhoneNumber.PhoneNumber.PhoneNumberId");
			phoneNumber.InstanceId = _ctx.StringValue("ModifyPhoneNumber.PhoneNumber.InstanceId");
			phoneNumber.Number = _ctx.StringValue("ModifyPhoneNumber.PhoneNumber.Number");
			phoneNumber.PhoneNumberDescription = _ctx.StringValue("ModifyPhoneNumber.PhoneNumber.PhoneNumberDescription");
			phoneNumber.TestOnly = _ctx.BooleanValue("ModifyPhoneNumber.PhoneNumber.TestOnly");
			phoneNumber.RemainingTime = _ctx.IntegerValue("ModifyPhoneNumber.PhoneNumber.RemainingTime");
			phoneNumber.AllowOutbound = _ctx.BooleanValue("ModifyPhoneNumber.PhoneNumber.AllowOutbound");
			phoneNumber.Usage = _ctx.StringValue("ModifyPhoneNumber.PhoneNumber.Usage");
			phoneNumber.Trunks = _ctx.IntegerValue("ModifyPhoneNumber.PhoneNumber.Trunks");

			ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber.ModifyPhoneNumber_ContactFlow contactFlow = new ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber.ModifyPhoneNumber_ContactFlow();
			contactFlow.ContactFlowId = _ctx.StringValue("ModifyPhoneNumber.PhoneNumber.ContactFlow.ContactFlowId");
			contactFlow.InstanceId = _ctx.StringValue("ModifyPhoneNumber.PhoneNumber.ContactFlow.InstanceId");
			contactFlow.ContactFlowName = _ctx.StringValue("ModifyPhoneNumber.PhoneNumber.ContactFlow.ContactFlowName");
			contactFlow.ContactFlowDescription = _ctx.StringValue("ModifyPhoneNumber.PhoneNumber.ContactFlow.ContactFlowDescription");
			contactFlow.Type = _ctx.StringValue("ModifyPhoneNumber.PhoneNumber.ContactFlow.Type");
			phoneNumber.ContactFlow = contactFlow;

			List<ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber.ModifyPhoneNumber_SkillGroup> phoneNumber_skillGroups = new List<ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber.ModifyPhoneNumber_SkillGroup>();
			for (int i = 0; i < _ctx.Length("ModifyPhoneNumber.PhoneNumber.SkillGroups.Length"); i++) {
				ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber.ModifyPhoneNumber_SkillGroup skillGroup = new ModifyPhoneNumberResponse.ModifyPhoneNumber_PhoneNumber.ModifyPhoneNumber_SkillGroup();
				skillGroup.SkillGroupId = _ctx.StringValue("ModifyPhoneNumber.PhoneNumber.SkillGroups["+ i +"].SkillGroupId");
				skillGroup.SkillGroupName = _ctx.StringValue("ModifyPhoneNumber.PhoneNumber.SkillGroups["+ i +"].SkillGroupName");

				phoneNumber_skillGroups.Add(skillGroup);
			}
			phoneNumber.SkillGroups = phoneNumber_skillGroups;
			modifyPhoneNumberResponse.PhoneNumber = phoneNumber;
        
			return modifyPhoneNumberResponse;
        }
    }
}
