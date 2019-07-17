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
    public class ListSkillGroupsOfUserResponseUnmarshaller
    {
        public static ListSkillGroupsOfUserResponse Unmarshall(UnmarshallerContext context)
        {
			ListSkillGroupsOfUserResponse listSkillGroupsOfUserResponse = new ListSkillGroupsOfUserResponse();

			listSkillGroupsOfUserResponse.HttpResponse = context.HttpResponse;
			listSkillGroupsOfUserResponse.RequestId = context.StringValue("ListSkillGroupsOfUser.RequestId");
			listSkillGroupsOfUserResponse.Success = context.BooleanValue("ListSkillGroupsOfUser.Success");
			listSkillGroupsOfUserResponse.Code = context.StringValue("ListSkillGroupsOfUser.Code");
			listSkillGroupsOfUserResponse.Message = context.StringValue("ListSkillGroupsOfUser.Message");
			listSkillGroupsOfUserResponse.HttpStatusCode = context.IntegerValue("ListSkillGroupsOfUser.HttpStatusCode");

			List<ListSkillGroupsOfUserResponse.ListSkillGroupsOfUser_SkillLevel> listSkillGroupsOfUserResponse_skillLevels = new List<ListSkillGroupsOfUserResponse.ListSkillGroupsOfUser_SkillLevel>();
			for (int i = 0; i < context.Length("ListSkillGroupsOfUser.SkillLevels.Length"); i++) {
				ListSkillGroupsOfUserResponse.ListSkillGroupsOfUser_SkillLevel skillLevel = new ListSkillGroupsOfUserResponse.ListSkillGroupsOfUser_SkillLevel();
				skillLevel.SkillLevelId = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].SkillLevelId");
				skillLevel.Level = context.IntegerValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Level");

				ListSkillGroupsOfUserResponse.ListSkillGroupsOfUser_SkillLevel.ListSkillGroupsOfUser_Skill skill = new ListSkillGroupsOfUserResponse.ListSkillGroupsOfUser_SkillLevel.ListSkillGroupsOfUser_Skill();
				skill.SkillGroupId = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.SkillGroupId");
				skill.InstanceId = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.InstanceId");
				skill.SkillGroupName = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.SkillGroupName");
				skill.SkillGroupDescription = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.SkillGroupDescription");
				skill.RoutingStrategy = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.RoutingStrategy");

				List<ListSkillGroupsOfUserResponse.ListSkillGroupsOfUser_SkillLevel.ListSkillGroupsOfUser_Skill.ListSkillGroupsOfUser_PhoneNumber> skill_outboundPhoneNumbers = new List<ListSkillGroupsOfUserResponse.ListSkillGroupsOfUser_SkillLevel.ListSkillGroupsOfUser_Skill.ListSkillGroupsOfUser_PhoneNumber>();
				for (int j = 0; j < context.Length("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.OutboundPhoneNumbers.Length"); j++) {
					ListSkillGroupsOfUserResponse.ListSkillGroupsOfUser_SkillLevel.ListSkillGroupsOfUser_Skill.ListSkillGroupsOfUser_PhoneNumber phoneNumber = new ListSkillGroupsOfUserResponse.ListSkillGroupsOfUser_SkillLevel.ListSkillGroupsOfUser_Skill.ListSkillGroupsOfUser_PhoneNumber();
					phoneNumber.PhoneNumberId = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.OutboundPhoneNumbers["+ j +"].PhoneNumberId");
					phoneNumber.InstanceId = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.OutboundPhoneNumbers["+ j +"].InstanceId");
					phoneNumber.Number = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.OutboundPhoneNumbers["+ j +"].Number");
					phoneNumber.PhoneNumberDescription = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.OutboundPhoneNumbers["+ j +"].PhoneNumberDescription");
					phoneNumber.TestOnly = context.BooleanValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.OutboundPhoneNumbers["+ j +"].TestOnly");
					phoneNumber.RemainingTime = context.IntegerValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.OutboundPhoneNumbers["+ j +"].RemainingTime");
					phoneNumber.AllowOutbound = context.BooleanValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.OutboundPhoneNumbers["+ j +"].AllowOutbound");
					phoneNumber.Usage = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.OutboundPhoneNumbers["+ j +"].Usage");
					phoneNumber.Trunks = context.IntegerValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.OutboundPhoneNumbers["+ j +"].Trunks");
					phoneNumber.Province = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.OutboundPhoneNumbers["+ j +"].Province");
					phoneNumber.City = context.StringValue("ListSkillGroupsOfUser.SkillLevels["+ i +"].Skill.OutboundPhoneNumbers["+ j +"].City");

					skill_outboundPhoneNumbers.Add(phoneNumber);
				}
				skill.OutboundPhoneNumbers = skill_outboundPhoneNumbers;
				skillLevel.Skill = skill;

				listSkillGroupsOfUserResponse_skillLevels.Add(skillLevel);
			}
			listSkillGroupsOfUserResponse.SkillLevels = listSkillGroupsOfUserResponse_skillLevels;
        
			return listSkillGroupsOfUserResponse;
        }
    }
}
